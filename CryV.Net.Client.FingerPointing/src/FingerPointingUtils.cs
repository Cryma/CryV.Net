using CryV.Net.Elements;

namespace CryV.Net.Client.FingerPointing
{
    public static class FingerPointingUtils
    {

        public static void StartPointing(Ped ped)
        {
            Streaming.LoadAnimationDictionary("anim@mp_point");

            ped.SetPedConfigFlag(36, true);
            ped.TaskMoveNetwork("task_mp_pointing", 0.5f, false, "anim@mp_point", 24);
        }

        public static void StopPointing(Ped ped)
        {
            ped._0xD01015C7316AE176("Stop");
            ped.ClearPedSecondaryTask();
            ped.SetPedConfigFlag(36, false);

            ped.ClearPedTasks();
        }

        public static void UpdatePointing(Ped ped, float cameraPitch, float cameraHeading, bool blocked)
        {
            ped._0xD5BB4025AE449A4E("Pitch", cameraPitch);
            ped._0xD5BB4025AE449A4E("Heading", cameraHeading);
            ped._0xB0A6CFD2C69C1088("isBlocked", blocked);
            ped._0xB0A6CFD2C69C1088("isFirstPerson", false);
        }

    }
}
