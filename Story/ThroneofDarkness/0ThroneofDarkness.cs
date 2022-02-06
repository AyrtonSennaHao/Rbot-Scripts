//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreDailys.cs
//cs_include Scripts/Story/ThroneofDarkness/CastleofBones.cs
//cs_include Scripts/Story/ThroneofDarkness/ParadoxPortal.cs
//cs_include Scripts/Story/ThroneofDarkness/FlyingBaconCatFortress.cs
//cs_include Scripts/Story/ThroneofDarkness/DeathPitArena.cs
//cs_include Scripts/Story/ThroneofDarkness/FourthDimensionalPyramid.cs
//cs_include Scripts/Story/ThroneofDarkness/ShiftingPyramid.cs
//cs_include Scripts/Story/ThroneofDarkness/HedgeMaze.cs
//cs_include Scripts/Story/ThroneofDarkness/TowerofMirros.cs


using RBot;

public class TheThroneisMine
{
    public ScriptInterface Bot => ScriptInterface.Instance;

    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();
    public CoreDailys Dailys = new CoreDailys();
    public CastleofBones story1 = new CastleofBones();
    public ParadoxPortal story2 = new ParadoxPortal();
    public FlyingBaconCatFortress story3 = new FlyingBaconCatFortress();
    public DeathPitArena story4 = new DeathPitArena();
    public FourthDimensionalPyramid story5 = new FourthDimensionalPyramid();
    public ShiftingPyramid story6 = new ShiftingPyramid();
    public HedgeMaze story7 = new HedgeMaze();
    public TowerofMirrors story8 = new TowerofMirrors();

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        LemmeSitontheThrone();
        Core.Logger("if it fits i sits");

        Core.SetOptions(false);
    }

    public void LemmeSitontheThrone()
    {
        Core.Logger("CastleofBones");
        story1.CastleofBonesSaga();
        Core.Logger("ParadoxPortal");
        story2.ParadoxPortalSaga();
        Core.Logger("FlyingBaconCatFortress");
        story3.FlyingBaconCatFortressSaga();
        Core.Logger("DeathPitArena");
        story4.DeathPitArenaSaga();
        Core.Logger("FourthDimensionalPyramid");
        story5.FourthDimensionalPyramidSaga();
        Core.Logger("ShiftingPyramid");
        story6.ShiftingPyramidSaga();
        Core.Logger("HedgeMaze");
        story7.HedgeMaze_Questline();
        Core.Logger("TowerofMirrors");
        story8.TowerofMirrorsSaga();
    }
}
