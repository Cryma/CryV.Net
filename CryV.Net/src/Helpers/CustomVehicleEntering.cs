using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using CryV.Net.Elements;
using CryV.Net.Enums;

namespace CryV.Net.Helpers;

public static class CustomVehicleEntering
{

    public static void Tick()
    {
        Gameplay.DisableControlAction(0, 23, true);

        if (Gameplay.IsDisabledControlJustPressed(0, 23))
        {
            EnterAsDriver();
        }

        if (Utility.IsKeyReleased(ConsoleKey.G))
        {
            EnterAsPassenger();
        }

        if (LocalPlayer.Character.IsEnteringVehicle() && (Gameplay.IsControlJustPressed(0, 30) || Gameplay.IsControlJustPressed(0, 31) 
            || Gameplay.IsControlJustPressed(0, 32) || Gameplay.IsControlJustPressed(0, 33) || Gameplay.IsControlJustPressed(0, 34) || Gameplay.IsControlJustPressed(0, 35)))
        {
            LocalPlayer.Character.ClearPedTasks();
        }
    }

    private static readonly List<string> _seatBones = new()
    {
        "seat_dside_r",
        "seat_dside_r1",
        "seat_dside_r2",
        "seat_dside_r3",
        "seat_dside_r4",
        "seat_dside_r5",
        "seat_dside_r6",
        "seat_dside_r7",
        "seat_pside_f",
        "seat_pside_r",
        "seat_pside_r1",
        "seat_pside_r2",
        "seat_pside_r3",
        "seat_pside_r4",
        "seat_pside_r5",
        "seat_pside_r6",
        "seat_pside_r7"
    };

    public static void EnterAsDriver()
    {
        if (LocalPlayer.Character.IsInAnyVehicle())
        {
            return;
        }

        var vehicle = GetClosestVehicle(LocalPlayer.Character.Position);
        if (vehicle == null || vehicle.DoesExist() == false || vehicle.EngineHealth < 0 || vehicle.IsVehicleSeatFree(VehicleSeat.Driver) == false)
        {
            return;
        }

        LocalPlayer.Character.TaskEnterVehicle(vehicle, -1, VehicleSeat.Driver, LocalPlayer.Character.Speed(), 0);
    }

    public static void EnterAsPassenger()
    {
        if (LocalPlayer.Character.IsInAnyVehicle())
        {
            return;
        }

        var vehicle = GetClosestVehicle(LocalPlayer.Character.Position);
        if (vehicle == null || vehicle.DoesExist() == false || vehicle.EngineHealth < 0)
        {
            return;
        }

        var closestSeat = GetVehiclePassengerSeat(vehicle, LocalPlayer.Character.Position);
        if (closestSeat == VehicleSeat.None)
        {
            return;
        }

        LocalPlayer.Character.TaskEnterVehicle(vehicle, -1, closestSeat, LocalPlayer.Character.Speed(), 0);
    }

    private static VehicleSeat GetVehiclePassengerSeat(Vehicle vehicle, Vector3 position)
    {
        var targetSeat = GetSeatFromBoneName(GetNearestUnoccupiedPassengerSeatBone(position, vehicle));

        // TODO: Handle other cases

        if (vehicle.IsThisModelABike())
        {
            return VehicleSeat.Passenger;
        }

        return targetSeat;
    }

    private static string GetNearestUnoccupiedPassengerSeatBone(Vector3 position, Vehicle vehicle)
    {
        var nearestBone = "";
        var distance = 50.0f;

        foreach (var bone in _seatBones)
        {
            var bonePosition = vehicle.GetWorldPositionOfBone(vehicle.GetBoneIndexByName(bone));
            var seat = GetSeatFromBoneName(bone);

            var dist = Vector3.Distance(position, bonePosition);
            if (dist > distance || vehicle.IsVehicleSeatFree(seat) == false)
            {
                continue;
            }

            distance = dist;
            nearestBone = bone;
        }

        return nearestBone;
    }

    private static VehicleSeat GetSeatFromBoneName(string bone)
    {
        switch (bone)
        {
            case "seat_dside_r":
                return VehicleSeat.LeftRear;
            case "seat_dside_r1":
                return VehicleSeat.ExtraSeat1;
            case "seat_dside_r2":
                return VehicleSeat.ExtraSeat3;
            case "seat_dside_r3":
                return VehicleSeat.ExtraSeat5;
            case "seat_dside_r4":
                return VehicleSeat.ExtraSeat7;
            case "seat_dside_r5":
                return VehicleSeat.ExtraSeat9;
            case "seat_dside_r6":
                return VehicleSeat.ExtraSeat11;
            case "seat_dside_r7":
                return VehicleSeat.ExtraSeat13;
            case "seat_pside_f":
                return VehicleSeat.Passenger;
            case "seat_pside_r":
                return VehicleSeat.RightRear;
            case "seat_pside_r1":
                return VehicleSeat.ExtraSeat2;
            case "seat_pside_r2":
                return VehicleSeat.ExtraSeat4;
            case "seat_pside_r3":
                return VehicleSeat.ExtraSeat6;
            case "seat_pside_r4":
                return VehicleSeat.ExtraSeat8;
            case "seat_pside_r5":
                return VehicleSeat.ExtraSeat10;
            case "seat_pside_r6":
                return VehicleSeat.ExtraSeat12;
            case "seat_pside_r7":
                return VehicleSeat.ExtraSeat14;
            default:
                return VehicleSeat.None;
        }
    }

    private static Vehicle GetClosestVehicle(Vector3 position, float maxDistance = 15.0f)
    {
        Vehicle closestVehicle = null;
        foreach (var vehicleEntity in EntityPool.GetEntities().Where(x => x.GetType() == typeof(Vehicle)))
        {
            var vehicle = (Vehicle) vehicleEntity;

            var distance = Vector3.Distance(position, vehicle.Position);
            if (distance > maxDistance)
            {
                continue;
            }

            maxDistance = distance;
            closestVehicle = vehicle;
        }

        return closestVehicle;
    }

}
