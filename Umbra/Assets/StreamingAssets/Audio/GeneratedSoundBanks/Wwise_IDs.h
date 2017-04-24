/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID AMB_ALARM = 267862785U;
        static const AkUniqueID AMB_CHECK = 1781658170U;
        static const AkUniqueID AMB_DOOR = 3008075654U;
        static const AkUniqueID AMB_RAIN = 3302041772U;
        static const AkUniqueID AMB_SHADOW_PIPE = 897032325U;
        static const AkUniqueID CUTS_START = 1323154943U;
        static const AkUniqueID MENU_CANCEL = 3180909377U;
        static const AkUniqueID MENU_CLICK = 760777789U;
        static const AkUniqueID MENU_HOVER = 309439191U;
        static const AkUniqueID MENU_PAUSE = 2170009975U;
        static const AkUniqueID MENU_PAUSE_END = 211604505U;
        static const AkUniqueID MENU_RUNE_CLICK = 2550334218U;
        static const AkUniqueID MENU_RUNE_HOVER = 1350920896U;
        static const AkUniqueID MUS_ALERT = 1102633101U;
        static const AkUniqueID MUS_EXPLO = 48865357U;
        static const AkUniqueID MUS_INGAME = 562626134U;
        static const AkUniqueID MUS_LOCATED = 2998987929U;
        static const AkUniqueID MUS_MENU = 3149643052U;
        static const AkUniqueID MUS_SECTEUR1 = 3224037365U;
        static const AkUniqueID MUS_SECTEUR2 = 3224037366U;
        static const AkUniqueID MUS_SECTEUR3 = 3224037367U;
        static const AkUniqueID NPC_ACTION_KILL = 3752724058U;
        static const AkUniqueID NPC_DESTROY = 55429609U;
        static const AkUniqueID NPC_FOOT_RUN = 888215683U;
        static const AkUniqueID NPC_STATE_ALARMED = 3551547733U;
        static const AkUniqueID NPC_STATE_LOCATED = 2712572047U;
        static const AkUniqueID NPC_STATE_NORMAL = 624895962U;
        static const AkUniqueID PC_ACTION_DEATH = 169793748U;
        static const AkUniqueID PC_ACTION_KILL = 1092215814U;
        static const AkUniqueID PC_ACTION_RESPAWN = 1590111458U;
        static const AkUniqueID PC_ACTION_SLOWMO = 348181601U;
        static const AkUniqueID PC_ACTION_SLOWMO_END = 2684526339U;
        static const AkUniqueID PC_FOOT_CLIMB = 771062343U;
        static const AkUniqueID PC_FOOT_JUMP = 1143253532U;
        static const AkUniqueID PC_FOOT_LAND = 1077239935U;
        static const AkUniqueID PC_FOOT_RUN = 1166184207U;
        static const AkUniqueID PC_RUNE_ACCROCHAGE_EQUIP = 651324617U;
        static const AkUniqueID PC_RUNE_ACCROCHAGE_GREEN = 4264946172U;
        static const AkUniqueID PC_RUNE_ACCROCHAGE_RED = 2004937196U;
        static const AkUniqueID PC_RUNE_ACCROCHAGE_USE = 1701807220U;
        static const AkUniqueID PC_RUNE_LEURRE_FILTER = 564655388U;
        static const AkUniqueID PC_RUNE_LEURRE_USE = 2295622767U;
        static const AkUniqueID PC_RUNE_MARQUAGE_USE = 153992643U;
        static const AkUniqueID PC_RUNE_OMBRE_DECAY = 3410690150U;
        static const AkUniqueID PC_RUNE_OMBRE_SELECT = 3591117188U;
        static const AkUniqueID PC_RUNE_OMBRE_USE = 710126949U;
        static const AkUniqueID PC_RUNE_SELECT = 966453248U;
        static const AkUniqueID PC_RUNE_SOLIDE_END = 1994207056U;
        static const AkUniqueID PC_RUNE_SOLIDE_USE = 1543771206U;
        static const AkUniqueID PC_RUNE_TRAP_STUN = 698530244U;
        static const AkUniqueID PC_RUNE_TRAP_USE = 3244327485U;
        static const AkUniqueID PC_STEALTH_OFF = 1483073216U;
        static const AkUniqueID PC_STEALTH_ON = 2183052938U;
        static const AkUniqueID SFX_SCRIPTED_SHIELD = 608424965U;
        static const AkUniqueID STOPALLMUSIC = 2907867019U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace FOOT_STEALTH
        {
            static const AkUniqueID GROUP = 3551007341U;

            namespace STATE
            {
                static const AkUniqueID STEALTH_OFF = 2099529632U;
                static const AkUniqueID STEALTH_ON = 581962986U;
            } // namespace STATE
        } // namespace FOOT_STEALTH

        namespace MUSIC
        {
            static const AkUniqueID GROUP = 3991942870U;

            namespace STATE
            {
                static const AkUniqueID ALERT = 721787521U;
                static const AkUniqueID EXPLO = 3814499265U;
                static const AkUniqueID LOCATED = 2375286893U;
            } // namespace STATE
        } // namespace MUSIC

        namespace SECTEURS
        {
            static const AkUniqueID GROUP = 2057580299U;

            namespace STATE
            {
                static const AkUniqueID MAINMENU = 3604647259U;
                static const AkUniqueID SECTEUR1 = 2057580361U;
                static const AkUniqueID SECTEUR2 = 2057580362U;
                static const AkUniqueID SECTEUR3 = 2057580363U;
            } // namespace STATE
        } // namespace SECTEURS

    } // namespace STATES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID LEURRE = 954629190U;
        static const AkUniqueID RUNE_MODE = 1448996089U;
    } // namespace GAME_PARAMETERS

    namespace TRIGGERS
    {
        static const AkUniqueID LOCATED = 2375286893U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID ALL = 1100754030U;
        static const AkUniqueID CUTS = 3884255510U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMB = 1117531639U;
        static const AkUniqueID AMB_PONCTUEL = 4264571901U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MASTER_SECONDARY_BUS = 805203703U;
        static const AkUniqueID MUS = 712897226U;
        static const AkUniqueID NORMAL = 1160234136U;
        static const AkUniqueID NPC = 662417162U;
        static const AkUniqueID PC = 1635194334U;
        static const AkUniqueID SCREAMS = 2812860249U;
        static const AkUniqueID SFX_ALL = 599508334U;
        static const AkUniqueID UI = 1551306167U;
        static const AkUniqueID VO = 1534528548U;
    } // namespace BUSSES

}// namespace AK

#endif // __WWISE_IDS_H__
