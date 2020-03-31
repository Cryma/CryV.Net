#pragma once

#include <Windows.h>
#include <stdint.h>

typedef DWORD Void;
typedef DWORD Any;
typedef DWORD uint;
typedef DWORD Hash;
typedef int Entity;
typedef int Player;
typedef int FireId;
typedef int Ped;
typedef int Vehicle;
typedef int Cam;
typedef int CarGenerator;
typedef int Group;
typedef int Train;
typedef int Pickup;
typedef int Object;
typedef int Weapon;
typedef int Interior;
typedef int Blip;
typedef int Texture;
typedef int TextureDict;
typedef int CoverPoint;
typedef int Camera;
typedef int TaskSequence;
typedef int ColourIndex;
typedef int Sphere;
typedef int ScrHandle;

#pragma pack(push, 1)
typedef struct {
	float x;
	DWORD _paddingx;
	float y;
	DWORD _paddingy;
	float z;
	DWORD _paddingz;
} Vector3;
#pragma pack(pop)

#pragma pack(push, 1)
typedef struct {
	float x;
	float y;
	float z;
} Vector3_t;
#pragma pack(pop)

struct Blip_t {
public:
	__int32 iID; //0x0000 
	__int8 iID2; //0x0004 
	char _0x0005[3];
	BYTE N000010FB; //0x0008 (80 = moves with player, some values will turn icon into map cursor and break it)
	char _0x0009[7];
	Vector3 coords;
	char _0x001C[6];
	BYTE bFocused; //0x0022   (Focused? 0100 0000)
	char _0x0023[5];
	char* szMessage; //0x0028 If not null, contains the string of whatever the blip says when selected.
	char _0x0030[16];
	int iIcon; //0x0040
	char _0x0044[4];
	DWORD dwColor; //0x0048 (Sometimes works?)
	char _0x004C[4];
	float fScale; //0x0050 
	__int16 iRotation; //0x0054 Heading
	BYTE bInfoIDType; //0x0056 GET_BLIP_INFO_ID_TYPE
	BYTE bZIndex; //0x0057 
	BYTE bDisplay; //0x0058  Also Visibility 0010
	BYTE bAlpha; //0x0059
};//Size=0x005A

struct BlipList {
public:
	Blip_t* m_Blips[1500]; //0x0000 

};//Size=0x2F18

class CVehicleModelInfo {
public:
	char pad_0000[24]; //0x0000
	uint32_t Model; //0x0018
	char pad_001C[48]; //0x001C
}; //Size: 0x004C

class CNavigation {
public:
	char pad_0000[32]; //0x0000
	float Heading; //0x0020
	float Heading2; //0x0024
	char pad_0028[8]; //0x0028
	Vector3_t Rotation; //0x0030
	char pad_003C[20]; //0x003C
	Vector3_t Position; //0x0050
}; //Size: 0x005C

class CVehicleHandling {
public:
	char pad_0000[12]; //0x0000
	float Mass; //0x000C
	char pad_0010[60]; //0x0010
	float Acceleration; //0x004C
	char pad_0050[28]; //0x0050
	float BrakeForce; //0x006C
	char pad_0070[12]; //0x0070
	float HandBrakeForce; //0x007C
}; //Size: 0x0080

class CWheel
{
public:
	char pad_0000[272]; //0x0000
	float N0000061F; //0x0110
	char pad_0114[92]; //0x0114
	float TyreSpeed; //0x0170
}; //Size: 0x0248

class CWheels
{
public:
	CWheel* Wheel[12]; //0x0000
}; //Size: 0x00A0

class CVehicle {
public:
	char pad_0000[32]; //0x0000
	CVehicleModelInfo* ModelInfo; //0x0020
	char pad_0028[8]; //0x0028
	CNavigation* Navigation; //0x0030 Contains proper position and rotation
	char pad_0038[88]; //0x0038
	Vector3_t VisualPosition; //0x0090
	char pad_009C[237]; //0x009C
	BYTE Godmode; //0x0189
	char pad_018A[246]; //0x018A
	float Health; //0x0280
	char pad_0284[28]; //0x0284
	float MaxHealth; //0x02A0
	char pad_02A4[1484]; //0x02A4
	BYTE N000003A0; //0x0870
	BYTE N000005A4; //0x0871
	uint8_t CurrentGear; //0x0872
	char pad_0873[61]; //0x0873
	float N000003A9; //0x08B0
	float CurrentRPM; //0x08B4
	char pad_08B8[8]; //0x08B8
	float Clutch; //0x08C0
	float Acceleration; //0x08C4
	char pad_08C8[16]; //0x08C8
	float Turbo; //0x08D8
	char pad_08DC[60]; //0x08DC
	CVehicleHandling* Handling; //0x0918
	char pad_0920[24]; //0x0920
	float DirtLevel; //0x0938
	char pad_093C[84]; //0x093C
	float N000001A7; //0x0990
	float SteeringAngle; //0x0994
	char pad_0998[8]; //0x0998
	float Brake; //0x09A0
	char pad_09A4[220]; //0x09A4
	float WheelSpeed; //0x0A80
	char pad_0A84[248]; //0x0A84
	float Gravity; //0x0B7C
	char pad_0B80[44]; //0x0B80
	float N000005C0; //0x0BAC
	CWheels* Wheels; //0x0BB0
	int32_t NumWheels; //0x0BB8
	char pad_0BBC[212]; //0x0BBC

	int numWheels() const {
		return NumWheels;
	}

	CWheel* getWheel(int index) const {
		if(index + 1 > NumWheels) {
			return nullptr;
		}

		if(Wheels == nullptr)
		{
			return nullptr;
		}

		if(Wheels->Wheel[index] == nullptr) {
			return nullptr;
		}

		return Wheels->Wheel[index];
	}

}; //Size: 0x0B88

class CVehicleHandle {
public:
	CVehicle* Vehicle; //0x0000
	int32_t Handle; //0x0008
	char pad_000C[4]; //0x000C
}; //Size: 0x0010

class CVehicleList {
public:
	CVehicleHandle VehicleHandles[300]; //0x0000
}; //Size: 0x12C0

class CVehicleInterface {
public:
	char pad_0000[384]; //0x0000
	CVehicleList* VehicleList; //0x0180
	int32_t MaxVehicles; //0x0188
	char pad_018C[4]; //0x018C
	int32_t CurrentVehicles; //0x0190

	CVehicle* getVehicle(const int& index) const {
		if (index < MaxVehicles) {
			return VehicleList->VehicleHandles[index].Vehicle;
		}

		return nullptr;
	}

}; //Size: 0x0194

class CAmmo {
public:
	char pad_0000[24]; //0x0000
	uint32_t AmmoAmount; //0x0018 Only working sometimes?
}; //Size: 0x001C

class CAmmoObject {
public:
	CAmmo* Ammo; //0x0000
}; //Size: 0x0008

class CAmmoInfo {
public:
	char pad_0000[8]; //0x0000
	CAmmoObject* AmmoObject; //0x0008
	char pad_0010[24]; //0x0010
	uint32_t MaxAmmo; //0x0028
}; //Size: 0x002C

class CWeaponInfo {
public:
	char pad_0000[16]; //0x0000
	uint32_t Hash; //0x0010
	char pad_0014[76]; //0x0014
	CAmmoInfo* AmmoInfo; //0x0060
	char pad_0068[496]; //0x0068
}; //Size: 0x0258

class CWeaponManager {
public:
	char pad_0000[16]; //0x0000
	class CPed* Ped; //0x0010
	char pad_0018[8]; //0x0018
	CWeaponInfo* WeaponInfo; //0x0020
	char pad_0028[32]; //0x0028
}; //Size: 0x0048

class CPed {
public:
	//   char pad_0000[32]; //0x0000
	//   CVehicleModelInfo* PedModelInfo; //0x0020
	//   char pad_0028[8]; //0x0028
	//   CNavigation* Navigation; //0x0030 Contains proper position and rotation
	//   char pad_0038[88]; //0x0038
	//   Vector3 VisualPosition; //0x0090
	//   char pad_009C[240]; //0x009C
	//   BYTE RND5312; //0x018C
	   //BYTE Godmode; //0x018D
	//   char pad_018E[242]; //0x018E
	//   float Health; //0x0280
	//   char pad_0284[28]; //0x0284
	//   float MaxHealth; //0x02A0
	//   char pad_02A4[124]; //0x02A4
	//   Vector3 Velocity; //0x0320
	//   char pad_032C[2556]; //0x032C
	//   CVehicle* LastVehicle; //0x0D28
	//   char pad_0D30[920]; //0x0D30
	//   CWeaponManager* WeaponManager; //0x10C8
	//   char pad_10D0[916]; //0x10D0
	   //BYTE RND8754; //0x1464
	   //BYTE IsInVehicle; //0x1465
	   //BYTE RND1568; //0x1466
	   //BYTE RND1879; //0x1467
	//   char pad_1468[144]; //0x1468
	//   CVehicle* LastVehicle2; //0x14F8
	//   char pad_1500[160]; //0x1500
	//   int16_t VehicleSeat; //0x15A0

	char pad_0000[32]; //0x0000
	CVehicleModelInfo* PedModelInfo; //0x0020
	char pad_0028[8]; //0x0028
	CNavigation* Navigation; //0x0030 Contains proper position and rotation
	char pad_0038[88]; //0x0038
	Vector3_t VisualPosition; //0x0090
	char pad_009C[240]; //0x009C
	BYTE RND5312; //0x018C
	BYTE Godmode; //0x018D
	char pad_018E[242]; //0x018E
	float Health; //0x0280
	char pad_0284[28]; //0x0284
	float MaxHealth; //0x02A0
	char pad_02A4[124]; //0x02A4
	Vector3_t Velocity; //0x0320
	char pad_032C[2556]; //0x032C
	CVehicle* LastVehicle; //0x0D28
	char pad_0D30[920]; //0x0D30
	CWeaponManager* WeaponManager; //0x10C8
	char pad_10D0[916]; //0x10D0
	BYTE RND8754; //0x1464
	BYTE IsInVehicle; //0x1465
	BYTE RND1568; //0x1466
	BYTE RND1879; //0x1467
	char pad_1468[144]; //0x1468
	CVehicle* LastVehicle2; //0x14F8
	char pad_1500[160]; //0x1500
	int16_t VehicleSeat; //0x15A0


	Vector3_t position() const {
		return Navigation->Position;
	}

	Vector3_t rotation() const {
		return Navigation->Rotation;
	}

	Vector3_t velocity() const {
		return Velocity;
	}

	Hash model() const {
		return PedModelInfo->Model;
	}

	bool godmode() const {
		return Godmode;
	}

	void setGodmode(bool value) {
		Godmode = value;
	}

	float health() const {
		return Health;
	}

	void setHealth(float value) {
		if (value > MaxHealth) {
			value = MaxHealth;
		}

		Health = value;
	}

	void setMaxHealth(float value) {
		MaxHealth = value;
	}

	CVehicle* lastVehicle() const {
		return LastVehicle;
	}

	int16_t vehicleSeat() const {
		if (IsInVehicle == false && VehicleSeat == -1) {
			return -3;
		}

		return VehicleSeat - 1;
	}

}; //Size: 0x15A2

class CPedHandle {
public:
	class CPed* Ped; //0x0000
	int32_t Handle; //0x0008
	char pad_000C[4]; //0x000C
}; //Size: 0x0010

class CPedList {
public:
	CPedHandle PedHandles[256]; //0x0000
	char pad_1000[64]; //0x1000
}; //Size: 0x1040

class CPedInterface {
public:
	char pad_0000[256]; //0x0000
	class CPedList* PedList; //0x0100
	int32_t MaxPeds; //0x0108
	char pad_010C[4]; //0x010C
	int32_t CurrentPeds; //0x0110

	CPed* getPed(const int& index) const {
		if (index < MaxPeds) {
			return PedList->PedHandles[index].Ped;
		}

		return nullptr;
	}

}; //Size: 0x0114

class CObject {
public:
	char pad_0000[72]; //0x0000
}; //Size: 0x0048

class CObjectHandle {
public:
	class CObject* Object; //0x0000
	int32_t Handle; //0x0008
	char pad_000C[4]; //0x000C
}; //Size: 0x0010

class CObjectList {
public:
	CObjectHandle ObjectHandles[2300]; //0x0000
}; //Size: 0x8FC0

class CObjectInterface {
public:
	char pad_0000[344]; //0x0000
	class CObjectList* ObjectList; //0x0158
	int32_t MaxObjects; //0x0160
	char pad_0164[4]; //0x0164
	int32_t CurrentObjects; //0x0168

	CObject* getObject(const int& index) const {
		if (index < MaxObjects) {
			return ObjectList->ObjectHandles[index].Object;
		}

		return nullptr;
	}

}; //Size: 0x016C

class CReplayInterface {
public:
	char pad_0000[16]; //0x0000
	class CVehicleInterface* VehicleInterface; //0x0010
	class CPedInterface* PedInterface; //0x0018
	char pad_0020[8]; //0x0020
	class CObjectInterface* ObjectInterface; //0x0028
	char pad_0030[16]; //0x0030
}; //Size: 0x0040
