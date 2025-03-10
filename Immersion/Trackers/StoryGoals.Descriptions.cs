using Story;

namespace Immersion.Trackers;

partial class StoryGoals
{
    private record Description(string Message, bool IsImportant = false)
    {
        public Priority Priority => IsImportant ? Priority.High : Priority.Low;
        public static implicit operator Description(string Message) => new(Message);
    }
    private static readonly Dictionary<string, Description> StoryGoalDescriptions = new(StoryGoal.KeyComparer)
    {
        // sorted roughly in story order

        // substitutions:
        //  {player} - player name
        // pronouns
        /// <see cref="Formatting.PronounSet"/>
        //  {subject} - e.g. "he"
        //  {object} - e.g. "him"
        //  {possessive} - "his"
        //  {is} - contraction of "X is" (e.g. "they're")
        //  {has} - contraction of "X has" (e.g. "they've")
        //  {reflexive} - "himself"

        // this is way more goals than we're actually going to use
        // TODO: go through and pick the ones we want
        #region Intro/Download
        ["IntroComplete"] = new("{player} has crash landed in a frozen valley on planet 4546B.", true),
        // ["TwistyBridgesSOS"] = null, // first time SOS
        // ["OnEnterSanctuary"] = null, // triggers dialogue
        // ["SanctuaryCaveComplete"] = null, // finished entrance dialogue
        // ["OnEnterSanctuaryCubeRoom"] = null, // dialogue
        // ["StartApproachingCube"] = null, // dialogue
        // ["AlanDownloadBlackout"] = null,
        // despite this being a very very important goal, it's triggered in the middle of a cutscene
        // so we don't actually get a chance to react to it
        ["SanctuaryCompleted"] = new("{player} has downloaded an alien Architect's consciousness into {possessive} head.", true),
        // ["DisableSanctuaryForceField"] = null, // disabled forcefields on places w/ precursor body parts
        // despite having "AfterDownload" in its name, this just triggers when you exit regardless of whether you have SanctuaryCompleted or not
        // ["SanctuaryExitAfterDownload"] = null,

        // ["Call_AlAn_Meet"] = null,
        // ["Body"] = "{player} must collect three blueprints to construct an Architect body.",
        #endregion Intro/Download

        #region Main story
        // ["TellPrecursorArtifact1"] = null, // gives first signal
        // ["VisitArtifact1"] = null,
        // etc for the rest of the artifacts
        // ["Log_Alan_Body_Request"] = null,
        // ["PrecursorAskedForBody"] = null,
        // ["Alan_Body_3_Clue"] = null, // rough location
        // ["Alan_Body_3_Clue2"] = null, // close
        // ["UnlockDeepPadsCache"] = null, // right outside
        ["Scan_PrecursorSkeleton"] = new("{player} has scanned an Architect skeleton, obtaining the first blueprint for the Architect body parts.", true),
        // ["UnlockArcticSpiresCache"] = null,
        ["Scan_PrecursorTissue"] = new("{player} has scanned a sample of Architect tissues, obtaining another blueprint for the Architect body parts.", true),
        // ["UnlockCrystalCastleCache"] = null,
        ["Scan_PrecursorOrgans"] = new("{player} has scanned a set of Architect organs, obtaining the final blueprint for the Architect body parts.", true),
        // ["Alan_BodyFacility"] = null,
        // ["AtBodyFacilityTerminal"] = null,
        // ["OnPrecursorNPCFabricated"] = null,
        // ["Scan_PrecursorBody"] = null,
        // ["AlanToEndGame"] = null,
        #endregion Main story

        #region Delta Station
        // ["DeltaIslandBeaconTimed"] = null, // timed autodiscovery
        // ["DeltaIslandBeacon"] = null, // triggered when in range, enables the beacon
        // ["DeltaIslandFirstVisit"] = null,
        // ["Scan_Alterra_Locations_Map"] = null,
        #endregion Delta Station

        #region Marguerit subplot
        // ["Log_Marg_DeltaIsland_GoAway"] = null,
        // ["FirstEncounterStart"] = null, // first encounter w/ marguerit
        // ["FirstEncounterEnd"] = null,
        // ["UnlockMargPostJumpSignal"] = null,

        // ["UnlockMarg2"] = null, // approaching the base
        ["MargBaseFirstVisit"] = null,
        #region Mercury II
        // ["Log_ExplorationHint_ShipWreck1"] = null, // stern
        // ["Log_ExplorationHint_ShipWreck2"] = null, // bow
        #endregion Mercury II
        ["OnUnlockRadioTowerPPU"] = null, // scanned third PPU fragment
        ["OnUnlockRadioTowerTOM"] = null,
        // ["RadioTowerTOMConnected"] = null,
        ["RadioTowerHacked"] = "{player} has disabled the satellite radio tower at Delta Station. Now Alterra can no longer track Marguerit.",
        ["MargGreenhouseHint"] = null,
        ["OnScanMarguerit"] = new("{player} is scanning Marguerit in an incredibly inappropriate way, please scold {object}.", true),
        #endregion Marguerit subplot

        #region Phi Robotics
        // ["GlacialBasinLandBeacon"] = null, // enables Phi beacon
        // ["Log_Robin_Phi_Enter"] = null,
        // ["SpyPenguinUnlocked"] = null,
        ["OnGlacialBasinBridgeItemInserted"] = "{player} has inserted a canister of hydraulic fluid into the receptacle. The bridge is now operational again.",
        #endregion Phi Robotics

        #region Random
        ["SeaMonkeyGift"] = "A Sea Monkey has brought {player} an item as a gift",
        #endregion Random
    };
}
