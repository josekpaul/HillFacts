window.d3VisualizationFunctions = {
	drawTreemap: function (data, elem) {
		var stringToColour = function (str) {
			var hash = 0;
			for (var i = 0; i < str.length; i++) {
				hash = str.charCodeAt(i) + ((hash << 5) - hash);
			}
			var colour = '#';
			for (var i = 0; i < 3; i++) {
				var value = (hash >> (i * 8)) & 0xFF;
				colour += ('00' + value.toString(16)).substr(-2);
			}
			return colour;
		}

		d3Selection = d3.select(elem).html("");
		var w = d3Selection.node().getBoundingClientRect().width;
		var margin = { top: 10, right: 10, bottom: 10, left: 10 },
			width = w,
			height = w;
		// append the svg object to the body of the page
		var svg = d3Selection
			.append("svg")
			.attr("width", width + margin.left + margin.right)
			.attr("height", height + margin.top + margin.bottom)
			.append("g")
			.attr("transform",
				"translate(" + margin.left + "," + margin.top + ")");

		// Give the data to this cluster layout:
		var root = d3.hierarchy(data).sum(function (d) { return d.value }) // Here the size of each leave is given in the 'value' field in input data

		// Then d3.treemap computes the position of each element of the hierarchy
		d3.treemap()
			.size([width, height])
			.paddingTop(28)
			.paddingRight(7)
			.paddingInner(3)      // Padding between each rectangle
			//.paddingOuter(6)
			//.padding(20)
			(root)

		// prepare a color scale
		var color = d3.scaleOrdinal()
			.domain(["boss1", "boss2", "boss3"])
			.range(["#402D54", "#D18975", "#8FD175"])

		// And a opacity scale
		var opacity = d3.scaleLinear()
			.domain([10, 30])
			.range([.5, 1])

		// use this information to add rectangles:
		svg
			.selectAll("rect")
			.data(root.leaves())
			.enter()
			.append("rect")
			.attr('x', function (d) { return d.x0; })
			.attr('y', function (d) { return d.y0; })
			.attr('width', function (d) { return d.x1 - d.x0; })
			.attr('height', function (d) { return d.y1 - d.y0; })
			.style("stroke", "black")
			.style("fill", function (d) { return stringToColour(d.parent.data.name) })
			.style("opacity", function (d) { return opacity(d.data.value) })

		// and to add the text labels
		svg
			.selectAll("text")
			.data(root.leaves())
			.enter()
			.append("text")
			.attr("x", function (d) { return d.x0 + 5 })    // +10 to adjust position (more right)
			.attr("y", function (d) { return d.y0 + 20 })    // +20 to adjust position (lower)
			.text(function (d) { return (d.data.name) })
			.attr("font-size", "19px")
			.attr("fill", "white")

		// and to add the text labels
		svg
			.selectAll("vals")
			.data(root.leaves())
			.enter()
			.append("text")
			.attr("x", function (d) { return d.x0 + 5 })    // +10 to adjust position (more right)
			.attr("y", function (d) { return d.y0 + 35 })    // +20 to adjust position (lower)
			.text(function (d) { return d.data.value })
			.attr("font-size", "11px")
			.attr("fill", "black")

		// Add title for the 3 groups
		svg
			.selectAll("titles")
			.data(root.descendants().filter(function (d) { return d.depth == 1 }))
			.enter()
			.append("text")
			.attr("x", function (d) { return d.x0 })
			.attr("y", function (d) { return d.y0 + 21 })
			.text(function (d) { return d.data.name })
			.attr("font-size", "19px")
			.attr("fill", function (d) { return stringToColour(d.data.name) })

		// Add title for the 3 groups
		svg
			.append("text")
			.attr("x", 0)
			.attr("y", 14)    // +20 to adjust position (lower)
			.text("Three group leaders and 14 employees")
			.attr("font-size", "19px")
			.attr("fill", "grey")
	},

	drawStackedColumnChart: function (dataTable, categoryColumn, elem, dotnetRef, callbackFn) {

		const d3Selection = d3.select(elem).html("");
		d3Selection.selectAll("*").remove();
		const w = d3Selection.node().getBoundingClientRect().width;

		// set the dimensions and margins of the graph
		const margin = { top: 10, right: 30, bottom: 20, left: 50 },
			width = w - margin.left - margin.right,
			height = Math.ceil(w / 1.64) - margin.top - margin.bottom;

		// append the svg object to the body of the page

		const data = d3.csvParse(dataTable, d3.autoType);

		const series = d3.stack().keys(data.columns.slice(1))(data);

		const Tooltip = d3Selection
			.append("div")
			.style("opacity", 0)
			.style("position","absolute")
			.attr("class", "tooltip")
			.style("background-color", "white")
			.style("border", "solid")
			.style("border-width", "2px")
			.style("border-radius", "5px")
			.style("padding", "5px");

		const svg = d3Selection
			.append("svg")
			.attr("width", width + margin.left + margin.right)
			.attr("height", height + margin.top + margin.bottom);

		const gSvg = svg.append("g")
			.attr("transform", "translate(" + margin.left + "," + margin.top + ")");

		const xScale = d3.scaleBand()
			.domain(data.map(function (d) { return d[categoryColumn]; }))
			.range([0, width])
			.padding(0.1);

		const yScale = d3.scaleLinear()
			.domain([0, d3.max(series, d => d3.max(d, d => d[1]))])
			.range([height, 0]);

		const color = d3.scaleOrdinal(d3.schemeCategory10);

		const rects = gSvg.selectAll("g").data(series).enter()
			.append("g")
			.attr("fill", function (d) {
				return color(d.key);
			});
		rects.selectAll("rect")
			.data(function (d) {
				return d;
			})
			.join("rect")
			.attr("x", (d, i) => xScale(d.data[categoryColumn]))
			.attr("y", d => yScale(d[1]))
			.attr("height", d => yScale(d[0]) - yScale(d[1]))
			.attr("width", xScale.bandwidth())
			.style("opacity", 0.8)
			.style("stroke", "grey")
			.on("mouseover", function (event, d) {
				Tooltip
					.style("opacity", 1)
				d3.select(this)
					.style("opacity", 1);
			})
			.on("mousemove", function (event, d) {
				Tooltip
					.html((d[1] - d[0]) + " " + d3.select(this.parentNode).datum().key)
					.style("left", (event.pageX + "px"))
					.style("top", ((event.pageY + 5) + "px"));
			})
			.on("mouseleave", function (event, d) {
				Tooltip
					.style("opacity", 0)
				d3.select(this)
					.style("opacity", 0.8);
			}).
			on("click", function (event, d) {
				dotnetRef.invokeMethodAsync(callbackFn, d[categoryColumn] + "|" + d3.select(this.parentNode).datum().key);
			});
    /*.on("mouseover", function(){d3.select(this).attr("fill", "purple")})
    .on("mouseout", function(){d3.select(this).attr("fill", color(series.key))})*/;

		const xAxis = gSvg.append("g")
			.attr("id", "xAxis")
			.attr("transform", "translate(0," + height + ")")
			.call(d3.axisBottom(xScale));

		const yAxis = gSvg.append("g")
			.attr("id", "yAxis")
			.call(d3.axisLeft(yScale));
  }
}

