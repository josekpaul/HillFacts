using AutoMapper;
using ProPublicaCongressAPI.Resolvers;
using System;

namespace ProPublicaCongressAPI
{
    internal static class AutoMapperConfiguration
    {
        private static bool isInitialized = false;
        private static MapperConfiguration config;
        private static IMapper mapper;

        public static IMapper Mapper { get { return mapper; } }

        public static void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            if (config == null)
            {
                config = new MapperConfiguration(x =>
                {
                    x.CreateMap<InternalModels.MemberSummary, Contracts.MemberSummary>()
                        .ForMember(dest => dest.FacebookId, opts => opts.Ignore()); 
                    x.CreateMap<InternalModels.MembersContainer, Contracts.MembersContainer>();

                    x.CreateMap<InternalModels.MemberCommittee, Contracts.MemberCommittee>();
                    x.CreateMap<InternalModels.MemberRole, Contracts.MemberRole>();
                    x.CreateMap<InternalModels.Member, Contracts.Member>()
                        .ForMember(dest => dest.ThomasId, opts => opts.Ignore())
                        .ForMember(dest => dest.FacebookId, opts => opts.Ignore());

                    x.CreateMap<InternalModels.NewMember, Contracts.NewMember>();
                    x.CreateMap<InternalModels.NewMembersContainer, Contracts.NewMembersContainer>();

                    x.CreateMap<InternalModels.CurrentMember, Contracts.CurrentMember>();

                    x.CreateMap<InternalModels.MemberVoteBill, Contracts.MemberVoteBill>();
                    x.CreateMap<InternalModels.MemberVote, Contracts.MemberVote>()
                        .ForMember(dest => dest.DateTimeVoted, opts => opts.MapFrom((source, dest) =>
                        {
                            return CreateDateTimeFromDateAndTime(source.DateVoted, source.TimeVoted);
                        }));
                    x.CreateMap<InternalModels.MemberVotesContainer, Contracts.MemberVotesContainer>();

                    x.CreateMap<InternalModels.MemberVoteComparison, Contracts.MemberVoteComparison>();

                    x.CreateMap<InternalModels.MemberBillSponsorshipComparison, Contracts.MemberBillSponsorshipComparison>();
                    x.CreateMap<InternalModels.MemberBillSponsorshipComparisonContainer, Contracts.MemberBillSponsorshipComparisonContainer>();

                    x.CreateMap<InternalModels.MemberBillCosponsored, Contracts.MemberBillCosponsored>();
                    x.CreateMap<InternalModels.MemberBillsCosponsoredContainer, Contracts.MemberBillsCosponsoredContainer>();

                    x.CreateMap<InternalModels.RollCallVotePosition, Contracts.RollCallVotePosition>();
                    x.CreateMap<InternalModels.RollCallVote, Contracts.RollCallVote>()
                        .ForMember(dest => dest.DateTimeRollCall, opts => opts.MapFrom((source, dest) =>
                        {
                            return CreateDateTimeFromDateAndTime(source.DateRollCall, source.TimeRollCall);
                        }));
                    x.CreateMap<InternalModels.RollCallVoteSummaryDemocratic, Contracts.RollCallVoteSummaryDemocratic>();
                    x.CreateMap<InternalModels.RollCallVoteSummaryRepublican, Contracts.RollCallVoteSummaryRepublican>();
                    x.CreateMap<InternalModels.RollCallVoteSummaryIndependent, Contracts.RollCallVoteSummaryIndependent>();
                    x.CreateMap<InternalModels.RollCallVoteSummaryTotal, Contracts.RollCallVoteSummaryTotal>();
                    x.CreateMap<InternalModels.RollCallVoteContainer, Contracts.RollCallVoteContainer>();
                    x.CreateMap<InternalModels.RollCallVotesContainer, Contracts.RollCallVotesContainer>();

                    x.CreateMap<InternalModels.VoteByTypeMember, Contracts.VoteByTypeMember>();
                    x.CreateMap<InternalModels.VoteByTypeContainer, Contracts.VoteByTypeContainer>();

                    x.CreateMap<InternalModels.VoteByDate, Contracts.VoteByDate>()
                        .ForMember(dest => dest.DateTimeVoted, opts => opts.MapFrom((source, dest) =>
                        {
                            return CreateDateTimeFromDateAndTime(source.DateVoted, source.TimeVoted);
                        }));
                    x.CreateMap<InternalModels.VoteBill, Contracts.VoteBill>();
                    x.CreateMap<InternalModels.VoteNomination, Contracts.VoteNomination>();
                    x.CreateMap<InternalModels.VoteByDateContainer, Contracts.VoteByDateContainer>();

                    x.CreateMap<InternalModels.SenateNominationVote, Contracts.SenateNominationVote>()
                        .ForMember(dest => dest.DateTimeVoted, opts => opts.MapFrom((source, dest) =>
                        {
                            return CreateDateTimeFromDateAndTime(source.DateVoted, source.TimeVoted);
                        }));
                    x.CreateMap<InternalModels.SenateNominationVoteContainer, Contracts.SenateNominationVoteContainer>();

                    x.CreateMap<InternalModels.RecentBill, Contracts.RecentBill>()
                        .ForMember(dest => dest.DateIntroduced,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateIntroduced))
                        .ForMember(dest => dest.Enacted,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.Enacted))
                        .ForMember(dest => dest.Vetoed,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.Vetoed))
                        .ForMember(dest => dest.DateLatestMajorAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestMajorAction));
                    x.CreateMap<InternalModels.RecentBillsContainer, Contracts.RecentBillsContainer>();

                    x.CreateMap<InternalModels.RecentBillByMember, Contracts.RecentBillByMember>()
                        .ForMember(dest => dest.DateIntroduced,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateIntroduced))
                        .ForMember(dest => dest.DateLatestMajorAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestMajorAction));
                    x.CreateMap<InternalModels.RecentBillsByMemberContainer, Contracts.RecentBillsByMemberContainer>();

                    x.CreateMap<InternalModels.SpecificBillVoteSummary, Contracts.SpecificBillVoteSummary>()
                        .ForMember(dest => dest.DateTimeVoted, opts => opts.MapFrom((source, dest) =>
                        {
                            return CreateDateTimeFromDateAndTime(source.DateVoted, source.TimeVoted);
                        }));

                    x.CreateMap<InternalModels.SpecificBillAction, Contracts.SpecificBillAction>()
                        .ForMember(dest => dest.DateTimeOccurred,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateTimeOccurred))
                        .ForMember(dest => dest.Chamber,
                            opts => opts.MapFrom<ChamberResolver, string>(s => s.Chamber));

                    x.CreateMap<InternalModels.SpecificBill, Contracts.SpecificBill>()
                        .ForMember(dest => dest.DateIntroduced,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateIntroduced))
                        .ForMember(dest => dest.DateLastVote,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateLastVote))
                        .ForMember(dest => dest.DateHousePassage,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateHousePassage))
                        .ForMember(dest => dest.DateSenatePassage,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateSenatePassage))
                        .ForMember(dest => dest.DateHousePassageVote,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateHousePassageVote))
                        .ForMember(dest => dest.DateSenatePassageVote,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateSenatePassageVote))
                        .ForMember(dest => dest.Enacted,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.Enacted))
                        .ForMember(dest => dest.Vetoed,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.Vetoed))
                        .ForMember(dest => dest.DateLatestMajorAction, 
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestMajorAction));

                    x.CreateMap<InternalModels.SpecificBillDetailRelated, Contracts.SpecificBillDetailRelated>()
                        .ForMember(dest => dest.DateIntroduced,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateIntroduced))
                        .ForMember(dest => dest.DateLatestMajorAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestMajorAction));
                    x.CreateMap<InternalModels.SpecificBillDetailSubject, Contracts.SpecificBillDetailSubject>();
                    x.CreateMap<InternalModels.SpecificBillDetail, Contracts.SpecificBillDetail>()
                        .ForMember(dest => dest.DateIntroduced,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateIntroduced))
                        .ForMember(dest => dest.DateHousePassageVote,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateHousePassageVote))
                        .ForMember(dest => dest.DateLatestMajorAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestMajorAction))
                        .ForMember(dest => dest.DateSenatePassageVote,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateSenatePassageVote));

                    x.CreateMap<InternalModels.AmendmentsContainer, Contracts.AmendmentsContainer>();
                    x.CreateMap<InternalModels.Amendment, Contracts.Amendment>()
                        .ForMember(dest => dest.DateIntroduced,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateIntroduced))
                        .ForMember(dest => dest.DateLatestMajorAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestMajorAction));

                    x.CreateMap<InternalModels.BillCosponsor, Contracts.BillCosponsor>()
                        .ForMember(dest => dest.DateCosponsored,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateCosponsored));
                    x.CreateMap<InternalModels.BillCosponsorPartySummary, Contracts.BillCosponsorPartySummary>();
                    x.CreateMap<InternalModels.BillCosponsorContainer, Contracts.BillCosponsorContainer>()
                        .ForMember(dest => dest.DateIntroduced,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateIntroduced))
                        .ForMember(dest => dest.DateHousePassageVote,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateHousePassageVote))
                        .ForMember(dest => dest.DateLatestMajorAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestMajorAction))
                        .ForMember(dest => dest.DateSenatePassageVote,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateSenatePassageVote));

                    x.CreateMap<InternalModels.RecentNomination, Contracts.RecentNomination>()
                        .ForMember(dest => dest.DateLatestAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestAction))
                        .ForMember(dest => dest.DateReceived,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateReceived));

                    x.CreateMap<InternalModels.SpecificNominationAction, Contracts.SpecificNominationAction>()
                        .ForMember(dest => dest.DateAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateAction));
                    x.CreateMap<InternalModels.SpecificNominationVote, Contracts.SpecificNominationVote>()
                        .ForMember(dest => dest.DateVote,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateVote));
                    x.CreateMap<InternalModels.SpecificNomination, Contracts.SpecificNomination>()
                        .ForMember(dest => dest.DateReceived,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateReceived))
                        .ForMember(dest => dest.DateLatestAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestAction));
                            
                    x.CreateMap<InternalModels.NomineeByState, Contracts.NomineeByState>()
                        .ForMember(dest => dest.DateLatestAction,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateLatestAction))
                        .ForMember(dest => dest.DateReceived,
                            opts => opts.MapFrom<DateTimeResolver, string>(s => s.DateReceived));

                    x.CreateMap<InternalModels.Committee, Contracts.Committee>();
                    x.CreateMap<InternalModels.CommitteesContainer, Contracts.CommitteesContainer>();

                    x.CreateMap<InternalModels.LobbyingRepresentation, Contracts.LobbyingRepresentation>();
                    x.CreateMap<InternalModels.Lobbyist, Contracts.Lobbyist>();
                    x.CreateMap<InternalModels.LatestFiling, Contracts.LatestFiling>();
                    x.CreateMap<InternalModels.LobbyingRegistrant, Contracts.LobbyingRegistrant>();
                    x.CreateMap<InternalModels.LobbyingClient, Contracts.LobbyingClient>();
                    x.CreateMap<InternalModels.Result, Contracts.Result>();


                    x.CreateMap<InternalModels.SpecificCommittee, Contracts.SpecificCommittee>();
                    x.CreateMap<InternalModels.SpecificCommitteeMember, Contracts.SpecificCommitteeMember>()
                        .ForMember(dest => dest.DateStarted,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateStarted))
                        .ForMember(dest => dest.DateEnded,
                            opts => opts.MapFrom<NullableDateTimeResolver, string>(s => s.DateEnded));
                });
            }

            if (mapper == null)
            {
                mapper = config.CreateMapper();
            }

            isInitialized = true;

#if DEBUG
            config.AssertConfigurationIsValid();
#endif
        }

        private static DateTime CreateDateTimeFromDateAndTime(string date, string time)
        {
            string rawDateTime = date;

            if (!String.IsNullOrWhiteSpace(time))
            {
                rawDateTime += " " + time;
            }

            DateTime parsedDateTime;
            DateTime.TryParse(rawDateTime, out parsedDateTime);

            return parsedDateTime;
        }

        public static void Reset()
        {
            config = null;
            mapper = null;
        }
    }
}