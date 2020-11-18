

window.jsEmbed = {
    runRemoteJs: function(sourceUrl, onload, nonce) {
        (function (d, script) {
            script = d.createElement('script');
            script.type = 'text/javascript';
            script.async = true;
            if (nonce)
                script.nonce = nonce;
            script.onload = function () {
                if (onload)
                    onload();
            };
            script.src = sourceUrl;
            d.getElementsByTagName('head')[0].appendChild(script);
        }(document));
    }

}
