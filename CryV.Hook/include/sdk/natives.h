#pragma once

#include <Windows.h>

#include <sdk/types.h>
#include <sdk/nativeCaller.h>

namespace APP
{
	static void APP_CLEAR_BLOCK() { invoke<Void>(0x5FE1DF3342DB7DBA); } // 0x5FE1DF3342DB7DBA
	static void APP_CLOSE_APP() { invoke<Void>(0xE41C65E07A5F05FC); } // 0xE41C65E07A5F05FC
	static void APP_CLOSE_BLOCK() { invoke<Void>(0xE8E3FCF72EAC0EF8); } // 0xE8E3FCF72EAC0EF8
	static int APP_DATA_VALID() { return invoke<int>(0x846AA8E7D55EE5B6); } // 0x846AA8E7D55EE5B6
	static BOOL APP_DELETE_APP_DATA(char* appName) { return invoke<BOOL>(0x44151AEA95C8A003, appName); } // 0x44151AEA95C8A003
	static Any APP_GET_DELETED_FILE_STATUS() { return invoke<Any>(0xC9853A2BE3DED1A6); } // 0xC9853A2BE3DED1A6
	static float APP_GET_FLOAT(char* property) { return invoke<float>(0x1514FB24C02C2322, property); } // 0x1514FB24C02C2322
	static void APP_GET_INT(ScrHandle property) { invoke<Void>(0xD3A58A12C77D9D4B, property); } // 0xD3A58A12C77D9D4B
	static char* APP_GET_STRING(char* property) { return invoke<char*>(0x749B023950D2311C, property); } // 0x749B023950D2311C
	static BOOL APP_HAS_LINKED_SOCIAL_CLUB_ACCOUNT() { return invoke<BOOL>(0x71EEE69745088DA0); } // 0x71EEE69745088DA0
	static BOOL APP_HAS_SYNCED_DATA(char* appName) { return invoke<BOOL>(0xCA52279A7271517F, appName); } // 0xCA52279A7271517F
	static void APP_SAVE_DATA() { invoke<Void>(0x95C5D356CDA6E85F); } // 0x95C5D356CDA6E85F
	static void APP_SET_APP(char* appName) { invoke<Void>(0xCFD0406ADAF90D2B, appName); } // 0xCFD0406ADAF90D2B
	static void APP_SET_BLOCK(char* blockName) { invoke<Void>(0x262AB456A3D21F93, blockName); } // 0x262AB456A3D21F93
	static void APP_SET_FLOAT(char* property, float value) { invoke<Void>(0x25D7687C68E0DAA4, property, value); } // 0x25D7687C68E0DAA4
	static void APP_SET_INT(char* property, int value) { invoke<Void>(0x607E8E3D3E4F9611, property, value); } // 0x607E8E3D3E4F9611
	static void APP_SET_STRING(char* property, char* value) { invoke<Void>(0x3FF2FCEC4B7721B4, property, value); } // 0x3FF2FCEC4B7721B4
}

namespace AUDIO
{
	static void ADD_LINE_TO_CONVERSATION(int p0, char* p1, char* p2, int p3, int p4, BOOL p5, BOOL p6, BOOL p7, BOOL p8, int p9, BOOL p10, BOOL p11, BOOL p12) { invoke<Void>(0xC5EF963405593646, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12); } // 0xC5EF963405593646
	static void ADD_PED_TO_CONVERSATION(Any p0, Any ped, char* p2) { invoke<Void>(0x95D9F4BC443956E7, p0, ped, p2); } // 0x95D9F4BC443956E7
	static Any AUDIO_IS_SCRIPTED_MUSIC_PLAYING() { return invoke<Any>(0x845FFC3A4FEEFA3E); } // 0x845FFC3A4FEEFA3E
	static void BLIP_SIREN(Vehicle vehicle) { invoke<Void>(0x1B9025BDA76822B6, vehicle); } // 0x1B9025BDA76822B6
	static BOOL CANCEL_MUSIC_EVENT(char* eventName) { return invoke<BOOL>(0x5B17A90291133DA5, eventName); } // 0x5B17A90291133DA5
	static BOOL _CAN_PED_SPEAK(Ped ped, char* speechName, BOOL unk) { return invoke<BOOL>(0x49B99BF3FDA89A7A, ped, speechName, unk); } // 0x49B99BF3FDA89A7A
	static void CLEAR_ALL_BROKEN_GLASS() { invoke<Void>(0xB32209EFFDC04913); } // 0xB32209EFFDC04913
	static void CLEAR_AMBIENT_ZONE_LIST_STATE(Any* p0, BOOL p1) { invoke<Void>(0x120C48C614909FA4, p0, p1); } // 0x120C48C614909FA4
	static void CLEAR_AMBIENT_ZONE_STATE(char* zoneName, BOOL p1) { invoke<Void>(0x218DD44AAAC964FF, zoneName, p1); } // 0x218DD44AAAC964FF
	static void CREATE_NEW_SCRIPTED_CONVERSATION() { invoke<Void>(0xD2C91A0B572AAE56); } // 0xD2C91A0B572AAE56
	static void DISABLE_PED_PAIN_AUDIO(Ped ped, BOOL toggle) { invoke<Void>(0xA9A41C1E940FB0E8, ped, toggle); } // 0xA9A41C1E940FB0E8
	static void _DISABLE_POLICE_REPORTS() { invoke<Void>(0xB4F90FAF7670B16F); } // 0xB4F90FAF7670B16F
	static void _DYNAMIC_MIXER_RELATED_FN(Entity p0, char* p1, float p2) { invoke<Void>(0x153973AB99FE8980, p0, p1, p2); } // 0x153973AB99FE8980
	static int FIND_RADIO_STATION_INDEX(int station) { return invoke<int>(0x8D67489793FF428B, station); } // 0x8D67489793FF428B
	static void _FORCE_AMBIENT_SIREN(BOOL value) { invoke<Void>(0x552369F549563AD5, value); } // 0x552369F549563AD5
	static void _FORCE_VEHICLE_ENGINE_AUDIO(Vehicle vehicle, char* audioName) { invoke<Void>(0x4F0C413926060B38, vehicle, audioName); } // 0x4F0C413926060B38
	static void FREEZE_RADIO_STATION(char* radioStation) { invoke<Void>(0x344F393B027E38C3, radioStation); } // 0x344F393B027E38C3
	static int GET_AUDIBLE_MUSIC_TRACK_TEXT_ID() { return invoke<int>(0x50B196FC9ED6545B); } // 0x50B196FC9ED6545B
	static Any GET_CURRENT_SCRIPTED_CONVERSATION_LINE() { return invoke<Any>(0x480357EE890C295A); } // 0x480357EE890C295A
	static Any GET_MUSIC_PLAYTIME() { return invoke<Any>(0xE7A0D23DC414507B); } // 0xE7A0D23DC414507B
	static int GET_NETWORK_ID_FROM_SOUND_ID(int soundId) { return invoke<int>(0x2DE3F0A134FFBC0D, soundId); } // 0x2DE3F0A134FFBC0D
	static int GET_NUMBER_OF_PASSENGER_VOICE_VARIATIONS(Any p0) { return invoke<int>(0x66E49BF55B4B1874, p0); } // 0x66E49BF55B4B1874
	static void GET_PLAYER_HEADSET_SOUND_ALTERNATE(char* p0, float p1) { invoke<Void>(0xBCC29F935ED07688, p0, p1); } // 0xBCC29F935ED07688
	static Any GET_PLAYER_RADIO_STATION_GENRE() { return invoke<Any>(0xA571991A7FE6CCEB); } // 0xA571991A7FE6CCEB
	static int GET_PLAYER_RADIO_STATION_INDEX() { return invoke<int>(0xE8AF77C4C06ADC93); } // 0xE8AF77C4C06ADC93
	static char* GET_PLAYER_RADIO_STATION_NAME() { return invoke<char*>(0xF6D733C32076AD03); } // 0xF6D733C32076AD03
	static char* GET_RADIO_STATION_NAME(int radioStation) { return invoke<char*>(0xB28ECA15046CA8B9, radioStation); } // 0xB28ECA15046CA8B9
	static int GET_SOUND_ID() { return invoke<int>(0x430386FE9BF80B45); } // 0x430386FE9BF80B45
	static int GET_SOUND_ID_FROM_NETWORK_ID(int netId) { return invoke<int>(0x75262FD12D0A1C84, netId); } // 0x75262FD12D0A1C84
	static int GET_STREAM_PLAY_TIME() { return invoke<int>(0x4E72BBDBCA58A3DB); } // 0x4E72BBDBCA58A3DB
	static Hash GET_VEHICLE_DEFAULT_HORN(Vehicle vehicle) { return invoke<Hash>(0x2165D55000219AC, vehicle); } // 0x2165D55000219AC
	static Hash _GET_VEHICLE_HORN_HASH(Vehicle vehicle) { return invoke<Hash>(0xACB5DCCA1EC76840, vehicle); } // 0xACB5DCCA1EC76840
	static BOOL HAS_SOUND_FINISHED(int soundId) { return invoke<BOOL>(0xFCBDCE714A7C88E5, soundId); } // 0xFCBDCE714A7C88E5
	static Any HINT_AMBIENT_AUDIO_BANK(Any p0, Any p1) { return invoke<Any>(0x8F8C0E370AE62F5C, p0, p1); } // 0x8F8C0E370AE62F5C
	static Any HINT_SCRIPT_AUDIO_BANK(Any p0, Any p1) { return invoke<Any>(0xFB380A29641EC31A, p0, p1); } // 0xFB380A29641EC31A
	static void INTERRUPT_CONVERSATION(Any p0, Any* p1, Any* p2) { invoke<Void>(0xA018A12E5C5C2FA6, p0, p1, p2); } // 0xA018A12E5C5C2FA6
	static BOOL IS_ALARM_PLAYING(char* alarmName) { return invoke<BOOL>(0x226435CB96CCFC8C, alarmName); } // 0x226435CB96CCFC8C
	static BOOL IS_AMBIENT_SPEECH_DISABLED(Ped ped) { return invoke<BOOL>(0x932C2D096A2C3FFF, ped); } // 0x932C2D096A2C3FFF
	static BOOL IS_AMBIENT_SPEECH_PLAYING(Ped p0) { return invoke<BOOL>(0x9072C8B49907BFAD, p0); } // 0x9072C8B49907BFAD
	static BOOL IS_AMBIENT_ZONE_ENABLED(char* ambientZone) { return invoke<BOOL>(0x1E2817A479A7F9B, ambientZone); } // 0x1E2817A479A7F9B
	static BOOL IS_ANY_SPEECH_PLAYING(Ped ped) { return invoke<BOOL>(0x729072355FA39EC9, ped); } // 0x729072355FA39EC9
	static BOOL IS_AUDIO_SCENE_ACTIVE(char* scene) { return invoke<BOOL>(0xB65B60556E2A9225, scene); } // 0xB65B60556E2A9225
	static BOOL IS_GAME_IN_CONTROL_OF_MUSIC() { return invoke<BOOL>(0x6D28DC1671E334FD); } // 0x6D28DC1671E334FD
	static BOOL IS_HORN_ACTIVE(Vehicle vehicle) { return invoke<BOOL>(0x9D6BFC12B05C6121, vehicle); } // 0x9D6BFC12B05C6121
	static BOOL IS_MISSION_COMPLETE_PLAYING() { return invoke<BOOL>(0x19A30C23F5827F8A); } // 0x19A30C23F5827F8A
	static BOOL IS_MOBILE_PHONE_CALL_ONGOING() { return invoke<BOOL>(0x7497D2CE2C30D24C); } // 0x7497D2CE2C30D24C
	static BOOL IS_MOBILE_PHONE_RADIO_ACTIVE() { return invoke<BOOL>(0xB35CE999E8EF317E); } // 0xB35CE999E8EF317E
	static BOOL IS_PED_IN_CURRENT_CONVERSATION(Ped ped) { return invoke<BOOL>(0x49E937F18F4020C, ped); } // 0x49E937F18F4020C
	static BOOL IS_PED_RINGTONE_PLAYING(Ped ped) { return invoke<BOOL>(0x1E8E5E20937E3137, ped); } // 0x1E8E5E20937E3137
	static BOOL _IS_PLAYER_VEHICLE_RADIO_ENABLED() { return invoke<BOOL>(0x5F43D83FD6738741); } // 0x5F43D83FD6738741
	static BOOL IS_RADIO_RETUNING() { return invoke<BOOL>(0xA151A7394A214E65); } // 0xA151A7394A214E65
	static BOOL IS_SCRIPTED_CONVERSATION_LOADED() { return invoke<BOOL>(0xDF0D54BE7A776737); } // 0xDF0D54BE7A776737
	static BOOL IS_SCRIPTED_CONVERSATION_ONGOING() { return invoke<BOOL>(0x16754C556D2EDE3D); } // 0x16754C556D2EDE3D
	static BOOL IS_SCRIPTED_SPEECH_PLAYING(Any p0) { return invoke<BOOL>(0xCC9AA18DCC7084F4, p0); } // 0xCC9AA18DCC7084F4
	static BOOL IS_STREAM_PLAYING() { return invoke<BOOL>(0xD11FA52EB849D978); } // 0xD11FA52EB849D978
	static BOOL _IS_VEHICLE_RADIO_LOUD(Vehicle vehicle) { return invoke<BOOL>(0x32A116663A4D5AC, vehicle); } // 0x32A116663A4D5AC
	static BOOL LOAD_STREAM(char* streamName, char* soundSet) { return invoke<BOOL>(0x1F1F957154EC51DF, streamName, soundSet); } // 0x1F1F957154EC51DF
	static BOOL LOAD_STREAM_WITH_START_OFFSET(char* streamName, int startOffset, char* soundSet) { return invoke<BOOL>(0x59C16B79F53B3712, streamName, startOffset, soundSet); } // 0x59C16B79F53B3712
	static int _MAX_RADIO_STATION_INDEX() { return invoke<int>(0xF1620ECB50E01DE7); } // 0xF1620ECB50E01DE7
	static void _0x0150B6FF25A9E2E5() { invoke<Void>(0x150B6FF25A9E2E5); } // 0x150B6FF25A9E2E5
	static void _0x01BB4D577D38BD9E(Any p0, float p1) { invoke<Void>(0x1BB4D577D38BD9E, p0, p1); } // 0x1BB4D577D38BD9E
	static void _0x02E93C796ABD3A97(BOOL p0) { invoke<Void>(0x2E93C796ABD3A97, p0); } // 0x2E93C796ABD3A97
	static void _0x031ACB6ABA18C729(char* radioStation, char* p1) { invoke<Void>(0x31ACB6ABA18C729, radioStation, p1); } // 0x31ACB6ABA18C729
	static void _0x044DBAD7A7FA2BE5(char* p0, char* p1) { invoke<Void>(0x44DBAD7A7FA2BE5, p0, p1); } // 0x44DBAD7A7FA2BE5
	static Any _0x0626A247D2405330() { return invoke<Any>(0x626A247D2405330); } // 0x626A247D2405330
	static void _0x062D5EAD4DA2FA6A() { invoke<Void>(0x62D5EAD4DA2FA6A); } // 0x62D5EAD4DA2FA6A
	static void _0x06C0023BED16DD6B(Any p0, BOOL p1) { invoke<Void>(0x6C0023BED16DD6B, p0, p1); } // 0x6C0023BED16DD6B
	static void _0x0B568201DD99F0EB(BOOL p0) { invoke<Void>(0xB568201DD99F0EB, p0); } // 0xB568201DD99F0EB
	static Any _0x0BE4BE946463F917(Any p0) { return invoke<Any>(0xBE4BE946463F917, p0); } // 0xBE4BE946463F917
	static BOOL _0x109697E2FFBAC8A1() { return invoke<BOOL>(0x109697E2FFBAC8A1); } // 0x109697E2FFBAC8A1
	static void _0x11579D940949C49E(Any p0) { invoke<Void>(0x11579D940949C49E, p0); } // 0x11579D940949C49E
	static void _0x12561FCBB62D5B9C(int p0) { invoke<Void>(0x12561FCBB62D5B9C, p0); } // 0x12561FCBB62D5B9C
	static void _0x149AEE66F0CB3A99(float p0, float p1) { invoke<Void>(0x149AEE66F0CB3A99, p0, p1); } // 0x149AEE66F0CB3A99
	static void _0x159B7318403A1CD8(Any p0) { invoke<Void>(0x159B7318403A1CD8, p0); } // 0x159B7318403A1CD8
	static void _0x1654F24A88A8E3FE(char* radioStation) { invoke<Void>(0x1654F24A88A8E3FE, radioStation); } // 0x1654F24A88A8E3FE
	static void _0x18EB48CFC41F2EA0(Any p0, float p1) { invoke<Void>(0x18EB48CFC41F2EA0, p0, p1); } // 0x18EB48CFC41F2EA0
	static void _0x19AF7ED9B9D23058() { invoke<Void>(0x19AF7ED9B9D23058); } // 0x19AF7ED9B9D23058
	static void _0x1B7ABE26CBCBF8C7(Any p0, Any p1, Any p2) { invoke<Void>(0x1B7ABE26CBCBF8C7, p0, p1, p2); } // 0x1B7ABE26CBCBF8C7
	static void _0x1C073274E065C6D2(Any p0, BOOL p1) { invoke<Void>(0x1C073274E065C6D2, p0, p1); } // 0x1C073274E065C6D2
	static void _0x2BE4BC731D039D5A(Any p0, BOOL p1) { invoke<Void>(0x2BE4BC731D039D5A, p0, p1); } // 0x2BE4BC731D039D5A
	static void _0x2C96CDB04FCA358E(float p0) { invoke<Void>(0x2C96CDB04FCA358E, p0); } // 0x2C96CDB04FCA358E
	static void _0x33E3C6C6F2F0B506(Any p0, float p1, float p2, float p3) { invoke<Void>(0x33E3C6C6F2F0B506, p0, p1, p2, p3); } // 0x33E3C6C6F2F0B506
	static Any _0x3A48AB4445D499BE() { return invoke<Any>(0x3A48AB4445D499BE); } // 0x3A48AB4445D499BE
	static Any _0x3D120012440E6683() { return invoke<Any>(0x3D120012440E6683); } // 0x3D120012440E6683
	static Any _0x40763EA7B9B783E7(Any p0, Any p1, Any p2) { return invoke<Any>(0x40763EA7B9B783E7, p0, p1, p2); } // 0x40763EA7B9B783E7
	static void _0x43FA0DFC5DF87815(Vehicle vehicle, BOOL p1) { invoke<Void>(0x43FA0DFC5DF87815, vehicle, p1); } // 0x43FA0DFC5DF87815
	static void _0x4E404A9361F75BB2(char* radioStation, char* p1, BOOL p2) { invoke<Void>(0x4E404A9361F75BB2, radioStation, p1, p2); } // 0x4E404A9361F75BB2
	static Any _0x544810ED9DB6BBE6() { return invoke<Any>(0x544810ED9DB6BBE6); } // 0x544810ED9DB6BBE6
	static void _0x58BB377BEC7CD5F4(BOOL p0, BOOL p1) { invoke<Void>(0x58BB377BEC7CD5F4, p0, p1); } // 0x58BB377BEC7CD5F4
	static void _0x59E7B488451F4D3A(Any p0, float p1) { invoke<Void>(0x59E7B488451F4D3A, p0, p1); } // 0x59E7B488451F4D3A
	static Any _0x5B50ABB1FE3746F4() { return invoke<Any>(0x5B50ABB1FE3746F4); } // 0x5B50ABB1FE3746F4
	static void _0x5B9853296731E88D(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0x5B9853296731E88D, p0, p1, p2, p3, p4, p5); } // 0x5B9853296731E88D
	static void _0x5D2BFAAB8D956E0E() { invoke<Void>(0x5D2BFAAB8D956E0E); } // 0x5D2BFAAB8D956E0E
	static BOOL _0x5DB8010EE71FDEF2(Vehicle vehicle) { return invoke<BOOL>(0x5DB8010EE71FDEF2, vehicle); } // 0x5DB8010EE71FDEF2
	static Any _0x5E203DA2BA15D436(Any p0) { return invoke<Any>(0x5E203DA2BA15D436, p0); } // 0x5E203DA2BA15D436
	static void _0x61631F5DF50D1C34(BOOL p0) { invoke<Void>(0x61631F5DF50D1C34, p0); } // 0x61631F5DF50D1C34
	static void _0x651D3228960D08AF(Any p0, Any p1) { invoke<Void>(0x651D3228960D08AF, p0, p1); } // 0x651D3228960D08AF
	static Any _0x6F259F82D873B8B8() { return invoke<Any>(0x6F259F82D873B8B8); } // 0x6F259F82D873B8B8
	static void _0x6FDDAD856E36988A(Any p0, BOOL p1) { invoke<Void>(0x6FDDAD856E36988A, p0, p1); } // 0x6FDDAD856E36988A
	static void _0x70B8EC8FC108A634(BOOL p0, Any p1) { invoke<Void>(0x70B8EC8FC108A634, p0, p1); } // 0x70B8EC8FC108A634
	static void _0x733ADF241531E5C2(char* name, float p1) { invoke<Void>(0x733ADF241531E5C2, name, p1); } // 0x733ADF241531E5C2
	static void _0x75773E11BA459E90(Any p0, BOOL p1) { invoke<Void>(0x75773E11BA459E90, p0, p1); } // 0x75773E11BA459E90
	static void _0x774BD811F656A122(char* radioStation, BOOL p1) { invoke<Void>(0x774BD811F656A122, radioStation, p1); } // 0x774BD811F656A122
	static void _0x7CDC8C3B89F661B3(Ped playerPed, Hash p1) { invoke<Void>(0x7CDC8C3B89F661B3, playerPed, p1); } // 0x7CDC8C3B89F661B3
	static void _0x7EC3C679D0E7E46B(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x7EC3C679D0E7E46B, p0, p1, p2, p3); } // 0x7EC3C679D0E7E46B
	static void _0x806058BBDC136E06() { invoke<Void>(0x806058BBDC136E06); } // 0x806058BBDC136E06
	static void _0x892B6AB8F33606F5(Any p0, Any p1) { invoke<Void>(0x892B6AB8F33606F5, p0, p1); } // 0x892B6AB8F33606F5
	static void _0x8A694D7A68F8DC38(Ped p0, char* p1, char* p2) { invoke<Void>(0x8A694D7A68F8DC38, p0, p1, p2); } // 0x8A694D7A68F8DC38
	static void _0x8BF907833BE275DE(float p0, float p1) { invoke<Void>(0x8BF907833BE275DE, p0, p1); } // 0x8BF907833BE275DE
	static void _0x9A53DED9921DE990(Any p0, Any p1) { invoke<Void>(0x9A53DED9921DE990, p0, p1); } // 0x9A53DED9921DE990
	static void _0x9AC92EED5E4793AB() { invoke<Void>(0x9AC92EED5E4793AB); } // 0x9AC92EED5E4793AB
	static void _0x9D3AF56E94C9AE98(Any p0, float p1) { invoke<Void>(0x9D3AF56E94C9AE98, p0, p1); } // 0x9D3AF56E94C9AE98
	static Any _0xA097AB275061FB21() { return invoke<Any>(0xA097AB275061FB21); } // 0xA097AB275061FB21
	static void _0xA5342D390CDA41D6(Any p0, BOOL p1) { invoke<Void>(0xA5342D390CDA41D6, p0, p1); } // 0xA5342D390CDA41D6
	static void _0xA5F377B175A699C5(Any p0) { invoke<Void>(0xA5F377B175A699C5, p0); } // 0xA5F377B175A699C5
	static Any _0xAA19F5572C38B564(Any* p0) { return invoke<Any>(0xAA19F5572C38B564, p0); } // 0xAA19F5572C38B564
	static void _0xB4BBFD9CD8B3922B(char* p0) { invoke<Void>(0xB4BBFD9CD8B3922B, p0); } // 0xB4BBFD9CD8B3922B
	static void _0xB542DE8C3D1CB210(BOOL p0) { invoke<Void>(0xB542DE8C3D1CB210, p0); } // 0xB542DE8C3D1CB210
	static void _0xB81CF134AEB56FFB() { invoke<Void>(0xB81CF134AEB56FFB); } // 0xB81CF134AEB56FFB
	static void _0xBEF34B1D9624D5DD(BOOL p0) { invoke<Void>(0xBEF34B1D9624D5DD, p0); } // 0xBEF34B1D9624D5DD
	static void _0xBF4DC1784BE94DFA(Any p0, BOOL p1, Any p2) { invoke<Void>(0xBF4DC1784BE94DFA, p0, p1, p2); } // 0xBF4DC1784BE94DFA
	static void _0xC15907D667F7CFB2(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xC15907D667F7CFB2, vehicle, toggle); } // 0xC15907D667F7CFB2
	static void _0xC1805D05E6D4FE10(Vehicle vehicle) { invoke<Void>(0xC1805D05E6D4FE10, vehicle); } // 0xC1805D05E6D4FE10
	static BOOL _0xC265DF9FB44A9FBD(Any p0) { return invoke<BOOL>(0xC265DF9FB44A9FBD, p0); } // 0xC265DF9FB44A9FBD
	static Any _0xC8B1B2425604CDD0() { return invoke<Any>(0xC8B1B2425604CDD0); } // 0xC8B1B2425604CDD0
	static void _0xC8EDE9BDBCCBA6D4(Any* p0, float p1, float p2, float p3) { invoke<Void>(0xC8EDE9BDBCCBA6D4, p0, p1, p2, p3); } // 0xC8EDE9BDBCCBA6D4
	static void _0xCADA5A0D0702381E(char* p0, char* soundset) { invoke<Void>(0xCADA5A0D0702381E, p0, soundset); } // 0xCADA5A0D0702381E
	static void _0xD01005D2BA2EB778(char* p0) { invoke<Void>(0xD01005D2BA2EB778, p0); } // 0xD01005D2BA2EB778
	static void _0xD2CC78CD3D0B50F9(Any p0, BOOL p1) { invoke<Void>(0xD2CC78CD3D0B50F9, p0, p1); } // 0xD2CC78CD3D0B50F9
	static void _0xD2DCCD8E16E20997(Any p0) { invoke<Void>(0xD2DCCD8E16E20997, p0); } // 0xD2DCCD8E16E20997
	static void _0xD57AAAE0E2214D11() { invoke<Void>(0xD57AAAE0E2214D11); } // 0xD57AAAE0E2214D11
	static void _0xDA07819E452FFE8F(Any p0) { invoke<Void>(0xDA07819E452FFE8F, p0); } // 0xDA07819E452FFE8F
	static void _0xDD6BCF9E94425DF9() { invoke<Void>(0xDD6BCF9E94425DF9); } // 0xDD6BCF9E94425DF9
	static void _0xDDC635D5B3262C56(char* p0) { invoke<Void>(0xDDC635D5B3262C56, p0); } // 0xDDC635D5B3262C56
	static void _0xE4E6DD5566D28C82() { invoke<Void>(0xE4E6DD5566D28C82); } // 0xE4E6DD5566D28C82
	static Any _0xE73364DB90778FFA() { return invoke<Any>(0xE73364DB90778FFA); } // 0xE73364DB90778FFA
	static void _0xEE066C7006C49C0A(Any p0, Any p1, Any* p2) { invoke<Void>(0xEE066C7006C49C0A, p0, p1, p2); } // 0xEE066C7006C49C0A
	static void _0xF154B8D1775B2DEC(BOOL p0) { invoke<Void>(0xF154B8D1775B2DEC, p0); } // 0xF154B8D1775B2DEC
	static void _0xF1F8157B8C3F171C(Any p0, char* p1, char* p2) { invoke<Void>(0xF1F8157B8C3F171C, p0, p1, p2); } // 0xF1F8157B8C3F171C
	static void _0xF3365489E0DD50F9(Any p0, BOOL p1) { invoke<Void>(0xF3365489E0DD50F9, p0, p1); } // 0xF3365489E0DD50F9
	static void _0xFBE20329593DEC9D(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xFBE20329593DEC9D, p0, p1, p2, p3); } // 0xFBE20329593DEC9D
	static void _0xFF266D1D0EB1195D() { invoke<Void>(0xFF266D1D0EB1195D); } // 0xFF266D1D0EB1195D
	static void OVERRIDE_TREVOR_RAGE(Any* p0) { invoke<Void>(0x13AD665062541A7E, p0); } // 0x13AD665062541A7E
	static void OVERRIDE_UNDERWATER_STREAM(Any* p0, BOOL p1) { invoke<Void>(0xF2A9CDABCEA04BD6, p0, p1); } // 0xF2A9CDABCEA04BD6
	static void OVERRIDE_VEH_HORN(Vehicle vehicle, BOOL override, int hornHash) { invoke<Void>(0x3CDC1E622CCE0356, vehicle, override, hornHash); } // 0x3CDC1E622CCE0356
	static void PAUSE_SCRIPTED_CONVERSATION(BOOL p0) { invoke<Void>(0x8530AD776CD72B12, p0); } // 0x8530AD776CD72B12
	static void _PLAY_AMBIENT_SPEECH1(Ped ped, char* speechName, char* speechParam) { invoke<Void>(0x8E04FEDD28D42462, ped, speechName, speechParam); } // 0x8E04FEDD28D42462
	static void _PLAY_AMBIENT_SPEECH2(Ped ped, char* speechName, char* speechParam) { invoke<Void>(0xC6941B4A3A8FBBB9, ped, speechName, speechParam); } // 0xC6941B4A3A8FBBB9
	static void _PLAY_AMBIENT_SPEECH_AT_COORDS(char* p0, char* p1, float p2, float p3, float p4, char* p5) { invoke<Void>(0xED640017ED337E45, p0, p1, p2, p3, p4, p5); } // 0xED640017ED337E45
	static void _PLAY_AMBIENT_SPEECH_WITH_VOICE(Ped p0, char* speechName, char* voiceName, char* speechParam, BOOL p4) { invoke<Void>(0x3523634255FC3318, p0, speechName, voiceName, speechParam, p4); } // 0x3523634255FC3318
	static void PLAY_END_CREDITS_MUSIC(BOOL play) { invoke<Void>(0xCD536C4D33DCC900, play); } // 0xCD536C4D33DCC900
	static void PLAY_MISSION_COMPLETE_AUDIO(char* audioName) { invoke<Void>(0xB138AAB8A70D3C69, audioName); } // 0xB138AAB8A70D3C69
	static void PLAY_PAIN(Ped ped, int painID, int p1) { invoke<Void>(0xBC9AE166038A5CEC, ped, painID, p1); } // 0xBC9AE166038A5CEC
	static void PLAY_PED_RINGTONE(char* ringtoneName, Ped ped, BOOL p2) { invoke<Void>(0xF9E56683CA8E11A5, ringtoneName, ped, p2); } // 0xF9E56683CA8E11A5
	static Any PLAY_POLICE_REPORT(char* name, float p1) { return invoke<Any>(0xDFEBD56D9BD1EB16, name, p1); } // 0xDFEBD56D9BD1EB16
	static void PLAY_SOUND(Player soundId, char* audioName, char* audioRef, BOOL p3, Any p4, BOOL p5) { invoke<Void>(0x7FF4944CC209192D, soundId, audioName, audioRef, p3, p4, p5); } // 0x7FF4944CC209192D
	static void PLAY_SOUND_FROM_COORD(int soundId, char* audioName, float x, float y, float z, char* audioRef, BOOL p6, int range, BOOL p8) { invoke<Void>(0x8D8686B622B88120, soundId, audioName, x, y, z, audioRef, p6, range, p8); } // 0x8D8686B622B88120
	static void PLAY_SOUND_FROM_ENTITY(int soundId, char* audioName, Entity entity, char* audioRef, BOOL p4, Any p5) { invoke<Void>(0xE65F427EB70AB1ED, soundId, audioName, entity, audioRef, p4, p5); } // 0xE65F427EB70AB1ED
	static void PLAY_SOUND_FRONTEND(int soundId, char* audioName, char* audioRef, BOOL p3) { invoke<Void>(0x67C540AA08E4A6F5, soundId, audioName, audioRef, p3); } // 0x67C540AA08E4A6F5
	static void PLAY_STREAM_FROM_OBJECT(Object object) { invoke<Void>(0xEBAA9B64D76356FD, object); } // 0xEBAA9B64D76356FD
	static void PLAY_STREAM_FROM_PED(Ped ped) { invoke<Void>(0x89049DD63C08B5D1, ped); } // 0x89049DD63C08B5D1
	static void PLAY_STREAM_FROM_VEHICLE(Vehicle vehicle) { invoke<Void>(0xB70374A758007DFA, vehicle); } // 0xB70374A758007DFA
	static void PLAY_STREAM_FRONTEND() { invoke<Void>(0x58FCE43488F9F5F4); } // 0x58FCE43488F9F5F4
	static BOOL PLAY_SYNCHRONIZED_AUDIO_EVENT(Any p0) { return invoke<BOOL>(0x8B2FD4560E55DD2D, p0); } // 0x8B2FD4560E55DD2D
	static void PLAY_VEHICLE_DOOR_CLOSE_SOUND(Vehicle vehicle, int p1) { invoke<Void>(0x62A456AA4769EF34, vehicle, p1); } // 0x62A456AA4769EF34
	static void PLAY_VEHICLE_DOOR_OPEN_SOUND(Vehicle vehicle, int p1) { invoke<Void>(0x3A539D52857EA82D, vehicle, p1); } // 0x3A539D52857EA82D
	static void PRELOAD_SCRIPT_CONVERSATION(BOOL p0, BOOL p1, BOOL p2, BOOL p3) { invoke<Void>(0x3B3CAD6166916D87, p0, p1, p2, p3); } // 0x3B3CAD6166916D87
	static void PRELOAD_SCRIPT_PHONE_CONVERSATION(BOOL p0, BOOL p1) { invoke<Void>(0x6004BCB0E226AAEA, p0, p1); } // 0x6004BCB0E226AAEA
	static BOOL PREPARE_ALARM(char* alarmName) { return invoke<BOOL>(0x9D74AE343DB65533, alarmName); } // 0x9D74AE343DB65533
	static BOOL PREPARE_MUSIC_EVENT(char* eventName) { return invoke<BOOL>(0x1E5185B72EF5158A, eventName); } // 0x1E5185B72EF5158A
	static Any PREPARE_SYNCHRONIZED_AUDIO_EVENT(char* p0, Any p1) { return invoke<Any>(0xC7ABCACA4985A766, p0, p1); } // 0xC7ABCACA4985A766
	static BOOL PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE(Any p0, Any* p1) { return invoke<BOOL>(0x29FE7CD1B7E2E75, p0, p1); } // 0x29FE7CD1B7E2E75
	static void REGISTER_SCRIPT_WITH_AUDIO(int p0) { invoke<Void>(0xC6ED9D5092438D91, p0); } // 0xC6ED9D5092438D91
	static void RELEASE_AMBIENT_AUDIO_BANK() { invoke<Void>(0x65475A218FFAA93D); } // 0x65475A218FFAA93D
	static void RELEASE_MISSION_AUDIO_BANK() { invoke<Void>(0xEC92A1BF0857187); } // 0xEC92A1BF0857187
	static void RELEASE_NAMED_SCRIPT_AUDIO_BANK(char* audioBank) { invoke<Void>(0x77ED170667F50170, audioBank); } // 0x77ED170667F50170
	static void RELEASE_SCRIPT_AUDIO_BANK() { invoke<Void>(0x7A2D8AD0A9EB9C3F); } // 0x7A2D8AD0A9EB9C3F
	static void RELEASE_SOUND_ID(int soundId) { invoke<Void>(0x353FC880830B88FA, soundId); } // 0x353FC880830B88FA
	static BOOL REQUEST_AMBIENT_AUDIO_BANK(char* p0, BOOL p1) { return invoke<BOOL>(0xFE02FFBED8CA9D99, p0, p1); } // 0xFE02FFBED8CA9D99
	static BOOL REQUEST_MISSION_AUDIO_BANK(char* p0, BOOL p1) { return invoke<BOOL>(0x7345BDD95E62E0F2, p0, p1); } // 0x7345BDD95E62E0F2
	static BOOL REQUEST_SCRIPT_AUDIO_BANK(char* p0, BOOL p1) { return invoke<BOOL>(0x2F844A8B08D76685, p0, p1); } // 0x2F844A8B08D76685
	static void RESET_PED_AUDIO_FLAGS(Ped ped) { invoke<Void>(0xF54BB7B61036F335, ped); } // 0xF54BB7B61036F335
	static void RESET_TREVOR_RAGE() { invoke<Void>(0xE78503B10C4314E0); } // 0xE78503B10C4314E0
	static void RESTART_SCRIPTED_CONVERSATION() { invoke<Void>(0x9AEB285D1818C9AC); } // 0x9AEB285D1818C9AC
	static void SET_AGGRESSIVE_HORNS(BOOL toggle) { invoke<Void>(0x395BF71085D1B1D9, toggle); } // 0x395BF71085D1B1D9
	static void SET_AMBIENT_VOICE_NAME(Ped ped, char* name) { invoke<Void>(0x6C8065A3B780185B, ped, name); } // 0x6C8065A3B780185B
	static void SET_AMBIENT_ZONE_LIST_STATE(char* p0, BOOL p1, BOOL p2) { invoke<Void>(0x9748FA4DE50CCE3E, p0, p1, p2); } // 0x9748FA4DE50CCE3E
	static void SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT(char* ambientZone, BOOL p1, BOOL p2) { invoke<Void>(0xF3638DAE8C4045E1, ambientZone, p1, p2); } // 0xF3638DAE8C4045E1
	static void SET_AMBIENT_ZONE_STATE(Any* p0, BOOL p1, BOOL p2) { invoke<Void>(0xBDA07E5950085E46, p0, p1, p2); } // 0xBDA07E5950085E46
	static void SET_AMBIENT_ZONE_STATE_PERSISTENT(char* ambientZone, BOOL p1, BOOL p2) { invoke<Void>(0x1D6650420CEC9D3B, ambientZone, p1, p2); } // 0x1D6650420CEC9D3B
	static void SET_ANIMAL_MOOD(Ped animal, int mood) { invoke<Void>(0xCC97B29285B1DC3B, animal, mood); } // 0xCC97B29285B1DC3B
	static void SET_AUDIO_FLAG(char* flagName, BOOL toggle) { invoke<Void>(0xB9EFD5C25018725A, flagName, toggle); } // 0xB9EFD5C25018725A
	static void SET_AUDIO_SCENE_VARIABLE(char* scene, char* variable, float value) { invoke<Void>(0xEF21A9EF089A2668, scene, variable, value); } // 0xEF21A9EF089A2668
	static void SET_AUDIO_VEHICLE_PRIORITY(Vehicle vehicle, Any p1) { invoke<Void>(0xE5564483E407F914, vehicle, p1); } // 0xE5564483E407F914
	static void SET_CUTSCENE_AUDIO_OVERRIDE(char* p0) { invoke<Void>(0x3B4BF5F0859204D9, p0); } // 0x3B4BF5F0859204D9
	static void SET_EMITTER_RADIO_STATION(char* emitterName, char* radioStation) { invoke<Void>(0xACF57305B12AF907, emitterName, radioStation); } // 0xACF57305B12AF907
	static void SET_FRONTEND_RADIO_ACTIVE(BOOL active) { invoke<Void>(0xF7F26C6E9CC9EBB8, active); } // 0xF7F26C6E9CC9EBB8
	static void SET_GPS_ACTIVE(BOOL active) { invoke<Void>(0x3BD3F52BA9B1E4E8, active); } // 0x3BD3F52BA9B1E4E8
	static void SET_HORN_ENABLED(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x76D683C108594D0E, vehicle, toggle); } // 0x76D683C108594D0E
	static void SET_INITIAL_PLAYER_STATION(char* radioStation) { invoke<Void>(0x88795F13FACDA88D, radioStation); } // 0x88795F13FACDA88D
	static void SET_MICROPHONE_POSITION(BOOL p0, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3) { invoke<Void>(0xB6AE90EDDE95C762, p0, x1, y1, z1, x2, y2, z2, x3, y3, z3); } // 0xB6AE90EDDE95C762
	static void SET_MOBILE_PHONE_RADIO_STATE(BOOL state) { invoke<Void>(0xBF286C554784F3DF, state); } // 0xBF286C554784F3DF
	static void SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY(BOOL Toggle) { invoke<Void>(0x1098355A16064BB3, Toggle); } // 0x1098355A16064BB3
	static void SET_PED_IS_DRUNK(Ped ped, BOOL toggle) { invoke<Void>(0x95D2D383D5396B8A, ped, toggle); } // 0x95D2D383D5396B8A
	static void _SET_PED_MUTE(Ped ped) { invoke<Void>(0x7A73D05A607734C7, ped); } // 0x7A73D05A607734C7
	static void _SET_PED_SCREAM(Ped ped) { invoke<Void>(0x40CF0D12D142A9E8, ped); } // 0x40CF0D12D142A9E8
	static void _SET_PED_TALK(Ped ped) { invoke<Void>(0x4ADA3F19BE4A6047, ped); } // 0x4ADA3F19BE4A6047
	static void SET_PLAYER_ANGRY(Ped playerPed, BOOL disabled) { invoke<Void>(0xEA241BB04110F091, playerPed, disabled); } // 0xEA241BB04110F091
	static void SET_RADIO_AUTO_UNFREEZE(BOOL toggle) { invoke<Void>(0xC1AA9F53CE982990, toggle); } // 0xC1AA9F53CE982990
	static void _SET_RADIO_STATION_DISABLED(char* stationName, BOOL Toggle) { invoke<Void>(0x94F2E83EAD7E6B82, stationName, Toggle); } // 0x94F2E83EAD7E6B82
	static void SET_RADIO_TO_STATION_INDEX(int radioStation) { invoke<Void>(0xA619B168B8A8570F, radioStation); } // 0xA619B168B8A8570F
	static void SET_RADIO_TO_STATION_NAME(char* stationName) { invoke<Void>(0xC69EDA28699D5107, stationName); } // 0xC69EDA28699D5107
	static void SET_RADIO_TRACK(char* radioStation, char* radioTrack) { invoke<Void>(0xB39786F201FEE30B, radioStation, radioTrack); } // 0xB39786F201FEE30B
	static void SET_SIREN_WITH_NO_DRIVER(Object* vehicle, ScrHandle* toggle) { invoke<Void>(0x1FEF0683B96EBCF2, vehicle, toggle); } // 0x1FEF0683B96EBCF2
	static void SET_STATIC_EMITTER_ENABLED(char* emitterName, BOOL toggle) { invoke<Void>(0x399D2D3B33F1B8EB, emitterName, toggle); } // 0x399D2D3B33F1B8EB
	static void _SET_SYNCHRONIZED_AUDIO_EVENT_POSITION_THIS_FRAME(char* p0, Entity p1) { invoke<Void>(0x950A154B8DAB6185, p0, p1); } // 0x950A154B8DAB6185
	static void SET_USER_RADIO_CONTROL_ENABLED(BOOL toggle) { invoke<Void>(0x19F21E63AE6EAE4E, toggle); } // 0x19F21E63AE6EAE4E
	static void SET_VARIABLE_ON_SOUND(int soundId, char* variableName, float value) { invoke<Void>(0xAD6B3148A78AE9B6, soundId, variableName, value); } // 0xAD6B3148A78AE9B6
	static void SET_VARIABLE_ON_STREAM(char* p0, float p1) { invoke<Void>(0x2F9D3834AEB9EF79, p0, p1); } // 0x2F9D3834AEB9EF79
	static void SET_VEHICLE_BOOST_ACTIVE(Vehicle vehicle, BOOL Toggle) { invoke<Void>(0x4A04DE7CAB2739A1, vehicle, Toggle); } // 0x4A04DE7CAB2739A1
	static void SET_VEHICLE_RADIO_ENABLED(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x3B988190C0AA6C0B, vehicle, toggle); } // 0x3B988190C0AA6C0B
	static void SET_VEHICLE_RADIO_LOUD(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xBB6F1CAEC68B0BCE, vehicle, toggle); } // 0xBB6F1CAEC68B0BCE
	static void SET_VEH_RADIO_STATION(Vehicle vehicle, char* radioStation) { invoke<Void>(0x1B9C0099CB942AC6, vehicle, radioStation); } // 0x1B9C0099CB942AC6
	static void SKIP_RADIO_FORWARD() { invoke<Void>(0x6DDBBDD98E2E9C25); } // 0x6DDBBDD98E2E9C25
	static void SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE() { invoke<Void>(0x9663FE6B7A61EB00); } // 0x9663FE6B7A61EB00
	static void _SOUND_VEHICLE_HORN_THIS_FRAME(Vehicle vehicle) { invoke<Void>(0x9C11908013EA4715, vehicle); } // 0x9C11908013EA4715
	static void SPECIAL_FRONTEND_EQUAL(float x, float y, float z) { invoke<Void>(0x21442F412E8DE56B, x, y, z); } // 0x21442F412E8DE56B
	static void START_ALARM(char* alarmName, BOOL p2) { invoke<Void>(0x355EF116C4C97B2, alarmName, p2); } // 0x355EF116C4C97B2
	static BOOL START_AUDIO_SCENE(char* scene) { return invoke<BOOL>(0x13A80FC08F6E4F2, scene); } // 0x13A80FC08F6E4F2
	static void START_PRELOADED_CONVERSATION() { invoke<Void>(0x23641AFE870AF385); } // 0x23641AFE870AF385
	static void START_SCRIPT_CONVERSATION(BOOL p0, BOOL p1, BOOL p2, BOOL p3) { invoke<Void>(0x6B17C62C9635D2DC, p0, p1, p2, p3); } // 0x6B17C62C9635D2DC
	static void START_SCRIPT_PHONE_CONVERSATION(BOOL p0, BOOL p1) { invoke<Void>(0x252E5F915EABB675, p0, p1); } // 0x252E5F915EABB675
	static void STOP_ALARM(char* alarmName, BOOL toggle) { invoke<Void>(0xA1CADDCD98415A41, alarmName, toggle); } // 0xA1CADDCD98415A41
	static void STOP_ALL_ALARMS(BOOL stop) { invoke<Void>(0x2F794A877ADD4C92, stop); } // 0x2F794A877ADD4C92
	static void STOP_AUDIO_SCENE(char* scene) { invoke<Void>(0xDFE8422B3B94E688, scene); } // 0xDFE8422B3B94E688
	static void STOP_AUDIO_SCENES() { invoke<Void>(0xBAC7FC81A75EC1A1); } // 0xBAC7FC81A75EC1A1
	static void STOP_CURRENT_PLAYING_AMBIENT_SPEECH(Ped ped) { invoke<Void>(0xB8BEC0CA6F0EDB0F, ped); } // 0xB8BEC0CA6F0EDB0F
	static void STOP_PED_RINGTONE(Ped ped) { invoke<Void>(0x6C5AE23EFA885092, ped); } // 0x6C5AE23EFA885092
	static void STOP_PED_SPEAKING(Ped ped, BOOL shaking) { invoke<Void>(0x9D64D7405520E3D3, ped, shaking); } // 0x9D64D7405520E3D3
	static Any STOP_SCRIPTED_CONVERSATION(BOOL p0) { return invoke<Any>(0xD79DEEFB53455EBA, p0); } // 0xD79DEEFB53455EBA
	static void STOP_SOUND(int soundId) { invoke<Void>(0xA3B0C41BA5CC0BB5, soundId); } // 0xA3B0C41BA5CC0BB5
	static void STOP_STREAM() { invoke<Void>(0xA4718A1419D18151); } // 0xA4718A1419D18151
	static BOOL STOP_SYNCHRONIZED_AUDIO_EVENT(Any p0) { return invoke<BOOL>(0x92D6A88E64A94430, p0); } // 0x92D6A88E64A94430
	static BOOL TRIGGER_MUSIC_EVENT(char* eventName) { return invoke<BOOL>(0x706D57B0F50DA710, eventName); } // 0x706D57B0F50DA710
	static void UNFREEZE_RADIO_STATION(char* radioStation) { invoke<Void>(0xFC00454CF60B91DD, radioStation); } // 0xFC00454CF60B91DD
	static void UNLOCK_MISSION_NEWS_STORY(int newsStory) { invoke<Void>(0xB165AB7C248B2DC1, newsStory); } // 0xB165AB7C248B2DC1
	static void UNREGISTER_SCRIPT_WITH_AUDIO() { invoke<Void>(0xA8638BE228D4751A); } // 0xA8638BE228D4751A
	static void USE_SIREN_AS_HORN(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xFA932DE350266EF8, vehicle, toggle); } // 0xFA932DE350266EF8
}

namespace BRAIN
{
	static void ADD_COVER_BLOCKING_AREA(float playerX, float playerY, float playerZ, float radiusX, float radiusY, float radiusZ, BOOL p6, BOOL p7, BOOL p8, BOOL p9) { invoke<Void>(0x45C597097DD7CB81, playerX, playerY, playerZ, radiusX, radiusY, radiusZ, p6, p7, p8, p9); } // 0x45C597097DD7CB81
	static ScrHandle ADD_COVER_POINT(float p0, float p1, float p2, float p3, Any p4, Any p5, Any p6, BOOL p7) { return invoke<ScrHandle>(0xD5C12A75C7B9497F, p0, p1, p2, p3, p4, p5, p6, p7); } // 0xD5C12A75C7B9497F
	static void ADD_PATROL_ROUTE_LINK(Any p0, Any p1) { invoke<Void>(0x23083260DEC3A551, p0, p1); } // 0x23083260DEC3A551
	static void ADD_PATROL_ROUTE_NODE(int p0, char* p1, float x1, float y1, float z1, float x2, float y2, float z2, int p8) { invoke<Void>(0x8EDF950167586B7C, p0, p1, x1, y1, z1, x2, y2, z2, p8); } // 0x8EDF950167586B7C
	static void ADD_SCRIPT_TO_RANDOM_PED(char* name, Hash model, float p2, float p3) { invoke<Void>(0x4EE5367468A65CCC, name, model, p2, p3); } // 0x4EE5367468A65CCC
	static void ADD_VEHICLE_SUBTASK_ATTACK_COORD(Ped ped, float x, float y, float z) { invoke<Void>(0x5CF0D8F9BBA0DD75, ped, x, y, z); } // 0x5CF0D8F9BBA0DD75
	static void ADD_VEHICLE_SUBTASK_ATTACK_PED(Ped ped, Ped ped2) { invoke<Void>(0x85F462BADC7DA47F, ped, ped2); } // 0x85F462BADC7DA47F
	static BOOL ASSISTED_MOVEMENT_IS_ROUTE_LOADED(char* route) { return invoke<BOOL>(0x60F9A4393A21F741, route); } // 0x60F9A4393A21F741
	static void ASSISTED_MOVEMENT_OVERRIDE_LOAD_DISTANCE_THIS_FRAME(float dist) { invoke<Void>(0x13945951E16EF912, dist); } // 0x13945951E16EF912
	static void ASSISTED_MOVEMENT_REMOVE_ROUTE(char* route) { invoke<Void>(0x3548536485DD792B, route); } // 0x3548536485DD792B
	static void ASSISTED_MOVEMENT_REQUEST_ROUTE(char* route) { invoke<Void>(0x817268968605947A, route); } // 0x817268968605947A
	static void ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES(char* route, int props) { invoke<Void>(0xD5002D78B7162E1B, route, props); } // 0xD5002D78B7162E1B
	static void CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(Ped ped) { invoke<Void>(0xC35B5CDB2824CF69, ped); } // 0xC35B5CDB2824CF69
	static void CLEAR_PED_SECONDARY_TASK(Ped ped) { invoke<Void>(0x176CECF6F920D707, ped); } // 0x176CECF6F920D707
	static void CLEAR_PED_TASKS(Ped ped) { invoke<Void>(0xE1EF3C1216AFF2CD, ped); } // 0xE1EF3C1216AFF2CD
	static void CLEAR_PED_TASKS_IMMEDIATELY(Ped ped) { invoke<Void>(0xAAA34F8A7CB32098, ped); } // 0xAAA34F8A7CB32098
	static Any CLEAR_SEQUENCE_TASK(Object* taskSequence) { return invoke<Any>(0x3841422E9C488D8C, taskSequence); } // 0x3841422E9C488D8C
	static void CLOSE_PATROL_ROUTE() { invoke<Void>(0xB043ECA801B8CBC1); } // 0xB043ECA801B8CBC1
	static Any CLOSE_SEQUENCE_TASK(Object taskSequence) { return invoke<Any>(0x39E72BC99E6360CB, taskSequence); } // 0x39E72BC99E6360CB
	static BOOL CONTROL_MOUNTED_WEAPON(Ped ped) { return invoke<BOOL>(0xDCFE42068FE0135A, ped); } // 0xDCFE42068FE0135A
	static void CREATE_PATROL_ROUTE() { invoke<Void>(0xAF8A443CCC8018DC); } // 0xAF8A443CCC8018DC
	static void DELETE_PATROL_ROUTE(char* patrolRoute) { invoke<Void>(0x7767DD9D65E91319, patrolRoute); } // 0x7767DD9D65E91319
	static void DISABLE_SCRIPT_BRAIN_SET(int brainSet) { invoke<Void>(0x14D8518E9760F08F, brainSet); } // 0x14D8518E9760F08F
	static BOOL DOES_SCENARIO_EXIST_IN_AREA(float x, float y, float z, float radius, BOOL b) { return invoke<BOOL>(0x5A59271FFADD33C1, x, y, z, radius, b); } // 0x5A59271FFADD33C1
	static BOOL DOES_SCENARIO_GROUP_EXIST(char* scenarioGroup) { return invoke<BOOL>(0xF9034C136C9E00D3, scenarioGroup); } // 0xF9034C136C9E00D3
	static BOOL DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA(float p0, float p1, float p2, Any* p3, float p4, BOOL p5) { return invoke<BOOL>(0xA9D0C2A3BBC86C1, p0, p1, p2, p3, p4, p5); } // 0xA9D0C2A3BBC86C1
	static BOOL DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS(float x, float y, float z) { return invoke<BOOL>(0xA98B8E3C088E5A31, x, y, z); } // 0xA98B8E3C088E5A31
	static void ENABLE_SCRIPT_BRAIN_SET(int brainSet) { invoke<Void>(0x67AA4D73F0CFA86B, brainSet); } // 0x67AA4D73F0CFA86B
	static int GET_ACTIVE_VEHICLE_MISSION_TYPE(Vehicle veh) { return invoke<int>(0x534AEBA6E5ED4CAB, veh); } // 0x534AEBA6E5ED4CAB
	static char* GET_CLIP_SET_FOR_SCRIPTED_GUN_TASK(int p0) { return invoke<char*>(0x3A8CADC7D37AACC5, p0); } // 0x3A8CADC7D37AACC5
	static BOOL GET_IS_TASK_ACTIVE(Ped ped, int taskNumber) { return invoke<BOOL>(0xB0760331C7AA4155, ped, taskNumber); } // 0xB0760331C7AA4155
	static BOOL GET_IS_WAYPOINT_RECORDING_LOADED(char* name) { return invoke<BOOL>(0xCB4E8BE8A0063C5D, name); } // 0xCB4E8BE8A0063C5D
	static int GET_NAVMESH_ROUTE_DISTANCE_REMAINING(Ped ped, float* distRemaining, BOOL* isPathReady) { return invoke<int>(0xC6F5C0BCDC74D62D, ped, distRemaining, isPathReady); } // 0xC6F5C0BCDC74D62D
	static int GET_NAVMESH_ROUTE_RESULT(Ped ped) { return invoke<int>(0x632E831F382A0FA8, ped); } // 0x632E831F382A0FA8
	static float GET_PED_DESIRED_MOVE_BLEND_RATIO(Ped ped) { return invoke<float>(0x8517D4A6CA8513ED, ped); } // 0x8517D4A6CA8513ED
	static float GET_PED_WAYPOINT_DISTANCE(Any p0) { return invoke<float>(0xE6A877C64CAF1BC5, p0); } // 0xE6A877C64CAF1BC5
	static int GET_PED_WAYPOINT_PROGRESS(Ped ped) { return invoke<int>(0x2720AAA75001E094, ped); } // 0x2720AAA75001E094
	static float GET_PHONE_GESTURE_ANIM_CURRENT_TIME(Ped ped) { return invoke<float>(0x47619ABE8B268C60, ped); } // 0x47619ABE8B268C60
	static float GET_PHONE_GESTURE_ANIM_TOTAL_TIME(Ped ped) { return invoke<float>(0x1EE0F68A7C25DEC6, ped); } // 0x1EE0F68A7C25DEC6
	static Vector3 GET_SCRIPTED_COVER_POINT_COORDS(ScrHandle coverpoint) { return invoke<Vector3>(0x594A1028FC2A3E85, coverpoint); } // 0x594A1028FC2A3E85
	static int GET_SCRIPT_TASK_STATUS(Ped targetPed, Hash taskHash) { return invoke<int>(0x77F1BEB8863288D5, targetPed, taskHash); } // 0x77F1BEB8863288D5
	static int GET_SEQUENCE_PROGRESS(Ped ped) { return invoke<int>(0xA9010CFE1E3533, ped); } // 0xA9010CFE1E3533
	static int GET_VEHICLE_WAYPOINT_PROGRESS(Vehicle vehicle) { return invoke<int>(0x9824CFF8FC66E159, vehicle); } // 0x9824CFF8FC66E159
	static Any GET_VEHICLE_WAYPOINT_TARGET_POINT(Any p0) { return invoke<Any>(0x416B62AC8B9E5BBD, p0); } // 0x416B62AC8B9E5BBD
	static float GET_WAYPOINT_DISTANCE_ALONG_ROUTE(char* p0, int p1) { return invoke<float>(0xA5B769058763E497, p0, p1); } // 0xA5B769058763E497
	static BOOL IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(Ped ped) { return invoke<BOOL>(0x8785E6E40C7A8818, ped); } // 0x8785E6E40C7A8818
	static BOOL IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK(Ped ped) { return invoke<BOOL>(0xA320EF046186FA3B, ped); } // 0xA320EF046186FA3B
	static BOOL IS_MOVE_BLEND_RATIO_RUNNING(Ped ped) { return invoke<BOOL>(0xD4D8636C0199A939, ped); } // 0xD4D8636C0199A939
	static BOOL IS_MOVE_BLEND_RATIO_SPRINTING(Ped ped) { return invoke<BOOL>(0x24A2AD74FA9814E2, ped); } // 0x24A2AD74FA9814E2
	static BOOL IS_MOVE_BLEND_RATIO_STILL(Ped ped) { return invoke<BOOL>(0x349CE7B56DAFD95C, ped); } // 0x349CE7B56DAFD95C
	static BOOL IS_MOVE_BLEND_RATIO_WALKING(Ped ped) { return invoke<BOOL>(0xF133BBBE91E1691F, ped); } // 0xF133BBBE91E1691F
	static BOOL IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE(Object object) { return invoke<BOOL>(0xCCBA154209823057, object); } // 0xCCBA154209823057
	static BOOL IS_PED_ACTIVE_IN_SCENARIO(Ped ped) { return invoke<BOOL>(0xAA135F9482C82CC3, ped); } // 0xAA135F9482C82CC3
	static BOOL IS_PED_BEING_ARRESTED(Ped ped) { return invoke<BOOL>(0x90A09F3A45FED688, ped); } // 0x90A09F3A45FED688
	static BOOL IS_PED_CUFFED(Ped ped) { return invoke<BOOL>(0x74E559B3BC910685, ped); } // 0x74E559B3BC910685
	static BOOL IS_PED_GETTING_UP(Ped ped) { return invoke<BOOL>(0x2A74E1D5F2F00EEC, ped); } // 0x2A74E1D5F2F00EEC
	static BOOL IS_PED_IN_WRITHE(Ped ped) { return invoke<BOOL>(0xDEB6D52126E7D640, ped); } // 0xDEB6D52126E7D640
	static BOOL IS_PED_RUNNING(Ped ped) { return invoke<BOOL>(0xC5286FFC176F28A2, ped); } // 0xC5286FFC176F28A2
	static BOOL IS_PED_RUNNING_ARREST_TASK(Ped ped) { return invoke<BOOL>(0x3DC52677769B4AE0, ped); } // 0x3DC52677769B4AE0
	static BOOL IS_PED_SPRINTING(Ped ped) { return invoke<BOOL>(0x57E457CD2C0FC168, ped); } // 0x57E457CD2C0FC168
	static BOOL IS_PED_STILL(Ped ped) { return invoke<BOOL>(0xAC29253EEF8F0180, ped); } // 0xAC29253EEF8F0180
	static BOOL IS_PED_STRAFING(Ped ped) { return invoke<BOOL>(0xE45B7F222DE47E09, ped); } // 0xE45B7F222DE47E09
	static BOOL IS_PED_WALKING(Ped ped) { return invoke<BOOL>(0xDE4C184B2B9B071A, ped); } // 0xDE4C184B2B9B071A
	static BOOL IS_PLAYING_PHONE_GESTURE_ANIM(Ped ped) { return invoke<BOOL>(0xB8EBB1E9D3588C10, ped); } // 0xB8EBB1E9D3588C10
	static BOOL IS_SCENARIO_GROUP_ENABLED(char* scenarioGroup) { return invoke<BOOL>(0x367A09DED4E05B99, scenarioGroup); } // 0x367A09DED4E05B99
	static BOOL IS_SCENARIO_OCCUPIED(float p0, float p1, float p2, float p3, BOOL p4) { return invoke<BOOL>(0x788756D73AC2E07C, p0, p1, p2, p3, p4); } // 0x788756D73AC2E07C
	static BOOL IS_SCENARIO_TYPE_ENABLED(char* scenarioType) { return invoke<BOOL>(0x3A815DB3EA088722, scenarioType); } // 0x3A815DB3EA088722
	static BOOL IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED(Any p0) { return invoke<BOOL>(0xE03B3F2D3DC59B64, p0); } // 0xE03B3F2D3DC59B64
	static BOOL IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE(Any p0) { return invoke<BOOL>(0xF5134943EA29868C, p0); } // 0xF5134943EA29868C
	static BOOL IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE() { return invoke<BOOL>(0xC5042CC6F5E3D450); } // 0xC5042CC6F5E3D450
	static void _0x0B40ED49D7D6FF84() { invoke<Void>(0xB40ED49D7D6FF84); } // 0xB40ED49D7D6FF84
	static void _0x19D1B791CB3670FE(Any p0, Any p1) { invoke<Void>(0x19D1B791CB3670FE, p0, p1); } // 0x19D1B791CB3670FE
	static void _0x1F351CF1C6475734(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { invoke<Void>(0x1F351CF1C6475734, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); } // 0x1F351CF1C6475734
	static BOOL _0x30ED88D5E0C56A37(Any p0) { return invoke<BOOL>(0x30ED88D5E0C56A37, p0); } // 0x30ED88D5E0C56A37
	static BOOL _0x3E38E28A1D80DDF6(Ped ped) { return invoke<BOOL>(0x3E38E28A1D80DDF6, ped); } // 0x3E38E28A1D80DDF6
	static void _0x4D953DF78EBF8158() { invoke<Void>(0x4D953DF78EBF8158); } // 0x4D953DF78EBF8158
	static BOOL _0x621C6E4729388E41(Ped ped) { return invoke<BOOL>(0x621C6E4729388E41, ped); } // 0x621C6E4729388E41
	static void _0x6D6840CEE8845831(char* action) { invoke<Void>(0x6D6840CEE8845831, action); } // 0x6D6840CEE8845831
	static void _0x6E91B04E08773030(char* action) { invoke<Void>(0x6E91B04E08773030, action); } // 0x6E91B04E08773030
	static char* _0x717E4D1F2048376D(Ped ped) { return invoke<char*>(0x717E4D1F2048376D, ped); } // 0x717E4D1F2048376D
	static void _0x88E32DB8C1A4AA4B(Ped ped, float p1) { invoke<Void>(0x88E32DB8C1A4AA4B, ped, p1); } // 0x88E32DB8C1A4AA4B
	static void _0x8C33220C8D78CA0D(Any p0, Any p1) { invoke<Void>(0x8C33220C8D78CA0D, p0, p1); } // 0x8C33220C8D78CA0D
	static void _0x8FD89A6240813FD0(Ped ped, BOOL p1, BOOL p2) { invoke<Void>(0x8FD89A6240813FD0, ped, p1, p2); } // 0x8FD89A6240813FD0
	static BOOL _0x921CE12C489C4C41(int PlayerID) { return invoke<BOOL>(0x921CE12C489C4C41, PlayerID); } // 0x921CE12C489C4C41
	static void _0x92C360B5F15D2302(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0x92C360B5F15D2302, p0, p1, p2, p3, p4, p5, p6); } // 0x92C360B5F15D2302
	static BOOL _0xA7FFBA498E4AAF67(Ped ped, char* p1) { return invoke<BOOL>(0xA7FFBA498E4AAF67, ped, p1); } // 0xA7FFBA498E4AAF67
	static Any _0xAB13A5565480B6D9(Any p0, Any p1) { return invoke<Any>(0xAB13A5565480B6D9, p0, p1); } // 0xAB13A5565480B6D9
	static BOOL _0xB4F47213DF45A64C(Ped ped, char* p1) { return invoke<BOOL>(0xB4F47213DF45A64C, ped, p1); } // 0xB4F47213DF45A64C
	static Any _0xD01015C7316AE176(Ped ped, char* p1) { return invoke<Any>(0xD01015C7316AE176, ped, p1); } // 0xD01015C7316AE176
	static void _0xE70BA7B90F8390DC(Any p0, Any p1, BOOL p2, Any p3) { invoke<Void>(0xE70BA7B90F8390DC, p0, p1, p2, p3); } // 0xE70BA7B90F8390DC
	static void OPEN_PATROL_ROUTE(char* patrolRoute) { invoke<Void>(0xA36BFB5EE89F3D82, patrolRoute); } // 0xA36BFB5EE89F3D82
	static Any OPEN_SEQUENCE_TASK(Object* taskSequence) { return invoke<Any>(0xE8854A4326B9E12B, taskSequence); } // 0xE8854A4326B9E12B
	static BOOL PED_HAS_USE_SCENARIO_TASK(Ped ped) { return invoke<BOOL>(0x295E3CCEC879CCD7, ped); } // 0x295E3CCEC879CCD7
	static void PLAY_ANIM_ON_RUNNING_SCENARIO(Ped ped, char* animDict, char* animName) { invoke<Void>(0x748040460F8DF5DC, ped, animDict, animName); } // 0x748040460F8DF5DC
	static void PLAY_ENTITY_SCRIPTED_ANIM(Any p0, Any* p1, Any* p2, Any* p3, float p4, float p5) { invoke<Void>(0x77A1EEC547E7FCF1, p0, p1, p2, p3, p4, p5); } // 0x77A1EEC547E7FCF1
	static void REGISTER_OBJECT_SCRIPT_BRAIN(char* scriptName, Hash objectName, int p2, float p3, int p4, int p5) { invoke<Void>(0xBE84C318BA6EC22, scriptName, objectName, p2, p3, p4, p5); } // 0xBE84C318BA6EC22
	static void REGISTER_WORLD_POINT_SCRIPT_BRAIN(Any* p0, float p1, Any p2) { invoke<Void>(0x3CDC7136613284BD, p0, p1, p2); } // 0x3CDC7136613284BD
	static void REMOVE_ALL_COVER_BLOCKING_AREAS() { invoke<Void>(0xDB6708C0B46F56D8); } // 0xDB6708C0B46F56D8
	static void REMOVE_COVER_POINT(ScrHandle coverpoint) { invoke<Void>(0xAE287C923D891715, coverpoint); } // 0xAE287C923D891715
	static void REMOVE_WAYPOINT_RECORDING(char* name) { invoke<Void>(0xFF1B8B4AA1C25DC8, name); } // 0xFF1B8B4AA1C25DC8
	static void REQUEST_WAYPOINT_RECORDING(char* name) { invoke<Void>(0x9EEFB62EB27B5792, name); } // 0x9EEFB62EB27B5792
	static void RESET_EXCLUSIVE_SCENARIO_GROUP() { invoke<Void>(0x4202BBCB8684563D); } // 0x4202BBCB8684563D
	static void RESET_SCENARIO_GROUPS_ENABLED() { invoke<Void>(0xDD902D0349AFAD3A); } // 0xDD902D0349AFAD3A
	static void RESET_SCENARIO_TYPES_ENABLED() { invoke<Void>(0xD40EE2A7F2B2D6D); } // 0xD40EE2A7F2B2D6D
	static void SET_ANIM_LOOPED(Any p0, BOOL p1, Any p2, BOOL p3) { invoke<Void>(0x70033C3CC29A1FF4, p0, p1, p2, p3); } // 0x70033C3CC29A1FF4
	static void SET_ANIM_RATE(Any p0, float p1, Any p2, BOOL p3) { invoke<Void>(0x32D49C5E359C847, p0, p1, p2, p3); } // 0x32D49C5E359C847
	static void SET_ANIM_WEIGHT(Any p0, float p1, Any p2, Any p3, BOOL p4) { invoke<Void>(0x207F1A47C0342F48, p0, p1, p2, p3, p4); } // 0x207F1A47C0342F48
	static void SET_DRIVEBY_TASK_TARGET(Ped shootingPed, Ped targetPed, Vehicle targetVehicle, float x, float y, float z) { invoke<Void>(0xE5B302114D8162EE, shootingPed, targetPed, targetVehicle, x, y, z); } // 0xE5B302114D8162EE
	static void SET_DRIVE_TASK_CRUISE_SPEED(Ped driver, float cruiseSpeed) { invoke<Void>(0x5C9B84BD7D31D908, driver, cruiseSpeed); } // 0x5C9B84BD7D31D908
	static void SET_DRIVE_TASK_DRIVING_STYLE(Ped ped, int drivingStyle) { invoke<Void>(0xDACE1BE37D88AF67, ped, drivingStyle); } // 0xDACE1BE37D88AF67
	static void SET_DRIVE_TASK_MAX_CRUISE_SPEED(Any p0, float p1) { invoke<Void>(0x404A5AA9B9F0B746, p0, p1); } // 0x404A5AA9B9F0B746
	static void SET_EXCLUSIVE_SCENARIO_GROUP(char* scenarioGroup) { invoke<Void>(0x535E97E1F7FC0C6A, scenarioGroup); } // 0x535E97E1F7FC0C6A
	static void SET_GLOBAL_MIN_BIRD_FLIGHT_HEIGHT(float height) { invoke<Void>(0x6C6B148586F934F7, height); } // 0x6C6B148586F934F7
	static void SET_HIGH_FALL_TASK(Ped ped, Any p1, Any p2, Any p3) { invoke<Void>(0x8C825BDC7741D37C, ped, p1, p2, p3); } // 0x8C825BDC7741D37C
	static void SET_MOUNTED_WEAPON_TARGET(Ped shootingPed, Ped targetPed, Vehicle targetVehicle, float x, float y, float z) { invoke<Void>(0xCCD892192C6D2BB9, shootingPed, targetPed, targetVehicle, x, y, z); } // 0xCCD892192C6D2BB9
	static void SET_NEXT_DESIRED_MOVE_STATE(float p0) { invoke<Void>(0xF1B9F16E89E2C93A, p0); } // 0xF1B9F16E89E2C93A
	static void SET_PARACHUTE_TASK_TARGET(Ped ped, float x, float y, float z) { invoke<Void>(0xC313379AF0FCEDA7, ped, x, y, z); } // 0xC313379AF0FCEDA7
	static void SET_PARACHUTE_TASK_THRUST(Ped ped, float thrust) { invoke<Void>(0x729BAC1B8C64317, ped, thrust); } // 0x729BAC1B8C64317
	static void SET_PED_DESIRED_MOVE_BLEND_RATIO(Ped ped, float p1) { invoke<Void>(0x1E982AC8716912C5, ped, p1); } // 0x1E982AC8716912C5
	static void SET_PED_PATH_AVOID_FIRE(Ped ped, BOOL avoidFire) { invoke<Void>(0x4455517B28441E60, ped, avoidFire); } // 0x4455517B28441E60
	static void SET_PED_PATH_CAN_DROP_FROM_HEIGHT(Ped ped, BOOL Toggle) { invoke<Void>(0xE361C5C71C431A4F, ped, Toggle); } // 0xE361C5C71C431A4F
	static Any SET_PED_PATH_CAN_USE_CLIMBOVERS(Ped ped, BOOL Toggle) { return invoke<Any>(0x8E06A6FE76C9EFF4, ped, Toggle); } // 0x8E06A6FE76C9EFF4
	static Any SET_PED_PATH_CAN_USE_LADDERS(Ped ped, BOOL Toggle) { return invoke<Any>(0x77A5B103C87F476E, ped, Toggle); } // 0x77A5B103C87F476E
	static void SET_PED_PATH_PREFER_TO_AVOID_WATER(Ped ped, BOOL avoidWater) { invoke<Void>(0x38FE1EC73743793C, ped, avoidWater); } // 0x38FE1EC73743793C
	static void SET_PED_PATHS_WIDTH_PLANT(Ped ped, BOOL mayEnterWater) { invoke<Void>(0xF35425A4204367EC, ped, mayEnterWater); } // 0xF35425A4204367EC
	static Any SET_PED_WAYPOINT_ROUTE_OFFSET(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0xED98E10B0AFCE4B4, p0, p1, p2, p3); } // 0xED98E10B0AFCE4B4
	static void SET_SCENARIO_GROUP_ENABLED(char* scenarioGroup, BOOL p1) { invoke<Void>(0x2C8E5B49848664E, scenarioGroup, p1); } // 0x2C8E5B49848664E
	static void SET_SCENARIO_TYPE_ENABLED(char* scenarioType, BOOL toggle) { invoke<Void>(0xEB47EC4E34FB7EE1, scenarioType, toggle); } // 0xEB47EC4E34FB7EE1
	static void SET_SEQUENCE_TO_REPEAT(Object taskSequence, BOOL repeat) { invoke<Void>(0x58C70CF3A41E4AE7, taskSequence, repeat); } // 0x58C70CF3A41E4AE7
	static void _SET_TASK_PROPERTY_BOOL(Ped ped, char* p1, BOOL p2) { invoke<Void>(0xB0A6CFD2C69C1088, ped, p1, p2); } // 0xB0A6CFD2C69C1088
	static void _SET_TASK_PROPERTY_FLOAT(Ped ped, char* p1, float p2) { invoke<Void>(0xD5BB4025AE449A4E, ped, p1, p2); } // 0xD5BB4025AE449A4E
	static void SET_TASK_VEHICLE_CHASE_BEHAVIOR_FLAG(Ped ped, int flag, BOOL set) { invoke<Void>(0xCC665AAC360D31E7, ped, flag, set); } // 0xCC665AAC360D31E7
	static void SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE(Ped ped, float distance) { invoke<Void>(0x639B642FACBE4EDD, ped, distance); } // 0x639B642FACBE4EDD
	static void STOP_ANIM_PLAYBACK(Ped ped, int p1, BOOL p2) { invoke<Void>(0xEE08C992D238C5D1, ped, p1, p2); } // 0xEE08C992D238C5D1
	static void STOP_ANIM_TASK(Ped ped, char* animDictionary, char* animationName, float p3) { invoke<Void>(0x97FF36A1D40EA00A, ped, animDictionary, animationName, p3); } // 0x97FF36A1D40EA00A
	static void TASK_ACHIEVE_HEADING(Ped ped, float heading, int timeout) { invoke<Void>(0x93B93A37987F1F3D, ped, heading, timeout); } // 0x93B93A37987F1F3D
	static void TASK_AIM_GUN_AT_COORD(Ped ped, float x, float y, float z, int time, BOOL p5, BOOL p6) { invoke<Void>(0x6671F3EEC681BDA1, ped, x, y, z, time, p5, p6); } // 0x6671F3EEC681BDA1
	static void TASK_AIM_GUN_AT_ENTITY(Ped ped, Entity entity, int duration, BOOL p3) { invoke<Void>(0x9B53BB6E8943AF53, ped, entity, duration, p3); } // 0x9B53BB6E8943AF53
	static void TASK_AIM_GUN_SCRIPTED(Ped ped, Hash scriptTask, BOOL p2, BOOL p3) { invoke<Void>(0x7A192BE16D373D00, ped, scriptTask, p2, p3); } // 0x7A192BE16D373D00
	static void TASK_AIM_GUN_SCRIPTED_WITH_TARGET(Any p0, Any p1, float p2, float p3, float p4, Any p5, BOOL p6, BOOL p7) { invoke<Void>(0x8605AF0DE8B3A5AC, p0, p1, p2, p3, p4, p5, p6, p7); } // 0x8605AF0DE8B3A5AC
	static void TASK_ARREST_PED(Ped ped, Ped target) { invoke<Void>(0xF3B9A78A178572B1, ped, target); } // 0xF3B9A78A178572B1
	static void TASK_BOAT_MISSION(Ped pedDriver, Vehicle boat, Any p2, Any p3, float x, float y, float z, Any p7, float maxSpeed, int drivingStyle, float p10, Any p11) { invoke<Void>(0x15C86013127CE63F, pedDriver, boat, p2, p3, x, y, z, p7, maxSpeed, drivingStyle, p10, p11); } // 0x15C86013127CE63F
	static void TASK_CHAT_TO_PED(Ped ped, Ped target, Any p2, float p3, float p4, float p5, float p6, float p7) { invoke<Void>(0x8C338E0263E4FD19, ped, target, p2, p3, p4, p5, p6, p7); } // 0x8C338E0263E4FD19
	static void TASK_CLEAR_DEFENSIVE_AREA(Any p0) { invoke<Void>(0x95A6C46A31D1917D, p0); } // 0x95A6C46A31D1917D
	static void TASK_CLEAR_LOOK_AT(Ped ped) { invoke<Void>(0xF804F1DB19B9689, ped); } // 0xF804F1DB19B9689
	static void TASK_CLIMB(Ped ped, BOOL unused) { invoke<Void>(0x89D9FCC2435112F1, ped, unused); } // 0x89D9FCC2435112F1
	static void TASK_CLIMB_LADDER(Ped ped, int p1) { invoke<Void>(0xB6C987F9285A3814, ped, p1); } // 0xB6C987F9285A3814
	static void TASK_COMBAT_HATED_TARGETS_AROUND_PED(Ped ped, float radius, int p2) { invoke<Void>(0x7BF835BB9E2698C8, ped, radius, p2); } // 0x7BF835BB9E2698C8
	static void TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED(Any p0, float p1, Any p2, Any p3) { invoke<Void>(0x2BBA30B854534A0C, p0, p1, p2, p3); } // 0x2BBA30B854534A0C
	static void TASK_COMBAT_HATED_TARGETS_IN_AREA(Ped ped, float x, float y, float z, float radius, Any p5) { invoke<Void>(0x4CF5F55DAC3280A0, ped, x, y, z, radius, p5); } // 0x4CF5F55DAC3280A0
	static void TASK_COMBAT_PED(Ped ped, Ped targetPed, int p2, int p3) { invoke<Void>(0xF166E48407BAC484, ped, targetPed, p2, p3); } // 0xF166E48407BAC484
	static void TASK_COMBAT_PED_TIMED(Any p0, Ped ped, int p2, Any p3) { invoke<Void>(0x944F30DCB7096BDE, p0, ped, p2, p3); } // 0x944F30DCB7096BDE
	static void TASK_COWER(Ped ped, int duration) { invoke<Void>(0x3EB1FE9E8E908E15, ped, duration); } // 0x3EB1FE9E8E908E15
	static void TASK_DRIVE_BY(Ped driverPed, Ped targetPed, Vehicle targetVehicle, float targetX, float targetY, float targetZ, float distanceToShoot, int pedAccuracy, BOOL p8, Hash firingPattern) { invoke<Void>(0x2F8AF0E82773A171, driverPed, targetPed, targetVehicle, targetX, targetY, targetZ, distanceToShoot, pedAccuracy, p8, firingPattern); } // 0x2F8AF0E82773A171
	static void TASK_ENTER_VEHICLE(Ped ped, Vehicle vehicle, int timeout, int seat, float speed, int flag, Any p6) { invoke<Void>(0xC20E50AA46D09CA8, ped, vehicle, timeout, seat, speed, flag, p6); } // 0xC20E50AA46D09CA8
	static void TASK_EVERYONE_LEAVE_VEHICLE(Vehicle vehicle) { invoke<Void>(0x7F93691AB4B92272, vehicle); } // 0x7F93691AB4B92272
	static void TASK_EXIT_COVER(Any p0, Any p1, float p2, float p3, float p4) { invoke<Void>(0x79B258E397854D29, p0, p1, p2, p3, p4); } // 0x79B258E397854D29
	static void TASK_EXTEND_ROUTE(float x, float y, float z) { invoke<Void>(0x1E7889778264843A, x, y, z); } // 0x1E7889778264843A
	static void TASK_FLUSH_ROUTE() { invoke<Void>(0x841142A1376E9006); } // 0x841142A1376E9006
	static void TASK_FOLLOW_NAV_MESH_TO_COORD(Ped ped, float x, float y, float z, float speed, int timeout, float stoppingRange, BOOL persistFollowing, float unk) { invoke<Void>(0x15D3A79D4E44B913, ped, x, y, z, speed, timeout, stoppingRange, persistFollowing, unk); } // 0x15D3A79D4E44B913
	static void TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED(Ped ped, float x, float y, float z, float speed, int timeout, float unkFloat, int unkInt, float unkX, float unkY, float unkZ, float unk_40000f) { invoke<Void>(0x17F58B88D085DBAC, ped, x, y, z, speed, timeout, unkFloat, unkInt, unkX, unkY, unkZ, unk_40000f); } // 0x17F58B88D085DBAC
	static void TASK_FOLLOW_POINT_ROUTE(Ped ped, float speed, int unknown) { invoke<Void>(0x595583281858626E, ped, speed, unknown); } // 0x595583281858626E
	static void TASK_FOLLOW_TO_OFFSET_OF_ENTITY(Ped ped, Entity entity, float offsetX, float offsetY, float offsetZ, float movementSpeed, int timeout, float stoppingRange, BOOL persistFollowing) { invoke<Void>(0x304AE42E357B8C7E, ped, entity, offsetX, offsetY, offsetZ, movementSpeed, timeout, stoppingRange, persistFollowing); } // 0x304AE42E357B8C7E
	static void TASK_FOLLOW_WAYPOINT_RECORDING(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x759591819534F7B, p0, p1, p2, p3, p4); } // 0x759591819534F7B
	static void TASK_FORCE_MOTION_STATE(Ped ped, Hash state, BOOL p2) { invoke<Void>(0x4F056E1AFFEF17AB, ped, state, p2); } // 0x4F056E1AFFEF17AB
	static void _TASK_GET_OFF_BOAT(Ped ped, Vehicle boat) { invoke<Void>(0x9C00E77AF14B2DFF, ped, boat); } // 0x9C00E77AF14B2DFF
	static void TASK_GO_STRAIGHT_TO_COORD(Ped ped, float x, float y, float z, float speed, int timeout, float targetHeading, float distanceToSlide) { invoke<Void>(0xD76B57B44F1E6F8B, ped, x, y, z, speed, timeout, targetHeading, distanceToSlide); } // 0xD76B57B44F1E6F8B
	static void TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY(Entity entity1, Entity entity2, float p2, float p3, float p4, float p5, Any p6) { invoke<Void>(0x61E360B7E040D12E, entity1, entity2, p2, p3, p4, p5, p6); } // 0x61E360B7E040D12E
	static void TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(Ped pedHandle, float goToLocationX, float goToLocationY, float goToLocationZ, float focusLocationX, float focusLocationY, float focusLocationZ, float speed, BOOL shootAtEnemies, float distanceToStopAt, float noRoadsDistance, BOOL unkTrue, int unkFlag, int aimingFlag, Hash firingPattern) { invoke<Void>(0xA55547801EB331FC, pedHandle, goToLocationX, goToLocationY, goToLocationZ, focusLocationX, focusLocationY, focusLocationZ, speed, shootAtEnemies, distanceToStopAt, noRoadsDistance, unkTrue, unkFlag, aimingFlag, firingPattern); } // 0xA55547801EB331FC
	static void TASK_GO_TO_COORD_ANY_MEANS(Ped ped, float x, float y, float z, float speed, Any p5, BOOL p6, int walkingStyle, float p8) { invoke<Void>(0x5BC448CB78FA3E88, ped, x, y, z, speed, p5, p6, walkingStyle, p8); } // 0x5BC448CB78FA3E88
	static void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS(Ped ped, float x, float y, float z, float speed, Any p5, BOOL p6, int walkingStyle, float p8, Any p9, Any p10, Any p11) { invoke<Void>(0x1DD45F9ECFDB1BC9, ped, x, y, z, speed, p5, p6, walkingStyle, p8, p9, p10, p11); } // 0x1DD45F9ECFDB1BC9
	static void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED(Ped ped, float x, float y, float z, float speed, Any p5, BOOL p6, int walkingStyle, float p8, Any p9, Any p10, Any p11, Any p12) { invoke<Void>(0xB8ECD61F531A7B02, ped, x, y, z, speed, p5, p6, walkingStyle, p8, p9, p10, p11, p12); } // 0xB8ECD61F531A7B02
	static void TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD(Ped ped, float x, float y, float z, float aimAtX, float aimAtY, float aimAtZ, float moveSpeed, BOOL p8, float p9, float p10, BOOL p11, Any flags, BOOL p13, Hash firingPattern) { invoke<Void>(0x11315AB3385B8AC0, ped, x, y, z, aimAtX, aimAtY, aimAtZ, moveSpeed, p8, p9, p10, p11, flags, p13, firingPattern); } // 0x11315AB3385B8AC0
	static void TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY(Any p0, float p1, float p2, float p3, Any p4, float p5, BOOL p6, float p7, float p8, BOOL p9, Any p10, BOOL p11, Any p12, Any p13) { invoke<Void>(0xB2A16444EAD9AE47, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13); } // 0xB2A16444EAD9AE47
	static void TASK_GO_TO_ENTITY(Entity entity, Entity target, int duration, float distance, float speed, float p5, int p6) { invoke<Void>(0x6A071245EB0D1882, entity, target, duration, distance, speed, p5, p6); } // 0x6A071245EB0D1882
	static void TASK_GOTO_ENTITY_AIMING(Ped ped, Entity target, float distanceToStopAt, float StartAimingDist) { invoke<Void>(0xA9DA48FAB8A76C12, ped, target, distanceToStopAt, StartAimingDist); } // 0xA9DA48FAB8A76C12
	static void TASK_GOTO_ENTITY_OFFSET(Ped ped, Any p1, Any p2, float x, float y, float z, int duration) { invoke<Void>(0xE39B4FF4FDEBDE27, ped, p1, p2, x, y, z, duration); } // 0xE39B4FF4FDEBDE27
	static void TASK_GOTO_ENTITY_OFFSET_XY(Ped ped, Entity entity, int duration, float xOffset, float yOffset, float zOffset, float moveBlendRatio, BOOL useNavmesh) { invoke<Void>(0x338E7EF52B6095A9, ped, entity, duration, xOffset, yOffset, zOffset, moveBlendRatio, useNavmesh); } // 0x338E7EF52B6095A9
	static void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD(Any p0, Any p1, float p2, float p3, float p4, float p5, BOOL p6, float p7, float p8, BOOL p9, BOOL p10, Any p11) { invoke<Void>(0x4701832B739DCE5, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); } // 0x4701832B739DCE5
	static void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY(Ped ped, Entity entityToWalkTo, Entity entityToAimAt, float speed, BOOL shootatEntity, float p5, float p6, BOOL p7, BOOL p8, Hash firingPattern) { invoke<Void>(0x97465886D35210E9, ped, entityToWalkTo, entityToAimAt, speed, shootatEntity, p5, p6, p7, p8, firingPattern); } // 0x97465886D35210E9
	static void TASK_GUARD_ASSIGNED_DEFENSIVE_AREA(Any p0, float p1, float p2, float p3, float p4, float p5, Any p6) { invoke<Void>(0xD2A207EEBDF9889B, p0, p1, p2, p3, p4, p5, p6); } // 0xD2A207EEBDF9889B
	static void TASK_GUARD_CURRENT_POSITION(Ped p0, float p1, float p2, BOOL p3) { invoke<Void>(0x4A58A47A72E3FCB4, p0, p1, p2, p3); } // 0x4A58A47A72E3FCB4
	static void TASK_GUARD_SPHERE_DEFENSIVE_AREA(Ped p0, float p1, float p2, float p3, float p4, float p5, Any p6, float p7, float p8, float p9, float p10) { invoke<Void>(0xC946FE14BE0EB5E2, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); } // 0xC946FE14BE0EB5E2
	static void TASK_HANDS_UP(Ped ped, int duration, Ped facingPed, int p3, BOOL p4) { invoke<Void>(0xF2EAB31979A7F910, ped, duration, facingPed, p3, p4); } // 0xF2EAB31979A7F910
	static void TASK_HELI_CHASE(Ped pilot, Entity entityToFollow, float x, float y, float z) { invoke<Void>(0xAC83B1DB38D0ADA0, pilot, entityToFollow, x, y, z); } // 0xAC83B1DB38D0ADA0
	static void TASK_HELI_MISSION(Ped pilot, Vehicle aircraft, Vehicle targetVehicle, Ped targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float maxSpeed, float landingRadius, float targetHeading, int unk1, int unk2, Hash unk3, int landingFlags) { invoke<Void>(0xDAD029E187A2BEB4, pilot, aircraft, targetVehicle, targetPed, destinationX, destinationY, destinationZ, missionFlag, maxSpeed, landingRadius, targetHeading, unk1, unk2, unk3, landingFlags); } // 0xDAD029E187A2BEB4
	static void TASK_JUMP(Ped ped, BOOL unused) { invoke<Void>(0xAE4086104E067B1, ped, unused); } // 0xAE4086104E067B1
	static void TASK_LEAVE_ANY_VEHICLE(Ped ped, int p1, int p2) { invoke<Void>(0x504D54DF3F6F2247, ped, p1, p2); } // 0x504D54DF3F6F2247
	static void TASK_LEAVE_VEHICLE(Ped ped, Vehicle vehicle, int flags) { invoke<Void>(0xD3DBCE61A490BE02, ped, vehicle, flags); } // 0xD3DBCE61A490BE02
	static void TASK_LOOK_AT_COORD(Entity entity, float x, float y, float z, float duration, Any p5, Any p6) { invoke<Void>(0x6FA46612594F7973, entity, x, y, z, duration, p5, p6); } // 0x6FA46612594F7973
	static void TASK_LOOK_AT_ENTITY(Ped ped, Entity lookAt, int duration, int unknown1, int unknown2) { invoke<Void>(0x69F4BE8C8CC4796C, ped, lookAt, duration, unknown1, unknown2); } // 0x69F4BE8C8CC4796C
	static void _TASK_MOVE_NETWORK(Ped ped, char* task, float multiplier, BOOL p3, char* animDict, int flags) { invoke<Void>(0x2D537BA194896636, ped, task, multiplier, p3, animDict, flags); } // 0x2D537BA194896636
	static void _TASK_MOVE_NETWORK_ADVANCED(Ped ped, char* p1, float p2, float p3, float p4, float p5, float p6, float p7, Any p8, float p9, BOOL p10, char* animDict, int flags) { invoke<Void>(0xD5B35BEA41919ACB, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, animDict, flags); } // 0xD5B35BEA41919ACB
	static void TASK_OPEN_VEHICLE_DOOR(Ped ped, Vehicle vehicle, int timeOut, int doorIndex, float speed) { invoke<Void>(0x965791A9A488A062, ped, vehicle, timeOut, doorIndex, speed); } // 0x965791A9A488A062
	static void TASK_PARACHUTE(Ped ped, BOOL p1) { invoke<Void>(0xD2F1C53C97EE81AB, ped, p1); } // 0xD2F1C53C97EE81AB
	static void TASK_PARACHUTE_TO_TARGET(Ped ped, float x, float y, float z) { invoke<Void>(0xB33E291AFA6BD03A, ped, x, y, z); } // 0xB33E291AFA6BD03A
	static void TASK_PATROL(Ped ped, char* p1, Any p2, BOOL p3, BOOL p4) { invoke<Void>(0xBDA5DF49D080FE4E, ped, p1, p2, p3, p4); } // 0xBDA5DF49D080FE4E
	static void TASK_PAUSE(Ped ped, int ms) { invoke<Void>(0xE73A266DB0CA9042, ped, ms); } // 0xE73A266DB0CA9042
	static void TASK_PED_SLIDE_TO_COORD(Ped ped, float x, float y, float z, float heading, float duration) { invoke<Void>(0xD04FE6765D990A06, ped, x, y, z, heading, duration); } // 0xD04FE6765D990A06
	static void TASK_PED_SLIDE_TO_COORD_HDG_RATE(Ped ped, float x, float y, float z, float heading, float p5, float p6) { invoke<Void>(0x5A4A6A6D3DC64F52, ped, x, y, z, heading, p5, p6); } // 0x5A4A6A6D3DC64F52
	static Any TASK_PERFORM_SEQUENCE(Ped ped, Object taskSequence) { return invoke<Any>(0x5ABA3986D90D8A3B, ped, taskSequence); } // 0x5ABA3986D90D8A3B
	static void TASK_PERFORM_SEQUENCE_FROM_PROGRESS(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x89221B16730234F0, p0, p1, p2, p3); } // 0x89221B16730234F0
	static void TASK_PLANE_CHASE(Ped pilot, Entity entityToFollow, float x, float y, float z) { invoke<Void>(0x2D2386F273FF7A25, pilot, entityToFollow, x, y, z); } // 0x2D2386F273FF7A25
	static void TASK_PLANE_LAND(Ped pilot, Vehicle plane, float runwayStartX, float runwayStartY, float runwayStartZ, float runwayEndX, float runwayEndY, float runwayEndZ) { invoke<Void>(0xBF19721FA34D32C0, pilot, plane, runwayStartX, runwayStartY, runwayStartZ, runwayEndX, runwayEndY, runwayEndZ); } // 0xBF19721FA34D32C0
	static void TASK_PLANE_MISSION(Ped pilot, Vehicle aircraft, Vehicle targetVehicle, Ped targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float angularDrag, float unk, float targetHeading, float maxZ, float minZ) { invoke<Void>(0x23703CD154E83B88, pilot, aircraft, targetVehicle, targetPed, destinationX, destinationY, destinationZ, missionFlag, angularDrag, unk, targetHeading, maxZ, minZ); } // 0x23703CD154E83B88
	static void TASK_PLANT_BOMB(Ped ped, float x, float y, float z, float heading) { invoke<Void>(0x965FEC691D55E9BF, ped, x, y, z, heading); } // 0x965FEC691D55E9BF
	static void TASK_PLAY_ANIM(Ped ped, char* animDictionary, char* animationName, float blendInSpeed, float blendOutSpeed, int duration, int flag, float playbackRate, BOOL lockX, BOOL lockY, BOOL lockZ) { invoke<Void>(0xEA47FE3719165B94, ped, animDictionary, animationName, blendInSpeed, blendOutSpeed, duration, flag, playbackRate, lockX, lockY, lockZ); } // 0xEA47FE3719165B94
	static void TASK_PLAY_ANIM_ADVANCED(Ped ped, char* animDict, char* animName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float speed, float speedMultiplier, int duration, Any flag, float animTime, Any p14, Any p15) { invoke<Void>(0x83CDB10EA29B370B, ped, animDict, animName, posX, posY, posZ, rotX, rotY, rotZ, speed, speedMultiplier, duration, flag, animTime, p14, p15); } // 0x83CDB10EA29B370B
	static void TASK_PLAY_PHONE_GESTURE_ANIMATION(Ped ped, char* animDict, char* animation, char* boneMaskType, float p4, float p5, BOOL p6, BOOL p7) { invoke<Void>(0x8FBB6758B3B3E9EC, ped, animDict, animation, boneMaskType, p4, p5, p6, p7); } // 0x8FBB6758B3B3E9EC
	static void TASK_PUT_PED_DIRECTLY_INTO_COVER(Ped ped, float x, float y, float z, Any timeout, BOOL p5, float p6, BOOL p7, BOOL p8, Any p9, BOOL p10) { invoke<Void>(0x4172393E6BE1FECE, ped, x, y, z, timeout, p5, p6, p7, p8, p9, p10); } // 0x4172393E6BE1FECE
	static void TASK_PUT_PED_DIRECTLY_INTO_MELEE(Ped ped, Ped meleeTarget, float p2, float p3, float p4, BOOL p5) { invoke<Void>(0x1C6CD14A876FFE39, ped, meleeTarget, p2, p3, p4, p5); } // 0x1C6CD14A876FFE39
	static void TASK_RAPPEL_FROM_HELI(Ped ped, int unused) { invoke<Void>(0x9693B0312F91649, ped, unused); } // 0x9693B0312F91649
	static void TASK_REACT_AND_FLEE_PED(Ped ped, Ped fleeTarget) { invoke<Void>(0x72C896464915D1B1, ped, fleeTarget); } // 0x72C896464915D1B1
	static void TASK_RELOAD_WEAPON(Ped ped, BOOL unused) { invoke<Void>(0x62D2916F56B9CD2D, ped, unused); } // 0x62D2916F56B9CD2D
	static void TASK_SCRIPTED_ANIMATION(Ped ped, Any* p1, Any* p2, Any* p3, float p4, float p5) { invoke<Void>(0x126EF75F1E17ABE5, ped, p1, p2, p3, p4, p5); } // 0x126EF75F1E17ABE5
	static void TASK_SEEK_COVER_FROM_PED(Ped ped, Ped target, int duration, BOOL p3) { invoke<Void>(0x84D32B3BEC531324, ped, target, duration, p3); } // 0x84D32B3BEC531324
	static void TASK_SEEK_COVER_FROM_POS(Ped ped, float x, float y, float z, int duration, BOOL p5) { invoke<Void>(0x75AC2B60386D89F2, ped, x, y, z, duration, p5); } // 0x75AC2B60386D89F2
	static void TASK_SEEK_COVER_TO_COORDS(Ped ped, float x1, float y1, float z1, float x2, float y2, float z2, Any p7, BOOL p8) { invoke<Void>(0x39246A6958EF072C, ped, x1, y1, z1, x2, y2, z2, p7, p8); } // 0x39246A6958EF072C
	static void TASK_SEEK_COVER_TO_COVER_POINT(Any p0, Any p1, float p2, float p3, float p4, Any p5, BOOL p6) { invoke<Void>(0xD43D95C7A869447F, p0, p1, p2, p3, p4, p5, p6); } // 0xD43D95C7A869447F
	static void TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(Ped ped, BOOL toggle) { invoke<Void>(0x90D2156198831D69, ped, toggle); } // 0x90D2156198831D69
	static void TASK_SET_DECISION_MAKER(Ped p0, Hash p1) { invoke<Void>(0xEB8517DDA73720DA, p0, p1); } // 0xEB8517DDA73720DA
	static void TASK_SET_SPHERE_DEFENSIVE_AREA(Any p0, float p1, float p2, float p3, float p4) { invoke<Void>(0x933C06518B52A9A4, p0, p1, p2, p3, p4); } // 0x933C06518B52A9A4
	static void TASK_SHOCKING_EVENT_REACT(Ped ped, int eventHandle) { invoke<Void>(0x452419CBD838065B, ped, eventHandle); } // 0x452419CBD838065B
	static void TASK_SHOOT_AT_COORD(Ped ped, float x, float y, float z, int duration, Hash firingPattern) { invoke<Void>(0x46A6CC01E0826106, ped, x, y, z, duration, firingPattern); } // 0x46A6CC01E0826106
	static void TASK_SHOOT_AT_ENTITY(Entity entity, Entity target, int duration, Hash firingPattern) { invoke<Void>(0x8DA95E8298AE772, entity, target, duration, firingPattern); } // 0x8DA95E8298AE772
	static void TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT(Ped ped, Vehicle vehicle) { invoke<Void>(0x7AA80209BDA643EB, ped, vehicle); } // 0x7AA80209BDA643EB
	static void TASK_SKY_DIVE(Ped ped) { invoke<Void>(0x601736CFE536B0A0, ped); } // 0x601736CFE536B0A0
	static void TASK_SMART_FLEE_COORD(Ped ped, float x, float y, float z, float distance, int time, BOOL p6, BOOL p7) { invoke<Void>(0x94587F17E9C365D5, ped, x, y, z, distance, time, p6, p7); } // 0x94587F17E9C365D5
	static void TASK_SMART_FLEE_PED(Ped ped, Ped fleeTarget, float distance, Any fleeTime, BOOL p4, BOOL p5) { invoke<Void>(0x22B0D0E37CCB840D, ped, fleeTarget, distance, fleeTime, p4, p5); } // 0x22B0D0E37CCB840D
	static void TASK_STAND_GUARD(Ped ped, float x, float y, float z, float heading, char* scenarioName) { invoke<Void>(0xAE032F8BBA959E90, ped, x, y, z, heading, scenarioName); } // 0xAE032F8BBA959E90
	static void TASK_STAND_STILL(Ped ped, int time) { invoke<Void>(0x919BE13EED931959, ped, time); } // 0x919BE13EED931959
	static void TASK_START_SCENARIO_AT_POSITION(Ped ped, char* scenarioName, float x, float y, float z, float heading, int duration, BOOL sittingScenario, BOOL teleport) { invoke<Void>(0xFA4EFC79F69D4F07, ped, scenarioName, x, y, z, heading, duration, sittingScenario, teleport); } // 0xFA4EFC79F69D4F07
	static void TASK_START_SCENARIO_IN_PLACE(Ped ped, char* scenarioName, int unkDelay, BOOL playEnterAnim) { invoke<Void>(0x142A02425FF02BD9, ped, scenarioName, unkDelay, playEnterAnim); } // 0x142A02425FF02BD9
	static void TASK_STAY_IN_COVER(Ped ped) { invoke<Void>(0xE5DA8615A6180789, ped); } // 0xE5DA8615A6180789
	static void TASK_STEALTH_KILL(Ped killer, Ped target, Hash actionType, float p3, Any p4) { invoke<Void>(0xAA5DC05579D60BD9, killer, target, actionType, p3, p4); } // 0xAA5DC05579D60BD9
	static void _TASK_STOP_PHONE_GESTURE_ANIMATION(Ped ped) { invoke<Void>(0x3FA00D4F4641BFAE, ped); } // 0x3FA00D4F4641BFAE
	static void TASK_SWAP_WEAPON(Ped ped, BOOL p1) { invoke<Void>(0xA21C51255B205245, ped, p1); } // 0xA21C51255B205245
	static void TASK_SWEEP_AIM_ENTITY(Ped ped, char* anim, char* p2, char* p3, char* p4, int p5, Vehicle vehicle, float p7, float p8) { invoke<Void>(0x2047C02158D6405A, ped, anim, p2, p3, p4, p5, vehicle, p7, p8); } // 0x2047C02158D6405A
	static void TASK_SWEEP_AIM_POSITION(Any p0, Any* p1, Any* p2, Any* p3, Any* p4, Any p5, float p6, float p7, float p8, float p9, float p10) { invoke<Void>(0x7AFE8FDC10BC07D2, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); } // 0x7AFE8FDC10BC07D2
	static void TASK_SYNCHRONIZED_SCENE(Ped ped, int scene, char* animDictionary, char* animationName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, Any p9) { invoke<Void>(0xEEA929141F699854, ped, scene, animDictionary, animationName, speed, speedMultiplier, duration, flag, playbackRate, p9); } // 0xEEA929141F699854
	static void TASK_THROW_PROJECTILE(int ped, float x, float y, float z) { invoke<Void>(0x7285951DBF6B5A51, ped, x, y, z); } // 0x7285951DBF6B5A51
	static void TASK_TOGGLE_DUCK(BOOL p0, BOOL p1) { invoke<Void>(0xAC96609B9995EDF8, p0, p1); } // 0xAC96609B9995EDF8
	static void TASK_TURN_PED_TO_FACE_COORD(Ped ped, float x, float y, float z, int duration) { invoke<Void>(0x1DDA930A0AC38571, ped, x, y, z, duration); } // 0x1DDA930A0AC38571
	static void TASK_TURN_PED_TO_FACE_ENTITY(Ped ped, Entity entity, int duration) { invoke<Void>(0x5AD23D40115353AC, ped, entity, duration); } // 0x5AD23D40115353AC
	static void TASK_USE_MOBILE_PHONE(Ped ped, int p1) { invoke<Void>(0xBD2A8EC3AF4DE7DB, ped, p1); } // 0xBD2A8EC3AF4DE7DB
	static void TASK_USE_MOBILE_PHONE_TIMED(Ped ped, int duration) { invoke<Void>(0x5EE02954A14C69DB, ped, duration); } // 0x5EE02954A14C69DB
	static void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD(Any p0, float p1, float p2, float p3, float p4, Any p5) { invoke<Void>(0x9FDA1B3D7E7028B3, p0, p1, p2, p3, p4, p5); } // 0x9FDA1B3D7E7028B3
	static void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP(Any p0, float p1, float p2, float p3, float p4, Any p5) { invoke<Void>(0x97A28E63F0BA5631, p0, p1, p2, p3, p4, p5); } // 0x97A28E63F0BA5631
	static void TASK_USE_NEAREST_SCENARIO_TO_COORD(Ped ped, float x, float y, float z, float distance, int duration) { invoke<Void>(0x277F471BA9DB000B, ped, x, y, z, distance, duration); } // 0x277F471BA9DB000B
	static void TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP(Ped ped, float x, float y, float z, float radius, Any p5) { invoke<Void>(0x58E2E0F23F6B76C3, ped, x, y, z, radius, p5); } // 0x58E2E0F23F6B76C3
	static void TASK_VEHICLE_AIM_AT_COORD(Ped ped, float x, float y, float z) { invoke<Void>(0x447C1E9EF844BC0F, ped, x, y, z); } // 0x447C1E9EF844BC0F
	static void TASK_VEHICLE_AIM_AT_PED(Ped ped, Ped target) { invoke<Void>(0xE41885592B08B097, ped, target); } // 0xE41885592B08B097
	static void TASK_VEHICLE_CHASE(Ped driver, Entity targetEnt) { invoke<Void>(0x3C08A8E30363B353, driver, targetEnt); } // 0x3C08A8E30363B353
	static void TASK_VEHICLE_DRIVE_TO_COORD(Ped ped, Vehicle vehicle, float x, float y, float z, float speed, Any p6, Hash vehicleModel, int drivingMode, float stopRange, float p10) { invoke<Void>(0xE2A2AA2F659D77A7, ped, vehicle, x, y, z, speed, p6, vehicleModel, drivingMode, stopRange, p10); } // 0xE2A2AA2F659D77A7
	static void TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE(Ped ped, Vehicle vehicle, float x, float y, float z, float speed, int driveMode, float stopRange) { invoke<Void>(0x158BB33F920D360C, ped, vehicle, x, y, z, speed, driveMode, stopRange); } // 0x158BB33F920D360C
	static void TASK_VEHICLE_DRIVE_WANDER(Ped ped, Vehicle vehicle, float speed, int drivingStyle) { invoke<Void>(0x480142959D337D00, ped, vehicle, speed, drivingStyle); } // 0x480142959D337D00
	static void TASK_VEHICLE_ESCORT(Ped ped, Vehicle vehicle, Vehicle targetVehicle, int mode, float speed, int drivingStyle, float minDistance, int p7, float noRoadsDistance) { invoke<Void>(0xFA6E4B75F302400, ped, vehicle, targetVehicle, mode, speed, drivingStyle, minDistance, p7, noRoadsDistance); } // 0xFA6E4B75F302400
	static void _TASK_VEHICLE_FOLLOW(Ped driver, Vehicle vehicle, Entity targetEntity, float speed, int drivingStyle, int minDistance) { invoke<Void>(0xFC545A9F0626E3B6, driver, vehicle, targetEntity, speed, drivingStyle, minDistance); } // 0xFC545A9F0626E3B6
	static void TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING(Ped ped, Vehicle vehicle, char* WPRecording, int p3, int p4, int p5, int p6, float p7, BOOL p8, float p9) { invoke<Void>(0x3123FAA6DB1CF7ED, ped, vehicle, WPRecording, p3, p4, p5, p6, p7, p8, p9); } // 0x3123FAA6DB1CF7ED
	static void TASK_VEHICLE_GOTO_NAVMESH(Ped ped, Vehicle vehicle, float x, float y, float z, float speed, int behaviorFlag, float stoppingRange) { invoke<Void>(0x195AEEB13CEFE2EE, ped, vehicle, x, y, z, speed, behaviorFlag, stoppingRange); } // 0x195AEEB13CEFE2EE
	static void TASK_VEHICLE_HELI_PROTECT(Ped pilot, Vehicle vehicle, Entity entityToFollow, float targetSpeed, int p4, float radius, int altitude, int p7) { invoke<Void>(0x1E09C32048FEFD1C, pilot, vehicle, entityToFollow, targetSpeed, p4, radius, altitude, p7); } // 0x1E09C32048FEFD1C
	static void TASK_VEHICLE_MISSION(int p0, int p1, Vehicle veh, Any p3, float p4, Any p5, float p6, float p7, BOOL p8) { invoke<Void>(0x659427E0EF36BCDE, p0, p1, veh, p3, p4, p5, p6, p7, p8); } // 0x659427E0EF36BCDE
	static void TASK_VEHICLE_MISSION_COORS_TARGET(Ped ped, Vehicle vehicle, float x, float y, float z, int p5, int p6, int p7, float p8, float p9, BOOL p10) { invoke<Void>(0xF0AF20AA7731F8C3, ped, vehicle, x, y, z, p5, p6, p7, p8, p9, p10); } // 0xF0AF20AA7731F8C3
	static void TASK_VEHICLE_MISSION_PED_TARGET(Ped ped, Vehicle vehicle, Ped pedTarget, int mode, float maxSpeed, int drivingStyle, float minDistance, float p7, BOOL p8) { invoke<Void>(0x9454528DF15D657A, ped, vehicle, pedTarget, mode, maxSpeed, drivingStyle, minDistance, p7, p8); } // 0x9454528DF15D657A
	static void TASK_VEHICLE_PARK(Ped ped, Vehicle vehicle, float x, float y, float z, float heading, int mode, float radius, BOOL keepEngineOn) { invoke<Void>(0xF3E34E968EA374E, ped, vehicle, x, y, z, heading, mode, radius, keepEngineOn); } // 0xF3E34E968EA374E
	static void TASK_VEHICLE_PLAY_ANIM(Vehicle vehicle, char* animation_set, char* animation_name) { invoke<Void>(0x69F5C3BD0F3EBD89, vehicle, animation_set, animation_name); } // 0x69F5C3BD0F3EBD89
	static void TASK_VEHICLE_SHOOT_AT_COORD(Ped ped, float x, float y, float z, float p4) { invoke<Void>(0x5190796ED39C9B6D, ped, x, y, z, p4); } // 0x5190796ED39C9B6D
	static void TASK_VEHICLE_SHOOT_AT_PED(Ped ped, Ped target, float p2) { invoke<Void>(0x10AB107B887214D8, ped, target, p2); } // 0x10AB107B887214D8
	static void TASK_VEHICLE_TEMP_ACTION(Ped driver, Vehicle vehicle, int action, int time) { invoke<Void>(0xC429DCEEB339E129, driver, vehicle, action, time); } // 0xC429DCEEB339E129
	static void TASK_WANDER_IN_AREA(Ped ped, float x, float y, float z, float radius, float minimalLength, float timeBetweenWalks) { invoke<Void>(0xE054346CA3A0F315, ped, x, y, z, radius, minimalLength, timeBetweenWalks); } // 0xE054346CA3A0F315
	static void TASK_WANDER_STANDARD(Ped ped, float p1, int p2) { invoke<Void>(0xBB9CE077274F6A1B, ped, p1, p2); } // 0xBB9CE077274F6A1B
	static void TASK_WARP_PED_INTO_VEHICLE(Ped ped, Vehicle vehicle, int seat) { invoke<Void>(0x9A7D091411C5F684, ped, vehicle, seat); } // 0x9A7D091411C5F684
	static void TASK_WRITHE(Ped ped, Ped target, int time, int p3) { invoke<Void>(0xCDDC2B77CE54AC6E, ped, target, time, p3); } // 0xCDDC2B77CE54AC6E
	static void UNCUFF_PED(Ped ped) { invoke<Void>(0x67406F2C8F87FC4F, ped); } // 0x67406F2C8F87FC4F
	static void UPDATE_TASK_AIM_GUN_SCRIPTED_TARGET(Ped p0, Ped p1, float p2, float p3, float p4, BOOL p5) { invoke<Void>(0x9724FB59A3E72AD0, p0, p1, p2, p3, p4, p5); } // 0x9724FB59A3E72AD0
	static void UPDATE_TASK_HANDS_UP_DURATION(Ped ped, int duration) { invoke<Void>(0xA98FCAFD7893C834, ped, duration); } // 0xA98FCAFD7893C834
	static void UPDATE_TASK_SWEEP_AIM_ENTITY(Ped ped, Entity entity) { invoke<Void>(0xE4973DBDBE6E44B3, ped, entity); } // 0xE4973DBDBE6E44B3
	static void UPDATE_TASK_SWEEP_AIM_POSITION(Any p0, float p1, float p2, float p3) { invoke<Void>(0xBB106883F5201FC4, p0, p1, p2, p3); } // 0xBB106883F5201FC4
	static void USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE(Any* p0, BOOL p1, float p2, float p3) { invoke<Void>(0x5A353B8E6B1095B5, p0, p1, p2, p3); } // 0x5A353B8E6B1095B5
	static void VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED(Any p0, float p1) { invoke<Void>(0x121F0593E0A431D7, p0, p1); } // 0x121F0593E0A431D7
	static void VEHICLE_WAYPOINT_PLAYBACK_PAUSE(Any p0) { invoke<Void>(0x8A4E6AC373666BC5, p0); } // 0x8A4E6AC373666BC5
	static void VEHICLE_WAYPOINT_PLAYBACK_RESUME(Any p0) { invoke<Void>(0xDC04FCAA7839D492, p0); } // 0xDC04FCAA7839D492
	static void VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(Any p0) { invoke<Void>(0x5CEB25A7D2848963, p0); } // 0x5CEB25A7D2848963
	static BOOL WAYPOINT_PLAYBACK_GET_IS_PAUSED(Any p0) { return invoke<BOOL>(0x701375A7D43F01CB, p0); } // 0x701375A7D43F01CB
	static void WAYPOINT_PLAYBACK_OVERRIDE_SPEED(Any p0, float p1, BOOL p2) { invoke<Void>(0x7D7D2B47FA788E85, p0, p1, p2); } // 0x7D7D2B47FA788E85
	static void WAYPOINT_PLAYBACK_PAUSE(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xF342546AA06FED5, p0, p1, p2); } // 0xF342546AA06FED5
	static void WAYPOINT_PLAYBACK_RESUME(Any p0, BOOL p1, Any p2, Any p3) { invoke<Void>(0x244F70C84C547D2D, p0, p1, p2, p3); } // 0x244F70C84C547D2D
	static void WAYPOINT_PLAYBACK_START_AIMING_AT_COORD(Any p0, float p1, float p2, float p3, BOOL p4) { invoke<Void>(0x8968400D900ED8B3, p0, p1, p2, p3, p4); } // 0x8968400D900ED8B3
	static void WAYPOINT_PLAYBACK_START_AIMING_AT_PED(Any p0, Any p1, BOOL p2) { invoke<Void>(0x20E330937C399D29, p0, p1, p2); } // 0x20E330937C399D29
	static void WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD(Any p0, float p1, float p2, float p3, BOOL p4, Any p5) { invoke<Void>(0x57A25CFCC9DB671, p0, p1, p2, p3, p4, p5); } // 0x57A25CFCC9DB671
	static void WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING(Any p0) { invoke<Void>(0x47EFA040EBB8E2EA, p0); } // 0x47EFA040EBB8E2EA
	static void WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(Any p0) { invoke<Void>(0x6599D834B12D0800, p0); } // 0x6599D834B12D0800
	static BOOL WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT(char* name, float x, float y, float z, int* point) { return invoke<BOOL>(0xB629A298081F876F, name, x, y, z, point); } // 0xB629A298081F876F
	static BOOL WAYPOINT_RECORDING_GET_COORD(char* name, int point, Vector3* coord) { return invoke<BOOL>(0x2FB897405C90B361, name, point, coord); } // 0x2FB897405C90B361
	static BOOL WAYPOINT_RECORDING_GET_NUM_POINTS(char* name, int* points) { return invoke<BOOL>(0x5343532C01A07234, name, points); } // 0x5343532C01A07234
	static float WAYPOINT_RECORDING_GET_SPEED_AT_POINT(char* name, int point) { return invoke<float>(0x5622AEBC33ACA9, name, point); } // 0x5622AEBC33ACA9
}

namespace CAM
{
	static void ADD_CAM_SPLINE_NODE(Cam camera, float x, float y, float z, float xRot, float yRot, float zRot, int length, int p8, int transitionType) { invoke<Void>(0x8609C75EC438FB3B, camera, x, y, z, xRot, yRot, zRot, length, p8, transitionType); } // 0x8609C75EC438FB3B
	static void ANIMATED_SHAKE_CAM(Cam cam, char* p1, char* p2, char* p3, float amplitude) { invoke<Void>(0xA2746EEAE3E577CD, cam, p1, p2, p3, amplitude); } // 0xA2746EEAE3E577CD
	static void _ANIMATE_GAMEPLAY_CAM_ZOOM(float p0, float distance) { invoke<Void>(0xDF2E1F7742402E81, p0, distance); } // 0xDF2E1F7742402E81
	static void ATTACH_CAM_TO_ENTITY(Cam cam, Entity entity, float xOffset, float yOffset, float zOffset, BOOL isRelative) { invoke<Void>(0xFEDB7D269E8C60E3, cam, entity, xOffset, yOffset, zOffset, isRelative); } // 0xFEDB7D269E8C60E3
	static void ATTACH_CAM_TO_PED_BONE(Cam cam, Ped ped, int boneIndex, float x, float y, float z, BOOL heading) { invoke<Void>(0x61A3DBA14AB7F411, cam, ped, boneIndex, x, y, z, heading); } // 0x61A3DBA14AB7F411
	static void _ATTACH_CAM_TO_VEHICLE_BONE(Cam cam, Vehicle vehicle, int boneIndex, BOOL relativeRotation, float rotX, float rotY, float rotZ, float offX, float offY, float offZ, BOOL fixedDirection) { invoke<Void>(0x8DB3F12A02CAEF72, cam, vehicle, boneIndex, relativeRotation, rotX, rotY, rotZ, offX, offY, offZ, fixedDirection); } // 0x8DB3F12A02CAEF72
	static Any _CLAMP_GAMEPLAY_CAM_PITCH(float minimum, float maximum) { return invoke<Any>(0xA516C198B7DCA1E1, minimum, maximum); } // 0xA516C198B7DCA1E1
	static Any _CLAMP_GAMEPLAY_CAM_YAW(float minimum, float maximum) { return invoke<Any>(0x8F993D26E0CA5E8E, minimum, maximum); } // 0x8F993D26E0CA5E8E
	static Cam CREATE_CAM(char* Gippo, BOOL p1) { return invoke<Cam>(0xC3981DCE61D9E13F, Gippo, p1); } // 0xC3981DCE61D9E13F
	static Cam CREATE_CAMERA(Hash camHash, BOOL p1) { return invoke<Cam>(0x5E3CF89C6BCCA67D, camHash, p1); } // 0x5E3CF89C6BCCA67D
	static Cam CREATE_CAMERA_WITH_PARAMS(Hash camHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, BOOL p8, Any p9) { return invoke<Cam>(0x6ABFA3E16460F22D, camHash, posX, posY, posZ, rotX, rotY, rotZ, fov, p8, p9); } // 0x6ABFA3E16460F22D
	static Cam CREATE_CAM_WITH_PARAMS(char* camName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, BOOL p8, int p9) { return invoke<Cam>(0xB51194800B257161, camName, posX, posY, posZ, rotX, rotY, rotZ, fov, p8, p9); } // 0xB51194800B257161
	static void CREATE_CINEMATIC_SHOT(Any p0, int p1, Any p2, Entity entity) { invoke<Void>(0x741B0129D4560F31, p0, p1, p2, entity); } // 0x741B0129D4560F31
	static void CUSTOM_MENU_COORDINATES(float p0) { invoke<Void>(0x487A82C650EB7799, p0); } // 0x487A82C650EB7799
	static void DESTROY_ALL_CAMS(BOOL thisScriptCheck) { invoke<Void>(0x8E5FB15663F79120, thisScriptCheck); } // 0x8E5FB15663F79120
	static void DESTROY_CAM(Cam cam, BOOL thisScriptCheck) { invoke<Void>(0x865908C81A2C22E9, cam, thisScriptCheck); } // 0x865908C81A2C22E9
	static void DETACH_CAM(Cam cam) { invoke<Void>(0xA2FABBE87F4BAD82, cam); } // 0xA2FABBE87F4BAD82
	static void DISABLE_AIM_CAM_THIS_UPDATE() { invoke<Void>(0x1A31FE0049E542F6); } // 0x1A31FE0049E542F6
	static void _DISABLE_FIRST_PERSON_CAM_THIS_FRAME() { invoke<Void>(0xDE2EF5DA284CC8DF); } // 0xDE2EF5DA284CC8DF
	static void _DISABLE_VEHICLE_FIRST_PERSON_CAM_THIS_FRAME() { invoke<Void>(0xADFF1B2A555F5FBA); } // 0xADFF1B2A555F5FBA
	static BOOL DOES_CAM_EXIST(Cam cam) { return invoke<BOOL>(0xA7A932170592B50E, cam); } // 0xA7A932170592B50E
	static void DO_SCREEN_FADE_IN(int duration) { invoke<Void>(0xD4E8E24955024033, duration); } // 0xD4E8E24955024033
	static void DO_SCREEN_FADE_OUT(int duration) { invoke<Void>(0x891B5B39AC6302AF, duration); } // 0x891B5B39AC6302AF
	static void _ENABLE_CROSSHAIR_THIS_FRAME() { invoke<Void>(0xEA7F0AD7E9BA676F); } // 0xEA7F0AD7E9BA676F
	static float GET_CAM_ANIM_CURRENT_PHASE(Cam cam) { return invoke<float>(0xA10B2DB49E92A6B0, cam); } // 0xA10B2DB49E92A6B0
	static Vector3 GET_CAM_COORD(Cam cam) { return invoke<Vector3>(0xBAC038F7459AE5AE, cam); } // 0xBAC038F7459AE5AE
	static float GET_CAM_FAR_CLIP(Cam cam) { return invoke<float>(0xB60A9CFEB21CA6AA, cam); } // 0xB60A9CFEB21CA6AA
	static float GET_CAM_FAR_DOF(Cam cam) { return invoke<float>(0x255F8DAFD540D397, cam); } // 0x255F8DAFD540D397
	static float GET_CAM_FOV(Cam cam) { return invoke<float>(0xC3330A45CCCDB26A, cam); } // 0xC3330A45CCCDB26A
	static float GET_CAM_NEAR_CLIP(Cam cam) { return invoke<float>(0xC520A34DAFBF24B1, cam); } // 0xC520A34DAFBF24B1
	static Vector3 GET_CAM_ROT(Cam cam, int rotationOrder) { return invoke<Vector3>(0x7D304C1C955E3E12, cam, rotationOrder); } // 0x7D304C1C955E3E12
	static int GET_CAM_SPLINE_NODE_INDEX(Cam cam) { return invoke<int>(0xB22B17DF858716A6, cam); } // 0xB22B17DF858716A6
	static float GET_CAM_SPLINE_NODE_PHASE(Cam cam) { return invoke<float>(0xD9D0E694C8282C96, cam); } // 0xD9D0E694C8282C96
	static float GET_CAM_SPLINE_PHASE(Cam cam) { return invoke<float>(0xB5349E36C546509A, cam); } // 0xB5349E36C546509A
	static int GET_FOLLOW_PED_CAM_VIEW_MODE() { return invoke<int>(0x8D4D46230B2C353A); } // 0x8D4D46230B2C353A
	static int GET_FOLLOW_PED_CAM_ZOOM_LEVEL() { return invoke<int>(0x33E6C8EFD0CD93E9); } // 0x33E6C8EFD0CD93E9
	static int GET_FOLLOW_VEHICLE_CAM_VIEW_MODE() { return invoke<int>(0xA4FF579AC0E3AAAE); } // 0xA4FF579AC0E3AAAE
	static int GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL() { return invoke<int>(0xEE82280AB767B690); } // 0xEE82280AB767B690
	static Vector3 GET_GAMEPLAY_CAM_COORD() { return invoke<Vector3>(0x14D6F5678D8F1B37); } // 0x14D6F5678D8F1B37
	static Vector3 _GET_GAMEPLAY_CAM_COORDS() { return invoke<Vector3>(0xA200EB1EE790F448); } // 0xA200EB1EE790F448
	static float _GET_GAMEPLAY_CAM_FAR_CLIP() { return invoke<float>(0xDFC8CBC606FDB0FC); } // 0xDFC8CBC606FDB0FC
	static float _GET_GAMEPLAY_CAM_FAR_DOF() { return invoke<float>(0x9780F32BCAF72431); } // 0x9780F32BCAF72431
	static float GET_GAMEPLAY_CAM_FOV() { return invoke<float>(0x65019750A0324133); } // 0x65019750A0324133
	static float _GET_GAMEPLAY_CAM_NEAR_DOF() { return invoke<float>(0xA03502FC581F7D9B); } // 0xA03502FC581F7D9B
	static float GET_GAMEPLAY_CAM_RELATIVE_HEADING() { return invoke<float>(0x743607648ADD4587); } // 0x743607648ADD4587
	static float GET_GAMEPLAY_CAM_RELATIVE_PITCH() { return invoke<float>(0x3A6867B4845BEDA2); } // 0x3A6867B4845BEDA2
	static Vector3 GET_GAMEPLAY_CAM_ROT(int rotationOrder) { return invoke<Vector3>(0x837765A25378F0BB, rotationOrder); } // 0x837765A25378F0BB
	static Vector3 _GET_GAMEPLAY_CAM_ROT_2(int rotationOrder) { return invoke<Vector3>(0x5B4E4C817FCC2DFB, rotationOrder); } // 0x5B4E4C817FCC2DFB
	static float _GET_GAMEPLAY_CAM_ZOOM() { return invoke<float>(0x7EC52CC40597D170); } // 0x7EC52CC40597D170
	static void GET_IS_MULTIPLAYER_BRIEF(BOOL p0) { invoke<Void>(0xE3433EADAAF7EE40, p0); } // 0xE3433EADAAF7EE40
	static Cam GET_RENDERING_CAM() { return invoke<Cam>(0x5234F9F10919EABA); } // 0x5234F9F10919EABA
	static BOOL IS_AIM_CAM_ACTIVE() { return invoke<BOOL>(0x68EDDA28A5976D07); } // 0x68EDDA28A5976D07
	static BOOL IS_CAM_ACTIVE(Cam cam) { return invoke<BOOL>(0xDFB2B516207D3534, cam); } // 0xDFB2B516207D3534
	static BOOL IS_CAM_INTERPOLATING(Cam cam) { return invoke<BOOL>(0x36F97C908C2B52C, cam); } // 0x36F97C908C2B52C
	static BOOL IS_CAM_PLAYING_ANIM(Cam cam, char* animName, char* animDictionary) { return invoke<BOOL>(0xC90621D8A0CEECF2, cam, animName, animDictionary); } // 0xC90621D8A0CEECF2
	static BOOL IS_CAM_RENDERING(Cam cam) { return invoke<BOOL>(0x2EC0AF5C5A49B7A, cam); } // 0x2EC0AF5C5A49B7A
	static BOOL IS_CAM_SHAKING(Cam cam) { return invoke<BOOL>(0x6B24BFE83A2BE47B, cam); } // 0x6B24BFE83A2BE47B
	static BOOL IS_CAM_SPLINE_PAUSED(Any p0) { return invoke<BOOL>(0x290F35C0AD97864, p0); } // 0x290F35C0AD97864
	static BOOL IS_CINEMATIC_CAM_RENDERING() { return invoke<BOOL>(0xB15162CB5826E9E8); } // 0xB15162CB5826E9E8
	static BOOL IS_CINEMATIC_CAM_SHAKING() { return invoke<BOOL>(0xBBC08F6B4CB8FF0A); } // 0xBBC08F6B4CB8FF0A
	static BOOL IS_CINEMATIC_SHOT_ACTIVE(Any p0) { return invoke<BOOL>(0xCC9F3371A7C28BC9, p0); } // 0xCC9F3371A7C28BC9
	static BOOL IS_FIRST_PERSON_AIM_CAM_ACTIVE() { return invoke<BOOL>(0x5E346D934122613F); } // 0x5E346D934122613F
	static BOOL IS_FOLLOW_PED_CAM_ACTIVE() { return invoke<BOOL>(0xC6D3D26810C8E0F9); } // 0xC6D3D26810C8E0F9
	static BOOL IS_FOLLOW_VEHICLE_CAM_ACTIVE() { return invoke<BOOL>(0xCBBDE6D335D6D496); } // 0xCBBDE6D335D6D496
	static BOOL IS_GAMEPLAY_CAM_LOOKING_BEHIND() { return invoke<BOOL>(0x70FDA869F3317EA9); } // 0x70FDA869F3317EA9
	static BOOL IS_GAMEPLAY_CAM_RENDERING() { return invoke<BOOL>(0x39B5D1B10383F0C8); } // 0x39B5D1B10383F0C8
	static BOOL IS_GAMEPLAY_CAM_SHAKING() { return invoke<BOOL>(0x16C090630DF1F89); } // 0x16C090630DF1F89
	static BOOL IS_GAMEPLAY_HINT_ACTIVE() { return invoke<BOOL>(0xE520FF1AD2785B40); } // 0xE520FF1AD2785B40
	static BOOL _IS_IN_VEHICLE_CAM_DISABLED() { return invoke<BOOL>(0x4F32C0D5A90A9B40); } // 0x4F32C0D5A90A9B40
	static BOOL IS_SCREEN_FADED_IN() { return invoke<BOOL>(0x5A859503B0C08678); } // 0x5A859503B0C08678
	static BOOL IS_SCREEN_FADED_OUT() { return invoke<BOOL>(0xB16FCE9DDC7BA182); } // 0xB16FCE9DDC7BA182
	static BOOL IS_SCREEN_FADING_IN() { return invoke<BOOL>(0x5C544BC6C57AC575); } // 0x5C544BC6C57AC575
	static BOOL IS_SCREEN_FADING_OUT() { return invoke<BOOL>(0x797AC7CB535BA28F); } // 0x797AC7CB535BA28F
	static BOOL IS_SCRIPT_GLOBAL_SHAKING() { return invoke<BOOL>(0xC912AF078AF19212); } // 0xC912AF078AF19212
	static BOOL IS_SPHERE_VISIBLE(float x, float y, float z, float radius) { return invoke<BOOL>(0xE33D59DA70B58FDF, x, y, z, radius); } // 0xE33D59DA70B58FDF
	static void _0x0225778816FDC28C(float p0) { invoke<Void>(0x225778816FDC28C, p0); } // 0x225778816FDC28C
	static void _0x0A9F2A468B328E74(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xA9F2A468B328E74, p0, p1, p2, p3); } // 0xA9F2A468B328E74
	static void _0x0AA27680A0BD43FA() { invoke<Void>(0xAA27680A0BD43FA); } // 0xAA27680A0BD43FA
	static void _0x0FB82563989CF4FB(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xFB82563989CF4FB, p0, p1, p2, p3); } // 0xFB82563989CF4FB
	static void _0x11FA5D3479C7DD47(Any p0) { invoke<Void>(0x11FA5D3479C7DD47, p0); } // 0x11FA5D3479C7DD47
	static void _0x12DED8CA53D47EA5(float p0) { invoke<Void>(0x12DED8CA53D47EA5, p0); } // 0x12DED8CA53D47EA5
	static float _0x162F9D995753DC19() { return invoke<float>(0x162F9D995753DC19); } // 0x162F9D995753DC19
	static Any _0x17FCA7199A530203() { return invoke<Any>(0x17FCA7199A530203); } // 0x17FCA7199A530203
	static Any _0x19CAFA3C87F7C2FF() { return invoke<Any>(0x19CAFA3C87F7C2FF); } // 0x19CAFA3C87F7C2FF
	static Any _0x1F2300CB7FA7B7F6() { return invoke<Any>(0x1F2300CB7FA7B7F6); } // 0x1F2300CB7FA7B7F6
	static void _0x21E253A7F8DA5DFB(char* vehicleName) { invoke<Void>(0x21E253A7F8DA5DFB, vehicleName); } // 0x21E253A7F8DA5DFB
	static void _0x247ACBC4ABBC9D1C(BOOL p0) { invoke<Void>(0x247ACBC4ABBC9D1C, p0); } // 0x247ACBC4ABBC9D1C
	static int _0x26903D9CD1175F2C(Any p0, Any p1) { return invoke<int>(0x26903D9CD1175F2C, p0, p1); } // 0x26903D9CD1175F2C
	static void _0x271017B9BA825366(Any p0, BOOL p1) { invoke<Void>(0x271017B9BA825366, p0, p1); } // 0x271017B9BA825366
	static void _0x271401846BD26E92(BOOL p0, BOOL p1) { invoke<Void>(0x271401846BD26E92, p0, p1); } // 0x271401846BD26E92
	static void _0x2A2173E46DAECD12(Any p0, Any p1) { invoke<Void>(0x2A2173E46DAECD12, p0, p1); } // 0x2A2173E46DAECD12
	static void _0x2AED6301F67007D5(Entity entity) { invoke<Void>(0x2AED6301F67007D5, entity); } // 0x2AED6301F67007D5
	static void _0x2F7F2B26DD3F18EE(float p0, float p1) { invoke<Void>(0x2F7F2B26DD3F18EE, p0, p1); } // 0x2F7F2B26DD3F18EE
	static BOOL _0x3044240D2E0FA842() { return invoke<BOOL>(0x3044240D2E0FA842); } // 0x3044240D2E0FA842
	static void _0x4008EDF7D6E48175(BOOL p0) { invoke<Void>(0x4008EDF7D6E48175, p0); } // 0x4008EDF7D6E48175
	static void _0x469F2ECDEC046337(BOOL p0) { invoke<Void>(0x469F2ECDEC046337, p0); } // 0x469F2ECDEC046337
	static void _0x47B595D60664CFFA(Any p0, Any p1) { invoke<Void>(0x47B595D60664CFFA, p0, p1); } // 0x47B595D60664CFFA
	static void _0x48608C3464F58AB4(Any p0, Any p1, Any p2) { invoke<Void>(0x48608C3464F58AB4, p0, p1, p2); } // 0x48608C3464F58AB4
	static Any _0x4879E4FE39074CDF() { return invoke<Any>(0x4879E4FE39074CDF); } // 0x4879E4FE39074CDF
	static void _0x49482F9FCD825AAA(Entity entity) { invoke<Void>(0x49482F9FCD825AAA, entity); } // 0x49482F9FCD825AAA
	static void _0x503F5920162365B2(Any p0, float p1, float p2, float p3) { invoke<Void>(0x503F5920162365B2, p0, p1, p2, p3); } // 0x503F5920162365B2
	static void _0x59424BD75174C9B1() { invoke<Void>(0x59424BD75174C9B1); } // 0x59424BD75174C9B1
	static void _0x5A43C76F7FC7BA5F() { invoke<Void>(0x5A43C76F7FC7BA5F); } // 0x5A43C76F7FC7BA5F
	static void _0x5C41E6BABC9E2112(Any p0) { invoke<Void>(0x5C41E6BABC9E2112, p0); } // 0x5C41E6BABC9E2112
	static BOOL _0x5C48A1D6E3B33179(Any p0) { return invoke<BOOL>(0x5C48A1D6E3B33179, p0); } // 0x5C48A1D6E3B33179
	static void _0x5D7B620DAE436138(float p0) { invoke<Void>(0x5D7B620DAE436138, p0); } // 0x5D7B620DAE436138
	static float _0x5F35F6732C3FBBA0(Any p0) { return invoke<float>(0x5F35F6732C3FBBA0, p0); } // 0x5F35F6732C3FBBA0
	static void _0x609278246A29CA34(Any p0, Any p1, Any p2) { invoke<Void>(0x609278246A29CA34, p0, p1, p2); } // 0x609278246A29CA34
	static void _0x62374889A4D59F72() { invoke<Void>(0x62374889A4D59F72); } // 0x62374889A4D59F72
	static void _0x62ECFCFDEE7885D6() { invoke<Void>(0x62ECFCFDEE7885D6); } // 0x62ECFCFDEE7885D6
	static void _0x6493CF69859B116A() { invoke<Void>(0x6493CF69859B116A); } // 0x6493CF69859B116A
	static void _0x661B5C8654ADD825(Any p0, BOOL p1) { invoke<Void>(0x661B5C8654ADD825, p0, p1); } // 0x661B5C8654ADD825
	static BOOL _0x705A276EBFF3133D() { return invoke<BOOL>(0x705A276EBFF3133D); } // 0x705A276EBFF3133D
	static Any _0x70894BD0915C5BCA(float p0) { return invoke<Any>(0x70894BD0915C5BCA, p0); } // 0x70894BD0915C5BCA
	static BOOL _0x74BD83EA840F6BC9() { return invoke<BOOL>(0x74BD83EA840F6BC9); } // 0x74BD83EA840F6BC9
	static void _0x7B8A361C1813FBEF() { invoke<Void>(0x7B8A361C1813FBEF); } // 0x7B8A361C1813FBEF
	static void _0x7BF1A54AE67AC070(Any p0, Any p1, Any p2) { invoke<Void>(0x7BF1A54AE67AC070, p0, p1, p2); } // 0x7BF1A54AE67AC070
	static float _0x80EC114669DAEFF4() { return invoke<float>(0x80EC114669DAEFF4); } // 0x80EC114669DAEFF4
	static void _0x83B8201ED82A9A2D(Any p0, Any p1, Any p2, float p3) { invoke<Void>(0x83B8201ED82A9A2D, p0, p1, p2, p3); } // 0x83B8201ED82A9A2D
	static Entity _0x89215EC747DF244A(float p0, int p1, float p2, float p3, float p4, float p5, float p6, int p7, int p8) { return invoke<Entity>(0x89215EC747DF244A, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0x89215EC747DF244A
	static void _0x8BBACBF51DA047A8(Any p0) { invoke<Void>(0x8BBACBF51DA047A8, p0); } // 0x8BBACBF51DA047A8
	static Any _0x8BFCEB5EA1B161B6() { return invoke<Any>(0x8BFCEB5EA1B161B6); } // 0x8BFCEB5EA1B161B6
	static void _0x91EF6EE6419E5B97(BOOL p0) { invoke<Void>(0x91EF6EE6419E5B97, p0); } // 0x91EF6EE6419E5B97
	static void _0x9E4CFFF989258472() { invoke<Void>(0x9E4CFFF989258472); } // 0x9E4CFFF989258472
	static void _0xA2767257A320FC82(Any p0, BOOL p1) { invoke<Void>(0xA2767257A320FC82, p0, p1); } // 0xA2767257A320FC82
	static void _0xA41BCD7213805AAC(BOOL p0) { invoke<Void>(0xA41BCD7213805AAC, p0); } // 0xA41BCD7213805AAC
	static void _0xA6385DEB180F319F(Any p0, Any p1, float p2) { invoke<Void>(0xA6385DEB180F319F, p0, p1, p2); } // 0xA6385DEB180F319F
	static Any _0xBF72910D0F26F025() { return invoke<Any>(0xBF72910D0F26F025); } // 0xBF72910D0F26F025
	static void _0xC2EAE3FB8CDBED31(char* p0, char* p1, char* p2, float p3) { invoke<Void>(0xC2EAE3FB8CDBED31, p0, p1, p2, p3); } // 0xC2EAE3FB8CDBED31
	static void _0xC8391C309684595A() { invoke<Void>(0xC8391C309684595A); } // 0xC8391C309684595A
	static void _0xC8B5C4A79CC18B94(Cam p0) { invoke<Void>(0xC8B5C4A79CC18B94, p0); } // 0xC8B5C4A79CC18B94
	static void _0xC91C6C55199308CA(Any p0, float p1, float p2, float p3) { invoke<Void>(0xC91C6C55199308CA, p0, p1, p2, p3); } // 0xC91C6C55199308CA
	static void _0xC92717EF615B6704(float p0) { invoke<Void>(0xC92717EF615B6704, p0); } // 0xC92717EF615B6704
	static BOOL _0xCA9D2AA3E326D720() { return invoke<BOOL>(0xCA9D2AA3E326D720); } // 0xCA9D2AA3E326D720
	static void _0xCCD078C2665D2973(BOOL p0) { invoke<Void>(0xCCD078C2665D2973, p0); } // 0xCCD078C2665D2973
	static void _0xCED08CBE8EBB97C7(float p0, float p1) { invoke<Void>(0xCED08CBE8EBB97C7, p0, p1); } // 0xCED08CBE8EBB97C7
	static float _0xD0082607100D7193() { return invoke<float>(0xD0082607100D7193); } // 0xD0082607100D7193
	static void _0xD1B0F412F109EA5D(Any p0, Any p1) { invoke<Void>(0xD1B0F412F109EA5D, p0, p1); } // 0xD1B0F412F109EA5D
	static void _0xD1F8363DFAD03848(float p0) { invoke<Void>(0xD1F8363DFAD03848, p0); } // 0xD1F8363DFAD03848
	static Any _0xD7360051C885628B() { return invoke<Any>(0xD7360051C885628B); } // 0xD7360051C885628B
	static void _0xDB90C6CCA48940F1(BOOL p0) { invoke<Void>(0xDB90C6CCA48940F1, p0); } // 0xDB90C6CCA48940F1
	static void _0xDC9DA9E8789F5246() { invoke<Void>(0xDC9DA9E8789F5246); } // 0xDC9DA9E8789F5246
	static void _0xDD79DF9F4D26E1C9() { invoke<Void>(0xDD79DF9F4D26E1C9); } // 0xDD79DF9F4D26E1C9
	static void _0xE111A7C0D200CBC5(Any p0, float p1) { invoke<Void>(0xE111A7C0D200CBC5, p0, p1); } // 0xE111A7C0D200CBC5
	static void _0xE827B9382CFB41BA(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xE827B9382CFB41BA, p0, p1, p2, p3); } // 0xE827B9382CFB41BA
	static Any _0xE9EA16D6E54CDCA4(Vehicle p0, int p1) { return invoke<Any>(0xE9EA16D6E54CDCA4, p0, p1); } // 0xE9EA16D6E54CDCA4
	static Any _0xEAF0FA793D05C592() { return invoke<Any>(0xEAF0FA793D05C592); } // 0xEAF0FA793D05C592
	static Any _0xEE778F8C7E1142E2(Any p0) { return invoke<Any>(0xEE778F8C7E1142E2, p0); } // 0xEE778F8C7E1142E2
	static void _0xF4C8CF9E353AFECA(char* p0, float p1) { invoke<Void>(0xF4C8CF9E353AFECA, p0, p1); } // 0xF4C8CF9E353AFECA
	static void _0xF4F2C0D4EE209E20() { invoke<Void>(0xF4F2C0D4EE209E20); } // 0xF4F2C0D4EE209E20
	static void _0xF55E4046F6F831DC(Any p0, float p1) { invoke<Void>(0xF55E4046F6F831DC, p0, p1); } // 0xF55E4046F6F831DC
	static void _0xF8BDBF3D573049A1(float p0) { invoke<Void>(0xF8BDBF3D573049A1, p0); } // 0xF8BDBF3D573049A1
	static void _0xFD3151CD37EA2245(Any p0) { invoke<Void>(0xFD3151CD37EA2245, p0); } // 0xFD3151CD37EA2245
	static void OVERRIDE_CAM_SPLINE_MOTION_BLUR(Cam cam, int p1, float p2, float p3) { invoke<Void>(0x7DCF7C708D292D55, cam, p1, p2, p3); } // 0x7DCF7C708D292D55
	static void OVERRIDE_CAM_SPLINE_VELOCITY(Cam cam, int p1, float p2, float p3) { invoke<Void>(0x40B62FA033EB0346, cam, p1, p2, p3); } // 0x40B62FA033EB0346
	static BOOL PLAY_CAM_ANIM(Cam cam, char* animName, char* animDictionary, float x, float y, float z, float xRot, float yRot, float zRot, BOOL p9, int p10) { return invoke<BOOL>(0x9A2D0FB2E7852392, cam, animName, animDictionary, x, y, z, xRot, yRot, zRot, p9, p10); } // 0x9A2D0FB2E7852392
	static BOOL PLAY_SYNCHRONIZED_CAM_ANIM(Any p0, Any p1, char* animName, char* animDictionary) { return invoke<BOOL>(0xE32EFE9AB4A9AA0C, p0, p1, animName, animDictionary); } // 0xE32EFE9AB4A9AA0C
	static void POINT_CAM_AT_COORD(Cam cam, float x, float y, float z) { invoke<Void>(0xF75497BB865F0803, cam, x, y, z); } // 0xF75497BB865F0803
	static void POINT_CAM_AT_ENTITY(Cam cam, Entity entity, float p2, float p3, float p4, BOOL p5) { invoke<Void>(0x5640BFF86B16E8DC, cam, entity, p2, p3, p4, p5); } // 0x5640BFF86B16E8DC
	static void POINT_CAM_AT_PED_BONE(Cam cam, int ped, int boneIndex, float x, float y, float z, BOOL p6) { invoke<Void>(0x68B2B5F33BA63C41, cam, ped, boneIndex, x, y, z, p6); } // 0x68B2B5F33BA63C41
	static void _RENDER_FIRST_PERSON_CAM(BOOL render, float p1, int p2) { invoke<Void>(0xC819F3CBB62BF692, render, p1, p2); } // 0xC819F3CBB62BF692
	static void RENDER_SCRIPT_CAMS(BOOL render, BOOL ease, int easeTime, BOOL p3, BOOL p4) { invoke<Void>(0x7E5B515DB0636FC, render, ease, easeTime, p3, p4); } // 0x7E5B515DB0636FC
	static void SET_CAM_ACTIVE(Cam cam, BOOL active) { invoke<Void>(0x26FB97D0A425F84, cam, active); } // 0x26FB97D0A425F84
	static void SET_CAM_ACTIVE_WITH_INTERP(Cam camTo, Cam camFrom, int duration, int easeLocation, int easeRotation) { invoke<Void>(0x9FBDA379383A52A4, camTo, camFrom, duration, easeLocation, easeRotation); } // 0x9FBDA379383A52A4
	static void SET_CAM_AFFECTS_AIMING(Cam cam, BOOL toggle) { invoke<Void>(0x8C1DC7770C51DC8D, cam, toggle); } // 0x8C1DC7770C51DC8D
	static void SET_CAM_ANIM_CURRENT_PHASE(Cam cam, float phase) { invoke<Void>(0x4145A4C44FF3B5A6, cam, phase); } // 0x4145A4C44FF3B5A6
	static void SET_CAM_COORD(Cam cam, float posX, float posY, float posZ) { invoke<Void>(0x4D41783FB745E42E, cam, posX, posY, posZ); } // 0x4D41783FB745E42E
	static void SET_CAM_DEBUG_NAME(Cam camera, char* name) { invoke<Void>(0x1B93E0107865DD40, camera, name); } // 0x1B93E0107865DD40
	static void _SET_CAM_DOF_FNUMBER_OF_LENS(Cam camera, float p1) { invoke<Void>(0x7DD234D6F3914C5B, camera, p1); } // 0x7DD234D6F3914C5B
	static void _SET_CAM_DOF_FOCUS_DISTANCE_BIAS(Cam camera, float p1) { invoke<Void>(0xC669EEA5D031B7DE, camera, p1); } // 0xC669EEA5D031B7DE
	static void _SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE(Cam camera, float p1) { invoke<Void>(0xC3654A441402562D, camera, p1); } // 0xC3654A441402562D
	static void _SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE_BLEND_LEVEL(Cam camera, float p1) { invoke<Void>(0x2C654B4943BDDF7C, camera, p1); } // 0x2C654B4943BDDF7C
	static void SET_CAM_DOF_PLANES(Cam cam, float p1, float p2, float p3, float p4) { invoke<Void>(0x3CF48F6F96E749DC, cam, p1, p2, p3, p4); } // 0x3CF48F6F96E749DC
	static void SET_CAM_DOF_STRENGTH(Cam cam, float dofStrength) { invoke<Void>(0x5EE29B4D7D5DF897, cam, dofStrength); } // 0x5EE29B4D7D5DF897
	static void _SET_CAM_EFFECT(int p0) { invoke<Void>(0x80C8B1846639BB19, p0); } // 0x80C8B1846639BB19
	static void _SET_CAMERA_RANGE(Cam cam, float range) { invoke<Void>(0xF9D02130ECDD1D77, cam, range); } // 0xF9D02130ECDD1D77
	static void SET_CAM_FAR_CLIP(Cam cam, float farClip) { invoke<Void>(0xAE306F2A904BF86E, cam, farClip); } // 0xAE306F2A904BF86E
	static void SET_CAM_FAR_DOF(Cam cam, float farDOF) { invoke<Void>(0xEDD91296CD01AEE0, cam, farDOF); } // 0xEDD91296CD01AEE0
	static void SET_CAM_FOV(Cam cam, float fieldOfView) { invoke<Void>(0xB13C14F66A00D047, cam, fieldOfView); } // 0xB13C14F66A00D047
	static void SET_CAM_INHERIT_ROLL_VEHICLE(Cam cam, BOOL p1) { invoke<Void>(0x45F1DE9C34B93AE6, cam, p1); } // 0x45F1DE9C34B93AE6
	static void SET_CAM_MOTION_BLUR_STRENGTH(Cam cam, float strength) { invoke<Void>(0x6F0F77FBA9A8F2E6, cam, strength); } // 0x6F0F77FBA9A8F2E6
	static void SET_CAM_NEAR_CLIP(Cam cam, float nearClip) { invoke<Void>(0xC7848EFCCC545182, cam, nearClip); } // 0xC7848EFCCC545182
	static void SET_CAM_NEAR_DOF(Cam cam, float nearDOF) { invoke<Void>(0x3FA4BF0A7AB7DE2C, cam, nearDOF); } // 0x3FA4BF0A7AB7DE2C
	static void SET_CAM_PARAMS(Cam cam, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fieldOfView, Any p8, int p9, int p10, int p11) { invoke<Void>(0xBFD8727AEA3CCEBA, cam, posX, posY, posZ, rotX, rotY, rotZ, fieldOfView, p8, p9, p10, p11); } // 0xBFD8727AEA3CCEBA
	static void SET_CAM_ROT(Cam cam, float rotX, float rotY, float rotZ, int rotationOrder) { invoke<Void>(0x85973643155D0B07, cam, rotX, rotY, rotZ, rotationOrder); } // 0x85973643155D0B07
	static void SET_CAM_SHAKE_AMPLITUDE(Cam cam, float amplitude) { invoke<Void>(0xD93DB43B82BC0D00, cam, amplitude); } // 0xD93DB43B82BC0D00
	static void SET_CAM_SPLINE_DURATION(int cam, int timeDuration) { invoke<Void>(0x1381539FEE034CDA, cam, timeDuration); } // 0x1381539FEE034CDA
	static void SET_CAM_SPLINE_PHASE(Cam cam, float p1) { invoke<Void>(0x242B5874F0A4E052, cam, p1); } // 0x242B5874F0A4E052
	static void SET_CAM_USE_SHALLOW_DOF_MODE(Cam cam, BOOL toggle) { invoke<Void>(0x16A96863A17552BB, cam, toggle); } // 0x16A96863A17552BB
	static void SET_CINEMATIC_BUTTON_ACTIVE(BOOL p0) { invoke<Void>(0x51669F7D1FB53D9F, p0); } // 0x51669F7D1FB53D9F
	static void SET_CINEMATIC_CAM_SHAKE_AMPLITUDE(float p0) { invoke<Void>(0xC724C701C30B2FE7, p0); } // 0xC724C701C30B2FE7
	static void SET_CINEMATIC_MODE_ACTIVE(BOOL p0) { invoke<Void>(0xDCF0754AC3D6FD4E, p0); } // 0xDCF0754AC3D6FD4E
	static void _SET_FIRST_PERSON_CAM_NEAR_CLIP(float distance) { invoke<Void>(0xAF7B437918103B3, distance); } // 0xAF7B437918103B3
	static void _SET_FIRST_PERSON_CAM_PITCH_RANGE(float minAngle, float maxAngle) { invoke<Void>(0xBCFC632DB7673BF0, minAngle, maxAngle); } // 0xBCFC632DB7673BF0
	static BOOL SET_FOLLOW_PED_CAM_CUTSCENE_CHAT(char* p0, int p1) { return invoke<BOOL>(0x44A113DD6FFC48D1, p0, p1); } // 0x44A113DD6FFC48D1
	static void SET_FOLLOW_PED_CAM_VIEW_MODE(int viewMode) { invoke<Void>(0x5A4F9EDF1673F704, viewMode); } // 0x5A4F9EDF1673F704
	static void SET_FOLLOW_VEHICLE_CAM_VIEW_MODE(int viewMode) { invoke<Void>(0xAC253D7842768F48, viewMode); } // 0xAC253D7842768F48
	static void SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL(int zoomLevel) { invoke<Void>(0x19464CB6E4078C8A, zoomLevel); } // 0x19464CB6E4078C8A
	static void _SET_GAMEPLAY_CAM_RAW_PITCH(float pitch) { invoke<Void>(0x759E13EBC1C15C5A, pitch); } // 0x759E13EBC1C15C5A
	static void _SET_GAMEPLAY_CAM_RAW_YAW(float yaw) { invoke<Void>(0x103991D4A307D472, yaw); } // 0x103991D4A307D472
	static void SET_GAMEPLAY_CAM_RELATIVE_HEADING(float heading) { invoke<Void>(0xB4EC2312F4E5B1F1, heading); } // 0xB4EC2312F4E5B1F1
	static void SET_GAMEPLAY_CAM_RELATIVE_PITCH(float x, float Value2) { invoke<Void>(0x6D0858B8EDFD2B7D, x, Value2); } // 0x6D0858B8EDFD2B7D
	static void SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE(float amplitude) { invoke<Void>(0xA87E00932DB4D85D, amplitude); } // 0xA87E00932DB4D85D
	static void SET_GAMEPLAY_COORD_HINT(float x, float y, float z, int duration, int blendOutDuration, int blendInDuration, int unk) { invoke<Void>(0xD51ADCD2D8BC0FB3, x, y, z, duration, blendOutDuration, blendInDuration, unk); } // 0xD51ADCD2D8BC0FB3
	static void SET_GAMEPLAY_ENTITY_HINT(Entity entity, float xOffset, float yOffset, float zOffset, BOOL p4, int p5, int p6, int p7, Any p8) { invoke<Void>(0x189E955A8313E298, entity, xOffset, yOffset, zOffset, p4, p5, p6, p7, p8); } // 0x189E955A8313E298
	static void SET_GAMEPLAY_HINT_FOV(float FOV) { invoke<Void>(0x513403FB9C56211F, FOV); } // 0x513403FB9C56211F
	static void SET_GAMEPLAY_OBJECT_HINT(Any p0, float p1, float p2, float p3, BOOL p4, Any p5, Any p6, Any p7) { invoke<Void>(0x83E87508A2CA2AC6, p0, p1, p2, p3, p4, p5, p6, p7); } // 0x83E87508A2CA2AC6
	static void SET_GAMEPLAY_PED_HINT(Ped p0, float x1, float y1, float z1, BOOL p4, Any p5, Any p6, Any p7) { invoke<Void>(0x2B486269ACD548D3, p0, x1, y1, z1, p4, p5, p6, p7); } // 0x2B486269ACD548D3
	static void SET_GAMEPLAY_VEHICLE_HINT(Any p0, float p1, float p2, float p3, BOOL p4, Any p5, Any p6, Any p7) { invoke<Void>(0xA2297E18F3E71C2E, p0, p1, p2, p3, p4, p5, p6, p7); } // 0xA2297E18F3E71C2E
	static void _SET_THIRD_PERSON_AIM_CAM_NEAR_CLIP(float distance) { invoke<Void>(0x42156508606DE65E, distance); } // 0x42156508606DE65E
	static void SET_TIME_IDLE_DROP(BOOL p0, BOOL p1) { invoke<Void>(0x9DFE13ECDC1EC196, p0, p1); } // 0x9DFE13ECDC1EC196
	static void SET_USE_HI_DOF() { invoke<Void>(0xA13B0222F3D94A94); } // 0xA13B0222F3D94A94
	static Any SET_WIDESCREEN_BORDERS(BOOL p0, int p1) { return invoke<Any>(0xDCD4EA924F42D01A, p0, p1); } // 0xDCD4EA924F42D01A
	static void SHAKE_CAM(Cam cam, char* type, float amplitude) { invoke<Void>(0x6A25241C340D3822, cam, type, amplitude); } // 0x6A25241C340D3822
	static void SHAKE_CINEMATIC_CAM(char* p0, float p1) { invoke<Void>(0xDCE214D9ED58F3CF, p0, p1); } // 0xDCE214D9ED58F3CF
	static void SHAKE_GAMEPLAY_CAM(char* shakeName, float intensity) { invoke<Void>(0xFD55E49555E017CF, shakeName, intensity); } // 0xFD55E49555E017CF
	static void STOP_CAM_POINTING(Cam cam) { invoke<Void>(0xF33AB75780BA57DE, cam); } // 0xF33AB75780BA57DE
	static void STOP_CAM_SHAKING(Cam cam, BOOL p1) { invoke<Void>(0xBDECF64367884AC3, cam, p1); } // 0xBDECF64367884AC3
	static void STOP_CINEMATIC_CAM_SHAKING(BOOL p0) { invoke<Void>(0x2238E588E588A6D7, p0); } // 0x2238E588E588A6D7
	static void STOP_CINEMATIC_SHOT(Any p0) { invoke<Void>(0x7660C6E75D3A078E, p0); } // 0x7660C6E75D3A078E
	static void STOP_CUTSCENE_CAM_SHAKING() { invoke<Void>(0xDB629FFD9285FA06); } // 0xDB629FFD9285FA06
	static void STOP_GAMEPLAY_CAM_SHAKING(BOOL p0) { invoke<Void>(0xEF93E9F3D08C178, p0); } // 0xEF93E9F3D08C178
	static void STOP_GAMEPLAY_HINT(BOOL p0) { invoke<Void>(0xF46C581C61718916, p0); } // 0xF46C581C61718916
	static void STOP_SCRIPT_GLOBAL_SHAKING(BOOL p0) { invoke<Void>(0x1C9D7949FA533490, p0); } // 0x1C9D7949FA533490
}

namespace CLOCK
{
	static void ADD_TO_CLOCK_TIME(int hours, int minutes, int seconds) { invoke<Void>(0xD716F30D8C8980E2, hours, minutes, seconds); } // 0xD716F30D8C8980E2
	static void ADVANCE_CLOCK_TIME_TO(int hour, int minute, int second) { invoke<Void>(0xC8CA9670B9D83B3B, hour, minute, second); } // 0xC8CA9670B9D83B3B
	static int GET_CLOCK_DAY_OF_MONTH() { return invoke<int>(0x3D10BC92A4DB1D35); } // 0x3D10BC92A4DB1D35
	static int GET_CLOCK_DAY_OF_WEEK() { return invoke<int>(0xD972E4BD7AEB235F); } // 0xD972E4BD7AEB235F
	static int GET_CLOCK_HOURS() { return invoke<int>(0x25223CA6B4D20B7F); } // 0x25223CA6B4D20B7F
	static int GET_CLOCK_MINUTES() { return invoke<int>(0x13D2B8ADD79640F2); } // 0x13D2B8ADD79640F2
	static int GET_CLOCK_MONTH() { return invoke<int>(0xBBC72712E80257A1); } // 0xBBC72712E80257A1
	static int GET_CLOCK_SECONDS() { return invoke<int>(0x494E97C2EF27C470); } // 0x494E97C2EF27C470
	static int GET_CLOCK_YEAR() { return invoke<int>(0x961777E64BDAF717); } // 0x961777E64BDAF717
	static void GET_LOCAL_TIME(int* year, int* month, int* day, int* hour, int* minute, int* second) { invoke<Void>(0x50C7A99057A69748, year, month, day, hour, minute, second); } // 0x50C7A99057A69748
	static int GET_MILLISECONDS_PER_GAME_MINUTE() { return invoke<int>(0x2F8B4D1C595B11DB); } // 0x2F8B4D1C595B11DB
	static void GET_POSIX_TIME(int* year, int* month, int* day, int* hour, int* minute, int* second) { invoke<Void>(0xDA488F299A5B164E, year, month, day, hour, minute, second); } // 0xDA488F299A5B164E
	static void _GET_UTC_TIME(int* year, int* month, int* day, int* hour, int* minute, int* second) { invoke<Void>(0x8117E09A19EEF4D3, year, month, day, hour, minute, second); } // 0x8117E09A19EEF4D3
	static void PAUSE_CLOCK(BOOL toggle) { invoke<Void>(0x4055E40BD2DBEC1D, toggle); } // 0x4055E40BD2DBEC1D
	static void SET_CLOCK_DATE(int day, int month, int year) { invoke<Void>(0xB096419DF0D06CE7, day, month, year); } // 0xB096419DF0D06CE7
	static void SET_CLOCK_TIME(int hour, int minute, int second) { invoke<Void>(0x47C3B5848C3E45D8, hour, minute, second); } // 0x47C3B5848C3E45D8
}

namespace CUTSCENE
{
	static BOOL CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY(char* cutsceneEntName, Hash modelHash) { return invoke<BOOL>(0x645D0B458D8E17B5, cutsceneEntName, modelHash); } // 0x645D0B458D8E17B5
	static BOOL CAN_SET_EXIT_STATE_FOR_CAMERA(BOOL p0) { return invoke<BOOL>(0xB2CBCD0930DFB420, p0); } // 0xB2CBCD0930DFB420
	static BOOL CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY(char* cutsceneEntName, Hash modelHash) { return invoke<BOOL>(0x4C6A6451C79E4662, cutsceneEntName, modelHash); } // 0x4C6A6451C79E4662
	static BOOL DOES_CUTSCENE_ENTITY_EXIST(char* cutsceneEntName, Hash modelHash) { return invoke<BOOL>(0x499EF20C5DB25C59, cutsceneEntName, modelHash); } // 0x499EF20C5DB25C59
	static int GET_CUTSCENE_SECTION_PLAYING() { return invoke<int>(0x49010A6A396553D8); } // 0x49010A6A396553D8
	static int GET_CUTSCENE_TIME() { return invoke<int>(0xE625BEABBAFFDAB9); } // 0xE625BEABBAFFDAB9
	static int GET_CUTSCENE_TOTAL_DURATION() { return invoke<int>(0xEE53B14A19E480D4); } // 0xEE53B14A19E480D4
	static Entity GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY(char* cutsceneEntName, Hash modelHash) { return invoke<Entity>(0xA2E9FDB9A8C62F6, cutsceneEntName, modelHash); } // 0xA2E9FDB9A8C62F6
	static Entity GET_ENTITY_INDEX_OF_REGISTERED_ENTITY(char* cutsceneEntName, Hash modelHash) { return invoke<Entity>(0xC0741A26499654CD, cutsceneEntName, modelHash); } // 0xC0741A26499654CD
	static BOOL HAS_CUTSCENE_FINISHED() { return invoke<BOOL>(0x7C0A893088881D57); } // 0x7C0A893088881D57
	static BOOL HAS_CUTSCENE_LOADED() { return invoke<BOOL>(0xC59F528E9AB9F339); } // 0xC59F528E9AB9F339
	static BOOL HAS_THIS_CUTSCENE_LOADED(char* cutsceneName) { return invoke<BOOL>(0x228D3D94F8A11C3C, cutsceneName); } // 0x228D3D94F8A11C3C
	static BOOL IS_CUTSCENE_ACTIVE() { return invoke<BOOL>(0x991251AFC3981F84); } // 0x991251AFC3981F84
	static BOOL IS_CUTSCENE_PLAYING() { return invoke<BOOL>(0xD3C2E180A40F031E); } // 0xD3C2E180A40F031E
	static void _0x011883F41211432A(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0x11883F41211432A, p0, p1, p2, p3, p4, p5, p6); } // 0x11883F41211432A
	static void _0x06A3524161C502BA(Any* p0) { invoke<Void>(0x6A3524161C502BA, p0); } // 0x6A3524161C502BA
	static void _0x06EE9048FD080382(BOOL p0) { invoke<Void>(0x6EE9048FD080382, p0); } // 0x6EE9048FD080382
	static Any _0x0ABC54DE641DC0FC(Any* p0) { return invoke<Any>(0xABC54DE641DC0FC, p0); } // 0xABC54DE641DC0FC
	static void _0x20746F7B1032A3C7(BOOL p0, BOOL p1, BOOL p2, BOOL p3) { invoke<Void>(0x20746F7B1032A3C7, p0, p1, p2, p3); } // 0x20746F7B1032A3C7
	static void _0x2A56C06EBEF2B0D9(char* cutsceneEntName, Ped ped, Hash modelHash) { invoke<Void>(0x2A56C06EBEF2B0D9, cutsceneEntName, ped, modelHash); } // 0x2A56C06EBEF2B0D9
	static void _0x2F137B508DE238F2(BOOL p0) { invoke<Void>(0x2F137B508DE238F2, p0); } // 0x2F137B508DE238F2
	static void _0x41FAA8FB2ECE8720(BOOL p0) { invoke<Void>(0x41FAA8FB2ECE8720, p0); } // 0x41FAA8FB2ECE8720
	static void _0x4C61C75BEE8184C2(char* p0, Any p1, Any p2) { invoke<Void>(0x4C61C75BEE8184C2, p0, p1, p2); } // 0x4C61C75BEE8184C2
	static BOOL _0x4CEBC1ED31E8925E(char* cutsceneName) { return invoke<BOOL>(0x4CEBC1ED31E8925E, cutsceneName); } // 0x4CEBC1ED31E8925E
	static int _0x583DF8E3D4AFBD98() { return invoke<int>(0x583DF8E3D4AFBD98); } // 0x583DF8E3D4AFBD98
	static BOOL _0x5EDEF0CF8C1DAB3C() { return invoke<BOOL>(0x5EDEF0CF8C1DAB3C); } // 0x5EDEF0CF8C1DAB3C
	static void _0x708BDD8CD795B043() { invoke<Void>(0x708BDD8CD795B043); } // 0x708BDD8CD795B043
	static BOOL _0x71B74D2AE19338D0(int p0) { return invoke<BOOL>(0x71B74D2AE19338D0, p0); } // 0x71B74D2AE19338D0
	static void _0x7F96F23FA9B73327(Hash modelHash) { invoke<Void>(0x7F96F23FA9B73327, modelHash); } // 0x7F96F23FA9B73327
	static void _0x8D9DF6ECA8768583(int p0) { invoke<Void>(0x8D9DF6ECA8768583, p0); } // 0x8D9DF6ECA8768583
	static int _0xA0FE76168A189DDB() { return invoke<int>(0xA0FE76168A189DDB); } // 0xA0FE76168A189DDB
	static BOOL _0xA1C996C2A744262E(Any* p0) { return invoke<BOOL>(0xA1C996C2A744262E, p0); } // 0xA1C996C2A744262E
	static BOOL _0xB56BBBCC2955D9CB() { return invoke<BOOL>(0xB56BBBCC2955D9CB); } // 0xB56BBBCC2955D9CB
	static void _0xC61B86C9F61EB404(BOOL toggle) { invoke<Void>(0xC61B86C9F61EB404, toggle); } // 0xC61B86C9F61EB404
	static void _0xD00D76A7DFC9D852(Any* p0) { invoke<Void>(0xD00D76A7DFC9D852, p0); } // 0xD00D76A7DFC9D852
	static void _0xE36A98D8AB3D3C66(BOOL p0) { invoke<Void>(0xE36A98D8AB3D3C66, p0); } // 0xE36A98D8AB3D3C66
	static void REGISTER_ENTITY_FOR_CUTSCENE(Ped cutscenePed, char* cutsceneEntName, int p2, Hash modelHash, int p4) { invoke<Void>(0xE40C1C56DF95C2E8, cutscenePed, cutsceneEntName, p2, modelHash, p4); } // 0xE40C1C56DF95C2E8
	static void REGISTER_SYNCHRONISED_SCRIPT_SPEECH() { invoke<Void>(0x2131046957F31B04); } // 0x2131046957F31B04
	static void REMOVE_CUTSCENE() { invoke<Void>(0x440AF51A3462B86F); } // 0x440AF51A3462B86F
	static void REQUEST_CUTSCENE(char* cutsceneName, int p1) { invoke<Void>(0x7A86743F475D9E09, cutsceneName, p1); } // 0x7A86743F475D9E09
	static void _REQUEST_CUTSCENE_EX(char* cutsceneName, int p1, int p2) { invoke<Void>(0xC23DE0E91C30B58C, cutsceneName, p1, p2); } // 0xC23DE0E91C30B58C
	static void SET_CUTSCENE_FADE_VALUES(BOOL p0, BOOL p1, BOOL p2, BOOL p3) { invoke<Void>(0x8093F23ABACCC7D4, p0, p1, p2, p3); } // 0x8093F23ABACCC7D4
	static void SET_CUTSCENE_ORIGIN(float x, float y, float z, float p3, int p4) { invoke<Void>(0xB812B3FD1C01CF27, x, y, z, p3, p4); } // 0xB812B3FD1C01CF27
	static void SET_CUTSCENE_PED_COMPONENT_VARIATION(char* cutsceneEntName, int p1, int p2, int p3, Hash modelHash) { invoke<Void>(0xBA01E7B6DEEFBBC9, cutsceneEntName, p1, p2, p3, modelHash); } // 0xBA01E7B6DEEFBBC9
	static void SET_CUTSCENE_PED_PROP_VARIATION(char* cutsceneEntName, int p1, int p2, int p3, Hash modelHash) { invoke<Void>(0x546524ADE2E9723, cutsceneEntName, p1, p2, p3, modelHash); } // 0x546524ADE2E9723
	static void SET_CUTSCENE_TRIGGER_AREA(float p0, float p1, float p2, float p3, float p4, float p5) { invoke<Void>(0x9896CE4721BE84BA, p0, p1, p2, p3, p4, p5); } // 0x9896CE4721BE84BA
	static void START_CUTSCENE(int p0) { invoke<Void>(0x186D5CB5E7B0FF7B, p0); } // 0x186D5CB5E7B0FF7B
	static void START_CUTSCENE_AT_COORDS(float x, float y, float z, int p3) { invoke<Void>(0x1C9ADDA3244A1FBF, x, y, z, p3); } // 0x1C9ADDA3244A1FBF
	static void STOP_CUTSCENE(BOOL p0) { invoke<Void>(0xC7272775B4DC786E, p0); } // 0xC7272775B4DC786E
	static void STOP_CUTSCENE_IMMEDIATELY() { invoke<Void>(0xD220BDD222AC4A1E); } // 0xD220BDD222AC4A1E
	static BOOL WAS_CUTSCENE_SKIPPED() { return invoke<BOOL>(0x40C8656EDAEDD569); } // 0x40C8656EDAEDD569
}

namespace DATAFILE
{
	static void _ARRAY_VALUE_ADD_BOOLEAN(Any* arrayData, BOOL value) { invoke<Void>(0xF8B0F5A43E928C76, arrayData, value); } // 0xF8B0F5A43E928C76
	static void _ARRAY_VALUE_ADD_FLOAT(Any* arrayData, float value) { invoke<Void>(0x57A995FD75D37F56, arrayData, value); } // 0x57A995FD75D37F56
	static void _ARRAY_VALUE_ADD_INTEGER(Any* arrayData, int value) { invoke<Void>(0xCABDB751D86FE93B, arrayData, value); } // 0xCABDB751D86FE93B
	static Any* _ARRAY_VALUE_ADD_OBJECT(Any* arrayData) { return invoke<Any*>(0x6889498B3E19C797, arrayData); } // 0x6889498B3E19C797
	static void _ARRAY_VALUE_ADD_STRING(Any* arrayData, char* value) { invoke<Void>(0x2F0661C155AEEEAA, arrayData, value); } // 0x2F0661C155AEEEAA
	static void _ARRAY_VALUE_ADD_VECTOR3(Any* arrayData, float valueX, float valueY, float valueZ) { invoke<Void>(0x407F8D034F70F0C2, arrayData, valueX, valueY, valueZ); } // 0x407F8D034F70F0C2
	static BOOL _ARRAY_VALUE_GET_BOOLEAN(Any* arrayData, int arrayIndex) { return invoke<BOOL>(0x50C1B2874E50C114, arrayData, arrayIndex); } // 0x50C1B2874E50C114
	static float _ARRAY_VALUE_GET_FLOAT(Any* arrayData, int arrayIndex) { return invoke<float>(0xC0C527B525D7CFB5, arrayData, arrayIndex); } // 0xC0C527B525D7CFB5
	static int _ARRAY_VALUE_GET_INTEGER(Any* arrayData, int arrayIndex) { return invoke<int>(0x3E5AE19425CD74BE, arrayData, arrayIndex); } // 0x3E5AE19425CD74BE
	static Any* _ARRAY_VALUE_GET_OBJECT(Any* arrayData, int arrayIndex) { return invoke<Any*>(0x8B5FADCC4E3A145F, arrayData, arrayIndex); } // 0x8B5FADCC4E3A145F
	static int _ARRAY_VALUE_GET_SIZE(Any* arrayData) { return invoke<int>(0x65DB281590CEA2D, arrayData); } // 0x65DB281590CEA2D
	static char* _ARRAY_VALUE_GET_STRING(Any* arrayData, int arrayIndex) { return invoke<char*>(0xD3F2FFEB8D836F52, arrayData, arrayIndex); } // 0xD3F2FFEB8D836F52
	static int _ARRAY_VALUE_GET_TYPE(Any* arrayData, int arrayIndex) { return invoke<int>(0x3A0014ADB172A3C5, arrayData, arrayIndex); } // 0x3A0014ADB172A3C5
	static Vector3 _ARRAY_VALUE_GET_VECTOR3(Any* arrayData, int arrayIndex) { return invoke<Vector3>(0x8D2064E5B64A628A, arrayData, arrayIndex); } // 0x8D2064E5B64A628A
	static void DATAFILE_CREATE() { invoke<Void>(0xD27058A1CA2B13EE); } // 0xD27058A1CA2B13EE
	static void DATAFILE_DELETE() { invoke<Void>(0x9AB9C1CFC8862DFB); } // 0x9AB9C1CFC8862DFB
	static char* DATAFILE_GET_FILE_DICT() { return invoke<char*>(0x906B778CA1DC72B6); } // 0x906B778CA1DC72B6
	static BOOL DATAFILE_IS_SAVE_PENDING() { return invoke<BOOL>(0xBEDB96A7584AA8CF); } // 0xBEDB96A7584AA8CF
	static BOOL _LOAD_UGC_FILE(char* filename) { return invoke<BOOL>(0xC5238C011AF405E4, filename); } // 0xC5238C011AF405E4
	static BOOL _0x01095C95CD46B624(int p0) { return invoke<BOOL>(0x1095C95CD46B624, p0); } // 0x1095C95CD46B624
	static BOOL _0x15FF52B809DB2353(Any p0) { return invoke<BOOL>(0x15FF52B809DB2353, p0); } // 0x15FF52B809DB2353
	static BOOL _0x22DA66936E0FFF37(Any p0) { return invoke<BOOL>(0x22DA66936E0FFF37, p0); } // 0x22DA66936E0FFF37
	static void _0x2ED61456317B8178() { invoke<Void>(0x2ED61456317B8178); } // 0x2ED61456317B8178
	static BOOL _0x4645DE9980999E93(char* p0, char* p1, char* p2, char* p3, char* type) { return invoke<BOOL>(0x4645DE9980999E93, p0, p1, p2, p3, type); } // 0x4645DE9980999E93
	static BOOL _0x4DFDD9EB705F8140(BOOL* p0) { return invoke<BOOL>(0x4DFDD9EB705F8140, p0); } // 0x4DFDD9EB705F8140
	static BOOL _0x52818819057F2B40(int p0) { return invoke<BOOL>(0x52818819057F2B40, p0); } // 0x52818819057F2B40
	static BOOL _0x648E7A5434AF7969(char* p0, Any* p1, BOOL p2, Any* p3, Any* p4, Any* p5, char* type) { return invoke<BOOL>(0x648E7A5434AF7969, p0, p1, p2, p3, p4, p5, type); } // 0x648E7A5434AF7969
	static BOOL _0x692D808C34A82143(char* p0, float p1, char* type) { return invoke<BOOL>(0x692D808C34A82143, p0, p1, type); } // 0x692D808C34A82143
	static void _0x6CC86E78358D5119() { invoke<Void>(0x6CC86E78358D5119); } // 0x6CC86E78358D5119
	static BOOL _0x83BCCE3224735F05(char* filename) { return invoke<BOOL>(0x83BCCE3224735F05, filename); } // 0x83BCCE3224735F05
	static BOOL _0x8F5EA1C01D65A100(Any p0) { return invoke<BOOL>(0x8F5EA1C01D65A100, p0); } // 0x8F5EA1C01D65A100
	static BOOL _0x9CB0BFA7A9342C3D(int p0, BOOL p1) { return invoke<BOOL>(0x9CB0BFA7A9342C3D, p0, p1); } // 0x9CB0BFA7A9342C3D
	static BOOL _0xA5EFC3E847D60507(char* p0, char* p1, char* p2, char* p3, BOOL p4) { return invoke<BOOL>(0xA5EFC3E847D60507, p0, p1, p2, p3, p4); } // 0xA5EFC3E847D60507
	static BOOL _0xA69AC4ADE82B57A4(int p0) { return invoke<BOOL>(0xA69AC4ADE82B57A4, p0); } // 0xA69AC4ADE82B57A4
	static void _0xAD6875BBC0FC899C(Blip x) { invoke<Void>(0xAD6875BBC0FC899C, x); } // 0xAD6875BBC0FC899C
	static void _0xC55854C7D7274882() { invoke<Void>(0xC55854C7D7274882); } // 0xC55854C7D7274882
	static BOOL _0xC84527E235FCA219(char* p0, BOOL p1, char* p2, Any* p3, Any* p4, char* type, BOOL p6) { return invoke<BOOL>(0xC84527E235FCA219, p0, p1, p2, p3, p4, type, p6); } // 0xC84527E235FCA219
	static BOOL _0xF8CC1EBE0B62E29F(Any p0) { return invoke<BOOL>(0xF8CC1EBE0B62E29F, p0); } // 0xF8CC1EBE0B62E29F
	static BOOL _0xFCCAE5B92A830878(Any p0) { return invoke<BOOL>(0xFCCAE5B92A830878, p0); } // 0xFCCAE5B92A830878
	static Any* _OBJECT_VALUE_ADD_ARRAY(Any* objectData, char* key) { return invoke<Any*>(0x5B11728527CA6E5F, objectData, key); } // 0x5B11728527CA6E5F
	static void _OBJECT_VALUE_ADD_BOOLEAN(Any* objectData, char* key, BOOL value) { invoke<Void>(0x35124302A556A325, objectData, key, value); } // 0x35124302A556A325
	static void _OBJECT_VALUE_ADD_FLOAT(Any* objectData, char* key, float value) { invoke<Void>(0xC27E1CC2D795105E, objectData, key, value); } // 0xC27E1CC2D795105E
	static void _OBJECT_VALUE_ADD_INTEGER(Any* objectData, char* key, int value) { invoke<Void>(0xE7E035450A7948D5, objectData, key, value); } // 0xE7E035450A7948D5
	static Any* _OBJECT_VALUE_ADD_OBJECT(Any* objectData, char* key) { return invoke<Any*>(0xA358F56F10732EE1, objectData, key); } // 0xA358F56F10732EE1
	static void _OBJECT_VALUE_ADD_STRING(Any* objectData, char* key, char* value) { invoke<Void>(0x8FF3847DADD8E30C, objectData, key, value); } // 0x8FF3847DADD8E30C
	static void _OBJECT_VALUE_ADD_VECTOR3(Any* objectData, char* key, float valueX, float valueY, float valueZ) { invoke<Void>(0x4CD49B76338C7DEE, objectData, key, valueX, valueY, valueZ); } // 0x4CD49B76338C7DEE
	static Any* _OBJECT_VALUE_GET_ARRAY(Any* objectData, char* key) { return invoke<Any*>(0x7A983AA9DA2659ED, objectData, key); } // 0x7A983AA9DA2659ED
	static BOOL _OBJECT_VALUE_GET_BOOLEAN(Any* objectData, char* key) { return invoke<BOOL>(0x1186940ED72FFEEC, objectData, key); } // 0x1186940ED72FFEEC
	static float _OBJECT_VALUE_GET_FLOAT(Any* objectData, char* key) { return invoke<float>(0x6610343E73B9727, objectData, key); } // 0x6610343E73B9727
	static int _OBJECT_VALUE_GET_INTEGER(Any* objectData, char* key) { return invoke<int>(0x78F06F6B1FB5A80C, objectData, key); } // 0x78F06F6B1FB5A80C
	static Any* _OBJECT_VALUE_GET_OBJECT(Any* objectData, char* key) { return invoke<Any*>(0xB6B9DDC412FCEEE2, objectData, key); } // 0xB6B9DDC412FCEEE2
	static char* _OBJECT_VALUE_GET_STRING(Any* objectData, char* key) { return invoke<char*>(0x3D2FD9E763B24472, objectData, key); } // 0x3D2FD9E763B24472
	static int _OBJECT_VALUE_GET_TYPE(Any* objectData, char* key) { return invoke<int>(0x31C55ED33227371, objectData, key); } // 0x31C55ED33227371
	static Vector3 _OBJECT_VALUE_GET_VECTOR3(Any* objectData, char* key) { return invoke<Vector3>(0x46CD3CB66E0825CC, objectData, key); } // 0x46CD3CB66E0825CC
}

namespace DECORATOR
{
	static BOOL DECOR_EXIST_ON(Entity entity, char* propertyName) { return invoke<BOOL>(0x5661B80A8C9165F, entity, propertyName); } // 0x5661B80A8C9165F
	static BOOL DECOR_GET_BOOL(Entity entity, char* propertyName) { return invoke<BOOL>(0xDACE671663F2F5DB, entity, propertyName); } // 0xDACE671663F2F5DB
	static float _DECOR_GET_FLOAT(Entity entity, char* propertyName) { return invoke<float>(0x6524A2F114706F43, entity, propertyName); } // 0x6524A2F114706F43
	static int DECOR_GET_INT(Entity entity, char* propertyName) { return invoke<int>(0xA06C969B02A97298, entity, propertyName); } // 0xA06C969B02A97298
	static BOOL DECOR_IS_REGISTERED_AS_TYPE(char* propertyName, int type) { return invoke<BOOL>(0x4F14F9F870D6FBC8, propertyName, type); } // 0x4F14F9F870D6FBC8
	static void DECOR_REGISTER(char* propertyName, int type) { invoke<Void>(0x9FD90732F56403CE, propertyName, type); } // 0x9FD90732F56403CE
	static void DECOR_REGISTER_LOCK() { invoke<Void>(0xA9D14EEA259F9248); } // 0xA9D14EEA259F9248
	static BOOL DECOR_REMOVE(Entity entity, char* propertyName) { return invoke<BOOL>(0xEE9F297C738720, entity, propertyName); } // 0xEE9F297C738720
	static BOOL DECOR_SET_BOOL(Entity entity, char* propertyName, BOOL value) { return invoke<BOOL>(0x6B1E8E2ED1335B71, entity, propertyName, value); } // 0x6B1E8E2ED1335B71
	static BOOL _DECOR_SET_FLOAT(Entity entity, char* propertyName, float value) { return invoke<BOOL>(0x211AB1DD8D0F363A, entity, propertyName, value); } // 0x211AB1DD8D0F363A
	static BOOL DECOR_SET_INT(Entity entity, char* propertyName, int value) { return invoke<BOOL>(0xCE3AA5E1CA19E10, entity, propertyName, value); } // 0xCE3AA5E1CA19E10
	static BOOL DECOR_SET_TIME(Entity entity, char* propertyName, int timestamp) { return invoke<BOOL>(0x95AED7B8E39ECAA4, entity, propertyName, timestamp); } // 0x95AED7B8E39ECAA4
	static BOOL _0x241FCA5B1AA14F75() { return invoke<BOOL>(0x241FCA5B1AA14F75); } // 0x241FCA5B1AA14F75
}

namespace DLC
{
	static BOOL GET_IS_LOADING_SCREEN_ACTIVE() { return invoke<BOOL>(0x10D0A8F259E93EC9); } // 0x10D0A8F259E93EC9
	static BOOL IS_DLC_PRESENT(Hash dlcHash) { return invoke<BOOL>(0x812595A0644CE1DE, dlcHash); } // 0x812595A0644CE1DE
	static void _LOAD_MP_DLC_MAPS() { invoke<Void>(0x888C3502DBBEEF5); } // 0x888C3502DBBEEF5
	static BOOL _NULLIFY(Any* variable, Any unused) { return invoke<BOOL>(0x46E2B844905BC5F0, variable, unused); } // 0x46E2B844905BC5F0
	static BOOL _0x8D30F648014A92B5() { return invoke<BOOL>(0x8D30F648014A92B5); } // 0x8D30F648014A92B5
	static Any _0x9489659372A81585() { return invoke<Any>(0x9489659372A81585); } // 0x9489659372A81585
	static Any _0xA213B11DFF526300() { return invoke<Any>(0xA213B11DFF526300); } // 0xA213B11DFF526300
	static void _0xD7C10C4A637992C9() { invoke<Void>(0xD7C10C4A637992C9); } // 0xD7C10C4A637992C9
	static BOOL _0xF2E07819EF1A5289() { return invoke<BOOL>(0xF2E07819EF1A5289); } // 0xF2E07819EF1A5289
}

namespace ENTITY
{
	static void APPLY_FORCE_TO_ENTITY(Entity entity, int forceFlags, float x, float y, float z, float offX, float offY, float offZ, int boneIndex, BOOL isDirectionRel, BOOL ignoreUpVec, BOOL isForceRel, BOOL p12, BOOL p13) { invoke<Void>(0xC5F68BE9613E2D18, entity, forceFlags, x, y, z, offX, offY, offZ, boneIndex, isDirectionRel, ignoreUpVec, isForceRel, p12, p13); } // 0xC5F68BE9613E2D18
	static void APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS(Entity entity, int forceType, float x, float y, float z, BOOL p5, BOOL isDirectionRel, BOOL isForceRel, BOOL p8) { invoke<Void>(0x18FF00FC7EFF559E, entity, forceType, x, y, z, p5, isDirectionRel, isForceRel, p8); } // 0x18FF00FC7EFF559E
	static void ATTACH_ENTITY_TO_ENTITY(Entity entity1, Entity entity2, int boneIndex, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, BOOL p9, BOOL useSoftPinning, BOOL collision, BOOL isPed, int vertexIndex, BOOL fixedRot) { invoke<Void>(0x6B9BBD38AB0796DF, entity1, entity2, boneIndex, xPos, yPos, zPos, xRot, yRot, zRot, p9, useSoftPinning, collision, isPed, vertexIndex, fixedRot); } // 0x6B9BBD38AB0796DF
	static void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY(Entity entity1, Entity entity2, int boneIndex1, int boneIndex2, float xPos1, float yPos1, float zPos1, float xPos2, float yPos2, float zPos2, float xRot, float yRot, float zRot, float breakForce, BOOL fixedRot, BOOL p15, BOOL collision, BOOL teleport, int p18) { invoke<Void>(0xC3675780C92F90F9, entity1, entity2, boneIndex1, boneIndex2, xPos1, yPos1, zPos1, xPos2, yPos2, zPos2, xRot, yRot, zRot, breakForce, fixedRot, p15, collision, teleport, p18); } // 0xC3675780C92F90F9
	static Any CLEAR_ENTITY_LAST_DAMAGE_ENTITY(Entity entity) { return invoke<Any>(0xA72CD9CA74A5ECBA, entity); } // 0xA72CD9CA74A5ECBA
	static void CREATE_FORCED_OBJECT(float x, float y, float z, Any p3, Hash modelHash, BOOL p5) { invoke<Void>(0x150E808B375A385A, x, y, z, p3, modelHash, p5); } // 0x150E808B375A385A
	static void CREATE_MODEL_HIDE(float x, float y, float z, float radius, Hash model, BOOL p5) { invoke<Void>(0x8A97BCA30A0CE478, x, y, z, radius, model, p5); } // 0x8A97BCA30A0CE478
	static void CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS(float x, float y, float z, float radius, Hash model, BOOL p5) { invoke<Void>(0x3A52AE588830BF7F, x, y, z, radius, model, p5); } // 0x3A52AE588830BF7F
	static void CREATE_MODEL_SWAP(float x, float y, float z, float radius, Hash originalModel, Hash newModel, BOOL p6) { invoke<Void>(0x92C47782FDA8B2A3, x, y, z, radius, originalModel, newModel, p6); } // 0x92C47782FDA8B2A3
	static void DELETE_ENTITY(Entity* entity) { invoke<Void>(0xAE3CBE5BF394C9C9, entity); } // 0xAE3CBE5BF394C9C9
	static void DETACH_ENTITY(Entity entity, BOOL p1, BOOL collision) { invoke<Void>(0x961AC54BF0613F5D, entity, p1, collision); } // 0x961AC54BF0613F5D
	static BOOL DOES_ENTITY_BELONG_TO_THIS_SCRIPT(Entity entity, BOOL p2) { return invoke<BOOL>(0xDDE6DF5AE89981D2, entity, p2); } // 0xDDE6DF5AE89981D2
	static BOOL DOES_ENTITY_EXIST(Object entity) { return invoke<BOOL>(0x7239B21A38F536BA, entity); } // 0x7239B21A38F536BA
	static BOOL DOES_ENTITY_HAVE_DRAWABLE(Entity entity) { return invoke<BOOL>(0x60D6E96F8B8E48D, entity); } // 0x60D6E96F8B8E48D
	static BOOL DOES_ENTITY_HAVE_PHYSICS(Entity entity) { return invoke<BOOL>(0xDA95EA3317CC5064, entity); } // 0xDA95EA3317CC5064
	static BOOL FIND_ANIM_EVENT_PHASE(char* animDictionary, char* animName, char* p2, Any* p3, Any* p4) { return invoke<BOOL>(0x7F1BE2BCCAA27A7, animDictionary, animName, p2, p3, p4); } // 0x7F1BE2BCCAA27A7
	static void FORCE_ENTITY_AI_AND_ANIMATION_UPDATE(Entity entity) { invoke<Void>(0x40FDEDB72F8293B2, entity); } // 0x40FDEDB72F8293B2
	static void FREEZE_ENTITY_POSITION(Entity entity, BOOL toggle) { invoke<Void>(0x428CA6DBD1094446, entity, toggle); } // 0x428CA6DBD1094446
	static float _GET_ANIM_DURATION(char* animDict, char* animName) { return invoke<float>(0xFEDDF04D62B8D790, animDict, animName); } // 0xFEDDF04D62B8D790
	static Vector3 GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY(Entity entity) { return invoke<Vector3>(0xE465D4AB7CA6AE72, entity); } // 0xE465D4AB7CA6AE72
	static int GET_ENTITY_ALPHA(Entity entity) { return invoke<int>(0x5A47B3B5E63E94C6, entity); } // 0x5A47B3B5E63E94C6
	static float GET_ENTITY_ANIM_CURRENT_TIME(Entity entity, char* animDict, char* animName) { return invoke<float>(0x346D81500D088F42, entity, animDict, animName); } // 0x346D81500D088F42
	static float GET_ENTITY_ANIM_TOTAL_TIME(Entity entity, char* animDict, char* animName) { return invoke<float>(0x50BD2730B191E360, entity, animDict, animName); } // 0x50BD2730B191E360
	static Entity GET_ENTITY_ATTACHED_TO(Entity entity) { return invoke<Entity>(0x48C2BED9180FE123, entity); } // 0x48C2BED9180FE123
	static int GET_ENTITY_BONE_INDEX_BY_NAME(Entity entity, char* boneName) { return invoke<int>(0xFB71170B7E76ACBA, entity, boneName); } // 0xFB71170B7E76ACBA
	static BOOL _GET_ENTITY_COLLISON_DISABLED(Entity entity) { return invoke<BOOL>(0xCCF1E97BEFDAE480, entity); } // 0xCCF1E97BEFDAE480
	static Vector3 GET_ENTITY_COORDS(Entity entity, BOOL alive) { return invoke<Vector3>(0x3FEF770D40960D5A, entity, alive); } // 0x3FEF770D40960D5A
	static Vector3 GET_ENTITY_FORWARD_VECTOR(Entity entity) { return invoke<Vector3>(0xA794A5A57F8DF91, entity); } // 0xA794A5A57F8DF91
	static float GET_ENTITY_FORWARD_X(Entity entity) { return invoke<float>(0x8BB4EF4214E0E6D5, entity); } // 0x8BB4EF4214E0E6D5
	static float GET_ENTITY_FORWARD_Y(Entity entity) { return invoke<float>(0x866A4A5FAE349510, entity); } // 0x866A4A5FAE349510
	static float GET_ENTITY_HEADING(Entity entity) { return invoke<float>(0xE83D4F9BA2A38914, entity); } // 0xE83D4F9BA2A38914
	static int GET_ENTITY_HEALTH(Entity entity) { return invoke<int>(0xEEF059FAD016D209, entity); } // 0xEEF059FAD016D209
	static float GET_ENTITY_HEIGHT(Entity entity, float X, float Y, float Z, BOOL atTop, BOOL inWorldCoords) { return invoke<float>(0x5A504562485944DD, entity, X, Y, Z, atTop, inWorldCoords); } // 0x5A504562485944DD
	static float GET_ENTITY_HEIGHT_ABOVE_GROUND(Entity entity) { return invoke<float>(0x1DD55701034110E5, entity); } // 0x1DD55701034110E5
	static int GET_ENTITY_LOD_DIST(Entity entity) { return invoke<int>(0x4159C2762B5791D6, entity); } // 0x4159C2762B5791D6
	static void GET_ENTITY_MATRIX(Entity entity, Vector3* rightVector, Vector3* forwardVector, Vector3* upVector, Vector3* position) { invoke<Void>(0xECB2FC7235A7D137, entity, rightVector, forwardVector, upVector, position); } // 0xECB2FC7235A7D137
	static int GET_ENTITY_MAX_HEALTH(Entity entity) { return invoke<int>(0x15D757606D170C3C, entity); } // 0x15D757606D170C3C
	static Hash GET_ENTITY_MODEL(Entity entity) { return invoke<Hash>(0x9F47B058362C84B5, entity); } // 0x9F47B058362C84B5
	static float _GET_ENTITY_PHYSICS_HEADING(Entity entity) { return invoke<float>(0x846BF6291198A71E, entity); } // 0x846BF6291198A71E
	static float GET_ENTITY_PITCH(Entity entity) { return invoke<float>(0xD45DC2893621E1FE, entity); } // 0xD45DC2893621E1FE
	static int GET_ENTITY_POPULATION_TYPE(Entity entity) { return invoke<int>(0xF6F5161F4534EDFF, entity); } // 0xF6F5161F4534EDFF
	static void GET_ENTITY_QUATERNION(Entity entity, float* x, float* y, float* z, float* w) { invoke<Void>(0x7B3703D2D32DFA18, entity, x, y, z, w); } // 0x7B3703D2D32DFA18
	static float GET_ENTITY_ROLL(Entity entity) { return invoke<float>(0x831E0242595560DF, entity); } // 0x831E0242595560DF
	static Vector3 GET_ENTITY_ROTATION(Entity entity, int rotationOrder) { return invoke<Vector3>(0xAFBD61CC738D9EB9, entity, rotationOrder); } // 0xAFBD61CC738D9EB9
	static Vector3 GET_ENTITY_ROTATION_VELOCITY(Entity entity) { return invoke<Vector3>(0x213B91045D09B983, entity); } // 0x213B91045D09B983
	static char* GET_ENTITY_SCRIPT(Entity entity, ScrHandle* script) { return invoke<char*>(0xA6E9C38DB51D7748, entity, script); } // 0xA6E9C38DB51D7748
	static float GET_ENTITY_SPEED(Entity entity) { return invoke<float>(0xD5037BA82E12416F, entity); } // 0xD5037BA82E12416F
	static Vector3 GET_ENTITY_SPEED_VECTOR(Entity entity, BOOL relative) { return invoke<Vector3>(0x9A8D700A51CB7B0D, entity, relative); } // 0x9A8D700A51CB7B0D
	static float GET_ENTITY_SUBMERGED_LEVEL(Entity entity) { return invoke<float>(0xE81AFC1BC4CC41CE, entity); } // 0xE81AFC1BC4CC41CE
	static int GET_ENTITY_TYPE(Entity entity) { return invoke<int>(0x8ACD366038D14505, entity); } // 0x8ACD366038D14505
	static float GET_ENTITY_UPRIGHT_VALUE(Entity entity) { return invoke<float>(0x95EED5A694951F9F, entity); } // 0x95EED5A694951F9F
	static Vector3 GET_ENTITY_VELOCITY(Entity entity) { return invoke<Vector3>(0x4805D2B1D8CF94A9, entity); } // 0x4805D2B1D8CF94A9
	static Hash GET_LAST_MATERIAL_HIT_BY_ENTITY(Entity entity) { return invoke<Hash>(0x5C3D0A935F535C4C, entity); } // 0x5C3D0A935F535C4C
	static Player GET_NEAREST_PLAYER_TO_ENTITY(Entity entity) { return invoke<Player>(0x7196842CB375CDB3, entity); } // 0x7196842CB375CDB3
	static Player GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM(Entity entity, int team) { return invoke<Player>(0x4DC9A62F844D9337, entity, team); } // 0x4DC9A62F844D9337
	static Object GET_OBJECT_INDEX_FROM_ENTITY_INDEX(Entity entity) { return invoke<Object>(0xD7E3B9735C0F89D6, entity); } // 0xD7E3B9735C0F89D6
	static Vector3 GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS(Entity entity, float posX, float posY, float posZ) { return invoke<Vector3>(0x2274BC1C4885E333, entity, posX, posY, posZ); } // 0x2274BC1C4885E333
	static Vector3 GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Entity entity, float offsetX, float offsetY, float offsetZ) { return invoke<Vector3>(0x1899F328B0E12848, entity, offsetX, offsetY, offsetZ); } // 0x1899F328B0E12848
	static Ped GET_PED_INDEX_FROM_ENTITY_INDEX(Entity entity) { return invoke<Ped>(0x4A2A40C73395041, entity); } // 0x4A2A40C73395041
	static Vehicle GET_VEHICLE_INDEX_FROM_ENTITY_INDEX(Entity entity) { return invoke<Vehicle>(0x4B53F92932ADFAC0, entity); } // 0x4B53F92932ADFAC0
	static Vector3 GET_WORLD_POSITION_OF_ENTITY_BONE(Entity entity, int boneIndex) { return invoke<Vector3>(0x44A8FCB8ED227738, entity, boneIndex); } // 0x44A8FCB8ED227738
	static BOOL HAS_ANIM_EVENT_FIRED(Entity entity, Hash actionHash) { return invoke<BOOL>(0xEAF4CD9EA3E7E922, entity, actionHash); } // 0xEAF4CD9EA3E7E922
	static BOOL HAS_COLLISION_LOADED_AROUND_ENTITY(Entity entity) { return invoke<BOOL>(0xE9676F61BC0B3321, entity); } // 0xE9676F61BC0B3321
	static BOOL HAS_ENTITY_ANIM_FINISHED(Entity entity, char* animDict, char* animName, int p3) { return invoke<BOOL>(0x20B711662962B472, entity, animDict, animName, p3); } // 0x20B711662962B472
	static BOOL HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT(Entity entity) { return invoke<BOOL>(0x95EB9964FF5C5C65, entity); } // 0x95EB9964FF5C5C65
	static BOOL HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED(Entity entity) { return invoke<BOOL>(0x605F5A140F202491, entity); } // 0x605F5A140F202491
	static BOOL HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE(Entity entity) { return invoke<BOOL>(0xDFD5033FDBA0A9C8, entity); } // 0xDFD5033FDBA0A9C8
	static BOOL HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY(Entity entity1, Entity entity2, BOOL p2) { return invoke<BOOL>(0xC86D67D52A707CF8, entity1, entity2, p2); } // 0xC86D67D52A707CF8
	static BOOL HAS_ENTITY_CLEAR_LOS_TO_ENTITY(Entity entity1, Entity entity2, int traceType) { return invoke<BOOL>(0xFCDFF7B72D23A1AC, entity1, entity2, traceType); } // 0xFCDFF7B72D23A1AC
	static BOOL HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT(Entity entity1, Entity entity2) { return invoke<BOOL>(0x267D00AF114F17A, entity1, entity2); } // 0x267D00AF114F17A
	static BOOL HAS_ENTITY_COLLIDED_WITH_ANYTHING(Entity entity) { return invoke<BOOL>(0x8BAD02F0368D9E14, entity); } // 0x8BAD02F0368D9E14
	static BOOL IS_AN_ENTITY(int handle) { return invoke<BOOL>(0x731EC8A916BD11A1, handle); } // 0x731EC8A916BD11A1
	static BOOL IS_ENTITY_A_MISSION_ENTITY(Entity entity) { return invoke<BOOL>(0xA7B270912999B3C, entity); } // 0xA7B270912999B3C
	static BOOL IS_ENTITY_AN_OBJECT(Entity entity) { return invoke<BOOL>(0x8D68C8FD0FACA94E, entity); } // 0x8D68C8FD0FACA94E
	static BOOL IS_ENTITY_A_PED(Entity entity) { return invoke<BOOL>(0x524AC5ECEA15343E, entity); } // 0x524AC5ECEA15343E
	static BOOL IS_ENTITY_AT_COORD(Entity entity, float xPos, float yPos, float zPos, float xSize, float ySize, float zSize, BOOL p7, BOOL p8, int p9) { return invoke<BOOL>(0x20B60995556D004F, entity, xPos, yPos, zPos, xSize, ySize, zSize, p7, p8, p9); } // 0x20B60995556D004F
	static BOOL IS_ENTITY_AT_ENTITY(Entity entity1, Entity entity2, float xSize, float ySize, float zSize, BOOL p5, BOOL p6, int p7) { return invoke<BOOL>(0x751B70C3D034E187, entity1, entity2, xSize, ySize, zSize, p5, p6, p7); } // 0x751B70C3D034E187
	static BOOL IS_ENTITY_ATTACHED(Entity entity) { return invoke<BOOL>(0xB346476EF1A64897, entity); } // 0xB346476EF1A64897
	static BOOL IS_ENTITY_ATTACHED_TO_ANY_OBJECT(Entity entity) { return invoke<BOOL>(0xCF511840CEEDE0CC, entity); } // 0xCF511840CEEDE0CC
	static BOOL IS_ENTITY_ATTACHED_TO_ANY_PED(Entity entity) { return invoke<BOOL>(0xB1632E9A5F988D11, entity); } // 0xB1632E9A5F988D11
	static BOOL IS_ENTITY_ATTACHED_TO_ANY_VEHICLE(Entity entity) { return invoke<BOOL>(0x26AA915AD89BFB4B, entity); } // 0x26AA915AD89BFB4B
	static BOOL IS_ENTITY_ATTACHED_TO_ENTITY(Entity from, Entity to) { return invoke<BOOL>(0xEFBE71898A993728, from, to); } // 0xEFBE71898A993728
	static BOOL IS_ENTITY_A_VEHICLE(Entity entity) { return invoke<BOOL>(0x6AC7003FA6E5575E, entity); } // 0x6AC7003FA6E5575E
	static BOOL IS_ENTITY_DEAD(Entity entity) { return invoke<BOOL>(0x5F9532F3B5CC2551, entity); } // 0x5F9532F3B5CC2551
	static BOOL IS_ENTITY_IN_AIR(Entity entity) { return invoke<BOOL>(0x886E37EC497200B6, entity); } // 0x886E37EC497200B6
	static BOOL IS_ENTITY_IN_ANGLED_AREA(Entity entity, float originX, float originY, float originZ, float edgeX, float edgeY, float edgeZ, float angle, BOOL p8, BOOL p9, Any p10) { return invoke<BOOL>(0x51210CED3DA1C78A, entity, originX, originY, originZ, edgeX, edgeY, edgeZ, angle, p8, p9, p10); } // 0x51210CED3DA1C78A
	static BOOL IS_ENTITY_IN_AREA(Entity entity, float x1, float y1, float z1, float x2, float y2, float z2, BOOL p7, BOOL p8, Any p9) { return invoke<BOOL>(0x54736AA40E271165, entity, x1, y1, z1, x2, y2, z2, p7, p8, p9); } // 0x54736AA40E271165
	static BOOL IS_ENTITY_IN_WATER(Entity entity) { return invoke<BOOL>(0xCFB0A0D8EDD145A3, entity); } // 0xCFB0A0D8EDD145A3
	static BOOL IS_ENTITY_IN_ZONE(Entity entity, char* zone) { return invoke<BOOL>(0xB6463CF6AF527071, entity, zone); } // 0xB6463CF6AF527071
	static BOOL IS_ENTITY_OCCLUDED(Entity entity) { return invoke<BOOL>(0xE31C2C72B8692B64, entity); } // 0xE31C2C72B8692B64
	static BOOL IS_ENTITY_ON_SCREEN(Entity entity) { return invoke<BOOL>(0xE659E47AF827484B, entity); } // 0xE659E47AF827484B
	static BOOL IS_ENTITY_PLAYING_ANIM(Entity entity, char* animDict, char* animName, int taskFlag) { return invoke<BOOL>(0x1F0B79228E461EC9, entity, animDict, animName, taskFlag); } // 0x1F0B79228E461EC9
	static BOOL IS_ENTITY_STATIC(Entity entity) { return invoke<BOOL>(0x1218E6886D3D8327, entity); } // 0x1218E6886D3D8327
	static BOOL IS_ENTITY_TOUCHING_ENTITY(Entity entity, Entity targetEntity) { return invoke<BOOL>(0x17FFC1B2BA35A494, entity, targetEntity); } // 0x17FFC1B2BA35A494
	static BOOL IS_ENTITY_TOUCHING_MODEL(Entity entity, Hash modelHash) { return invoke<BOOL>(0xF42323798A58C8C, entity, modelHash); } // 0xF42323798A58C8C
	static BOOL IS_ENTITY_UPRIGHT(Entity entity, float angle) { return invoke<BOOL>(0x5333F526F6AB19AA, entity, angle); } // 0x5333F526F6AB19AA
	static BOOL IS_ENTITY_UPSIDEDOWN(Entity entity) { return invoke<BOOL>(0x1DBD58820FA61D71, entity); } // 0x1DBD58820FA61D71
	static BOOL IS_ENTITY_VISIBLE(Entity entity) { return invoke<BOOL>(0x47D6F43D77935C75, entity); } // 0x47D6F43D77935C75
	static BOOL IS_ENTITY_VISIBLE_TO_SCRIPT(Entity entity) { return invoke<BOOL>(0xD796CB5BA8F20E32, entity); } // 0xD796CB5BA8F20E32
	static BOOL IS_ENTITY_WAITING_FOR_WORLD_COLLISION(Entity entity) { return invoke<BOOL>(0xD05BFF0C0A12C68F, entity); } // 0xD05BFF0C0A12C68F
	static void _0x1A092BB0C3808B96(Entity entity, BOOL p1) { invoke<Void>(0x1A092BB0C3808B96, entity, p1); } // 0x1A092BB0C3808B96
	static void _0x2C2E3DC128F44309(Entity entity, BOOL p1) { invoke<Void>(0x2C2E3DC128F44309, entity, p1); } // 0x2C2E3DC128F44309
	static void _0x352E2B5CF420BF3B(Any p0, Any p1) { invoke<Void>(0x352E2B5CF420BF3B, p0, p1); } // 0x352E2B5CF420BF3B
	static void _0x36F32DE87082343E(Any p0, Any p1) { invoke<Void>(0x36F32DE87082343E, p0, p1); } // 0x36F32DE87082343E
	static Vector3 _0x46F8696933A63C9B(Any p0, Any p1) { return invoke<Vector3>(0x46F8696933A63C9B, p0, p1); } // 0x46F8696933A63C9B
	static void _0x490861B88F4FD846(Any p0) { invoke<Void>(0x490861B88F4FD846, p0); } // 0x490861B88F4FD846
	static void _0x5C3B791D580E0BC2(Entity entity, float p1) { invoke<Void>(0x5C3B791D580E0BC2, entity, p1); } // 0x5C3B791D580E0BC2
	static void _0x5C48B75732C8456C(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0x5C48B75732C8456C, p0, p1, p2, p3, p4, p5); } // 0x5C48B75732C8456C
	static void _0x694E00132F2823ED(Entity entity, BOOL p1) { invoke<Void>(0x694E00132F2823ED, entity, p1); } // 0x694E00132F2823ED
	static void _0x6CE177D014502E8A(Any p0) { invoke<Void>(0x6CE177D014502E8A, p0); } // 0x6CE177D014502E8A
	static void _0x78E8E3A640178255(Entity entity) { invoke<Void>(0x78E8E3A640178255, entity); } // 0x78E8E3A640178255
	static void _0xA80AE305E0A3044F(Entity entity, BOOL p1) { invoke<Void>(0xA80AE305E0A3044F, entity, p1); } // 0xA80AE305E0A3044F
	static void _0xB17BC6453F6CF5AC(Any p0, Any p1) { invoke<Void>(0xB17BC6453F6CF5AC, p0, p1); } // 0xB17BC6453F6CF5AC
	static Any _0xB328DCC3A3AA401B(Any p0) { return invoke<Any>(0xB328DCC3A3AA401B, p0); } // 0xB328DCC3A3AA401B
	static void _0xC34BC448DA29F5E9(Any p0, Any p1) { invoke<Void>(0xC34BC448DA29F5E9, p0, p1); } // 0xC34BC448DA29F5E9
	static Vector3 _0xCE6294A232D03786(Any p0, Any p1) { return invoke<Vector3>(0xCE6294A232D03786, p0, p1); } // 0xCE6294A232D03786
	static void _0xCEA7C8E1B48FF68C(Any p0, Any p1) { invoke<Void>(0xCEA7C8E1B48FF68C, p0, p1); } // 0xCEA7C8E1B48FF68C
	static Any _0xD95CC5D2AB15A09F(Any p0) { return invoke<Any>(0xD95CC5D2AB15A09F, p0); } // 0xD95CC5D2AB15A09F
	static void _0xDC6F8601FAF2E893(Entity entity, BOOL p1) { invoke<Void>(0xDC6F8601FAF2E893, entity, p1); } // 0xDC6F8601FAF2E893
	static void _0xE12ABE5E3A389A6C(Entity entity, BOOL p1) { invoke<Void>(0xE12ABE5E3A389A6C, entity, p1); } // 0xE12ABE5E3A389A6C
	static void _0xFD1695C5D3B05439(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0xFD1695C5D3B05439, p0, p1, p2, p3, p4, p5); } // 0xFD1695C5D3B05439
	static BOOL PLAY_ENTITY_ANIM(Entity entity, char* animName, char* animDict, float p3, BOOL loop, BOOL stayInAnim, BOOL p6, float delta, Any bitset) { return invoke<BOOL>(0x7FB218262B810701, entity, animName, animDict, p3, loop, stayInAnim, p6, delta, bitset); } // 0x7FB218262B810701
	static BOOL PLAY_SYNCHRONIZED_ENTITY_ANIM(Entity entity, int syncedScene, char* animation, char* propName, float p4, float p5, Any p6, float p7) { return invoke<BOOL>(0xC77720A12FE14A86, entity, syncedScene, animation, propName, p4, p5, p6, p7); } // 0xC77720A12FE14A86
	static BOOL PLAY_SYNCHRONIZED_MAP_ENTITY_ANIM(float p0, float p1, float p2, float p3, Any p4, Any p5, Any* p6, Any* p7, float p8, float p9, Any p10, float p11) { return invoke<BOOL>(0xB9C54555ED30FBC4, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); } // 0xB9C54555ED30FBC4
	static void PROCESS_ENTITY_ATTACHMENTS(Entity entity) { invoke<Void>(0xF4080490ADC51C6F, entity); } // 0xF4080490ADC51C6F
	static void REMOVE_FORCED_OBJECT(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x61B6775E83C0DB6F, p0, p1, p2, p3, p4); } // 0x61B6775E83C0DB6F
	static void REMOVE_MODEL_HIDE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0xD9E3006FB3CBD765, p0, p1, p2, p3, p4, p5); } // 0xD9E3006FB3CBD765
	static void REMOVE_MODEL_SWAP(float x, float y, float z, float radius, Hash originalModel, Hash newModel, BOOL p6) { invoke<Void>(0x33C0F9A64E229AE, x, y, z, radius, originalModel, newModel, p6); } // 0x33C0F9A64E229AE
	static Any RESET_ENTITY_ALPHA(Entity entity) { return invoke<Any>(0x9B1E824FFBB7027A, entity); } // 0x9B1E824FFBB7027A
	static void SET_ENTITY_ALPHA(Entity entity, int alphaLevel, int skin) { invoke<Void>(0x44A0870B7E92D7C0, entity, alphaLevel, skin); } // 0x44A0870B7E92D7C0
	static void SET_ENTITY_ALWAYS_PRERENDER(Entity entity, BOOL toggle) { invoke<Void>(0xACAD101E1FB66689, entity, toggle); } // 0xACAD101E1FB66689
	static void SET_ENTITY_ANIM_CURRENT_TIME(Entity entity, char* animDictionary, char* animName, float time) { invoke<Void>(0x4487C259F0F70977, entity, animDictionary, animName, time); } // 0x4487C259F0F70977
	static void SET_ENTITY_ANIM_SPEED(Entity entity, char* animDictionary, char* animName, float speedMultiplier) { invoke<Void>(0x28D1A16553C51776, entity, animDictionary, animName, speedMultiplier); } // 0x28D1A16553C51776
	static void SET_ENTITY_AS_MISSION_ENTITY(Entity entity, BOOL p1, BOOL p2) { invoke<Void>(0xAD738C3085FE7E11, entity, p1, p2); } // 0xAD738C3085FE7E11
	static void SET_ENTITY_AS_NO_LONGER_NEEDED(Entity* entity) { invoke<Void>(0xB736A491E64A32CF, entity); } // 0xB736A491E64A32CF
	static void SET_ENTITY_CAN_BE_DAMAGED(Entity entity, BOOL toggle) { invoke<Void>(0x1760FFA8AB074D66, entity, toggle); } // 0x1760FFA8AB074D66
	static void SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP(Entity entity, BOOL bCanBeDamaged, int relGroup) { invoke<Void>(0xE22D8FDE858B8119, entity, bCanBeDamaged, relGroup); } // 0xE22D8FDE858B8119
	static void SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS(Entity entity, BOOL toggle) { invoke<Void>(0xD3997889736FD899, entity, toggle); } // 0xD3997889736FD899
	static void SET_ENTITY_COLLISION(Entity entity, BOOL toggle, BOOL keepPhysics) { invoke<Void>(0x1A9205C1B9EE827F, entity, toggle, keepPhysics); } // 0x1A9205C1B9EE827F
	static void _SET_ENTITY_COLLISION_2(Entity entity, BOOL p1, BOOL p2) { invoke<Void>(0x9EBC85ED0FFFE51C, entity, p1, p2); } // 0x9EBC85ED0FFFE51C
	static void SET_ENTITY_COORDS(Entity entity, float xPos, float yPos, float zPos, BOOL xAxis, BOOL yAxis, BOOL zAxis, BOOL clearArea) { invoke<Void>(0x6843DA7060A026B, entity, xPos, yPos, zPos, xAxis, yAxis, zAxis, clearArea); } // 0x6843DA7060A026B
	static void SET_ENTITY_COORDS_NO_OFFSET(Entity entity, float xPos, float yPos, float zPos, BOOL xAxis, BOOL yAxis, BOOL zAxis) { invoke<Void>(0x239A3351AC1DA385, entity, xPos, yPos, zPos, xAxis, yAxis, zAxis); } // 0x239A3351AC1DA385
	static void _SET_ENTITY_COORDS_2(Entity entity, float xPos, float yPos, float zPos, BOOL xAxis, BOOL yAxis, BOOL zAxis, BOOL clearArea) { invoke<Void>(0x621873ECE1178967, entity, xPos, yPos, zPos, xAxis, yAxis, zAxis, clearArea); } // 0x621873ECE1178967
	static void SET_ENTITY_DYNAMIC(Entity entity, BOOL toggle) { invoke<Void>(0x1718DE8E3F2823CA, entity, toggle); } // 0x1718DE8E3F2823CA
	static void SET_ENTITY_HAS_GRAVITY(Entity entity, BOOL toggle) { invoke<Void>(0x4A4722448F18EEF5, entity, toggle); } // 0x4A4722448F18EEF5
	static void SET_ENTITY_HEADING(Entity entity, float heading) { invoke<Void>(0x8E2530AA8ADA980E, entity, heading); } // 0x8E2530AA8ADA980E
	static void SET_ENTITY_HEALTH(Entity entity, int health) { invoke<Void>(0x6B76DC1F3AE6E6A3, entity, health); } // 0x6B76DC1F3AE6E6A3
	static void SET_ENTITY_INVINCIBLE(Entity entity, BOOL toggle) { invoke<Void>(0x3882114BDE571AD4, entity, toggle); } // 0x3882114BDE571AD4
	static void SET_ENTITY_IS_TARGET_PRIORITY(Entity entity, BOOL p1, float p2) { invoke<Void>(0xEA02E132F5C68722, entity, p1, p2); } // 0xEA02E132F5C68722
	static void SET_ENTITY_LIGHTS(Entity entity, BOOL toggle) { invoke<Void>(0x7CFBA6A80BDF3874, entity, toggle); } // 0x7CFBA6A80BDF3874
	static void SET_ENTITY_LOAD_COLLISION_FLAG(Entity entity, BOOL toggle) { invoke<Void>(0xDC7CABAB1E9B67E, entity, toggle); } // 0xDC7CABAB1E9B67E
	static void SET_ENTITY_LOD_DIST(Entity entity, int value) { invoke<Void>(0x5927F96A78577363, entity, value); } // 0x5927F96A78577363
	static void SET_ENTITY_MAX_HEALTH(Entity entity, int value) { invoke<Void>(0x166E7CF68597D8B5, entity, value); } // 0x166E7CF68597D8B5
	static void SET_ENTITY_MAX_SPEED(Entity entity, float speed) { invoke<Void>(0xE46A3FCBDE2A1B1, entity, speed); } // 0xE46A3FCBDE2A1B1
	static void SET_ENTITY_MOTION_BLUR(Entity entity, BOOL toggle) { invoke<Void>(0x295D82A8559F9150, entity, toggle); } // 0x295D82A8559F9150
	static void SET_ENTITY_NO_COLLISION_ENTITY(Entity entity1, Entity entity2, BOOL unknown) { invoke<Void>(0xA53ED5520C07654A, entity1, entity2, unknown); } // 0xA53ED5520C07654A
	static void SET_ENTITY_ONLY_DAMAGED_BY_PLAYER(Entity entity, BOOL toggle) { invoke<Void>(0x79F020FF9EDC0748, entity, toggle); } // 0x79F020FF9EDC0748
	static void SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP(Entity entity, BOOL p1, Hash relationshipHash) { invoke<Void>(0x7022BD828FA0B082, entity, p1, relationshipHash); } // 0x7022BD828FA0B082
	static void SET_ENTITY_PROOFS(Entity entity, BOOL bulletProof, BOOL fireProof, BOOL explosionProof, BOOL collisionProof, BOOL meleeProof, BOOL p6, BOOL p7, BOOL p8) { invoke<Void>(0xFAEE099C6F890BB8, entity, bulletProof, fireProof, explosionProof, collisionProof, meleeProof, p6, p7, p8); } // 0xFAEE099C6F890BB8
	static void SET_ENTITY_QUATERNION(Entity entity, float x, float y, float z, float w) { invoke<Void>(0x77B21BE7AC540F07, entity, x, y, z, w); } // 0x77B21BE7AC540F07
	static void SET_ENTITY_RECORDS_COLLISIONS(Entity entity, BOOL toggle) { invoke<Void>(0xA50A1EEDAD01E65, entity, toggle); } // 0xA50A1EEDAD01E65
	static void SET_ENTITY_RENDER_SCORCHED(Entity entity, BOOL toggle) { invoke<Void>(0x730F5F8D3F0F2050, entity, toggle); } // 0x730F5F8D3F0F2050
	static void SET_ENTITY_ROTATION(Entity entity, float pitch, float roll, float yaw, int rotationOrder, BOOL p5) { invoke<Void>(0x8524A8B0171D5E07, entity, pitch, roll, yaw, rotationOrder, p5); } // 0x8524A8B0171D5E07
	static void _SET_ENTITY_SOMETHING(Entity entity, BOOL toggle) { invoke<Void>(0x3910051CCECDB00C, entity, toggle); } // 0x3910051CCECDB00C
	static void SET_ENTITY_TRAFFICLIGHT_OVERRIDE(Entity entity, int state) { invoke<Void>(0x57C5DB656185EAC4, entity, state); } // 0x57C5DB656185EAC4
	static void SET_ENTITY_VELOCITY(Entity entity, float x, float y, float z) { invoke<Void>(0x1C99BB7B6E96D16F, entity, x, y, z); } // 0x1C99BB7B6E96D16F
	static void SET_ENTITY_VISIBLE(Entity entity, BOOL toggle, BOOL unk) { invoke<Void>(0xEA1C610A04DB6BBB, entity, toggle, unk); } // 0xEA1C610A04DB6BBB
	static void SET_OBJECT_AS_NO_LONGER_NEEDED(Object* object) { invoke<Void>(0x3AE22DEB5BA5A3E6, object); } // 0x3AE22DEB5BA5A3E6
	static void SET_PED_AS_NO_LONGER_NEEDED(Ped* ped) { invoke<Void>(0x2595DD4236549CE3, ped); } // 0x2595DD4236549CE3
	static void SET_VEHICLE_AS_NO_LONGER_NEEDED(Vehicle* vehicle) { invoke<Void>(0x629BFA74418D6239, vehicle); } // 0x629BFA74418D6239
	static Any STOP_ENTITY_ANIM(Entity entity, char* animation, char* animGroup, float p3) { return invoke<Any>(0x28004F88151E03E0, entity, animation, animGroup, p3); } // 0x28004F88151E03E0
	static BOOL STOP_SYNCHRONIZED_ENTITY_ANIM(Entity entity, float p1, BOOL p2) { return invoke<BOOL>(0x43D3807C077261E3, entity, p1, p2); } // 0x43D3807C077261E3
	static BOOL STOP_SYNCHRONIZED_MAP_ENTITY_ANIM(float p0, float p1, float p2, float p3, Any p4, float p5) { return invoke<BOOL>(0x11E79CAB7183B6F5, p0, p1, p2, p3, p4, p5); } // 0x11E79CAB7183B6F5
	static BOOL WOULD_ENTITY_BE_OCCLUDED(Hash entityModelHash, float x, float y, float z, BOOL p4) { return invoke<BOOL>(0xEE5D2A122E09EC42, entityModelHash, x, y, z, p4); } // 0xEE5D2A122E09EC42
}

namespace EVENT
{
	static ScrHandle ADD_SHOCKING_EVENT_AT_POSITION(int type, float x, float y, float z, float duration) { return invoke<ScrHandle>(0xD9F8455409B525E9, type, x, y, z, duration); } // 0xD9F8455409B525E9
	static ScrHandle ADD_SHOCKING_EVENT_FOR_ENTITY(int type, Entity entity, float duration) { return invoke<ScrHandle>(0x7FD8F3BE76F89422, type, entity, duration); } // 0x7FD8F3BE76F89422
	static void BLOCK_DECISION_MAKER_EVENT(Hash name, int type) { invoke<Void>(0xE42FCDFD0E4196F7, name, type); } // 0xE42FCDFD0E4196F7
	static void CLEAR_DECISION_MAKER_EVENT_RESPONSE(Hash name, int type) { invoke<Void>(0x4FC9381A7AEE8968, name, type); } // 0x4FC9381A7AEE8968
	static BOOL IS_SHOCKING_EVENT_IN_SPHERE(int type, float x, float y, float z, float radius) { return invoke<BOOL>(0x1374ABB7C15BAB92, type, x, y, z, radius); } // 0x1374ABB7C15BAB92
	static void REMOVE_ALL_SHOCKING_EVENTS(BOOL p0) { invoke<Void>(0xEAABE8FDFA21274C, p0); } // 0xEAABE8FDFA21274C
	static BOOL REMOVE_SHOCKING_EVENT(ScrHandle event) { return invoke<BOOL>(0x2CDA538C44C6CCE5, event); } // 0x2CDA538C44C6CCE5
	static void REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS() { invoke<Void>(0x340F1415B68AEADE); } // 0x340F1415B68AEADE
	static void SET_DECISION_MAKER(Ped ped, Hash name) { invoke<Void>(0xB604A2942ADED0EE, ped, name); } // 0xB604A2942ADED0EE
	static void SUPPRESS_AGITATION_EVENTS_NEXT_FRAME() { invoke<Void>(0x5F3B7749C112D552); } // 0x5F3B7749C112D552
	static void SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME() { invoke<Void>(0x2F9A292AD0A3BD89); } // 0x2F9A292AD0A3BD89
	static void SUPPRESS_SHOCKING_EVENT_TYPE_NEXT_FRAME(int type) { invoke<Void>(0x3FD2EC8BF1F1CF30, type); } // 0x3FD2EC8BF1F1CF30
	static void UNBLOCK_DECISION_MAKER_EVENT(Hash name, int type) { invoke<Void>(0xD7CD9CF34F2C99E8, name, type); } // 0xD7CD9CF34F2C99E8
}

namespace FILESYSTEM
{
	static BOOL GET_DLC_VEHICLE_DATA(int dlcVehicleIndex, int* outData) { return invoke<BOOL>(0x33468EDC08E371F6, dlcVehicleIndex, outData); } // 0x33468EDC08E371F6
	static int GET_DLC_VEHICLE_FLAGS(int dlcVehicleIndex) { return invoke<int>(0x5549EE11FA22FCF2, dlcVehicleIndex); } // 0x5549EE11FA22FCF2
	static Hash GET_DLC_VEHICLE_MODEL(int dlcVehicleIndex) { return invoke<Hash>(0xECC01B7C5763333C, dlcVehicleIndex); } // 0xECC01B7C5763333C
	static BOOL GET_DLC_WEAPON_COMPONENT_DATA(int dlcWeaponIndex, int dlcWeapCompIndex, Any* ComponentDataPtr) { return invoke<BOOL>(0x6CF598A2957C2BF8, dlcWeaponIndex, dlcWeapCompIndex, ComponentDataPtr); } // 0x6CF598A2957C2BF8
	static BOOL GET_DLC_WEAPON_DATA(int dlcWeaponIndex, int* outData) { return invoke<BOOL>(0x79923CD21BECE14E, dlcWeaponIndex, outData); } // 0x79923CD21BECE14E
	static void GET_FORCED_COMPONENT(Hash componentHash, int componentId, Any* p2, Any* p3, Any* p4) { invoke<Void>(0x6C93ED8C2F74859B, componentHash, componentId, p2, p3, p4); } // 0x6C93ED8C2F74859B
	static Hash GET_HASH_NAME_FOR_COMPONENT(Entity entity, int componentId, int drawableVariant, int textureVariant) { return invoke<Hash>(0x368B3A838070348, entity, componentId, drawableVariant, textureVariant); } // 0x368B3A838070348
	static Hash GET_HASH_NAME_FOR_PROP(Entity entity, int componentId, int propIndex, int propTextureIndex) { return invoke<Hash>(0x5D6160275CAEC8DD, entity, componentId, propIndex, propTextureIndex); } // 0x5D6160275CAEC8DD
	static int _GET_NUM_DECORATIONS(int character) { return invoke<int>(0x278F76C3B0A8F109, character); } // 0x278F76C3B0A8F109
	static int GET_NUM_DLC_VEHICLES() { return invoke<int>(0xA7A866D21CD2329B); } // 0xA7A866D21CD2329B
	static int GET_NUM_DLC_WEAPON_COMPONENTS(int dlcWeaponIndex) { return invoke<int>(0x405425358A7D61FE, dlcWeaponIndex); } // 0x405425358A7D61FE
	static int GET_NUM_DLC_WEAPONS() { return invoke<int>(0xEE47635F352DA367); } // 0xEE47635F352DA367
	static int _GET_NUM_FORCED_COMPONENTS(Hash componentHash) { return invoke<int>(0xC6B9DB42C04DD8C3, componentHash); } // 0xC6B9DB42C04DD8C3
	static int _GET_NUM_PROPS_FROM_OUTFIT(int character, int p1, int p2, BOOL p3, int p4, int componentId) { return invoke<int>(0x9BDF59818B1E38C1, character, p1, p2, p3, p4, componentId); } // 0x9BDF59818B1E38C1
	static BOOL _GET_PROP_FROM_OUTFIT(Any outfit, int slot, Any* item) { return invoke<BOOL>(0x19F2A026EDF0013F, outfit, slot, item); } // 0x19F2A026EDF0013F
	static void GET_SHOP_PED_COMPONENT(Hash p0, Any* p1) { invoke<Void>(0x74C0E2A57EC66760, p0, p1); } // 0x74C0E2A57EC66760
	static void GET_SHOP_PED_OUTFIT(Any p0, Any* p1) { invoke<Void>(0xB7952076E444979D, p0, p1); } // 0xB7952076E444979D
	static Any GET_SHOP_PED_OUTFIT_LOCATE(Any p0) { return invoke<Any>(0x73CA26B079F956E, p0); } // 0x73CA26B079F956E
	static void GET_SHOP_PED_QUERY_COMPONENT(int componentId, int* outComponent) { invoke<Void>(0x249E310B2D920699, componentId, outComponent); } // 0x249E310B2D920699
	static void GET_SHOP_PED_QUERY_OUTFIT(Any p0, Any* outfit) { invoke<Void>(0x6D793F03A631FE56, p0, outfit); } // 0x6D793F03A631FE56
	static void GET_SHOP_PED_QUERY_PROP(Any p0, Any* p1) { invoke<Void>(0xDE44A00999B2837D, p0, p1); } // 0xDE44A00999B2837D
	static BOOL _GET_TATTOO_COLLECTION_DATA(int characterType, int decorationIndex, Any* outComponent) { return invoke<BOOL>(0xFF56381874F82086, characterType, decorationIndex, outComponent); } // 0xFF56381874F82086
	static void GET_VARIANT_COMPONENT(Hash componentHash, int componentId, Any* p2, Any* p3, Any* p4) { invoke<Void>(0x6E11F282F11863B6, componentHash, componentId, p2, p3, p4); } // 0x6E11F282F11863B6
	static void INIT_SHOP_PED_COMPONENT(int* outComponent) { invoke<Void>(0x1E8C308FD312C036, outComponent); } // 0x1E8C308FD312C036
	static void INIT_SHOP_PED_PROP(int* outProp) { invoke<Void>(0xEB0A2B758F7B850F, outProp); } // 0xEB0A2B758F7B850F
	static BOOL _IS_DLC_DATA_EMPTY(Any* dlcData) { return invoke<BOOL>(0xD4D7B033C3AA243C, dlcData); } // 0xD4D7B033C3AA243C
	static BOOL IS_DLC_VEHICLE_MOD(Any modData) { return invoke<BOOL>(0x564B9FF9631B82C, modData); } // 0x564B9FF9631B82C
	static Any _0x017568A8182D98A6(Any p0) { return invoke<Any>(0x17568A8182D98A6, p0); } // 0x17568A8182D98A6
	static BOOL _0x341DE7ED1D2A1BFD(Hash componentHash, Hash drawableSlotHash, int componentId) { return invoke<BOOL>(0x341DE7ED1D2A1BFD, componentHash, drawableSlotHash, componentId); } // 0x341DE7ED1D2A1BFD
	static int _0x50F457823CE6EB5F(int p0, int p1, int p2, int p3) { return invoke<int>(0x50F457823CE6EB5F, p0, p1, p2, p3); } // 0x50F457823CE6EB5F
	static void _0x5D5CAFF661DDF6FC(Any p0, Any* p1) { invoke<Void>(0x5D5CAFF661DDF6FC, p0, p1); } // 0x5D5CAFF661DDF6FC
	static BOOL _0xA9F9C2E0FDE11CBB(Any p0, Any p1, Any* p2) { return invoke<BOOL>(0xA9F9C2E0FDE11CBB, p0, p1, p2); } // 0xA9F9C2E0FDE11CBB
	static int _0xC098810437312FFF(int modData) { return invoke<int>(0xC098810437312FFF, modData); } // 0xC098810437312FFF
	static int _0xC17AD0E5752BECDA(Hash componentHash) { return invoke<int>(0xC17AD0E5752BECDA, componentHash); } // 0xC17AD0E5752BECDA
	static void _0xE1CA84EBF72E691D(Any p0, Any p1, Any* p2, Any* p3, Any* p4) { invoke<Void>(0xE1CA84EBF72E691D, p0, p1, p2, p3, p4); } // 0xE1CA84EBF72E691D
	static int _0xF3FBE2D50A6A8C28(int character, BOOL p1) { return invoke<int>(0xF3FBE2D50A6A8C28, character, p1); } // 0xF3FBE2D50A6A8C28
}

namespace FILES
{
	static int _0xD40AAC51E8E4C663(Hash propHash) { return invoke<int>(0xD40AAC51E8E4C663, propHash); } // 0xD40AAC51E8E4C663
	static void _0xD81B7F27BC773E66(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xD81B7F27BC773E66, p0, p1, p2, p3, p4); } // 0xD81B7F27BC773E66
}

namespace FIRE
{
	static void ADD_EXPLOSION(float x, float y, float z, int explosionType, float damageScale, BOOL isAudible, BOOL isInvisible, float cameraShake) { invoke<Void>(0xE3AD2BDBAEE269AC, x, y, z, explosionType, damageScale, isAudible, isInvisible, cameraShake); } // 0xE3AD2BDBAEE269AC
	static void ADD_EXPLOSION_WITH_USER_VFX(float x, float y, float z, int explosionType, Hash explosionFx, float damageScale, BOOL isAudible, BOOL isInvisible, float cameraShake) { invoke<Void>(0x36DD3FE58B5E5212, x, y, z, explosionType, explosionFx, damageScale, isAudible, isInvisible, cameraShake); } // 0x36DD3FE58B5E5212
	static void ADD_OWNED_EXPLOSION(Ped ped, float x, float y, float z, int explosionType, float damageScale, BOOL isAudible, BOOL isInvisible, float cameraShake) { invoke<Void>(0x172AA1B624FA1013, ped, x, y, z, explosionType, damageScale, isAudible, isInvisible, cameraShake); } // 0x172AA1B624FA1013
	static BOOL GET_CLOSEST_FIRE_POS(Vector3* outPosition, float x, float y, float z) { return invoke<BOOL>(0x352A9F6BCF90081F, outPosition, x, y, z); } // 0x352A9F6BCF90081F
	static int GET_NUMBER_OF_FIRES_IN_RANGE(float x, float y, float z, float radius) { return invoke<int>(0x50CAD495A460B305, x, y, z, radius); } // 0x50CAD495A460B305
	static Entity _GET_PED_INSIDE_EXPLOSION_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2, float radius) { return invoke<Entity>(0x14BA4BA137AF6CEC, explosionType, x1, y1, z1, x2, y2, z2, radius); } // 0x14BA4BA137AF6CEC
	static BOOL IS_ENTITY_ON_FIRE(Entity entity) { return invoke<BOOL>(0x28D3FED7190D3A0B, entity); } // 0x28D3FED7190D3A0B
	static BOOL IS_EXPLOSION_IN_ANGLED_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2, float angle) { return invoke<BOOL>(0xA079A6C51525DC4B, explosionType, x1, y1, z1, x2, y2, z2, angle); } // 0xA079A6C51525DC4B
	static BOOL IS_EXPLOSION_IN_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2) { return invoke<BOOL>(0x2E2EBA0EE7CED0E0, explosionType, x1, y1, z1, x2, y2, z2); } // 0x2E2EBA0EE7CED0E0
	static BOOL IS_EXPLOSION_IN_SPHERE(int explosionType, float x, float y, float z, float radius) { return invoke<BOOL>(0xAB0F816885B0E483, explosionType, x, y, z, radius); } // 0xAB0F816885B0E483
	static Any _0x6070104B699B2EF4(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return invoke<Any>(0x6070104B699B2EF4, p0, p1, p2, p3, p4, p5, p6); } // 0x6070104B699B2EF4
	static void REMOVE_SCRIPT_FIRE(int fireHandle) { invoke<Void>(0x7FF548385680673F, fireHandle); } // 0x7FF548385680673F
	static Any START_ENTITY_FIRE(Entity entity) { return invoke<Any>(0xF6A9D9708F6F23DF, entity); } // 0xF6A9D9708F6F23DF
	static int START_SCRIPT_FIRE(float X, float Y, float Z, int maxChildren, BOOL isGasFire) { return invoke<int>(0x6B83617E04503888, X, Y, Z, maxChildren, isGasFire); } // 0x6B83617E04503888
	static void STOP_ENTITY_FIRE(Entity entity) { invoke<Void>(0x7F0DD2EBBB651AFF, entity); } // 0x7F0DD2EBBB651AFF
	static void STOP_FIRE_IN_RANGE(float x, float y, float z, float radius) { invoke<Void>(0x56A8A219B8E829F, x, y, z, radius); } // 0x56A8A219B8E829F
}

namespace GRAPHICS
{
	static BOOL _ADD_CLAN_DECAL_TO_VEHICLE(Vehicle vehicle, Ped ped, int boneIndex, float x1, float x2, float x3, float y1, float y2, float y3, float z1, float z2, float z3, float scale, Any p13, int alpha) { return invoke<BOOL>(0x428BDCB9DA58DA53, vehicle, ped, boneIndex, x1, x2, x3, y1, y2, y3, z1, z2, z3, scale, p13, alpha); } // 0x428BDCB9DA58DA53
	static Object ADD_DECAL(int decalType, float posX, float posY, float posZ, float p4, float p5, float p6, float p7, float p8, float p9, float width, float height, float rCoef, float gCoef, float bCoef, float opacity, float timeout, BOOL p17, BOOL p18, BOOL p19) { return invoke<Object>(0xB302244A1839BDAD, decalType, posX, posY, posZ, p4, p5, p6, p7, p8, p9, width, height, rCoef, gCoef, bCoef, opacity, timeout, p17, p18, p19); } // 0xB302244A1839BDAD
	static void _ADD_DECAL_TO_MARKER(int decalType, char* textureDict, char* textureName) { invoke<Void>(0x8A35C742130C6080, decalType, textureDict, textureName); } // 0x8A35C742130C6080
	static Any ADD_ENTITY_ICON(Entity entity, char* icon) { return invoke<Any>(0x9CD43EEE12BF4DD0, entity, icon); } // 0x9CD43EEE12BF4DD0
	static Any ADD_PETROL_DECAL(float x, float y, float z, float groundLvl, float width, float transparency) { return invoke<Any>(0x4F5212C7AD880DF8, x, y, z, groundLvl, width, transparency); } // 0x4F5212C7AD880DF8
	static void ATTACH_TV_AUDIO_TO_ENTITY(Entity entity) { invoke<Void>(0x845BAD77CC770633, entity); } // 0x845BAD77CC770633
	static BOOL BEGIN_SCALEFORM_MOVIE_METHOD(int scaleform, char* functionName) { return invoke<BOOL>(0xF6E48914C7A8694E, scaleform, functionName); } // 0xF6E48914C7A8694E
	static BOOL _BEGIN_SCALEFORM_MOVIE_METHOD_HUD_COMPONENT(int hudComponent, char* functionName) { return invoke<BOOL>(0x98C494FD5BDFBFD5, hudComponent, functionName); } // 0x98C494FD5BDFBFD5
	static BOOL BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND(char* functionName) { return invoke<BOOL>(0xAB58C27C2E6123C6, functionName); } // 0xAB58C27C2E6123C6
	static BOOL BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER(char* functionName) { return invoke<BOOL>(0xB9449845F73F5E9C, functionName); } // 0xB9449845F73F5E9C
	static void BEGIN_TEXT_COMMAND_SCALEFORM_STRING(char* componentType) { invoke<Void>(0x80338406F3475E55, componentType); } // 0x80338406F3475E55
	static void _CALL_SCALEFORM_MOVIE_FUNCTION_FLOAT_PARAMS(int scaleform, char* functionName, float param1, float param2, float param3, float param4, float param5) { invoke<Void>(0xD0837058AE2E4BEE, scaleform, functionName, param1, param2, param3, param4, param5); } // 0xD0837058AE2E4BEE
	static void _CALL_SCALEFORM_MOVIE_FUNCTION_MIXED_PARAMS(int scaleform, char* functionName, float floatParam1, float floatParam2, float floatParam3, float floatParam4, float floatParam5, char* stringParam1, char* stringParam2, char* stringParam3, char* stringParam4, char* stringParam5) { invoke<Void>(0xEF662D8D57E290B1, scaleform, functionName, floatParam1, floatParam2, floatParam3, floatParam4, floatParam5, stringParam1, stringParam2, stringParam3, stringParam4, stringParam5); } // 0xEF662D8D57E290B1
	static void _CALL_SCALEFORM_MOVIE_FUNCTION_STRING_PARAMS(int scaleform, char* functionName, char* param1, char* param2, char* param3, char* param4, char* param5) { invoke<Void>(0x51BC1ED3CC44E8F7, scaleform, functionName, param1, param2, param3, param4, param5); } // 0x51BC1ED3CC44E8F7
	static void CALL_SCALEFORM_MOVIE_METHOD(int scaleform, char* method) { invoke<Void>(0xFBD96D87AC96D533, scaleform, method); } // 0xFBD96D87AC96D533
	static void CLEAR_DRAW_ORIGIN() { invoke<Void>(0xFF0B610F6BE0D7AF); } // 0xFF0B610F6BE0D7AF
	static void _CLEAR_EXTRA_TIMECYCLE_MODIFIER() { invoke<Void>(0x92CCC17A7A2285DA); } // 0x92CCC17A7A2285DA
	static void CLEAR_TIMECYCLE_MODIFIER() { invoke<Void>(0xF07E7745A236711); } // 0xF07E7745A236711
	static int CREATE_CHECKPOINT(int type, float posX1, float posY1, float posZ1, float posX2, float posY2, float posZ2, float radius, int red, int green, int blue, int alpha, int reserved) { return invoke<int>(0x134F0835AB6BFCB, type, posX1, posY1, posZ1, posX2, posY2, posZ2, radius, red, green, blue, alpha, reserved); } // 0x134F0835AB6BFCB
	static int CREATE_TRACKED_POINT() { return invoke<int>(0xE2C9439ED45DEA60); } // 0xE2C9439ED45DEA60
	static void DELETE_CHECKPOINT(int checkpoint) { invoke<Void>(0xF5ED37F54CD4D52E, checkpoint); } // 0xF5ED37F54CD4D52E
	static void DESTROY_TRACKED_POINT(int point) { invoke<Void>(0xB25DC90BAD56CA42, point); } // 0xB25DC90BAD56CA42
	static void DISABLE_VEHICLE_DISTANTLIGHTS(BOOL toggle) { invoke<Void>(0xC9F98AC1884E73A2, toggle); } // 0xC9F98AC1884E73A2
	static BOOL DOES_PARTICLE_FX_LOOPED_EXIST(int ptfxHandle) { return invoke<BOOL>(0x74AFEF0D2E1E409B, ptfxHandle); } // 0x74AFEF0D2E1E409B
	static BOOL _DOES_VEHICLE_HAVE_DECAL(Vehicle vehicle, Any p1) { return invoke<BOOL>(0x60D935D3981A275, vehicle, p1); } // 0x60D935D3981A275
	static void DRAW_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha) { invoke<Void>(0xD3A9971CADAC7252, x1, y1, z1, x2, y2, z2, red, green, blue, alpha); } // 0xD3A9971CADAC7252
	static void DRAW_DEBUG_BOX(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha) { invoke<Void>(0x83A2CA4F2E573BD, x1, y1, z1, x2, y2, z2, red, green, blue, alpha); } // 0x83A2CA4F2E573BD
	static void DRAW_DEBUG_CROSS(float x, float y, float z, float size, int red, int green, int blue, int alpha) { invoke<Void>(0x73B1189623049839, x, y, z, size, red, green, blue, alpha); } // 0x73B1189623049839
	static void DRAW_DEBUG_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha) { invoke<Void>(0x7FDFADE676AA3CB0, x1, y1, z1, x2, y2, z2, red, green, blue, alpha); } // 0x7FDFADE676AA3CB0
	static void DRAW_DEBUG_LINE_WITH_TWO_COLOURS(float x1, float y1, float z1, float x2, float y2, float z2, int r1, int g1, int b1, int r2, int g2, int b2, int alpha1, int alpha2) { invoke<Void>(0xD8B9A8AC5608FF94, x1, y1, z1, x2, y2, z2, r1, g1, b1, r2, g2, b2, alpha1, alpha2); } // 0xD8B9A8AC5608FF94
	static void DRAW_DEBUG_SPHERE(float x, float y, float z, float radius, int red, int green, int blue, int alpha) { invoke<Void>(0xAAD68E1AB39DA632, x, y, z, radius, red, green, blue, alpha); } // 0xAAD68E1AB39DA632
	static void DRAW_DEBUG_TEXT(char* text, float x, float y, float z, int red, int green, int blue, int alpha) { invoke<Void>(0x3903E216620488E8, text, x, y, z, red, green, blue, alpha); } // 0x3903E216620488E8
	static void DRAW_DEBUG_TEXT_2D(char* text, float x, float y, float z, int red, int green, int blue, int alpha) { invoke<Void>(0xA3BB2E9555C05A8F, text, x, y, z, red, green, blue, alpha); } // 0xA3BB2E9555C05A8F
	static void _DRAW_INTERACTIVE_SPRITE(char* textureDict, char* textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha) { invoke<Void>(0x2BC54A8188768488, textureDict, textureName, screenX, screenY, width, height, heading, red, green, blue, alpha); } // 0x2BC54A8188768488
	static void DRAW_LIGHT_WITH_RANGE(float posX, float posY, float posZ, int colorR, int colorG, int colorB, float range, float intensity) { invoke<Void>(0xF2A1B2771A01DBD4, posX, posY, posZ, colorR, colorG, colorB, range, intensity); } // 0xF2A1B2771A01DBD4
	static void _DRAW_LIGHT_WITH_RANGE_AND_SHADOW(float x, float y, float z, int r, int g, int b, float range, float intensity, float shadow) { invoke<Void>(0xF49E9A9716A04595, x, y, z, r, g, b, range, intensity, shadow); } // 0xF49E9A9716A04595
	static void DRAW_LINE(float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha) { invoke<Void>(0x6B7256074AE34680, x1, y1, z1, x2, y2, z2, red, green, blue, alpha); } // 0x6B7256074AE34680
	static void DRAW_MARKER(int type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, BOOL bobUpAndDown, BOOL faceCamera, int p19, BOOL rotate, char* textureDict, char* textureName, BOOL drawOnEnts) { invoke<Void>(0x28477EC23D892089, type, posX, posY, posZ, dirX, dirY, dirZ, rotX, rotY, rotZ, scaleX, scaleY, scaleZ, red, green, blue, alpha, bobUpAndDown, faceCamera, p19, rotate, textureDict, textureName, drawOnEnts); } // 0x28477EC23D892089
	static void DRAW_POLY(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, int red, int green, int blue, int alpha) { invoke<Void>(0xAC26716048436851, x1, y1, z1, x2, y2, z2, x3, y3, z3, red, green, blue, alpha); } // 0xAC26716048436851
	static void DRAW_RECT(float x, float y, float width, float height, int r, int g, int b, int a) { invoke<Void>(0x3A618A217E5154F0, x, y, width, height, r, g, b, a); } // 0x3A618A217E5154F0
	static void DRAW_SCALEFORM_MOVIE(int scaleformHandle, float x, float y, float width, float height, int red, int green, int blue, int alpha, int unk) { invoke<Void>(0x54972ADAF0294A93, scaleformHandle, x, y, width, height, red, green, blue, alpha, unk); } // 0x54972ADAF0294A93
	static void DRAW_SCALEFORM_MOVIE_FULLSCREEN(int scaleform, int red, int green, int blue, int alpha, int unk) { invoke<Void>(0xDF606929C105BE1, scaleform, red, green, blue, alpha, unk); } // 0xDF606929C105BE1
	static void DRAW_SCALEFORM_MOVIE_FULLSCREEN_MASKED(int scaleform1, int scaleform2, int red, int green, int blue, int alpha) { invoke<Void>(0xCF537FDE4FBD4CE5, scaleform1, scaleform2, red, green, blue, alpha); } // 0xCF537FDE4FBD4CE5
	static void DRAW_SCALEFORM_MOVIE_3D(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float sharpness, float p9, float scaleX, float scaleY, float scaleZ, Any p13) { invoke<Void>(0x87D51D72255D4E78, scaleform, posX, posY, posZ, rotX, rotY, rotZ, p7, sharpness, p9, scaleX, scaleY, scaleZ, p13); } // 0x87D51D72255D4E78
	static void _DRAW_SCALEFORM_MOVIE_3D_NON_ADDITIVE(int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float p8, float p9, float scaleX, float scaleY, float scaleZ, Any p13) { invoke<Void>(0x1CE592FDC749D6F5, scaleform, posX, posY, posZ, rotX, rotY, rotZ, p7, p8, p9, scaleX, scaleY, scaleZ, p13); } // 0x1CE592FDC749D6F5
	static BOOL _DRAW_SHOWROOM(char* p0, Ped ped, int p2, float posX, float posY, float posZ) { return invoke<BOOL>(0x98C4FE6EC34154CA, p0, ped, p2, posX, posY, posZ); } // 0x98C4FE6EC34154CA
	static void DRAW_SPOT_LIGHT(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float hardness, float radius, float falloff) { invoke<Void>(0xD0F64B265C8C8B33, posX, posY, posZ, dirX, dirY, dirZ, colorR, colorG, colorB, distance, brightness, hardness, radius, falloff); } // 0xD0F64B265C8C8B33
	static void _DRAW_SPOT_LIGHT_WITH_SHADOW(float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float roundness, float radius, float falloff, int shadowId) { invoke<Void>(0x5BCA583A583194DB, posX, posY, posZ, dirX, dirY, dirZ, colorR, colorG, colorB, distance, brightness, roundness, radius, falloff, shadowId); } // 0x5BCA583A583194DB
	static void DRAW_SPRITE(char* textureDict, char* textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha) { invoke<Void>(0xE7FFAE5EBF23D890, textureDict, textureName, screenX, screenY, width, height, heading, red, green, blue, alpha); } // 0xE7FFAE5EBF23D890
	static void DRAW_TV_CHANNEL(float xPos, float yPos, float xScale, float yScale, float rotation, int red, int green, int blue, int alpha) { invoke<Void>(0xFDDC2B4ED3C69DF0, xPos, yPos, xScale, yScale, rotation, red, green, blue, alpha); } // 0xFDDC2B4ED3C69DF0
	static void ENABLE_ALIEN_BLOOD_VFX(BOOL Toggle) { invoke<Void>(0x9DCE1F0F78260875, Toggle); } // 0x9DCE1F0F78260875
	static void ENABLE_CLOWN_BLOOD_VFX(BOOL toggle) { invoke<Void>(0xD821490579791273, toggle); } // 0xD821490579791273
	static void ENABLE_MOVIE_SUBTITLES(BOOL toggle) { invoke<Void>(0x873FA65C778AD970, toggle); } // 0x873FA65C778AD970
	static void END_SCALEFORM_MOVIE_METHOD() { invoke<Void>(0xC6796A8FFA375E53); } // 0xC6796A8FFA375E53
	static int _END_SCALEFORM_MOVIE_METHOD_RETURN() { return invoke<int>(0xC50AA39A577AF886); } // 0xC50AA39A577AF886
	static void END_TEXT_COMMAND_SCALEFORM_STRING() { invoke<Void>(0x362E2D3FE93A9959); } // 0x362E2D3FE93A9959
	static void _END_TEXT_COMMAND_SCALEFORM_STRING_2() { invoke<Void>(0xAE4E8157D9ECF087); } // 0xAE4E8157D9ECF087
	static void _ENTITY_DESCRIPTION_TEXT(Entity entity) { invoke<Void>(0xDEADC0DEDEADC0DE, entity); } // 0xDEADC0DEDEADC0DE
	static void FADE_DECALS_IN_RANGE(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xD77EDADB0420E6E0, p0, p1, p2, p3, p4); } // 0xD77EDADB0420E6E0
	static void _GET_ACTIVE_SCREEN_RESOLUTION(int* x, int* y) { invoke<Void>(0x873C9F3104101DD3, x, y); } // 0x873C9F3104101DD3
	static float _GET_ASPECT_RATIO(BOOL b) { return invoke<float>(0xF1307EF624A80D87, b); } // 0xF1307EF624A80D87
	static float GET_DECAL_WASH_LEVEL(int decal) { return invoke<float>(0x323F647679A09103, decal); } // 0x323F647679A09103
	static int _GET_EXTRA_TIMECYCLE_MODIFIER_INDEX() { return invoke<int>(0xBB0527EC6341496D); } // 0xBB0527EC6341496D
	static BOOL GET_IS_HIDEF() { return invoke<BOOL>(0x84ED31191CC5D2C9); } // 0x84ED31191CC5D2C9
	static BOOL GET_IS_WIDESCREEN() { return invoke<BOOL>(0x30CF4BDA4FCB1905); } // 0x30CF4BDA4FCB1905
	static int GET_MAXIMUM_NUMBER_OF_PHOTOS() { return invoke<int>(0x34D23450F028B0BF); } // 0x34D23450F028B0BF
	static int _GET_MAXIMUM_NUMBER_OF_PHOTOS_2() { return invoke<int>(0xDC54A7AF8B3A14EF); } // 0xDC54A7AF8B3A14EF
	static int _GET_NUMBER_OF_PHOTOS() { return invoke<int>(0x473151EBC762C6DA); } // 0x473151EBC762C6DA
	static float GET_SAFE_ZONE_SIZE() { return invoke<float>(0xBAF107B6BB2C97F0); } // 0xBAF107B6BB2C97F0
	static BOOL _GET_SCALEFORM_MOVIE_FUNCTION_RETURN_BOOL(int method_return) { return invoke<BOOL>(0x768FF8961BA904D6, method_return); } // 0x768FF8961BA904D6
	static int _GET_SCALEFORM_MOVIE_FUNCTION_RETURN_INT(int method_return) { return invoke<int>(0x2DE7EFA66B906036, method_return); } // 0x2DE7EFA66B906036
	static char* _GET_SCALEFORM_MOVIE_FUNCTION_RETURN_STRING(int method_return) { return invoke<char*>(0xE1E258829A885245, method_return); } // 0xE1E258829A885245
	static BOOL GET_SCREEN_COORD_FROM_WORLD_COORD(float worldX, float worldY, float worldZ, float* screenX, float* screenY) { return invoke<BOOL>(0x34E82F05DF2974F5, worldX, worldY, worldZ, screenX, screenY); } // 0x34E82F05DF2974F5
	static BOOL _GET_SCREEN_EFFECT_IS_ACTIVE(char* effectName) { return invoke<BOOL>(0x36AD3E690DA5ACEB, effectName); } // 0x36AD3E690DA5ACEB
	static void GET_SCREEN_RESOLUTION(int* x, int* y) { invoke<Void>(0x888D57E407E63624, x, y); } // 0x888D57E407E63624
	static void _GET_SCRIPT_GFX_POSITION(float x, float y, float* calculatedX, float* calculatedY) { invoke<Void>(0x6DD8F5AA635EB4B2, x, y, calculatedX, calculatedY); } // 0x6DD8F5AA635EB4B2
	static Vector3 GET_TEXTURE_RESOLUTION(char* textureDict, char* textureName) { return invoke<Vector3>(0x35736EE65BD00C11, textureDict, textureName); } // 0x35736EE65BD00C11
	static int GET_TIMECYCLE_MODIFIER_INDEX() { return invoke<int>(0xFDF3D97C674AFB66); } // 0xFDF3D97C674AFB66
	static int GET_TV_CHANNEL() { return invoke<int>(0xFC1E275A90D39995); } // 0xFC1E275A90D39995
	static float GET_TV_VOLUME() { return invoke<float>(0x2170813D3DD8661B); } // 0x2170813D3DD8661B
	static BOOL _HAS_HUD_SCALEFORM_LOADED(int hudComponent) { return invoke<BOOL>(0xDF6E5987D2B4D140, hudComponent); } // 0xDF6E5987D2B4D140
	static BOOL _HAS_NAMED_SCALEFORM_MOVIE_LOADED(char* scaleformName) { return invoke<BOOL>(0xC1C5D756FB5F337, scaleformName); } // 0xC1C5D756FB5F337
	static BOOL HAS_SCALEFORM_CONTAINER_MOVIE_LOADED_INTO_PARENT(int scaleformHandle) { return invoke<BOOL>(0x8217150E1217EBFD, scaleformHandle); } // 0x8217150E1217EBFD
	static BOOL HAS_SCALEFORM_MOVIE_LOADED(int scaleformHandle) { return invoke<BOOL>(0x85F01B8D5B90570E, scaleformHandle); } // 0x85F01B8D5B90570E
	static BOOL HAS_STREAMED_TEXTURE_DICT_LOADED(char* textureDict) { return invoke<BOOL>(0x145F696AAAAD2E4, textureDict); } // 0x145F696AAAAD2E4
	static BOOL IS_DECAL_ALIVE(Object decal) { return invoke<BOOL>(0xC694D74949CAFD0C, decal); } // 0xC694D74949CAFD0C
	static BOOL _IS_NIGHTVISION_ACTIVE() { return invoke<BOOL>(0x2202A3F42C8E5F79); } // 0x2202A3F42C8E5F79
	static float IS_PARTICLE_FX_DELAYED_BLINK() { return invoke<float>(0x5CCABFFCA31DDE33); } // 0x5CCABFFCA31DDE33
	static BOOL _IS_SEETHROUGH_ACTIVE() { return invoke<BOOL>(0x44B80ABAB9D80BD3); } // 0x44B80ABAB9D80BD3
	static BOOL IS_TRACKED_POINT_VISIBLE(int point) { return invoke<BOOL>(0xC45CCDAAC9221CA8, point); } // 0xC45CCDAAC9221CA8
	static int LOAD_MOVIE_MESH_SET(char* movieMeshSetName) { return invoke<int>(0xB66064452270E8F1, movieMeshSetName); } // 0xB66064452270E8F1
	static BOOL _LOAD_TV_CHANNEL(Hash tvChannel) { return invoke<BOOL>(0xAD973CA1E077B60, tvChannel); } // 0xAD973CA1E077B60
	static void _LOAD_TV_CHANNEL_SEQUENCE(int TV_Channel, char* VideoSequence, BOOL Restart) { invoke<Void>(0xF7B38B8305F1FE8B, TV_Channel, VideoSequence, Restart); } // 0xF7B38B8305F1FE8B
	static void MOVE_VEHICLE_DECALS(Any p0, Any p1) { invoke<Void>(0x84C8D7C2D30D3280, p0, p1); } // 0x84C8D7C2D30D3280
	static void _0x0218BA067D249DEA() { invoke<Void>(0x218BA067D249DEA); } // 0x218BA067D249DEA
	static void _0x02369D5C8A51FDCF(BOOL p0) { invoke<Void>(0x2369D5C8A51FDCF, p0); } // 0x2369D5C8A51FDCF
	static Any _0x02AC28F3A01FA04A(float p0) { return invoke<Any>(0x2AC28F3A01FA04A, p0); } // 0x2AC28F3A01FA04A
	static void _0x03300B57FCAC6DDB(BOOL p0) { invoke<Void>(0x3300B57FCAC6DDB, p0); } // 0x3300B57FCAC6DDB
	static void _0x03FC694AE06C5A20() { invoke<Void>(0x3FC694AE06C5A20); } // 0x3FC694AE06C5A20
	static void _0x06F761EA47C1D3ED(BOOL p0) { invoke<Void>(0x6F761EA47C1D3ED, p0); } // 0x6F761EA47C1D3ED
	static void _0x0A123435A26C36CD() { invoke<Void>(0xA123435A26C36CD); } // 0xA123435A26C36CD
	static void _0x0A46AF8A78DC5E0A() { invoke<Void>(0xA46AF8A78DC5E0A); } // 0xA46AF8A78DC5E0A
	static void _0x0AE73D8DF3A762B2(BOOL p0) { invoke<Void>(0xAE73D8DF3A762B2, p0); } // 0xAE73D8DF3A762B2
	static int _0x0C0C4E81E1AC60A0() { return invoke<int>(0xC0C4E81E1AC60A0); } // 0xC0C4E81E1AC60A0
	static void _0x0C8FAC83902A62DF(Any p0) { invoke<Void>(0xC8FAC83902A62DF, p0); } // 0xC8FAC83902A62DF
	static int _0x0D6CA79EEEBD8CA3() { return invoke<int>(0xD6CA79EEEBD8CA3); } // 0xD6CA79EEEBD8CA3
	static void _0x0E4299C549F0D1F1(BOOL p0) { invoke<Void>(0xE4299C549F0D1F1, p0); } // 0xE4299C549F0D1F1
	static void _0x1072F115DAB0717E(BOOL p0, BOOL p1) { invoke<Void>(0x1072F115DAB0717E, p0, p1); } // 0x1072F115DAB0717E
	static void _0x1086127B3A63505E(Any p0, Any p1, Any p2) { invoke<Void>(0x1086127B3A63505E, p0, p1, p2); } // 0x1086127B3A63505E
	static void _0x108BE26959A9D9BB(BOOL p0) { invoke<Void>(0x108BE26959A9D9BB, p0); } // 0x108BE26959A9D9BB
	static void _0x12995F2E53FFA601(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11) { invoke<Void>(0x12995F2E53FFA601, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); } // 0x12995F2E53FFA601
	static void _0x14FC5833464340A8() { invoke<Void>(0x14FC5833464340A8); } // 0x14FC5833464340A8
	static void _0x15E33297C3E8DC60(Any p0) { invoke<Void>(0x15E33297C3E8DC60, p0); } // 0x15E33297C3E8DC60
	static void _0x1600FD8CF72EBC12(float p0) { invoke<Void>(0x1600FD8CF72EBC12, p0); } // 0x1600FD8CF72EBC12
	static void _0x1612C45F9E3E0D44() { invoke<Void>(0x1612C45F9E3E0D44); } // 0x1612C45F9E3E0D44
	static void _0x1636D7FC127B10D2(Any p0) { invoke<Void>(0x1636D7FC127B10D2, p0); } // 0x1636D7FC127B10D2
	static int _0x1670F8D05056F257(Any p0) { return invoke<int>(0x1670F8D05056F257, p0); } // 0x1670F8D05056F257
	static void _0x19E50EB6E33E1D28(Any p0) { invoke<Void>(0x19E50EB6E33E1D28, p0); } // 0x19E50EB6E33E1D28
	static void _0x1A8E2C8B9CF4549C(Any* p0, Any* p1) { invoke<Void>(0x1A8E2C8B9CF4549C, p0, p1); } // 0x1A8E2C8B9CF4549C
	static void _0x1BBC135A4D25EDDE(BOOL p0) { invoke<Void>(0x1BBC135A4D25EDDE, p0); } // 0x1BBC135A4D25EDDE
	static void _0x1C4FC5752BCD8E48(float x, float y, float z, float p3, float rotation, float p5, float width, float height, float p8, float scale, float glowIntensity, float normalHeight, float heightDiff) { invoke<Void>(0x1C4FC5752BCD8E48, x, y, z, p3, rotation, p5, width, height, p8, scale, glowIntensity, normalHeight, heightDiff); } // 0x1C4FC5752BCD8E48
	static void _0x1CBA05AE7BD7EE05(float p0) { invoke<Void>(0x1CBA05AE7BD7EE05, p0); } // 0x1CBA05AE7BD7EE05
	static BOOL _0x1DD2139A9A20DCE8() { return invoke<BOOL>(0x1DD2139A9A20DCE8); } // 0x1DD2139A9A20DCE8
	static void _0x2201C576FACAEBE8(Any p0, char* p1, Any p2) { invoke<Void>(0x2201C576FACAEBE8, p0, p1, p2); } // 0x2201C576FACAEBE8
	static void _0x22A249A53034450A(BOOL p0) { invoke<Void>(0x22A249A53034450A, p0); } // 0x22A249A53034450A
	static void _0x23BA6B0C2AD7B0D3(BOOL toggle) { invoke<Void>(0x23BA6B0C2AD7B0D3, toggle); } // 0x23BA6B0C2AD7B0D3
	static void _0x2485D34E50A22E84(float p0, float p1, float p2) { invoke<Void>(0x2485D34E50A22E84, p0, p1, p2); } // 0x2485D34E50A22E84
	static void _0x259BA6D4E6F808F1(Any p0) { invoke<Void>(0x259BA6D4E6F808F1, p0); } // 0x259BA6D4E6F808F1
	static void _0x25FC3E33A31AD0C9(BOOL p0) { invoke<Void>(0x25FC3E33A31AD0C9, p0); } // 0x25FC3E33A31AD0C9
	static void _0x27CB772218215325() { invoke<Void>(0x27CB772218215325); } // 0x27CB772218215325
	static void _0x27CFB1B1E078CB2D() { invoke<Void>(0x27CFB1B1E078CB2D); } // 0x27CFB1B1E078CB2D
	static void _0x27E32866E9A5C416(float p0) { invoke<Void>(0x27E32866E9A5C416, p0); } // 0x27E32866E9A5C416
	static BOOL _0x27FEB5254759CDE3(char* textureDict, BOOL p1) { return invoke<BOOL>(0x27FEB5254759CDE3, textureDict, p1); } // 0x27FEB5254759CDE3
	static void _0x29280002282F1928(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14, Any p15, Any p16, Any p17, Any p18, Any p19, Any p20, Any p21, Any p22, Any p23) { invoke<Void>(0x29280002282F1928, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23); } // 0x29280002282F1928
	static void _0x2A2A52824DB96700(Any* p0) { invoke<Void>(0x2A2A52824DB96700, p0); } // 0x2A2A52824DB96700
	static BOOL _0x2A893980E96B659A(BOOL p0) { return invoke<BOOL>(0x2A893980E96B659A, p0); } // 0x2A893980E96B659A
	static void _0x2B40A97646381508(Any p0) { invoke<Void>(0x2B40A97646381508, p0); } // 0x2B40A97646381508
	static Any _0x2C42340F916C5930(Any p0) { return invoke<Any>(0x2C42340F916C5930, p0); } // 0x2C42340F916C5930
	static BOOL _0x2F09F7976C512404(float xCoord, float yCoord, float zCoord, float p3) { return invoke<BOOL>(0x2F09F7976C512404, xCoord, yCoord, zCoord, p3); } // 0x2F09F7976C512404
	static void _0x302C91AB2D477F7E() { invoke<Void>(0x302C91AB2D477F7E); } // 0x302C91AB2D477F7E
	static void _0x312342E1A4874F3F(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, BOOL p8) { invoke<Void>(0x312342E1A4874F3F, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0x312342E1A4874F3F
	static void _0x32F34FF7F617643B(Any p0, Any p1) { invoke<Void>(0x32F34FF7F617643B, p0, p1); } // 0x32F34FF7F617643B
	static void _0x346EF3ECAAAB149E() { invoke<Void>(0x346EF3ECAAAB149E); } // 0x346EF3ECAAAB149E
	static Any _0x35FB78DC42B7BD21() { return invoke<Any>(0x35FB78DC42B7BD21); } // 0x35FB78DC42B7BD21
	static void _0x3669F1B198DCAA4F() { invoke<Void>(0x3669F1B198DCAA4F); } // 0x3669F1B198DCAA4F
	static void _0x36F6626459D91457(float p0) { invoke<Void>(0x36F6626459D91457, p0); } // 0x36F6626459D91457
	static Any _0x393BD2275CEB7793() { return invoke<Any>(0x393BD2275CEB7793); } // 0x393BD2275CEB7793
	static BOOL _0x3DEC726C25A11BAC(int p0) { return invoke<BOOL>(0x3DEC726C25A11BAC, p0); } // 0x3DEC726C25A11BAC
	static void _0x44621483FF966526(Any p0, Any p1) { invoke<Void>(0x44621483FF966526, p0, p1); } // 0x44621483FF966526
	static Any _0x459FD2C8D0AB78BC() { return invoke<Any>(0x459FD2C8D0AB78BC); } // 0x459FD2C8D0AB78BC
	static void _0x46D1A61A21F566FC(float p0) { invoke<Void>(0x46D1A61A21F566FC, p0); } // 0x46D1A61A21F566FC
	static BOOL _0x4862437A486F91B0(char* p0, Any* p1, Any* p2, BOOL p3) { return invoke<BOOL>(0x4862437A486F91B0, p0, p1, p2, p3); } // 0x4862437A486F91B0
	static void _0x4AF92ACD3141D96C() { invoke<Void>(0x4AF92ACD3141D96C); } // 0x4AF92ACD3141D96C
	static void _0x4B5CFC83122DF602() { invoke<Void>(0x4B5CFC83122DF602); } // 0x4B5CFC83122DF602
	static void _0x54E22EA2C1956A8D(float p0) { invoke<Void>(0x54E22EA2C1956A8D, p0); } // 0x54E22EA2C1956A8D
	static int _0x5B0316762AFD4A64() { return invoke<int>(0x5B0316762AFD4A64); } // 0x5B0316762AFD4A64
	static void _0x5CE62918F8D703C7(int lowR, int lowG, int lowB, int lowAlpha, int R, int G, int B, int Alpha, int highR, int highG, int highB, int highAlpha) { invoke<Void>(0x5CE62918F8D703C7, lowR, lowG, lowB, lowAlpha, R, G, B, Alpha, highR, highG, highB, highAlpha); } // 0x5CE62918F8D703C7
	static void _0x5DBF05DB5926D089(Any p0) { invoke<Void>(0x5DBF05DB5926D089, p0); } // 0x5DBF05DB5926D089
	static void _0x5DEBD9C4DC995692() { invoke<Void>(0x5DEBD9C4DC995692); } // 0x5DEBD9C4DC995692
	static BOOL _0x5E657EF1099EDD65(int p0) { return invoke<BOOL>(0x5E657EF1099EDD65, p0); } // 0x5E657EF1099EDD65
	static void _0x5E9DAF5A20F15908(float p0) { invoke<Void>(0x5E9DAF5A20F15908, p0); } // 0x5E9DAF5A20F15908
	static void _0x5F0F3F56635809EF(float p0) { invoke<Void>(0x5F0F3F56635809EF, p0); } // 0x5F0F3F56635809EF
	static void _0x615D3925E87A3B26(int checkpoint) { invoke<Void>(0x615D3925E87A3B26, checkpoint); } // 0x615D3925E87A3B26
	static void _0x61F95E5BB3E0A8C6(Any p0) { invoke<Void>(0x61F95E5BB3E0A8C6, p0); } // 0x61F95E5BB3E0A8C6
	static void _0x649C97D52332341A(Any p0) { invoke<Void>(0x649C97D52332341A, p0); } // 0x649C97D52332341A
	static Any _0x65E7E78842E74CDB(Any p0) { return invoke<Any>(0x65E7E78842E74CDB, p0); } // 0x65E7E78842E74CDB
	static void _0x6A12D88881435DCA() { invoke<Void>(0x6A12D88881435DCA); } // 0x6A12D88881435DCA
	static void _0x6A51F78772175A51(Any p0) { invoke<Void>(0x6A51F78772175A51, p0); } // 0x6A51F78772175A51
	static void _0x6D955F6A9E0295B1(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0x6D955F6A9E0295B1, p0, p1, p2, p3, p4, p5, p6); } // 0x6D955F6A9E0295B1
	static void _0x6DDBF9DFFC4AC080(BOOL p0) { invoke<Void>(0x6DDBF9DFFC4AC080, p0); } // 0x6DDBF9DFFC4AC080
	static void _0x736D7AA1B750856B(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14, Any p15, Any p16, Any p17, Any p18, Any p19, Any p20, Any p21, Any p22, Any p23, Any p24, Any p25, Any p26, Any p27, Any p28, Any p29, Any p30, Any p31) { invoke<Void>(0x736D7AA1B750856B, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31); } // 0x736D7AA1B750856B
	static void _0x74C180030FDE4B69(BOOL p0) { invoke<Void>(0x74C180030FDE4B69, p0); } // 0x74C180030FDE4B69
	static BOOL _0x759650634F07B6B4(int p0) { return invoke<BOOL>(0x759650634F07B6B4, p0); } // 0x759650634F07B6B4
	static void _0x799017F9E3B10112(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { invoke<Void>(0x799017F9E3B10112, p0, p1, p2, p3, p4, p5, p6, p7); } // 0x799017F9E3B10112
	static void _0x7A42B2E236E71415() { invoke<Void>(0x7A42B2E236E71415); } // 0x7A42B2E236E71415
	static BOOL _0x7AC24EAB6D74118D(BOOL p0) { return invoke<BOOL>(0x7AC24EAB6D74118D, p0); } // 0x7AC24EAB6D74118D
	static Any _0x7B226C785A52A0A9() { return invoke<Any>(0x7B226C785A52A0A9); } // 0x7B226C785A52A0A9
	static BOOL _0x7FA5D82B8F58EC06() { return invoke<BOOL>(0x7FA5D82B8F58EC06); } // 0x7FA5D82B8F58EC06
	static void _0x814AF7DCAACC597B(Any p0) { invoke<Void>(0x814AF7DCAACC597B, p0); } // 0x814AF7DCAACC597B
	static Any _0x82ACC484FFA3B05F(Any p0) { return invoke<Any>(0x82ACC484FFA3B05F, p0); } // 0x82ACC484FFA3B05F
	static void _0x851CD923176EBA7C() { invoke<Void>(0x851CD923176EBA7C); } // 0x851CD923176EBA7C
	static void _0x8CDE909A0370BB3A(BOOL p0) { invoke<Void>(0x8CDE909A0370BB3A, p0); } // 0x8CDE909A0370BB3A
	static int _0x90A78ECAA4E78453() { return invoke<int>(0x90A78ECAA4E78453); } // 0x90A78ECAA4E78453
	static void _0x949F397A288B28B3(float p0) { invoke<Void>(0x949F397A288B28B3, p0); } // 0x949F397A288B28B3
	static Any _0x95EB5E34F821BABE(Any p0, Any p1, Any p2) { return invoke<Any>(0x95EB5E34F821BABE, p0, p1, p2); } // 0x95EB5E34F821BABE
	static void _0x9641588DAB93B4B5(Any p0) { invoke<Void>(0x9641588DAB93B4B5, p0); } // 0x9641588DAB93B4B5
	static void _0x967278682CB6967A(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x967278682CB6967A, p0, p1, p2, p3); } // 0x967278682CB6967A
	static void _0x98EDF76A7271E4F2() { invoke<Void>(0x98EDF76A7271E4F2); } // 0x98EDF76A7271E4F2
	static void _0x99AC7F0D8B9C893D(float p0) { invoke<Void>(0x99AC7F0D8B9C893D, p0); } // 0x99AC7F0D8B9C893D
	static void _0x9B079E5221D984D3(BOOL p0) { invoke<Void>(0x9B079E5221D984D3, p0); } // 0x9B079E5221D984D3
	static Any _0x9B6E70C5CEEF4EEB(Any p0) { return invoke<Any>(0x9B6E70C5CEEF4EEB, p0); } // 0x9B6E70C5CEEF4EEB
	static void _0x9CFDD90B2B844BF7(float p0, float p1, float p2, float p3, float p4) { invoke<Void>(0x9CFDD90B2B844BF7, p0, p1, p2, p3, p4); } // 0x9CFDD90B2B844BF7
	static void _0x9D75795B9DC6EBBF(Any p0) { invoke<Void>(0x9D75795B9DC6EBBF, p0); } // 0x9D75795B9DC6EBBF
	static void _0xA356990E161C9E65(BOOL toggle) { invoke<Void>(0xA356990E161C9E65, toggle); } // 0xA356990E161C9E65
	static void _0xA44FF770DFBC5DAE() { invoke<Void>(0xA44FF770DFBC5DAE); } // 0xA44FF770DFBC5DAE
	static int _0xA4664972A9B8F8BA(Any p0) { return invoke<int>(0xA4664972A9B8F8BA, p0); } // 0xA4664972A9B8F8BA
	static void _0xA46B73FAA3460AE1(BOOL p0) { invoke<Void>(0xA46B73FAA3460AE1, p0); } // 0xA46B73FAA3460AE1
	static Any _0xA4819F5E23E2FFAD() { return invoke<Any>(0xA4819F5E23E2FFAD); } // 0xA4819F5E23E2FFAD
	static void _0xA51C4B86B71652AE(BOOL p0) { invoke<Void>(0xA51C4B86B71652AE, p0); } // 0xA51C4B86B71652AE
	static BOOL _0xA67C35C56EB1BD9D() { return invoke<BOOL>(0xA67C35C56EB1BD9D); } // 0xA67C35C56EB1BD9D
	static void _0xA78DE25577300BA1(Any p0) { invoke<Void>(0xA78DE25577300BA1, p0); } // 0xA78DE25577300BA1
	static void _0xAE51BC858F32BA66(Any p0, float p1, float p2, float p3, float p4) { invoke<Void>(0xAE51BC858F32BA66, p0, p1, p2, p3, p4); } // 0xAE51BC858F32BA66
	static void _0xB11D94BC55F41932(char* p0) { invoke<Void>(0xB11D94BC55F41932, p0); } // 0xB11D94BC55F41932
	static void _0xB1BB03742917A5D6(int type, float xPos, float yPos, float zPos, float p4, int red, int green, int blue, int alpha) { invoke<Void>(0xB1BB03742917A5D6, type, xPos, yPos, zPos, p4, red, green, blue, alpha); } // 0xB1BB03742917A5D6
	static Any _0xB2EBE8CBC58B90E9() { return invoke<Any>(0xB2EBE8CBC58B90E9); } // 0xB2EBE8CBC58B90E9
	static void _0xB3C641F3630BF6DA(float p0) { invoke<Void>(0xB3C641F3630BF6DA, p0); } // 0xB3C641F3630BF6DA
	static void _0xB569F41F3E7E83A4(Any p0) { invoke<Void>(0xB569F41F3E7E83A4, p0); } // 0xB569F41F3E7E83A4
	static void _0xB7ED70C49521A61D(int decalType) { invoke<Void>(0xB7ED70C49521A61D, decalType); } // 0xB7ED70C49521A61D
	static void _0xBA0127DA25FD54C9(Any p0, Any p1) { invoke<Void>(0xBA0127DA25FD54C9, p0, p1); } // 0xBA0127DA25FD54C9
	static void _0xBA3D194057C79A7B(Any p0) { invoke<Void>(0xBA3D194057C79A7B, p0); } // 0xBA3D194057C79A7B
	static void _0xBA3D65906822BED5(BOOL p0, BOOL p1, float p2, float p3, float p4, float p5) { invoke<Void>(0xBA3D65906822BED5, p0, p1, p2, p3, p4, p5); } // 0xBA3D65906822BED5
	static void _0xBB90E12CAC1DAB25(float p0) { invoke<Void>(0xBB90E12CAC1DAB25, p0); } // 0xBB90E12CAC1DAB25
	static void _0xBBF327DED94E4DEB(char* p0) { invoke<Void>(0xBBF327DED94E4DEB, p0); } // 0xBBF327DED94E4DEB
	static Any _0xBCEDB009461DA156() { return invoke<Any>(0xBCEDB009461DA156); } // 0xBCEDB009461DA156
	static void _0xBDEB86F4D5809204(float p0) { invoke<Void>(0xBDEB86F4D5809204, p0); } // 0xBDEB86F4D5809204
	static Any _0xBE197EAA669238F4(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0xBE197EAA669238F4, p0, p1, p2, p3); } // 0xBE197EAA669238F4
	static void _0xBEB3D46BB7F043C0(Any p0) { invoke<Void>(0xBEB3D46BB7F043C0, p0); } // 0xBEB3D46BB7F043C0
	static void _0xBF59707B3E5ED531(char* p0) { invoke<Void>(0xBF59707B3E5ED531, p0); } // 0xBF59707B3E5ED531
	static void _0xC0416B061F2B7E5E(BOOL p0) { invoke<Void>(0xC0416B061F2B7E5E, p0); } // 0xC0416B061F2B7E5E
	static void _0xC35A6D07C93802B2() { invoke<Void>(0xC35A6D07C93802B2); } // 0xC35A6D07C93802B2
	static void _0xC5C8F970D4EDFF71(Any p0) { invoke<Void>(0xC5C8F970D4EDFF71, p0); } // 0xC5C8F970D4EDFF71
	static void _0xC9B18B4619F48F7B(float p0) { invoke<Void>(0xC9B18B4619F48F7B, p0); } // 0xC9B18B4619F48F7B
	static void _0xCA465D9CC0D231BA(Any p0) { invoke<Void>(0xCA465D9CC0D231BA, p0); } // 0xCA465D9CC0D231BA
	static void _0xCA4AE345A153D573(BOOL p0) { invoke<Void>(0xCA4AE345A153D573, p0); } // 0xCA4AE345A153D573
	static int _0xCB82A0BF0E3E3265(int p0) { return invoke<int>(0xCB82A0BF0E3E3265, p0); } // 0xCB82A0BF0E3E3265
	static void _0xD1C55B110E4DF534(Any p0) { invoke<Void>(0xD1C55B110E4DF534, p0); } // 0xD1C55B110E4DF534
	static BOOL _0xD1C7CB175E012964(int scaleformHandle) { return invoke<BOOL>(0xD1C7CB175E012964, scaleformHandle); } // 0xD1C7CB175E012964
	static void _0xD2209BE128B5418C(char* graphicsName) { invoke<Void>(0xD2209BE128B5418C, graphicsName); } // 0xD2209BE128B5418C
	static void _0xD2300034310557E4(Vehicle vehicle, Any p1) { invoke<Void>(0xD2300034310557E4, vehicle, p1); } // 0xD2300034310557E4
	static void _0xD2936CAB8B58FCBD(Any p0, BOOL p1, float p2, float p3, float p4, float p5, BOOL p6, float p7) { invoke<Void>(0xD2936CAB8B58FCBD, p0, p1, p2, p3, p4, p5, p6, p7); } // 0xD2936CAB8B58FCBD
	static void _0xD39D13C9FEBF0511(BOOL p0) { invoke<Void>(0xD39D13C9FEBF0511, p0); } // 0xD39D13C9FEBF0511
	static BOOL _0xD3A10FC7FD8D98CD() { return invoke<BOOL>(0xD3A10FC7FD8D98CD); } // 0xD3A10FC7FD8D98CD
	static void _0xD7021272EB0A451E(char* p0) { invoke<Void>(0xD7021272EB0A451E, p0); } // 0xD7021272EB0A451E
	static void _0xD7D0B00177485411(Any p0, float p1) { invoke<Void>(0xD7D0B00177485411, p0, p1); } // 0xD7D0B00177485411
	static void _0xD801CC02177FA3F1() { invoke<Void>(0xD801CC02177FA3F1); } // 0xD801CC02177FA3F1
	static Any _0xD80A80346A45D761(Any p0) { return invoke<Any>(0xD80A80346A45D761, p0); } // 0xD80A80346A45D761
	static void _0xD9454B5752C857DC() { invoke<Void>(0xD9454B5752C857DC); } // 0xD9454B5752C857DC
	static void _0xDBAA5EC848BA2D46(Any p0, Any p1) { invoke<Void>(0xDBAA5EC848BA2D46, p0, p1); } // 0xDBAA5EC848BA2D46
	static void _0xDC459CFA0CCE245B(BOOL p0) { invoke<Void>(0xDC459CFA0CCE245B, p0); } // 0xDC459CFA0CCE245B
	static void _0xDE81239437E8C5A8() { invoke<Void>(0xDE81239437E8C5A8); } // 0xDE81239437E8C5A8
	static void _0xE1C8709406F2C41C() { invoke<Void>(0xE1C8709406F2C41C); } // 0xE1C8709406F2C41C
	static void _0xE2892E7E55D7073A(float p0) { invoke<Void>(0xE2892E7E55D7073A, p0); } // 0xE2892E7E55D7073A
	static Any _0xE35B38A27E8E7179(Any p0) { return invoke<Any>(0xE35B38A27E8E7179, p0); } // 0xE35B38A27E8E7179
	static void _0xE3E2C1B4C59DBC77(int unk) { invoke<Void>(0xE3E2C1B4C59DBC77, unk); } // 0xE3E2C1B4C59DBC77
	static Any _0xE59343E9E96529E7() { return invoke<Any>(0xE59343E9E96529E7); } // 0xE59343E9E96529E7
	static void _0xE63D7C6EECECB66B(BOOL p0) { invoke<Void>(0xE63D7C6EECECB66B, p0); } // 0xE63D7C6EECECB66B
	static void _0xE6A9F00D4240B519(Any p0, Any p1) { invoke<Void>(0xE6A9F00D4240B519, p0, p1); } // 0xE6A9F00D4240B519
	static Any _0xE791DF1F73ED2C8B(Any p0) { return invoke<Any>(0xE791DF1F73ED2C8B, p0); } // 0xE791DF1F73ED2C8B
	static void _0xE82728F0DE75D13A(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14, Any p15, Any p16, Any p17, Any p18, Any p19, Any p20, Any p21, Any p22, Any p23, Any p24) { invoke<Void>(0xE82728F0DE75D13A, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24); } // 0xE82728F0DE75D13A
	static BOOL _0xEB3DAC2C86001E5E() { return invoke<BOOL>(0xEB3DAC2C86001E5E); } // 0xEB3DAC2C86001E5E
	static void _0xEC52C631A1831C03(int p0) { invoke<Void>(0xEC52C631A1831C03, p0); } // 0xEC52C631A1831C03
	static Any _0xEC72C258667BE5EA(Any p0) { return invoke<Any>(0xEC72C258667BE5EA, p0); } // 0xEC72C258667BE5EA
	static void _0xEF398BEEE4EF45F9(BOOL p0) { invoke<Void>(0xEF398BEEE4EF45F9, p0); } // 0xEF398BEEE4EF45F9
	static void _0xEFABC7722293DA7C() { invoke<Void>(0xEFABC7722293DA7C); } // 0xEFABC7722293DA7C
	static void _0xEFB55E7C25D3B3BE() { invoke<Void>(0xEFB55E7C25D3B3BE); } // 0xEFB55E7C25D3B3BE
	static void _0xEFD97FF47B745B8D(Any p0) { invoke<Void>(0xEFD97FF47B745B8D, p0); } // 0xEFD97FF47B745B8D
	static BOOL _0xF1CEA8A4198D8E9A(char* p0) { return invoke<BOOL>(0xF1CEA8A4198D8E9A, p0); } // 0xF1CEA8A4198D8E9A
	static void _0xF44A5456AC3F4F97(Any p0) { invoke<Void>(0xF44A5456AC3F4F97, p0); } // 0xF44A5456AC3F4F97
	static void _0xF51D36185993515D(int checkpoint, float posX, float posY, float posZ, float unkX, float unkY, float unkZ) { invoke<Void>(0xF51D36185993515D, checkpoint, posX, posY, posZ, unkX, unkY, unkZ); } // 0xF51D36185993515D
	static int _0xF5BED327CEA362B1(BOOL p0) { return invoke<int>(0xF5BED327CEA362B1, p0); } // 0xF5BED327CEA362B1
	static void _0xF78B803082D4386F(float p0) { invoke<Void>(0xF78B803082D4386F, p0); } // 0xF78B803082D4386F
	static int _0xFE26117A5841B2FF(Vehicle vehicle, Any p1) { return invoke<int>(0xFE26117A5841B2FF, vehicle, p1); } // 0xFE26117A5841B2FF
	static void _0xFEBFBFDFB66039DE(Any p0) { invoke<Void>(0xFEBFBFDFB66039DE, p0); } // 0xFEBFBFDFB66039DE
	static void _0xFF5992E1C9E65D05(Any p0) { invoke<Void>(0xFF5992E1C9E65D05, p0); } // 0xFF5992E1C9E65D05
	static void POP_TIMECYCLE_MODIFIER() { invoke<Void>(0x3C8938D7D872211E); } // 0x3C8938D7D872211E
	static void _PUSH_SCALEFORM_MOVIE_METHOD_PARAMETER_BUTTON_NAME(char* button) { invoke<Void>(0xE83A3E3557A56640, button); } // 0xE83A3E3557A56640
	static void _PUSH_SCALEFORM_MOVIE_METHOD_PARAMETER_STRING(char* value) { invoke<Void>(0xBA7148484BD90365, value); } // 0xBA7148484BD90365
	static void _PUSH_SCALEFORM_MOVIE_METHOD_PARAMETER_STRING_2(char* value) { invoke<Void>(0x77FE3402004CD1B0, value); } // 0x77FE3402004CD1B0
	static void PUSH_TIMECYCLE_MODIFIER() { invoke<Void>(0x58F735290861E6B4); } // 0x58F735290861E6B4
	static void RELEASE_MOVIE_MESH_SET(int movieMeshSet) { invoke<Void>(0xEB119AA014E89183, movieMeshSet); } // 0xEB119AA014E89183
	static void REMOVE_DECAL(Object decal) { invoke<Void>(0xED3F346429CCD659, decal); } // 0xED3F346429CCD659
	static void REMOVE_DECALS_FROM_OBJECT(Object obj) { invoke<Void>(0xCCF71CBDDF5B6CB9, obj); } // 0xCCF71CBDDF5B6CB9
	static void REMOVE_DECALS_FROM_OBJECT_FACING(Object obj, float x, float y, float z) { invoke<Void>(0xA6F6F70FDC6D144C, obj, x, y, z); } // 0xA6F6F70FDC6D144C
	static void REMOVE_DECALS_FROM_VEHICLE(Vehicle vehicle) { invoke<Void>(0xE91F1B65F2B48D57, vehicle); } // 0xE91F1B65F2B48D57
	static void REMOVE_DECALS_IN_RANGE(float x, float y, float z, float range) { invoke<Void>(0x5D6B2D4830A67C62, x, y, z, range); } // 0x5D6B2D4830A67C62
	static void REMOVE_PARTICLE_FX(int ptfxHandle, BOOL p1) { invoke<Void>(0xC401503DFE8D53CF, ptfxHandle, p1); } // 0xC401503DFE8D53CF
	static void REMOVE_PARTICLE_FX_FROM_ENTITY(Entity entity) { invoke<Void>(0xB8FEAEEBCC127425, entity); } // 0xB8FEAEEBCC127425
	static void REMOVE_PARTICLE_FX_IN_RANGE(float X, float Y, float Z, float radius) { invoke<Void>(0xDD19FA1C6D657305, X, Y, Z, radius); } // 0xDD19FA1C6D657305
	static void _REQUEST_HUD_SCALEFORM(int hudComponent) { invoke<Void>(0x9304881D6F6537EA, hudComponent); } // 0x9304881D6F6537EA
	static int REQUEST_SCALEFORM_MOVIE(char* scaleformName) { return invoke<int>(0x11FE353CF9733E6F, scaleformName); } // 0x11FE353CF9733E6F
	static int REQUEST_SCALEFORM_MOVIE_INSTANCE(char* scaleformName) { return invoke<int>(0xC514489CFB8AF806, scaleformName); } // 0xC514489CFB8AF806
	static int _REQUEST_SCALEFORM_MOVIE_INTERACTIVE(char* scaleformName) { return invoke<int>(0xBD06C611BB9048C2, scaleformName); } // 0xBD06C611BB9048C2
	static void REQUEST_STREAMED_TEXTURE_DICT(char* textureDict, BOOL p1) { invoke<Void>(0xDFA2EF8E04127DD5, textureDict, p1); } // 0xDFA2EF8E04127DD5
	static void _RESET_EXTRA_TIMECYCLE_MODIFIER_STRENGTH() { invoke<Void>(0x2BF72AD5B41AA739); } // 0x2BF72AD5B41AA739
	static void _RESET_PARTICLE_FX_ASSET_OLD_TO_NEW(char* name) { invoke<Void>(0x89C8553DD3274AAE, name); } // 0x89C8553DD3274AAE
	static void RESET_SCRIPT_GFX_ALIGN() { invoke<Void>(0xE3A3DB414A373DAB); } // 0xE3A3DB414A373DAB
	static int _RETURN_TWO(Any p0) { return invoke<int>(0x40AFB081F8ADD4EE, p0); } // 0x40AFB081F8ADD4EE
	static void SCALEFORM_MOVIE_METHOD_ADD_PARAM_BOOL(BOOL value) { invoke<Void>(0xC58424BA936EB458, value); } // 0xC58424BA936EB458
	static void SCALEFORM_MOVIE_METHOD_ADD_PARAM_FLOAT(float value) { invoke<Void>(0xD69736AAE04DB51A, value); } // 0xD69736AAE04DB51A
	static void SCALEFORM_MOVIE_METHOD_ADD_PARAM_INT(int value) { invoke<Void>(0xC3D0841A0CC546A6, value); } // 0xC3D0841A0CC546A6
	static void SET_ARTIFICIAL_LIGHTS_STATE(BOOL state) { invoke<Void>(0x1268615ACE24D504, state); } // 0x1268615ACE24D504
	static void SET_CHECKPOINT_CYLINDER_HEIGHT(int checkpoint, float nearHeight, float farHeight, float radius) { invoke<Void>(0x2707AAE9D9297D89, checkpoint, nearHeight, farHeight, radius); } // 0x2707AAE9D9297D89
	static void _SET_CHECKPOINT_ICON_RGBA(int checkpoint, int red, int green, int blue, int alpha) { invoke<Void>(0xB9EA40907C680580, checkpoint, red, green, blue, alpha); } // 0xB9EA40907C680580
	static void SET_CHECKPOINT_RGBA(int checkpoint, int red, int green, int blue, int alpha) { invoke<Void>(0x7167371E8AD747F7, checkpoint, red, green, blue, alpha); } // 0x7167371E8AD747F7
	static void _SET_CHECKPOINT_SCALE(int checkpoint, float p0) { invoke<Void>(0x4B5B4DA5D79F1943, checkpoint, p0); } // 0x4B5B4DA5D79F1943
	static void SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE(BOOL enabled) { invoke<Void>(0x175B6BFC15CDD0C5, enabled); } // 0x175B6BFC15CDD0C5
	static void SET_DRAW_ORIGIN(float x, float y, float z, Any p3) { invoke<Void>(0xAA0008F3BBB8F416, x, y, z, p3); } // 0xAA0008F3BBB8F416
	static void SET_ENTITY_ICON_COLOR(Entity entity, int red, int green, int blue, int alpha) { invoke<Void>(0x1D5F595CCAE2E238, entity, red, green, blue, alpha); } // 0x1D5F595CCAE2E238
	static void SET_ENTITY_ICON_VISIBILITY(Entity entity, BOOL toggle) { invoke<Void>(0xE0E8BEECCA96BA31, entity, toggle); } // 0xE0E8BEECCA96BA31
	static void _SET_EXTRA_TIMECYCLE_MODIFIER(char* modifierName) { invoke<Void>(0x5096FD9CCB49056D, modifierName); } // 0x5096FD9CCB49056D
	static void _SET_EXTRA_TIMECYCLE_MODIFIER_STRENGTH(float strength) { invoke<Void>(0x2C328AF17210F009, strength); } // 0x2C328AF17210F009
	static void _SET_FAR_SHADOWS_SUPPRESSED(BOOL toggle) { invoke<Void>(0x80ECBC0C856D3B0B, toggle); } // 0x80ECBC0C856D3B0B
	static void SET_FLASH(float p0, float p1, float fadeIn, float duration, float fadeOut) { invoke<Void>(0xAB84296FED9CFC6, p0, p1, fadeIn, duration, fadeOut); } // 0xAB84296FED9CFC6
	static void _SET_FORCE_PED_FOOTSTEPS_TRACKS(BOOL toggle) { invoke<Void>(0xAEEDAD1420C65CC0, toggle); } // 0xAEEDAD1420C65CC0
	static void _SET_FORCE_VEHICLE_TRAILS(BOOL toggle) { invoke<Void>(0x4CC7F0FEA5283FE0, toggle); } // 0x4CC7F0FEA5283FE0
	static void _SET_FROZEN_RENDERING_DISABLED(BOOL enabled) { invoke<Void>(0xDFC252D8A3E15AB7, enabled); } // 0xDFC252D8A3E15AB7
	static void SET_NIGHTVISION(BOOL toggle) { invoke<Void>(0x18F621F7A5B1F85D, toggle); } // 0x18F621F7A5B1F85D
	static void SET_NOISEOVERIDE(BOOL toggle) { invoke<Void>(0xE787BF1C5CF823C9, toggle); } // 0xE787BF1C5CF823C9
	static void SET_NOISINESSOVERIDE(float value) { invoke<Void>(0xCB6A7C3BB17A0C67, value); } // 0xCB6A7C3BB17A0C67
	static void _SET_PARTICLE_FX_ASSET_OLD_TO_NEW(char* oldAsset, char* newAsset) { invoke<Void>(0xEA1E2D93F6F75ED9, oldAsset, newAsset); } // 0xEA1E2D93F6F75ED9
	static void SET_PARTICLE_FX_BLOOD_SCALE(BOOL p0) { invoke<Void>(0x5F6DF3D92271E8A1, p0); } // 0x5F6DF3D92271E8A1
	static void SET_PARTICLE_FX_CAM_INSIDE_NONPLAYER_VEHICLE(Any p0, BOOL p1) { invoke<Void>(0xACEE6F360FC1F6B6, p0, p1); } // 0xACEE6F360FC1F6B6
	static void SET_PARTICLE_FX_CAM_INSIDE_VEHICLE(BOOL p0) { invoke<Void>(0xEEC4047028426510, p0); } // 0xEEC4047028426510
	static void SET_PARTICLE_FX_LOOPED_ALPHA(int ptfxHandle, float alpha) { invoke<Void>(0x726845132380142E, ptfxHandle, alpha); } // 0x726845132380142E
	static void SET_PARTICLE_FX_LOOPED_COLOUR(int ptfxHandle, float r, float g, float b, BOOL p4) { invoke<Void>(0x7F8F65877F88783B, ptfxHandle, r, g, b, p4); } // 0x7F8F65877F88783B
	static void SET_PARTICLE_FX_LOOPED_EVOLUTION(int ptfxHandle, char* propertyName, float amount, BOOL Id) { invoke<Void>(0x5F0C4B5B1C393BE2, ptfxHandle, propertyName, amount, Id); } // 0x5F0C4B5B1C393BE2
	static void SET_PARTICLE_FX_LOOPED_OFFSETS(int ptfxHandle, float x, float y, float z, float rotX, float rotY, float rotZ) { invoke<Void>(0xF7DDEBEC43483C43, ptfxHandle, x, y, z, rotX, rotY, rotZ); } // 0xF7DDEBEC43483C43
	static void _SET_PARTICLE_FX_LOOPED_RANGE(int ptfxHandle, float range) { invoke<Void>(0xDCB194B85EF7B541, ptfxHandle, range); } // 0xDCB194B85EF7B541
	static void SET_PARTICLE_FX_LOOPED_SCALE(int ptfxHandle, float scale) { invoke<Void>(0xB44250AAA456492D, ptfxHandle, scale); } // 0xB44250AAA456492D
	static void SET_PARTICLE_FX_NON_LOOPED_ALPHA(float alpha) { invoke<Void>(0x77168D722C58B2FC, alpha); } // 0x77168D722C58B2FC
	static void SET_PARTICLE_FX_NON_LOOPED_COLOUR(float r, float g, float b) { invoke<Void>(0x26143A59EF48B262, r, g, b); } // 0x26143A59EF48B262
	static void SET_PARTICLE_FX_SHOOTOUT_BOAT(Any p0) { invoke<Void>(0x96EF97DAEB89BEF5, p0); } // 0x96EF97DAEB89BEF5
	static void SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED(int* scaleformHandle) { invoke<Void>(0x1D132D614DD86811, scaleformHandle); } // 0x1D132D614DD86811
	static void SET_SCALEFORM_MOVIE_TO_USE_SYSTEM_TIME(int scaleform, BOOL toggle) { invoke<Void>(0x6D8EB211944DCE08, scaleform, toggle); } // 0x6D8EB211944DCE08
	static void SET_SCRIPT_GFX_ALIGN(int horizontalAlign, int verticalAlign) { invoke<Void>(0xB8A850F20A067EB6, horizontalAlign, verticalAlign); } // 0xB8A850F20A067EB6
	static void SET_SCRIPT_GFX_ALIGN_PARAMS(float x, float y, float w, float h) { invoke<Void>(0xF5A2C681787E579D, x, y, w, h); } // 0xF5A2C681787E579D
	static void SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU(BOOL flag) { invoke<Void>(0xC6372ECD45D73BCD, flag); } // 0xC6372ECD45D73BCD
	static void SET_SCRIPT_GFX_DRAW_ORDER(int order) { invoke<Void>(0x61BB1D9B3A95D802, order); } // 0x61BB1D9B3A95D802
	static void SET_SEETHROUGH(BOOL toggle) { invoke<Void>(0x7E08924259E08CE0, toggle); } // 0x7E08924259E08CE0
	static void SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED(char* textureDict) { invoke<Void>(0xBE2CACCF5A8AA805, textureDict); } // 0xBE2CACCF5A8AA805
	static void SET_TIMECYCLE_MODIFIER(char* modifierName) { invoke<Void>(0x2C933ABF17A1DF41, modifierName); } // 0x2C933ABF17A1DF41
	static void SET_TIMECYCLE_MODIFIER_STRENGTH(float strength) { invoke<Void>(0x82E7FFCD5B2326B3, strength); } // 0x82E7FFCD5B2326B3
	static void SET_TRACKED_POINT_INFO(int point, float x, float y, float z, float radius) { invoke<Void>(0x164ECBB3CF750CB0, point, x, y, z, radius); } // 0x164ECBB3CF750CB0
	static void SET_TRANSITION_TIMECYCLE_MODIFIER(char* modifierName, float transition) { invoke<Void>(0x3BCF567485E1971C, modifierName, transition); } // 0x3BCF567485E1971C
	static void SET_TV_AUDIO_FRONTEND(BOOL toggle) { invoke<Void>(0x113D2C5DC57E1774, toggle); } // 0x113D2C5DC57E1774
	static void SET_TV_CHANNEL(int channel) { invoke<Void>(0xBAABBB23EB6E484E, channel); } // 0xBAABBB23EB6E484E
	static void SET_TV_VOLUME(float volume) { invoke<Void>(0x2982BF73F66E9DDC, volume); } // 0x2982BF73F66E9DDC
	static int START_PARTICLE_FX_LOOPED_AT_COORD(char* effectName, float x, float y, float z, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis, BOOL p11) { return invoke<int>(0xE184F4F0DC5910E7, effectName, x, y, z, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis, p11); } // 0xE184F4F0DC5910E7
	static int START_PARTICLE_FX_LOOPED_ON_ENTITY(char* effectName, Entity entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return invoke<int>(0x1AE42C1660FD6517, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis); } // 0x1AE42C1660FD6517
	static int _START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(char* effectName, Entity entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return invoke<int>(0xC6EB449E33977F0B, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, boneIndex, scale, xAxis, yAxis, zAxis); } // 0xC6EB449E33977F0B
	static int _START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE_2(char* effectName, Entity entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return invoke<int>(0xDDE23F30CC5A0F03, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, boneIndex, scale, xAxis, yAxis, zAxis); } // 0xDDE23F30CC5A0F03
	static int _START_PARTICLE_FX_LOOPED_ON_ENTITY_2(char* effectName, Entity entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return invoke<int>(0x6F60E89A7B64EE1D, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis); } // 0x6F60E89A7B64EE1D
	static int START_PARTICLE_FX_LOOPED_ON_PED_BONE(char* effectName, Ped ped, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return invoke<int>(0xF28DA9F38CD1787C, effectName, ped, xOffset, yOffset, zOffset, xRot, yRot, zRot, boneIndex, scale, xAxis, yAxis, zAxis); } // 0xF28DA9F38CD1787C
	static int START_PARTICLE_FX_NON_LOOPED_AT_COORD(char* effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return invoke<int>(0x25129531F77B9ED3, effectName, xPos, yPos, zPos, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis); } // 0x25129531F77B9ED3
	static BOOL _START_PARTICLE_FX_NON_LOOPED_AT_COORD_2(char* effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return invoke<BOOL>(0xF56B8137DF10135D, effectName, xPos, yPos, zPos, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis); } // 0xF56B8137DF10135D
	static BOOL START_PARTICLE_FX_NON_LOOPED_ON_ENTITY(char* effectName, Entity entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, BOOL axisX, BOOL axisY, BOOL axisZ) { return invoke<BOOL>(0xD53A3B8DA0809D2, effectName, entity, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, scale, axisX, axisY, axisZ); } // 0xD53A3B8DA0809D2
	static BOOL _START_PARTICLE_FX_NON_LOOPED_ON_ENTITY_2(char* effectName, Entity entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, BOOL axisX, BOOL axisY, BOOL axisZ) { return invoke<BOOL>(0xC95EB1DB6E92113D, effectName, entity, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, scale, axisX, axisY, axisZ); } // 0xC95EB1DB6E92113D
	static BOOL START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(char* effectName, Ped ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, BOOL axisX, BOOL axisY, BOOL axisZ) { return invoke<BOOL>(0xE7E72961BA18619, effectName, ped, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, boneIndex, scale, axisX, axisY, axisZ); } // 0xE7E72961BA18619
	static BOOL _START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE_2(char* effectName, Ped ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, BOOL axisX, BOOL axisY, BOOL axisZ) { return invoke<BOOL>(0xA41B6A43642AC2CF, effectName, ped, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, boneIndex, scale, axisX, axisY, axisZ); } // 0xA41B6A43642AC2CF
	static void _START_SCREEN_EFFECT(char* effectName, int duration, BOOL looped) { invoke<Void>(0x2206BF9A37B7F724, effectName, duration, looped); } // 0x2206BF9A37B7F724
	static void _STOP_ALL_SCREEN_EFFECTS() { invoke<Void>(0xB4EDDC19532BFB85); } // 0xB4EDDC19532BFB85
	static void STOP_PARTICLE_FX_LOOPED(int ptfxHandle, BOOL p1) { invoke<Void>(0x8F75998877616996, ptfxHandle, p1); } // 0x8F75998877616996
	static void _STOP_SCREEN_EFFECT(char* effectName) { invoke<Void>(0x68E835A1D0DC0E3, effectName); } // 0x68E835A1D0DC0E3
	static BOOL _TRANSITION_FROM_BLURRED(float transitionTime) { return invoke<BOOL>(0xEFACC8AEF94430D5, transitionTime); } // 0xEFACC8AEF94430D5
	static BOOL _TRANSITION_TO_BLURRED(float transitionTime) { return invoke<BOOL>(0xA328A24AAA6B7FDC, transitionTime); } // 0xA328A24AAA6B7FDC
	static void _USE_PARTICLE_FX_ASSET_NEXT_CALL(char* name) { invoke<Void>(0x6C38AF3693A69A91, name); } // 0x6C38AF3693A69A91
	static void WASH_DECALS_FROM_VEHICLE(Vehicle vehicle, float p1) { invoke<Void>(0x5B712761429DBC14, vehicle, p1); } // 0x5B712761429DBC14
	static void WASH_DECALS_IN_RANGE(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x9C30613D50A6ADEF, p0, p1, p2, p3, p4); } // 0x9C30613D50A6ADEF
}

namespace HUD
{
	static void _ABORT_TEXT_CHAT() { invoke<Void>(0x1AC8F4AD40E22127); } // 0x1AC8F4AD40E22127
	static void ACTIVATE_FRONTEND_MENU(Hash menuhash, BOOL Toggle_Pause, int component) { invoke<Void>(0xEF01D36B9C9D0C7B, menuhash, Toggle_Pause, component); } // 0xEF01D36B9C9D0C7B
	static Blip _ADD_BLIP_FOR_AREA(float x, float y, float z, float width, float height) { return invoke<Blip>(0xCE5D0E5E315DB238, x, y, z, width, height); } // 0xCE5D0E5E315DB238
	static Blip ADD_BLIP_FOR_COORD(float x, float y, float z) { return invoke<Blip>(0x5A039BB0BCA604B6, x, y, z); } // 0x5A039BB0BCA604B6
	static Blip ADD_BLIP_FOR_ENTITY(Entity entity) { return invoke<Blip>(0x5CDE92C702A8FCE7, entity); } // 0x5CDE92C702A8FCE7
	static Blip ADD_BLIP_FOR_PICKUP(Pickup pickup) { return invoke<Blip>(0xBE339365C863BD36, pickup); } // 0xBE339365C863BD36
	static Blip ADD_BLIP_FOR_RADIUS(float posX, float posY, float posZ, float radius) { return invoke<Blip>(0x46818D79B1F7499A, posX, posY, posZ, radius); } // 0x46818D79B1F7499A
	static void ADD_NEXT_MESSAGE_TO_PREVIOUS_BRIEFS(BOOL p0) { invoke<Void>(0x60296AF4BA14ABC5, p0); } // 0x60296AF4BA14ABC5
	static void _ADD_TEXT_COMPONENT_APP_TITLE(char* p0, int p1) { invoke<Void>(0x761B77454205A61D, p0, p1); } // 0x761B77454205A61D
	static void ADD_TEXT_COMPONENT_FLOAT(float value, int decimalPlaces) { invoke<Void>(0xE7DCB5B874BCD96E, value, decimalPlaces); } // 0xE7DCB5B874BCD96E
	static void ADD_TEXT_COMPONENT_FORMATTED_INTEGER(int value, BOOL commaSeparated) { invoke<Void>(0xE4C749FF9DE9CC4, value, commaSeparated); } // 0xE4C749FF9DE9CC4
	static void ADD_TEXT_COMPONENT_INTEGER(int value) { invoke<Void>(0x3B504CF259931BC, value); } // 0x3B504CF259931BC
	static void _ADD_TEXT_COMPONENT_SCALEFORM(char* p0) { invoke<Void>(0x5F68520888E69014, p0); } // 0x5F68520888E69014
	static void ADD_TEXT_COMPONENT_SUBSTRING_BLIP_NAME(Blip blip) { invoke<Void>(0x80EAD8E2E1D5D52E, blip); } // 0x80EAD8E2E1D5D52E
	static void ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(char* text) { invoke<Void>(0x6C188BE134E074AA, text); } // 0x6C188BE134E074AA
	static void ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL(char* labelName) { invoke<Void>(0xC63CD5D2920ACBE7, labelName); } // 0xC63CD5D2920ACBE7
	static void ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL_HASH_KEY(Hash gxtEntryHash) { invoke<Void>(0x17299B63C7683A2B, gxtEntryHash); } // 0x17299B63C7683A2B
	static void ADD_TEXT_COMPONENT_SUBSTRING_TIME(int timestamp, int flags) { invoke<Void>(0x1115F16B8AB9E8BF, timestamp, flags); } // 0x1115F16B8AB9E8BF
	static void ADD_TEXT_COMPONENT_SUBSTRING_WEBSITE(char* website) { invoke<Void>(0x94CF4AC034C9C986, website); } // 0x94CF4AC034C9C986
	static BOOL ADD_TREVOR_RANDOM_MODIFIER(int gamerTagId) { return invoke<BOOL>(0x595B5178E412E199, gamerTagId); } // 0x595B5178E412E199
	static void _BEGIN_TEXT_COMMAND_BUSY_STRING(char* string) { invoke<Void>(0xABA17D7CE615ADBF, string); } // 0xABA17D7CE615ADBF
	static void BEGIN_TEXT_COMMAND_CLEAR_PRINT(char* text) { invoke<Void>(0xE124FA80A759019C, text); } // 0xE124FA80A759019C
	static void BEGIN_TEXT_COMMAND_DISPLAY_HELP(char* inputType) { invoke<Void>(0x8509B634FBE7DA11, inputType); } // 0x8509B634FBE7DA11
	static void BEGIN_TEXT_COMMAND_DISPLAY_TEXT(char* text) { invoke<Void>(0x25FBB336DF1804CB, text); } // 0x25FBB336DF1804CB
	static void BEGIN_TEXT_COMMAND_IS_MESSAGE_DISPLAYED(char* text) { invoke<Void>(0x853648FD1063A213, text); } // 0x853648FD1063A213
	static void BEGIN_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED(char* labelName) { invoke<Void>(0xA24DA3A41B718F5, labelName); } // 0xA24DA3A41B718F5
	static void _BEGIN_TEXT_COMMAND_LINE_COUNT(char* entry) { invoke<Void>(0x521FB041D93DD0E4, entry); } // 0x521FB041D93DD0E4
	static void _BEGIN_TEXT_COMMAND_OBJECTIVE(char* p0) { invoke<Void>(0x23D69E0465570028, p0); } // 0x23D69E0465570028
	static void BEGIN_TEXT_COMMAND_PRINT(char* GxtEntry) { invoke<Void>(0xB87A37EEB7FAA67D, GxtEntry); } // 0xB87A37EEB7FAA67D
	static void BEGIN_TEXT_COMMAND_SET_BLIP_NAME(char* textLabel) { invoke<Void>(0xF9113A30DE5C6670, textLabel); } // 0xF9113A30DE5C6670
	static void _BEGIN_TEXT_COMMAND_TIMER(char* p0) { invoke<Void>(0x8F9EE5687F8EECCD, p0); } // 0x8F9EE5687F8EECCD
	static void _BEGIN_TEXT_COMMAND_WIDTH(char* text) { invoke<Void>(0x54CE8AC98E120CAB, text); } // 0x54CE8AC98E120CAB
	static void _BLOCK_WEAPON_WHEEL_THIS_FRAME() { invoke<Void>(0xAFC4AF510774B47); } // 0xAFC4AF510774B47
	static void _CENTER_PLAYER_ON_RADAR_THIS_FRAME() { invoke<Void>(0x6D14BFDC33B34F55); } // 0x6D14BFDC33B34F55
	static void CLEAR_ADDITIONAL_TEXT(int p0, BOOL p1) { invoke<Void>(0x2A179DF17CCF04CD, p0, p1); } // 0x2A179DF17CCF04CD
	static void CLEAR_ALL_HELP_MESSAGES() { invoke<Void>(0x6178F68A87A4D3A0); } // 0x6178F68A87A4D3A0
	static void CLEAR_BRIEF() { invoke<Void>(0x9D292F73ADBD9313); } // 0x9D292F73ADBD9313
	static void CLEAR_FLOATING_HELP(Any p0, BOOL p1) { invoke<Void>(0x50085246ABD3FEFA, p0, p1); } // 0x50085246ABD3FEFA
	static void CLEAR_GPS_FLAGS() { invoke<Void>(0x21986729D6A3A830); } // 0x21986729D6A3A830
	static void CLEAR_GPS_PLAYER_WAYPOINT() { invoke<Void>(0xFF4FB7C8CDFA3DA7); } // 0xFF4FB7C8CDFA3DA7
	static void CLEAR_GPS_RACE_TRACK() { invoke<Void>(0x7AA5B4CE533C858B); } // 0x7AA5B4CE533C858B
	static void CLEAR_HELP(BOOL toggle) { invoke<Void>(0x8DFCED7A656F8802, toggle); } // 0x8DFCED7A656F8802
	static void _CLEAR_NOTIFICATIONS_POS(float pos) { invoke<Void>(0x55598D21339CB998, pos); } // 0x55598D21339CB998
	static void CLEAR_PED_IN_PAUSE_MENU() { invoke<Void>(0x5E62BE5DC58E9E06); } // 0x5E62BE5DC58E9E06
	static void CLEAR_PRINTS() { invoke<Void>(0xCC33FA791322B9D9); } // 0xCC33FA791322B9D9
	static void CLEAR_REMINDER_MESSAGE() { invoke<Void>(0xB57D8DD645CFA2CF); } // 0xB57D8DD645CFA2CF
	static void CLEAR_SMALL_PRINTS() { invoke<Void>(0x2CEA2839313C09AC); } // 0x2CEA2839313C09AC
	static void CLEAR_THIS_PRINT(char* p0) { invoke<Void>(0xCF708001E1E536DD, p0); } // 0xCF708001E1E536DD
	static int _CREATE_MP_GAMER_TAG(Ped ped, char* username, BOOL pointedClanTag, BOOL isRockstarClan, char* clanTag, Any p5) { return invoke<int>(0xBFEFE3321A3F5015, ped, username, pointedClanTag, isRockstarClan, clanTag, p5); } // 0xBFEFE3321A3F5015
	static Blip DISABLE_BLIP_NAME_FOR_VAR() { return invoke<Blip>(0x5C90988E7C8E1AF4); } // 0x5C90988E7C8E1AF4
	static void DISABLE_FRONTEND_THIS_FRAME() { invoke<Void>(0x6D3465A73092F0E6); } // 0x6D3465A73092F0E6
	static void _DISABLE_RADAR_THIS_FRAME() { invoke<Void>(0x5FBAE526203990C9); } // 0x5FBAE526203990C9
	static void DISPLAY_AMMO_THIS_FRAME(BOOL display) { invoke<Void>(0xA5E78BA2B1331C55, display); } // 0xA5E78BA2B1331C55
	static void DISPLAY_AREA_NAME(BOOL toggle) { invoke<Void>(0x276B6CE369C33678, toggle); } // 0x276B6CE369C33678
	static void DISPLAY_CASH(BOOL toggle) { invoke<Void>(0x96DEC8D5430208B7, toggle); } // 0x96DEC8D5430208B7
	static void DISPLAY_HELP_TEXT_THIS_FRAME(char* message, BOOL p1) { invoke<Void>(0x960C9FF8F616E41C, message, p1); } // 0x960C9FF8F616E41C
	static void DISPLAY_HUD(BOOL toggle) { invoke<Void>(0xA6294919E56FF02A, toggle); } // 0xA6294919E56FF02A
	static void _DISPLAY_JOB_REPORT() { invoke<Void>(0x523A590C1A3CC0D3); } // 0x523A590C1A3CC0D3
	static Any DISPLAY_RADAR(BOOL Toggle) { return invoke<Any>(0xA0EBB943C300E693, Toggle); } // 0xA0EBB943C300E693
	static void DISPLAY_SNIPER_SCOPE_THIS_FRAME() { invoke<Void>(0x73115226F4814E62); } // 0x73115226F4814E62
	static BOOL DOES_BLIP_EXIST(Blip blip) { return invoke<BOOL>(0xA6DB27D19ECBB7DA, blip); } // 0xA6DB27D19ECBB7DA
	static BOOL DOES_PED_HAVE_AI_BLIP(Ped ped) { return invoke<BOOL>(0x15B8ECF844EE67ED, ped); } // 0x15B8ECF844EE67ED
	static BOOL DOES_TEXT_BLOCK_EXIST(char* gxt) { return invoke<BOOL>(0x1C7302E725259789, gxt); } // 0x1C7302E725259789
	static BOOL DOES_TEXT_LABEL_EXIST(char* gxt) { return invoke<BOOL>(0xAC09CA973C564252, gxt); } // 0xAC09CA973C564252
	static Any _DRAW_FRONTEND_ALERT(char* labelTitle, char* labelMsg, int p2, int p3, char* labelMsg2, int p5, int p6, int p7, char* p8, char* p9, BOOL background, Any p11) { return invoke<Any>(0x15803FEC3B9A872B, labelTitle, labelMsg, p2, p3, labelMsg2, p5, p6, p7, p8, p9, background, p11); } // 0x15803FEC3B9A872B
	static int _DRAW_NOTIFICATION(BOOL blink, BOOL showInBrief) { return invoke<int>(0x2ED7843F8F801023, blink, showInBrief); } // 0x2ED7843F8F801023
	static int _DRAW_NOTIFICATION_APARTMENT_INVITE(BOOL p0, BOOL p1, int* p2, int p3, BOOL isLeader, BOOL unk0, int clanDesc, int R, int G, int B) { return invoke<int>(0x97C9E4E7024A8F2C, p0, p1, p2, p3, isLeader, unk0, clanDesc, R, G, B); } // 0x97C9E4E7024A8F2C
	static int _DRAW_NOTIFICATION_AWARD(char* textureDict, char* textureName, int rpBonus, int colorOverlay, char* titleLabel) { return invoke<int>(0xAA295B6F28BD587D, textureDict, textureName, rpBonus, colorOverlay, titleLabel); } // 0xAA295B6F28BD587D
	static int _DRAW_NOTIFICATION_CLAN_INVITE(BOOL p0, BOOL p1, int* p2, int p3, BOOL isLeader, BOOL unk0, int clanDesc, char* playerName, int R, int G, int B) { return invoke<int>(0x137BC35589E34E1E, p0, p1, p2, p3, isLeader, unk0, clanDesc, playerName, R, G, B); } // 0x137BC35589E34E1E
	static int _DRAW_NOTIFICATION_WITH_BUTTON(int type, char* button, char* text) { return invoke<int>(0xDD6CB2CCE7C2735C, type, button, text); } // 0xDD6CB2CCE7C2735C
	static int _DRAW_NOTIFICATION_WITH_ICON(int type, int image, char* text) { return invoke<int>(0xD202B92CBF1D816F, type, image, text); } // 0xD202B92CBF1D816F
	static int _DRAW_NOTIFICATION_2(BOOL blink, BOOL p1) { return invoke<int>(0x44FA03975424A0EE, blink, p1); } // 0x44FA03975424A0EE
	static int _DRAW_NOTIFICATION_3(BOOL blink, BOOL p1) { return invoke<int>(0x378E809BF61EC840, blink, p1); } // 0x378E809BF61EC840
	static int _DRAW_NOTIFICATION_4(BOOL blink, BOOL p1) { return invoke<int>(0xF020C96915705B3A, blink, p1); } // 0xF020C96915705B3A
	static void ENABLE_DEATHBLOOD_SEETHROUGH(BOOL p0) { invoke<Void>(0x4895BDEA16E7C080, p0); } // 0x4895BDEA16E7C080
	static void _END_TEXT_COMMAND_BUSY_STRING(int busySpinnerType) { invoke<Void>(0xBD12F8228410D9B4, busySpinnerType); } // 0xBD12F8228410D9B4
	static void END_TEXT_COMMAND_CLEAR_PRINT() { invoke<Void>(0xFCC75460ABA29378); } // 0xFCC75460ABA29378
	static void END_TEXT_COMMAND_DISPLAY_HELP(Any p0, BOOL loop, BOOL beep, int duration) { invoke<Void>(0x238FFE5C7B0498A6, p0, loop, beep, duration); } // 0x238FFE5C7B0498A6
	static void END_TEXT_COMMAND_DISPLAY_TEXT(float x, float y) { invoke<Void>(0xCD015E5BB0D96A57, x, y); } // 0xCD015E5BB0D96A57
	static float _END_TEXT_COMMAND_GET_WIDTH(BOOL p0) { return invoke<float>(0x85F061DA64ED2F67, p0); } // 0x85F061DA64ED2F67
	static BOOL END_TEXT_COMMAND_IS_MESSAGE_DISPLAYED() { return invoke<BOOL>(0x8A9BA1AB3E237613); } // 0x8A9BA1AB3E237613
	static BOOL END_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED(int p0) { return invoke<BOOL>(0x10BDDBFC529428DD, p0); } // 0x10BDDBFC529428DD
	static void _END_TEXT_COMMAND_OBJECTIVE(BOOL p0) { invoke<Void>(0xCFDBDF5AE59BA0F4, p0); } // 0xCFDBDF5AE59BA0F4
	static void END_TEXT_COMMAND_PRINT(int duration, BOOL drawImmediately) { invoke<Void>(0x9D77056A530643F6, duration, drawImmediately); } // 0x9D77056A530643F6
	static void END_TEXT_COMMAND_SET_BLIP_NAME(Blip blip) { invoke<Void>(0xBC38B49BCB83BC9B, blip); } // 0xBC38B49BCB83BC9B
	static void _END_TEXT_COMMAND_TIMER(BOOL p0) { invoke<Void>(0xA86911979638106F, p0); } // 0xA86911979638106F
	static void FLASH_ABILITY_BAR(BOOL toggle) { invoke<Void>(0x2CFBA0C9E9275CE, toggle); } // 0x2CFBA0C9E9275CE
	static void FLASH_MINIMAP_DISPLAY() { invoke<Void>(0xF2DD778C22B15BDA); } // 0xF2DD778C22B15BDA
	static Any FLASH_WANTED_DISPLAY(BOOL p0) { return invoke<Any>(0xA18AFB39081B6A1F, p0); } // 0xA18AFB39081B6A1F
	static int _GET_ACTIVE_WEBSITE_ID() { return invoke<int>(0x1A358D9128B7A86); } // 0x1A358D9128B7A86
	static Blip _GET_AI_BLIP(Ped ped) { return invoke<Blip>(0x56176892826A4FE8, ped); } // 0x56176892826A4FE8
	static int GET_BLIP_ALPHA(Blip blip) { return invoke<int>(0x970F608F0EE6C885, blip); } // 0x970F608F0EE6C885
	static int GET_BLIP_COLOUR(Blip blip) { return invoke<int>(0xDF729E8D20CF7327, blip); } // 0xDF729E8D20CF7327
	static Vector3 GET_BLIP_COORDS(Blip blip) { return invoke<Vector3>(0x586AFE3FF72D996E, blip); } // 0x586AFE3FF72D996E
	static Blip GET_BLIP_FROM_ENTITY(Entity entity) { return invoke<Blip>(0xBC8DBDCA2436F7E8, entity); } // 0xBC8DBDCA2436F7E8
	static int GET_BLIP_HUD_COLOUR(Blip blip) { return invoke<int>(0x729B5F1EFBC0AAEE, blip); } // 0x729B5F1EFBC0AAEE
	static Vector3 GET_BLIP_INFO_ID_COORD(Blip blip) { return invoke<Vector3>(0xFA7C7F0AADF25D09, blip); } // 0xFA7C7F0AADF25D09
	static int GET_BLIP_INFO_ID_DISPLAY(Blip blip) { return invoke<int>(0x1E314167F701DC3B, blip); } // 0x1E314167F701DC3B
	static Entity GET_BLIP_INFO_ID_ENTITY_INDEX(Blip blip) { return invoke<Entity>(0x4BA4E2553AFEDC2C, blip); } // 0x4BA4E2553AFEDC2C
	static int _GET_BLIP_INFO_ID_ITERATOR() { return invoke<int>(0x186E5D252FA50E7D); } // 0x186E5D252FA50E7D
	static Pickup GET_BLIP_INFO_ID_PICKUP_INDEX(Blip blip) { return invoke<Pickup>(0x9B6786E4C03DD382, blip); } // 0x9B6786E4C03DD382
	static int GET_BLIP_INFO_ID_TYPE(Blip blip) { return invoke<int>(0xBE9B0959FFD0779B, blip); } // 0xBE9B0959FFD0779B
	static int GET_BLIP_SPRITE(Blip blip) { return invoke<int>(0x1FC877464A04FC4F, blip); } // 0x1FC877464A04FC4F
	static Hash _GET_CURRENT_FRONTEND_MENU() { return invoke<Hash>(0x2309595AD6145265); } // 0x2309595AD6145265
	static int _GET_CURRENT_NOTIFICATION() { return invoke<int>(0x82352748437638CA); } // 0x82352748437638CA
	static int GET_CURRENT_WEBSITE_ID() { return invoke<int>(0x97D47996FC48CBAD); } // 0x97D47996FC48CBAD
	static int GET_DEFAULT_SCRIPT_RENDERTARGET_RENDER_ID() { return invoke<int>(0x52F0982D7FD156B6); } // 0x52F0982D7FD156B6
	static Blip GET_FIRST_BLIP_INFO_ID(int blipSprite) { return invoke<Blip>(0x1BEDE233E6CD2A1F, blipSprite); } // 0x1BEDE233E6CD2A1F
	static void GET_HUD_COLOUR(int hudColorIndex, int* r, int* g, int* b, int* a) { invoke<Void>(0x7C9C91AB74A0360F, hudColorIndex, r, g, b, a); } // 0x7C9C91AB74A0360F
	static Vector3 GET_HUD_COMPONENT_POSITION(int id) { return invoke<Vector3>(0x223CA69A8C4417FD, id); } // 0x223CA69A8C4417FD
	static char* _GET_LABEL_TEXT(char* labelName) { return invoke<char*>(0x7B5280EBA9840C72, labelName); } // 0x7B5280EBA9840C72
	static int GET_LENGTH_OF_LITERAL_STRING(char* string) { return invoke<int>(0xF030907CCBB8A9FD, string); } // 0xF030907CCBB8A9FD
	static int _GET_LENGTH_OF_STRING(char* STRING) { return invoke<int>(0x43E4111189E54F0E, STRING); } // 0x43E4111189E54F0E
	static int GET_LENGTH_OF_STRING_WITH_THIS_TEXT_LABEL(char* gxt) { return invoke<int>(0x801BD273D3A23F74, gxt); } // 0x801BD273D3A23F74
	static Blip GET_MAIN_PLAYER_BLIP_ID() { return invoke<Blip>(0xDCD4EC3F419D02FA); } // 0xDCD4EC3F419D02FA
	static Any GET_NAMED_RENDERTARGET_RENDER_ID(char* p0) { return invoke<Any>(0x1A6478B61C6BDC3B, p0); } // 0x1A6478B61C6BDC3B
	static Blip GET_NEXT_BLIP_INFO_ID(int blipSprite) { return invoke<Blip>(0x14F96AA50D6FBEA7, blipSprite); } // 0x14F96AA50D6FBEA7
	static int GET_NUMBER_OF_ACTIVE_BLIPS() { return invoke<int>(0x9A3FF3DE163034E8); } // 0x9A3FF3DE163034E8
	static int GET_PAUSE_MENU_STATE() { return invoke<int>(0x272ACD84970869C5); } // 0x272ACD84970869C5
	static BOOL _GET_SCREEN_COORD_FROM_WORLD_COORD(float worldX, float worldY, float worldZ, float* screenX, float* screenY) { return invoke<BOOL>(0xF9904D11F1ACBEC3, worldX, worldY, worldZ, screenX, screenY); } // 0xF9904D11F1ACBEC3
	static char* GET_STREET_NAME_FROM_HASH_KEY(Hash hash) { return invoke<char*>(0xD0EF8A959B8A4CB9, hash); } // 0xD0EF8A959B8A4CB9
	static float _GET_TEXT_SCALE_HEIGHT(float size, int font) { return invoke<float>(0xDB88A37483346780, size, font); } // 0xDB88A37483346780
	static int _GET_TEXT_SCREEN_LINE_COUNT(float x, float y) { return invoke<int>(0x9040DFB09BE75706, x, y); } // 0x9040DFB09BE75706
	static char* _GET_TEXT_SUBSTRING(char* text, int position, int length) { return invoke<char*>(0x169BD9382084C8C0, text, position, length); } // 0x169BD9382084C8C0
	static char* _GET_TEXT_SUBSTRING_SAFE(char* text, int position, int length, int maxLength) { return invoke<char*>(0xB2798643312205C5, text, position, length, maxLength); } // 0xB2798643312205C5
	static char* _GET_TEXT_SUBSTRING_SLICE(char* text, int startPosition, int endPosition) { return invoke<char*>(0xCE94AEBA5D82908A, text, startPosition, endPosition); } // 0xCE94AEBA5D82908A
	static void GIVE_PED_TO_PAUSE_MENU(Ped ped, int p1) { invoke<Void>(0xAC0BFBDC3BE00E14, ped, p1); } // 0xAC0BFBDC3BE00E14
	static BOOL HAS_ADDITIONAL_TEXT_LOADED(int slot) { return invoke<BOOL>(0x2245FE4BED318B8, slot); } // 0x2245FE4BED318B8
	static BOOL _HAS_MP_GAMER_TAG() { return invoke<BOOL>(0x6E0EB3EB47C8D7AA); } // 0x6E0EB3EB47C8D7AA
	static BOOL _HAS_MP_GAMER_TAG_2(int gamerTagId) { return invoke<BOOL>(0xEB709A36958ABE0D, gamerTagId); } // 0xEB709A36958ABE0D
	static BOOL HAS_THIS_ADDITIONAL_TEXT_LOADED(char* gxt, int slot) { return invoke<BOOL>(0xADBF060E2B30C5BC, gxt, slot); } // 0xADBF060E2B30C5BC
	static void HIDE_HELP_TEXT_THIS_FRAME() { invoke<Void>(0xD46923FC481CA285); } // 0xD46923FC481CA285
	static void HIDE_HUD_AND_RADAR_THIS_FRAME() { invoke<Void>(0x719FF505F097FD20); } // 0x719FF505F097FD20
	static void HIDE_HUD_COMPONENT_THIS_FRAME(int id) { invoke<Void>(0x6806C51AD12B83B8, id); } // 0x6806C51AD12B83B8
	static void HIDE_LOADING_ON_FADE_THIS_FRAME() { invoke<Void>(0x4B0311D3CDC4648F); } // 0x4B0311D3CDC4648F
	static void HIDE_NUMBER_ON_BLIP(Blip blip) { invoke<Void>(0x532CFF637EF80148, blip); } // 0x532CFF637EF80148
	static void HIDE_SCRIPTED_HUD_COMPONENT_THIS_FRAME(int id) { invoke<Void>(0xE374C498D8BADC14, id); } // 0xE374C498D8BADC14
	static void HIDE_SPECIAL_ABILITY_LOCKON_OPERATION(Any p0, BOOL p1) { invoke<Void>(0x3EED80DFF7325CAA, p0, p1); } // 0x3EED80DFF7325CAA
	static void _IS_AI_BLIP_ALWAYS_SHOWN(Ped ped, BOOL flag) { invoke<Void>(0xC4BBF625CA98C4E, ped, flag); } // 0xC4BBF625CA98C4E
	static BOOL IS_BLIP_FLASHING(Blip blip) { return invoke<BOOL>(0xA5E41FD83AD6CEF0, blip); } // 0xA5E41FD83AD6CEF0
	static BOOL IS_BLIP_ON_MINIMAP(Blip blip) { return invoke<BOOL>(0xE41CA53051197A27, blip); } // 0xE41CA53051197A27
	static BOOL IS_BLIP_SHORT_RANGE(Blip blip) { return invoke<BOOL>(0xDA5F8727EB75B926, blip); } // 0xDA5F8727EB75B926
	static BOOL IS_HELP_MESSAGE_BEING_DISPLAYED() { return invoke<BOOL>(0x4D79439A6B55AC67); } // 0x4D79439A6B55AC67
	static BOOL IS_HELP_MESSAGE_FADING_OUT() { return invoke<BOOL>(0x327EDEEEAC55C369); } // 0x327EDEEEAC55C369
	static BOOL IS_HELP_MESSAGE_ON_SCREEN() { return invoke<BOOL>(0xDAD37F45428801AE); } // 0xDAD37F45428801AE
	static BOOL IS_HUD_COMPONENT_ACTIVE(int id) { return invoke<BOOL>(0xBC4C9EA5391ECC0D, id); } // 0xBC4C9EA5391ECC0D
	static BOOL IS_HUD_HIDDEN() { return invoke<BOOL>(0xA86478C6958735C5); } // 0xA86478C6958735C5
	static BOOL IS_HUD_PREFERENCE_SWITCHED_ON() { return invoke<BOOL>(0x1930DFA731813EC4); } // 0x1930DFA731813EC4
	static BOOL _IS_LOADING_PROMPT_BEING_DISPLAYED() { return invoke<BOOL>(0xD422FCC5F239A915); } // 0xD422FCC5F239A915
	static BOOL IS_MESSAGE_BEING_DISPLAYED() { return invoke<BOOL>(0x7984C03AA5CC2F41); } // 0x7984C03AA5CC2F41
	static BOOL _IS_MINIMAP_AREA_REVEALED(float x, float y, float radius) { return invoke<BOOL>(0x6E31B91145873922, x, y, radius); } // 0x6E31B91145873922
	static BOOL IS_MISSION_CREATOR_BLIP(Blip blip) { return invoke<BOOL>(0x26F49BF3381D933D, blip); } // 0x26F49BF3381D933D
	static BOOL IS_MP_GAMER_TAG_ACTIVE(int gamerTagId) { return invoke<BOOL>(0x4E929E7A5796FD26, gamerTagId); } // 0x4E929E7A5796FD26
	static BOOL IS_NAMED_RENDERTARGET_LINKED(Hash hash) { return invoke<BOOL>(0x113750538FA31298, hash); } // 0x113750538FA31298
	static BOOL IS_NAMED_RENDERTARGET_REGISTERED(char* p0) { return invoke<BOOL>(0x78DCDC15C9F116B4, p0); } // 0x78DCDC15C9F116B4
	static BOOL IS_PAUSE_MENU_ACTIVE() { return invoke<BOOL>(0xB0034A223497FFCB); } // 0xB0034A223497FFCB
	static BOOL IS_PAUSE_MENU_RESTARTING() { return invoke<BOOL>(0x1C491717107431C7); } // 0x1C491717107431C7
	static BOOL _IS_RADAR_ENABLED() { return invoke<BOOL>(0xAF754F20EB5CD51A); } // 0xAF754F20EB5CD51A
	static BOOL IS_RADAR_HIDDEN() { return invoke<BOOL>(0x157F93B036700462); } // 0x157F93B036700462
	static BOOL IS_RADAR_PREFERENCE_SWITCHED_ON() { return invoke<BOOL>(0x9EB6522EA68F22FE); } // 0x9EB6522EA68F22FE
	static BOOL IS_SCRIPTED_HUD_COMPONENT_ACTIVE(int id) { return invoke<BOOL>(0xDD100EB17A94FF65, id); } // 0xDD100EB17A94FF65
	static BOOL IS_SOCIAL_CLUB_ACTIVE() { return invoke<BOOL>(0xC406BE343FC4B9AF); } // 0xC406BE343FC4B9AF
	static BOOL IS_STREAMING_ADDITIONAL_TEXT(int p0) { return invoke<BOOL>(0x8B6817B71B85EBF0, p0); } // 0x8B6817B71B85EBF0
	static BOOL IS_SUBTITLE_PREFERENCE_SWITCHED_ON() { return invoke<BOOL>(0xAD6DACA4BA53E0A4); } // 0xAD6DACA4BA53E0A4
	static BOOL _IS_TEXT_CHAT_ACTIVE() { return invoke<BOOL>(0xB118AF58B5F332A1); } // 0xB118AF58B5F332A1
	static BOOL IS_WARNING_MESSAGE_ACTIVE() { return invoke<BOOL>(0xE18B138FABC53103); } // 0xE18B138FABC53103
	static BOOL IS_WAYPOINT_ACTIVE() { return invoke<BOOL>(0x1DD1F58F493F1DA5); } // 0x1DD1F58F493F1DA5
	static void KEY_HUD_COLOUR(BOOL p0, Any p1) { invoke<Void>(0x1A5CD7752DD28CD3, p0, p1); } // 0x1A5CD7752DD28CD3
	static void LINK_NAMED_RENDERTARGET(Hash hash) { invoke<Void>(0xF6C09E276AEB3F2D, hash); } // 0xF6C09E276AEB3F2D
	static void LOCK_MINIMAP_ANGLE(int angle) { invoke<Void>(0x299FAEBB108AE05B, angle); } // 0x299FAEBB108AE05B
	static void LOCK_MINIMAP_POSITION(float x, float y) { invoke<Void>(0x1279E861A329E73F, x, y); } // 0x1279E861A329E73F
	static void _LOG_DEBUG_INFO(char* p0) { invoke<Void>(0x2162C446DFDF38FD, p0); } // 0x2162C446DFDF38FD
	static void _0x04655F9D075D0AE5(BOOL p0) { invoke<Void>(0x4655F9D075D0AE5, p0); } // 0x4655F9D075D0AE5
	static BOOL _0x052991E59076E4E4(Hash p0, Any* p1) { return invoke<BOOL>(0x52991E59076E4E4, p0, p1); } // 0x52991E59076E4E4
	static void _0x06A320535F5F0248(Any p0) { invoke<Void>(0x6A320535F5F0248, p0); } // 0x6A320535F5F0248
	static void _0x0923DBF87DFF735E(float x, float y, float z) { invoke<Void>(0x923DBF87DFF735E, x, y, z); } // 0x923DBF87DFF735E
	static BOOL _0x09C0403ED9A751C2(Any p0) { return invoke<BOOL>(0x9C0403ED9A751C2, p0); } // 0x9C0403ED9A751C2
	static BOOL _0x0C5A80A9E096D529(Any p0, Any* p1, Any p2, Any p3, Any p4, Any p5) { return invoke<BOOL>(0xC5A80A9E096D529, p0, p1, p2, p3, p4, p5); } // 0xC5A80A9E096D529
	static void _0x0CF54F20DE43879C(Any p0) { invoke<Void>(0xCF54F20DE43879C, p0); } // 0xCF54F20DE43879C
	static Any _0x1121BFA1A1A522A8() { return invoke<Any>(0x1121BFA1A1A522A8); } // 0x1121BFA1A1A522A8
	static void _0x1185A8087587322C(BOOL p0) { invoke<Void>(0x1185A8087587322C, p0); } // 0x1185A8087587322C
	static Any _0x13C4B962653A5280() { return invoke<Any>(0x13C4B962653A5280); } // 0x13C4B962653A5280
	static void _0x14621BB1DF14E2B2() { invoke<Void>(0x14621BB1DF14E2B2); } // 0x14621BB1DF14E2B2
	static void _0x14C9FDCC41F81F63(BOOL p0) { invoke<Void>(0x14C9FDCC41F81F63, p0); } // 0x14C9FDCC41F81F63
	static void _0x15CFA549788D35EF() { invoke<Void>(0x15CFA549788D35EF); } // 0x15CFA549788D35EF
	static void _0x16A304E6CB2BFAB9(int r, int g, int b, int a) { invoke<Void>(0x16A304E6CB2BFAB9, r, g, b, a); } // 0x16A304E6CB2BFAB9
	static void _0x170F541E1CADD1DE(BOOL p0) { invoke<Void>(0x170F541E1CADD1DE, p0); } // 0x170F541E1CADD1DE
	static void _0x17AD8C9706BDD88A(Any p0) { invoke<Void>(0x17AD8C9706BDD88A, p0); } // 0x17AD8C9706BDD88A
	static void _0x1EAC5F91BCBC5073(BOOL p0) { invoke<Void>(0x1EAC5F91BCBC5073, p0); } // 0x1EAC5F91BCBC5073
	static void _0x1EAE6DD17B7A5EFA(Any p0) { invoke<Void>(0x1EAE6DD17B7A5EFA, p0); } // 0x1EAE6DD17B7A5EFA
	static void _0x20FE7FDFEEAD38C0() { invoke<Void>(0x20FE7FDFEEAD38C0); } // 0x20FE7FDFEEAD38C0
	static void _0x211C4EF450086857() { invoke<Void>(0x211C4EF450086857); } // 0x211C4EF450086857
	static BOOL _0x214CD562A939246A() { return invoke<BOOL>(0x214CD562A939246A); } // 0x214CD562A939246A
	static BOOL _0x2432784ACA090DA4(Any p0) { return invoke<BOOL>(0x2432784ACA090DA4, p0); } // 0x2432784ACA090DA4
	static BOOL _0x24A49BEAF468DC90(Any p0, Any* p1, Any p2, Any p3, Any p4) { return invoke<BOOL>(0x24A49BEAF468DC90, p0, p1, p2, p3, p4); } // 0x24A49BEAF468DC90
	static void _0x25615540D894B814(Any p0, BOOL p1) { invoke<Void>(0x25615540D894B814, p0, p1); } // 0x25615540D894B814
	static void _0x25F87B30C382FCA7() { invoke<Void>(0x25F87B30C382FCA7); } // 0x25F87B30C382FCA7
	static void _0x2632482FD6B9AB87() { invoke<Void>(0x2632482FD6B9AB87); } // 0x2632482FD6B9AB87
	static void _0x2708FC083123F9FF() { invoke<Void>(0x2708FC083123F9FF); } // 0x2708FC083123F9FF
	static void _0x2790F4B17D098E26(Any p0) { invoke<Void>(0x2790F4B17D098E26, p0); } // 0x2790F4B17D098E26
	static void _0x2916A928514C9827() { invoke<Void>(0x2916A928514C9827); } // 0x2916A928514C9827
	static Any _0x2A25ADC48F87841F() { return invoke<Any>(0x2A25ADC48F87841F); } // 0x2A25ADC48F87841F
	static Any _0x2C173AE2BDB9385E(Blip blip) { return invoke<Any>(0x2C173AE2BDB9385E, blip); } // 0x2C173AE2BDB9385E
	static void _0x2C9F302398E13141(Any p0, Any p1) { invoke<Void>(0x2C9F302398E13141, p0, p1); } // 0x2C9F302398E13141
	static void _0x2DE6C5E2E996F178(Any p0) { invoke<Void>(0x2DE6C5E2E996F178, p0); } // 0x2DE6C5E2E996F178
	static Any _0x2E22FEFA0100275E() { return invoke<Any>(0x2E22FEFA0100275E); } // 0x2E22FEFA0100275E
	static Any _0x2F057596F2BD0061() { return invoke<Any>(0x2F057596F2BD0061); } // 0x2F057596F2BD0061
	static void _0x311438A071DD9B1A(Any p0, Any p1, Any p2) { invoke<Void>(0x311438A071DD9B1A, p0, p1, p2); } // 0x311438A071DD9B1A
	static void _0x317EBA71D7543F52(Any* p0, Any* p1, Any* p2, Any* p3) { invoke<Void>(0x317EBA71D7543F52, p0, p1, p2, p3); } // 0x317EBA71D7543F52
	static void _0x32888337579A5970() { invoke<Void>(0x32888337579A5970); } // 0x32888337579A5970
	static Any _0x33EE12743CCD6343(Any p0, Any p1, Any p2) { return invoke<Any>(0x33EE12743CCD6343, p0, p1, p2); } // 0x33EE12743CCD6343
	static Any _0x359AF31A4B52F5ED() { return invoke<Any>(0x359AF31A4B52F5ED); } // 0x359AF31A4B52F5ED
	static void _0x35EDD5B2E3FF01C0() { invoke<Void>(0x35EDD5B2E3FF01C0); } // 0x35EDD5B2E3FF01C0
	static void _0x36C1451A88A09630(Any* p0, Any* p1) { invoke<Void>(0x36C1451A88A09630, p0, p1); } // 0x36C1451A88A09630
	static Any _0x3BAB9A4E4F2FF5C7() { return invoke<Any>(0x3BAB9A4E4F2FF5C7); } // 0x3BAB9A4E4F2FF5C7
	static void _0x3D3D15AF7BCAAF83(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x3D3D15AF7BCAAF83, p0, p1, p2); } // 0x3D3D15AF7BCAAF83
	static Any _0x3D9ACB1EB139E702() { return invoke<Any>(0x3D9ACB1EB139E702); } // 0x3D9ACB1EB139E702
	static void _0x3DDA37128DD1ACA8(BOOL p0) { invoke<Void>(0x3DDA37128DD1ACA8, p0); } // 0x3DDA37128DD1ACA8
	static Any _0x3F0CF9CB7E589B88() { return invoke<Any>(0x3F0CF9CB7E589B88); } // 0x3F0CF9CB7E589B88
	static void _0x3F5CC444DCAAA8F2(Any p0, Any p1, BOOL p2) { invoke<Void>(0x3F5CC444DCAAA8F2, p0, p1, p2); } // 0x3F5CC444DCAAA8F2
	static void _0x402F9ED62087E898() { invoke<Void>(0x402F9ED62087E898); } // 0x402F9ED62087E898
	static void _0x41350B4FC28E3941(BOOL p0) { invoke<Void>(0x41350B4FC28E3941, p0); } // 0x41350B4FC28E3941
	static BOOL _0x4167EFE0527D706E() { return invoke<BOOL>(0x4167EFE0527D706E); } // 0x4167EFE0527D706E
	static void _0x488043841BBE156F() { invoke<Void>(0x488043841BBE156F); } // 0x488043841BBE156F
	static void _0x4A0C7C9BB10ABB36(BOOL p0) { invoke<Void>(0x4A0C7C9BB10ABB36, p0); } // 0x4A0C7C9BB10ABB36
	static BOOL _0x4A9923385BDB9DAD() { return invoke<BOOL>(0x4A9923385BDB9DAD); } // 0x4A9923385BDB9DAD
	static void _0x4B5B620C9B59ED34(Any p0, Any p1) { invoke<Void>(0x4B5B620C9B59ED34, p0, p1); } // 0x4B5B620C9B59ED34
	static Any _0x4E3CD0EF8A489541() { return invoke<Any>(0x4E3CD0EF8A489541); } // 0x4E3CD0EF8A489541
	static void _0x54318C915D27E4CE(Any p0, BOOL p1) { invoke<Void>(0x54318C915D27E4CE, p0, p1); } // 0x54318C915D27E4CE
	static Any _0x551DF99658DB6EE8(float p0, float p1, float p2) { return invoke<Any>(0x551DF99658DB6EE8, p0, p1, p2); } // 0x551DF99658DB6EE8
	static void _0x56C8B608CFD49854() { invoke<Void>(0x56C8B608CFD49854); } // 0x56C8B608CFD49854
	static void _0x577599CCED639CA2(Any p0) { invoke<Void>(0x577599CCED639CA2, p0); } // 0x577599CCED639CA2
	static void _0x57D760D55F54E071(BOOL p0) { invoke<Void>(0x57D760D55F54E071, p0); } // 0x57D760D55F54E071
	static void _0x583049884A2EEE3C() { invoke<Void>(0x583049884A2EEE3C); } // 0x583049884A2EEE3C
	static Any _0x593FEAE1F73392D4() { return invoke<Any>(0x593FEAE1F73392D4); } // 0x593FEAE1F73392D4
	static Vector3 _0x5BFF36D6ED83E0AE() { return invoke<Vector3>(0x5BFF36D6ED83E0AE); } // 0x5BFF36D6ED83E0AE
	static BOOL _0x5FBD7095FE7AE57F(Any p0, float* p1) { return invoke<BOOL>(0x5FBD7095FE7AE57F, p0, p1); } // 0x5FBD7095FE7AE57F
	static void _0x60734CC207C9833C(BOOL p0) { invoke<Void>(0x60734CC207C9833C, p0); } // 0x60734CC207C9833C
	static void _0x60E892BA4F5BDCA4() { invoke<Void>(0x60E892BA4F5BDCA4); } // 0x60E892BA4F5BDCA4
	static void _0x62E849B7EB28E770(BOOL p0) { invoke<Void>(0x62E849B7EB28E770, p0); } // 0x62E849B7EB28E770
	static BOOL _0x632B2940C67F4EA9(int scaleformHandle, Any* p1, Any* p2, Any* p3) { return invoke<BOOL>(0x632B2940C67F4EA9, scaleformHandle, p1, p2, p3); } // 0x632B2940C67F4EA9
	static Any _0x66E7CB63C97B7D20() { return invoke<Any>(0x66E7CB63C97B7D20); } // 0x66E7CB63C97B7D20
	static void _0x67EEDEA1B9BAFD94() { invoke<Void>(0x67EEDEA1B9BAFD94); } // 0x67EEDEA1B9BAFD94
	static void _0x6A1738B4323FE2D9(Any p0) { invoke<Void>(0x6A1738B4323FE2D9, p0); } // 0x6A1738B4323FE2D9
	static void _0x6B1DE27EE78E6A19(Any p0) { invoke<Void>(0x6B1DE27EE78E6A19, p0); } // 0x6B1DE27EE78E6A19
	static void _0x6CDD58146A436083(Any p0) { invoke<Void>(0x6CDD58146A436083, p0); } // 0x6CDD58146A436083
	static void _0x6EF54AB721DC6242() { invoke<Void>(0x6EF54AB721DC6242); } // 0x6EF54AB721DC6242
	static void _0x6F1554B0CC2089FA(BOOL p0) { invoke<Void>(0x6F1554B0CC2089FA, p0); } // 0x6F1554B0CC2089FA
	static int _0x6F72CD94F7B5B68C() { return invoke<int>(0x6F72CD94F7B5B68C); } // 0x6F72CD94F7B5B68C
	static void _0x72C1056D678BB7D8(Hash weaponHash) { invoke<Void>(0x72C1056D678BB7D8, weaponHash); } // 0x72C1056D678BB7D8
	static void _0x72DD432F3CDFC0EE(float posX, float posY, float posZ, float radius, int p4) { invoke<Void>(0x72DD432F3CDFC0EE, posX, posY, posZ, radius, p4); } // 0x72DD432F3CDFC0EE
	static void _0x75A16C3DA34F1245(Blip blip, BOOL p1) { invoke<Void>(0x75A16C3DA34F1245, blip, p1); } // 0x75A16C3DA34F1245
	static void _0x75D3691713C3B05A() { invoke<Void>(0x75D3691713C3B05A); } // 0x75D3691713C3B05A
	static void _0x7669F9E39DC17063() { invoke<Void>(0x7669F9E39DC17063); } // 0x7669F9E39DC17063
	static void _0x7679CC1BCEBE3D4C(Any p0, float p1, float p2) { invoke<Void>(0x7679CC1BCEBE3D4C, p0, p1, p2); } // 0x7679CC1BCEBE3D4C
	static void _0x7792424AA0EAC32E() { invoke<Void>(0x7792424AA0EAC32E); } // 0x7792424AA0EAC32E
	static void _0x77F16B447824DA6C(Any p0) { invoke<Void>(0x77F16B447824DA6C, p0); } // 0x77F16B447824DA6C
	static void _0x784BA7E0ECEB4178(Any p0, float x, float y, float z) { invoke<Void>(0x784BA7E0ECEB4178, p0, x, y, z); } // 0x784BA7E0ECEB4178
	static void _0x788E7FD431BD67F1(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0x788E7FD431BD67F1, p0, p1, p2, p3, p4, p5); } // 0x788E7FD431BD67F1
	static Any _0x7AE0589093A2E088(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return invoke<Any>(0x7AE0589093A2E088, p0, p1, p2, p3, p4, p5); } // 0x7AE0589093A2E088
	static void _0x7B21E0BB01E8224A(Any p0) { invoke<Void>(0x7B21E0BB01E8224A, p0); } // 0x7B21E0BB01E8224A
	static void _0x7C226D5346D4D10A(Any p0) { invoke<Void>(0x7C226D5346D4D10A, p0); } // 0x7C226D5346D4D10A
	static void _0x7CD934010E115C2C(Ped ped) { invoke<Void>(0x7CD934010E115C2C, ped); } // 0x7CD934010E115C2C
	static void _0x7E17BE53E1AAABAF(int* p0, int* p1, int* p2) { invoke<Void>(0x7E17BE53E1AAABAF, p0, p1, p2); } // 0x7E17BE53E1AAABAF
	static Any _0x801879A9B4F4B2FB() { return invoke<Any>(0x801879A9B4F4B2FB); } // 0x801879A9B4F4B2FB
	static void _0x80FE4F3AB4E1B62A() { invoke<Void>(0x80FE4F3AB4E1B62A); } // 0x80FE4F3AB4E1B62A
	static void _0x817B86108EB94E51(BOOL p0, Any* p1, Any* p2, Any* p3, Any* p4, Any* p5, Any* p6, Any* p7, Any* p8) { invoke<Void>(0x817B86108EB94E51, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0x817B86108EB94E51
	static void _0x82CEDC33687E1F50(BOOL p0) { invoke<Void>(0x82CEDC33687E1F50, p0); } // 0x82CEDC33687E1F50
	static BOOL _0x84698AB38D0C6636(Hash hash) { return invoke<BOOL>(0x84698AB38D0C6636, hash); } // 0x84698AB38D0C6636
	static void _0x8817605C2BA76200() { invoke<Void>(0x8817605C2BA76200); } // 0x8817605C2BA76200
	static Any _0x8EFCCF6EC66D85E4(Any* p0, Any* p1, Any* p2, BOOL p3, BOOL p4) { return invoke<Any>(0x8EFCCF6EC66D85E4, p0, p1, p2, p3, p4); } // 0x8EFCCF6EC66D85E4
	static BOOL _0x8F08017F9D7C47BD(Any p0, Any* p1, Any p2) { return invoke<BOOL>(0x8F08017F9D7C47BD, p0, p1, p2); } // 0x8F08017F9D7C47BD
	static void _0x900086F371220B6F(BOOL p0, Any p1, Any p2) { invoke<Void>(0x900086F371220B6F, p0, p1, p2); } // 0x900086F371220B6F
	static Any _0x9049FE339D5F6F6F() { return invoke<Any>(0x9049FE339D5F6F6F); } // 0x9049FE339D5F6F6F
	static BOOL _0x90A6526CF0381030(Any p0, Any* p1, Any p2, Any p3) { return invoke<BOOL>(0x90A6526CF0381030, p0, p1, p2, p3); } // 0x90A6526CF0381030
	static Any _0x9135584D09A3437E() { return invoke<Any>(0x9135584D09A3437E); } // 0x9135584D09A3437E
	static void _0x9245E81072704B8A(BOOL p0) { invoke<Void>(0x9245E81072704B8A, p0); } // 0x9245E81072704B8A
	static void _0x95CF81BD06EE1887() { invoke<Void>(0x95CF81BD06EE1887); } // 0x95CF81BD06EE1887
	static void _0x975D66A0BC17064C(Any p0) { invoke<Void>(0x975D66A0BC17064C, p0); } // 0x975D66A0BC17064C
	static void _0x98215325A695E78A(BOOL p0) { invoke<Void>(0x98215325A695E78A, p0); } // 0x98215325A695E78A
	static Any _0x98C3CF913D895111(Any p0, Any p1) { return invoke<Any>(0x98C3CF913D895111, p0, p1); } // 0x98C3CF913D895111
	static void _0x9C16459B2324B2CF(Any p0, Any p1) { invoke<Void>(0x9C16459B2324B2CF, p0, p1); } // 0x9C16459B2324B2CF
	static void _0x9E778248D6685FE0(char* p0) { invoke<Void>(0x9E778248D6685FE0, p0); } // 0x9E778248D6685FE0
	static void _0xA13C11E1B5C06BFC() { invoke<Void>(0xA13C11E1B5C06BFC); } // 0xA13C11E1B5C06BFC
	static Any _0xA13E93403F26C812(Any p0) { return invoke<Any>(0xA13E93403F26C812, p0); } // 0xA13E93403F26C812
	static void _0xA17784FCA9548D15(Any p0, Any p1, Any p2) { invoke<Void>(0xA17784FCA9548D15, p0, p1, p2); } // 0xA17784FCA9548D15
	static BOOL _0xA238192F33110615(int* p0, int* p1, int* p2) { return invoke<BOOL>(0xA238192F33110615, p0, p1, p2); } // 0xA238192F33110615
	static Any _0xA277800A9EAE340E() { return invoke<Any>(0xA277800A9EAE340E); } // 0xA277800A9EAE340E
	static Hash _0xA48931185F0536FE() { return invoke<Hash>(0xA48931185F0536FE); } // 0xA48931185F0536FE
	static void _0xA4DEDE28B1814289() { invoke<Void>(0xA4DEDE28B1814289); } // 0xA4DEDE28B1814289
	static void _0xA8B6AFDAC320AC87(Any p0, Any p1) { invoke<Void>(0xA8B6AFDAC320AC87, p0, p1); } // 0xA8B6AFDAC320AC87
	static void _0xA8FDB297A8D25FBA() { invoke<Void>(0xA8FDB297A8D25FBA); } // 0xA8FDB297A8D25FBA
	static void _0xA905192A6781C41B(float x, float y, float z) { invoke<Void>(0xA905192A6781C41B, x, y, z); } // 0xA905192A6781C41B
	static Any _0xA9CBFD40B3FA3010() { return invoke<Any>(0xA9CBFD40B3FA3010); } // 0xA9CBFD40B3FA3010
	static void _0xADED7F5748ACAFE6() { invoke<Void>(0xADED7F5748ACAFE6); } // 0xADED7F5748ACAFE6
	static Any _0xAF42195A42C63BBA() { return invoke<Any>(0xAF42195A42C63BBA); } // 0xAF42195A42C63BBA
	static void _0xB094BC1DB4018240(Any p0, Any p1, float p2, float p3) { invoke<Void>(0xB094BC1DB4018240, p0, p1, p2, p3); } // 0xB094BC1DB4018240
	static void _0xB13DCB4C6FAAD238(Ped ped, BOOL toggle, Any p3) { invoke<Void>(0xB13DCB4C6FAAD238, ped, toggle, p3); } // 0xB13DCB4C6FAAD238
	static Pickup _0xB2A592B04648A9CB() { return invoke<Pickup>(0xB2A592B04648A9CB); } // 0xB2A592B04648A9CB
	static void _0xB552929B85FC27EC(Any p0, Any p1) { invoke<Void>(0xB552929B85FC27EC, p0, p1); } // 0xB552929B85FC27EC
	static Any _0xB6871B0555B02996(Any* p0, Any* p1, Any p2, Any* p3, Any* p4, Any p5) { return invoke<Any>(0xB6871B0555B02996, p0, p1, p2, p3, p4, p5); } // 0xB6871B0555B02996
	static void _0xB695E2CD0A2DA9EE() { invoke<Void>(0xB695E2CD0A2DA9EE); } // 0xB695E2CD0A2DA9EE
	static void _0xB99C4E4D9499DF29(BOOL p0) { invoke<Void>(0xB99C4E4D9499DF29, p0); } // 0xB99C4E4D9499DF29
	static void _0xB9C362BABECDDC7A(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xB9C362BABECDDC7A, p0, p1, p2, p3, p4); } // 0xB9C362BABECDDC7A
	static void _0xBA751764F0821256() { invoke<Void>(0xBA751764F0821256); } // 0xBA751764F0821256
	static void _0xBA8D65C1C65702E5(BOOL p0) { invoke<Void>(0xBA8D65C1C65702E5, p0); } // 0xBA8D65C1C65702E5
	static void _0xBAE4F9B97CD43B30(BOOL p0) { invoke<Void>(0xBAE4F9B97CD43B30, p0); } // 0xBAE4F9B97CD43B30
	static void _0xBF4F34A85CA2970C() { invoke<Void>(0xBF4F34A85CA2970C); } // 0xBF4F34A85CA2970C
	static void _0xC2D15BEF167E27BC() { invoke<Void>(0xC2D15BEF167E27BC); } // 0xC2D15BEF167E27BC
	static Any _0xC2D2AD9EAAE265B8() { return invoke<Any>(0xC2D2AD9EAAE265B8); } // 0xC2D2AD9EAAE265B8
	static void _0xC4278F70131BAA6D(Blip p0, BOOL p1) { invoke<Void>(0xC4278F70131BAA6D, p0, p1); } // 0xC4278F70131BAA6D
	static void _0xC594B315EDF2D4AF(Ped ped) { invoke<Void>(0xC594B315EDF2D4AF, ped); } // 0xC594B315EDF2D4AF
	static void _0xC65AB383CD91DF98() { invoke<Void>(0xC65AB383CD91DF98); } // 0xC65AB383CD91DF98
	static void _0xC78E239AC5B2DDB9(BOOL p0, Any p1, Any p2) { invoke<Void>(0xC78E239AC5B2DDB9, p0, p1, p2); } // 0xC78E239AC5B2DDB9
	static BOOL _0xC8E1071177A23BE5(Any* p0, Any* p1, Any* p2) { return invoke<BOOL>(0xC8E1071177A23BE5, p0, p1, p2); } // 0xC8E1071177A23BE5
	static Any _0xC8F3AAF93D0600BF(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0xC8F3AAF93D0600BF, p0, p1, p2, p3); } // 0xC8F3AAF93D0600BF
	static BOOL _0xCA6B2F7CE32AB653(Any p0, Any* p1, Any p2) { return invoke<BOOL>(0xCA6B2F7CE32AB653, p0, p1, p2); } // 0xCA6B2F7CE32AB653
	static void _0xCC3FDDED67BCFC63() { invoke<Void>(0xCC3FDDED67BCFC63); } // 0xCC3FDDED67BCFC63
	static void _0xCD74233600C4EA6B(Any p0) { invoke<Void>(0xCD74233600C4EA6B, p0); } // 0xCD74233600C4EA6B
	static void _0xCDCA26E80FAECB8F() { invoke<Void>(0xCDCA26E80FAECB8F); } // 0xCDCA26E80FAECB8F
	static void _0xCEF214315D276FD1(BOOL p0) { invoke<Void>(0xCEF214315D276FD1, p0); } // 0xCEF214315D276FD1
	static void _0xD12882D3FF82BF11() { invoke<Void>(0xD12882D3FF82BF11); } // 0xD12882D3FF82BF11
	static void _0xD1942374085C8469(Any p0) { invoke<Void>(0xD1942374085C8469, p0); } // 0xD1942374085C8469
	static void _0xD2049635DEB9C375() { invoke<Void>(0xD2049635DEB9C375); } // 0xD2049635DEB9C375
	static void _0xD2B32BE3FC1626C6() { invoke<Void>(0xD2B32BE3FC1626C6); } // 0xD2B32BE3FC1626C6
	static void _0xD4438C0564490E63() { invoke<Void>(0xD4438C0564490E63); } // 0xD4438C0564490E63
	static void _0xD68A5FF8A3A89874(int r, int g, int b, int a) { invoke<Void>(0xD68A5FF8A3A89874, r, g, b, a); } // 0xD68A5FF8A3A89874
	static void _0xD8E694757BCEA8E9() { invoke<Void>(0xD8E694757BCEA8E9); } // 0xD8E694757BCEA8E9
	static BOOL _0xDAF87174BE7454FF(Any p0) { return invoke<BOOL>(0xDAF87174BE7454FF, p0); } // 0xDAF87174BE7454FF
	static void _0xDB34E8D56FC13B08(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xDB34E8D56FC13B08, p0, p1, p2); } // 0xDB34E8D56FC13B08
	static BOOL _0xDD2238F57B977751(Any p0) { return invoke<BOOL>(0xDD2238F57B977751, p0); } // 0xDD2238F57B977751
	static Any _0xDE03620F8703A9DF() { return invoke<Any>(0xDE03620F8703A9DF); } // 0xDE03620F8703A9DF
	static float _0xE0130B41D3CF4574() { return invoke<float>(0xE0130B41D3CF4574); } // 0xE0130B41D3CF4574
	static void _0xE1CD1E48E025E661() { invoke<Void>(0xE1CD1E48E025E661); } // 0xE1CD1E48E025E661
	static Any _0xE3B05614DCE1D014(Any p0) { return invoke<Any>(0xE3B05614DCE1D014, p0); } // 0xE3B05614DCE1D014
	static void _0xE67C6DFD386EA5E7(BOOL p0) { invoke<Void>(0xE67C6DFD386EA5E7, p0); } // 0xE67C6DFD386EA5E7
	static void _0xE6DE0561D9232A64() { invoke<Void>(0xE6DE0561D9232A64); } // 0xE6DE0561D9232A64
	static void _0xEC9264727EEC0F28() { invoke<Void>(0xEC9264727EEC0F28); } // 0xEC9264727EEC0F28
	static void _0xEE4C0E6DBC6F2C6F() { invoke<Void>(0xEE4C0E6DBC6F2C6F); } // 0xEE4C0E6DBC6F2C6F
	static void _0xF06EBB91A81E09E3(BOOL p0) { invoke<Void>(0xF06EBB91A81E09E3, p0); } // 0xF06EBB91A81E09E3
	static Any _0xF13FE2A80C05C561() { return invoke<Any>(0xF13FE2A80C05C561); } // 0xF13FE2A80C05C561
	static void _0xF1A6C18B35BCADE6(BOOL p0) { invoke<Void>(0xF1A6C18B35BCADE6, p0); } // 0xF1A6C18B35BCADE6
	static Any _0xF284AC67940C6812() { return invoke<Any>(0xF284AC67940C6812); } // 0xF284AC67940C6812
	static void _0xF47E567B3630DD12(Any p0, Any p1) { invoke<Void>(0xF47E567B3630DD12, p0, p1); } // 0xF47E567B3630DD12
	static void _0xF98E4B3E56AFC7B1(Any p0, float p1) { invoke<Void>(0xF98E4B3E56AFC7B1, p0, p1); } // 0xF98E4B3E56AFC7B1
	static void _0xFCFACD0DB9D7A57D(Ped ped, Any p1) { invoke<Void>(0xFCFACD0DB9D7A57D, ped, p1); } // 0xFCFACD0DB9D7A57D
	static void _0xFDB423997FA30340() { invoke<Void>(0xFDB423997FA30340); } // 0xFDB423997FA30340
	static void _0xFDD85225B2DEA55E() { invoke<Void>(0xFDD85225B2DEA55E); } // 0xFDD85225B2DEA55E
	static void _0xFDEC055AB549E328() { invoke<Void>(0xFDEC055AB549E328); } // 0xFDEC055AB549E328
	static void OBJECT_DECAL_TOGGLE(Hash hash) { invoke<Void>(0x444D8CF241EC25C5, hash); } // 0x444D8CF241EC25C5
	static void PAUSE_MENU_ACTIVATE_CONTEXT(Hash hash) { invoke<Void>(0xDD564BDD0472C936, hash); } // 0xDD564BDD0472C936
	static void PULSE_BLIP(Blip blip) { invoke<Void>(0x742D6FD43115AF73, blip); } // 0x742D6FD43115AF73
	static void REFRESH_WAYPOINT() { invoke<Void>(0x81FA173F170560D1); } // 0x81FA173F170560D1
	static BOOL REGISTER_NAMED_RENDERTARGET(char* p0, BOOL p1) { return invoke<BOOL>(0x57D9C12635E25CE3, p0, p1); } // 0x57D9C12635E25CE3
	static BOOL RELEASE_NAMED_RENDERTARGET(Any* p0) { return invoke<BOOL>(0xE9F6FFE837354DD4, p0); } // 0xE9F6FFE837354DD4
	static void REMOVE_BLIP(Blip* blip) { invoke<Void>(0x86A652570E5F25DD, blip); } // 0x86A652570E5F25DD
	static void _REMOVE_LOADING_PROMPT() { invoke<Void>(0x10D373323E5B9C0D); } // 0x10D373323E5B9C0D
	static void REMOVE_MP_GAMER_TAG(int gamerTagId) { invoke<Void>(0x31698AA80E0223F8, gamerTagId); } // 0x31698AA80E0223F8
	static void REMOVE_MULTIPLAYER_BANK_CASH() { invoke<Void>(0xC7C6789AA1CFEDD0); } // 0xC7C6789AA1CFEDD0
	static void REMOVE_MULTIPLAYER_HUD_CASH() { invoke<Void>(0x968F270E39141ECA); } // 0x968F270E39141ECA
	static void _REMOVE_NOTIFICATION(int notificationId) { invoke<Void>(0xBE4390CB40B3E627, notificationId); } // 0xBE4390CB40B3E627
	static void REQUEST_ADDITIONAL_TEXT(char* gxt, int slot) { invoke<Void>(0x71A78003C8E71424, gxt, slot); } // 0x71A78003C8E71424
	static void _REQUEST_ADDITIONAL_TEXT_2(char* gxt, int slot) { invoke<Void>(0x6009F9F1AE90D8A6, gxt, slot); } // 0x6009F9F1AE90D8A6
	static void RESET_HUD_COMPONENT_VALUES(int id) { invoke<Void>(0x450930E616475D0D, id); } // 0x450930E616475D0D
	static void RESET_RETICULE_VALUES() { invoke<Void>(0x12782CE0A636E9F0); } // 0x12782CE0A636E9F0
	static void RESPONDING_AS_TEMP(float p0) { invoke<Void>(0xBD12C5EEE184C337, p0); } // 0xBD12C5EEE184C337
	static void RESTART_FRONTEND_MENU(Hash menuHash, int p1) { invoke<Void>(0x10706DC6AD2D49C0, menuHash, p1); } // 0x10706DC6AD2D49C0
	static void SET_ABILITY_BAR_VALUE(float value, float maxValue) { invoke<Void>(0x9969599CCFF5D85E, value, maxValue); } // 0x9969599CCFF5D85E
	static void _SET_AI_BLIP_MAX_DISTANCE(Ped ped, float distance) { invoke<Void>(0x97C65887D4B37FA9, ped, distance); } // 0x97C65887D4B37FA9
	static void _SET_AI_BLIP_TYPE(Ped ped, int type) { invoke<Void>(0xE52B8E7F85D39A08, ped, type); } // 0xE52B8E7F85D39A08
	static void SET_BIGMAP_ACTIVE(BOOL toggleBigMap, BOOL showFullMap) { invoke<Void>(0x231C8F89D0539D8F, toggleBigMap, showFullMap); } // 0x231C8F89D0539D8F
	static void SET_BLIP_ALPHA(Blip blip, int alpha) { invoke<Void>(0x45FF974EEE1C8734, blip, alpha); } // 0x45FF974EEE1C8734
	static void SET_BLIP_AS_FRIENDLY(Blip blip, BOOL toggle) { invoke<Void>(0x6F6F290102C02AB4, blip, toggle); } // 0x6F6F290102C02AB4
	static void SET_BLIP_AS_MISSION_CREATOR_BLIP(Blip blip, BOOL toggle) { invoke<Void>(0x24AC0137444F9FD5, blip, toggle); } // 0x24AC0137444F9FD5
	static void SET_BLIP_AS_SHORT_RANGE(Blip blip, BOOL toggle) { invoke<Void>(0xBE8BE4FE60E27B72, blip, toggle); } // 0xBE8BE4FE60E27B72
	static void SET_BLIP_BRIGHT(Blip blip, BOOL toggle) { invoke<Void>(0xB203913733F27884, blip, toggle); } // 0xB203913733F27884
	static void SET_BLIP_CATEGORY(Blip blip, int index) { invoke<Void>(0x234CDD44D996FD9A, blip, index); } // 0x234CDD44D996FD9A
	static void SET_BLIP_COLOUR(Blip blip, int color) { invoke<Void>(0x3D7FB09E75D6B7E, blip, color); } // 0x3D7FB09E75D6B7E
	static void SET_BLIP_COORDS(Blip blip, float posX, float posY, float posZ) { invoke<Void>(0xAE2AF67E9D9AF65D, blip, posX, posY, posZ); } // 0xAE2AF67E9D9AF65D
	static void SET_BLIP_DISPLAY(Blip blip, int displayId) { invoke<Void>(0x9029B2F3DA924928, blip, displayId); } // 0x9029B2F3DA924928
	static void SET_BLIP_FADE(Blip blip, int opacity, int duration) { invoke<Void>(0x2AEE8F8390D2298C, blip, opacity, duration); } // 0x2AEE8F8390D2298C
	static void SET_BLIP_FLASHES(Blip blip, BOOL toggle) { invoke<Void>(0xB14552383D39CE3E, blip, toggle); } // 0xB14552383D39CE3E
	static void SET_BLIP_FLASHES_ALTERNATE(Blip blip, BOOL toggle) { invoke<Void>(0x2E8D9498C56DD0D1, blip, toggle); } // 0x2E8D9498C56DD0D1
	static void SET_BLIP_FLASH_INTERVAL(Blip blip, Any p1) { invoke<Void>(0xAA51DB313C010A7E, blip, p1); } // 0xAA51DB313C010A7E
	static void SET_BLIP_FLASH_TIMER(Blip blip, int duration) { invoke<Void>(0xD3CD6FD297AE87CC, blip, duration); } // 0xD3CD6FD297AE87CC
	static void SET_BLIP_HIGH_DETAIL(Blip blip, BOOL toggle) { invoke<Void>(0xE2590BC29220CEBB, blip, toggle); } // 0xE2590BC29220CEBB
	static void SET_BLIP_NAME_FROM_TEXT_FILE(Blip blip, char* gxtEntry) { invoke<Void>(0xEAA0FFE120D92784, blip, gxtEntry); } // 0xEAA0FFE120D92784
	static void SET_BLIP_NAME_TO_PLAYER_NAME(Blip blip, Player player) { invoke<Void>(0x127DE7B20C60A6A3, blip, player); } // 0x127DE7B20C60A6A3
	static void SET_BLIP_PRIORITY(Blip blip, int priority) { invoke<Void>(0xAE9FC9EF6A9FAC79, blip, priority); } // 0xAE9FC9EF6A9FAC79
	static void SET_BLIP_ROTATION(Blip blip, int rotation) { invoke<Void>(0xF87683CDF73C3F6E, blip, rotation); } // 0xF87683CDF73C3F6E
	static void SET_BLIP_ROUTE(Blip blip, BOOL enabled) { invoke<Void>(0x4F7D8A9BFB0B43E9, blip, enabled); } // 0x4F7D8A9BFB0B43E9
	static void SET_BLIP_ROUTE_COLOUR(Blip blip, int colour) { invoke<Void>(0x837155CD2F63DA09, blip, colour); } // 0x837155CD2F63DA09
	static void SET_BLIP_SCALE(Blip blip, float scale) { invoke<Void>(0xD38744167B2FA257, blip, scale); } // 0xD38744167B2FA257
	static void SET_BLIP_SECONDARY_COLOUR(Blip blip, float r, float g, float b) { invoke<Void>(0x14892474891E09EB, blip, r, g, b); } // 0x14892474891E09EB
	static void SET_BLIP_SHOW_CONE(Blip blip, BOOL toggle) { invoke<Void>(0x13127EC3665E8EE1, blip, toggle); } // 0x13127EC3665E8EE1
	static void _SET_BLIP_SHRINK(Blip blip, BOOL toggle) { invoke<Void>(0x2B6D467DAB714E8D, blip, toggle); } // 0x2B6D467DAB714E8D
	static void SET_BLIP_SPRITE(Blip blip, int spriteId) { invoke<Void>(0xDF735600A4696DAF, blip, spriteId); } // 0xDF735600A4696DAF
	static void _SET_CURSOR_SPRITE(int spriteId) { invoke<Void>(0x8DB8CFFD58B62552, spriteId); } // 0x8DB8CFFD58B62552
	static void _SET_DIRECTOR_MODE(BOOL toggle) { invoke<Void>(0x808519373FD336A3, toggle); } // 0x808519373FD336A3
	static void SET_FRONTEND_ACTIVE(BOOL active) { invoke<Void>(0x745711A75AB09277, active); } // 0x745711A75AB09277
	static void SET_GPS_FLAGS(int p0, float p1) { invoke<Void>(0x5B440763A4C8D15B, p0, p1); } // 0x5B440763A4C8D15B
	static void SET_GPS_FLASHES(BOOL toggle) { invoke<Void>(0x320D0E0D936A0E9B, toggle); } // 0x320D0E0D936A0E9B
	static void _SET_HUD_COLOUR(int hudColorIndex, int r, int g, int b, int a) { invoke<Void>(0xF314CF4F0211894E, hudColorIndex, r, g, b, a); } // 0xF314CF4F0211894E
	static void _SET_HUD_COLOURS_SWITCH(int hudColorIndex, int hudColorIndex2) { invoke<Void>(0x1CCC708F0F850613, hudColorIndex, hudColorIndex2); } // 0x1CCC708F0F850613
	static void SET_HUD_COMPONENT_POSITION(int id, float x, float y) { invoke<Void>(0xAABB1F56E2A17CED, id, x, y); } // 0xAABB1F56E2A17CED
	static void _SET_MAP_FULL_SCREEN(BOOL toggle) { invoke<Void>(0x5354C5BA2EA868A4, toggle); } // 0x5354C5BA2EA868A4
	static void _SET_MINIMAP_ATTITUDE_INDICATOR_LEVEL(float altitude, BOOL p1) { invoke<Void>(0xD201F3FF917A506D, altitude, p1); } // 0xD201F3FF917A506D
	static void SET_MINIMAP_BLOCK_WAYPOINT(BOOL toggle) { invoke<Void>(0x58FADDED207897DC, toggle); } // 0x58FADDED207897DC
	static Any SET_MINIMAP_COMPONENT(int componentID, BOOL toggle, int p2) { return invoke<Any>(0x75A9A10948D1DEA6, componentID, toggle, p2); } // 0x75A9A10948D1DEA6
	static void SET_MINIMAP_GOLF_COURSE(int hole) { invoke<Void>(0x71BDB63DBAF8DA59, hole); } // 0x71BDB63DBAF8DA59
	static void _SET_MINIMAP_REVEALED(BOOL toggle) { invoke<Void>(0xF8DEE0A5600CBB93, toggle); } // 0xF8DEE0A5600CBB93
	static void SET_MISSION_NAME(BOOL p0, char* name) { invoke<Void>(0x5F28ECF5FC84772F, p0, name); } // 0x5F28ECF5FC84772F
	static void _SET_MISSION_NAME_2(BOOL p0, char* name) { invoke<Void>(0xE45087D85F468BC2, p0, name); } // 0xE45087D85F468BC2
	static void SET_MP_GAMER_TAG_ALPHA(int gamerTagId, int component, int alpha) { invoke<Void>(0xD48FE545CD46F857, gamerTagId, component, alpha); } // 0xD48FE545CD46F857
	static void _SET_MP_GAMER_TAG_CHATTING(int gamerTagId, char* string) { invoke<Void>(0x7B7723747CCB55B6, gamerTagId, string); } // 0x7B7723747CCB55B6
	static void _SET_MP_GAMER_TAG_COLOR(int headDisplayId, char* username, BOOL pointedClanTag, BOOL isRockstarClan, char* clanTag, Any p5, int r, int g, int b) { invoke<Void>(0x6DD05E9D83EFA4C9, headDisplayId, username, pointedClanTag, isRockstarClan, clanTag, p5, r, g, b); } // 0x6DD05E9D83EFA4C9
	static void SET_MP_GAMER_TAG_COLOUR(int gamerTagId, int flag, int color) { invoke<Void>(0x613ED644950626AE, gamerTagId, flag, color); } // 0x613ED644950626AE
	static void SET_MP_GAMER_TAG_HEALTH_BAR_COLOUR(int headDisplayId, int color) { invoke<Void>(0x3158C77A7E888AB4, headDisplayId, color); } // 0x3158C77A7E888AB4
	static void _SET_MP_GAMER_TAG_ICONS(int headDisplayId, BOOL p1) { invoke<Void>(0xA67F9C46D612B6F1, headDisplayId, p1); } // 0xA67F9C46D612B6F1
	static void SET_MP_GAMER_TAG_NAME(int gamerTagId, char* string) { invoke<Void>(0xDEA2B8283BAA3944, gamerTagId, string); } // 0xDEA2B8283BAA3944
	static void SET_MP_GAMER_TAG_VISIBILITY(int gamerTagId, int component, BOOL toggle) { invoke<Void>(0x63BB75ABEDC1F6A0, gamerTagId, component, toggle); } // 0x63BB75ABEDC1F6A0
	static void SET_MP_GAMER_TAG_WANTED_LEVEL(int gamerTagId, int wantedlvl) { invoke<Void>(0xCF228E2AA03099C3, gamerTagId, wantedlvl); } // 0xCF228E2AA03099C3
	static void _SET_MP_GAMER_TAG_(int headDisplayId, BOOL p1) { invoke<Void>(0xEE76FF7E6A0166B0, headDisplayId, p1); } // 0xEE76FF7E6A0166B0
	static void SET_MULTIPLAYER_BANK_CASH() { invoke<Void>(0xDD21B55DF695CD0A); } // 0xDD21B55DF695CD0A
	static void SET_MULTIPLAYER_HUD_CASH(int p0, int p1) { invoke<Void>(0xFD1D220394BCB824, p0, p1); } // 0xFD1D220394BCB824
	static void SET_NEW_WAYPOINT(float x, float y) { invoke<Void>(0xFE43368D2AA4F2FC, x, y); } // 0xFE43368D2AA4F2FC
	static void _SET_NORTH_YANKTON_MAP(BOOL toggle) { invoke<Void>(0x9133955F1A2DA957, toggle); } // 0x9133955F1A2DA957
	static void _SET_NOTIFICATION_BACKGROUND_COLOR(int hudIndex) { invoke<Void>(0x92F0DA1E27DB96DC, hudIndex); } // 0x92F0DA1E27DB96DC
	static void _SET_NOTIFICATION_COLOR_NEXT(int hudIndex) { invoke<Void>(0x39BBF623FC803EAC, hudIndex); } // 0x39BBF623FC803EAC
	static void _SET_NOTIFICATION_FLASH_COLOR(int red, int green, int blue, int alpha) { invoke<Void>(0x17430B918701C342, red, green, blue, alpha); } // 0x17430B918701C342
	static int _SET_NOTIFICATION_MESSAGE(char* textureDict, char* textureName, BOOL flash, int iconType, char* sender, char* subject) { return invoke<int>(0x1CCD9A37359072CF, textureDict, textureName, flash, iconType, sender, subject); } // 0x1CCD9A37359072CF
	static int _SET_NOTIFICATION_MESSAGE_CLAN_TAG(char* picName1, char* picName2, BOOL flash, int iconType, char* sender, char* subject, float duration, char* clanTag) { return invoke<int>(0x5CBF7BADE20DB93E, picName1, picName2, flash, iconType, sender, subject, duration, clanTag); } // 0x5CBF7BADE20DB93E
	static int _SET_NOTIFICATION_MESSAGE_CLAN_TAG_2(char* picName1, char* picName2, BOOL flash, int iconType1, char* sender, char* subject, float duration, char* clanTag, int iconType2, int p9) { return invoke<int>(0x531B84E7DA981FB6, picName1, picName2, flash, iconType1, sender, subject, duration, clanTag, iconType2, p9); } // 0x531B84E7DA981FB6
	static int _SET_NOTIFICATION_MESSAGE_2(char* picName1, int picName2, BOOL flash, int iconType, BOOL p4, char* sender, char* subject) { return invoke<int>(0x2B7E9A4EAAA93C89, picName1, picName2, flash, iconType, p4, sender, subject); } // 0x2B7E9A4EAAA93C89
	static int _SET_NOTIFICATION_MESSAGE_3(char* picName1, char* picName2, BOOL p2, Any p3, char* p4, char* p5) { return invoke<int>(0xC6F580E4C94926AC, picName1, picName2, p2, p3, p4, p5); } // 0xC6F580E4C94926AC
	static int _SET_NOTIFICATION_MESSAGE_4(char* picName1, char* picName2, BOOL flash, int iconType, char* sender, char* subject, float duration) { return invoke<int>(0x1E6611149DB3DB6B, picName1, picName2, flash, iconType, sender, subject, duration); } // 0x1E6611149DB3DB6B
	static void _SET_NOTIFICATION_TEXT_ENTRY(char* text) { invoke<Void>(0x202709F4C58A0424, text); } // 0x202709F4C58A0424
	static void SET_PAUSE_MENU_ACTIVE(BOOL toggle) { invoke<Void>(0xDF47FC56C71569CF, toggle); } // 0xDF47FC56C71569CF
	static void SET_PAUSE_MENU_PED_LIGHTING(BOOL state) { invoke<Void>(0x3CA6050692BC61B0, state); } // 0x3CA6050692BC61B0
	static void SET_PAUSE_MENU_PED_SLEEP_STATE(BOOL state) { invoke<Void>(0xECF128344E9FF9F1, state); } // 0xECF128344E9FF9F1
	static void _SET_PED_AI_BLIP(int pedHandle, BOOL showViewCones) { invoke<Void>(0xD30C50DF888D58B5, pedHandle, showViewCones); } // 0xD30C50DF888D58B5
	static void _SET_PLAYER_BLIP_POSITION_THIS_FRAME(float x, float y) { invoke<Void>(0x77E2DD177910E1CF, x, y); } // 0x77E2DD177910E1CF
	static void _SET_PLAYER_CASH_CHANGE(int cash, int bank) { invoke<Void>(0x772DF77852C2E30, cash, bank); } // 0x772DF77852C2E30
	static void SET_RADAR_AS_EXTERIOR_THIS_FRAME() { invoke<Void>(0xE81B7D2A3DAB2D81); } // 0xE81B7D2A3DAB2D81
	static void SET_RADAR_AS_INTERIOR_THIS_FRAME(Hash interior, float x, float y, int heading, int zoom) { invoke<Void>(0x59E727A1C9D3E31A, interior, x, y, heading, zoom); } // 0x59E727A1C9D3E31A
	static void SET_RADAR_ZOOM(int zoomLevel) { invoke<Void>(0x96EF57A0C999BBA, zoomLevel); } // 0x96EF57A0C999BBA
	static void _SET_RADAR_ZOOM_LEVEL_THIS_FRAME(float zoomLevel) { invoke<Void>(0xCB7CC0D58405AD41, zoomLevel); } // 0xCB7CC0D58405AD41
	static void SET_TEXT_CENTRE(BOOL align) { invoke<Void>(0xC02F4DBFB51D988B, align); } // 0xC02F4DBFB51D988B
	static void _SET_TEXT_CHAT_UNK(BOOL p0) { invoke<Void>(0x1DB21A44B09E8BA3, p0); } // 0x1DB21A44B09E8BA3
	static void SET_TEXT_COLOUR(int red, int green, int blue, int alpha) { invoke<Void>(0xBE6B23FFA53FB442, red, green, blue, alpha); } // 0xBE6B23FFA53FB442
	static void SET_TEXT_DROP_SHADOW() { invoke<Void>(0x1CA3E9EAC9D93E5E); } // 0x1CA3E9EAC9D93E5E
	static void SET_TEXT_DROPSHADOW(int distance, int r, int g, int b, int a) { invoke<Void>(0x465C84BC39F1C351, distance, r, g, b, a); } // 0x465C84BC39F1C351
	static void SET_TEXT_EDGE(int p0, int r, int g, int b, int a) { invoke<Void>(0x441603240D202FA6, p0, r, g, b, a); } // 0x441603240D202FA6
	static void SET_TEXT_FONT(int fontType) { invoke<Void>(0x66E0276CC5F6B9DA, fontType); } // 0x66E0276CC5F6B9DA
	static void SET_TEXT_JUSTIFICATION(int justifyType) { invoke<Void>(0x4E096588B13FFECA, justifyType); } // 0x4E096588B13FFECA
	static void SET_TEXT_LEADING(BOOL p0) { invoke<Void>(0xA50ABC31E3CDFAFF, p0); } // 0xA50ABC31E3CDFAFF
	static void SET_TEXT_OUTLINE() { invoke<Void>(0x2513DFB0FB8400FE); } // 0x2513DFB0FB8400FE
	static void SET_TEXT_PROPORTIONAL(BOOL p0) { invoke<Void>(0x38C1F517D7FDCF8, p0); } // 0x38C1F517D7FDCF8
	static void SET_TEXT_RENDER_ID(int renderId) { invoke<Void>(0x5F15302936E07111, renderId); } // 0x5F15302936E07111
	static void SET_TEXT_RIGHT_JUSTIFY(BOOL toggle) { invoke<Void>(0x6B3C4650BC8BEE47, toggle); } // 0x6B3C4650BC8BEE47
	static void SET_TEXT_SCALE(float scale, float size) { invoke<Void>(0x7C837F9A01C34C9, scale, size); } // 0x7C837F9A01C34C9
	static void SET_TEXT_WRAP(float start, float end) { invoke<Void>(0x63145D9C883A1A70, start, end); } // 0x63145D9C883A1A70
	static BOOL SET_USERIDS_UIHIDDEN(Any p0, Any* p1) { return invoke<BOOL>(0xEF4CED81CEBEDC6D, p0, p1); } // 0xEF4CED81CEBEDC6D
	static void SET_WARNING_MESSAGE(char* entryLine1, int instructionalKey, char* entryLine2, BOOL p3, Any p4, Any* background, Any* p6, BOOL p7, Any p8) { invoke<Void>(0x7B1776B3B53F8D74, entryLine1, instructionalKey, entryLine2, p3, p4, background, p6, p7, p8); } // 0x7B1776B3B53F8D74
	static void SET_WARNING_MESSAGE_WITH_HEADER(char* entryHeader, char* entryLine1, int instructionalKey, char* entryLine2, BOOL p4, Any p5, BOOL background, Any* p7, BOOL p8) { invoke<Void>(0xDC38CC1E35B6A5D7, entryHeader, entryLine1, instructionalKey, entryLine2, p4, p5, background, p7, p8); } // 0xDC38CC1E35B6A5D7
	static void _SET_WARNING_MESSAGE_3(char* entryHeader, char* entryLine1, Any instructionalKey, char* entryLine2, BOOL p4, Any p5, Any p6, Any* p7, Any* p8, BOOL p9) { invoke<Void>(0x701919482C74B5AB, entryHeader, entryLine1, instructionalKey, entryLine2, p4, p5, p6, p7, p8, p9); } // 0x701919482C74B5AB
	static void SET_WAYPOINT_OFF() { invoke<Void>(0xA7E4E2D361C2627F); } // 0xA7E4E2D361C2627F
	static void SET_WIDESCREEN_FORMAT(Any p0) { invoke<Void>(0xC3B07BA00A83B0F1, p0); } // 0xC3B07BA00A83B0F1
	static void SHOW_CREW_INDICATOR_ON_BLIP(Blip blip, BOOL toggle) { invoke<Void>(0xDCFB5D4DB8BF367E, blip, toggle); } // 0xDCFB5D4DB8BF367E
	static void _SHOW_CURSOR_THIS_FRAME() { invoke<Void>(0xAAE7CE1D63167423); } // 0xAAE7CE1D63167423
	static void SHOW_FRIEND_INDICATOR_ON_BLIP(Blip blip, BOOL toggle) { invoke<Void>(0x23C3EB807312F01A, blip, toggle); } // 0x23C3EB807312F01A
	static void SHOW_HEADING_INDICATOR_ON_BLIP(Blip blip, BOOL toggle) { invoke<Void>(0x5FBCA48327B914DF, blip, toggle); } // 0x5FBCA48327B914DF
	static void SHOW_HUD_COMPONENT_THIS_FRAME(int id) { invoke<Void>(0xB4DF1FA60C0E664, id); } // 0xB4DF1FA60C0E664
	static void SHOW_NUMBER_ON_BLIP(Blip blip, int number) { invoke<Void>(0xA3C0B359DCB848B6, blip, number); } // 0xA3C0B359DCB848B6
	static void SHOW_OUTLINE_INDICATOR_ON_BLIP(Blip blip, BOOL toggle) { invoke<Void>(0xB81656BC81FE24D1, blip, toggle); } // 0xB81656BC81FE24D1
	static void _SHOW_SOCIAL_CLUB_LEGAL_SCREEN() { invoke<Void>(0x805D7CBB36FD6C4C); } // 0x805D7CBB36FD6C4C
	static void SHOW_TICK_ON_BLIP(Blip blip, BOOL toggle) { invoke<Void>(0x74513EA3E505181E, blip, toggle); } // 0x74513EA3E505181E
	static void _SHOW_WEAPON_WHEEL(BOOL forcedShow) { invoke<Void>(0xEB354E5376BC81A7, forcedShow); } // 0xEB354E5376BC81A7
	static void TOGGLE_STEALTH_RADAR(BOOL toggle) { invoke<Void>(0x6AFDFB93754950C7, toggle); } // 0x6AFDFB93754950C7
	static void UNLOCK_MINIMAP_ANGLE() { invoke<Void>(0x8183455E16C42E3A); } // 0x8183455E16C42E3A
	static void UNLOCK_MINIMAP_POSITION() { invoke<Void>(0x3E93E06DB8EF1F30); } // 0x3E93E06DB8EF1F30
}

namespace INTERIOR
{
	static void ADD_PICKUP_TO_INTERIOR_ROOM_BY_NAME(Pickup pickup, char* roomName) { invoke<Void>(0x3F6167F351168730, pickup, roomName); } // 0x3F6167F351168730
	static BOOL _ARE_COORDS_COLLIDING_WITH_EXTERIOR(float x, float y, float z) { return invoke<BOOL>(0xEEA5AC2EDA7C33E8, x, y, z); } // 0xEEA5AC2EDA7C33E8
	static void CAP_INTERIOR(int interiorID, BOOL toggle) { invoke<Void>(0xD9175F941610DB54, interiorID, toggle); } // 0xD9175F941610DB54
	static void CLEAR_ROOM_FOR_ENTITY(Entity entity) { invoke<Void>(0xB365FC0C4E27FFA7, entity); } // 0xB365FC0C4E27FFA7
	static void DISABLE_INTERIOR(int interiorID, BOOL toggle) { invoke<Void>(0x6170941419D7D8EC, interiorID, toggle); } // 0x6170941419D7D8EC
	static void _DISABLE_INTERIOR_PROP(int interiorID, char* propName) { invoke<Void>(0x420BD37289EEE162, interiorID, propName); } // 0x420BD37289EEE162
	static void _ENABLE_INTERIOR_PROP(int interiorID, char* propName) { invoke<Void>(0x55E86AF2712B36A1, interiorID, propName); } // 0x55E86AF2712B36A1
	static void FORCE_ROOM_FOR_ENTITY(Entity entity, int interiorID, Hash roomHashKey) { invoke<Void>(0x52923C4710DD9907, entity, interiorID, roomHashKey); } // 0x52923C4710DD9907
	static int GET_INTERIOR_AT_COORDS(float x, float y, float z) { return invoke<int>(0xB0F7F8663821D9C3, x, y, z); } // 0xB0F7F8663821D9C3
	static int GET_INTERIOR_AT_COORDS_WITH_TYPE(float x, float y, float z, char* interiorType) { return invoke<int>(0x5B7A89BD78797FC, x, y, z, interiorType); } // 0x5B7A89BD78797FC
	static int GET_INTERIOR_FROM_COLLISION(float x, float y, float z) { return invoke<int>(0xEC4CF9FCB29A4424, x, y, z); } // 0xEC4CF9FCB29A4424
	static int GET_INTERIOR_FROM_ENTITY(Entity entity) { return invoke<int>(0x2107BA504071A6BB, entity); } // 0x2107BA504071A6BB
	static int GET_INTERIOR_GROUP_ID(int interiorID) { return invoke<int>(0xE4A84ABF135EF91A, interiorID); } // 0xE4A84ABF135EF91A
	static Hash GET_KEY_FOR_ENTITY_IN_ROOM(Entity entity) { return invoke<Hash>(0x399685DB942336BC, entity); } // 0x399685DB942336BC
	static Vector3 GET_OFFSET_FROM_INTERIOR_IN_WORLD_COORDS(int interiorID, float x, float y, float z) { return invoke<Vector3>(0x9E3B3E6D66F6E22F, interiorID, x, y, z); } // 0x9E3B3E6D66F6E22F
	static Hash GET_ROOM_KEY_FROM_ENTITY(Entity entity) { return invoke<Hash>(0x47C2A06D4F5F424B, entity); } // 0x47C2A06D4F5F424B
	static Hash _GET_ROOM_KEY_FROM_GAMEPLAY_CAM() { return invoke<Hash>(0xA6575914D2A0B450); } // 0xA6575914D2A0B450
	static void _HIDE_MAP_OBJECT_THIS_FRAME(Hash mapObjectHash) { invoke<Void>(0xA97F257D0151A6AB, mapObjectHash); } // 0xA97F257D0151A6AB
	static BOOL IS_INTERIOR_CAPPED(int interiorID) { return invoke<BOOL>(0x92BAC8ACF88CEC26, interiorID); } // 0x92BAC8ACF88CEC26
	static BOOL IS_INTERIOR_DISABLED(int interiorID) { return invoke<BOOL>(0xBC5115A5A939DD15, interiorID); } // 0xBC5115A5A939DD15
	static BOOL _IS_INTERIOR_PROP_ENABLED(int interiorID, char* propName) { return invoke<BOOL>(0x35F7DD45E8C0A16D, interiorID, propName); } // 0x35F7DD45E8C0A16D
	static BOOL IS_INTERIOR_READY(int interiorID) { return invoke<BOOL>(0x6726BDCCC1932F0E, interiorID); } // 0x6726BDCCC1932F0E
	static BOOL IS_INTERIOR_SCENE() { return invoke<BOOL>(0xBC72B5D7A1CBD54D); } // 0xBC72B5D7A1CBD54D
	static BOOL IS_VALID_INTERIOR(int interiorID) { return invoke<BOOL>(0x26B0E73D7EAAF4D3, interiorID); } // 0x26B0E73D7EAAF4D3
	static void _LOAD_INTERIOR(int interiorID) { invoke<Void>(0x2CA429C029CCF247, interiorID); } // 0x2CA429C029CCF247
	static void _0x23B59D8912F94246() { invoke<Void>(0x23B59D8912F94246); } // 0x23B59D8912F94246
	static void _0x405DC2AEF6AF95B9(Hash roomHashKey) { invoke<Void>(0x405DC2AEF6AF95B9, roomHashKey); } // 0x405DC2AEF6AF95B9
	static void _0x483ACA1176CA93F1() { invoke<Void>(0x483ACA1176CA93F1); } // 0x483ACA1176CA93F1
	static Any _0x4C2330E61D3DEB56(int interiorID) { return invoke<Any>(0x4C2330E61D3DEB56, interiorID); } // 0x4C2330E61D3DEB56
	static void _0x50C375537449F369(Any p0) { invoke<Void>(0x50C375537449F369, p0); } // 0x50C375537449F369
	static void _0x7241CCB7D020DB69(Any p0, Any p1) { invoke<Void>(0x7241CCB7D020DB69, p0, p1); } // 0x7241CCB7D020DB69
	static void _0x82EBB79E258FA2B7(Entity entity, int interiorID) { invoke<Void>(0x82EBB79E258FA2B7, entity, interiorID); } // 0x82EBB79E258FA2B7
	static void _0x920D853F3E17F1DA(int interiorID, Hash roomHashKey) { invoke<Void>(0x920D853F3E17F1DA, interiorID, roomHashKey); } // 0x920D853F3E17F1DA
	static void _0x9E6542F0CE8E70A3(BOOL toggle) { invoke<Void>(0x9E6542F0CE8E70A3, toggle); } // 0x9E6542F0CE8E70A3
	static void _0xAF348AFCB575A441(char* roomName) { invoke<Void>(0xAF348AFCB575A441, roomName); } // 0xAF348AFCB575A441
	static void REFRESH_INTERIOR(int interiorID) { invoke<Void>(0x41F37C3427C75AE0, interiorID); } // 0x41F37C3427C75AE0
	static void _SET_INTERIOR_PROP_COLOR(int interiorID, char* propName, int color) { invoke<Void>(0xC1F1920BAF281317, interiorID, propName, color); } // 0xC1F1920BAF281317
	static int _UNK_GET_INTERIOR_AT_COORDS(float x, float y, float z, int unk) { return invoke<int>(0xF0F77ADB9F67E79D, x, y, z, unk); } // 0xF0F77ADB9F67E79D
	static void UNPIN_INTERIOR(int interiorID) { invoke<Void>(0x261CCE7EED010641, interiorID); } // 0x261CCE7EED010641
}

namespace ITEMSET
{
	static BOOL ADD_TO_ITEMSET(Any p0, Any p1) { return invoke<BOOL>(0xE3945201F14637DD, p0, p1); } // 0xE3945201F14637DD
	static void CLEAN_ITEMSET(Any p0) { invoke<Void>(0x41BC0D722FC04221, p0); } // 0x41BC0D722FC04221
	static Vehicle CREATE_ITEMSET(Vehicle distri) { return invoke<Vehicle>(0x35AD299F50D91B24, distri); } // 0x35AD299F50D91B24
	static void DESTROY_ITEMSET(Any p0) { invoke<Void>(0xDE18220B1C183EDA, p0); } // 0xDE18220B1C183EDA
	static Any GET_INDEXED_ITEM_IN_ITEMSET(Any p0, Any p1) { return invoke<Any>(0x7A197E2521EE2BAB, p0, p1); } // 0x7A197E2521EE2BAB
	static Any GET_ITEMSET_SIZE(ScrHandle x) { return invoke<Any>(0xD9127E83ABF7C631, x); } // 0xD9127E83ABF7C631
	static BOOL IS_IN_ITEMSET(Any p0, Any p1) { return invoke<BOOL>(0x2D0FC594D1E9C107, p0, p1); } // 0x2D0FC594D1E9C107
	static BOOL IS_ITEMSET_VALID(Any p0) { return invoke<BOOL>(0xB1B1EA596344DFAB, p0); } // 0xB1B1EA596344DFAB
	static void REMOVE_FROM_ITEMSET(Any p0, Any p1) { invoke<Void>(0x25E68244B0177686, p0, p1); } // 0x25E68244B0177686
}

namespace LOCALE
{
	static Any _0x497420E022796B3F() { return invoke<Any>(0x497420E022796B3F); } // 0x497420E022796B3F
}

namespace MISC
{
	static float ABSF(float value) { return invoke<float>(0x73D57CFFDD12C355, value); } // 0x73D57CFFDD12C355
	static int ABSI(int value) { return invoke<int>(0xF0D31AD191A74F87, value); } // 0xF0D31AD191A74F87
	static float ACOS(float p0) { return invoke<float>(0x1D08B970013C34B6, p0); } // 0x1D08B970013C34B6
	static int ADD_HOSPITAL_RESTART(float x, float y, float z, float p3, Any p4) { return invoke<int>(0x1F464EF988465A81, x, y, z, p3, p4); } // 0x1F464EF988465A81
	static Any ADD_POLICE_RESTART(float p0, float p1, float p2, float p3, Any p4) { return invoke<Any>(0x452736765B31FC4B, p0, p1, p2, p3, p4); } // 0x452736765B31FC4B
	static int ADD_STUNT_JUMP(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float x4, float y4, float z4, float camX, float camY, float camZ, int unk1, int unk2, int unk3) { return invoke<int>(0x1A992DA297A4630C, x1, y1, z1, x2, y2, z2, x3, y3, z3, x4, y4, z4, camX, camY, camZ, unk1, unk2, unk3); } // 0x1A992DA297A4630C
	static int ADD_STUNT_JUMP_ANGLED(float x1, float y1, float z1, float x2, float y2, float z2, float radius1, float x3, float y3, float z3, float x4, float y4, float z4, float radius2, float camX, float camY, float camZ, int unk1, int unk2, int unk3) { return invoke<int>(0xBBE5D803A5360CBF, x1, y1, z1, x2, y2, z2, radius1, x3, y3, z3, x4, y4, z4, radius2, camX, camY, camZ, unk1, unk2, unk3); } // 0xBBE5D803A5360CBF
	static BOOL ARE_STRINGS_EQUAL(char* string1, char* string2) { return invoke<BOOL>(0xC515FAB3FF9EA92, string1, string2); } // 0xC515FAB3FF9EA92
	static float ASIN(float p0) { return invoke<float>(0xC843060B5765DCE7, p0); } // 0xC843060B5765DCE7
	static float ATAN(float p0) { return invoke<float>(0xA9D1795CD5043663, p0); } // 0xA9D1795CD5043663
	static float ATAN2(float p0, float p1) { return invoke<float>(0x8927CBF9D22261A4, p0, p1); } // 0x8927CBF9D22261A4
	static void BEGIN_REPLAY_STATS(Any p0, Any p1) { invoke<Void>(0xE0E500246FF73D66, p0, p1); } // 0xE0E500246FF73D66
	static void CANCEL_STUNT_JUMP() { invoke<Void>(0xE6B7B0ACD4E4B75E); } // 0xE6B7B0ACD4E4B75E
	static void CLEAR_ANGLED_AREA_OF_VEHICLES(float p0, float p1, float p2, float p3, float p4, float p5, float p6, BOOL p7, BOOL p8, BOOL p9, BOOL p10, BOOL p11) { invoke<Void>(0x11DB3500F042A8AA, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); } // 0x11DB3500F042A8AA
	static void CLEAR_AREA(float X, float Y, float Z, float radius, BOOL p4, BOOL ignoreCopCars, BOOL ignoreObjects, BOOL p7) { invoke<Void>(0xA56F01F3765B93A0, X, Y, Z, radius, p4, ignoreCopCars, ignoreObjects, p7); } // 0xA56F01F3765B93A0
	static void CLEAR_AREA_OF_COPS(float x, float y, float z, float radius, int flags) { invoke<Void>(0x4F8FC8FCF58F88D, x, y, z, radius, flags); } // 0x4F8FC8FCF58F88D
	static void _CLEAR_AREA_OF_EVERYTHING(float x, float y, float z, float radius, BOOL p4, BOOL p5, BOOL p6, BOOL p7) { invoke<Void>(0x957838AAF91BD12D, x, y, z, radius, p4, p5, p6, p7); } // 0x957838AAF91BD12D
	static void CLEAR_AREA_OF_OBJECTS(float x, float y, float z, float radius, int flags) { invoke<Void>(0xDD9B9B385AAC7F5B, x, y, z, radius, flags); } // 0xDD9B9B385AAC7F5B
	static void CLEAR_AREA_OF_PEDS(float x, float y, float z, float radius, int flags) { invoke<Void>(0xBE31FD6CE464AC59, x, y, z, radius, flags); } // 0xBE31FD6CE464AC59
	static void CLEAR_AREA_OF_PROJECTILES(float x, float y, float z, float radius, BOOL isNetworkGame) { invoke<Void>(0xA1CB9094635D1A6, x, y, z, radius, isNetworkGame); } // 0xA1CB9094635D1A6
	static void CLEAR_AREA_OF_VEHICLES(float x, float y, float z, float radius, BOOL p4, BOOL p5, BOOL p6, BOOL p7, BOOL p8) { invoke<Void>(0x1C7B9B38428AEB6, x, y, z, radius, p4, p5, p6, p7, p8); } // 0x1C7B9B38428AEB6
	static void CLEAR_BIT(int* address, int offset) { invoke<Void>(0xE80492A9AC099A93, address, offset); } // 0xE80492A9AC099A93
	static void _CLEAR_CLOUD_HAT() { invoke<Void>(0x957E790EA1727B64); } // 0x957E790EA1727B64
	static void CLEAR_OVERRIDE_WEATHER() { invoke<Void>(0x338D2E3477711050); } // 0x338D2E3477711050
	static void CLEAR_REPLAY_STATS() { invoke<Void>(0x1B1AB132A16FDA55); } // 0x1B1AB132A16FDA55
	static void CLEAR_WEATHER_TYPE_PERSIST() { invoke<Void>(0xCCC39339BEF76CF5); } // 0xCCC39339BEF76CF5
	static int COMPARE_STRINGS(char* str1, char* str2, BOOL matchCase, int maxLength) { return invoke<int>(0x1E34710ECD4AB0EB, str1, str2, matchCase, maxLength); } // 0x1E34710ECD4AB0EB
	static BOOL CREATE_INCIDENT(int incidentType, float x, float y, float z, int p5, float radius, int* outIncidentID) { return invoke<BOOL>(0x3F892CAF67444AE7, incidentType, x, y, z, p5, radius, outIncidentID); } // 0x3F892CAF67444AE7
	static BOOL CREATE_INCIDENT_WITH_ENTITY(int incidentType, Ped ped, int amountOfPeople, float radius, int* outIncidentID) { return invoke<BOOL>(0x5983472F0494E60, incidentType, ped, amountOfPeople, radius, outIncidentID); } // 0x5983472F0494E60
	static void _CREATE_LIGHTNING_THUNDER() { invoke<Void>(0xF6062E089251C898); } // 0xF6062E089251C898
	static void DELETE_INCIDENT(int incidentId) { invoke<Void>(0x556C1AA270D5A207, incidentId); } // 0x556C1AA270D5A207
	static void DELETE_STUNT_JUMP(int p0) { invoke<Void>(0xDC518000E39DAE1F, p0); } // 0xDC518000E39DAE1F
	static void _DISABLE_AUTOMATIC_RESPAWN(BOOL disableRespawn) { invoke<Void>(0x2C2B3493FBF51C71, disableRespawn); } // 0x2C2B3493FBF51C71
	static void DISABLE_HOSPITAL_RESTART(int hospitalIndex, BOOL toggle) { invoke<Void>(0xC8535819C450EBA8, hospitalIndex, toggle); } // 0xC8535819C450EBA8
	static void DISABLE_POLICE_RESTART(int policeIndex, BOOL toggle) { invoke<Void>(0x23285DED6EBD7EA3, policeIndex, toggle); } // 0x23285DED6EBD7EA3
	static void DISABLE_STUNT_JUMP_SET(int p0) { invoke<Void>(0xA5272EBEDD4747F6, p0); } // 0xA5272EBEDD4747F6
	static void DISPLAY_ONSCREEN_KEYBOARD(int p0, char* windowTitle, char* p2, char* defaultText, char* defaultConcat1, char* defaultConcat2, char* defaultConcat3, int maxInputLength) { invoke<Void>(0xDC833F2568DBF6, p0, windowTitle, p2, defaultText, defaultConcat1, defaultConcat2, defaultConcat3, maxInputLength); } // 0xDC833F2568DBF6
	static void _DISPLAY_ONSCREEN_KEYBOARD_2(int p0, char* windowTitle, Any* p2, char* defaultText, char* defaultConcat1, char* defaultConcat2, char* defaultConcat3, char* defaultConcat4, char* defaultConcat5, char* defaultConcat6, char* defaultConcat7, int maxInputLength) { invoke<Void>(0xCA78CFA0366592FE, p0, windowTitle, p2, defaultText, defaultConcat1, defaultConcat2, defaultConcat3, defaultConcat4, defaultConcat5, defaultConcat6, defaultConcat7, maxInputLength); } // 0xCA78CFA0366592FE
	static void DO_AUTO_SAVE() { invoke<Void>(0x50EEAAD86232EE55); } // 0x50EEAAD86232EE55
	static void ENABLE_DISPATCH_SERVICE(int dispatchService, BOOL toggle) { invoke<Void>(0xDC0F817884CDD856, dispatchService, toggle); } // 0xDC0F817884CDD856
	static void ENABLE_STUNT_JUMP_SET(int p0) { invoke<Void>(0xE369A5783B866016, p0); } // 0xE369A5783B866016
	static void ENABLE_TENNIS_MODE(Ped ped, BOOL toggle, BOOL p2) { invoke<Void>(0x28A04B411933F8A6, ped, toggle, p2); } // 0x28A04B411933F8A6
	static void END_REPLAY_STATS() { invoke<Void>(0xA23E821FBDF8A5F2); } // 0xA23E821FBDF8A5F2
	static BOOL FIND_SPAWN_POINT_IN_DIRECTION(float x1, float y1, float z1, float x2, float y2, float z2, float distance, Vector3* spawnPoint) { return invoke<BOOL>(0x6874E2190B0C1972, x1, y1, z1, x2, y2, z2, distance, spawnPoint); } // 0x6874E2190B0C1972
	static void _FORCE_SOCIAL_CLUB_UPDATE() { invoke<Void>(0xEB6891F03362FB12); } // 0xEB6891F03362FB12
	static int GET_ALLOCATED_STACK_SIZE() { return invoke<int>(0x8B3CA62B1EF19B62); } // 0x8B3CA62B1EF19B62
	static float GET_ANGLE_BETWEEN_2D_VECTORS(float x1, float y1, float x2, float y2) { return invoke<float>(0x186FC4BE848E1C92, x1, y1, x2, y2); } // 0x186FC4BE848E1C92
	static float _GET_BENCHMARK_TIME() { return invoke<float>(0xE599A503B3837E1B); } // 0xE599A503B3837E1B
	static int GET_BITS_IN_RANGE(int var, int rangeStart, int rangeEnd) { return invoke<int>(0x53158863FCC0893A, var, rangeStart, rangeEnd); } // 0x53158863FCC0893A
	static float _GET_CLOUD_HAT_OPACITY() { return invoke<float>(0x20AC25E781AE4A84); } // 0x20AC25E781AE4A84
	static float GET_DISTANCE_BETWEEN_COORDS(float x1, float y1, float z1, float x2, float y2, float z2, BOOL useZ) { return invoke<float>(0xF1B760881820C952, x1, y1, z1, x2, y2, z2, useZ); } // 0xF1B760881820C952
	static int GET_FAKE_WANTED_LEVEL() { return invoke<int>(0x4C9296CBCD1B971E); } // 0x4C9296CBCD1B971E
	static int GET_FRAME_COUNT() { return invoke<int>(0xFC8202EFC642E6F2); } // 0xFC8202EFC642E6F2
	static float GET_FRAME_TIME() { return invoke<float>(0x15C40837039FFAF7); } // 0x15C40837039FFAF7
	static int _GET_FREE_STACK_SLOTS_COUNT(int threadId) { return invoke<int>(0xFEAD16FC8F9DFC0F, threadId); } // 0xFEAD16FC8F9DFC0F
	static int GET_GAME_TIMER() { return invoke<int>(0x9CD27B0045628463); } // 0x9CD27B0045628463
	static char* _GET_GLOBAL_CHAR_BUFFER() { return invoke<char*>(0x24DA7D7667FD7B09); } // 0x24DA7D7667FD7B09
	static BOOL _GET_GROUND_Z_COORD_WITH_OFFSETS(float x, float y, float z, float* groundZ, Vector3* offsets) { return invoke<BOOL>(0x8BDC7BFC57A81E76, x, y, z, groundZ, offsets); } // 0x8BDC7BFC57A81E76
	static BOOL GET_GROUND_Z_FOR_3D_COORD(float x, float y, float z, float* groundZ, BOOL unk) { return invoke<BOOL>(0xC906A7DAB05C8D2B, x, y, z, groundZ, unk); } // 0xC906A7DAB05C8D2B
	static Hash GET_HASH_KEY(char* string) { return invoke<Hash>(0xD24D37CC275948CC, string); } // 0xD24D37CC275948CC
	static float GET_HEADING_FROM_VECTOR_2D(float dx, float dy) { return invoke<float>(0x2FFB6B224F4B2926, dx, dy); } // 0x2FFB6B224F4B2926
	static int GET_INDEX_OF_CURRENT_LEVEL() { return invoke<int>(0xCBAD6729F7B1F4FC); } // 0xCBAD6729F7B1F4FC
	static BOOL _GET_IS_PROJECTILE_TYPE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, Hash projHash, Vector3* projPos, BOOL ownedByPlayer) { return invoke<BOOL>(0x8D7A43EC6A5FEA45, x1, y1, z1, x2, y2, z2, projHash, projPos, ownedByPlayer); } // 0x8D7A43EC6A5FEA45
	static BOOL GET_MISSION_FLAG() { return invoke<BOOL>(0xA33CDCCDA663159E); } // 0xA33CDCCDA663159E
	static void GET_MODEL_DIMENSIONS(Hash modelHash, Vector3* minimum, Vector3* maximum) { invoke<Void>(0x3E8D3D5F549087A, modelHash, minimum, maximum); } // 0x3E8D3D5F549087A
	static Hash GET_NEXT_WEATHER_TYPE_HASH_NAME() { return invoke<Hash>(0x711327CD09C8F162); } // 0x711327CD09C8F162
	static int _GET_NUMBER_OF_DISPATCHED_UNITS_FOR_PLAYER(int dispatchService) { return invoke<int>(0xEB4A0C2D56441717, dispatchService); } // 0xEB4A0C2D56441717
	static char* GET_ONSCREEN_KEYBOARD_RESULT() { return invoke<char*>(0x8362B09B91893647); } // 0x8362B09B91893647
	static Hash GET_PREV_WEATHER_TYPE_HASH_NAME() { return invoke<Hash>(0x564B884A05EC45A3); } // 0x564B884A05EC45A3
	static int GET_PROFILE_SETTING(int profileSetting) { return invoke<int>(0xC488FF2356EA7791, profileSetting); } // 0xC488FF2356EA7791
	static BOOL _GET_PROJECTILE_NEAR_PED(Ped ped, Hash projHash, float radius, Vector3* projPos, Entity* projEnt, BOOL ownedByPlayer) { return invoke<BOOL>(0x82FDE6A57EE4EE44, ped, projHash, radius, projPos, projEnt, ownedByPlayer); } // 0x82FDE6A57EE4EE44
	static BOOL _GET_PROJECTILE_NEAR_PED_COORDS(Ped ped, Hash projHash, float radius, Vector3* projPos, BOOL ownedByPlayer) { return invoke<BOOL>(0xDFB4138EEFED7B81, ped, projHash, radius, projPos, ownedByPlayer); } // 0xDFB4138EEFED7B81
	static Any* GET_RAIN_LEVEL() { return invoke<Any*>(0x96695E368AD855F3); } // 0x96695E368AD855F3
	static Any GET_RANDOM_EVENT_FLAG() { return invoke<Any>(0xD2D57F1D764117B1); } // 0xD2D57F1D764117B1
	static float GET_RANDOM_FLOAT_IN_RANGE(float startRange, float endRange) { return invoke<float>(0x313CE5879CEB6FCD, startRange, endRange); } // 0x313CE5879CEB6FCD
	static int GET_RANDOM_INT_IN_RANGE(int startRange, int endRange) { return invoke<int>(0xD53343AA4FB7DD28, startRange, endRange); } // 0xD53343AA4FB7DD28
	static Any GET_SNOW_LEVEL() { return invoke<Any>(0xC5868A966E5BE3AE); } // 0xC5868A966E5BE3AE
	static void _GET_WEATHER_TYPE_TRANSITION(Hash* weatherType1, Hash* weatherType2, float* percentWeather2) { invoke<Void>(0xF3BBE884A14BB413, weatherType1, weatherType2, percentWeather2); } // 0xF3BBE884A14BB413
	static Vector3 GET_WIND_DIRECTION() { return invoke<Vector3>(0x1F400FEF721170DA); } // 0x1F400FEF721170DA
	static float GET_WIND_SPEED() { return invoke<float>(0xA8CF1CC0AFCD3F12); } // 0xA8CF1CC0AFCD3F12
	static BOOL HAS_BULLET_IMPACTED_IN_AREA(float x, float y, float z, float p3, BOOL p4, BOOL p5) { return invoke<BOOL>(0x9870ACFB89A90995, x, y, z, p3, p4, p5); } // 0x9870ACFB89A90995
	static BOOL HAS_BULLET_IMPACTED_IN_BOX(float p0, float p1, float p2, float p3, float p4, float p5, BOOL p6, BOOL p7) { return invoke<BOOL>(0xDC8C5D7CFEAB8394, p0, p1, p2, p3, p4, p5, p6, p7); } // 0xDC8C5D7CFEAB8394
	static BOOL _HAS_BUTTON_COMBINATION_JUST_BEEN_ENTERED(Hash hash, int amount) { return invoke<BOOL>(0x71E2A839DE82D90, hash, amount); } // 0x71E2A839DE82D90
	static BOOL _HAS_CHEAT_STRING_JUST_BEEN_ENTERED(Hash hash) { return invoke<BOOL>(0x557E43C447E700A8, hash); } // 0x557E43C447E700A8
	static void IGNORE_NEXT_RESTART(BOOL toggle) { invoke<Void>(0x21FFB63D8C615361, toggle); } // 0x21FFB63D8C615361
	static BOOL IS_AREA_OCCUPIED(float p0, float p1, float p2, float p3, float p4, float p5, BOOL p6, BOOL p7, BOOL p8, BOOL p9, BOOL p10, Any p11, BOOL p12) { return invoke<BOOL>(0xA61B4DF533DCB56E, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12); } // 0xA61B4DF533DCB56E
	static BOOL IS_AUSSIE_VERSION() { return invoke<BOOL>(0x9F1935CA1F724008); } // 0x9F1935CA1F724008
	static BOOL IS_AUTO_SAVE_IN_PROGRESS() { return invoke<BOOL>(0x69240733738C19A0); } // 0x69240733738C19A0
	static BOOL IS_BIT_SET(int address, int offset) { return invoke<BOOL>(0xA921AA820C25702F, address, offset); } // 0xA921AA820C25702F
	static BOOL IS_BULLET_IN_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, BOOL p7) { return invoke<BOOL>(0x1A8B5F3C01E2B477, p0, p1, p2, p3, p4, p5, p6, p7); } // 0x1A8B5F3C01E2B477
	static BOOL IS_BULLET_IN_AREA(float p0, float p1, float p2, float p3, BOOL p4) { return invoke<BOOL>(0x3F2023999AD51C1F, p0, p1, p2, p3, p4); } // 0x3F2023999AD51C1F
	static BOOL IS_BULLET_IN_BOX(float p0, float p1, float p2, float p3, float p4, float p5, BOOL p6) { return invoke<BOOL>(0xDE0F6D7450D37351, p0, p1, p2, p3, p4, p5, p6); } // 0xDE0F6D7450D37351
	static BOOL IS_DURANGO_VERSION() { return invoke<BOOL>(0x4D982ADB1978442D); } // 0x4D982ADB1978442D
	static BOOL IS_FRONTEND_FADING() { return invoke<BOOL>(0x7EA2B6AF97ECA6ED); } // 0x7EA2B6AF97ECA6ED
	static BOOL IS_INCIDENT_VALID(int incidentId) { return invoke<BOOL>(0xC8BC6461E629BEAA, incidentId); } // 0xC8BC6461E629BEAA
	static BOOL IS_MEMORY_CARD_IN_USE() { return invoke<BOOL>(0x8A75CE2956274ADD); } // 0x8A75CE2956274ADD
	static BOOL IS_MINIGAME_IN_PROGRESS() { return invoke<BOOL>(0x2B4A15E44DE0F478); } // 0x2B4A15E44DE0F478
	static BOOL IS_NEXT_WEATHER_TYPE(char* weatherType) { return invoke<BOOL>(0x2FAA3A30BEC0F25D, weatherType); } // 0x2FAA3A30BEC0F25D
	static BOOL IS_ORBIS_VERSION() { return invoke<BOOL>(0xA72BC0B675B1519E); } // 0xA72BC0B675B1519E
	static BOOL IS_PC_VERSION() { return invoke<BOOL>(0x48AF36444B965238); } // 0x48AF36444B965238
	static BOOL IS_POINT_OBSCURED_BY_A_MISSION_ENTITY(float p0, float p1, float p2, float p3, float p4, float p5, Any p6) { return invoke<BOOL>(0xE54E209C35FFA18D, p0, p1, p2, p3, p4, p5, p6); } // 0xE54E209C35FFA18D
	static BOOL IS_POSITION_OCCUPIED(float x, float y, float z, float range, BOOL p4, BOOL p5, BOOL p6, BOOL p7, BOOL p8, Any p9, BOOL p10) { return invoke<BOOL>(0xADCDE75E1C60F32D, x, y, z, range, p4, p5, p6, p7, p8, p9, p10); } // 0xADCDE75E1C60F32D
	static BOOL IS_PREV_WEATHER_TYPE(char* weatherType) { return invoke<BOOL>(0x44F28F86433B10A9, weatherType); } // 0x44F28F86433B10A9
	static BOOL IS_PROJECTILE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL ownedByPlayer) { return invoke<BOOL>(0x5270A8FBC098C3F8, x1, y1, z1, x2, y2, z2, ownedByPlayer); } // 0x5270A8FBC098C3F8
	static BOOL IS_PROJECTILE_TYPE_IN_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, Any p7, BOOL p8) { return invoke<BOOL>(0xF0BC12401061DEA0, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0xF0BC12401061DEA0
	static BOOL IS_PROJECTILE_TYPE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, int type, BOOL p7) { return invoke<BOOL>(0x2E0DC353342C4A6D, x1, y1, z1, x2, y2, z2, type, p7); } // 0x2E0DC353342C4A6D
	static BOOL _IS_PROJECTILE_TYPE_IN_RADIUS(float x, float y, float z, Hash projHash, float radius, BOOL ownedByPlayer) { return invoke<BOOL>(0x34318593248C8FB2, x, y, z, projHash, radius, ownedByPlayer); } // 0x34318593248C8FB2
	static BOOL IS_PS3_VERSION() { return invoke<BOOL>(0xCCA1072C29D096C2); } // 0xCCA1072C29D096C2
	static BOOL IS_SNIPER_BULLET_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2) { return invoke<BOOL>(0xFEFCF11B01287125, x1, y1, z1, x2, y2, z2); } // 0xFEFCF11B01287125
	static BOOL IS_SNIPER_INVERTED() { return invoke<BOOL>(0x61A23B7EDA9BDA24); } // 0x61A23B7EDA9BDA24
	static BOOL IS_STRING_NULL(char* string) { return invoke<BOOL>(0xF22B6C47C6EAB066, string); } // 0xF22B6C47C6EAB066
	static BOOL IS_STRING_NULL_OR_EMPTY(char* string) { return invoke<BOOL>(0xCA042B6957743895, string); } // 0xCA042B6957743895
	static BOOL IS_STUNT_JUMP_IN_PROGRESS() { return invoke<BOOL>(0x7A3F19700A4D0525); } // 0x7A3F19700A4D0525
	static BOOL IS_STUNT_JUMP_MESSAGE_SHOWING() { return invoke<BOOL>(0x2272B0A1343129F4); } // 0x2272B0A1343129F4
	static BOOL IS_TENNIS_MODE(Ped ped) { return invoke<BOOL>(0x5D5479D115290C3F, ped); } // 0x5D5479D115290C3F
	static BOOL IS_THIS_A_MINIGAME_SCRIPT() { return invoke<BOOL>(0x7B30F65D7B710098); } // 0x7B30F65D7B710098
	static BOOL IS_XBOX360_VERSION() { return invoke<BOOL>(0xF6201B4DAF662A9D); } // 0xF6201B4DAF662A9D
	static void NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME() { invoke<Void>(0x9243BAC96D64C050); } // 0x9243BAC96D64C050
	static void _0x02DEAAC8F8EA7FE7(char* p0) { invoke<Void>(0x2DEAAC8F8EA7FE7, p0); } // 0x2DEAAC8F8EA7FE7
	static void _0x06462A961E94B67C() { invoke<Void>(0x6462A961E94B67C); } // 0x6462A961E94B67C
	static Any _0x075F1D57402C93BA() { return invoke<Any>(0x75F1D57402C93BA); } // 0x75F1D57402C93BA
	static void _0x0A60017F841A54F2(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xA60017F841A54F2, p0, p1, p2, p3); } // 0xA60017F841A54F2
	static void _0x0CF97F497FE7D048(Any p0) { invoke<Void>(0xCF97F497FE7D048, p0); } // 0xCF97F497FE7D048
	static void _0x11B56FBBF7224868(char* p0) { invoke<Void>(0x11B56FBBF7224868, p0); } // 0x11B56FBBF7224868
	static BOOL _0x1327E2FE9746BAEE(Any p0) { return invoke<BOOL>(0x1327E2FE9746BAEE, p0); } // 0x1327E2FE9746BAEE
	static Any _0x14832BF2ABA53FC5() { return invoke<Any>(0x14832BF2ABA53FC5); } // 0x14832BF2ABA53FC5
	static Any _0x171BAFB3C60389F4(Any p0) { return invoke<Any>(0x171BAFB3C60389F4, p0); } // 0x171BAFB3C60389F4
	static BOOL _0x17DF68D720AA77F8(Any p0) { return invoke<BOOL>(0x17DF68D720AA77F8, p0); } // 0x17DF68D720AA77F8
	static BOOL _0x19BFED045C647C49(Any p0) { return invoke<BOOL>(0x19BFED045C647C49, p0); } // 0x19BFED045C647C49
	static Any _0x1B2366C3F2A5C8DF() { return invoke<Any>(0x1B2366C3F2A5C8DF); } // 0x1B2366C3F2A5C8DF
	static void _0x1BB299305C3E8C13(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x1BB299305C3E8C13, p0, p1, p2, p3); } // 0x1BB299305C3E8C13
	static void _0x1EAE0A6E978894A2(int p0, BOOL p1) { invoke<Void>(0x1EAE0A6E978894A2, p0, p1); } // 0x1EAE0A6E978894A2
	static void _0x1FF6BF9A63E5757F() { invoke<Void>(0x1FF6BF9A63E5757F); } // 0x1FF6BF9A63E5757F
	static Any _0x2107A3773771186D() { return invoke<Any>(0x2107A3773771186D); } // 0x2107A3773771186D
	static void _0x213AEB2B90CBA7AC(Any p0, Any p1, Any p2) { invoke<Void>(0x213AEB2B90CBA7AC, p0, p1, p2); } // 0x213AEB2B90CBA7AC
	static Vector3 _0x21C235BC64831E5A(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, BOOL p9) { return invoke<Vector3>(0x21C235BC64831E5A, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); } // 0x21C235BC64831E5A
	static void _0x23227DF0B2115469() { invoke<Void>(0x23227DF0B2115469); } // 0x23227DF0B2115469
	static void _0x2587A48BC88DFADF(BOOL p0) { invoke<Void>(0x2587A48BC88DFADF, p0); } // 0x2587A48BC88DFADF
	static Any _0x2B5E102E4A42F2BF() { return invoke<Any>(0x2B5E102E4A42F2BF); } // 0x2B5E102E4A42F2BF
	static Any _0x2B626A0150E4D449() { return invoke<Any>(0x2B626A0150E4D449); } // 0x2B626A0150E4D449
	static Any _0x2D4259F1FEB81DA9(float p0, float p1, float p2, float p3) { return invoke<Any>(0x2D4259F1FEB81DA9, p0, p1, p2, p3); } // 0x2D4259F1FEB81DA9
	static void _0x31125FD509D9043F(Any* p0) { invoke<Void>(0x31125FD509D9043F, p0); } // 0x31125FD509D9043F
	static void _0x31727907B2C43C55(float p0) { invoke<Void>(0x31727907B2C43C55, p0); } // 0x31727907B2C43C55
	static Any _0x32C7A7E8C43A1F80(float p0, float p1, float p2, float p3, float p4, float p5, BOOL p6, BOOL p7) { return invoke<Any>(0x32C7A7E8C43A1F80, p0, p1, p2, p3, p4, p5, p6, p7); } // 0x32C7A7E8C43A1F80
	static void _0x37DEB0AA183FB6D8() { invoke<Void>(0x37DEB0AA183FB6D8); } // 0x37DEB0AA183FB6D8
	static int _0x397BAA01068BAA96() { return invoke<int>(0x397BAA01068BAA96); } // 0x397BAA01068BAA96
	static Any _0x3BBBD13E5041A79E() { return invoke<Any>(0x3BBBD13E5041A79E); } // 0x3BBBD13E5041A79E
	static void _0x3ED1438C1F5C6612(int p0) { invoke<Void>(0x3ED1438C1F5C6612, p0); } // 0x3ED1438C1F5C6612
	static void _0x405591EC8FD9096D(float p0) { invoke<Void>(0x405591EC8FD9096D, p0); } // 0x405591EC8FD9096D
	static void _0x437138B6A830166A() { invoke<Void>(0x437138B6A830166A); } // 0x437138B6A830166A
	static void _0x438822C279B73B93(Any p0) { invoke<Void>(0x438822C279B73B93, p0); } // 0x438822C279B73B93
	static Any _0x44A0BDC559B35F6E() { return invoke<Any>(0x44A0BDC559B35F6E); } // 0x44A0BDC559B35F6E
	static Any _0x4750FC27570311EC() { return invoke<Any>(0x4750FC27570311EC); } // 0x4750FC27570311EC
	static void _0x48F069265A0E4BEC(Any* p0, char* name) { invoke<Void>(0x48F069265A0E4BEC, p0, name); } // 0x48F069265A0E4BEC
	static void _0x4DCDF92BF64236CD(char* p0, char* p1) { invoke<Void>(0x4DCDF92BF64236CD, p0, p1); } // 0x4DCDF92BF64236CD
	static void _0x54F157E0336A3822(Any p0, char* p1, float p2) { invoke<Void>(0x54F157E0336A3822, p0, p1, p2); } // 0x54F157E0336A3822
	static void _0x58A39BE597CE99CD() { invoke<Void>(0x58A39BE597CE99CD); } // 0x58A39BE597CE99CD
	static Any _0x5AA3BEFA29F03AD4() { return invoke<Any>(0x5AA3BEFA29F03AD4); } // 0x5AA3BEFA29F03AD4
	static Any _0x5B1F2E327B6B6FE1() { return invoke<Any>(0x5B1F2E327B6B6FE1); } // 0x5B1F2E327B6B6FE1
	static void _0x6216B116083A7CB4(float p0) { invoke<Void>(0x6216B116083A7CB4, p0); } // 0x6216B116083A7CB4
	static void _0x65D2EBB47E1CEC21(BOOL p0) { invoke<Void>(0x65D2EBB47E1CEC21, p0); } // 0x65D2EBB47E1CEC21
	static Any _0x67F6413D3220E18D(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { return invoke<Any>(0x67F6413D3220E18D, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0x67F6413D3220E18D
	static BOOL _0x684A41975F077262() { return invoke<BOOL>(0x684A41975F077262); } // 0x684A41975F077262
	static int _0x6856EC3D35C81EA4() { return invoke<int>(0x6856EC3D35C81EA4); } // 0x6856EC3D35C81EA4
	static void _0x693478ACBD7F18E7() { invoke<Void>(0x693478ACBD7F18E7); } // 0x693478ACBD7F18E7
	static void _0x69FE6DC87BD2A5E9(Any p0) { invoke<Void>(0x69FE6DC87BD2A5E9, p0); } // 0x69FE6DC87BD2A5E9
	static Any _0x6E04F06094C87047() { return invoke<Any>(0x6E04F06094C87047); } // 0x6E04F06094C87047
	static void _0x6F2135B6129620C1(BOOL p0) { invoke<Void>(0x6F2135B6129620C1, p0); } // 0x6F2135B6129620C1
	static void _0x6F7794F28C6B2535(Any* p0, char* name) { invoke<Void>(0x6F7794F28C6B2535, p0, name); } // 0x6F7794F28C6B2535
	static BOOL _0x6FDDF453C0C756EC() { return invoke<BOOL>(0x6FDDF453C0C756EC); } // 0x6FDDF453C0C756EC
	static void _0x703CC7F60CBB2B57(Any p0) { invoke<Void>(0x703CC7F60CBB2B57, p0); } // 0x703CC7F60CBB2B57
	static Any _0x72DE52178C291CB5() { return invoke<Any>(0x72DE52178C291CB5); } // 0x72DE52178C291CB5
	static void _0x7C9C0B1EEB1F9072(float p0) { invoke<Void>(0x7C9C0B1EEB1F9072, p0); } // 0x7C9C0B1EEB1F9072
	static void _0x7EC6F9A478A6A512() { invoke<Void>(0x7EC6F9A478A6A512); } // 0x7EC6F9A478A6A512
	static float _0x7F8F6405F4777AF6(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, BOOL p9) { return invoke<float>(0x7F8F6405F4777AF6, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); } // 0x7F8F6405F4777AF6
	static Any _0x8098C8D6597AAE18(Any p0) { return invoke<Any>(0x8098C8D6597AAE18, p0); } // 0x8098C8D6597AAE18
	static void _0x8269816F6CFD40F8(Any* p0, char* name) { invoke<Void>(0x8269816F6CFD40F8, p0, name); } // 0x8269816F6CFD40F8
	static void _0x8951EB9C6906D3C8() { invoke<Void>(0x8951EB9C6906D3C8); } // 0x8951EB9C6906D3C8
	static void _0x8D74E26F54B4E5C3(char* p0) { invoke<Void>(0x8D74E26F54B4E5C3, p0); } // 0x8D74E26F54B4E5C3
	static BOOL _0x8EF5573A1F801A5C(Any p0, Any* p1, Any* p2) { return invoke<BOOL>(0x8EF5573A1F801A5C, p0, p1, p2); } // 0x8EF5573A1F801A5C
	static void _0x8FA9C42FC5D7C64B(Any p0, Any p1, float p2, float p3, float p4, BOOL p5) { invoke<Void>(0x8FA9C42FC5D7C64B, p0, p1, p2, p3, p4, p5); } // 0x8FA9C42FC5D7C64B
	static Any _0x918C7B2D2FF3928B(float p0, float p1, float p2, float p3, float p4, float p5, float p6) { return invoke<Any>(0x918C7B2D2FF3928B, p0, p1, p2, p3, p4, p5, p6); } // 0x918C7B2D2FF3928B
	static void _0x92790862E36C2ADA() { invoke<Void>(0x92790862E36C2ADA); } // 0x92790862E36C2ADA
	static BOOL _0x9689123E3F213AA5() { return invoke<BOOL>(0x9689123E3F213AA5); } // 0x9689123E3F213AA5
	static void _0x97E7E2C04245115B(Any p0) { invoke<Void>(0x97E7E2C04245115B, p0); } // 0x97E7E2C04245115B
	static int _0x996DD1E1E02F1008() { return invoke<int>(0x996DD1E1E02F1008); } // 0x996DD1E1E02F1008
	static void _0x9B2BD3773123EA2F(int type, BOOL toggle) { invoke<Void>(0x9B2BD3773123EA2F, type, toggle); } // 0x9B2BD3773123EA2F
	static void _0x9D8D44ADBBA61EF2(BOOL p0) { invoke<Void>(0x9D8D44ADBBA61EF2, p0); } // 0x9D8D44ADBBA61EF2
	static Any _0x9E82F0F362881B29(Any p0, Any p1, Any p2, Any p3, Any p4) { return invoke<Any>(0x9E82F0F362881B29, p0, p1, p2, p3, p4); } // 0x9E82F0F362881B29
	static void _0x9F5E6BB6B34540DA(float p0) { invoke<Void>(0x9F5E6BB6B34540DA, p0); } // 0x9F5E6BB6B34540DA
	static BOOL _0xA049A5BE0F04F2F8() { return invoke<BOOL>(0xA049A5BE0F04F2F8); } // 0xA049A5BE0F04F2F8
	static int _0xA09F896CE912481F(BOOL p0) { return invoke<int>(0xA09F896CE912481F, p0); } // 0xA09F896CE912481F
	static Any _0xA4A0065E39C9F25C(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0xA4A0065E39C9F25C, p0, p1, p2, p3); } // 0xA4A0065E39C9F25C
	static void _0xA735353C77334EA0(Any* p0, Any* p1) { invoke<Void>(0xA735353C77334EA0, p0, p1); } // 0xA735353C77334EA0
	static void _0xA74802FB8D0B7814(char* p0, float p1) { invoke<Void>(0xA74802FB8D0B7814, p0, p1); } // 0xA74802FB8D0B7814
	static void _0xA7A1127490312C36(float p0) { invoke<Void>(0xA7A1127490312C36, p0); } // 0xA7A1127490312C36
	static void _0xA8434F1DFF41D6E7(float p0) { invoke<Void>(0xA8434F1DFF41D6E7, p0); } // 0xA8434F1DFF41D6E7
	static Any _0xABB2FA71C83A1B72() { return invoke<Any>(0xABB2FA71C83A1B72); } // 0xABB2FA71C83A1B72
	static void _0xB08B85D860E7BA3C(Any p0, Any p1, Any p2) { invoke<Void>(0xB08B85D860E7BA3C, p0, p1, p2); } // 0xB08B85D860E7BA3C
	static void _0xB129E447A2EDA4BF(Any p0, BOOL p1) { invoke<Void>(0xB129E447A2EDA4BF, p0, p1); } // 0xB129E447A2EDA4BF
	static BOOL _0xB335F761606DB47C(Any* p1, Any* p2, Any p3, BOOL p4) { return invoke<BOOL>(0xB335F761606DB47C, p1, p2, p3, p4); } // 0xB335F761606DB47C
	static void _0xB3CD58CCA6CDA852() { invoke<Void>(0xB3CD58CCA6CDA852); } // 0xB3CD58CCA6CDA852
	static void _0xB3E6360DDE733E82(float p0) { invoke<Void>(0xB3E6360DDE733E82, p0); } // 0xB3E6360DDE733E82
	static void _0xB51B9AB9EF81868C(BOOL toggle) { invoke<Void>(0xB51B9AB9EF81868C, toggle); } // 0xB51B9AB9EF81868C
	static void _0xB8721407EE9C3FF6(Any p0, Any p1, Any p2) { invoke<Void>(0xB8721407EE9C3FF6, p0, p1, p2); } // 0xB8721407EE9C3FF6
	static void _0xB8F87EAD7533B176(float p0) { invoke<Void>(0xB8F87EAD7533B176, p0); } // 0xB8F87EAD7533B176
	static void _0xB9854DFDE0D833D6(float p0) { invoke<Void>(0xB9854DFDE0D833D6, p0); } // 0xB9854DFDE0D833D6
	static void _0xBA4B8D83BDC75551(Any p0) { invoke<Void>(0xBA4B8D83BDC75551, p0); } // 0xBA4B8D83BDC75551
	static void _0xC3C221ADDDE31A11(float p0) { invoke<Void>(0xC3C221ADDDE31A11, p0); } // 0xC3C221ADDDE31A11
	static void _0xC3EAD29AB273ECE8(float p0) { invoke<Void>(0xC3EAD29AB273ECE8, p0); } // 0xC3EAD29AB273ECE8
	static void _0xC54A08C85AE4D410(float p0) { invoke<Void>(0xC54A08C85AE4D410, p0); } // 0xC54A08C85AE4D410
	static void _0xC79AE21974B01FB2() { invoke<Void>(0xC79AE21974B01FB2); } // 0xC79AE21974B01FB2
	static void _0xC7DB36C24634F52B() { invoke<Void>(0xC7DB36C24634F52B); } // 0xC7DB36C24634F52B
	static Any _0xD10282B6E3751BA0() { return invoke<Any>(0xD10282B6E3751BA0); } // 0xD10282B6E3751BA0
	static void _0xD10F442036302D50(Any p0, Any p1, Any p2) { invoke<Void>(0xD10F442036302D50, p0, p1, p2); } // 0xD10F442036302D50
	static void _0xD261BA3E7E998072(Any p0, float p1) { invoke<Void>(0xD261BA3E7E998072, p0, p1); } // 0xD261BA3E7E998072
	static Any _0xD642319C54AADEB6() { return invoke<Any>(0xD642319C54AADEB6); } // 0xD642319C54AADEB6
	static void _0xD79185689F8FD5DF(BOOL p0) { invoke<Void>(0xD79185689F8FD5DF, p0); } // 0xD79185689F8FD5DF
	static void _0xD9F692D349249528() { invoke<Void>(0xD9F692D349249528); } // 0xD9F692D349249528
	static Any _0xDC9274A7EF6B2867() { return invoke<Any>(0xDC9274A7EF6B2867); } // 0xDC9274A7EF6B2867
	static void _0xDEA36202FC3382DF(BOOL p0) { invoke<Void>(0xDEA36202FC3382DF, p0); } // 0xDEA36202FC3382DF
	static void _0xE266ED23311F24D4(Any p0, Any* p1, Any* p2, float p3, float p4, BOOL p5) { invoke<Void>(0xE266ED23311F24D4, p0, p1, p2, p3, p4, p5); } // 0xE266ED23311F24D4
	static void _0xE3D969D2785FFB5E() { invoke<Void>(0xE3D969D2785FFB5E); } // 0xE3D969D2785FFB5E
	static void _0xE532EC1A63231B4F(Any p0, Any p1) { invoke<Void>(0xE532EC1A63231B4F, p0, p1); } // 0xE532EC1A63231B4F
	static void _0xE574A662ACAEFBB1() { invoke<Void>(0xE574A662ACAEFBB1); } // 0xE574A662ACAEFBB1
	static void _0xE6869BECDD8F2403(Any p0, BOOL p1) { invoke<Void>(0xE6869BECDD8F2403, p0, p1); } // 0xE6869BECDD8F2403
	static BOOL _0xE8B9C0EC9E183F35() { return invoke<BOOL>(0xE8B9C0EC9E183F35); } // 0xE8B9C0EC9E183F35
	static BOOL _0xE95B0C7D5BA3B96B(Any p0) { return invoke<BOOL>(0xE95B0C7D5BA3B96B, p0); } // 0xE95B0C7D5BA3B96B
	static Any _0xEA2F2061875EED90() { return invoke<Any>(0xEA2F2061875EED90); } // 0xEA2F2061875EED90
	static void _0xEB078CA2B5E82ADD(Any p0, Any p1) { invoke<Void>(0xEB078CA2B5E82ADD, p0, p1); } // 0xEB078CA2B5E82ADD
	static Any _0xEB2104E905C6F2E9() { return invoke<Any>(0xEB2104E905C6F2E9); } // 0xEB2104E905C6F2E9
	static void _0xEBD3205A207939ED(Any* p0) { invoke<Void>(0xEBD3205A207939ED, p0); } // 0xEBD3205A207939ED
	static void _0xF2F6A2FA49278625(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, Any* p9, Any* p10, Any* p11, Any* p12) { invoke<Void>(0xF2F6A2FA49278625, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12); } // 0xF2F6A2FA49278625
	static BOOL _0xF56DFB7B61BE7276(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, Any* p12) { return invoke<BOOL>(0xF56DFB7B61BE7276, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12); } // 0xF56DFB7B61BE7276
	static void _0xF751B16FB32ABC1D(float p0) { invoke<Void>(0xF751B16FB32ABC1D, p0); } // 0xF751B16FB32ABC1D
	static void _0xFAA457EF263E8763(Any* p0, char* name) { invoke<Void>(0xFAA457EF263E8763, p0, name); } // 0xFAA457EF263E8763
	static void _0xFB00CA71DA386228() { invoke<Void>(0xFB00CA71DA386228); } // 0xFB00CA71DA386228
	static void _0xFB80AB299D2EE1BD(Any p0) { invoke<Void>(0xFB80AB299D2EE1BD, p0); } // 0xFB80AB299D2EE1BD
	static BOOL OVERRIDE_SAVE_HOUSE(BOOL p0, float p1, float p2, float p3, float p4, BOOL p5, float p6, float p7) { return invoke<BOOL>(0x1162EA8AE9D24EEA, p0, p1, p2, p3, p4, p5, p6, p7); } // 0x1162EA8AE9D24EEA
	static void POPULATE_NOW() { invoke<Void>(0x7472BB270D7B4F3E); } // 0x7472BB270D7B4F3E
	static void REGISTER_BOOL_TO_SAVE(Any* p0, char* name) { invoke<Void>(0xC8F4131414C835A1, p0, name); } // 0xC8F4131414C835A1
	static void REGISTER_ENUM_TO_SAVE(Any* p0, char* name) { invoke<Void>(0x10C2FA78D0E128A1, p0, name); } // 0x10C2FA78D0E128A1
	static void REGISTER_FLOAT_TO_SAVE(Any* p0, char* name) { invoke<Void>(0x7CAEC29ECB5DFEBB, p0, name); } // 0x7CAEC29ECB5DFEBB
	static void REGISTER_INT_TO_SAVE(Any* p0, char* name) { invoke<Void>(0x34C9EE5986258415, p0, name); } // 0x34C9EE5986258415
	static Any REGISTER_SAVE_HOUSE(float p0, float p1, float p2, float p3, Any* p4, Any p5, Any p6) { return invoke<Any>(0xC0714D0A7EEECA54, p0, p1, p2, p3, p4, p5, p6); } // 0xC0714D0A7EEECA54
	static void REGISTER_TEXT_LABEL_TO_SAVE(Any* p0, char* name) { invoke<Void>(0xEDB1232C5BEAE62F, p0, name); } // 0xEDB1232C5BEAE62F
	static void REMOVE_DISPATCH_SPAWN_BLOCKING_AREA(Any p0) { invoke<Void>(0x264AC28B01B353A5, p0); } // 0x264AC28B01B353A5
	static void _REMOVE_STEALTH_KILL(Hash hash, BOOL p1) { invoke<Void>(0xA6A12939F16D85BE, hash, p1); } // 0xA6A12939F16D85BE
	static void RESET_DISPATCH_IDEAL_SPAWN_DISTANCE() { invoke<Void>(0x77A84429DD9F0A15); } // 0x77A84429DD9F0A15
	static void RESET_DISPATCH_SPAWN_BLOCKING_AREAS() { invoke<Void>(0xAC7BFD5C1D83EA75); } // 0xAC7BFD5C1D83EA75
	static void _RESET_LOCALPLAYER_STATE() { invoke<Void>(0xC0AA53F866B3134D); } // 0xC0AA53F866B3134D
	static void SET_BIT(int* address, int offset) { invoke<Void>(0x933D6A9EEC1BACD0, address, offset); } // 0x933D6A9EEC1BACD0
	static void SET_BITS_IN_RANGE(int* var, int rangeStart, int rangeEnd, int p3) { invoke<Void>(0x8EF07E15701D61ED, var, rangeStart, rangeEnd, p3); } // 0x8EF07E15701D61ED
	static void _SET_CLOUD_HAT_OPACITY(float opacity) { invoke<Void>(0xF36199225D6D8C86, opacity); } // 0xF36199225D6D8C86
	static void _SET_CLOUD_HAT_TRANSITION(char* type, float transitionTime) { invoke<Void>(0xFC4842A34657BFCB, type, transitionTime); } // 0xFC4842A34657BFCB
	static void SET_CREDITS_ACTIVE(BOOL toggle) { invoke<Void>(0xB938B7E6D3C0620C, toggle); } // 0xB938B7E6D3C0620C
	static void _SET_CUSTOM_RESPAWN_POSITION(float x, float y, float z, float heading) { invoke<Void>(0x706B5EDCAA7FA663, x, y, z, heading); } // 0x706B5EDCAA7FA663
	static void SET_DISPATCH_IDEAL_SPAWN_DISTANCE(float p0) { invoke<Void>(0x6FE601A64180D423, p0); } // 0x6FE601A64180D423
	static void SET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS(Any p0, float p1) { invoke<Void>(0x44F7CBC1BEB3327D, p0, p1); } // 0x44F7CBC1BEB3327D
	static void SET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS_MULTIPLIER(Any p0, float p1) { invoke<Void>(0x48838ED9937A15D1, p0, p1); } // 0x48838ED9937A15D1
	static void SET_EXPLOSIVE_AMMO_THIS_FRAME(Player player) { invoke<Void>(0xA66C71C98D5F2CFB, player); } // 0xA66C71C98D5F2CFB
	static Any SET_EXPLOSIVE_MELEE_THIS_FRAME(Player player) { return invoke<Any>(0xFF1BED81BFDC0FE0, player); } // 0xFF1BED81BFDC0FE0
	static void SET_FADE_IN_AFTER_DEATH_ARREST(BOOL toggle) { invoke<Void>(0xDA66D2796BA33F12, toggle); } // 0xDA66D2796BA33F12
	static void SET_FADE_IN_AFTER_LOAD(BOOL toggle) { invoke<Void>(0xF3D78F59DFE18D79, toggle); } // 0xF3D78F59DFE18D79
	static void SET_FADE_OUT_AFTER_ARREST(BOOL toggle) { invoke<Void>(0x1E0B4DC0D990A4E7, toggle); } // 0x1E0B4DC0D990A4E7
	static void SET_FADE_OUT_AFTER_DEATH(BOOL toggle) { invoke<Void>(0x4A18E01DF2C87B86, toggle); } // 0x4A18E01DF2C87B86
	static void SET_FAKE_WANTED_LEVEL(int fakeWantedLevel) { invoke<Void>(0x1454F2448DE30163, fakeWantedLevel); } // 0x1454F2448DE30163
	static Any SET_FIRE_AMMO_THIS_FRAME(Player player) { return invoke<Any>(0x11879CDD803D30F4, player); } // 0x11879CDD803D30F4
	static void SET_GAME_PAUSED(BOOL toggle) { invoke<Void>(0x577D1284D6873711, toggle); } // 0x577D1284D6873711
	static void SET_GRAVITY_LEVEL(int level) { invoke<Void>(0x740E14FAD5842351, level); } // 0x740E14FAD5842351
	static void SET_MINIGAME_IN_PROGRESS(BOOL toggle) { invoke<Void>(0x19E00D7322C6F85B, toggle); } // 0x19E00D7322C6F85B
	static void SET_MISSION_FLAG(BOOL toggle) { invoke<Void>(0xC4301E5121A0ED73, toggle); } // 0xC4301E5121A0ED73
	static void _SET_NEXT_RESPAWN_TO_CUSTOM() { invoke<Void>(0xA2716D40842EAF79); } // 0xA2716D40842EAF79
	static void SET_OVERRIDE_WEATHER(char* weatherType) { invoke<Void>(0xA43D5C6FE51ADBEF, weatherType); } // 0xA43D5C6FE51ADBEF
	static void _SET_RAIN_FX_INTENSITY(float intensity) { invoke<Void>(0x643E26EA6E024D92, intensity); } // 0x643E26EA6E024D92
	static void SET_RANDOM_EVENT_FLAG(Any p0) { invoke<Void>(0x971927086CFD2158, p0); } // 0x971927086CFD2158
	static void SET_RANDOM_SEED(int time) { invoke<Void>(0x444D98F98C11F3EC, time); } // 0x444D98F98C11F3EC
	static void SET_RANDOM_WEATHER_TYPE() { invoke<Void>(0x8B05F884CF7E8020); } // 0x8B05F884CF7E8020
	static void SET_SAVE_HOUSE(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x4F548CABEAE553BC, p0, p1, p2); } // 0x4F548CABEAE553BC
	static void SET_SAVE_MENU_ACTIVE(BOOL unk) { invoke<Void>(0xC9BF75D28165FF77, unk); } // 0xC9BF75D28165FF77
	static int SET_SUPER_JUMP_THIS_FRAME(Player player) { return invoke<int>(0x57FFF03E423A4C0B, player); } // 0x57FFF03E423A4C0B
	static void SET_THIS_SCRIPT_CAN_BE_PAUSED(BOOL toggle) { invoke<Void>(0xAA391C728106F7AF, toggle); } // 0xAA391C728106F7AF
	static void SET_THIS_SCRIPT_CAN_REMOVE_BLIPS_CREATED_BY_ANY_SCRIPT(BOOL toggle) { invoke<Void>(0xB98236CAAECEF897, toggle); } // 0xB98236CAAECEF897
	static void SET_TIME_SCALE(float time) { invoke<Void>(0x1D408577D440E81E, time); } // 0x1D408577D440E81E
	static void _SET_UNK_MAP_FLAG(int flag) { invoke<Void>(0xC5F0A8EBD3F361CE, flag); } // 0xC5F0A8EBD3F361CE
	static void SET_WEATHER_TYPE_NOW(char* weatherType) { invoke<Void>(0x29B487C359E19889, weatherType); } // 0x29B487C359E19889
	static void SET_WEATHER_TYPE_NOW_PERSIST(char* weatherType) { invoke<Void>(0xED712CA327900C8A, weatherType); } // 0xED712CA327900C8A
	static void _SET_WEATHER_TYPE_OVER_TIME(char* weatherType, float time) { invoke<Void>(0xFB5045B7C42B75BF, weatherType, time); } // 0xFB5045B7C42B75BF
	static void SET_WEATHER_TYPE_PERSIST(char* weatherType) { invoke<Void>(0x704983DF373B198F, weatherType); } // 0x704983DF373B198F
	static void _SET_WEATHER_TYPE_TRANSITION(Hash weatherType1, Hash weatherType2, float percentWeather2) { invoke<Void>(0x578C752848ECFA0C, weatherType1, weatherType2, percentWeather2); } // 0x578C752848ECFA0C
	static void SET_WIND(float speed) { invoke<Void>(0xAC3A74E8384A9919, speed); } // 0xAC3A74E8384A9919
	static void SET_WIND_DIRECTION(float direction) { invoke<Void>(0xEB0F4468467B4528, direction); } // 0xEB0F4468467B4528
	static void SET_WIND_SPEED(float speed) { invoke<Void>(0xEE09ECEDBABE47FC, speed); } // 0xEE09ECEDBABE47FC
	static void SHOOT_SINGLE_BULLET_BETWEEN_COORDS(float x1, float y1, float z1, float x2, float y2, float z2, int damage, BOOL p7, Hash weaponHash, Ped ownerPed, BOOL isAudible, BOOL isInvisible, float speed) { invoke<Void>(0x867654CBC7606F2C, x1, y1, z1, x2, y2, z2, damage, p7, weaponHash, ownerPed, isAudible, isInvisible, speed); } // 0x867654CBC7606F2C
	static void _SHOOT_SINGLE_BULLET_BETWEEN_COORDS_PRESET_PARAMS(float x1, float y1, float z1, float x2, float y2, float z2, int damage, BOOL p7, Hash weaponHash, Ped ownerPed, BOOL isAudible, BOOL isInvisible, float speed, Entity entity) { invoke<Void>(0xE3A7742E0B7A2F8B, x1, y1, z1, x2, y2, z2, damage, p7, weaponHash, ownerPed, isAudible, isInvisible, speed, entity); } // 0xE3A7742E0B7A2F8B
	static void _SHOOT_SINGLE_BULLET_BETWEEN_COORDS_WITH_EXTRA_PARAMS(float x1, float y1, float z1, float x2, float y2, float z2, int damage, BOOL p7, Hash weaponHash, Ped ownerPed, BOOL isAudible, BOOL isInvisible, float speed, Entity entity, BOOL p14, BOOL p15, BOOL p16, BOOL p17) { invoke<Void>(0xBFE5756E7407064A, x1, y1, z1, x2, y2, z2, damage, p7, weaponHash, ownerPed, isAudible, isInvisible, speed, entity, p14, p15, p16, p17); } // 0xBFE5756E7407064A
	static BOOL SHOULD_USE_METRIC_MEASUREMENTS() { return invoke<BOOL>(0xD3D15555431AB793); } // 0xD3D15555431AB793
	static void _SHOW_PED_IN_PAUSE_MENU(BOOL toggle) { invoke<Void>(0x4EBB7E87AA0DBED4, toggle); } // 0x4EBB7E87AA0DBED4
	static void _START_SAVE_ARRAY(Any* p0, int p1, char* arrayName) { invoke<Void>(0x60FE567DF1B1AF9D, p0, p1, arrayName); } // 0x60FE567DF1B1AF9D
	static void START_SAVE_DATA(Any* p0, Any p1, BOOL p2) { invoke<Void>(0xA9575F812C6A7997, p0, p1, p2); } // 0xA9575F812C6A7997
	static void _START_SAVE_STRUCT(Any* p0, int p1, char* structName) { invoke<Void>(0xBF737600CDDBEADD, p0, p1, structName); } // 0xBF737600CDDBEADD
	static void STOP_SAVE_ARRAY() { invoke<Void>(0x4456F95153C6BE4); } // 0x4456F95153C6BE4
	static void STOP_SAVE_DATA() { invoke<Void>(0x74E20C9145FB66FD); } // 0x74E20C9145FB66FD
	static void STOP_SAVE_STRUCT() { invoke<Void>(0xEB1774DF12BB9F12); } // 0xEB1774DF12BB9F12
	static BOOL STRING_TO_INT(char* string, int* outInteger) { return invoke<BOOL>(0x5A5F40FE637EB584, string, outInteger); } // 0x5A5F40FE637EB584
	static float TAN(float p0) { return invoke<float>(0x632106CC96E82E91, p0); } // 0x632106CC96E82E91
	static void TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME(char* scriptName) { invoke<Void>(0x9DC711BC69C548DF, scriptName); } // 0x9DC711BC69C548DF
	static int UPDATE_ONSCREEN_KEYBOARD() { return invoke<int>(0xCF2B696BBF945AE); } // 0xCF2B696BBF945AE
	static void _USE_FREEMODE_MAP_BEHAVIOR(BOOL toggle) { invoke<Void>(0x9BAE5AD2508DF078, toggle); } // 0x9BAE5AD2508DF078
	static void USING_MISSION_CREATOR(BOOL toggle) { invoke<Void>(0xF14878FC50BEC6EE, toggle); } // 0xF14878FC50BEC6EE
}

namespace MOBILE
{
	static BOOL CAN_PHONE_BE_SEEN_ON_SCREEN() { return invoke<BOOL>(0xC4E2813898C97A4B); } // 0xC4E2813898C97A4B
	static void CELL_CAM_ACTIVATE(BOOL p0, BOOL p1) { invoke<Void>(0xFDE8F069C542D126, p0, p1); } // 0xFDE8F069C542D126
	static BOOL CELL_CAM_IS_CHAR_VISIBLE_NO_FACE_CHECK(Entity entity) { return invoke<BOOL>(0x439E9BC95B7E7FBE, entity); } // 0x439E9BC95B7E7FBE
	static void CREATE_MOBILE_PHONE(int p3) { invoke<Void>(0xA4E8E696C532FBC7, p3); } // 0xA4E8E696C532FBC7
	static void DESTROY_MOBILE_PHONE() { invoke<Void>(0x3BC861DF703E5097); } // 0x3BC861DF703E5097
	static void _DISABLE_PHONE_THIS_FRAME(BOOL toggle) { invoke<Void>(0x15C49A93E3E086E, toggle); } // 0x15C49A93E3E086E
	static void GET_MOBILE_PHONE_POSITION(Vector3* position) { invoke<Void>(0x584FDFDA48805B86, position); } // 0x584FDFDA48805B86
	static void GET_MOBILE_PHONE_RENDER_ID(int* renderId) { invoke<Void>(0xB4A53E05F68B6FA1, renderId); } // 0xB4A53E05F68B6FA1
	static void GET_MOBILE_PHONE_ROTATION(Vector3* rotation, Vehicle p1) { invoke<Void>(0x1CEFB61F193070AE, rotation, p1); } // 0x1CEFB61F193070AE
	static void _MOVE_FINGER(int direction) { invoke<Void>(0x95C9E72F3D7DEC9B, direction); } // 0x95C9E72F3D7DEC9B
	static BOOL _NETWORK_SHOP_DOES_ITEM_EXIST(char* name) { return invoke<BOOL>(0xBD4D7EAF8A30F637, name); } // 0xBD4D7EAF8A30F637
	static BOOL _NETWORK_SHOP_DOES_ITEM_EXIST_HASH(Hash hash) { return invoke<BOOL>(0x247F0F73A182EA0B, hash); } // 0x247F0F73A182EA0B
	static void _0x15E69E2802C24B8D(float p0) { invoke<Void>(0x15E69E2802C24B8D, p0); } // 0x15E69E2802C24B8D
	static void _0x1B0B4AEED5B9B41C(float p0) { invoke<Void>(0x1B0B4AEED5B9B41C, p0); } // 0x1B0B4AEED5B9B41C
	static void _0x3117D84EFA60F77B(float p0) { invoke<Void>(0x3117D84EFA60F77B, p0); } // 0x3117D84EFA60F77B
	static void _0x375A706A5C2FD084(Any p0) { invoke<Void>(0x375A706A5C2FD084, p0); } // 0x375A706A5C2FD084
	static void _0x466DA42C89865553(float p0) { invoke<Void>(0x466DA42C89865553, p0); } // 0x466DA42C89865553
	static void _0x53F4892D18EC90A4(float p0) { invoke<Void>(0x53F4892D18EC90A4, p0); } // 0x53F4892D18EC90A4
	static void _0xA2CCBE62CD4C91A4(int* toggle) { invoke<Void>(0xA2CCBE62CD4C91A4, toggle); } // 0xA2CCBE62CD4C91A4
	static void _0xAC2890471901861C(float p0) { invoke<Void>(0xAC2890471901861C, p0); } // 0xAC2890471901861C
	static void _0xD6ADE981781FCA09(float p0) { invoke<Void>(0xD6ADE981781FCA09, p0); } // 0xD6ADE981781FCA09
	static void _0xF1E22DC13F5EEBAD(float p0) { invoke<Void>(0xF1E22DC13F5EEBAD, p0); } // 0xF1E22DC13F5EEBAD
	static void SCRIPT_IS_MOVING_MOBILE_PHONE_OFFSCREEN(BOOL toggle) { invoke<Void>(0xF511F759238A5122, toggle); } // 0xF511F759238A5122
	static void SET_MOBILE_PHONE_POSITION(float posX, float posY, float posZ) { invoke<Void>(0x693A5C6D6734085B, posX, posY, posZ); } // 0x693A5C6D6734085B
	static void SET_MOBILE_PHONE_ROTATION(float rotX, float rotY, float rotZ, Any p3) { invoke<Void>(0xBB779C0CA917E865, rotX, rotY, rotZ, p3); } // 0xBB779C0CA917E865
	static void SET_MOBILE_PHONE_SCALE(float scale) { invoke<Void>(0xCBDD322A73D6D932, scale); } // 0xCBDD322A73D6D932
	static void _SET_PHONE_LEAN(BOOL Toggle) { invoke<Void>(0x44E44169EF70138E, Toggle); } // 0x44E44169EF70138E
}

namespace NETCASH
{
	static void _0x0035BB914316F1E3(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x35BB914316F1E3, p0, p1, p2, p3); } // 0x35BB914316F1E3
	static void _0x05F04155A226FBBF(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x5F04155A226FBBF, p0, p1, p2, p3); } // 0x5F04155A226FBBF
	static void _0x08A1B82B91900682(Any p0, Any p1, Any p2) { invoke<Void>(0x8A1B82B91900682, p0, p1, p2); } // 0x8A1B82B91900682
	static void _0x08B0CA7A6AB3AC32(Any p0, Any p1, Any p2) { invoke<Void>(0x8B0CA7A6AB3AC32, p0, p1, p2); } // 0x8B0CA7A6AB3AC32
	static void _0x0C82D21A77C22D49(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xC82D21A77C22D49, p0, p1, p2, p3); } // 0xC82D21A77C22D49
	static void _0x0CB1BE0633C024A8(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xCB1BE0633C024A8, p0, p1, p2, p3); } // 0xCB1BE0633C024A8
	static void _0x0D30EB83668E63C5(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xD30EB83668E63C5, p0, p1, p2, p3); } // 0xD30EB83668E63C5
	static void _0x0FE8E1FCD2B86B33(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xFE8E1FCD2B86B33, p0, p1, p2, p3); } // 0xFE8E1FCD2B86B33
	static void _0x112209CE0290C03A(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x112209CE0290C03A, p0, p1, p2, p3); } // 0x112209CE0290C03A
	static void _0x12D148D26538D0F9(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x12D148D26538D0F9, p0, p1, p2, p3); } // 0x12D148D26538D0F9
	static void _0x2AFC2D19B50797F2(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x2AFC2D19B50797F2, p0, p1, p2, p3); } // 0x2AFC2D19B50797F2
	static void _0x2FAB6614CE22E196(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x2FAB6614CE22E196, p0, p1, p2, p3); } // 0x2FAB6614CE22E196
	static void _0x30FD873ECE50E9F6(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x30FD873ECE50E9F6, p0, p1, p2, p3, p4); } // 0x30FD873ECE50E9F6
	static void _0x33981D6804E62F49(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x33981D6804E62F49, p0, p1, p2, p3); } // 0x33981D6804E62F49
	static void _0x365E877C61D6988B(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x365E877C61D6988B, p0, p1, p2, p3); } // 0x365E877C61D6988B
	static Any _0x3E4ADAFF1830F146() { return invoke<Any>(0x3E4ADAFF1830F146); } // 0x3E4ADAFF1830F146
	static void _0x4128464231E3CA0B(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x4128464231E3CA0B, p0, p1, p2, p3); } // 0x4128464231E3CA0B
	static void _0x5182A339A3474510(Any p0, Any p1, Any p2) { invoke<Void>(0x5182A339A3474510, p0, p1, p2); } // 0x5182A339A3474510
	static void _0x55A1E095DB052FA5(Any p0, Any p1) { invoke<Void>(0x55A1E095DB052FA5, p0, p1); } // 0x55A1E095DB052FA5
	static void _0x5BCDE0F640C773D2(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x5BCDE0F640C773D2, p0, p1, p2, p3); } // 0x5BCDE0F640C773D2
	static void _0x5D97630A8A0EF123(Any p0, Any p1, Any p2) { invoke<Void>(0x5D97630A8A0EF123, p0, p1, p2); } // 0x5D97630A8A0EF123
	static void _0x5F456788B05FAEAC(Any p0, Any p1, Any p2) { invoke<Void>(0x5F456788B05FAEAC, p0, p1, p2); } // 0x5F456788B05FAEAC
	static void _0x675D19C6067CAE08(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x675D19C6067CAE08, p0, p1, p2, p3); } // 0x675D19C6067CAE08
	static void _0x69EF772B192614C1(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x69EF772B192614C1, p0, p1, p2, p3); } // 0x69EF772B192614C1
	static void _0x6FD97159FE3C971A(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x6FD97159FE3C971A, p0, p1, p2, p3); } // 0x6FD97159FE3C971A
	static void _0x821418C727FCACD7(Any p0) { invoke<Void>(0x821418C727FCACD7, p0); } // 0x821418C727FCACD7
	static void _0x84C0116D012E8FC2(Any p0) { invoke<Void>(0x84C0116D012E8FC2, p0); } // 0x84C0116D012E8FC2
	static void _0x8586789730B10CAF(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x8586789730B10CAF, p0, p1, p2, p3); } // 0x8586789730B10CAF
	static void _0x8E243837643D9583(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x8E243837643D9583, p0, p1, p2, p3); } // 0x8E243837643D9583
	static void _0x9251B6ABF2D0A5B4(Any p0, Any p1) { invoke<Void>(0x9251B6ABF2D0A5B4, p0, p1); } // 0x9251B6ABF2D0A5B4
	static Any _0x9777734DAD16992F() { return invoke<Any>(0x9777734DAD16992F); } // 0x9777734DAD16992F
	static void _0x998E18CEB44487FC(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x998E18CEB44487FC, p0, p1, p2, p3); } // 0x998E18CEB44487FC
	static void _0xA51B086B0B2C0F7A(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xA51B086B0B2C0F7A, p0, p1, p2, p3); } // 0xA51B086B0B2C0F7A
	static void _0xA75CCF58A60A5FD1(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { invoke<Void>(0xA75CCF58A60A5FD1, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); } // 0xA75CCF58A60A5FD1
	static void _0xA95F667A755725DA(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xA95F667A755725DA, p0, p1, p2, p3); } // 0xA95F667A755725DA
	static void _0xAC272C0AE01B4BD8(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xAC272C0AE01B4BD8, p0, p1, p2, p3); } // 0xAC272C0AE01B4BD8
	static void _0xB49ECA122467D05F(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xB49ECA122467D05F, p0, p1, p2, p3); } // 0xB49ECA122467D05F
	static void _0xB4C2EC463672474E(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xB4C2EC463672474E, p0, p1, p2, p3); } // 0xB4C2EC463672474E
	static void _0xBD0EFB25CCA8F97A(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xBD0EFB25CCA8F97A, p0, p1, p2, p3); } // 0xBD0EFB25CCA8F97A
	static void _0xC1952F3773BA18FE(Any p0, Any p1, Any p2) { invoke<Void>(0xC1952F3773BA18FE, p0, p1, p2); } // 0xC1952F3773BA18FE
	static void _0xC8407624CEF2354B(Any p0, Any p1) { invoke<Void>(0xC8407624CEF2354B, p0, p1); } // 0xC8407624CEF2354B
	static void _0xCDA1C62BE2777802(Any p0, Any p1, Any p2) { invoke<Void>(0xCDA1C62BE2777802, p0, p1, p2); } // 0xCDA1C62BE2777802
	static void _0xD7CCCBA28C4ECAF0(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xD7CCCBA28C4ECAF0, p0, p1, p2, p3, p4); } // 0xD7CCCBA28C4ECAF0
	static void _0xD99DB210089617FE(Any p0, Any p1, Any p2) { invoke<Void>(0xD99DB210089617FE, p0, p1, p2); } // 0xD99DB210089617FE
	static void _0xDBC966A01C02BCA7(Any p0, Any p1, Any p2) { invoke<Void>(0xDBC966A01C02BCA7, p0, p1, p2); } // 0xDBC966A01C02BCA7
	static void _0xE23ADC6FCB1F29AE(Any p0, Any p1, Any p2) { invoke<Void>(0xE23ADC6FCB1F29AE, p0, p1, p2); } // 0xE23ADC6FCB1F29AE
	static void _0xE7DF4E0545DFB56E(Any p0, Any p1, Any p2) { invoke<Void>(0xE7DF4E0545DFB56E, p0, p1, p2); } // 0xE7DF4E0545DFB56E
	static void _0xE8B0B270B6E7C76E(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xE8B0B270B6E7C76E, p0, p1, p2, p3); } // 0xE8B0B270B6E7C76E
	static void _0xECA658CE2A4E5A72(Any p0, Any p1) { invoke<Void>(0xECA658CE2A4E5A72, p0, p1); } // 0xECA658CE2A4E5A72
	static void _0xED5FD7AF10F5E262(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xED5FD7AF10F5E262, p0, p1, p2, p3); } // 0xED5FD7AF10F5E262
	static void _0xEDEAD9A91EC768B3(Any p0, Any p1, Any p2) { invoke<Void>(0xEDEAD9A91EC768B3, p0, p1, p2); } // 0xEDEAD9A91EC768B3
	static void _0xFA07759E6FDDD7CF(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xFA07759E6FDDD7CF, p0, p1, p2, p3); } // 0xFA07759E6FDDD7CF
	static void _0xFC4EE00A7B3BFB76(Any p0, Any p1, Any p2) { invoke<Void>(0xFC4EE00A7B3BFB76, p0, p1, p2); } // 0xFC4EE00A7B3BFB76
	static Any _0xFFBE02CD385356BD() { return invoke<Any>(0xFFBE02CD385356BD); } // 0xFFBE02CD385356BD
}

namespace NETSHOP
{
	static char* _GET_ONLINE_VERSION() { return invoke<char*>(0xFCA9373EF340AC0A); } // 0xFCA9373EF340AC0A
	static BOOL _NETWORK_SHOP_BASKET_ADD_ITEM(Any* p0, Any p1) { return invoke<BOOL>(0xF30980718C8ED876, p0, p1); } // 0xF30980718C8ED876
	static BOOL _NETWORK_SHOP_BASKET_APPLY_SERVER_DATA(Any p0, Any* p1) { return invoke<BOOL>(0xE1A0450ED46A7812, p0, p1); } // 0xE1A0450ED46A7812
	static BOOL _NETWORK_SHOP_BASKET_END() { return invoke<BOOL>(0xA65568121DF2EA26); } // 0xA65568121DF2EA26
	static Any _NETWORK_SHOP_BASKET_IS_FULL() { return invoke<Any>(0x27F76CC6C55AD30E); } // 0x27F76CC6C55AD30E
	static BOOL _NETWORK_SHOP_BASKET_START(Any* p0, int p1, int p2, int p3) { return invoke<BOOL>(0x279F08B1A4B29B7E, p0, p1, p2, p3); } // 0x279F08B1A4B29B7E
	static BOOL _NETWORK_SHOP_BEGIN_SERVICE(int* transactionID, Hash p1, Hash transactionHash, int amount, Hash p4, int mode) { return invoke<BOOL>(0x3C5FD37B5499582E, transactionID, p1, transactionHash, amount, p4, mode); } // 0x3C5FD37B5499582E
	static BOOL _NETWORK_SHOP_CASH_TRANSFER_SET_TELEMETRY_NONCE_SEED() { return invoke<BOOL>(0x498C1E05CE5F7877); } // 0x498C1E05CE5F7877
	static BOOL _NETWORK_SHOP_CHECKOUT_START(int transactionID) { return invoke<BOOL>(0x39BE7CEA8D9CC8E6, transactionID); } // 0x39BE7CEA8D9CC8E6
	static Any _NETWORK_SHOP_DELETE_SET_TELEMETRY_NONCE_SEED() { return invoke<Any>(0x112CEF1615A1139F); } // 0x112CEF1615A1139F
	static int _NETWORK_SHOP_GET_PRICE(Hash itemHash, Hash hash2, BOOL p2) { return invoke<int>(0xC27009422FCCA88D, itemHash, hash2, p2); } // 0xC27009422FCCA88D
	static BOOL _NETWORK_SHOP_GET_TRANSACTIONS_DISABLED() { return invoke<BOOL>(0x810E8431C0614BF9); } // 0x810E8431C0614BF9
	static BOOL _NETWORK_SHOP_GET_TRANSACTIONS_ENABLED_FOR_CHARACTER(int mpChar) { return invoke<BOOL>(0xB24F0944DA203D9E, mpChar); } // 0xB24F0944DA203D9E
	static BOOL _NETWORK_SHOP_SESSION_APPLY_RECEIVED_DATA(Any p0) { return invoke<BOOL>(0x2F41D51BA3BCD1F1, p0); } // 0x2F41D51BA3BCD1F1
	static BOOL _NETWORK_SHOP_SET_TELEMETRY_NONCE_SEED(Any p0) { return invoke<BOOL>(0x9507D4271988E1AE, p0); } // 0x9507D4271988E1AE
	static BOOL _NETWORK_SHOP_START_SESSION(Any p0) { return invoke<BOOL>(0xA135AC892A58FC07, p0); } // 0xA135AC892A58FC07
	static BOOL _NETWORK_SHOP_TERMINATE_SERVICE(int transactionID) { return invoke<BOOL>(0xE2A99A9B524BEFFF, transactionID); } // 0xE2A99A9B524BEFFF
	static BOOL _NETWORK_TRANSFER_BANK_TO_WALLET(int charStatInt, int amount) { return invoke<BOOL>(0xD47A2C1BA117471D, charStatInt, amount); } // 0xD47A2C1BA117471D
	static BOOL _NETWORK_TRANSFER_WALLET_TO_BANK(int charStatInt, int amount) { return invoke<BOOL>(0xC2F7FE5309181C7D, charStatInt, amount); } // 0xC2F7FE5309181C7D
	static BOOL _0x0395CB47B022E62C(Any* p0) { return invoke<BOOL>(0x395CB47B022E62C, p0); } // 0x395CB47B022E62C
	static Any _0x0A6D923DFFC9BD89() { return invoke<Any>(0xA6D923DFFC9BD89); } // 0xA6D923DFFC9BD89
	static BOOL _0x170910093218C8B9(Any* p0) { return invoke<BOOL>(0x170910093218C8B9, p0); } // 0x170910093218C8B9
	static Any _0x23789E777D14CE44() { return invoke<Any>(0x23789E777D14CE44); } // 0x23789E777D14CE44
	static Any _0x2B949A1E6AEC8F6A() { return invoke<Any>(0x2B949A1E6AEC8F6A); } // 0x2B949A1E6AEC8F6A
	static Any _0x350AA5EBC03D3BD2() { return invoke<Any>(0x350AA5EBC03D3BD2); } // 0x350AA5EBC03D3BD2
	static Any _0x357B152EF96C30B6() { return invoke<Any>(0x357B152EF96C30B6); } // 0x357B152EF96C30B6
	static BOOL _0x35A1B3E1D1315CFA(BOOL p0, BOOL p1) { return invoke<BOOL>(0x35A1B3E1D1315CFA, p0, p1); } // 0x35A1B3E1D1315CFA
	static Any _0x3C4487461E9B0DCB() { return invoke<Any>(0x3C4487461E9B0DCB); } // 0x3C4487461E9B0DCB
	static BOOL _0x51F1A8E48C3D2F6D(Any p0, BOOL p1, Any p2) { return invoke<BOOL>(0x51F1A8E48C3D2F6D, p0, p1, p2); } // 0x51F1A8E48C3D2F6D
	static Any _0x613F125BA3BD2EB9() { return invoke<Any>(0x613F125BA3BD2EB9); } // 0x613F125BA3BD2EB9
	static BOOL _0x72EB7BA9B69BF6AB() { return invoke<BOOL>(0x72EB7BA9B69BF6AB); } // 0x72EB7BA9B69BF6AB
	static int _0x74A0FD0688F1EE45(int p0) { return invoke<int>(0x74A0FD0688F1EE45, p0); } // 0x74A0FD0688F1EE45
	static Any _0x85F6C9ABA1DE2BCF() { return invoke<Any>(0x85F6C9ABA1DE2BCF); } // 0x85F6C9ABA1DE2BCF
	static BOOL _0x897433D292B44130(Any* p0, Any* p1) { return invoke<BOOL>(0x897433D292B44130, p0, p1); } // 0x897433D292B44130
	static BOOL _0xC13C38E47EA5DF31(Any* p0) { return invoke<BOOL>(0xC13C38E47EA5DF31, p0); } // 0xC13C38E47EA5DF31
	static BOOL _0xCF38DAFBB49EDE5E(Any* p0) { return invoke<BOOL>(0xCF38DAFBB49EDE5E, p0); } // 0xCF38DAFBB49EDE5E
	static Any _0xE3E5A7C64CA2C6ED() { return invoke<Any>(0xE3E5A7C64CA2C6ED); } // 0xE3E5A7C64CA2C6ED
	static Any _0xE547E9114277098F() { return invoke<Any>(0xE547E9114277098F); } // 0xE547E9114277098F
}

namespace NETWORK
{
	static void ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID(int netID, BOOL p1) { invoke<Void>(0xD45B1FFCCD52FF19, netID, p1); } // 0xD45B1FFCCD52FF19
	static BOOL BAD_SPORT_PLAYER_LEFT_DETECTED(int* networkHandle, int event, int amountReceived) { return invoke<BOOL>(0xEC5E3AF5289DCA81, networkHandle, event, amountReceived); } // 0xEC5E3AF5289DCA81
	static BOOL _CAN_PLAY_ONLINE() { return invoke<BOOL>(0x5F91D5D0B36AA310); } // 0x5F91D5D0B36AA310
	static BOOL CAN_REGISTER_MISSION_ENTITIES(int ped_amt, int vehicle_amt, int object_amt, int pickup_amt) { return invoke<BOOL>(0x69778E7564BADE6D, ped_amt, vehicle_amt, object_amt, pickup_amt); } // 0x69778E7564BADE6D
	static BOOL CAN_REGISTER_MISSION_OBJECTS(int amount) { return invoke<BOOL>(0x800DD4721A8B008B, amount); } // 0x800DD4721A8B008B
	static BOOL CAN_REGISTER_MISSION_PEDS(int amount) { return invoke<BOOL>(0xBCBF4FEF9FA5D781, amount); } // 0xBCBF4FEF9FA5D781
	static BOOL _CAN_REGISTER_MISSION_PICKUPS(int p0) { return invoke<BOOL>(0xA49D1CB6E34AF72, p0); } // 0xA49D1CB6E34AF72
	static BOOL CAN_REGISTER_MISSION_VEHICLES(int amount) { return invoke<BOOL>(0x7277F1F2E085EE74, amount); } // 0x7277F1F2E085EE74
	static void _DOWNLOAD_CHECK() { invoke<Void>(0x4F18196C8D38768D); } // 0x4F18196C8D38768D
	static BOOL _FACEBOOK_DO_UNK_CHECK() { return invoke<BOOL>(0xA75E2B6733DA5142); } // 0xA75E2B6733DA5142
	static BOOL _FACEBOOK_IS_AVAILABLE() { return invoke<BOOL>(0x43865688AE10F0D7); } // 0x43865688AE10F0D7
	static BOOL _FACEBOOK_IS_SENDING_DATA() { return invoke<BOOL>(0x62B9FEC9A11F10EF); } // 0x62B9FEC9A11F10EF
	static BOOL _FACEBOOK_SET_CREATE_CHARACTER_COMPLETE() { return invoke<BOOL>(0xDC48473142545431); } // 0xDC48473142545431
	static BOOL _FACEBOOK_SET_HEIST_COMPLETE(char* heistName, int cashEarned, int xpEarned) { return invoke<BOOL>(0x98AB65B9ED9A9EC, heistName, cashEarned, xpEarned); } // 0x98AB65B9ED9A9EC
	static BOOL _FACEBOOK_SET_MILESTONE_COMPLETE(int milestoneId) { return invoke<BOOL>(0xAE1F1653B554AB9, milestoneId); } // 0xAE1F1653B554AB9
	static void FADE_OUT_LOCAL_PLAYER(BOOL p0) { invoke<Void>(0x416DBD4CD6ED8DD2, p0); } // 0x416DBD4CD6ED8DD2
	static BOOL FILLOUT_PM_PLAYER_LIST(int* networkHandle, Any p1, Any p2) { return invoke<BOOL>(0xCBBD7C4991B64809, networkHandle, p1, p2); } // 0xCBBD7C4991B64809
	static BOOL FILLOUT_PM_PLAYER_LIST_WITH_NAMES(Any* p0, Any* p1, Any p2, Any p3) { return invoke<BOOL>(0x716B6DB9D1886106, p0, p1, p2, p3); } // 0x716B6DB9D1886106
	static int GET_CLOUD_TIME_AS_INT() { return invoke<int>(0x9A73240B49945C76); } // 0x9A73240B49945C76
	static int _GET_CONTENT_CATEGORY(int p0) { return invoke<int>(0xA7BAB11E7C9C6C5A, p0); } // 0xA7BAB11E7C9C6C5A
	static int _GET_CONTENT_DESCRIPTION_HASH(Any p0) { return invoke<int>(0x7CF0448787B23758, p0); } // 0x7CF0448787B23758
	static Any _GET_CONTENT_FILE_VERSION(Any p0, Any p1) { return invoke<Any>(0x37025B27D9B658B1, p0, p1); } // 0x37025B27D9B658B1
	static char* _GET_CONTENT_ID(Any p0) { return invoke<char*>(0x55AA95F481D694D2, p0); } // 0x55AA95F481D694D2
	static void _GET_DATE_AND_TIME_FROM_UNIX_EPOCH(int unixEpoch, Any* timeStructure) { invoke<Void>(0xAC97AF97FA68E5D5, unixEpoch, timeStructure); } // 0xAC97AF97FA68E5D5
	static int GET_NETWORK_TIME() { return invoke<int>(0x7A5487FE9FAA6B48); } // 0x7A5487FE9FAA6B48
	static int _GET_NUM_MEMBERSHIP_DESC() { return invoke<int>(0x1F471B79ACC90BEF); } // 0x1F471B79ACC90BEF
	static int GET_NUM_RESERVED_MISSION_OBJECTS(BOOL p0) { return invoke<int>(0xAA81B5F10BC43AC2, p0); } // 0xAA81B5F10BC43AC2
	static int GET_NUM_RESERVED_MISSION_PEDS(BOOL p0) { return invoke<int>(0x1F13D5AE5CB17E17, p0); } // 0x1F13D5AE5CB17E17
	static int GET_NUM_RESERVED_MISSION_VEHICLES(BOOL p0) { return invoke<int>(0xCF3A965906452031, p0); } // 0xCF3A965906452031
	static char* GET_PLAYER_ADVANCED_MODIFIER_PRIVILEGES(int p0) { return invoke<char*>(0xCD67AD041A394C9C, p0); } // 0xCD67AD041A394C9C
	static char* _GET_ROOT_CONTENT_ID(Any p0) { return invoke<char*>(0xC0173D6BFF4E0348, p0); } // 0xC0173D6BFF4E0348
	static char* GET_TIME_AS_STRING(int time) { return invoke<char*>(0x9E23B1777A927DAD, time); } // 0x9E23B1777A927DAD
	static int GET_TIME_DIFFERENCE(int timeA, int timeB) { return invoke<int>(0xA2C6FC031D46FFF0, timeA, timeB); } // 0xA2C6FC031D46FFF0
	static int GET_TIME_OFFSET(int timeA, int timeB) { return invoke<int>(0x17008CCDAD48503, timeA, timeB); } // 0x17008CCDAD48503
	static int _GET_TUNABLES_CONTENT_MODIFIER_ID(Hash contentHash) { return invoke<int>(0x187382F8A3E0A6C3, contentHash); } // 0x187382F8A3E0A6C3
	static BOOL _HAS_BG_SCRIPT_BEEN_DOWNLOADED() { return invoke<BOOL>(0x8132C0EB8B2B3293); } // 0x8132C0EB8B2B3293
	static BOOL HAS_NETWORK_TIME_STARTED() { return invoke<BOOL>(0x46718ACEEDEAFC84); } // 0x46718ACEEDEAFC84
	static BOOL _HAS_TUNABLES_BEEN_DOWNLOADED() { return invoke<BOOL>(0x467C11ED88B7D28); } // 0x467C11ED88B7D28
	static BOOL IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID(int netID) { return invoke<BOOL>(0x6E192E33AD436366, netID); } // 0x6E192E33AD436366
	static BOOL IS_NETWORK_VEHICLE_BEEN_DAMAGED_BY_ANY_OBJECT(float x, float y, float z) { return invoke<BOOL>(0xDBD2056652689917, x, y, z); } // 0xDBD2056652689917
	static BOOL IS_PLAYER_IN_CUTSCENE(Player player) { return invoke<BOOL>(0xE73092F4157CD126, player); } // 0xE73092F4157CD126
	static BOOL _IS_ROCKSTAR_BANNED() { return invoke<BOOL>(0x8020A73847E0CA7D); } // 0x8020A73847E0CA7D
	static BOOL _IS_SOCIALCLUB_BANNED() { return invoke<BOOL>(0xA0AD7E2AF5349F61); } // 0xA0AD7E2AF5349F61
	static BOOL IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE(float p0, float p1, float p2, float p3) { return invoke<BOOL>(0xD82CF8E64C8729D8, p0, p1, p2, p3); } // 0xD82CF8E64C8729D8
	static BOOL IS_SPHERE_VISIBLE_TO_PLAYER(Any p0, float p1, float p2, float p3, float p4) { return invoke<BOOL>(0xDC3A310219E5DA62, p0, p1, p2, p3, p4); } // 0xDC3A310219E5DA62
	static BOOL IS_TIME_EQUAL_TO(int timeA, int timeB) { return invoke<BOOL>(0xF5BC95857BD6D512, timeA, timeB); } // 0xF5BC95857BD6D512
	static BOOL IS_TIME_LESS_THAN(int timeA, int timeB) { return invoke<BOOL>(0xCB2CF5148012C8D0, timeA, timeB); } // 0xCB2CF5148012C8D0
	static BOOL IS_TIME_MORE_THAN(int timeA, int timeB) { return invoke<BOOL>(0xDE350F8651E4346C, timeA, timeB); } // 0xDE350F8651E4346C
	static Entity NET_TO_ENT(int netHandle) { return invoke<Entity>(0xBFFEAB45A9A9094A, netHandle); } // 0xBFFEAB45A9A9094A
	static Object NET_TO_OBJ(int netHandle) { return invoke<Object>(0xD8515F5FEA14CB3F, netHandle); } // 0xD8515F5FEA14CB3F
	static Ped NET_TO_PED(int netHandle) { return invoke<Ped>(0xBDCD95FC216A8B3E, netHandle); } // 0xBDCD95FC216A8B3E
	static Vehicle NET_TO_VEH(int netHandle) { return invoke<Vehicle>(0x367B936610BA360C, netHandle); } // 0x367B936610BA360C
	static BOOL NETWORK_ACCEPT_PRESENCE_INVITE(Any p0) { return invoke<BOOL>(0xFA91550DF9318B22, p0); } // 0xFA91550DF9318B22
	static BOOL NETWORK_ACCESS_TUNABLE_BOOL(char* tunableContext, char* tunableName) { return invoke<BOOL>(0xAA6A47A573ABB75A, tunableContext, tunableName); } // 0xAA6A47A573ABB75A
	static BOOL _NETWORK_ACCESS_TUNABLE_BOOL_HASH(Hash tunableContext, Hash tunableName) { return invoke<BOOL>(0xEA16B69D93D71A45, tunableContext, tunableName); } // 0xEA16B69D93D71A45
	static BOOL _NETWORK_ACCESS_TUNABLE_BOOL_HASH_FAIL_VAL(Hash tunableContext, Hash tunableName, BOOL defaultValue) { return invoke<BOOL>(0xC7420099936CE286, tunableContext, tunableName, defaultValue); } // 0xC7420099936CE286
	static BOOL NETWORK_ACCESS_TUNABLE_FLOAT(char* tunableContext, char* tunableName, float* value) { return invoke<BOOL>(0xE5608CA7BC163A5F, tunableContext, tunableName, value); } // 0xE5608CA7BC163A5F
	static BOOL _NETWORK_ACCESS_TUNABLE_FLOAT_HASH(Hash tunableContext, Hash tunableName, float* value) { return invoke<BOOL>(0x972BC203BBC4C4D5, tunableContext, tunableName, value); } // 0x972BC203BBC4C4D5
	static BOOL NETWORK_ACCESS_TUNABLE_INT(char* tunableContext, char* tunableName, int* value) { return invoke<BOOL>(0x8BE1146DFD5D4468, tunableContext, tunableName, value); } // 0x8BE1146DFD5D4468
	static BOOL _NETWORK_ACCESS_TUNABLE_INT_HASH(Hash tunableContext, Hash tunableName, int* value) { return invoke<BOOL>(0x40FCE03E50E8DBE8, tunableContext, tunableName, value); } // 0x40FCE03E50E8DBE8
	static Any NETWORK_ACTION_FOLLOW_INVITE() { return invoke<Any>(0xC88156EBB786F8D5); } // 0xC88156EBB786F8D5
	static Any _NETWORK_ADD_ENTITY_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6) { return invoke<Any>(0x376C6375BA60293A, p0, p1, p2, p3, p4, p5, p6); } // 0x376C6375BA60293A
	static Any NETWORK_ADD_ENTITY_AREA(float p0, float p1, float p2, float p3, float p4, float p5) { return invoke<Any>(0x494C8FB299290269, p0, p1, p2, p3, p4, p5); } // 0x494C8FB299290269
	static void NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE(Entity entity, int netScene, char* animDict, char* animName, float speed, float speedMulitiplier, int flag) { invoke<Void>(0xF2404D68CBC855FA, entity, netScene, animDict, animName, speed, speedMulitiplier, flag); } // 0xF2404D68CBC855FA
	static void NETWORK_ADD_FOLLOWERS(int* p0, int p1) { invoke<Void>(0x236406F60CF216D6, p0, p1); } // 0x236406F60CF216D6
	static BOOL NETWORK_ADD_FRIEND(int* networkHandle, char* message) { return invoke<BOOL>(0x8E02D73914064223, networkHandle, message); } // 0x8E02D73914064223
	static void NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE(Ped ped, int netScene, char* animDict, char* animnName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, Any p9) { invoke<Void>(0x742A637471BCECD9, ped, netScene, animDict, animnName, speed, speedMultiplier, duration, flag, playbackRate, p9); } // 0x742A637471BCECD9
	static BOOL NETWORK_AM_I_BLOCKED_BY_GAMER(Any* p0) { return invoke<BOOL>(0x15337C7C268A27B2, p0); } // 0x15337C7C268A27B2
	static BOOL NETWORK_AM_I_BLOCKED_BY_PLAYER(Player player) { return invoke<BOOL>(0x87F395D957D4353D, player); } // 0x87F395D957D4353D
	static BOOL NETWORK_AM_I_MUTED_BY_GAMER(Any* p0) { return invoke<BOOL>(0xDF02A2C93F1F26DA, p0); } // 0xDF02A2C93F1F26DA
	static BOOL NETWORK_AM_I_MUTED_BY_PLAYER(Player player) { return invoke<BOOL>(0x9D6981DFC91A8604, player); } // 0x9D6981DFC91A8604
	static void NETWORK_APPLY_TRANSITION_PARAMETER(Any p0, Any p1) { invoke<Void>(0x521638ADA1BA0D18, p0, p1); } // 0x521638ADA1BA0D18
	static BOOL NETWORK_ARE_HANDLES_THE_SAME(int* netHandle1, int* netHandle2) { return invoke<BOOL>(0x57DBA049E110F217, netHandle1, netHandle2); } // 0x57DBA049E110F217
	static BOOL _NETWORK_ARE_ROS_AVAILABLE() { return invoke<BOOL>(0x85443FF4C328F53B); } // 0x85443FF4C328F53B
	static BOOL NETWORK_ARE_TRANSITION_DETAILS_VALID(Any p0) { return invoke<BOOL>(0x2615AA2A695930C1, p0); } // 0x2615AA2A695930C1
	static void NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY(int netScene, Entity entity, int bone) { invoke<Void>(0x478DCBD2A98B705A, netScene, entity, bone); } // 0x478DCBD2A98B705A
	static void NETWORK_BAIL() { invoke<Void>(0x95914459A87EBA28); } // 0x95914459A87EBA28
	static void NETWORK_BAIL_TRANSITION() { invoke<Void>(0xEAA572036990CD1B); } // 0xEAA572036990CD1B
	static void NETWORK_BLOCK_INVITES(BOOL toggle) { invoke<Void>(0x34F9E9049454A7A0, toggle); } // 0x34F9E9049454A7A0
	static void _NETWORK_BLOCK_INVITES_2(BOOL p0) { invoke<Void>(0x4A9FDE3A5A6D0437, p0); } // 0x4A9FDE3A5A6D0437
	static void _NETWORK_BLOCK_KICKED_PLAYERS(BOOL p0) { invoke<Void>(0x6B07B9CE4D390375, p0); } // 0x6B07B9CE4D390375
	static BOOL NETWORK_CAN_ACCESS_MULTIPLAYER(int* loadingState) { return invoke<BOOL>(0xAF50DA1A3F8B1BA4, loadingState); } // 0xAF50DA1A3F8B1BA4
	static BOOL NETWORK_CAN_BAIL() { return invoke<BOOL>(0x580CE4438479CC61); } // 0x580CE4438479CC61
	static BOOL NETWORK_CAN_COMMUNICATE_WITH_GAMER(int* player) { return invoke<BOOL>(0xA150A4F065806B1F, player); } // 0xA150A4F065806B1F
	static BOOL NETWORK_CAN_ENTER_MULTIPLAYER() { return invoke<BOOL>(0x7E782A910C362C25); } // 0x7E782A910C362C25
	static BOOL _NETWORK_CAN_NETWORK_ID_BE_SEEN(int netId) { return invoke<BOOL>(0xA1607996431332DF, netId); } // 0xA1607996431332DF
	static BOOL NETWORK_CAN_SESSION_END() { return invoke<BOOL>(0x4EEBC3694E49C572); } // 0x4EEBC3694E49C572
	static BOOL NETWORK_CAN_SET_WAYPOINT() { return invoke<BOOL>(0xC927EC229934AF60); } // 0xC927EC229934AF60
	static void NETWORK_CHANGE_TRANSITION_SLOTS(Any p0, Any p1) { invoke<Void>(0xEEEDA5E6D7080987, p0, p1); } // 0xEEEDA5E6D7080987
	static void _NETWORK_CHAT_MUTE(BOOL p0) { invoke<Void>(0x57B192B4D4AD23D5, p0); } // 0x57B192B4D4AD23D5
	static BOOL _NETWORK_CHECK_DATA_MANAGER_FOR_HANDLE(Any* p0) { return invoke<BOOL>(0x796A87B3B68D1F3D, p0); } // 0x796A87B3B68D1F3D
	static BOOL _NETWORK_CLAN_ANIMATION(char* animDict, char* animName) { return invoke<BOOL>(0x729E3401F0430686, animDict, animName); } // 0x729E3401F0430686
	static BOOL NETWORK_CLAN_DOWNLOAD_MEMBERSHIP(int* networkHandle) { return invoke<BOOL>(0xA989044E70010ABE, networkHandle); } // 0xA989044E70010ABE
	static BOOL NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING(Any* p0) { return invoke<BOOL>(0x5B9E023DC6EBEDC0, p0); } // 0x5B9E023DC6EBEDC0
	static BOOL NETWORK_CLAN_GET_MEMBERSHIP(int* p0, int* clanMembership, int p2) { return invoke<BOOL>(0xC8BC2011F67B3411, p0, clanMembership, p2); } // 0xC8BC2011F67B3411
	static int NETWORK_CLAN_GET_MEMBERSHIP_COUNT(int* p0) { return invoke<int>(0xAAB11F6C4ADBC2C1, p0); } // 0xAAB11F6C4ADBC2C1
	static BOOL NETWORK_CLAN_GET_MEMBERSHIP_DESC(int* memberDesc, int p1) { return invoke<BOOL>(0x48DE78AF2C8885B8, memberDesc, p1); } // 0x48DE78AF2C8885B8
	static BOOL NETWORK_CLAN_GET_MEMBERSHIP_VALID(int* p0, Any p1) { return invoke<BOOL>(0x48A59CF88D43DF0E, p0, p1); } // 0x48A59CF88D43DF0E
	static BOOL NETWORK_CLAN_JOIN(int clanDesc) { return invoke<BOOL>(0x9FAAA4F4FC71F87F, clanDesc); } // 0x9FAAA4F4FC71F87F
	static BOOL NETWORK_CLAN_PLAYER_GET_DESC(int* clanDesc, int bufferSize, int* networkHandle) { return invoke<BOOL>(0xEEE6EACBE8874FBA, clanDesc, bufferSize, networkHandle); } // 0xEEE6EACBE8874FBA
	static BOOL NETWORK_CLAN_PLAYER_IS_ACTIVE(int* networkHandle) { return invoke<BOOL>(0xB124B57F571D8F18, networkHandle); } // 0xB124B57F571D8F18
	static BOOL NETWORK_CLAN_REMOTE_MEMBERSHIPS_ARE_IN_CACHE(int* p0) { return invoke<BOOL>(0xBB6E6FEE99D866B2, p0); } // 0xBB6E6FEE99D866B2
	static void NETWORK_CLEAR_CLOCK_TIME_OVERRIDE() { invoke<Void>(0xD972DF67326F966E); } // 0xD972DF67326F966E
	static void NETWORK_CLEAR_FOLLOWERS() { invoke<Void>(0x58F43EC59A8631A); } // 0x58F43EC59A8631A
	static Any NETWORK_CLEAR_FOLLOW_INVITE() { return invoke<Any>(0x439BFDE3CD0610F6); } // 0x439BFDE3CD0610F6
	static void NETWORK_CLEAR_FOUND_GAMERS() { invoke<Void>(0x6D14CCEE1B40381A); } // 0x6D14CCEE1B40381A
	static void NETWORK_CLEAR_PROPERTY_ID() { invoke<Void>(0xC2B82527CA77053E); } // 0xC2B82527CA77053E
	static void NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE() { invoke<Void>(0xFB3272229A82C759); } // 0xFB3272229A82C759
	static void NETWORK_CLEAR_VOICE_CHANNEL() { invoke<Void>(0xE036A705F989E049); } // 0xE036A705F989E049
	static void NETWORK_CLOSE_TRANSITION_MATCHMAKING() { invoke<Void>(0x43F4DBA69710E01E); } // 0x43F4DBA69710E01E
	static int _NETWORK_CONVERT_SYNCHRONISED_SCENE_TO_SYNCHRONIZED_SCENE(int netScene) { return invoke<int>(0x2C40BF885C567B6, netScene); } // 0x2C40BF885C567B6
	static BOOL _NETWORK_COPY_PED_BLEND_DATA(Ped ped, Player player) { return invoke<BOOL>(0x99B72C7ABDE5C910, ped, player); } // 0x99B72C7ABDE5C910
	static int NETWORK_CREATE_SYNCHRONISED_SCENE(float x, float y, float z, float xRot, float yRot, float zRot, int p6, int p7, int p8, float p9) { return invoke<int>(0x7CD6BC4C2BBDD526, x, y, z, xRot, yRot, zRot, p6, p7, p8, p9); } // 0x7CD6BC4C2BBDD526
	static void NETWORK_DISABLE_INVINCIBLE_FLASHING(int player, BOOL p1) { invoke<Void>(0x9DD368BF06983221, player, p1); } // 0x9DD368BF06983221
	static BOOL NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID(Entity entity) { return invoke<BOOL>(0x18A47D074708FD68, entity); } // 0x18A47D074708FD68
	static BOOL NETWORK_DOES_NETWORK_ID_EXIST(int netID) { return invoke<BOOL>(0x38CE16C96BD11344, netID); } // 0x38CE16C96BD11344
	static BOOL NETWORK_DOES_TUNABLE_EXIST(char* tunableContext, char* tunableName) { return invoke<BOOL>(0x85E5F8B9B898B20A, tunableContext, tunableName); } // 0x85E5F8B9B898B20A
	static BOOL _NETWORK_DOES_TUNABLE_EXIST_HASH(Hash tunableContext, Hash tunableName) { return invoke<BOOL>(0xE4E53E1419D81127, tunableContext, tunableName); } // 0xE4E53E1419D81127
	static BOOL NETWORK_DO_TRANSITION_QUICKMATCH(Any p0, Any p1, Any p2, Any p3) { return invoke<BOOL>(0x71FB0EBCD4915D56, p0, p1, p2, p3); } // 0x71FB0EBCD4915D56
	static BOOL NETWORK_DO_TRANSITION_QUICKMATCH_ASYNC(Any p0, Any p1, Any p2, Any p3) { return invoke<BOOL>(0xA091A5E44F0072E5, p0, p1, p2, p3); } // 0xA091A5E44F0072E5
	static BOOL NETWORK_DO_TRANSITION_QUICKMATCH_WITH_GROUP(Any p0, Any p1, Any p2, Any p3, Any* p4, Any p5) { return invoke<BOOL>(0x9C4AB58491FDC98A, p0, p1, p2, p3, p4, p5); } // 0x9C4AB58491FDC98A
	static BOOL NETWORK_DO_TRANSITION_TO_FREEMODE(Any* p0, Any p1, BOOL p2, int players, BOOL p4) { return invoke<BOOL>(0x3AAD8B2FCA1E289F, p0, p1, p2, players, p4); } // 0x3AAD8B2FCA1E289F
	static BOOL NETWORK_DO_TRANSITION_TO_GAME(BOOL p0, int maxPlayers) { return invoke<BOOL>(0x3E9BB38102A589B0, p0, maxPlayers); } // 0x3E9BB38102A589B0
	static BOOL NETWORK_DO_TRANSITION_TO_NEW_FREEMODE(Any* p0, Any* p1, int players, BOOL p3, BOOL p4, BOOL p5) { return invoke<BOOL>(0x9E80A5BA8109F974, p0, p1, players, p3, p4, p5); } // 0x9E80A5BA8109F974
	static BOOL NETWORK_DO_TRANSITION_TO_NEW_GAME(BOOL p0, int maxPlayers, BOOL p2) { return invoke<BOOL>(0x4665F51EFED00034, p0, maxPlayers, p2); } // 0x4665F51EFED00034
	static Any NETWORK_ENABLE_MOTION_DRUGGED() { return invoke<Any>(0xB0CC10720653F3B); } // 0xB0CC10720653F3B
	static void NETWORK_END_TUTORIAL_SESSION() { invoke<Void>(0xD0AFAFF5A51D72F7); } // 0xD0AFAFF5A51D72F7
	static Any NETWORK_EXPLODE_VEHICLE(Vehicle vehicle, BOOL isAudible, BOOL isInvisible, BOOL p3) { return invoke<Any>(0x301A42153C9AD707, vehicle, isAudible, isInvisible, p3); } // 0x301A42153C9AD707
	static void NETWORK_FADE_IN_ENTITY(Entity entity, BOOL state) { invoke<Void>(0x1F4ED342ACEFE62D, entity, state); } // 0x1F4ED342ACEFE62D
	static void NETWORK_FADE_OUT_ENTITY(Entity entity, BOOL normal, BOOL slow) { invoke<Void>(0xDE564951F95E09ED, entity, normal, slow); } // 0xDE564951F95E09ED
	static BOOL NETWORK_FIND_MATCHED_GAMERS(Any p0, float p1, float p2, float p3) { return invoke<BOOL>(0xF7B2CFDE5C9F700D, p0, p1, p2, p3); } // 0xF7B2CFDE5C9F700D
	static void _NETWORK_FORCE_LOCAL_USE_OF_SYNCED_SCENE_CAMERA(int netScene, char* animDict, char* animName) { invoke<Void>(0xCF8BD3B0BD6D42D7, netScene, animDict, animName); } // 0xCF8BD3B0BD6D42D7
	static BOOL NETWORK_GAMER_HAS_HEADSET(Any* p0) { return invoke<BOOL>(0xF2FD55CB574BCC55, p0); } // 0xF2FD55CB574BCC55
	static BOOL NETWORK_GAMERTAG_FROM_HANDLE_PENDING() { return invoke<BOOL>(0xB071E27958EF4CF0); } // 0xB071E27958EF4CF0
	static BOOL NETWORK_GAMERTAG_FROM_HANDLE_START(int* networkHandle) { return invoke<BOOL>(0x9F0C0A981D73FA56, networkHandle); } // 0x9F0C0A981D73FA56
	static BOOL NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED() { return invoke<BOOL>(0xFD00798DBA7523DD); } // 0xFD00798DBA7523DD
	static int NETWORK_GET_ACTIVITY_PLAYER_NUM(BOOL p0) { return invoke<int>(0x73E2B500410DA5A2, p0); } // 0x73E2B500410DA5A2
	static BOOL NETWORK_GET_BACKGROUND_LOADING_RECIPIENTS(Any p0, Any p1, Any* p2, Any* p3) { return invoke<BOOL>(0x97A770BEEF227E2B, p0, p1, p2, p3); } // 0x97A770BEEF227E2B
	static BOOL NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(Any* p0) { return invoke<BOOL>(0x74881E6BCAE2327C, p0); } // 0x74881E6BCAE2327C
	static BOOL _NETWORK_GET_DESROYER_OF_ENTITY(Any p0, Any p1, Hash* weaponHash) { return invoke<BOOL>(0x4CACA84440FA26F6, p0, p1, weaponHash); } // 0x4CACA84440FA26F6
	static int NETWORK_GET_DESTROYER_OF_NETWORK_ID(int netId, Hash* weaponHash) { return invoke<int>(0x7A1ADEEF01740A24, netId, weaponHash); } // 0x7A1ADEEF01740A24
	static Entity NETWORK_GET_ENTITY_FROM_NETWORK_ID(int netId) { return invoke<Entity>(0xCE4E5D9B0A4FF560, netId); } // 0xCE4E5D9B0A4FF560
	static BOOL NETWORK_GET_ENTITY_IS_LOCAL(Entity entity) { return invoke<BOOL>(0x991549DE4D64762, entity); } // 0x991549DE4D64762
	static BOOL NETWORK_GET_ENTITY_IS_NETWORKED(Entity entity) { return invoke<BOOL>(0xC7827959479DCC78, entity); } // 0xC7827959479DCC78
	static Entity NETWORK_GET_ENTITY_KILLER_OF_PLAYER(Player player, Hash* weaponHash) { return invoke<Entity>(0x42B2DAA6B596F5F8, player, weaponHash); } // 0x42B2DAA6B596F5F8
	static BOOL NETWORK_GET_FOUND_GAMER(Any* p0, Any p1) { return invoke<BOOL>(0x9DCFF2AFB68B3476, p0, p1); } // 0x9DCFF2AFB68B3476
	static int NETWORK_GET_FRIEND_COUNT() { return invoke<int>(0x203F1CFD823B27A4); } // 0x203F1CFD823B27A4
	static char* NETWORK_GET_FRIEND_NAME(int friendIndex) { return invoke<char*>(0xE11EBBB2A783FE8B, friendIndex); } // 0xE11EBBB2A783FE8B
	static char* _NETWORK_GET_FRIEND_NAME_FROM_INDEX(int friendIndex) { return invoke<char*>(0x4164F227D052E293, friendIndex); } // 0x4164F227D052E293
	static char* NETWORK_GET_GAMERTAG_FROM_HANDLE(int* networkHandle) { return invoke<char*>(0x426141162EBE5CDB, networkHandle); } // 0x426141162EBE5CDB
	static int NETWORK_GET_HOST_OF_SCRIPT(char* scriptName, int p1, int p2) { return invoke<int>(0x1D6A14F1F9A736FC, scriptName, p1, p2); } // 0x1D6A14F1F9A736FC
	static Any NETWORK_GET_HOST_OF_THIS_SCRIPT() { return invoke<Any>(0xC7B4D79B01FA7A5C); } // 0xC7B4D79B01FA7A5C
	static void NETWORK_GET_LOCAL_HANDLE(int* networkHandle, int bufferSize) { invoke<Void>(0xE86051786B66CD8E, networkHandle, bufferSize); } // 0xE86051786B66CD8E
	static int NETWORK_GET_MAX_FRIENDS() { return invoke<int>(0xAFEBB0D5D8F687D2); } // 0xAFEBB0D5D8F687D2
	static int NETWORK_GET_NETWORK_ID_FROM_ENTITY(Entity entity) { return invoke<int>(0xA11700682F3AD45C, entity); } // 0xA11700682F3AD45C
	static int NETWORK_GET_NUM_CONNECTED_PLAYERS() { return invoke<int>(0xA4A79DD2D9600654); } // 0xA4A79DD2D9600654
	static int NETWORK_GET_NUM_FOUND_GAMERS() { return invoke<int>(0xA1B043EE79A916FB); } // 0xA1B043EE79A916FB
	static int NETWORK_GET_NUM_PARTICIPANTS() { return invoke<int>(0x18D0456E86604654); } // 0x18D0456E86604654
	static int _NETWORK_GET_NUM_PARTICIPANTS_HOST() { return invoke<int>(0xA6C90FBC38E395EE); } // 0xA6C90FBC38E395EE
	static int NETWORK_GET_NUM_PRESENCE_INVITES() { return invoke<int>(0xCEFA968912D0F78D); } // 0xCEFA968912D0F78D
	static int NETWORK_GET_NUM_SCRIPT_PARTICIPANTS(Any* p0, Any p1, Any p2) { return invoke<int>(0x3658E8CD94FC121A, p0, p1, p2); } // 0x3658E8CD94FC121A
	static int NETWORK_GET_PARTICIPANT_INDEX(int index) { return invoke<int>(0x1B84DF6AF2A46938, index); } // 0x1B84DF6AF2A46938
	static Vector3 _NETWORK_GET_PLAYER_COORDS(Player player) { return invoke<Vector3>(0x125E6D638B8605D4, player); } // 0x125E6D638B8605D4
	static BOOL _NETWORK_GET_PLAYER_CREW_EMBLEM_TXD_NAME(Player* player, Any* p1) { return invoke<BOOL>(0x5835D9CD92E83184, player, p1); } // 0x5835D9CD92E83184
	static Player NETWORK_GET_PLAYER_FROM_GAMER_HANDLE(int* networkHandle) { return invoke<Player>(0xCE5F689CF5A0A49D, networkHandle); } // 0xCE5F689CF5A0A49D
	static int NETWORK_GET_PLAYER_INDEX(Player player) { return invoke<int>(0x24FB80D107371267, player); } // 0x24FB80D107371267
	static Player NETWORK_GET_PLAYER_INDEX_FROM_PED(Ped ped) { return invoke<Player>(0x6C0E2E0125610278, ped); } // 0x6C0E2E0125610278
	static float NETWORK_GET_PLAYER_LOUDNESS(Any p0) { return invoke<float>(0x21A1684A25C2867F, p0); } // 0x21A1684A25C2867F
	static BOOL NETWORK_GET_PRESENCE_INVITE_HANDLE(Any p0, Any* p1) { return invoke<BOOL>(0x38D5B0FEBB086F75, p0, p1); } // 0x38D5B0FEBB086F75
	static Any NETWORK_GET_PRESENCE_INVITE_ID(Any p0) { return invoke<Any>(0xDFF09646E12EC386, p0); } // 0xDFF09646E12EC386
	static Any NETWORK_GET_PRESENCE_INVITE_INVITER(Any p0) { return invoke<Any>(0x4962CC4AA2F345B7, p0); } // 0x4962CC4AA2F345B7
	static Any NETWORK_GET_PRESENCE_INVITE_SESSION_ID(Any p0) { return invoke<Any>(0x26E1CD96B0903D60, p0); } // 0x26E1CD96B0903D60
	static void NETWORK_GET_PRIMARY_CLAN_DATA_CANCEL() { invoke<Void>(0x42E4B70B93E6054); } // 0x42E4B70B93E6054
	static Any NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR() { return invoke<Any>(0x9AA46BADAD0E27ED); } // 0x9AA46BADAD0E27ED
	static BOOL NETWORK_GET_PRIMARY_CLAN_DATA_NEW(Any* p0, Any* p1) { return invoke<BOOL>(0xC080FF658B2E41DA, p0, p1); } // 0xC080FF658B2E41DA
	static Any NETWORK_GET_PRIMARY_CLAN_DATA_PENDING() { return invoke<Any>(0xB5074DB804E28CE7); } // 0xB5074DB804E28CE7
	static BOOL NETWORK_GET_PRIMARY_CLAN_DATA_START(Any* p0, Any p1) { return invoke<BOOL>(0xCE86D8191B762107, p0, p1); } // 0xCE86D8191B762107
	static Any NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS() { return invoke<Any>(0x5B4F04F19376A0BA); } // 0x5B4F04F19376A0BA
	static int NETWORK_GET_RANDOM_INT() { return invoke<int>(0x599E4FA1F87EB5FF); } // 0x599E4FA1F87EB5FF
	static int _NETWORK_GET_RANDOM_INT_IN_RANGE(int rangeStart, int rangeEnd) { return invoke<int>(0xE30CF56F1EFA5F43, rangeStart, rangeEnd); } // 0xE30CF56F1EFA5F43
	static void NETWORK_GET_RESPAWN_RESULT(int randomInt, Vector3* coordinates, float* heading) { invoke<Void>(0x371EA43692861CF1, randomInt, coordinates, heading); } // 0x371EA43692861CF1
	static int NETWORK_GET_SCRIPT_STATUS() { return invoke<int>(0x57D158647A6BFABF); } // 0x57D158647A6BFABF
	static void _NETWORK_GET_SERVER_TIME(int* hours, int* minutes, int* seconds) { invoke<Void>(0x6D03BFBD643B2A02, hours, minutes, seconds); } // 0x6D03BFBD643B2A02
	static Any NETWORK_GET_TALKER_PROXIMITY() { return invoke<Any>(0x84F0F13120B4E098); } // 0x84F0F13120B4E098
	static BOOL NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT() { return invoke<BOOL>(0x2910669969E9535E); } // 0x2910669969E9535E
	static int NETWORK_GET_TIMEOUT_TIME() { return invoke<int>(0x5ED0356A0CE3A34F); } // 0x5ED0356A0CE3A34F
	static BOOL NETWORK_GET_TRANSITION_HOST(int* networkHandle) { return invoke<BOOL>(0x65042B9774C4435E, networkHandle); } // 0x65042B9774C4435E
	static Any NETWORK_GET_TRANSITION_MEMBERS(Any* p0, Any p1) { return invoke<Any>(0x73B000F7FBC55829, p0, p1); } // 0x73B000F7FBC55829
	static void NETWORK_HANDLE_FROM_FRIEND(Player friendIndex, int* networkHandle, int bufferSize) { invoke<Void>(0xD45CB817D7E177D2, friendIndex, networkHandle, bufferSize); } // 0xD45CB817D7E177D2
	static void NETWORK_HANDLE_FROM_MEMBER_ID(char* memberId, int* networkHandle, int bufferSize) { invoke<Void>(0xA0FD21BED61E5C4C, memberId, networkHandle, bufferSize); } // 0xA0FD21BED61E5C4C
	static void NETWORK_HANDLE_FROM_PLAYER(Player player, int* networkHandle, int bufferSize) { invoke<Void>(0x388EB2B86C73B6B3, player, networkHandle, bufferSize); } // 0x388EB2B86C73B6B3
	static void NETWORK_HANDLE_FROM_USER_ID(char* userId, int* networkHandle, int bufferSize) { invoke<Void>(0xDCD51DD8F87AEC5C, userId, networkHandle, bufferSize); } // 0xDCD51DD8F87AEC5C
	static BOOL NETWORK_HAS_CONTROL_OF_DOOR(Hash doorHash) { return invoke<BOOL>(0xCB3C68ADB06195DF, doorHash); } // 0xCB3C68ADB06195DF
	static BOOL NETWORK_HAS_CONTROL_OF_ENTITY(Entity entity) { return invoke<BOOL>(0x1BF60A500E28887, entity); } // 0x1BF60A500E28887
	static BOOL NETWORK_HAS_CONTROL_OF_NETWORK_ID(int netId) { return invoke<BOOL>(0x4D36070FE0215186, netId); } // 0x4D36070FE0215186
	static BOOL _NETWORK_HAS_CONTROL_OF_PAVEMENT_STATS(Hash doorHash) { return invoke<BOOL>(0xC01E93FAC20C3346, doorHash); } // 0xC01E93FAC20C3346
	static BOOL NETWORK_HAS_CONTROL_OF_PICKUP(Pickup pickup) { return invoke<BOOL>(0x5BC9495F0B3B6FA6, pickup); } // 0x5BC9495F0B3B6FA6
	static BOOL NETWORK_HAS_FOLLOW_INVITE() { return invoke<BOOL>(0x76D9B976C4C09FDE); } // 0x76D9B976C4C09FDE
	static BOOL NETWORK_HAS_HEADSET() { return invoke<BOOL>(0xE870F9F1F7B4F1FA); } // 0xE870F9F1F7B4F1FA
	static Hash _NETWORK_HASH_FROM_GAMER_HANDLE(int* networkHandle) { return invoke<Hash>(0x58575AC3CF2CA8EC, networkHandle); } // 0x58575AC3CF2CA8EC
	static Hash _NETWORK_HASH_FROM_PLAYER_HANDLE(Player player) { return invoke<Hash>(0xBC1D768F2F5D6C05, player); } // 0xBC1D768F2F5D6C05
	static BOOL NETWORK_HAS_INVITED_GAMER(Any* p0) { return invoke<BOOL>(0x4D86CD31E8976ECE, p0); } // 0x4D86CD31E8976ECE
	static BOOL NETWORK_HAS_INVITED_GAMER_TO_TRANSITION(Any* p0) { return invoke<BOOL>(0x7284A47B3540E6CF, p0); } // 0x7284A47B3540E6CF
	static BOOL NETWORK_HAS_PENDING_INVITE() { return invoke<BOOL>(0xAC8C7B9B88C4A668); } // 0xAC8C7B9B88C4A668
	static BOOL NETWORK_HAS_PLAYER_STARTED_TRANSITION(Player player) { return invoke<BOOL>(0x9AC9CCBFA8C29795, player); } // 0x9AC9CCBFA8C29795
	static BOOL NETWORK_HAVE_ONLINE_PRIVILEGES() { return invoke<BOOL>(0x25CB5A9F37BFD063); } // 0x25CB5A9F37BFD063
	static BOOL NETWORK_HOST_TRANSITION(int p0, int p1, int p2, int p3, Any p4, BOOL p5, BOOL p6, int p7, Any p8, int p9) { return invoke<BOOL>(0xA60BB5CE242BB254, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); } // 0xA60BB5CE242BB254
	static BOOL NETWORK_INVITE_GAMERS(Any* p0, Any p1, Any* p2, Any* p3) { return invoke<BOOL>(0x9D80CD1D0E6327DE, p0, p1, p2, p3); } // 0x9D80CD1D0E6327DE
	static BOOL NETWORK_INVITE_GAMERS_TO_TRANSITION(Any* p0, Any p1) { return invoke<BOOL>(0x4A595C32F77DFF76, p0, p1); } // 0x4A595C32F77DFF76
	static BOOL NETWORK_IS_ACTIVITY_SESSION() { return invoke<BOOL>(0x5095437424397FA); } // 0x5095437424397FA
	static Any NETWORK_IS_ACTIVITY_SPECTATOR() { return invoke<Any>(0x12103B9E0C9F92FB); } // 0x12103B9E0C9F92FB
	static BOOL NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE(int* networkHandle) { return invoke<BOOL>(0x2763BBAA72A7BCB9, networkHandle); } // 0x2763BBAA72A7BCB9
	static BOOL NETWORK_IS_ADDING_FRIEND() { return invoke<BOOL>(0x6EA101606F6E4D81); } // 0x6EA101606F6E4D81
	static BOOL NETWORK_IS_CABLE_CONNECTED() { return invoke<BOOL>(0xEFFB25453D8600F9); } // 0xEFFB25453D8600F9
	static BOOL NETWORK_IS_CHATTING_IN_PLATFORM_PARTY(int* networkHandle) { return invoke<BOOL>(0x8DE9945BCC9AEC52, networkHandle); } // 0x8DE9945BCC9AEC52
	static BOOL _NETWORK_IS_CLAN_MEMBERSHIP_FINISHED_DOWNLOADING() { return invoke<BOOL>(0xB3F64A6A91432477); } // 0xB3F64A6A91432477
	static BOOL NETWORK_IS_CLOCK_TIME_OVERRIDDEN() { return invoke<BOOL>(0xD7C95D322FF57522); } // 0xD7C95D322FF57522
	static BOOL NETWORK_IS_CLOUD_AVAILABLE() { return invoke<BOOL>(0x9A4CF4F48AD77302); } // 0x9A4CF4F48AD77302
	static BOOL NETWORK_IS_FINDING_GAMERS() { return invoke<BOOL>(0xDDDF64C91BFCF0AA); } // 0xDDDF64C91BFCF0AA
	static BOOL NETWORK_IS_FRIEND(int* networkHandle) { return invoke<BOOL>(0x1A24A179F9B31654, networkHandle); } // 0x1A24A179F9B31654
	static BOOL NETWORK_IS_FRIEND_INDEX_ONLINE(int friendIndex) { return invoke<BOOL>(0xBAD8F2A42B844821, friendIndex); } // 0xBAD8F2A42B844821
	static BOOL NETWORK_IS_FRIEND_IN_MULTIPLAYER(char* friendName) { return invoke<BOOL>(0x57005C18827F3A28, friendName); } // 0x57005C18827F3A28
	static BOOL NETWORK_IS_FRIEND_IN_SAME_TITLE(char* friendName) { return invoke<BOOL>(0x2EA9A3BEDF3F17B8, friendName); } // 0x2EA9A3BEDF3F17B8
	static BOOL NETWORK_IS_FRIEND_ONLINE(char* name) { return invoke<BOOL>(0x425A44533437B64D, name); } // 0x425A44533437B64D
	static BOOL _NETWORK_IS_FRIEND_ONLINE_2(int* networkHandle) { return invoke<BOOL>(0x87EB7A3FFCB314DB, networkHandle); } // 0x87EB7A3FFCB314DB
	static BOOL NETWORK_IS_GAME_IN_PROGRESS() { return invoke<BOOL>(0x10FAB35428CCC9D7); } // 0x10FAB35428CCC9D7
	static BOOL NETWORK_IS_GAMER_BLOCKED_BY_ME(Any* p0) { return invoke<BOOL>(0xE944C4F5AF1B5883, p0); } // 0xE944C4F5AF1B5883
	static BOOL NETWORK_IS_GAMER_IN_MY_SESSION(int* networkHandle) { return invoke<BOOL>(0xF10B05DDF8D16E9, networkHandle); } // 0xF10B05DDF8D16E9
	static BOOL NETWORK_IS_GAMER_MUTED_BY_ME(int* p0) { return invoke<BOOL>(0xCE60DE011B6C7978, p0); } // 0xCE60DE011B6C7978
	static BOOL NETWORK_IS_GAMER_TALKING(int* p0) { return invoke<BOOL>(0x71C33B22606CD88A, p0); } // 0x71C33B22606CD88A
	static BOOL NETWORK_IS_HANDLE_VALID(int* networkHandle, int bufferSize) { return invoke<BOOL>(0x6F79B93B0A8E4133, networkHandle, bufferSize); } // 0x6F79B93B0A8E4133
	static BOOL NETWORK_IS_HOST() { return invoke<BOOL>(0x8DB296B814EDDA07); } // 0x8DB296B814EDDA07
	static BOOL NETWORK_IS_HOST_OF_THIS_SCRIPT() { return invoke<BOOL>(0x83CD99A1E6061AB5); } // 0x83CD99A1E6061AB5
	static BOOL NETWORK_IS_INACTIVE_PROFILE(Any* p0) { return invoke<BOOL>(0x7E58745504313A2E, p0); } // 0x7E58745504313A2E
	static BOOL NETWORK_IS_IN_MP_CUTSCENE() { return invoke<BOOL>(0x6CC27C9FA2040220); } // 0x6CC27C9FA2040220
	static BOOL NETWORK_IS_IN_PARTY() { return invoke<BOOL>(0x966C2BC2A7FE3F30); } // 0x966C2BC2A7FE3F30
	static BOOL NETWORK_IS_IN_SESSION() { return invoke<BOOL>(0xCA97246103B63917); } // 0xCA97246103B63917
	static BOOL NETWORK_IS_IN_SPECTATOR_MODE() { return invoke<BOOL>(0x48746E388762E11); } // 0x48746E388762E11
	static BOOL NETWORK_IS_IN_TRANSITION() { return invoke<BOOL>(0x68049AEFF83D8F0A); } // 0x68049AEFF83D8F0A
	static Any NETWORK_IS_IN_TUTORIAL_SESSION() { return invoke<Any>(0xADA24309FE08DACF); } // 0xADA24309FE08DACF
	static BOOL NETWORK_IS_LOCAL_PLAYER_INVINCIBLE() { return invoke<BOOL>(0x8A8694B48715B000); } // 0x8A8694B48715B000
	static ScrHandle NETWORK_IS_MULTIPLAYER_DISABLED() { return invoke<ScrHandle>(0x9747292807126EDA); } // 0x9747292807126EDA
	static BOOL NETWORK_IS_PARTICIPANT_ACTIVE(int p0) { return invoke<BOOL>(0x6FF8FF40B6357D45, p0); } // 0x6FF8FF40B6357D45
	static BOOL NETWORK_IS_PARTY_MEMBER(int* networkHandle) { return invoke<BOOL>(0x676ED266AADD31E0, networkHandle); } // 0x676ED266AADD31E0
	static BOOL NETWORK_IS_PENDING_FRIEND(Any p0) { return invoke<BOOL>(0xBE73DA6984A6E33, p0); } // 0xBE73DA6984A6E33
	static BOOL NETWORK_IS_PLAYER_ACTIVE(Player player) { return invoke<BOOL>(0xB8DFD30D6973E135, player); } // 0xB8DFD30D6973E135
	static void NETWORK_IS_PLAYER_ANIMATION_DRAWING_SYNCHRONIZED() { invoke<Void>(0xC6F8AB8A4189CF3A); } // 0xC6F8AB8A4189CF3A
	static BOOL NETWORK_IS_PLAYER_A_PARTICIPANT(Any p0) { return invoke<BOOL>(0x3CA58F6CB7CBD784, p0); } // 0x3CA58F6CB7CBD784
	static BOOL NETWORK_IS_PLAYER_BLOCKED_BY_ME(Player player) { return invoke<BOOL>(0x57AF1F8E27483721, player); } // 0x57AF1F8E27483721
	static BOOL NETWORK_IS_PLAYER_CONNECTED(Player player) { return invoke<BOOL>(0x93DC1BE4E1ABE9D1, player); } // 0x93DC1BE4E1ABE9D1
	static BOOL _NETWORK_IS_PLAYER_EQUAL_TO_INDEX(Player player, int index) { return invoke<BOOL>(0x9DE986FC9A87C474, player, index); } // 0x9DE986FC9A87C474
	static BOOL NETWORK_IS_PLAYER_IN_MP_CUTSCENE(Player player) { return invoke<BOOL>(0x63F9EE203C3619F2, player); } // 0x63F9EE203C3619F2
	static BOOL _NETWORK_IS_PLAYER_IN_SCRIPT(Player player, int p1, Hash scriptHash) { return invoke<BOOL>(0x46FB3ED415C7641C, player, p1, scriptHash); } // 0x46FB3ED415C7641C
	static BOOL NETWORK_IS_PLAYER_MUTED_BY_ME(Player player) { return invoke<BOOL>(0x8C71288AE68EDE39, player); } // 0x8C71288AE68EDE39
	static BOOL NETWORK_IS_PLAYER_TALKING(Player player) { return invoke<BOOL>(0x31E11F3D447647E, player); } // 0x31E11F3D447647E
	static BOOL _NETWORK_IS_PSN_AVAILABLE() { return invoke<BOOL>(0x8D11E61A4ABF49CC); } // 0x8D11E61A4ABF49CC
	static BOOL NETWORK_IS_SCRIPT_ACTIVE(char* scriptName, Player player, BOOL p2, Any p3) { return invoke<BOOL>(0x9D40DF90FAD26098, scriptName, player, p2, p3); } // 0x9D40DF90FAD26098
	static BOOL NETWORK_IS_SESSION_ACTIVE() { return invoke<BOOL>(0xD83C2B94E7508980); } // 0xD83C2B94E7508980
	static BOOL NETWORK_IS_SESSION_BUSY() { return invoke<BOOL>(0xF4435D66A8E2905E); } // 0xF4435D66A8E2905E
	static BOOL NETWORK_IS_SESSION_STARTED() { return invoke<BOOL>(0x9DE624D2FC4B603F); } // 0x9DE624D2FC4B603F
	static BOOL NETWORK_IS_SIGNED_IN() { return invoke<BOOL>(0x54354A99211EB96); } // 0x54354A99211EB96
	static BOOL NETWORK_IS_SIGNED_ONLINE() { return invoke<BOOL>(0x1077788E268557C2); } // 0x1077788E268557C2
	static BOOL _NETWORK_IS_TEXT_CHAT_ACTIVE() { return invoke<BOOL>(0x5FCF4D7069B09026); } // 0x5FCF4D7069B09026
	static BOOL _NETWORK_IS_THIS_SCRIPT_MARKED(Any p0, BOOL p1, Any p2) { return invoke<BOOL>(0xD1110739EEADB592, p0, p1, p2); } // 0xD1110739EEADB592
	static Any NETWORK_IS_TRANSITION_BUSY() { return invoke<Any>(0x520F3282A53D26B7); } // 0x520F3282A53D26B7
	static Any NETWORK_IS_TRANSITION_HOST() { return invoke<Any>(0xB824797C9BF2159); } // 0xB824797C9BF2159
	static BOOL NETWORK_IS_TRANSITION_HOST_FROM_HANDLE(int* networkHandle) { return invoke<BOOL>(0x6B5C83BA3EFE6A10, networkHandle); } // 0x6B5C83BA3EFE6A10
	static Any NETWORK_IS_TRANSITION_MATCHMAKING() { return invoke<Any>(0x292564C735375EDF); } // 0x292564C735375EDF
	static BOOL NETWORK_IS_TRANSITION_STARTED() { return invoke<BOOL>(0x53FA83401D9C07FE); } // 0x53FA83401D9C07FE
	static Any NETWORK_IS_TRANSITION_TO_GAME() { return invoke<Any>(0x9D7696D8F4FA6CB7); } // 0x9D7696D8F4FA6CB7
	static Any NETWORK_JOIN_GROUP_ACTIVITY() { return invoke<Any>(0xA06509A691D12BE4); } // 0xA06509A691D12BE4
	static BOOL NETWORK_JOIN_TRANSITION(Player player) { return invoke<BOOL>(0x9D060B08CD63321A, player); } // 0x9D060B08CD63321A
	static Any NETWORK_LAUNCH_TRANSITION() { return invoke<Any>(0x2DCF46CB1A4F0884); } // 0x2DCF46CB1A4F0884
	static Any NETWORK_LEAVE_TRANSITION() { return invoke<Any>(0xD23A1A815D21DB19); } // 0xD23A1A815D21DB19
	static BOOL NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED(Any* p0) { return invoke<BOOL>(0x5728BB6D63E3FF1D, p0); } // 0x5728BB6D63E3FF1D
	static char* NETWORK_MEMBER_ID_FROM_GAMER_HANDLE(int* networkHandle) { return invoke<char*>(0xC82630132081BB6F, networkHandle); } // 0xC82630132081BB6F
	static void NETWORK_OPEN_TRANSITION_MATCHMAKING() { invoke<Void>(0x2B3A8F7CA3A38FDE); } // 0x2B3A8F7CA3A38FDE
	static void NETWORK_OVERRIDE_CHAT_RESTRICTIONS(Player player, BOOL toggle) { invoke<Void>(0x3039AE5AD2C9C0C4, player, toggle); } // 0x3039AE5AD2C9C0C4
	static void NETWORK_OVERRIDE_CLOCK_TIME(int Hours, int Minutes, int Seconds) { invoke<Void>(0xE679E3E06E363892, Hours, Minutes, Seconds); } // 0xE679E3E06E363892
	static void NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS(Player player, BOOL toggle) { invoke<Void>(0xDDF73E2B1FEC5AB4, player, toggle); } // 0xDDF73E2B1FEC5AB4
	static void _NETWORK_OVERRIDE_SEND_RESTRICTIONS(Player player, BOOL toggle) { invoke<Void>(0x97DD4C5944CC2E6A, player, toggle); } // 0x97DD4C5944CC2E6A
	static void NETWORK_OVERRIDE_TRANSITION_CHAT(BOOL p0) { invoke<Void>(0xAF66059A131AA269, p0); } // 0xAF66059A131AA269
	static char* NETWORK_PLAYER_GET_NAME(Player player) { return invoke<char*>(0x7718D2E2060837D2, player); } // 0x7718D2E2060837D2
	static char* NETWORK_PLAYER_GET_USERID(Player player, char* userID) { return invoke<char*>(0x4927FC39CD0869A0, player, userID); } // 0x4927FC39CD0869A0
	static BOOL NETWORK_PLAYER_HAS_HEADSET(Player player) { return invoke<BOOL>(0x3FB99A8B08D18FD6, player); } // 0x3FB99A8B08D18FD6
	static BOOL NETWORK_PLAYER_IS_BADSPORT() { return invoke<BOOL>(0x19D8DA0E5A68045A); } // 0x19D8DA0E5A68045A
	static BOOL NETWORK_PLAYER_IS_CHEATER() { return invoke<BOOL>(0x655B91F1495A9090); } // 0x655B91F1495A9090
	static BOOL _NETWORK_PLAYER_IS_IN_CLAN() { return invoke<BOOL>(0x579CCED0265D4896); } // 0x579CCED0265D4896
	static BOOL NETWORK_PLAYER_IS_ROCKSTAR_DEV(Player player) { return invoke<BOOL>(0x544ABDDA3B409B6D, player); } // 0x544ABDDA3B409B6D
	static BOOL _NETWORK_PLAYER_IS_UNK() { return invoke<BOOL>(0x172F75B6EE2233BA); } // 0x172F75B6EE2233BA
	static BOOL _NETWORK_PLAYER_SOMETHING(Player player) { return invoke<BOOL>(0x565E430DB3B05BEC, player); } // 0x565E430DB3B05BEC
	static void NETWORK_REGISTER_ENTITY_AS_NETWORKED(Entity entity) { invoke<Void>(0x6FAACD625D80CAA, entity); } // 0x6FAACD625D80CAA
	static void NETWORK_REGISTER_HOST_BROADCAST_VARIABLES(int* vars, int sizeofVars) { invoke<Void>(0x3E9B2F01C50DF595, vars, sizeofVars); } // 0x3E9B2F01C50DF595
	static void NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES(int* vars, int numVars) { invoke<Void>(0x3364AA97340CA215, vars, numVars); } // 0x3364AA97340CA215
	static void NETWORK_REMOVE_ALL_TRANSITION_INVITE() { invoke<Void>(0x726E0375C7A26368); } // 0x726E0375C7A26368
	static BOOL NETWORK_REMOVE_ENTITY_AREA(Any p0) { return invoke<BOOL>(0x93CF869BAA0C4874, p0); } // 0x93CF869BAA0C4874
	static BOOL NETWORK_REMOVE_PRESENCE_INVITE(Any p0) { return invoke<BOOL>(0xF0210268DB0974B1, p0); } // 0xF0210268DB0974B1
	static void NETWORK_REMOVE_TRANSITION_INVITE(Any* p0) { invoke<Void>(0x7524B431B2E6F7EE, p0); } // 0x7524B431B2E6F7EE
	static BOOL _NETWORK_REQUEST_CLOUD_BACKGROUND_SCRIPTS() { return invoke<BOOL>(0x924426BFFD82E915); } // 0x924426BFFD82E915
	static void NETWORK_REQUEST_CLOUD_TUNABLES() { invoke<Void>(0x42FB3B532D526E6C); } // 0x42FB3B532D526E6C
	static BOOL NETWORK_REQUEST_CONTROL_OF_DOOR(int doorID) { return invoke<BOOL>(0x870DDFD5A4A796E4, doorID); } // 0x870DDFD5A4A796E4
	static BOOL NETWORK_REQUEST_CONTROL_OF_ENTITY(Entity entity) { return invoke<BOOL>(0xB69317BF5E782347, entity); } // 0xB69317BF5E782347
	static BOOL NETWORK_REQUEST_CONTROL_OF_NETWORK_ID(int netId) { return invoke<BOOL>(0xA670B3662FAFFBD0, netId); } // 0xA670B3662FAFFBD0
	static void NETWORK_RESET_BODY_TRACKER() { invoke<Void>(0x72433699B4E6DD64); } // 0x72433699B4E6DD64
	static void _NETWORK_RESPAWN_COORDS(Player player, float x, float y, float z, BOOL p4, BOOL p5) { invoke<Void>(0x9769F811D1785B03, player, x, y, z, p4, p5); } // 0x9769F811D1785B03
	static void NETWORK_RESURRECT_LOCAL_PLAYER(float x, float y, float z, float heading, BOOL unk, BOOL changetime) { invoke<Void>(0xEA23C49EAA83ACFB, x, y, z, heading, unk, changetime); } // 0xEA23C49EAA83ACFB
	static void _NETWORK_SCTV_SLOTS(int p0) { invoke<Void>(0x49EC8030F5015F8B, p0); } // 0x49EC8030F5015F8B
	static BOOL _NETWORK_SEND_PRESENCE_INVITE(int* networkHandle, Any* p1, Any p2, Any p3) { return invoke<BOOL>(0xC3C7A6AFDB244624, networkHandle, p1, p2, p3); } // 0xC3C7A6AFDB244624
	static BOOL _NETWORK_SEND_PRESENCE_TRANSITION_INVITE(Any* p0, Any* p1, Any p2, Any p3) { return invoke<BOOL>(0xC116FF9B4D488291, p0, p1, p2, p3); } // 0xC116FF9B4D488291
	static BOOL NETWORK_SEND_TEXT_MESSAGE(char* message, int* networkHandle) { return invoke<BOOL>(0x3A214F2EC889B100, message, networkHandle); } // 0x3A214F2EC889B100
	static BOOL NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION(int* networkHandle, char* p1, int p2, int p3, BOOL p4) { return invoke<BOOL>(0x31D1D2B858D25E6B, networkHandle, p1, p2, p3, p4); } // 0x31D1D2B858D25E6B
	static BOOL NETWORK_SESSION_ACTIVITY_QUICKMATCH(Any p0, Any p1, Any p2, Any p3) { return invoke<BOOL>(0xBE3E347A87ACEB82, p0, p1, p2, p3); } // 0xBE3E347A87ACEB82
	static void NETWORK_SESSION_BLOCK_JOIN_REQUESTS(BOOL p0) { invoke<Void>(0xA73667484D7037C3, p0); } // 0xA73667484D7037C3
	static void NETWORK_SESSION_CANCEL_INVITE() { invoke<Void>(0x2FBF47B1B36D36F9); } // 0x2FBF47B1B36D36F9
	static void NETWORK_SESSION_CHANGE_SLOTS(int p0, BOOL p1) { invoke<Void>(0xB4AB419E0D86ACAE, p0, p1); } // 0xB4AB419E0D86ACAE
	static BOOL NETWORK_SESSION_CREW_MATCHMAKING(int p0, int p1, int p2, int maxPlayers, BOOL p4) { return invoke<BOOL>(0x94BC51E9449D917F, p0, p1, p2, maxPlayers, p4); } // 0x94BC51E9449D917F
	static BOOL NETWORK_SESSION_END(BOOL p0, BOOL p1) { return invoke<BOOL>(0xA02E59562D711006, p0, p1); } // 0xA02E59562D711006
	static Any NETWORK_SESSION_ENTER(Any p0, Any p1, Any p2, int maxPlayers, Any p4, Any p5) { return invoke<Any>(0x330ED4D05491934F, p0, p1, p2, maxPlayers, p4, p5); } // 0x330ED4D05491934F
	static void NETWORK_SESSION_FORCE_CANCEL_INVITE() { invoke<Void>(0xA29177F7703B5644); } // 0xA29177F7703B5644
	static BOOL NETWORK_SESSION_FRIEND_MATCHMAKING(int p0, int p1, int maxPlayers, BOOL p3) { return invoke<BOOL>(0x2CFC76E0D087C994, p0, p1, maxPlayers, p3); } // 0x2CFC76E0D087C994
	static void NETWORK_SESSION_GET_INVITER(int* networkHandle) { invoke<Void>(0xE57397B4A3429DD0, networkHandle); } // 0xE57397B4A3429DD0
	static int _NETWORK_SESSION_GET_UNK(int p0) { return invoke<int>(0x56CE820830EF040B, p0); } // 0x56CE820830EF040B
	static BOOL NETWORK_SESSION_HOST(int p0, int maxPlayers, BOOL p2) { return invoke<BOOL>(0x6F3D4ED9BEE4E61D, p0, maxPlayers, p2); } // 0x6F3D4ED9BEE4E61D
	static BOOL NETWORK_SESSION_HOST_CLOSED(int p0, int maxPlayers) { return invoke<BOOL>(0xED34C0C02C098BB7, p0, maxPlayers); } // 0xED34C0C02C098BB7
	static void _NETWORK_SESSION_HOSTED(BOOL p0) { invoke<Void>(0xC19F6C8E7865A6FF, p0); } // 0xC19F6C8E7865A6FF
	static BOOL NETWORK_SESSION_HOST_FRIENDS_ONLY(int p0, int maxPlayers) { return invoke<BOOL>(0xB9CFD27A5D578D83, p0, maxPlayers); } // 0xB9CFD27A5D578D83
	static void NETWORK_SESSION_HOST_SINGLE_PLAYER(int p0) { invoke<Void>(0xC74C33FCA52856D5, p0); } // 0xC74C33FCA52856D5
	static BOOL NETWORK_SESSION_IS_CLOSED_CREW() { return invoke<BOOL>(0x74732C6CA90DA2B4); } // 0x74732C6CA90DA2B4
	static BOOL NETWORK_SESSION_IS_CLOSED_FRIENDS() { return invoke<BOOL>(0xFBCFA2EA2E206890); } // 0xFBCFA2EA2E206890
	static BOOL _NETWORK_SESSION_IS_PLAYER_VOTED_TO_KICK(Player player) { return invoke<BOOL>(0xD6D09A6F32F49EF1, player); } // 0xD6D09A6F32F49EF1
	static BOOL NETWORK_SESSION_IS_PRIVATE() { return invoke<BOOL>(0xCEF70AA5B3F89BA1); } // 0xCEF70AA5B3F89BA1
	static BOOL NETWORK_SESSION_IS_SOLO() { return invoke<BOOL>(0xF3929C2379B60CCE); } // 0xF3929C2379B60CCE
	static BOOL NETWORK_SESSION_IS_VISIBLE() { return invoke<BOOL>(0xBA416D68C631496A); } // 0xBA416D68C631496A
	static void NETWORK_SESSION_KICK_PLAYER(Player player) { invoke<Void>(0xFA8904DC5F304220, player); } // 0xFA8904DC5F304220
	static void NETWORK_SESSION_LEAVE_SINGLE_PLAYER() { invoke<Void>(0x3442775428FD2DAA); } // 0x3442775428FD2DAA
	static void NETWORK_SESSION_MARK_VISIBLE(BOOL p0) { invoke<Void>(0x271CC6AB59EBF9A5, p0); } // 0x271CC6AB59EBF9A5
	static void _NETWORK_SESSION_SET_MAX_PLAYERS(int playerType, int playerCount) { invoke<Void>(0x8B6A4DD0AF9CE215, playerType, playerCount); } // 0x8B6A4DD0AF9CE215
	static void NETWORK_SESSION_VOICE_HOST() { invoke<Void>(0x9C1556705F864230); } // 0x9C1556705F864230
	static void NETWORK_SESSION_VOICE_LEAVE() { invoke<Void>(0x6793E42BE02B575D); } // 0x6793E42BE02B575D
	static BOOL NETWORK_SESSION_WAS_INVITED() { return invoke<BOOL>(0x23DFB504655D0CE4); } // 0x23DFB504655D0CE4
	static void NETWORK_SET_ACTIVITY_SPECTATOR(BOOL toggle) { invoke<Void>(0x75138790B4359A74, toggle); } // 0x75138790B4359A74
	static void NETWORK_SET_ACTIVITY_SPECTATOR_MAX(int maxSpectators) { invoke<Void>(0x9D277B76D1D12222, maxSpectators); } // 0x9D277B76D1D12222
	static BOOL NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU(Any* p0) { return invoke<BOOL>(0x7206F674F2A3B1BB, p0); } // 0x7206F674F2A3B1BB
	static void NETWORK_SET_ENTITY_CAN_BLEND(Entity entity, BOOL toggle) { invoke<Void>(0xD830567D88A1E873, entity, toggle); } // 0xD830567D88A1E873
	static void _NETWORK_SET_ENTITY_INVISIBLE_TO_NETWORK(Entity entity, BOOL toggle) { invoke<Void>(0xF1CA12B18AEF5298, entity, toggle); } // 0xF1CA12B18AEF5298
	static void NETWORK_SET_FRIENDLY_FIRE_OPTION(BOOL toggle) { invoke<Void>(0xF808475FA571D823, toggle); } // 0xF808475FA571D823
	static void NETWORK_SET_GAMER_INVITED_TO_TRANSITION(int* networkHandle) { invoke<Void>(0xCA2C8073411ECDB6, networkHandle); } // 0xCA2C8073411ECDB6
	static void NETWORK_SET_IN_MP_CUTSCENE(BOOL p0, BOOL p1) { invoke<Void>(0x9CA5DE655269FEC4, p0, p1); } // 0x9CA5DE655269FEC4
	static void NETWORK_SET_IN_SPECTATOR_MODE(BOOL toggle, Ped playerPed) { invoke<Void>(0x423DE3854BB50894, toggle, playerPed); } // 0x423DE3854BB50894
	static void NETWORK_SET_KEEP_FOCUSPOINT(BOOL p0, Any p1) { invoke<Void>(0x7F8413B7FC2AA6B9, p0, p1); } // 0x7F8413B7FC2AA6B9
	static void NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME(int time) { invoke<Void>(0x2D95C7E2D7E07307, time); } // 0x2D95C7E2D7E07307
	static void NETWORK_SET_MISSION_FINISHED() { invoke<Void>(0x3B3D11CD9FFCDFC9); } // 0x3B3D11CD9FFCDFC9
	static void _NETWORK_SET_NETWORK_ID_DYNAMIC(int netID, BOOL toggle) { invoke<Void>(0x2B1813ABA29016C5, netID, toggle); } // 0x2B1813ABA29016C5
	static void NETWORK_SET_OVERRIDE_SPECTATOR_MODE(BOOL toggle) { invoke<Void>(0x70DA3BF8DACD3210, toggle); } // 0x70DA3BF8DACD3210
	static void NETWORK_SET_PROPERTY_ID(Any p0) { invoke<Void>(0x1775961C2FBBCB5C, p0); } // 0x1775961C2FBBCB5C
	static void NETWORK_SET_RICH_PRESENCE(int p0, Any p1, Any p2, Any p3) { invoke<Void>(0x1DCCACDCFC569362, p0, p1, p2, p3); } // 0x1DCCACDCFC569362
	static void _NETWORK_SET_RICH_PRESENCE_2(int p0, char* gxtLabel) { invoke<Void>(0x3E200C2BCF4164EB, p0, gxtLabel); } // 0x3E200C2BCF4164EB
	static void NETWORK_SET_TALKER_PROXIMITY(float p0) { invoke<Void>(0xCBF12D65F95AD686, p0); } // 0xCBF12D65F95AD686
	static void NETWORK_SET_TEAM_ONLY_CHAT(BOOL toggle) { invoke<Void>(0xD5B4883AC32F24C3, toggle); } // 0xD5B4883AC32F24C3
	static void NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(int lobbySize, BOOL p1, int playerId) { invoke<Void>(0x1CA59E306ECB80A5, lobbySize, p1, playerId); } // 0x1CA59E306ECB80A5
	static void NETWORK_SET_TRANSITION_ACTIVITY_ID(Any p0) { invoke<Void>(0x30DE938B516F0AD2, p0); } // 0x30DE938B516F0AD2
	static void NETWORK_SET_TRANSITION_CREATOR_HANDLE(Any* p0) { invoke<Void>(0xEF26739BCD9907D5, p0); } // 0xEF26739BCD9907D5
	static void NETWORK_SET_VOICE_ACTIVE(BOOL toggle) { invoke<Void>(0xBABEC9E69A91C57B, toggle); } // 0xBABEC9E69A91C57B
	static void NETWORK_SET_VOICE_CHANNEL(Any p0) { invoke<Void>(0xEF6212C2EFEF1A23, p0); } // 0xEF6212C2EFEF1A23
	static void NETWORK_SHOW_PROFILE_UI(int* networkHandle) { invoke<Void>(0x859ED1CEA343FCA8, networkHandle); } // 0x859ED1CEA343FCA8
	static void NETWORK_START_SYNCHRONISED_SCENE(int netScene) { invoke<Void>(0x9A1B3FCDB36C8697, netScene); } // 0x9A1B3FCDB36C8697
	static void NETWORK_STOP_SYNCHRONISED_SCENE(int netScene) { invoke<Void>(0xC254481A4574CB2F, netScene); } // 0xC254481A4574CB2F
	static void NETWORK_SUPPRESS_INVITE(BOOL toggle) { invoke<Void>(0xA0682D67EF1FBA3D, toggle); } // 0xA0682D67EF1FBA3D
	static void NETWORK_UNREGISTER_NETWORKED_ENTITY(Entity entity) { invoke<Void>(0x7368E683BB9038D6, entity); } // 0x7368E683BB9038D6
	static void _NETWORK_VOICE_CONNECT_TO_PLAYER(Any* globalPtr) { invoke<Void>(0xABD5E88B8A2D3DB2, globalPtr); } // 0xABD5E88B8A2D3DB2
	static BOOL NETWORK_X_AFFECTS_GAMERS(Any p0) { return invoke<BOOL>(0xE532D6811B3A4D2A, p0); } // 0xE532D6811B3A4D2A
	static Any _0x01ABCE5E7CBDA196() { return invoke<Any>(0x1ABCE5E7CBDA196); } // 0x1ABCE5E7CBDA196
	static BOOL _0x02A8BEC6FD9AF660(Any* p0, Any p1) { return invoke<BOOL>(0x2A8BEC6FD9AF660, p0, p1); } // 0x2A8BEC6FD9AF660
	static Any _0x02ADA21EA2F6918F() { return invoke<Any>(0x2ADA21EA2F6918F); } // 0x2ADA21EA2F6918F
	static void _0x0379DAF89BA09AA5(Any p0, Any p1) { invoke<Void>(0x379DAF89BA09AA5, p0, p1); } // 0x379DAF89BA09AA5
	static Any _0x041C7F2A6C9894E6(Any p0, Any p1, Any p2) { return invoke<Any>(0x41C7F2A6C9894E6, p0, p1, p2); } // 0x41C7F2A6C9894E6
	static Any _0x04918A41BC9B8157(Any p0, Any p1, Any p2) { return invoke<Any>(0x4918A41BC9B8157, p0, p1, p2); } // 0x4918A41BC9B8157
	static BOOL _0x07DD29D5E22763F1(Any* p0) { return invoke<BOOL>(0x7DD29D5E22763F1, p0); } // 0x7DD29D5E22763F1
	static Any _0x07EAB372C8841D99(Any p0, Any p1, Any p2) { return invoke<Any>(0x7EAB372C8841D99, p0, p1, p2); } // 0x7EAB372C8841D99
	static Any _0x0AFCE529F69B21FF() { return invoke<Any>(0xAFCE529F69B21FF); } // 0xAFCE529F69B21FF
	static Any _0x0B203B4AFDE53A4F(Any* p0, Any* p1, BOOL p2) { return invoke<Any>(0xB203B4AFDE53A4F, p0, p1, p2); } // 0xB203B4AFDE53A4F
	static Any _0x0C1F7D49C39D2289() { return invoke<Any>(0xC1F7D49C39D2289); } // 0xC1F7D49C39D2289
	static void _0x0C978FDA19692C2C(BOOL p0, BOOL p1) { invoke<Void>(0xC978FDA19692C2C, p0, p1); } // 0xC978FDA19692C2C
	static int _0x0CD9AB83489430EA(BOOL p0) { return invoke<int>(0xCD9AB83489430EA, p0); } // 0xCD9AB83489430EA
	static void _0x0D77A82DC2D0DA59(Any* p0, Any* p1) { invoke<Void>(0xD77A82DC2D0DA59, p0, p1); } // 0xD77A82DC2D0DA59
	static Any _0x0DBD5D7E3C5BEC3B() { return invoke<Any>(0xDBD5D7E3C5BEC3B); } // 0xDBD5D7E3C5BEC3B
	static void _0x0E4F77F7B9D74D84(Any p0) { invoke<Void>(0xE4F77F7B9D74D84, p0); } // 0xE4F77F7B9D74D84
	static BOOL _0x0EDE326D47CD0F3E(Ped ped, Player player) { return invoke<BOOL>(0xEDE326D47CD0F3E, ped, player); } // 0xEDE326D47CD0F3E
	static void _0x0FF2862B61A58AF9(BOOL p0) { invoke<Void>(0xFF2862B61A58AF9, p0); } // 0xFF2862B61A58AF9
	static Any _0x10BD227A753B0D84() { return invoke<Any>(0x10BD227A753B0D84); } // 0x10BD227A753B0D84
	static void _0x113E6E3E50E286B0(Any p0) { invoke<Void>(0x113E6E3E50E286B0, p0); } // 0x113E6E3E50E286B0
	static void _0x1153FA02A659051C() { invoke<Void>(0x1153FA02A659051C); } // 0x1153FA02A659051C
	static BOOL _0x1171A97A3D3981B6(Any* p0, Any* p1, Any p2, Any p3) { return invoke<BOOL>(0x1171A97A3D3981B6, p0, p1, p2, p3); } // 0x1171A97A3D3981B6
	static Any _0x120364DE2845DAF8(Any* p0, Any p1) { return invoke<Any>(0x120364DE2845DAF8, p0, p1); } // 0x120364DE2845DAF8
	static int _0x12B6281B6C6706C0(BOOL p0) { return invoke<int>(0x12B6281B6C6706C0, p0); } // 0x12B6281B6C6706C0
	static BOOL _0x13518FF1C6B28938(Any p0) { return invoke<BOOL>(0x13518FF1C6B28938, p0); } // 0x13518FF1C6B28938
	static BOOL _0x1353F87E89946207() { return invoke<BOOL>(0x1353F87E89946207); } // 0x1353F87E89946207
	static BOOL _0x135F9B7B7ADD2185(Any* p0) { return invoke<BOOL>(0x135F9B7B7ADD2185, p0); } // 0x135F9B7B7ADD2185
	static void _0x1398582B7F72B3ED(Any p0) { invoke<Void>(0x1398582B7F72B3ED, p0); } // 0x1398582B7F72B3ED
	static void _0x13F1FCB111B820B0(Any p0) { invoke<Void>(0x13F1FCB111B820B0, p0); } // 0x13F1FCB111B820B0
	static void _0x140E6A44870A11CE() { invoke<Void>(0x140E6A44870A11CE); } // 0x140E6A44870A11CE
	static void _0x144DA052257AE7D8(Any p0) { invoke<Void>(0x144DA052257AE7D8, p0); } // 0x144DA052257AE7D8
	static Any _0x14922ED3E38761F0() { return invoke<Any>(0x14922ED3E38761F0); } // 0x14922ED3E38761F0
	static BOOL _0x152D90E4C1B4738A(Any* p0, Any* p1) { return invoke<BOOL>(0x152D90E4C1B4738A, p0, p1); } // 0x152D90E4C1B4738A
	static BOOL _0x158EC424F35EC469(char* p0, BOOL p1, char* contentType) { return invoke<BOOL>(0x158EC424F35EC469, p0, p1, contentType); } // 0x158EC424F35EC469
	static BOOL _0x162C23CA83ED0A62(Any p0) { return invoke<BOOL>(0x162C23CA83ED0A62, p0); } // 0x162C23CA83ED0A62
	static void _0x1632BE0AC1E62876(Any p0, Any p1) { invoke<Void>(0x1632BE0AC1E62876, p0, p1); } // 0x1632BE0AC1E62876
	static Any _0x171DF6A0C07FB3DC(Any p0, Any p1) { return invoke<Any>(0x171DF6A0C07FB3DC, p0, p1); } // 0x171DF6A0C07FB3DC
	static void _0x17330EBF2F2124A8() { invoke<Void>(0x17330EBF2F2124A8); } // 0x17330EBF2F2124A8
	static void _0x17440AA15D1D3739() { invoke<Void>(0x17440AA15D1D3739); } // 0x17440AA15D1D3739
	static void _0x17E0198B3882C2CB() { invoke<Void>(0x17E0198B3882C2CB); } // 0x17E0198B3882C2CB
	static void _0x1888694923EF4591() { invoke<Void>(0x1888694923EF4591); } // 0x1888694923EF4591
	static Any _0x1950DAE9848A4739(Any p0, Any p1, Any p2) { return invoke<Any>(0x1950DAE9848A4739, p0, p1, p2); } // 0x1950DAE9848A4739
	static Any _0x1ACCFBA3D8DAB2EE(Any p0, Any p1) { return invoke<Any>(0x1ACCFBA3D8DAB2EE, p0, p1); } // 0x1ACCFBA3D8DAB2EE
	static BOOL _0x1AD5B71586B94820(Player p0, Any* p1, Any p2) { return invoke<BOOL>(0x1AD5B71586B94820, p0, p1, p2); } // 0x1AD5B71586B94820
	static void _0x1B857666604B1A74(BOOL p0) { invoke<Void>(0x1B857666604B1A74, p0); } // 0x1B857666604B1A74
	static Any _0x1D4DC17C38FEAFF0() { return invoke<Any>(0x1D4DC17C38FEAFF0); } // 0x1D4DC17C38FEAFF0
	static BOOL _0x1D610EB0FEA716D9(Any p0) { return invoke<BOOL>(0x1D610EB0FEA716D9, p0); } // 0x1D610EB0FEA716D9
	static BOOL _0x1DE0F5F50D723CAA(Any* p0, Any* p1, Any* p2) { return invoke<BOOL>(0x1DE0F5F50D723CAA, p0, p1, p2); } // 0x1DE0F5F50D723CAA
	static void _0x1F8E00FB18239600(Any p0) { invoke<Void>(0x1F8E00FB18239600, p0); } // 0x1F8E00FB18239600
	static BOOL _0x21D04D7BC538C146(Any p0) { return invoke<BOOL>(0x21D04D7BC538C146, p0); } // 0x21D04D7BC538C146
	static void _0x2302C0264EA58D31() { invoke<Void>(0x2302C0264EA58D31); } // 0x2302C0264EA58D31
	static BOOL _0x237D5336A9A54108(Any p0) { return invoke<BOOL>(0x237D5336A9A54108, p0); } // 0x237D5336A9A54108
	static Any _0x24409FC4C55CB22D(Any p0) { return invoke<Any>(0x24409FC4C55CB22D, p0); } // 0x24409FC4C55CB22D
	static Any _0x24E4E51FC16305F9() { return invoke<Any>(0x24E4E51FC16305F9); } // 0x24E4E51FC16305F9
	static Any _0x25B99872D588A101(float p0, float p1, float p2, float p3, float p4, float p5) { return invoke<Any>(0x25B99872D588A101, p0, p1, p2, p3, p4, p5); } // 0x25B99872D588A101
	static void _0x25D990F8E0E3F13C() { invoke<Void>(0x25D990F8E0E3F13C); } // 0x25D990F8E0E3F13C
	static void _0x261E97AD7BCF3D40(BOOL p0) { invoke<Void>(0x261E97AD7BCF3D40, p0); } // 0x261E97AD7BCF3D40
	static void _0x265559DA40B3F327(Any p0) { invoke<Void>(0x265559DA40B3F327, p0); } // 0x265559DA40B3F327
	static void _0x265635150FB0D82E() { invoke<Void>(0x265635150FB0D82E); } // 0x265635150FB0D82E
	static void _0x267C78C60E806B9A(Any p0, BOOL p1) { invoke<Void>(0x267C78C60E806B9A, p0, p1); } // 0x267C78C60E806B9A
	static Any _0x26F07DD83A5F7F98() { return invoke<Any>(0x26F07DD83A5F7F98); } // 0x26F07DD83A5F7F98
	static BOOL _0x274A1519DFC1094F(Any* p0, BOOL p1, Any* p2) { return invoke<BOOL>(0x274A1519DFC1094F, p0, p1, p2); } // 0x274A1519DFC1094F
	static void _0x283B6062A2C01E9B() { invoke<Void>(0x283B6062A2C01E9B); } // 0x283B6062A2C01E9B
	static Any _0x299EF3C576773506() { return invoke<Any>(0x299EF3C576773506); } // 0x299EF3C576773506
	static void _0x2A5E0621DD815A9A(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x2A5E0621DD815A9A, p0, p1, p2, p3); } // 0x2A5E0621DD815A9A
	static Any _0x2A7776C709904AB0(Any p0) { return invoke<Any>(0x2A7776C709904AB0, p0); } // 0x2A7776C709904AB0
	static Any _0x2B1C623823DB0D9D(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return invoke<Any>(0x2B1C623823DB0D9D, p0, p1, p2, p3, p4, p5, p6); } // 0x2B1C623823DB0D9D
	static BOOL _0x2B51EDBEFC301339(int p0, char* p1) { return invoke<BOOL>(0x2B51EDBEFC301339, p0, p1); } // 0x2B51EDBEFC301339
	static Any _0x2BF66D2E7414F686() { return invoke<Any>(0x2BF66D2E7414F686); } // 0x2BF66D2E7414F686
	static Any _0x2CC848A861D01493() { return invoke<Any>(0x2CC848A861D01493); } // 0x2CC848A861D01493
	static void _0x2CE9D95E4051AECD(Any p0) { invoke<Void>(0x2CE9D95E4051AECD, p0); } // 0x2CE9D95E4051AECD
	static BOOL _0x2D5DC831176D0114(Any p0) { return invoke<BOOL>(0x2D5DC831176D0114, p0); } // 0x2D5DC831176D0114
	static Any _0x2DA41ED6E1FCD7A5(Any p0, Any p1) { return invoke<Any>(0x2DA41ED6E1FCD7A5, p0, p1); } // 0x2DA41ED6E1FCD7A5
	static BOOL _0x2E0BF682CC778D49(Any p0) { return invoke<BOOL>(0x2E0BF682CC778D49, p0); } // 0x2E0BF682CC778D49
	static Any _0x2E4C123D1C8A710E(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return invoke<Any>(0x2E4C123D1C8A710E, p0, p1, p2, p3, p4, p5, p6); } // 0x2E4C123D1C8A710E
	static Any _0x2EAC52B4019E2782() { return invoke<Any>(0x2EAC52B4019E2782); } // 0x2EAC52B4019E2782
	static Any _0x2FC5650B0271CB57() { return invoke<Any>(0x2FC5650B0271CB57); } // 0x2FC5650B0271CB57
	static BOOL _0x3054F114121C21EA(Any p0) { return invoke<BOOL>(0x3054F114121C21EA, p0); } // 0x3054F114121C21EA
	static Any _0x308F96458B7087CC(Any* p0, Any p1, Any p2, Any p3, Any* p4, BOOL p5) { return invoke<Any>(0x308F96458B7087CC, p0, p1, p2, p3, p4, p5); } // 0x308F96458B7087CC
	static BOOL _0x3195F8DD0D531052(Any p0, Any p1, Any* p2, Any* p3) { return invoke<BOOL>(0x3195F8DD0D531052, p0, p1, p2, p3); } // 0x3195F8DD0D531052
	static Any _0x32DD916F3F7C9672(Any p0) { return invoke<Any>(0x32DD916F3F7C9672, p0); } // 0x32DD916F3F7C9672
	static void _0x32EBD154CB6B8B99(Any p0, Any p1, Any p2) { invoke<Void>(0x32EBD154CB6B8B99, p0, p1, p2); } // 0x32EBD154CB6B8B99
	static Vector3 _0x33DE49EDF4DDE77A(Any p0) { return invoke<Vector3>(0x33DE49EDF4DDE77A, p0); } // 0x33DE49EDF4DDE77A
	static Any _0x35F0B98A8387274D() { return invoke<Any>(0x35F0B98A8387274D); } // 0x35F0B98A8387274D
	static Any _0x36391F397731595D(Any p0) { return invoke<Any>(0x36391F397731595D, p0); } // 0x36391F397731595D
	static void _0x367EF5E2F439B4C6(int p0) { invoke<Void>(0x367EF5E2F439B4C6, p0); } // 0x367EF5E2F439B4C6
	static Any _0x37A4494483B9F5C9() { return invoke<Any>(0x37A4494483B9F5C9); } // 0x37A4494483B9F5C9
	static int _0x37D5F739FD494675(Any p0) { return invoke<int>(0x37D5F739FD494675, p0); } // 0x37D5F739FD494675
	static Any _0x3855FB5EB2C5E8B2(Any p0) { return invoke<Any>(0x3855FB5EB2C5E8B2, p0); } // 0x3855FB5EB2C5E8B2
	static void _0x39917E1B4CB0F911(BOOL p0) { invoke<Void>(0x39917E1B4CB0F911, p0); } // 0x39917E1B4CB0F911
	static Any _0x3A17A27D75C74887() { return invoke<Any>(0x3A17A27D75C74887); } // 0x3A17A27D75C74887
	static BOOL _0x3A3D5568AF297CD5(Any p0) { return invoke<BOOL>(0x3A3D5568AF297CD5, p0); } // 0x3A3D5568AF297CD5
	static Any _0x3A8B55FDA4C8DDEF(Any p0, Any p1, Any p2) { return invoke<Any>(0x3A8B55FDA4C8DDEF, p0, p1, p2); } // 0x3A8B55FDA4C8DDEF
	static Any _0x3B39236746714134(Any p0) { return invoke<Any>(0x3B39236746714134, p0); } // 0x3B39236746714134
	static void _0x3C5C1E2C2FF814B1(BOOL p0) { invoke<Void>(0x3C5C1E2C2FF814B1, p0); } // 0x3C5C1E2C2FF814B1
	static Any _0x3C891A251567DFCE(Any* p0) { return invoke<Any>(0x3C891A251567DFCE, p0); } // 0x3C891A251567DFCE
	static BOOL _0x3DBF2DF0AEB7D289(Any p0) { return invoke<BOOL>(0x3DBF2DF0AEB7D289, p0); } // 0x3DBF2DF0AEB7D289
	static void _0x3F52E880AAF6C8CA(BOOL p0) { invoke<Void>(0x3F52E880AAF6C8CA, p0); } // 0x3F52E880AAF6C8CA
	static BOOL _0x3F9990BF5F22759C(Any* p0) { return invoke<BOOL>(0x3F9990BF5F22759C, p0); } // 0x3F9990BF5F22759C
	static void _0x3FA36981311FA4FF(int netId, BOOL state) { invoke<Void>(0x3FA36981311FA4FF, netId, state); } // 0x3FA36981311FA4FF
	static void _0x407091CF6037118E(int netID) { invoke<Void>(0x407091CF6037118E, netID); } // 0x407091CF6037118E
	static Any _0x40F7E66472DF3E5C(Any p0, Any p1) { return invoke<Any>(0x40F7E66472DF3E5C, p0, p1); } // 0x40F7E66472DF3E5C
	static void _0x419594E137637120(BOOL p0, Any p1, BOOL p2) { invoke<Void>(0x419594E137637120, p0, p1, p2); } // 0x419594E137637120
	static BOOL _0x422D396F80A96547() { return invoke<BOOL>(0x422D396F80A96547); } // 0x422D396F80A96547
	static BOOL _0x422F32CC7E56ABAD(Any p0) { return invoke<BOOL>(0x422F32CC7E56ABAD, p0); } // 0x422F32CC7E56ABAD
	static BOOL _0x4237E822315D8BA9() { return invoke<BOOL>(0x4237E822315D8BA9); } // 0x4237E822315D8BA9
	static void _0x42613035157E4208(Any p0) { invoke<Void>(0x42613035157E4208, p0); } // 0x42613035157E4208
	static Any _0x4348BFDA56023A2F(Any p0, Any p1) { return invoke<Any>(0x4348BFDA56023A2F, p0, p1); } // 0x4348BFDA56023A2F
	static void _0x444C4525ECE0A4B9() { invoke<Void>(0x444C4525ECE0A4B9); } // 0x444C4525ECE0A4B9
	static BOOL _0x44B37CDCAE765AAE(Any p0, Any* p1) { return invoke<BOOL>(0x44B37CDCAE765AAE, p0, p1); } // 0x44B37CDCAE765AAE
	static void _0x45A83257ED02D9BC() { invoke<Void>(0x45A83257ED02D9BC); } // 0x45A83257ED02D9BC
	static Any _0x45E816772E93A9DB() { return invoke<Any>(0x45E816772E93A9DB); } // 0x45E816772E93A9DB
	static Any _0x472841A026D26D8B() { return invoke<Any>(0x472841A026D26D8B); } // 0x472841A026D26D8B
	static void _0x4811BBAC21C5FCD5(Any p0) { invoke<Void>(0x4811BBAC21C5FCD5, p0); } // 0x4811BBAC21C5FCD5
	static BOOL _0x4A2D4E8BF4265B0F(Any p0) { return invoke<BOOL>(0x4A2D4E8BF4265B0F, p0); } // 0x4A2D4E8BF4265B0F
	static Any _0x4AD490AE1536933B(Any p0, Any p1) { return invoke<Any>(0x4AD490AE1536933B, p0, p1); } // 0x4AD490AE1536933B
	static void _0x4BA166079D658ED4(Any p0, Any p1) { invoke<Void>(0x4BA166079D658ED4, p0, p1); } // 0x4BA166079D658ED4
	static BOOL _0x4BA92A18502BCA61(Player player, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, int flags) { return invoke<BOOL>(0x4BA92A18502BCA61, player, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, flags); } // 0x4BA92A18502BCA61
	static void _0x4C2A9FDC22377075() { invoke<Void>(0x4C2A9FDC22377075); } // 0x4C2A9FDC22377075
	static BOOL _0x4C61B39930D045DA(Any p0) { return invoke<BOOL>(0x4C61B39930D045DA, p0); } // 0x4C61B39930D045DA
	static Any _0x4D02279C83BE69FE() { return invoke<Any>(0x4D02279C83BE69FE); } // 0x4D02279C83BE69FE
	static BOOL _0x4DF7CFFF471A7FB1(Any p0) { return invoke<BOOL>(0x4DF7CFFF471A7FB1, p0); } // 0x4DF7CFFF471A7FB1
	static Any _0x4E548C0D7AE39FF9(Any p0, Any p1) { return invoke<Any>(0x4E548C0D7AE39FF9, p0, p1); } // 0x4E548C0D7AE39FF9
	static void _0x524FF0AEFF9C3973(Any p0) { invoke<Void>(0x524FF0AEFF9C3973, p0); } // 0x524FF0AEFF9C3973
	static BOOL _0x5324A0E3E4CE3570(Any p0, Any p1, Any* p2, Any* p3) { return invoke<BOOL>(0x5324A0E3E4CE3570, p0, p1, p2, p3); } // 0x5324A0E3E4CE3570
	static Any _0x53AFD64C6758F2F9() { return invoke<Any>(0x53AFD64C6758F2F9); } // 0x53AFD64C6758F2F9
	static Any _0x53C10C8BD774F2C9() { return invoke<Any>(0x53C10C8BD774F2C9); } // 0x53C10C8BD774F2C9
	static void _0x5539C3EBF104A53A(BOOL p0) { invoke<Void>(0x5539C3EBF104A53A, p0); } // 0x5539C3EBF104A53A
	static Any _0x5626D9D6810730D5() { return invoke<Any>(0x5626D9D6810730D5); } // 0x5626D9D6810730D5
	static BOOL _0x584770794D758C18(Any p0, Any* p1) { return invoke<BOOL>(0x584770794D758C18, p0, p1); } // 0x584770794D758C18
	static void _0x58C21165F6545892(char* p0, char* p1) { invoke<Void>(0x58C21165F6545892, p0, p1); } // 0x58C21165F6545892
	static Any _0x58CC181719256197(Any p0, Any p1, Any p2) { return invoke<Any>(0x58CC181719256197, p0, p1, p2); } // 0x58CC181719256197
	static Any _0x59328EB08C5CEB2B() { return invoke<Any>(0x59328EB08C5CEB2B); } // 0x59328EB08C5CEB2B
	static Any _0x593570C289A77688() { return invoke<Any>(0x593570C289A77688); } // 0x593570C289A77688
	static BOOL _0x595F028698072DD9(Any p0, Any p1, BOOL p2) { return invoke<BOOL>(0x595F028698072DD9, p0, p1, p2); } // 0x595F028698072DD9
	static Any _0x597F8DBA9B206FC7() { return invoke<Any>(0x597F8DBA9B206FC7); } // 0x597F8DBA9B206FC7
	static void _0x59D421683D31835A(Any p0) { invoke<Void>(0x59D421683D31835A, p0); } // 0x59D421683D31835A
	static Any _0x59DF79317F85A7E0() { return invoke<Any>(0x59DF79317F85A7E0); } // 0x59DF79317F85A7E0
	static Any _0x5A0A3D1A186A5508() { return invoke<Any>(0x5A0A3D1A186A5508); } // 0x5A0A3D1A186A5508
	static BOOL _0x5A34CD9C3C5BEC44(Any p0) { return invoke<BOOL>(0x5A34CD9C3C5BEC44, p0); } // 0x5A34CD9C3C5BEC44
	static BOOL _0x5A6AA44FF8E931E6() { return invoke<BOOL>(0x5A6AA44FF8E931E6); } // 0x5A6AA44FF8E931E6
	static BOOL _0x5A6FFA2433E2F14C(Player player, float p1, float p2, float p3, float p4, float p5, float p6, float p7, int flags) { return invoke<BOOL>(0x5A6FFA2433E2F14C, player, p1, p2, p3, p4, p5, p6, p7, flags); } // 0x5A6FFA2433E2F14C
	static Any _0x5AE17C6B0134B7F1() { return invoke<Any>(0x5AE17C6B0134B7F1); } // 0x5AE17C6B0134B7F1
	static void _0x5B8ED3DB018927B1(Any p0) { invoke<Void>(0x5B8ED3DB018927B1, p0); } // 0x5B8ED3DB018927B1
	static void _0x5C497525F803486B() { invoke<Void>(0x5C497525F803486B); } // 0x5C497525F803486B
	static void _0x5C707A667DF8B9FA(BOOL p0, Any p1) { invoke<Void>(0x5C707A667DF8B9FA, p0, p1); } // 0x5C707A667DF8B9FA
	static BOOL _0x5CAE833B0EE0C500(Any p0) { return invoke<BOOL>(0x5CAE833B0EE0C500, p0); } // 0x5CAE833B0EE0C500
	static BOOL _0x5D10B3795F3FC886() { return invoke<BOOL>(0x5D10B3795F3FC886); } // 0x5D10B3795F3FC886
	static BOOL _0x5DC577201723960A() { return invoke<BOOL>(0x5DC577201723960A); } // 0x5DC577201723960A
	static Any _0x5E0165278F6339EE(Any p0) { return invoke<Any>(0x5E0165278F6339EE, p0); } // 0x5E0165278F6339EE
	static Any _0x5E24341A7F92A74B() { return invoke<Any>(0x5E24341A7F92A74B); } // 0x5E24341A7F92A74B
	static void _0x5E3AA4CA2B6FB0EE(Any p0) { invoke<Void>(0x5E3AA4CA2B6FB0EE, p0); } // 0x5E3AA4CA2B6FB0EE
	static Any _0x5EA784D197556507() { return invoke<Any>(0x5EA784D197556507); } // 0x5EA784D197556507
	static void _0x5ECD378EE64450AB(Any p0) { invoke<Void>(0x5ECD378EE64450AB, p0); } // 0x5ECD378EE64450AB
	static void _0x600F8CB31C7AAB6E(Any p0) { invoke<Void>(0x600F8CB31C7AAB6E, p0); } // 0x600F8CB31C7AAB6E
	static Any _0x606E4D3E3CCCF3EB() { return invoke<Any>(0x606E4D3E3CCCF3EB); } // 0x606E4D3E3CCCF3EB
	static Any _0x60EDD13EB3AC1FF3() { return invoke<Any>(0x60EDD13EB3AC1FF3); } // 0x60EDD13EB3AC1FF3
	static Any _0x617F49C2668E6155() { return invoke<Any>(0x617F49C2668E6155); } // 0x617F49C2668E6155
	static void _0x61A885D3F7CFEE9A() { invoke<Void>(0x61A885D3F7CFEE9A); } // 0x61A885D3F7CFEE9A
	static Any _0x62A0296C1BB1CEB3() { return invoke<Any>(0x62A0296C1BB1CEB3); } // 0x62A0296C1BB1CEB3
	static BOOL _0x631DC5DFF4B110E3(Any p0) { return invoke<BOOL>(0x631DC5DFF4B110E3, p0); } // 0x631DC5DFF4B110E3
	static int _0x638A3A81733086DB() { return invoke<int>(0x638A3A81733086DB); } // 0x638A3A81733086DB
	static Any _0x63B406D7884BFA95() { return invoke<Any>(0x63B406D7884BFA95); } // 0x63B406D7884BFA95
	static Vector3 _0x64D779659BC37B19(Any p0) { return invoke<Vector3>(0x64D779659BC37B19, p0); } // 0x64D779659BC37B19
	static void _0x64F62AFB081E260D() { invoke<Void>(0x64F62AFB081E260D); } // 0x64F62AFB081E260D
	static Any _0x6512765E3BE78C50() { return invoke<Any>(0x6512765E3BE78C50); } // 0x6512765E3BE78C50
	static void _0x658500AE6D723A7E(Any p0) { invoke<Void>(0x658500AE6D723A7E, p0); } // 0x658500AE6D723A7E
	static Any _0x659CF2EF7F550C4F() { return invoke<Any>(0x659CF2EF7F550C4F); } // 0x659CF2EF7F550C4F
	static Any _0x662635855957C411(Any p0) { return invoke<Any>(0x662635855957C411, p0); } // 0x662635855957C411
	static Any _0x66B59CFFD78467AF() { return invoke<Any>(0x66B59CFFD78467AF); } // 0x66B59CFFD78467AF
	static void _0x66F010A4B031A331(Any* p0) { invoke<Void>(0x66F010A4B031A331, p0); } // 0x66F010A4B031A331
	static BOOL _0x678BB03C1A3BD51E(Any p0, Any p1, Any p2, Any* p3, Any* p4) { return invoke<BOOL>(0x678BB03C1A3BD51E, p0, p1, p2, p3, p4); } // 0x678BB03C1A3BD51E
	static BOOL _0x67A5589628E0CFF6() { return invoke<BOOL>(0x67A5589628E0CFF6); } // 0x67A5589628E0CFF6
	static Any _0x67FC09BC554A75E5() { return invoke<Any>(0x67FC09BC554A75E5); } // 0x67FC09BC554A75E5
	static void _0x68103E2247887242() { invoke<Void>(0x68103E2247887242); } // 0x68103E2247887242
	static BOOL _0x692D58DF40657E8C(Any p0, Any p1, Any p2, Any* p3, Any p4, BOOL p5) { return invoke<BOOL>(0x692D58DF40657E8C, p0, p1, p2, p3, p4, p5); } // 0x692D58DF40657E8C
	static Any _0x697F508861875B42(Any p0, Any p1, Any p2) { return invoke<Any>(0x697F508861875B42, p0, p1, p2); } // 0x697F508861875B42
	static void _0x6A5D89D7769A40D8(BOOL p0) { invoke<Void>(0x6A5D89D7769A40D8, p0); } // 0x6A5D89D7769A40D8
	static void _0x6BFF5F84102DF80A(Any p0) { invoke<Void>(0x6BFF5F84102DF80A, p0); } // 0x6BFF5F84102DF80A
	static Any _0x6C34F1208B8923FD(Any p0) { return invoke<Any>(0x6C34F1208B8923FD, p0); } // 0x6C34F1208B8923FD
	static void _0x6CE50E47F5543D0C() { invoke<Void>(0x6CE50E47F5543D0C); } // 0x6CE50E47F5543D0C
	static BOOL _0x6D4CB481FAC835E8(Any p0, Any p1, Any* p2, Any p3) { return invoke<BOOL>(0x6D4CB481FAC835E8, p0, p1, p2, p3); } // 0x6D4CB481FAC835E8
	static Any _0x6F44CBF56D79FAC0(Any p0, Any p1) { return invoke<Any>(0x6F44CBF56D79FAC0, p0, p1); } // 0x6F44CBF56D79FAC0
	static void _0x6F697A66CE78674E(int team, BOOL toggle) { invoke<Void>(0x6F697A66CE78674E, team, toggle); } // 0x6F697A66CE78674E
	static Any _0x6FB7BB3607D27FA2() { return invoke<Any>(0x6FB7BB3607D27FA2); } // 0x6FB7BB3607D27FA2
	static void _0x702BC4D605522539(Any p0) { invoke<Void>(0x702BC4D605522539, p0); } // 0x702BC4D605522539
	static Any _0x703F12425ECA8BF5(Any p0) { return invoke<Any>(0x703F12425ECA8BF5, p0); } // 0x703F12425ECA8BF5
	static BOOL _0x70EA8DA57840F9BE(Any p0) { return invoke<BOOL>(0x70EA8DA57840F9BE, p0); } // 0x70EA8DA57840F9BE
	static Any _0x71302EC70689052A(Any p0) { return invoke<Any>(0x71302EC70689052A, p0); } // 0x71302EC70689052A
	static void _0x715135F4B82AC90D(Entity entity) { invoke<Void>(0x715135F4B82AC90D, entity); } // 0x715135F4B82AC90D
	static Any _0x71DC455F5CD1C2B1(Any p0) { return invoke<Any>(0x71DC455F5CD1C2B1, p0); } // 0x71DC455F5CD1C2B1
	static Any _0x722F5D28B61C5EA8(Any p0) { return invoke<Any>(0x722F5D28B61C5EA8, p0); } // 0x722F5D28B61C5EA8
	static Any _0x7242F8B741CE1086(Any netId) { return invoke<Any>(0x7242F8B741CE1086, netId); } // 0x7242F8B741CE1086
	static Any _0x728C4CC7920CD102(Any p0) { return invoke<Any>(0x728C4CC7920CD102, p0); } // 0x728C4CC7920CD102
	static void _0x72D0706CD6CCDB58() { invoke<Void>(0x72D0706CD6CCDB58); } // 0x72D0706CD6CCDB58
	static BOOL _0x72D918C99BCACC54(Any p0) { return invoke<BOOL>(0x72D918C99BCACC54, p0); } // 0x72D918C99BCACC54
	static void _0x741A3D8380319A81() { invoke<Void>(0x741A3D8380319A81); } // 0x741A3D8380319A81
	static Any _0x742B58F723233ED9(Any p0) { return invoke<Any>(0x742B58F723233ED9, p0); } // 0x742B58F723233ED9
	static Any _0x74698374C45701D2() { return invoke<Any>(0x74698374C45701D2); } // 0x74698374C45701D2
	static Any _0x74FB3E29E6D10FA9() { return invoke<Any>(0x74FB3E29E6D10FA9); } // 0x74FB3E29E6D10FA9
	static BOOL _0x7543BB439F63792B(int* clanDesc, int bufferSize) { return invoke<BOOL>(0x7543BB439F63792B, clanDesc, bufferSize); } // 0x7543BB439F63792B
	static Any _0x759299C5BB31D2A9(Any p0, Any p1) { return invoke<Any>(0x759299C5BB31D2A9, p0, p1); } // 0x759299C5BB31D2A9
	static Any _0x769951E2455E2EB5() { return invoke<Any>(0x769951E2455E2EB5); } // 0x769951E2455E2EB5
	static Any* _0x76BF03FADBF154F5() { return invoke<Any*>(0x76BF03FADBF154F5); } // 0x76BF03FADBF154F5
	static void _0x77758139EC9B66C7(BOOL p0) { invoke<Void>(0x77758139EC9B66C7, p0); } // 0x77758139EC9B66C7
	static void _0x77FADDCBE3499DF7(Any p0) { invoke<Void>(0x77FADDCBE3499DF7, p0); } // 0x77FADDCBE3499DF7
	static Any _0x7808619F31FF22DB() { return invoke<Any>(0x7808619F31FF22DB); } // 0x7808619F31FF22DB
	static BOOL _0x78321BEA235FD8CD(Any p0, BOOL p1) { return invoke<BOOL>(0x78321BEA235FD8CD, p0, p1); } // 0x78321BEA235FD8CD
	static Any _0x793FF272D5B365F4() { return invoke<Any>(0x793FF272D5B365F4); } // 0x793FF272D5B365F4
	static void _0x7AC752103856FB20(BOOL p0) { invoke<Void>(0x7AC752103856FB20, p0); } // 0x7AC752103856FB20
	static void _0x7D395EA61622E116(BOOL p0) { invoke<Void>(0x7D395EA61622E116, p0); } // 0x7D395EA61622E116
	static Any _0x7DB53B37A2F211A0() { return invoke<Any>(0x7DB53B37A2F211A0); } // 0x7DB53B37A2F211A0
	static Any _0x7EF7649B64D7FF10(Any p0) { return invoke<Any>(0x7EF7649B64D7FF10, p0); } // 0x7EF7649B64D7FF10
	static BOOL _0x7FCC39C46C3C03BD(Any p0) { return invoke<BOOL>(0x7FCC39C46C3C03BD, p0); } // 0x7FCC39C46C3C03BD
	static Any _0x7FD2990AF016795E(Any* p0, Any* p1, Any p2, Any p3, Any p4) { return invoke<Any>(0x7FD2990AF016795E, p0, p1, p2, p3, p4); } // 0x7FD2990AF016795E
	static Any _0x815F18AD865F057F(Any p0) { return invoke<Any>(0x815F18AD865F057F, p0); } // 0x815F18AD865F057F
	static BOOL _0x82377B65E943F72D(Any p0) { return invoke<BOOL>(0x82377B65E943F72D, p0); } // 0x82377B65E943F72D
	static Any _0x82A2B386716608F1() { return invoke<Any>(0x82A2B386716608F1); } // 0x82A2B386716608F1
	static Any _0x83660B734994124D(Any p0, Any p1, Any p2) { return invoke<Any>(0x83660B734994124D, p0, p1, p2); } // 0x83660B734994124D
	static void _0x838DA0936A24ED4D(Any p0, Any p1) { invoke<Void>(0x838DA0936A24ED4D, p0, p1); } // 0x838DA0936A24ED4D
	static BOOL _0x83F28CE49FBBFFBA(Any p0, Any p1, BOOL p2) { return invoke<BOOL>(0x83F28CE49FBBFFBA, p0, p1, p2); } // 0x83F28CE49FBBFFBA
	static void _0x83FE8D7229593017() { invoke<Void>(0x83FE8D7229593017); } // 0x83FE8D7229593017
	static BOOL _0x855BC38818F6F684() { return invoke<BOOL>(0x855BC38818F6F684); } // 0x855BC38818F6F684
	static BOOL _0x85A0EF54A500882C(Any* p0) { return invoke<BOOL>(0x85A0EF54A500882C, p0); } // 0x85A0EF54A500882C
	static void _0x86E0660E4F5C956D() { invoke<Void>(0x86E0660E4F5C956D); } // 0x86E0660E4F5C956D
	static Any _0x87E5C46C187FE0AE(Any p0, Any p1) { return invoke<Any>(0x87E5C46C187FE0AE, p0, p1); } // 0x87E5C46C187FE0AE
	static BOOL _0x8806CEBFABD3CE05(Any p0) { return invoke<BOOL>(0x8806CEBFABD3CE05, p0); } // 0x8806CEBFABD3CE05
	static Any _0x883D79C4071E18B3() { return invoke<Any>(0x883D79C4071E18B3); } // 0x883D79C4071E18B3
	static Any _0x88B588B41FF7868E() { return invoke<Any>(0x88B588B41FF7868E); } // 0x88B588B41FF7868E
	static int _0x89023FBBF9200E9F() { return invoke<int>(0x89023FBBF9200E9F); } // 0x89023FBBF9200E9F
	static Any _0x8B0C2964BA471961() { return invoke<Any>(0x8B0C2964BA471961); } // 0x8B0C2964BA471961
	static Any _0x8B4FFC790CA131EF(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0x8B4FFC790CA131EF, p0, p1, p2, p3); } // 0x8B4FFC790CA131EF
	static Any _0x8BD6C6DEA20E82C6(Any p0) { return invoke<Any>(0x8BD6C6DEA20E82C6, p0); } // 0x8BD6C6DEA20E82C6
	static BOOL _0x8C8D2739BA44AF0F(Any p0) { return invoke<BOOL>(0x8C8D2739BA44AF0F, p0); } // 0x8C8D2739BA44AF0F
	static Any _0x8F5D1AD832AEB06C(Any p0) { return invoke<Any>(0x8F5D1AD832AEB06C, p0); } // 0x8F5D1AD832AEB06C
	static BOOL _0x919B3C98ED8292F9(Any p0) { return invoke<BOOL>(0x919B3C98ED8292F9, p0); } // 0x919B3C98ED8292F9
	static Any _0x91B87C55093DE351() { return invoke<Any>(0x91B87C55093DE351); } // 0x91B87C55093DE351
	static Any _0x941E5306BCD7C2C7() { return invoke<Any>(0x941E5306BCD7C2C7); } // 0x941E5306BCD7C2C7
	static void _0x94538037EE44F5CF(BOOL p0) { invoke<Void>(0x94538037EE44F5CF, p0); } // 0x94538037EE44F5CF
	static void _0x9465E683B12D3F6B() { invoke<Void>(0x9465E683B12D3F6B); } // 0x9465E683B12D3F6B
	static Any _0x94A8394D150B013A() { return invoke<Any>(0x94A8394D150B013A); } // 0x94A8394D150B013A
	static Any _0x9614B71F8ADB982B() { return invoke<Any>(0x9614B71F8ADB982B); } // 0x9614B71F8ADB982B
	static void _0x966DD84FB6A46017() { invoke<Void>(0x966DD84FB6A46017); } // 0x966DD84FB6A46017
	static void _0x973D76AA760A6CB6(BOOL p0) { invoke<Void>(0x973D76AA760A6CB6, p0); } // 0x973D76AA760A6CB6
	static BOOL _0x993CBE59D350D225(Any p0) { return invoke<BOOL>(0x993CBE59D350D225, p0); } // 0x993CBE59D350D225
	static BOOL _0x9BF438815F5D96EA(Any p0, Any p1, Any* p2, Any p3, Any p4, Any p5) { return invoke<BOOL>(0x9BF438815F5D96EA, p0, p1, p2, p3, p4, p5); } // 0x9BF438815F5D96EA
	static void _0x9D7AFCBF21C51712(BOOL p0) { invoke<Void>(0x9D7AFCBF21C51712, p0); } // 0x9D7AFCBF21C51712
	static Any _0x9ECA15ADFE141431() { return invoke<Any>(0x9ECA15ADFE141431); } // 0x9ECA15ADFE141431
	static BOOL _0x9F6E2821885CAEE2(Any p0, Any p1, Any p2, Any* p3, Any* p4) { return invoke<BOOL>(0x9F6E2821885CAEE2, p0, p1, p2, p3, p4); } // 0x9F6E2821885CAEE2
	static Any _0x9FEDF86898F100E9() { return invoke<Any>(0x9FEDF86898F100E9); } // 0x9FEDF86898F100E9
	static Any _0xA0FA4EC6A05DA44E() { return invoke<Any>(0xA0FA4EC6A05DA44E); } // 0xA0FA4EC6A05DA44E
	static Any _0xA12D3A5A3753CC23() { return invoke<Any>(0xA12D3A5A3753CC23); } // 0xA12D3A5A3753CC23
	static BOOL _0xA134777FF7F33331(Any p0, Any* p1) { return invoke<BOOL>(0xA134777FF7F33331, p0, p1); } // 0xA134777FF7F33331
	static void _0xA1E5E0204A6FCC70() { invoke<Void>(0xA1E5E0204A6FCC70); } // 0xA1E5E0204A6FCC70
	static void _0xA2A707979FE754DC(Any p0, Any p1) { invoke<Void>(0xA2A707979FE754DC, p0, p1); } // 0xA2A707979FE754DC
	static void _0xA2E9C1AB8A92E8CD(BOOL p0) { invoke<Void>(0xA2E9C1AB8A92E8CD, p0); } // 0xA2E9C1AB8A92E8CD
	static BOOL _0xA2F952104FC6DD4B(Any p0) { return invoke<BOOL>(0xA2F952104FC6DD4B, p0); } // 0xA2F952104FC6DD4B
	static Any _0xA306F470D1660581() { return invoke<Any>(0xA306F470D1660581); } // 0xA306F470D1660581
	static BOOL _0xA699957E60D80214(Any p0) { return invoke<BOOL>(0xA699957E60D80214, p0); } // 0xA699957E60D80214
	static Any _0xA72835064DD63E4C() { return invoke<Any>(0xA72835064DD63E4C); } // 0xA72835064DD63E4C
	static BOOL _0xA7862BC5ED1DFD7E(Any p0, Any p1, Any* p2, Any* p3) { return invoke<BOOL>(0xA7862BC5ED1DFD7E, p0, p1, p2, p3); } // 0xA7862BC5ED1DFD7E
	static void _0xA7C511FA1C5BDA38(Any p0, Any p1) { invoke<Void>(0xA7C511FA1C5BDA38, p0, p1); } // 0xA7C511FA1C5BDA38
	static void _0xA7E30DE9272B6D49(Ped ped, float x, float y, float z, float p4) { invoke<Void>(0xA7E30DE9272B6D49, ped, x, y, z, p4); } // 0xA7E30DE9272B6D49
	static Any _0xA8ACB6459542A8C8() { return invoke<Any>(0xA8ACB6459542A8C8); } // 0xA8ACB6459542A8C8
	static BOOL _0xA9240A96C74CCA13(Any p0) { return invoke<BOOL>(0xA9240A96C74CCA13, p0); } // 0xA9240A96C74CCA13
	static Any _0xAA5FAFCD2C5F5E47() { return invoke<Any>(0xAA5FAFCD2C5F5E47); } // 0xAA5FAFCD2C5F5E47
	static void _0xAAA553E7DD28A457(BOOL p0) { invoke<Void>(0xAAA553E7DD28A457, p0); } // 0xAAA553E7DD28A457
	static void _0xADB57E5B663CCA8B(Player p0, float* p1, float* p2) { invoke<Void>(0xADB57E5B663CCA8B, p0, p1, p2); } // 0xADB57E5B663CCA8B
	static BOOL _0xAEAB987727C5A8A4(Any p0) { return invoke<BOOL>(0xAEAB987727C5A8A4, p0); } // 0xAEAB987727C5A8A4
	static BOOL _0xAEEF48CDF5B6CE7C(Any p0, Any p1) { return invoke<BOOL>(0xAEEF48CDF5B6CE7C, p0, p1); } // 0xAEEF48CDF5B6CE7C
	static BOOL _0xB07D3185E11657A5(Entity p0) { return invoke<BOOL>(0xB07D3185E11657A5, p0); } // 0xB07D3185E11657A5
	static void _0xB13E88E655E5A3BC() { invoke<Void>(0xB13E88E655E5A3BC); } // 0xB13E88E655E5A3BC
	static Any _0xB2092A1EAA7FD45F(Any p0) { return invoke<Any>(0xB2092A1EAA7FD45F, p0); } // 0xB2092A1EAA7FD45F
	static Any _0xB309EBEA797E001F(Any p0) { return invoke<Any>(0xB309EBEA797E001F, p0); } // 0xB309EBEA797E001F
	static Any _0xB37E4E6A2388CA7B() { return invoke<Any>(0xB37E4E6A2388CA7B); } // 0xB37E4E6A2388CA7B
	static Any _0xB4271092CA7EDF48(Any p0) { return invoke<Any>(0xB4271092CA7EDF48, p0); } // 0xB4271092CA7EDF48
	static BOOL _0xB57A49545BA53CE7(Any* p0) { return invoke<BOOL>(0xB57A49545BA53CE7, p0); } // 0xB57A49545BA53CE7
	static Any _0xB5D3453C98456528() { return invoke<Any>(0xB5D3453C98456528); } // 0xB5D3453C98456528
	static void _0xB606E6CC59664972(Any p0) { invoke<Void>(0xB606E6CC59664972, p0); } // 0xB606E6CC59664972
	static BOOL _0xB746D20B17F2A229(Any* p0, Any* p1) { return invoke<BOOL>(0xB746D20B17F2A229, p0, p1); } // 0xB746D20B17F2A229
	static void _0xB7C7F6AD6424304B() { invoke<Void>(0xB7C7F6AD6424304B); } // 0xB7C7F6AD6424304B
	static void _0xBA7F0B77D80A4EB7(Any p0, Any p1) { invoke<Void>(0xBA7F0B77D80A4EB7, p0, p1); } // 0xBA7F0B77D80A4EB7
	static void _0xBA96394A0EECFA65() { invoke<Void>(0xBA96394A0EECFA65); } // 0xBA96394A0EECFA65
	static Any _0xBA9775570DB788CF() { return invoke<Any>(0xBA9775570DB788CF); } // 0xBA9775570DB788CF
	static Any _0xBAF6BABF9E7CCC13(int p0, Any* p1) { return invoke<Any>(0xBAF6BABF9E7CCC13, p0, p1); } // 0xBAF6BABF9E7CCC13
	static void _0xBBDF066252829606(Any p0, BOOL p1) { invoke<Void>(0xBBDF066252829606, p0, p1); } // 0xBBDF066252829606
	static void _0xBD0BE0BFC927EAC1() { invoke<Void>(0xBD0BE0BFC927EAC1); } // 0xBD0BE0BFC927EAC1
	static BOOL _0xBD545D44CCE70597() { return invoke<BOOL>(0xBD545D44CCE70597); } // 0xBD545D44CCE70597
	static Any _0xBDB6F89C729CF388() { return invoke<Any>(0xBDB6F89C729CF388); } // 0xBDB6F89C729CF388
	static void _0xBEC0816FF5ACBCDA(Any p0, Any p1) { invoke<Void>(0xBEC0816FF5ACBCDA, p0, p1); } // 0xBEC0816FF5ACBCDA
	static Any _0xBF09786A7FCAB582(Any p0) { return invoke<Any>(0xBF09786A7FCAB582, p0); } // 0xBF09786A7FCAB582
	static void _0xBF22E0F32968E967(Player player, BOOL p1) { invoke<Void>(0xBF22E0F32968E967, player, p1); } // 0xBF22E0F32968E967
	static Any _0xC0D2AF00BCC234CA() { return invoke<Any>(0xC0D2AF00BCC234CA); } // 0xC0D2AF00BCC234CA
	static BOOL _0xC22912B1D85F26B1(int p0, int* p1, Vector3* p2) { return invoke<BOOL>(0xC22912B1D85F26B1, p0, p1, p2); } // 0xC22912B1D85F26B1
	static Any _0xC32EA7A2F6CA7557() { return invoke<Any>(0xC32EA7A2F6CA7557); } // 0xC32EA7A2F6CA7557
	static Any _0xC3BFED92026A2AAD(Any p0, Any p1, Any p2, Any p3, Any p4) { return invoke<Any>(0xC3BFED92026A2AAD, p0, p1, p2, p3, p4); } // 0xC3BFED92026A2AAD
	static Any _0xC42DD763159F3461() { return invoke<Any>(0xC42DD763159F3461); } // 0xC42DD763159F3461
	static Any _0xC434133D9BA52777(Any p0, Any p1) { return invoke<Any>(0xC434133D9BA52777, p0, p1); } // 0xC434133D9BA52777
	static void _0xC505036A35AFD01B(BOOL p0) { invoke<Void>(0xC505036A35AFD01B, p0); } // 0xC505036A35AFD01B
	static Any _0xC55A0B40FFB1ED23() { return invoke<Any>(0xC55A0B40FFB1ED23); } // 0xC55A0B40FFB1ED23
	static Any _0xC571D0E77D8BBC29() { return invoke<Any>(0xC571D0E77D8BBC29); } // 0xC571D0E77D8BBC29
	static Any _0xC64DED7EF0D2FE37(Any* p0) { return invoke<Any>(0xC64DED7EF0D2FE37, p0); } // 0xC64DED7EF0D2FE37
	static BOOL _0xC7397A83F7A2A462(Any* p0, Any p1, BOOL p2, Any* p3) { return invoke<BOOL>(0xC7397A83F7A2A462, p0, p1, p2, p3); } // 0xC7397A83F7A2A462
	static Any _0xC7ABAC5DE675EE3B() { return invoke<Any>(0xC7ABAC5DE675EE3B); } // 0xC7ABAC5DE675EE3B
	static Any _0xC7BE335216B5EC7C() { return invoke<Any>(0xC7BE335216B5EC7C); } // 0xC7BE335216B5EC7C
	static Any _0xC87E740D9F3872CC() { return invoke<Any>(0xC87E740D9F3872CC); } // 0xC87E740D9F3872CC
	static void _0xC9B43A33D09CADA7(Any p0) { invoke<Void>(0xC9B43A33D09CADA7, p0); } // 0xC9B43A33D09CADA7
	static void _0xCA575C391FEA25CC(Any p0) { invoke<Void>(0xCA575C391FEA25CC, p0); } // 0xCA575C391FEA25CC
	static Any _0xCA94551B50B4932C(Any p0) { return invoke<Any>(0xCA94551B50B4932C, p0); } // 0xCA94551B50B4932C
	static void _0xCAE55F48D3D7875C(Any p0) { invoke<Void>(0xCAE55F48D3D7875C, p0); } // 0xCAE55F48D3D7875C
	static int _0xCB215C4B56A7FAE7(BOOL p0) { return invoke<int>(0xCB215C4B56A7FAE7, p0); } // 0xCB215C4B56A7FAE7
	static BOOL _0xCCA4318E1AB03F1F(Any* p0) { return invoke<BOOL>(0xCCA4318E1AB03F1F, p0); } // 0xCCA4318E1AB03F1F
	static void _0xCD71A4ECAB22709E(Entity entity) { invoke<Void>(0xCD71A4ECAB22709E, entity); } // 0xCD71A4ECAB22709E
	static int _0xCF61D4B4702EE9EB() { return invoke<int>(0xCF61D4B4702EE9EB); } // 0xCF61D4B4702EE9EB
	static void _0xCFD115B373C0DF63(Any p0, Any* p1) { invoke<Void>(0xCFD115B373C0DF63, p0, p1); } // 0xCFD115B373C0DF63
	static void _0xCFEB46DCD7D8D5EB(BOOL p0) { invoke<Void>(0xCFEB46DCD7D8D5EB, p0); } // 0xCFEB46DCD7D8D5EB
	static void _0xCFEB8AF24FC1D0BB(BOOL p0) { invoke<Void>(0xCFEB8AF24FC1D0BB, p0); } // 0xCFEB8AF24FC1D0BB
	static BOOL _0xD05D1A6C74DA3498(Any* p0, BOOL p1, Any* p2) { return invoke<BOOL>(0xD05D1A6C74DA3498, p0, p1, p2); } // 0xD05D1A6C74DA3498
	static Any _0xD0A484CB2F829FBE() { return invoke<Any>(0xD0A484CB2F829FBE); } // 0xD0A484CB2F829FBE
	static Any _0xD313DE83394AF134() { return invoke<Any>(0xD313DE83394AF134); } // 0xD313DE83394AF134
	static Any _0xD38C4A6D047C019D() { return invoke<Any>(0xD38C4A6D047C019D); } // 0xD38C4A6D047C019D
	static Any _0xD39B3FFF8FFDD5BF(Any p0) { return invoke<Any>(0xD39B3FFF8FFDD5BF, p0); } // 0xD39B3FFF8FFDD5BF
	static Any _0xD53ACDBEF24A46E8() { return invoke<Any>(0xD53ACDBEF24A46E8); } // 0xD53ACDBEF24A46E8
	static BOOL _0xD5A4B59980401588(Any p0, Any p1, Any* p2, Any* p3) { return invoke<BOOL>(0xD5A4B59980401588, p0, p1, p2, p3); } // 0xD5A4B59980401588
	static int _0xD66C9E72B3CC4982(Any* p0, Any p1) { return invoke<int>(0xD66C9E72B3CC4982, p0, p1); } // 0xD66C9E72B3CC4982
	static void _0xD7B6C73CAD419BCF(Any p0) { invoke<Void>(0xD7B6C73CAD419BCF, p0); } // 0xD7B6C73CAD419BCF
	static Any _0xDEB2B99A1AF1A2A6(Any p0) { return invoke<Any>(0xDEB2B99A1AF1A2A6, p0); } // 0xDEB2B99A1AF1A2A6
	static Any _0xDFFA5BE8381C3314() { return invoke<Any>(0xDFFA5BE8381C3314); } // 0xDFFA5BE8381C3314
	static Any _0xE0A6138401BCB837() { return invoke<Any>(0xE0A6138401BCB837); } // 0xE0A6138401BCB837
	static Any _0xE16AA70CE9BEEDC3(Any p0) { return invoke<Any>(0xE16AA70CE9BEEDC3, p0); } // 0xE16AA70CE9BEEDC3
	static BOOL _0xE64A3CA08DFA37A9(Any p0) { return invoke<BOOL>(0xE64A3CA08DFA37A9, p0); } // 0xE64A3CA08DFA37A9
	static void _0xE66C690248F11150(Entity p0, Any p1) { invoke<Void>(0xE66C690248F11150, p0, p1); } // 0xE66C690248F11150
	static void _0xE6717E652B8C8D8A(Any p0, Any p1) { invoke<Void>(0xE6717E652B8C8D8A, p0, p1); } // 0xE6717E652B8C8D8A
	static void _0xE9B99B6853181409() { invoke<Void>(0xE9B99B6853181409); } // 0xE9B99B6853181409
	static Any _0xEA14EEF5B7CD2C30() { return invoke<Any>(0xEA14EEF5B7CD2C30); } // 0xEA14EEF5B7CD2C30
	static Any _0xEBCAB9E5048434F4() { return invoke<Any>(0xEBCAB9E5048434F4); } // 0xEBCAB9E5048434F4
	static void _0xEBEFC2E77084F599(Any p0, char* p1, BOOL p2) { invoke<Void>(0xEBEFC2E77084F599, p0, p1, p2); } // 0xEBEFC2E77084F599
	static void _0xEBF8284D8CADEB53() { invoke<Void>(0xEBF8284D8CADEB53); } // 0xEBF8284D8CADEB53
	static BOOL _0xEBFA8D50ADDC54C4(Any p0) { return invoke<BOOL>(0xEBFA8D50ADDC54C4, p0); } // 0xEBFA8D50ADDC54C4
	static Any _0xEDF7F927136C224B() { return invoke<Any>(0xEDF7F927136C224B); } // 0xEDF7F927136C224B
	static BOOL _0xEF0912DDF7C4CB4B() { return invoke<BOOL>(0xEF0912DDF7C4CB4B); } // 0xEF0912DDF7C4CB4B
	static void _0xF03755696450470C() { invoke<Void>(0xF03755696450470C); } // 0xF03755696450470C
	static void _0xF083835B70BA9BFE() { invoke<Void>(0xF083835B70BA9BFE); } // 0xF083835B70BA9BFE
	static Any _0xF12E6CD06C73D69E() { return invoke<Any>(0xF12E6CD06C73D69E); } // 0xF12E6CD06C73D69E
	static void _0xF1B84178F8674195(Any p0) { invoke<Void>(0xF1B84178F8674195, p0); } // 0xF1B84178F8674195
	static void _0xF1EEA2DDA9FFA69D(Any p0) { invoke<Void>(0xF1EEA2DDA9FFA69D, p0); } // 0xF1EEA2DDA9FFA69D
	static Any _0xF287F506767CC8A9() { return invoke<Any>(0xF287F506767CC8A9); } // 0xF287F506767CC8A9
	static Any _0xF2EAC213D5EA0623() { return invoke<Any>(0xF2EAC213D5EA0623); } // 0xF2EAC213D5EA0623
	static void _0xF45352426FF3A4F0(int* clanDesc, int bufferSize, int* networkHandle) { invoke<Void>(0xF45352426FF3A4F0, clanDesc, bufferSize, networkHandle); } // 0xF45352426FF3A4F0
	static void _0xF46A1E03E8755980(BOOL p0) { invoke<Void>(0xF46A1E03E8755980, p0); } // 0xF46A1E03E8755980
	static void _0xF49ABC20D8552257(Any p0) { invoke<Void>(0xF49ABC20D8552257, p0); } // 0xF49ABC20D8552257
	static BOOL _0xF53E48461B71EECB(Any p0) { return invoke<BOOL>(0xF53E48461B71EECB, p0); } // 0xF53E48461B71EECB
	static void _0xF6F4383B7C92F11A(Any p0) { invoke<Void>(0xF6F4383B7C92F11A, p0); } // 0xF6F4383B7C92F11A
	static void _0xF814FEC6A19FD6E0() { invoke<Void>(0xF814FEC6A19FD6E0); } // 0xF814FEC6A19FD6E0
	static void _0xF98DDE0A8ED09323(BOOL p0) { invoke<Void>(0xF98DDE0A8ED09323, p0); } // 0xF98DDE0A8ED09323
	static Any _0xF9B83B77929D8863() { return invoke<Any>(0xF9B83B77929D8863); } // 0xF9B83B77929D8863
	static BOOL _0xF9E1CCAE8BA4C281(Any p0, Any p1, Any* p2, Any* p3) { return invoke<BOOL>(0xF9E1CCAE8BA4C281, p0, p1, p2, p3); } // 0xF9E1CCAE8BA4C281
	static void _0xFA2888E3833C8E96() { invoke<Void>(0xFA2888E3833C8E96); } // 0xFA2888E3833C8E96
	static void _0xFAE628F1E9ADB239(Any p0, Any p1, Any p2) { invoke<Void>(0xFAE628F1E9ADB239, p0, p1, p2); } // 0xFAE628F1E9ADB239
	static Any _0xFAFC23AEE23868DB() { return invoke<Any>(0xFAFC23AEE23868DB); } // 0xFAFC23AEE23868DB
	static Any _0xFB1F9381E80FA13F(int p0, Any* p1) { return invoke<Any>(0xFB1F9381E80FA13F, p0, p1); } // 0xFB1F9381E80FA13F
	static void _0xFB680D403909DC70(Any p0, Any p1) { invoke<Void>(0xFB680D403909DC70, p0, p1); } // 0xFB680D403909DC70
	static void _0xFB8F2A6F3DF08CBE() { invoke<Void>(0xFB8F2A6F3DF08CBE); } // 0xFB8F2A6F3DF08CBE
	static Any _0xFBC5E768C7A77A6A() { return invoke<Any>(0xFBC5E768C7A77A6A); } // 0xFBC5E768C7A77A6A
	static void _0xFC18DB55AE19E046(BOOL p0) { invoke<Void>(0xFC18DB55AE19E046, p0); } // 0xFC18DB55AE19E046
	static void _0xFD75DABC0957BF33(BOOL p0) { invoke<Void>(0xFD75DABC0957BF33, p0); } // 0xFD75DABC0957BF33
	static Any _0xFD8B834A8BA05048() { return invoke<Any>(0xFD8B834A8BA05048); } // 0xFD8B834A8BA05048
	static Any _0xFFE1E5B792D92B34() { return invoke<Any>(0xFFE1E5B792D92B34); } // 0xFFE1E5B792D92B34
	static int OBJ_TO_NET(Object object) { return invoke<int>(0x99BFDC94A603E541, object); } // 0x99BFDC94A603E541
	static Player PARTICIPANT_ID() { return invoke<Player>(0x90986E8876CE0A83); } // 0x90986E8876CE0A83
	static int PARTICIPANT_ID_TO_INT() { return invoke<int>(0x57A3BDDAD8E5AA0A); } // 0x57A3BDDAD8E5AA0A
	static int PED_TO_NET(Ped ped) { return invoke<int>(0xEDEC3C276198689, ped); } // 0xEDEC3C276198689
	static void RESERVE_NETWORK_MISSION_OBJECTS(int amount) { invoke<Void>(0x4E5C93BD0C32FBF8, amount); } // 0x4E5C93BD0C32FBF8
	static void RESERVE_NETWORK_MISSION_PEDS(int amount) { invoke<Void>(0xB60FEBA45333D36F, amount); } // 0xB60FEBA45333D36F
	static void RESERVE_NETWORK_MISSION_VEHICLES(int amount) { invoke<Void>(0x76B02E21ED27A469, amount); } // 0x76B02E21ED27A469
	static BOOL SET_BALANCE_ADD_MACHINE(Any* p0, Any* p1) { return invoke<BOOL>(0x815E5E3073DA1D67, p0, p1); } // 0x815E5E3073DA1D67
	static BOOL SET_BALANCE_ADD_MACHINES(Any* p0, Any p1, Any* p2) { return invoke<BOOL>(0xB8322EEB38BE7C26, p0, p1, p2); } // 0xB8322EEB38BE7C26
	static void SET_ENTITY_LOCALLY_INVISIBLE(Entity entity) { invoke<Void>(0xE135A9FF3F5D05D8, entity); } // 0xE135A9FF3F5D05D8
	static void SET_ENTITY_LOCALLY_VISIBLE(Entity entity) { invoke<Void>(0x241E289B5C059EDC, entity); } // 0x241E289B5C059EDC
	static void SET_ENTITY_VISIBLE_IN_CUTSCENE(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xE0031D3C8F36AB82, p0, p1, p2); } // 0xE0031D3C8F36AB82
	static void SET_LOCAL_PLAYER_INVISIBLE_LOCALLY(BOOL p0) { invoke<Void>(0xE5F773C1A1D9D168, p0); } // 0xE5F773C1A1D9D168
	static void SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE(BOOL p0, BOOL p1) { invoke<Void>(0xD1065D68947E7B6E, p0, p1); } // 0xD1065D68947E7B6E
	static void SET_LOCAL_PLAYER_VISIBLE_LOCALLY(BOOL p0) { invoke<Void>(0x7619364C82D3BF14, p0); } // 0x7619364C82D3BF14
	static void SET_NETWORK_ID_CAN_MIGRATE(int netId, BOOL toggle) { invoke<Void>(0x299EEB23175895FC, netId, toggle); } // 0x299EEB23175895FC
	static void SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(int netId, BOOL toggle) { invoke<Void>(0xE05E81A888FA63C8, netId, toggle); } // 0xE05E81A888FA63C8
	static void _SET_NETWORK_ID_SYNC_TO_PLAYER(int netId, Player player, BOOL toggle) { invoke<Void>(0xA8A024587329F36A, netId, player, toggle); } // 0xA8A024587329F36A
	static void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE(int netId, BOOL p1, BOOL p2) { invoke<Void>(0xA6928482543022B4, netId, p1, p2); } // 0xA6928482543022B4
	static void _SET_NETWORK_OBJECT_NON_CONTACT(Object object, BOOL toggle) { invoke<Void>(0x6274C4712850841E, object, toggle); } // 0x6274C4712850841E
	static void SET_NETWORK_VEHICLE_RESPOT_TIMER(int netId, int time) { invoke<Void>(0xEC51713AB6EC36E8, netId, time); } // 0xEC51713AB6EC36E8
	static void SET_PLAYER_INVISIBLE_LOCALLY(Player player, BOOL toggle) { invoke<Void>(0x12B37D54667DB0B8, player, toggle); } // 0x12B37D54667DB0B8
	static void SET_PLAYER_VISIBLE_LOCALLY(Player player, BOOL toggle) { invoke<Void>(0xFAA10F1FAFB11AF2, player, toggle); } // 0xFAA10F1FAFB11AF2
	static void SET_STORE_ENABLED(BOOL toggle) { invoke<Void>(0x9641A9FF718E9C5E, toggle); } // 0x9641A9FF718E9C5E
	static void SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME() { invoke<Void>(0x593850C16A36B692); } // 0x593850C16A36B692
	static char* TEXTURE_DOWNLOAD_GET_NAME(int p0) { return invoke<char*>(0x3448505B6E35262D, p0); } // 0x3448505B6E35262D
	static BOOL TEXTURE_DOWNLOAD_HAS_FAILED(int p0) { return invoke<BOOL>(0x5776ED562C134687, p0); } // 0x5776ED562C134687
	static void TEXTURE_DOWNLOAD_RELEASE(int p0) { invoke<Void>(0x487EB90B98E9FB19, p0); } // 0x487EB90B98E9FB19
	static int TEXTURE_DOWNLOAD_REQUEST(int* PlayerHandle, char* FilePath, char* Name, BOOL p3) { return invoke<int>(0x16160DA74A8E74A2, PlayerHandle, FilePath, Name, p3); } // 0x16160DA74A8E74A2
	static void USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR(BOOL toggle) { invoke<Void>(0x5FFE9B4144F9712F, toggle); } // 0x5FFE9B4144F9712F
	static BOOL USING_NETWORK_WEAPONTYPE(Any p0) { return invoke<BOOL>(0xE26CCFF8094D8C74, p0); } // 0xE26CCFF8094D8C74
	static int VEH_TO_NET(Vehicle vehicle) { return invoke<int>(0xB4C94523F023419C, vehicle); } // 0xB4C94523F023419C
}

namespace NETWORKCASH
{
	static void NETWORK_BUY_AIRSTRIKE(int cost, BOOL p1, BOOL p2) { invoke<Void>(0x763B4BD305338F19, cost, p1, p2); } // 0x763B4BD305338F19
	static void NETWORK_BUY_BOUNTY(int amount, Player victim, BOOL p2, BOOL p3) { invoke<Void>(0x7B718E197453F2D9, amount, victim, p2, p3); } // 0x7B718E197453F2D9
	static void NETWORK_BUY_FAIRGROUND_RIDE(int amountSpent, Any p1, BOOL p2, BOOL p3) { invoke<Void>(0x8A7B3952DD64D2B5, amountSpent, p1, p2, p3); } // 0x8A7B3952DD64D2B5
	static void NETWORK_BUY_HEALTHCARE(int cost, BOOL p1, BOOL p2) { invoke<Void>(0xD9B067E55253E3DD, cost, p1, p2); } // 0xD9B067E55253E3DD
	static void NETWORK_BUY_HELI_STRIKE(int cost, BOOL p1, BOOL p2) { invoke<Void>(0x81AA4610E3FD3A69, cost, p1, p2); } // 0x81AA4610E3FD3A69
	static void NETWORK_BUY_ITEM(Ped player, Hash item, Any p2, Any p3, BOOL p4, char* item_name, Any p6, Any p7, Any p8, BOOL p9) { invoke<Void>(0xF0077C797F66A355, player, item, p2, p3, p4, item_name, p6, p7, p8, p9); } // 0xF0077C797F66A355
	static void NETWORK_BUY_PROPERTY(float propertyCost, Hash propertyName, BOOL p2, BOOL p3) { invoke<Void>(0x650A08A280870AF6, propertyCost, propertyName, p2, p3); } // 0x650A08A280870AF6
	static BOOL NETWORK_CAN_BET(Any p0) { return invoke<BOOL>(0x3A54E33660DED67F, p0); } // 0x3A54E33660DED67F
	static BOOL NETWORK_CAN_RECEIVE_PLAYER_CASH(Any p0, Any p1, Any p2, Any p3) { return invoke<BOOL>(0x5D17BE59D2123284, p0, p1, p2, p3); } // 0x5D17BE59D2123284
	static BOOL NETWORK_CAN_SPEND_MONEY(Any p0, BOOL p1, BOOL p2, BOOL p3, Any p4) { return invoke<BOOL>(0xAB3CAA6B422164DA, p0, p1, p2, p3, p4); } // 0xAB3CAA6B422164DA
	static void NETWORK_CLEAR_CHARACTER_WALLET(Any p0) { invoke<Void>(0xA921DED15FDF28F5, p0); } // 0xA921DED15FDF28F5
	static void NETWORK_DELETE_CHARACTER(int characterIndex, BOOL p1, BOOL p2) { invoke<Void>(0x5A50AF38947EB8D, characterIndex, p1, p2); } // 0x5A50AF38947EB8D
	static void NETWORK_EARN_FROM_AI_TARGET_KILL(Any p0, Any p1) { invoke<Void>(0x515B4A22E4D3C6D7, p0, p1); } // 0x515B4A22E4D3C6D7
	static void _NETWORK_EARN_FROM_AMBIENT_JOB(int p0, char* p1, Any* p2) { invoke<Void>(0xFB6DB092FBAE29E6, p0, p1, p2); } // 0xFB6DB092FBAE29E6
	static void _NETWORK_EARN_FROM_ARMOUR_TRUCK(int amount) { invoke<Void>(0xF514621E8EA463D0, amount); } // 0xF514621E8EA463D0
	static void NETWORK_EARN_FROM_BETTING(int amount, char* p1) { invoke<Void>(0x827A5BA1A44ACA6D, amount, p1); } // 0x827A5BA1A44ACA6D
	static void NETWORK_EARN_FROM_BOUNTY(int amount, int* networkHandle, Any* p2, Any p3) { invoke<Void>(0x131BB5DA15453ACF, amount, networkHandle, p2, p3); } // 0x131BB5DA15453ACF
	static void NETWORK_EARN_FROM_CHALLENGE_WIN(Any p0, Any* p1, BOOL p2) { invoke<Void>(0x2B171E6B2F64D8DF, p0, p1, p2); } // 0x2B171E6B2F64D8DF
	static void NETWORK_EARN_FROM_CRATE_DROP(int amount) { invoke<Void>(0xB1CC1B9EC3007A2A, amount); } // 0xB1CC1B9EC3007A2A
	static void _NETWORK_EARN_FROM_DAILY_OBJECTIVE(int p0, char* p1, int p2) { invoke<Void>(0x6EA318C91C1A8786, p0, p1, p2); } // 0x6EA318C91C1A8786
	static void _NETWORK_EARN_FROM_GANG_PICKUP(int amount) { invoke<Void>(0xA03D4ACE0A3284CE, amount); } // 0xA03D4ACE0A3284CE
	static void NETWORK_EARN_FROM_HOLDUPS(int amount) { invoke<Void>(0x45B8154E077D9E4D, amount); } // 0x45B8154E077D9E4D
	static void NETWORK_EARN_FROM_IMPORT_EXPORT(Any p0, Any p1) { invoke<Void>(0xF92A014A634442D6, p0, p1); } // 0xF92A014A634442D6
	static void NETWORK_EARN_FROM_JOB(int amount, char* p1) { invoke<Void>(0xB2CC4836834E8A98, amount, p1); } // 0xB2CC4836834E8A98
	static void _NETWORK_EARN_FROM_JOB_BONUS(Any p0, Any* p1, Any* p2) { invoke<Void>(0x6816FB4416760775, p0, p1, p2); } // 0x6816FB4416760775
	static void NETWORK_EARN_FROM_MISSION_H(int amount, char* heistHash) { invoke<Void>(0x61326EE6DF15B0CA, amount, heistHash); } // 0x61326EE6DF15B0CA
	static void NETWORK_EARN_FROM_NOT_BADSPORT(int amount) { invoke<Void>(0x4337511FA8221D36, amount); } // 0x4337511FA8221D36
	static void NETWORK_EARN_FROM_PERSONAL_VEHICLE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { invoke<Void>(0x3F4D00167E41E0AD, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0x3F4D00167E41E0AD
	static Any NETWORK_EARN_FROM_PICKUP(int amount) { return invoke<Any>(0xED1517D3AF17C698, amount); } // 0xED1517D3AF17C698
	static void NETWORK_EARN_FROM_PROPERTY(int amount, Hash propertyName) { invoke<Void>(0x849648349D77F5C5, amount, propertyName); } // 0x849648349D77F5C5
	static void NETWORK_EARN_FROM_ROCKSTAR(int amount) { invoke<Void>(0x2CE1D6AC0FC73EA, amount); } // 0x2CE1D6AC0FC73EA
	static void NETWORK_EARN_FROM_VEHICLE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { invoke<Void>(0xB539BD8A4C1EECF8, p0, p1, p2, p3, p4, p5, p6, p7); } // 0xB539BD8A4C1EECF8
	static char* _NETWORK_GET_BANK_BALANCE_STRING() { return invoke<char*>(0xA6FA3979BED01B81); } // 0xA6FA3979BED01B81
	static int NETWORK_GET_VC_BALANCE() { return invoke<int>(0x5CBAD97E059E1B94); } // 0x5CBAD97E059E1B94
	static int NETWORK_GET_VC_BANK_BALANCE() { return invoke<int>(0x76EF28DA05EA395A); } // 0x76EF28DA05EA395A
	static int NETWORK_GET_VC_WALLET_BALANCE(int character) { return invoke<int>(0xA40F9C2623F6A8B5, character); } // 0xA40F9C2623F6A8B5
	static void NETWORK_GIVE_PLAYER_JOBSHARE_CASH(int amount, int* networkHandle) { invoke<Void>(0xFB18DF9CB95E0105, amount, networkHandle); } // 0xFB18DF9CB95E0105
	static void NETWORK_INITIALIZE_CASH(int p0, int p1) { invoke<Void>(0x3DA5ECD1A56CBA6D, p0, p1); } // 0x3DA5ECD1A56CBA6D
	static BOOL NETWORK_MONEY_CAN_BET(Any p0, BOOL p1, BOOL p2) { return invoke<BOOL>(0x81404F3DC124FE5B, p0, p1, p2); } // 0x81404F3DC124FE5B
	static void NETWORK_PAY_EMPLOYEE_WAGE(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x5FD5ED82CBBE9989, p0, p1, p2); } // 0x5FD5ED82CBBE9989
	static void NETWORK_PAY_MATCH_ENTRY_FEE(int value, int* p1, BOOL p2, BOOL p3) { invoke<Void>(0x9346E14F2AF74D46, value, p1, p2, p3); } // 0x9346E14F2AF74D46
	static void NETWORK_PAY_UTILITY_BILL(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xAFE08B35EC0C9EAE, p0, p1, p2); } // 0xAFE08B35EC0C9EAE
	static void NETWORK_RECEIVE_PLAYER_JOBSHARE_CASH(int value, int* networkHandle) { invoke<Void>(0x56A3B51944C50598, value, networkHandle); } // 0x56A3B51944C50598
	static void NETWORK_REFUND_CASH(int index, char* context, char* reason, BOOL unk) { invoke<Void>(0xF9C812CD7C46E817, index, context, reason, unk); } // 0xF9C812CD7C46E817
	static void NETWORK_SPENT_AMMO_DROP(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xB162DC95C0A3317B, p0, p1, p2); } // 0xB162DC95C0A3317B
	static void NETWORK_SPENT_ARREST_BAIL(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x812F5488B1B2A299, p0, p1, p2); } // 0x812F5488B1B2A299
	static void NETWORK_SPENT_BETTING(Any p0, Any p1, Any* p2, BOOL p3, BOOL p4) { invoke<Void>(0x1C436FD11FFA692F, p0, p1, p2, p3, p4); } // 0x1C436FD11FFA692F
	static void NETWORK_SPENT_BOAT_PICKUP(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x524EE43A37232C00, p0, p1, p2); } // 0x524EE43A37232C00
	static void NETWORK_SPENT_BOUNTY(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x29B260B84947DFCC, p0, p1, p2); } // 0x29B260B84947DFCC
	static void NETWORK_SPENT_BULL_SHARK(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xA6DD8458CE24012C, p0, p1, p2); } // 0xA6DD8458CE24012C
	static void NETWORK_SPENT_BUY_OFFTHERADAR(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xA628A745E2275C5D, p0, p1, p2); } // 0xA628A745E2275C5D
	static void NETWORK_SPENT_BUY_PASSIVE_MODE(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x6D3A430D1A809179, p0, p1, p2); } // 0x6D3A430D1A809179
	static void NETWORK_SPENT_BUY_REVEAL_PLAYERS(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x6E176F1B18BC0637, p0, p1, p2); } // 0x6E176F1B18BC0637
	static void NETWORK_SPENT_BUY_WANTEDLEVEL(Any p0, Any* p1, BOOL p2, BOOL p3) { invoke<Void>(0xE1B13771A843C4F6, p0, p1, p2, p3); } // 0xE1B13771A843C4F6
	static void NETWORK_SPENT_CALL_PLAYER(Any p0, Any* p1, BOOL p2, BOOL p3) { invoke<Void>(0xACDE7185B374177C, p0, p1, p2, p3); } // 0xACDE7185B374177C
	static void NETWORK_SPENT_CARWASH(Any p0, Any p1, Any p2, BOOL p3, BOOL p4) { invoke<Void>(0xEC03C719DB2F4306, p0, p1, p2, p3, p4); } // 0xEC03C719DB2F4306
	static void NETWORK_SPENT_CASH_DROP(int amount, BOOL p1, BOOL p2) { invoke<Void>(0x289016EC778D60E0, amount, p1, p2); } // 0x289016EC778D60E0
	static void NETWORK_SPENT_CINEMA(Any p0, Any p1, BOOL p2, BOOL p3) { invoke<Void>(0x6B38ECB05A63A685, p0, p1, p2, p3); } // 0x6B38ECB05A63A685
	static void NETWORK_SPENT_FROM_ROCKSTAR(int bank, BOOL p1, BOOL p2) { invoke<Void>(0x6A445B64ED7ABEB5, bank, p1, p2); } // 0x6A445B64ED7ABEB5
	static void NETWORK_SPENT_HELI_PICKUP(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x7BF1D73DB2ECA492, p0, p1, p2); } // 0x7BF1D73DB2ECA492
	static void NETWORK_SPENT_HIRE_MERCENARY(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xE7B80E2BF9D80BD6, p0, p1, p2); } // 0xE7B80E2BF9D80BD6
	static void NETWORK_SPENT_HIRE_MUGGER(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xE404BFB981665BF0, p0, p1, p2); } // 0xE404BFB981665BF0
	static void NETWORK_SPENT_HOLDUPS(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xD9B86B9872039763, p0, p1, p2); } // 0xD9B86B9872039763
	static void NETWORK_SPENT_IN_STRIPCLUB(Any p0, BOOL p1, Any p2, BOOL p3) { invoke<Void>(0xEE99784E4467689C, p0, p1, p2, p3); } // 0xEE99784E4467689C
	static void NETWORK_SPENT_NO_COPS(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xD5BB406F4E04019F, p0, p1, p2); } // 0xD5BB406F4E04019F
	static void NETWORK_SPENT_PAY_VEHICLE_INSURANCE_PREMIUM(int amount, Hash vehicleModel, int* networkHandle, BOOL notBankrupt, BOOL hasTheMoney) { invoke<Void>(0x9FF28D88C766E3E8, amount, vehicleModel, networkHandle, notBankrupt, hasTheMoney); } // 0x9FF28D88C766E3E8
	static void NETWORK_SPENT_PLAYER_HEALTHCARE(Any p0, Any p1, BOOL p2, BOOL p3) { invoke<Void>(0x7C99101F7FCE2EE5, p0, p1, p2, p3); } // 0x7C99101F7FCE2EE5
	static void NETWORK_SPENT_PROSTITUTES(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xB21B89501CFAC79E, p0, p1, p2); } // 0xB21B89501CFAC79E
	static void _NETWORK_SPENT_REQUEST_HEIST(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x9D26502BB97BFE62, p0, p1, p2); } // 0x9D26502BB97BFE62
	static void NETWORK_SPENT_REQUEST_JOB(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x8204DA7934DF3155, p0, p1, p2); } // 0x8204DA7934DF3155
	static void NETWORK_SPENT_ROBBED_BY_MUGGER(int amount, BOOL p1, BOOL p2) { invoke<Void>(0x995A65F15F581359, amount, p1, p2); } // 0x995A65F15F581359
	static void NETWORK_SPENT_TAXI(int amount, BOOL p1, BOOL p2) { invoke<Void>(0x17C3A7D31EAE39F9, amount, p1, p2); } // 0x17C3A7D31EAE39F9
	static void NETWORK_SPENT_TELESCOPE(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0x7FE61782AD94CC09, p0, p1, p2); } // 0x7FE61782AD94CC09
	static Any _0x1C2473301B1C66BA() { return invoke<Any>(0x1C2473301B1C66BA); } // 0x1C2473301B1C66BA
	static void _0x6FCF8DDEA146C45B(Any p0) { invoke<Void>(0x6FCF8DDEA146C45B, p0); } // 0x6FCF8DDEA146C45B
	static BOOL _0x7303E27CC6532080(Any p0, BOOL p1, BOOL p2, BOOL p3, Any* p4, Any p5) { return invoke<BOOL>(0x7303E27CC6532080, p0, p1, p2, p3, p4, p5); } // 0x7303E27CC6532080
	static BOOL _0x7C4FCCD2E4DEB394() { return invoke<BOOL>(0x7C4FCCD2E4DEB394); } // 0x7C4FCCD2E4DEB394
	static BOOL _0xDC18531D7019A535(Any p0, Any p1) { return invoke<BOOL>(0xDC18531D7019A535, p0, p1); } // 0xDC18531D7019A535
	static BOOL _0xE154B48B68EF72BC(Any p0) { return invoke<BOOL>(0xE154B48B68EF72BC, p0); } // 0xE154B48B68EF72BC
	static BOOL _0xE260E0BB9CD995AC(Any p0) { return invoke<BOOL>(0xE260E0BB9CD995AC, p0); } // 0xE260E0BB9CD995AC
	static Any _0xF70EFA14FE091429(Any p0) { return invoke<Any>(0xF70EFA14FE091429, p0); } // 0xF70EFA14FE091429
	static char* PROCESS_CASH_GIFT(int* p0, int* p1, char* p2) { return invoke<char*>(0x20194D48EAEC9A41, p0, p1, p2); } // 0x20194D48EAEC9A41
}

namespace OBJECT
{
	static void ADD_DOOR_TO_SYSTEM(Hash doorHash, Hash modelHash, float x, float y, float z, BOOL p5, BOOL p6, BOOL p7) { invoke<Void>(0x6F8838D03D1DC226, doorHash, modelHash, x, y, z, p5, p6, p7); } // 0x6F8838D03D1DC226
	static void ATTACH_PORTABLE_PICKUP_TO_PED(Ped ped, Any p1) { invoke<Void>(0x8DC39368BDD57755, ped, p1); } // 0x8DC39368BDD57755
	static Pickup CREATE_AMBIENT_PICKUP(Hash pickupHash, float posX, float posY, float posZ, int p4, int value, Hash modelHash, BOOL returnHandle, BOOL p8) { return invoke<Pickup>(0x673966A0C0FD7171, pickupHash, posX, posY, posZ, p4, value, modelHash, returnHandle, p8); } // 0x673966A0C0FD7171
	static void CREATE_MONEY_PICKUPS(float x, float y, float z, int value, int amount, Hash model) { invoke<Void>(0x589B5E791CE9B2B, x, y, z, value, amount, model); } // 0x589B5E791CE9B2B
	static Object CREATE_OBJECT(Object modelHash, float x, float y, float z, BOOL isNetwork, BOOL thisScriptCheck, BOOL dynamic) { return invoke<Object>(0x509D5878EB39E842, modelHash, x, y, z, isNetwork, thisScriptCheck, dynamic); } // 0x509D5878EB39E842
	static Object CREATE_OBJECT_NO_OFFSET(Hash modelHash, float x, float y, float z, BOOL isNetwork, BOOL thisScriptCheck, BOOL dynamic) { return invoke<Object>(0x9A294B2138ABB884, modelHash, x, y, z, isNetwork, thisScriptCheck, dynamic); } // 0x9A294B2138ABB884
	static Pickup CREATE_PICKUP(Hash pickupHash, float posX, float posY, float posZ, int p4, int value, BOOL p6, Hash modelHash) { return invoke<Pickup>(0xFBA08C503DD5FA58, pickupHash, posX, posY, posZ, p4, value, p6, modelHash); } // 0xFBA08C503DD5FA58
	static Pickup CREATE_PICKUP_ROTATE(Hash pickupHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int flag, int amount, Any p9, BOOL p10, Hash modelHash) { return invoke<Pickup>(0x891804727E0A98B7, pickupHash, posX, posY, posZ, rotX, rotY, rotZ, flag, amount, p9, p10, modelHash); } // 0x891804727E0A98B7
	static Pickup CREATE_PORTABLE_PICKUP(Hash pickupHash, float x, float y, float z, BOOL placeOnGround, Hash modelHash) { return invoke<Pickup>(0x2EAF1FDB2FB55698, pickupHash, x, y, z, placeOnGround, modelHash); } // 0x2EAF1FDB2FB55698
	static Pickup _CREATE_PORTABLE_PICKUP_2(Hash pickupHash, float x, float y, float z, BOOL placeOnGround, Hash modelHash) { return invoke<Pickup>(0x125494B98A21AAF7, pickupHash, x, y, z, placeOnGround, modelHash); } // 0x125494B98A21AAF7
	static void DELETE_OBJECT(Object* object) { invoke<Void>(0x539E0AE3E6634B9F, object); } // 0x539E0AE3E6634B9F
	static void DETACH_PORTABLE_PICKUP_FROM_PED(Ped ped) { invoke<Void>(0xCF463D1E9A0AECB1, ped); } // 0xCF463D1E9A0AECB1
	static BOOL _DOES_DES_OBJECT_EXIST(int handle) { return invoke<BOOL>(0x52AF537A0C5B8AAD, handle); } // 0x52AF537A0C5B8AAD
	static BOOL _DOES_DOOR_EXIST(Hash doorHash) { return invoke<BOOL>(0xC153C43EA202C8C1, doorHash); } // 0xC153C43EA202C8C1
	static BOOL DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS(float x, float y, float z, float radius, Hash hash, BOOL p5) { return invoke<BOOL>(0xBFA48E2FF417213F, x, y, z, radius, hash, p5); } // 0xBFA48E2FF417213F
	static BOOL DOES_PICKUP_EXIST(Pickup pickup) { return invoke<BOOL>(0xAFC1CA75AD4074D1, pickup); } // 0xAFC1CA75AD4074D1
	static BOOL DOES_PICKUP_OBJECT_EXIST(Object pickupObject) { return invoke<BOOL>(0xD9EFB6DBF7DAAEA3, pickupObject); } // 0xD9EFB6DBF7DAAEA3
	static void _DOOR_CONTROL(Hash doorHash, float x, float y, float z, BOOL locked, float xRotMult, float yRotMult, float zRotMult) { invoke<Void>(0x9B12F9A24FABEDB0, doorHash, x, y, z, locked, xRotMult, yRotMult, zRotMult); } // 0x9B12F9A24FABEDB0
	static Object GET_CLOSEST_OBJECT_OF_TYPE(float x, float y, float z, float radius, Hash modelHash, BOOL isMission, BOOL p6, BOOL p7) { return invoke<Object>(0xE143FA2249364369, x, y, z, radius, modelHash, isMission, p6, p7); } // 0xE143FA2249364369
	static int _GET_DES_OBJECT(float x, float y, float z, float rotation, char* name) { return invoke<int>(0xB48FCED898292E52, x, y, z, rotation, name); } // 0xB48FCED898292E52
	static float _GET_DES_OBJECT_ANIM_PROGRESS(int desObjectHandle) { return invoke<float>(0x260EE4FDBDF4DB01, desObjectHandle); } // 0x260EE4FDBDF4DB01
	static Any _GET_DES_OBJECT_STATE(int handle) { return invoke<Any>(0x899BA936634A322E, handle); } // 0x899BA936634A322E
	static float GET_OBJECT_FRAGMENT_DAMAGE_HEALTH(Any p0, BOOL p1) { return invoke<float>(0xB6FBFD079B8D0596, p0, p1); } // 0xB6FBFD079B8D0596
	static Vector3 _GET_OBJECT_OFFSET_FROM_COORDS(float xPos, float yPos, float zPos, float heading, float xOffset, float yOffset, float zOffset) { return invoke<Vector3>(0x163E252DE035A133, xPos, yPos, zPos, heading, xOffset, yOffset, zOffset); } // 0x163E252DE035A133
	static Vector3 GET_PICKUP_COORDS(Pickup pickup) { return invoke<Vector3>(0x225B8B35C88029B3, pickup); } // 0x225B8B35C88029B3
	static Hash _GET_PICKUP_HASH(Pickup pickupHash) { return invoke<Hash>(0x5EAAD83F8CFB4575, pickupHash); } // 0x5EAAD83F8CFB4575
	static Object GET_PICKUP_OBJECT(Pickup pickup) { return invoke<Object>(0x5099BC55630B25AE, pickup); } // 0x5099BC55630B25AE
	static Vector3 GET_SAFE_PICKUP_COORDS(float x, float y, float z, Any p3, Any p4) { return invoke<Vector3>(0x6E16BC2503FF1FF0, x, y, z, p3, p4); } // 0x6E16BC2503FF1FF0
	static void GET_STATE_OF_CLOSEST_DOOR_OF_TYPE(Hash type, float x, float y, float z, BOOL* locked, float* heading) { invoke<Void>(0xEDC1A5B84AEF33FF, type, x, y, z, locked, heading); } // 0xEDC1A5B84AEF33FF
	static Hash _GET_WEAPON_HASH_FROM_PICKUP(Pickup pickupHash) { return invoke<Hash>(0x8F96CA6C551AD51, pickupHash); } // 0x8F96CA6C551AD51
	static BOOL HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN(float p0, float p1, float p2, float p3, Hash modelHash, Any p5) { return invoke<BOOL>(0x761B0E69AC4D007E, p0, p1, p2, p3, modelHash, p5); } // 0x761B0E69AC4D007E
	static BOOL HAS_OBJECT_BEEN_BROKEN(Object object) { return invoke<BOOL>(0x8ABFB70C49CC43E2, object); } // 0x8ABFB70C49CC43E2
	static BOOL HAS_PICKUP_BEEN_COLLECTED(Pickup pickup) { return invoke<BOOL>(0x80EC48E6679313F9, pickup); } // 0x80EC48E6679313F9
	static void _HIGHLIGHT_PLACEMENT_COORDS(float x, float y, float z, int colorIndex) { invoke<Void>(0x3430676B11CDF21D, x, y, z, colorIndex); } // 0x3430676B11CDF21D
	static BOOL IS_ANY_OBJECT_NEAR_POINT(float x, float y, float z, float range, BOOL p4) { return invoke<BOOL>(0x397DC58FF00298D1, x, y, z, range, p4); } // 0x397DC58FF00298D1
	static BOOL IS_DOOR_CLOSED(Hash door) { return invoke<BOOL>(0xC531EE8A1145A149, door); } // 0xC531EE8A1145A149
	static BOOL IS_GARAGE_EMPTY(Any garage, BOOL p1, int p2) { return invoke<BOOL>(0x90E47239EA1980B8, garage, p1, p2); } // 0x90E47239EA1980B8
	static BOOL IS_OBJECT_NEAR_POINT(Hash objectHash, float x, float y, float z, float range) { return invoke<BOOL>(0x8C90FE4B381BA60A, objectHash, x, y, z, range); } // 0x8C90FE4B381BA60A
	static BOOL IS_OBJECT_VISIBLE(Object object) { return invoke<BOOL>(0x8B32ACE6326A7546, object); } // 0x8B32ACE6326A7546
	static BOOL _IS_PICKUP_WITHIN_RADIUS(Hash pickupHash, float x, float y, float z, float radius) { return invoke<BOOL>(0xF9C36251F6E48E33, pickupHash, x, y, z, radius); } // 0xF9C36251F6E48E33
	static BOOL IS_POINT_IN_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, BOOL p10, BOOL p11) { return invoke<BOOL>(0x2A70BAE8883E4C81, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); } // 0x2A70BAE8883E4C81
	static void _MARK_OBJECT_FOR_DELETION(Object object) { invoke<Void>(0xADBE4809F19F927A, object); } // 0xADBE4809F19F927A
	static BOOL _0x024A60DEB0EA69F0(Any p0, Player player, float p2, int p3) { return invoke<BOOL>(0x24A60DEB0EA69F0, p0, player, p2, p3); } // 0x24A60DEB0EA69F0
	static BOOL _0x0378C08504160D0D(Any p0) { return invoke<BOOL>(0x378C08504160D0D, p0); } // 0x378C08504160D0D
	static void _0x03C27E13B42A0E82(Hash doorHash, float p1, BOOL p2, BOOL p3) { invoke<Void>(0x3C27E13B42A0E82, doorHash, p1, p2, p3); } // 0x3C27E13B42A0E82
	static void _0x0596843B34B95CE5(Any p0, Any p1) { invoke<Void>(0x596843B34B95CE5, p0, p1); } // 0x596843B34B95CE5
	static void _0x0BF3B3BD47D79C08(Hash hash, int p1) { invoke<Void>(0xBF3B3BD47D79C08, hash, p1); } // 0xBF3B3BD47D79C08
	static BOOL _0x11D1E53A726891FE(Object object) { return invoke<BOOL>(0x11D1E53A726891FE, object); } // 0x11D1E53A726891FE
	static int _0x160AA1B32F6139B8(Hash doorHash) { return invoke<int>(0x160AA1B32F6139B8, doorHash); } // 0x160AA1B32F6139B8
	static Any _0x163F8B586BC95F2A(Any coords, float radius, Hash modelHash, float x, float y, float z, Vector3* p6, int p7) { return invoke<Any>(0x163F8B586BC95F2A, coords, radius, modelHash, x, y, z, p6, p7); } // 0x163F8B586BC95F2A
	static BOOL _0x1761DC5D8471CBAA(Any p0, Player player, int p2) { return invoke<BOOL>(0x1761DC5D8471CBAA, p0, player, p2); } // 0x1761DC5D8471CBAA
	static void _0x190428512B240692(Any p0, BOOL p1, BOOL p2, BOOL p3, BOOL p4) { invoke<Void>(0x190428512B240692, p0, p1, p2, p3, p4); } // 0x190428512B240692
	static void _0x1C1B69FAE509BA97(Any p0, Any p1) { invoke<Void>(0x1C1B69FAE509BA97, p0, p1); } // 0x1C1B69FAE509BA97
	static void _0x1E3F1B1B891A2AAA(Any p0, Any p1) { invoke<Void>(0x1E3F1B1B891A2AAA, p0, p1); } // 0x1E3F1B1B891A2AAA
	static void _0x318516E02DE3ECE2(float p0) { invoke<Void>(0x318516E02DE3ECE2, p0); } // 0x318516E02DE3ECE2
	static void _0x31F924B53EADDF65(BOOL p0) { invoke<Void>(0x31F924B53EADDF65, p0); } // 0x31F924B53EADDF65
	static BOOL _0x372EF6699146A1E4(Any p0, Entity entity, float p2, int p3) { return invoke<BOOL>(0x372EF6699146A1E4, p0, entity, p2, p3); } // 0x372EF6699146A1E4
	static void _0x394CD08E31313C28() { invoke<Void>(0x394CD08E31313C28); } // 0x394CD08E31313C28
	static void _0x39A5FB7EAF150840(Any p0, Any p1) { invoke<Void>(0x39A5FB7EAF150840, p0, p1); } // 0x39A5FB7EAF150840
	static void _0x3ED2B83AB2E82799(Any p0, Any p1) { invoke<Void>(0x3ED2B83AB2E82799, p0, p1); } // 0x3ED2B83AB2E82799
	static BOOL _0x46494A2475701343(float p0, float p1, float p2, float p3, Hash modelHash, BOOL p5) { return invoke<BOOL>(0x46494A2475701343, p0, p1, p2, p3, modelHash, p5); } // 0x46494A2475701343
	static void _0x46F3ADD1E2D5BAF2(Any p0, Any p1) { invoke<Void>(0x46F3ADD1E2D5BAF2, p0, p1); } // 0x46F3ADD1E2D5BAF2
	static void _0x4A39DB43E47CF3AA(Any p0) { invoke<Void>(0x4A39DB43E47CF3AA, p0); } // 0x4A39DB43E47CF3AA
	static int _0x4BC2854478F3A749(Hash doorHash) { return invoke<int>(0x4BC2854478F3A749, doorHash); } // 0x4BC2854478F3A749
	static void _0x4D89D607CB3DD1D2(Object object, BOOL toggle) { invoke<Void>(0x4D89D607CB3DD1D2, object, toggle); } // 0x4D89D607CB3DD1D2
	static BOOL _0x589F80B325CC82C5(float p0, float p1, float p2, Any p3, Any* p4) { return invoke<BOOL>(0x589F80B325CC82C5, p0, p1, p2, p3, p4); } // 0x589F80B325CC82C5
	static void _0x616093EC6B139DD9(Player player, Hash pickupHash, BOOL p2) { invoke<Void>(0x616093EC6B139DD9, player, pickupHash, p2); } // 0x616093EC6B139DD9
	static void _0x62454A641B41F3C5(Any p0) { invoke<Void>(0x62454A641B41F3C5, p0); } // 0x62454A641B41F3C5
	static void _0x641F272B52E2F0F8(Any p0, Any p1) { invoke<Void>(0x641F272B52E2F0F8, p0, p1); } // 0x641F272B52E2F0F8
	static float _0x65499865FCA6E5EC(Hash doorHash) { return invoke<float>(0x65499865FCA6E5EC, doorHash); } // 0x65499865FCA6E5EC
	static void _0x66A49D021870FE88() { invoke<Void>(0x66A49D021870FE88); } // 0x66A49D021870FE88
	static BOOL _0x673ED815D6E323B7(Any p0, BOOL p1, BOOL p2, BOOL p3, Any p4) { return invoke<BOOL>(0x673ED815D6E323B7, p0, p1, p2, p3, p4); } // 0x673ED815D6E323B7
	static void _0x701FDA1E82076BA4() { invoke<Void>(0x701FDA1E82076BA4); } // 0x701FDA1E82076BA4
	static void _0x758A5C1B3B1E1990(Any p0) { invoke<Void>(0x758A5C1B3B1E1990, p0); } // 0x758A5C1B3B1E1990
	static void _0x762DB2D380B48D04(Any p0) { invoke<Void>(0x762DB2D380B48D04, p0); } // 0x762DB2D380B48D04
	static void _0x78857FC65CADB909(BOOL p0) { invoke<Void>(0x78857FC65CADB909, p0); } // 0x78857FC65CADB909
	static void _0x826D1EE4D1CAFC78(Any p0, Any p1) { invoke<Void>(0x826D1EE4D1CAFC78, p0, p1); } // 0x826D1EE4D1CAFC78
	static void _0x858EC9FD25DE04AA(Any p0, Any p1) { invoke<Void>(0x858EC9FD25DE04AA, p0, p1); } // 0x858EC9FD25DE04AA
	static BOOL _0x85B6C850546FDDE2(Any p0, BOOL p1, BOOL p2, BOOL p3, Any p4) { return invoke<BOOL>(0x85B6C850546FDDE2, p0, p1, p2, p3, p4); } // 0x85B6C850546FDDE2
	static void _0x867458251D47CCB2(Any p0, Any p1) { invoke<Void>(0x867458251D47CCB2, p0, p1); } // 0x867458251D47CCB2
	static void _0x8881C98A31117998(Any p0) { invoke<Void>(0x8881C98A31117998, p0); } // 0x8881C98A31117998
	static void _0x88EAEC617CD26926(Hash p0, BOOL p1) { invoke<Void>(0x88EAEC617CD26926, p0, p1); } // 0x88EAEC617CD26926
	static void _0x8CAAB2BD3EA58BD4(Any p0) { invoke<Void>(0x8CAAB2BD3EA58BD4, p0); } // 0x8CAAB2BD3EA58BD4
	static void _0x92AEFB5F6E294023(Object object, BOOL p1, BOOL p2) { invoke<Void>(0x92AEFB5F6E294023, object, p1, p2); } // 0x92AEFB5F6E294023
	static void _0x96EE0EBA0163DF80(Any p0, Any p1) { invoke<Void>(0x96EE0EBA0163DF80, p0, p1); } // 0x96EE0EBA0163DF80
	static void _0x9BA001CB45CBF627(Hash doorHash, float heading, BOOL p2, BOOL p3) { invoke<Void>(0x9BA001CB45CBF627, doorHash, heading, p2, p3); } // 0x9BA001CB45CBF627
	static void _0xA08FE5E49BDC39DD(Any p0, float p1, BOOL p2) { invoke<Void>(0xA08FE5E49BDC39DD, p0, p1, p2); } // 0xA08FE5E49BDC39DD
	static void _0xA2C1F5E92AFE49ED() { invoke<Void>(0xA2C1F5E92AFE49ED); } // 0xA2C1F5E92AFE49ED
	static void _0xA85A21582451E951(Hash doorHash, BOOL p1) { invoke<Void>(0xA85A21582451E951, doorHash, p1); } // 0xA85A21582451E951
	static void _0xA90E7227A9303FA9(Any p0, Any p1) { invoke<Void>(0xA90E7227A9303FA9, p0, p1); } // 0xA90E7227A9303FA9
	static void _0xB2D0BDE54F0E8E5A(Object object, BOOL toggle) { invoke<Void>(0xB2D0BDE54F0E8E5A, object, toggle); } // 0xB2D0BDE54F0E8E5A
	static Any _0xB3ECA65C7317F174() { return invoke<Any>(0xB3ECA65C7317F174); } // 0xB3ECA65C7317F174
	static void _0xBCE595371A5FBAAF(Any p0, BOOL p1) { invoke<Void>(0xBCE595371A5FBAAF, p0, p1); } // 0xBCE595371A5FBAAF
	static void _0xC485E07E4F0B7958(Hash doorHash, BOOL p1, BOOL p2, BOOL p3) { invoke<Void>(0xC485E07E4F0B7958, doorHash, p1, p2, p3); } // 0xC485E07E4F0B7958
	static void _0xC6033D32241F6FB5(Any p0, BOOL p1) { invoke<Void>(0xC6033D32241F6FB5, p0, p1); } // 0xC6033D32241F6FB5
	static void _0xC7F29CA00F46350E(BOOL p0) { invoke<Void>(0xC7F29CA00F46350E, p0); } // 0xC7F29CA00F46350E
	static Any _0xD76EEEF746057FD6(Any p0) { return invoke<Any>(0xD76EEEF746057FD6, p0); } // 0xD76EEEF746057FD6
	static void _0xD9B71952F78A2640(Hash doorHash, BOOL p1) { invoke<Void>(0xD9B71952F78A2640, doorHash, p1); } // 0xD9B71952F78A2640
	static void _0xDA05194260CDCDF9(Any p0, Any p1) { invoke<Void>(0xDA05194260CDCDF9, p0, p1); } // 0xDA05194260CDCDF9
	static Any _0xDB41D07A45A6D4B7(Any p0) { return invoke<Any>(0xDB41D07A45A6D4B7, p0); } // 0xDB41D07A45A6D4B7
	static void _0xDF6CA0330F2E737B(Any p0, Any p1) { invoke<Void>(0xDF6CA0330F2E737B, p0, p1); } // 0xDF6CA0330F2E737B
	static BOOL _0xDF97CDD4FC08FD34(Any p0) { return invoke<BOOL>(0xDF97CDD4FC08FD34, p0); } // 0xDF97CDD4FC08FD34
	static void _0xE7E4C198B0185900(Object p0, Any p1, BOOL p2) { invoke<Void>(0xE7E4C198B0185900, p0, p1, p2); } // 0xE7E4C198B0185900
	static Any _0xE84EB93729C5F36A(Any p0) { return invoke<Any>(0xE84EB93729C5F36A, p0); } // 0xE84EB93729C5F36A
	static void _0xEB6F1A9B5510A5D2(Any p0, BOOL p1) { invoke<Void>(0xEB6F1A9B5510A5D2, p0, p1); } // 0xEB6F1A9B5510A5D2
	static BOOL _0xF0EED5A6BC7B237A(Any p0, Entity entity, int p2) { return invoke<BOOL>(0xF0EED5A6BC7B237A, p0, entity, p2); } // 0xF0EED5A6BC7B237A
	static Any _0xF12E33034D887F66(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return invoke<Any>(0xF12E33034D887F66, p0, p1, p2, p3, p4, p5); } // 0xF12E33034D887F66
	static void _0xF2E1A7133DD356A6(Hash hash, BOOL toggle) { invoke<Void>(0xF2E1A7133DD356A6, hash, toggle); } // 0xF2E1A7133DD356A6
	static void _0xF92099527DB8E2A7(Any p0, Any p1) { invoke<Void>(0xF92099527DB8E2A7, p0, p1); } // 0xF92099527DB8E2A7
	static void _0xF9C1681347C8BD15(Object object) { invoke<Void>(0xF9C1681347C8BD15, object); } // 0xF9C1681347C8BD15
	static BOOL PLACE_OBJECT_ON_GROUND_PROPERLY(Object object) { return invoke<BOOL>(0x58A850EAEE20FAA3, object); } // 0x58A850EAEE20FAA3
	static void REMOVE_ALL_PICKUPS_OF_TYPE(Hash pickupHash) { invoke<Void>(0x27F9D613092159CF, pickupHash); } // 0x27F9D613092159CF
	static void REMOVE_DOOR_FROM_SYSTEM(Hash doorHash) { invoke<Void>(0x464D8E1427156FE4, doorHash); } // 0x464D8E1427156FE4
	static void REMOVE_PICKUP(Pickup pickup) { invoke<Void>(0x3288D8ACAECD2AB2, pickup); } // 0x3288D8ACAECD2AB2
	static void SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN(Object object, BOOL toggle) { invoke<Void>(0x406137F8EF90EAF5, object, toggle); } // 0x406137F8EF90EAF5
	static void _SET_DES_OBJECT_STATE(int handle, int state) { invoke<Void>(0x5C29F698D404C5E1, handle, state); } // 0x5C29F698D404C5E1
	static void _SET_DOOR_ACCELERATION_LIMIT(Hash doorHash, int limit, BOOL p2, BOOL p3) { invoke<Void>(0x6BAB9442830C7F53, doorHash, limit, p2, p3); } // 0x6BAB9442830C7F53
	static void _SET_DOOR_AJAR_ANGLE(Hash doorHash, float ajar, BOOL p2, BOOL p3) { invoke<Void>(0xB6E6FBA95C7324AC, doorHash, ajar, p2, p3); } // 0xB6E6FBA95C7324AC
	static void SET_FORCE_OBJECT_THIS_FRAME(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xF538081986E49E9D, p0, p1, p2, p3); } // 0xF538081986E49E9D
	static void _SET_OBJECT_COLOUR(Entity entity, Any p1, int R, int G, int B) { invoke<Void>(0x3B2FD68DB5F8331C, entity, p1, R, G, B); } // 0x3B2FD68DB5F8331C
	static void SET_OBJECT_PHYSICS_PARAMS(Object object, float weight, float p2, float p3, float p4, float p5, float gravity, float p7, float p8, float p9, float p10, float buoyancy) { invoke<Void>(0xF6DF6E90DE7DF90F, object, weight, p2, p3, p4, p5, gravity, p7, p8, p9, p10, buoyancy); } // 0xF6DF6E90DE7DF90F
	static void _SET_OBJECT_SOMETHING(Object object, BOOL p1) { invoke<Void>(0x77F33F2CCF64B3AA, object, p1); } // 0x77F33F2CCF64B3AA
	static Any SET_OBJECT_TARGETTABLE(Object object, BOOL targettable) { return invoke<Any>(0x8A7391690F5AFD81, object, targettable); } // 0x8A7391690F5AFD81
	static void _SET_OBJECT_TEXTURE_VARIANT(Object object, int paintIndex) { invoke<Void>(0x971DA0055324D033, object, paintIndex); } // 0x971DA0055324D033
	static void SET_PICKUP_REGENERATION_TIME(Pickup pickup, int duration) { invoke<Void>(0x78015C9B4B3ECC9D, pickup, duration); } // 0x78015C9B4B3ECC9D
	static void SET_STATE_OF_CLOSEST_DOOR_OF_TYPE(Hash type, float x, float y, float z, BOOL locked, float heading, BOOL p6) { invoke<Void>(0xF82D8F1926A02C3D, type, x, y, z, locked, heading, p6); } // 0xF82D8F1926A02C3D
	static void SET_TEAM_PICKUP_OBJECT(Object object, Any p1, BOOL p2) { invoke<Void>(0x53E0DF1A2A3CF0CA, object, p1, p2); } // 0x53E0DF1A2A3CF0CA
	static BOOL SLIDE_OBJECT(Object object, float toX, float toY, float toZ, float speedX, float speedY, float speedZ, BOOL collision) { return invoke<BOOL>(0x2FDFF4107B8C1147, object, toX, toY, toZ, speedX, speedY, speedZ, collision); } // 0x2FDFF4107B8C1147
	static void TRACK_OBJECT_VISIBILITY(Any p0) { invoke<Void>(0xB252BC036B525623, p0); } // 0xB252BC036B525623
}

namespace PAD
{
	static void DISABLE_ALL_CONTROL_ACTIONS(int inputGroup) { invoke<Void>(0x5F4B6931816E599B, inputGroup); } // 0x5F4B6931816E599B
	static void DISABLE_CONTROL_ACTION(int inputGroup, int control, BOOL disable) { invoke<Void>(0xFE99B66D079CF6BC, inputGroup, control, disable); } // 0xFE99B66D079CF6BC
	static void _DISABLE_INPUT_GROUP(int inputGroup) { invoke<Void>(0x7F4724035FDCA1DD, inputGroup); } // 0x7F4724035FDCA1DD
	static void ENABLE_ALL_CONTROL_ACTIONS(int inputGroup) { invoke<Void>(0xA5FFE9B05F199DE7, inputGroup); } // 0xA5FFE9B05F199DE7
	static void ENABLE_CONTROL_ACTION(int inputGroup, int control, BOOL enable) { invoke<Void>(0x351220255D64C155, inputGroup, control, enable); } // 0x351220255D64C155
	static char* GET_CONTROL_INSTRUCTIONAL_BUTTON(int inputGroup, int control, Player p2) { return invoke<char*>(0x499D7B09FC9B407, inputGroup, control, p2); } // 0x499D7B09FC9B407
	static float GET_CONTROL_NORMAL(int inputGroup, int control) { return invoke<float>(0xEC3C9B8D5327B563, inputGroup, control); } // 0xEC3C9B8D5327B563
	static int GET_CONTROL_VALUE(int inputGroup, int control) { return invoke<int>(0xD95E79E8686D2C27, inputGroup, control); } // 0xD95E79E8686D2C27
	static float GET_DISABLED_CONTROL_NORMAL(int inputGroup, int control) { return invoke<float>(0x11E65974A982637C, inputGroup, control); } // 0x11E65974A982637C
	static int GET_LOCAL_PLAYER_AIM_STATE() { return invoke<int>(0xBB41AFBBBC0A0287); } // 0xBB41AFBBBC0A0287
	static BOOL IS_CONTROL_ENABLED(int inputGroup, int control) { return invoke<BOOL>(0x1CEA6BFDF248E5D9, inputGroup, control); } // 0x1CEA6BFDF248E5D9
	static BOOL IS_CONTROL_JUST_PRESSED(int inputGroup, int control) { return invoke<BOOL>(0x580417101DDB492F, inputGroup, control); } // 0x580417101DDB492F
	static BOOL IS_CONTROL_JUST_RELEASED(int inputGroup, int control) { return invoke<BOOL>(0x50F940259D3841E6, inputGroup, control); } // 0x50F940259D3841E6
	static BOOL IS_CONTROL_PRESSED(int inputGroup, int control) { return invoke<BOOL>(0xF3A21BCD95725A4A, inputGroup, control); } // 0xF3A21BCD95725A4A
	static BOOL IS_CONTROL_RELEASED(int inputGroup, int control) { return invoke<BOOL>(0x648EE3E7F38877DD, inputGroup, control); } // 0x648EE3E7F38877DD
	static BOOL IS_DISABLED_CONTROL_JUST_PRESSED(int inputGroup, int control) { return invoke<BOOL>(0x91AEF906BCA88877, inputGroup, control); } // 0x91AEF906BCA88877
	static BOOL IS_DISABLED_CONTROL_JUST_RELEASED(int inputGroup, int control) { return invoke<BOOL>(0x305C8DCD79DA8B0F, inputGroup, control); } // 0x305C8DCD79DA8B0F
	static BOOL IS_DISABLED_CONTROL_PRESSED(int inputGroup, int control) { return invoke<BOOL>(0xE2587F8CBBD87B1D, inputGroup, control); } // 0xE2587F8CBBD87B1D
	static BOOL _IS_INPUT_DISABLED(int inputGroup) { return invoke<BOOL>(0xA571D46727E2B718, inputGroup); } // 0xA571D46727E2B718
	static BOOL _IS_INPUT_JUST_DISABLED(int inputGroup) { return invoke<BOOL>(0x13337B38DB572509, inputGroup); } // 0x13337B38DB572509
	static BOOL IS_LOOK_INVERTED() { return invoke<BOOL>(0x77B612531280010D); } // 0x77B612531280010D
	static BOOL _0x0F70731BACCFBB96() { return invoke<BOOL>(0xF70731BACCFBB96); } // 0xF70731BACCFBB96
	static void _0x14D29BB12D47F68C(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x14D29BB12D47F68C, p0, p1, p2, p3, p4); } // 0x14D29BB12D47F68C
	static BOOL _0x23F09EADC01449D6(BOOL p0) { return invoke<BOOL>(0x23F09EADC01449D6, p0); } // 0x23F09EADC01449D6
	static BOOL _0x3D42B92563939375(char* p0) { return invoke<BOOL>(0x3D42B92563939375, p0); } // 0x3D42B92563939375
	static BOOL _0x4683149ED1DDE7A1(char* p0) { return invoke<BOOL>(0x4683149ED1DDE7A1, p0); } // 0x4683149ED1DDE7A1
	static float _0x4F8A26A890FD62FB(int inputGroup, int control) { return invoke<float>(0x4F8A26A890FD62FB, inputGroup, control); } // 0x4F8A26A890FD62FB
	static Any _0x59B9A7AF4C95133C() { return invoke<Any>(0x59B9A7AF4C95133C); } // 0x59B9A7AF4C95133C
	static void _0x5B73C77D9EB66E24(BOOL p0) { invoke<Void>(0x5B73C77D9EB66E24, p0); } // 0x5B73C77D9EB66E24
	static float _0x5B84D09CEC5209C5(int inputGroup, int control) { return invoke<float>(0x5B84D09CEC5209C5, inputGroup, control); } // 0x5B84D09CEC5209C5
	static void _0x643ED62D5EA3BEBD() { invoke<Void>(0x643ED62D5EA3BEBD); } // 0x643ED62D5EA3BEBD
	static BOOL _0x6CD79468A1E595C6(int inputGroup) { return invoke<BOOL>(0x6CD79468A1E595C6, inputGroup); } // 0x6CD79468A1E595C6
	static char* _0x80C2FD58D720C801(int inputGroup, int control, BOOL p2) { return invoke<char*>(0x80C2FD58D720C801, inputGroup, control, p2); } // 0x80C2FD58D720C801
	static void _0x8290252FFF36ACB5(int p0, int red, int green, int blue) { invoke<Void>(0x8290252FFF36ACB5, p0, red, green, blue); } // 0x8290252FFF36ACB5
	static void _0xA0CEFCEA390AAB9B(Any p0) { invoke<Void>(0xA0CEFCEA390AAB9B, p0); } // 0xA0CEFCEA390AAB9B
	static void _0xCB0360EFEFB2580D(Any p0) { invoke<Void>(0xCB0360EFEFB2580D, p0); } // 0xCB0360EFEFB2580D
	static int _0xD7D22F5592AED8BA(int p0) { return invoke<int>(0xD7D22F5592AED8BA, p0); } // 0xD7D22F5592AED8BA
	static BOOL _0xE1615EC03B3BB4FD() { return invoke<BOOL>(0xE1615EC03B3BB4FD); } // 0xE1615EC03B3BB4FD
	static void _0xF239400E16C23E08(Any p0, Any p1) { invoke<Void>(0xF239400E16C23E08, p0, p1); } // 0xF239400E16C23E08
	static Any _0xFB6C4072E9A32E92(Any p0, Any p1) { return invoke<Any>(0xFB6C4072E9A32E92, p0, p1); } // 0xFB6C4072E9A32E92
	static BOOL _0xFC859E2374407556() { return invoke<BOOL>(0xFC859E2374407556); } // 0xFC859E2374407556
	static BOOL _SET_CONTROL_NORMAL(int inputGroup, int control, float amount) { return invoke<BOOL>(0xE8A25867FBA3B05E, inputGroup, control, amount); } // 0xE8A25867FBA3B05E
	static BOOL _SET_CURSOR_LOCATION(float x, float y) { return invoke<BOOL>(0xFC695459D4D0E219, x, y); } // 0xFC695459D4D0E219
	static void SET_INPUT_EXCLUSIVE(int inputGroup, int control) { invoke<Void>(0xEDE476E5EE29EDB1, inputGroup, control); } // 0xEDE476E5EE29EDB1
	static void SET_PAD_SHAKE(int p0, int duration, int frequency) { invoke<Void>(0x48B3886C1358D0D5, p0, duration, frequency); } // 0x48B3886C1358D0D5
	static void SET_PLAYERPAD_SHAKES_WHEN_CONTROLLER_DISABLED(BOOL toggle) { invoke<Void>(0x798FDEB5B1575088, toggle); } // 0x798FDEB5B1575088
	static void STOP_PAD_SHAKE(Any p0) { invoke<Void>(0x38C16A305E8CDC8D, p0); } // 0x38C16A305E8CDC8D
}

namespace PATHFIND
{
	static Any ADD_NAVMESH_BLOCKING_OBJECT(float p0, float p1, float p2, float p3, float p4, float p5, float p6, BOOL p7, Any p8) { return invoke<Any>(0xFCD5C8E06E502F5A, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0xFCD5C8E06E502F5A
	static void ADD_NAVMESH_REQUIRED_REGION(float x, float y, float radius) { invoke<Void>(0x387EAD7EE42F6685, x, y, radius); } // 0x387EAD7EE42F6685
	static BOOL ARE_ALL_NAVMESH_REGIONS_LOADED() { return invoke<BOOL>(0x8415D95B194A3AEA); } // 0x8415D95B194A3AEA
	static float CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS(float x1, float y1, float z1, float x2, float y2, float z2) { return invoke<float>(0xADD95C7005C4A197, x1, y1, z1, x2, y2, z2); } // 0xADD95C7005C4A197
	static void DISABLE_NAVMESH_IN_AREA(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0x4C8872D8CDBE1B8B, p0, p1, p2, p3, p4, p5, p6); } // 0x4C8872D8CDBE1B8B
	static BOOL DOES_NAVMESH_BLOCKING_OBJECT_EXIST(Any p0) { return invoke<BOOL>(0xEAEB0DB4B132399, p0); } // 0xEAEB0DB4B132399
	static int GENERATE_DIRECTIONS_TO_COORD(float x, float y, float z, BOOL p3, int* direction, float* vehicle, float* distToNxJunction) { return invoke<int>(0xF90125F1F79ECDF8, x, y, z, p3, direction, vehicle, distToNxJunction); } // 0xF90125F1F79ECDF8
	static BOOL GET_CLOSEST_MAJOR_VEHICLE_NODE(float x, float y, float z, Vector3* outPosition, float unknown1, int unknown2) { return invoke<BOOL>(0x2EABE3B06F58C1BE, x, y, z, outPosition, unknown1, unknown2); } // 0x2EABE3B06F58C1BE
	static Any GET_CLOSEST_ROAD(float x, float y, float z, float p3, int p4, Vector3* p5, Vector3* p6, Any* p7, Any* p8, float* p9, BOOL p10) { return invoke<Any>(0x132F52BBA570FE92, x, y, z, p3, p4, p5, p6, p7, p8, p9, p10); } // 0x132F52BBA570FE92
	static BOOL GET_CLOSEST_VEHICLE_NODE(float x, float y, float z, Vector3* outPosition, int nodeType, float p5, float p6) { return invoke<BOOL>(0x240A18690AE96513, x, y, z, outPosition, nodeType, p5, p6); } // 0x240A18690AE96513
	static BOOL GET_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, Vector3* outPosition, float* outHeading, int nodeType, float p6, int p7) { return invoke<BOOL>(0xFF071FB798B803B0, x, y, z, outPosition, outHeading, nodeType, p6, p7); } // 0xFF071FB798B803B0
	static BOOL _GET_IS_SLOW_ROAD_FLAG(int nodeID) { return invoke<BOOL>(0x4F5070AA58F69279, nodeID); } // 0x4F5070AA58F69279
	static BOOL GET_NTH_CLOSEST_VEHICLE_NODE(float x, float y, float z, int nthClosest, Vector3* outPosition, Any unknown1, Any unknown2, Any unknown3) { return invoke<BOOL>(0xE50E52416CCF948B, x, y, z, nthClosest, outPosition, unknown1, unknown2, unknown3); } // 0xE50E52416CCF948B
	static BOOL GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION(float x, float y, float z, float desiredX, float desiredY, float desiredZ, int nthClosest, Vector3* outPosition, float* outHeading, int nodetype, Any p10, Any p11) { return invoke<BOOL>(0x45905BE8654AE067, x, y, z, desiredX, desiredY, desiredZ, nthClosest, outPosition, outHeading, nodetype, p10, p11); } // 0x45905BE8654AE067
	static int GET_NTH_CLOSEST_VEHICLE_NODE_ID(float x, float y, float z, int nth, int nodetype, float p5, float p6) { return invoke<int>(0x22D7275A79FE8215, x, y, z, nth, nodetype, p5, p6); } // 0x22D7275A79FE8215
	static Any GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING(float x, float y, float z, int nthClosest, Vector3* outPosition, float outHeading, Any p6, float p7, float p8) { return invoke<Any>(0x6448050E9C2A7207, x, y, z, nthClosest, outPosition, outHeading, p6, p7, p8); } // 0x6448050E9C2A7207
	static BOOL GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, int nthClosest, Vector3* outPosition, float* heading, Any* unknown1, int unknown2, float unknown3, float unknown4) { return invoke<BOOL>(0x80CA6A8B6C094CC4, x, y, z, nthClosest, outPosition, heading, unknown1, unknown2, unknown3, unknown4); } // 0x80CA6A8B6C094CC4
	static BOOL GET_RANDOM_VEHICLE_NODE(float x, float y, float z, float radius, BOOL p4, BOOL p5, BOOL p6, Vector3* outPosition, int* nodeId) { return invoke<BOOL>(0x93E0DB8440B73A7D, x, y, z, radius, p4, p5, p6, outPosition, nodeId); } // 0x93E0DB8440B73A7D
	static BOOL GET_SAFE_COORD_FOR_PED(float x, float y, float z, BOOL onGround, Vector3* outPosition, int flags) { return invoke<BOOL>(0xB61C8E878A4199CA, x, y, z, onGround, outPosition, flags); } // 0xB61C8E878A4199CA
	static void GET_STREET_NAME_AT_COORD(float x, float y, float z, Hash* streetName, Hash* crossingRoad) { invoke<Void>(0x2EB41072B4C1E4C0, x, y, z, streetName, crossingRoad); } // 0x2EB41072B4C1E4C0
	static BOOL _GET_SUPPORTS_GPS_ROUTE_FLAG(int nodeID) { return invoke<BOOL>(0xA2AE5C478B96E3B6, nodeID); } // 0xA2AE5C478B96E3B6
	static void GET_VEHICLE_NODE_POSITION(int nodeId, Vector3* outPosition) { invoke<Void>(0x703123E5E7D429C2, nodeId, outPosition); } // 0x703123E5E7D429C2
	static BOOL GET_VEHICLE_NODE_PROPERTIES(float x, float y, float z, int* density, int* flags) { return invoke<BOOL>(0x568566ACBB5DEDC, x, y, z, density, flags); } // 0x568566ACBB5DEDC
	static BOOL IS_NAVMESH_LOADED_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2) { return invoke<BOOL>(0xF813C7E63F9062A5, x1, y1, z1, x2, y2, z2); } // 0xF813C7E63F9062A5
	static BOOL IS_POINT_ON_ROAD(float x, float y, float z, Vehicle vehicle) { return invoke<BOOL>(0x125BF4ABFC536B09, x, y, z, vehicle); } // 0x125BF4ABFC536B09
	static BOOL IS_VEHICLE_NODE_ID_VALID(int vehicleNodeId) { return invoke<BOOL>(0x1EAF30FCFBF5AF74, vehicleNodeId); } // 0x1EAF30FCFBF5AF74
	static BOOL LOAD_ALL_PATH_NODES(BOOL keepInMemory) { return invoke<BOOL>(0x80E4A6EDDB0BE8D9, keepInMemory); } // 0x80E4A6EDDB0BE8D9
	static Any _0x01708E8DD3FF8C65(float p0, float p1, float p2, float p3, float p4, float p5) { return invoke<Any>(0x1708E8DD3FF8C65, p0, p1, p2, p3, p4, p5); } // 0x1708E8DD3FF8C65
	static BOOL _0x07FB139B592FA687(float p0, float p1, float p2, float p3) { return invoke<BOOL>(0x7FB139B592FA687, p0, p1, p2, p3); } // 0x7FB139B592FA687
	static void _0x0B919E1FB47CC4E0(float p0) { invoke<Void>(0xB919E1FB47CC4E0, p0); } // 0xB919E1FB47CC4E0
	static Any _0x16F46FB18C8009E4(Any p0, Any p1, Any p2, Any p3, Any p4) { return invoke<Any>(0x16F46FB18C8009E4, p0, p1, p2, p3, p4); } // 0x16F46FB18C8009E4
	static Any _0x1FC289A0C3FF470F(BOOL p0) { return invoke<Any>(0x1FC289A0C3FF470F, p0); } // 0x1FC289A0C3FF470F
	static void _0x228E5C6AD4D74BFD(BOOL p0) { invoke<Void>(0x228E5C6AD4D74BFD, p0); } // 0x228E5C6AD4D74BFD
	static void _0x2801D0012266DF07(Any p0) { invoke<Void>(0x2801D0012266DF07, p0); } // 0x2801D0012266DF07
	static float _0x29C24BFBED8AB8FB(float p0, float p1) { return invoke<float>(0x29C24BFBED8AB8FB, p0, p1); } // 0x29C24BFBED8AB8FB
	static float _0x336511A34F2E5185(float left, float right) { return invoke<float>(0x336511A34F2E5185, left, right); } // 0x336511A34F2E5185
	static float _0x3599D741C9AC6310(float p0, float p1, float p2, float p3) { return invoke<float>(0x3599D741C9AC6310, p0, p1, p2, p3); } // 0x3599D741C9AC6310
	static Any _0x705A844002B39DC0() { return invoke<Any>(0x705A844002B39DC0); } // 0x705A844002B39DC0
	static Any _0x869DAACBBE9FA006() { return invoke<Any>(0x869DAACBBE9FA006); } // 0x869DAACBBE9FA006
	static float _0x8ABE8608576D9CE3(float p0, float p1, float p2, float p3) { return invoke<float>(0x8ABE8608576D9CE3, p0, p1, p2, p3); } // 0x8ABE8608576D9CE3
	static Any _0xA0F8A7517A273C05(Any p0, Any p1, Any p2, Any p3, Any p4) { return invoke<Any>(0xA0F8A7517A273C05, p0, p1, p2, p3, p4); } // 0xA0F8A7517A273C05
	static void _0xAA76052DDA9BFC3E(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0xAA76052DDA9BFC3E, p0, p1, p2, p3, p4, p5, p6); } // 0xAA76052DDA9BFC3E
	static Any _0xBBB45C3CF5C8AA85() { return invoke<Any>(0xBBB45C3CF5C8AA85); } // 0xBBB45C3CF5C8AA85
	static void _0xD0BC1C6FB18EE154(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0xD0BC1C6FB18EE154, p0, p1, p2, p3, p4, p5, p6); } // 0xD0BC1C6FB18EE154
	static Any _0xD3A6A0EF48823A8C() { return invoke<Any>(0xD3A6A0EF48823A8C); } // 0xD3A6A0EF48823A8C
	static Any _0xF3162836C28F9DA5(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0xF3162836C28F9DA5, p0, p1, p2, p3); } // 0xF3162836C28F9DA5
	static BOOL _0xF7B79A50B905A30D(float p0, float p1, float p2, float p3) { return invoke<BOOL>(0xF7B79A50B905A30D, p0, p1, p2, p3); } // 0xF7B79A50B905A30D
	static void REMOVE_NAVMESH_BLOCKING_OBJECT(Any p0) { invoke<Void>(0x46399A7895957C0E, p0); } // 0x46399A7895957C0E
	static void REMOVE_NAVMESH_REQUIRED_REGIONS() { invoke<Void>(0x916F0A3CDEC3445E); } // 0x916F0A3CDEC3445E
	static void SET_GPS_DISABLED_ZONE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0xDC20483CD3DD5201, p0, p1, p2, p3, p4, p5); } // 0xDC20483CD3DD5201
	static void SET_IGNORE_NO_GPS_FLAG(BOOL ignore) { invoke<Void>(0x72751156E7678833, ignore); } // 0x72751156E7678833
	static void SET_PED_PATHS_BACK_TO_ORIGINAL(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0xE04B48F2CC926253, p0, p1, p2, p3, p4, p5); } // 0xE04B48F2CC926253
	static void SET_PED_PATHS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL unknown) { invoke<Void>(0x34F060F4BF92E018, x1, y1, z1, x2, y2, z2, unknown); } // 0x34F060F4BF92E018
	static void SET_ROADS_BACK_TO_ORIGINAL(float p0, float p1, float p2, float p3, float p4, float p5) { invoke<Void>(0x1EE7063B80FFC77C, p0, p1, p2, p3, p4, p5); } // 0x1EE7063B80FFC77C
	static void SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float p6) { invoke<Void>(0x27501B9F3B407E, x1, y1, z1, x2, y2, z2, p6); } // 0x27501B9F3B407E
	static void SET_ROADS_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float angle, BOOL unknown1, BOOL unknown2, BOOL unknown3) { invoke<Void>(0x1A5AA1208AF5DB59, x1, y1, z1, x2, y2, z2, angle, unknown1, unknown2, unknown3); } // 0x1A5AA1208AF5DB59
	static void SET_ROADS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL unknown1, BOOL unknown2) { invoke<Void>(0xBF1A602B5BA52FEE, x1, y1, z1, x2, y2, z2, unknown1, unknown2); } // 0xBF1A602B5BA52FEE
	static void UPDATE_NAVMESH_BLOCKING_OBJECT(Any p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, Any p8) { invoke<Void>(0x109E99373F290687, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0x109E99373F290687
}

namespace PED
{
	static void ADD_ARMOUR_TO_PED(Ped ped, int amount) { invoke<Void>(0x5BA652A0CD14DF2F, ped, amount); } // 0x5BA652A0CD14DF2F
	static Any ADD_RELATIONSHIP_GROUP(char* name, Hash* groupHash) { return invoke<Any>(0xF372BC22FCB88606, name, groupHash); } // 0xF372BC22FCB88606
	static int ADD_SCENARIO_BLOCKING_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL p6, BOOL p7, BOOL p8, BOOL p9) { return invoke<int>(0x1B5C85C612E5256E, x1, y1, z1, x2, y2, z2, p6, p7, p8, p9); } // 0x1B5C85C612E5256E
	static void APPLY_DAMAGE_TO_PED(Ped ped, int damageAmount, BOOL armorFirst) { invoke<Void>(0x697157CED63F18D4, ped, damageAmount, armorFirst); } // 0x697157CED63F18D4
	static void APPLY_PED_BLOOD(Ped ped, int boneIndex, float xRot, float yRot, float zRot, char* woundType) { invoke<Void>(0x83F7E01C7B769A26, ped, boneIndex, xRot, yRot, zRot, woundType); } // 0x83F7E01C7B769A26
	static void APPLY_PED_BLOOD_BY_ZONE(Ped ped, Any p1, float p2, float p3, Any* p4) { invoke<Void>(0x3311E47B91EDCBBC, ped, p1, p2, p3, p4); } // 0x3311E47B91EDCBBC
	static void APPLY_PED_BLOOD_DAMAGE_BY_ZONE(Ped ped, Any p1, float p2, float p3, Any p4) { invoke<Void>(0x816F6981C60BF53B, ped, p1, p2, p3, p4); } // 0x816F6981C60BF53B
	static void APPLY_PED_BLOOD_SPECIFIC(Ped ped, Any p1, float p2, float p3, float p4, float p5, Any p6, float p7, Any* p8) { invoke<Void>(0xEF0D582CBF2D9B0F, ped, p1, p2, p3, p4, p5, p6, p7, p8); } // 0xEF0D582CBF2D9B0F
	static void APPLY_PED_DAMAGE_DECAL(Ped ped, int p1, float p2, float p3, float p4, float p5, float p6, int p7, BOOL p8, char* p9) { invoke<Void>(0x397C38AA7B4A5F83, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9); } // 0x397C38AA7B4A5F83
	static void APPLY_PED_DAMAGE_PACK(Ped ped, char* damagePack, float damage, float mult) { invoke<Void>(0x46DF918788CB093F, ped, damagePack, damage, mult); } // 0x46DF918788CB093F
	static void ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY(int sceneID, Entity entity, int boneIndex) { invoke<Void>(0x272E4723B56A3B96, sceneID, entity, boneIndex); } // 0x272E4723B56A3B96
	static BOOL CAN_CREATE_RANDOM_BIKE_RIDER() { return invoke<BOOL>(0xEACEEDA81751915C); } // 0xEACEEDA81751915C
	static BOOL CAN_CREATE_RANDOM_COPS() { return invoke<BOOL>(0x5EE2CAFF7F17770D); } // 0x5EE2CAFF7F17770D
	static BOOL CAN_CREATE_RANDOM_DRIVER() { return invoke<BOOL>(0xB8EB95E5B4E56978); } // 0xB8EB95E5B4E56978
	static BOOL CAN_CREATE_RANDOM_PED(BOOL unk) { return invoke<BOOL>(0x3E8349C08E4B82E4, unk); } // 0x3E8349C08E4B82E4
	static BOOL CAN_KNOCK_PED_OFF_VEHICLE(Ped ped) { return invoke<BOOL>(0x51AC07A44D4F5B8A, ped); } // 0x51AC07A44D4F5B8A
	static BOOL CAN_PED_IN_COMBAT_SEE_TARGET(Ped ped, Ped target) { return invoke<BOOL>(0xEAD42DE3610D0721, ped, target); } // 0xEAD42DE3610D0721
	static BOOL CAN_PED_RAGDOLL(Ped ped) { return invoke<BOOL>(0x128F79EDCECE4FD5, ped); } // 0x128F79EDCECE4FD5
	static BOOL _CAN_PED_SEE_PED(Ped ped1, Ped ped2) { return invoke<BOOL>(0x6CD5A433374D4CFB, ped1, ped2); } // 0x6CD5A433374D4CFB
	static void CLEAR_ALL_PED_PROPS(Ped ped) { invoke<Void>(0xCD8A7537A9B52F06, ped); } // 0xCD8A7537A9B52F06
	static void CLEAR_FACIAL_IDLE_ANIM_OVERRIDE(Ped ped) { invoke<Void>(0x726256CC1EEB182F, ped); } // 0x726256CC1EEB182F
	static void CLEAR_PED_ALTERNATE_MOVEMENT_ANIM(Ped ped, int stance, float p2) { invoke<Void>(0xD8D19675ED5FBDCE, ped, stance, p2); } // 0xD8D19675ED5FBDCE
	static void CLEAR_PED_ALTERNATE_WALK_ANIM(Ped ped, float p1) { invoke<Void>(0x8844BBFCE30AA9E9, ped, p1); } // 0x8844BBFCE30AA9E9
	static void CLEAR_PED_BLOOD_DAMAGE(Ped ped) { invoke<Void>(0x8FE22675A5A45817, ped); } // 0x8FE22675A5A45817
	static void CLEAR_PED_BLOOD_DAMAGE_BY_ZONE(Ped ped, int p1) { invoke<Void>(0x56E3B78C5408D9F4, ped, p1); } // 0x56E3B78C5408D9F4
	static void CLEAR_PED_DAMAGE_DECAL_BY_ZONE(Ped ped, int p1, char* p2) { invoke<Void>(0x523C79AEEFCC4A2A, ped, p1, p2); } // 0x523C79AEEFCC4A2A
	static void CLEAR_PED_DECORATIONS(Ped ped) { invoke<Void>(0xE5173C163976E38, ped); } // 0xE5173C163976E38
	static void CLEAR_PED_DRIVE_BY_CLIPSET_OVERRIDE(Ped ped) { invoke<Void>(0x4AFE3690D7E0B5AC, ped); } // 0x4AFE3690D7E0B5AC
	static void _CLEAR_PED_FACIAL_DECORATIONS(Ped ped) { invoke<Void>(0xE3B27E70CEAB9F0C, ped); } // 0xE3B27E70CEAB9F0C
	static void CLEAR_PED_LAST_DAMAGE_BONE(Ped ped) { invoke<Void>(0x8EF6B7AC68E2F01B, ped); } // 0x8EF6B7AC68E2F01B
	static void CLEAR_PED_NON_CREATION_AREA() { invoke<Void>(0x2E05208086BA0651); } // 0x2E05208086BA0651
	static void CLEAR_PED_PROP(Ped ped, int propId) { invoke<Void>(0x943E5B8E078E76E, ped, propId); } // 0x943E5B8E078E76E
	static void CLEAR_PED_SCUBA_GEAR_VARIATION(Ped ped) { invoke<Void>(0xB50EB4CCB29704AC, ped); } // 0xB50EB4CCB29704AC
	static void CLEAR_PED_WETNESS(Ped ped) { invoke<Void>(0x9C720776DAA43E7E, ped); } // 0x9C720776DAA43E7E
	static void CLEAR_RELATIONSHIP_BETWEEN_GROUPS(int relationship, Hash group1, Hash group2) { invoke<Void>(0x5E29243FB56FC6D4, relationship, group1, group2); } // 0x5E29243FB56FC6D4
	static Ped CLONE_PED(Ped ped, float heading, BOOL isNetwork, BOOL thisScriptCheck) { return invoke<Ped>(0xEF29A16337FACADB, ped, heading, isNetwork, thisScriptCheck); } // 0xEF29A16337FACADB
	static void CLONE_PED_TO_TARGET(Ped ped, Ped targetPed) { invoke<Void>(0xE952D6431689AD9A, ped, targetPed); } // 0xE952D6431689AD9A
	static int CREATE_GROUP(int unused) { return invoke<int>(0x90370EBE0FEE1A3D, unused); } // 0x90370EBE0FEE1A3D
	static void CREATE_NM_MESSAGE(BOOL startImmediately, int messageId) { invoke<Void>(0x418EF2A1BCE56685, startImmediately, messageId); } // 0x418EF2A1BCE56685
	static Ped CREATE_PED(int pedType, Hash modelHash, float x, float y, float z, float heading, BOOL isNetwork, BOOL thisScriptCheck) { return invoke<Ped>(0xD49F9B0955C367DE, pedType, modelHash, x, y, z, heading, isNetwork, thisScriptCheck); } // 0xD49F9B0955C367DE
	static Ped CREATE_PED_INSIDE_VEHICLE(Vehicle vehicle, int pedType, Hash modelHash, int seat, BOOL isNetwork, BOOL thisScriptCheck) { return invoke<Ped>(0x7DD959874C1FD534, vehicle, pedType, modelHash, seat, isNetwork, thisScriptCheck); } // 0x7DD959874C1FD534
	static Ped CREATE_RANDOM_PED(float posX, float posY, float posZ) { return invoke<Ped>(0xB4AC7D0CF06BFE8F, posX, posY, posZ); } // 0xB4AC7D0CF06BFE8F
	static Ped CREATE_RANDOM_PED_AS_DRIVER(Vehicle vehicle, BOOL returnHandle) { return invoke<Ped>(0x9B62392B474F44A0, vehicle, returnHandle); } // 0x9B62392B474F44A0
	static int CREATE_SYNCHRONIZED_SCENE(float x, float y, float z, float roll, float pitch, float yaw, int p6) { return invoke<int>(0x8C18E0F9080ADD73, x, y, z, roll, pitch, yaw, p6); } // 0x8C18E0F9080ADD73
	static int _CREATE_SYNCHRONIZED_SCENE_2(float x, float y, float z, float radius, Hash object) { return invoke<int>(0x62EC273D00187DCA, x, y, z, radius, object); } // 0x62EC273D00187DCA
	static void DELETE_PED(Ped* ped) { invoke<Void>(0x9614299DCB53E54B, ped); } // 0x9614299DCB53E54B
	static void DETACH_SYNCHRONIZED_SCENE(int sceneID) { invoke<Void>(0x6D38F1F04CBB37EA, sceneID); } // 0x6D38F1F04CBB37EA
	static void _DISPOSE_SYNCHRONIZED_SCENE(int scene) { invoke<Void>(0xCD9CC7E200A52A6F, scene); } // 0xCD9CC7E200A52A6F
	static BOOL DOES_GROUP_EXIST(int groupId) { return invoke<BOOL>(0x7C6B0C22F9F40BBE, groupId); } // 0x7C6B0C22F9F40BBE
	static void EXPLODE_PED_HEAD(Ped ped, Hash weaponHash) { invoke<Void>(0x2D05CED3A38D0F3A, ped, weaponHash); } // 0x2D05CED3A38D0F3A
	static BOOL FORCE_PED_MOTION_STATE(Ped ped, Hash motionStateHash, BOOL p2, BOOL p3, BOOL p4) { return invoke<BOOL>(0xF28965D04F570DCA, ped, motionStateHash, p2, p3, p4); } // 0xF28965D04F570DCA
	static void FORCE_PED_TO_OPEN_PARACHUTE(Ped ped) { invoke<Void>(0x16E42E800B472221, ped); } // 0x16E42E800B472221
	static void _FREEZE_PED_CAMERA_ROTATION(Ped ped) { invoke<Void>(0xFF287323B0E2C69A, ped); } // 0xFF287323B0E2C69A
	static Vector3 GET_ANIM_INITIAL_OFFSET_POSITION(char* animDict, char* animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9) { return invoke<Vector3>(0xBE22B26DD764C040, animDict, animName, x, y, z, xRot, yRot, zRot, p8, p9); } // 0xBE22B26DD764C040
	static Vector3 GET_ANIM_INITIAL_OFFSET_ROTATION(char* animDict, char* animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9) { return invoke<Vector3>(0x4B805E6046EE9E47, animDict, animName, x, y, z, xRot, yRot, zRot, p8, p9); } // 0x4B805E6046EE9E47
	static BOOL GET_CLOSEST_PED(float x, float y, float z, float radius, BOOL p4, BOOL p5, Ped* outPed, BOOL p7, BOOL p8, int pedType) { return invoke<BOOL>(0xC33AB876A77F8164, x, y, z, radius, p4, p5, outPed, p7, p8, pedType); } // 0xC33AB876A77F8164
	static float GET_COMBAT_FLOAT(Ped ped, int p1) { return invoke<float>(0x52DFF8A10508090A, ped, p1); } // 0x52DFF8A10508090A
	static Vector3 GET_DEAD_PED_PICKUP_COORDS(Ped ped, float p1, float p2) { return invoke<Vector3>(0xCD5003B097200F36, ped, p1, p2); } // 0xCD5003B097200F36
	static int _GET_FIRST_PARENT_ID_FOR_PED_TYPE(int type) { return invoke<int>(0x68D353AB88B97E0C, type); } // 0x68D353AB88B97E0C
	static void GET_GROUP_SIZE(int groupID, Any* unknown, int* sizeInMembers) { invoke<Void>(0x8DE69FE35CA09A45, groupID, unknown, sizeInMembers); } // 0x8DE69FE35CA09A45
	static void _GET_HAIR_RGB_COLOR(int hairColorIndex, int* outR, int* outG, int* outB) { invoke<Void>(0x4852FC386E2E1BB5, hairColorIndex, outR, outG, outB); } // 0x4852FC386E2E1BB5
	static Ped GET_JACK_TARGET(Ped ped) { return invoke<Ped>(0x5486A79D9FBD342D, ped); } // 0x5486A79D9FBD342D
	static void _GET_MAKEUP_RGB_COLOR(int makeupColorIndex, int* outR, int* outG, int* outB) { invoke<Void>(0x13E5CFC38CD5387, makeupColorIndex, outR, outG, outB); } // 0x13E5CFC38CD5387
	static Ped GET_MELEE_TARGET_FOR_PED(Ped ped) { return invoke<Ped>(0x18A3E9EE1297FD39, ped); } // 0x18A3E9EE1297FD39
	static Ped GET_MOUNT(Ped ped) { return invoke<Ped>(0xE7E11B8DCBED1058, ped); } // 0xE7E11B8DCBED1058
	static int GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS(Ped ped, int componentId) { return invoke<int>(0x27561561732A7842, ped, componentId); } // 0x27561561732A7842
	static int GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS(Ped ped, int propId) { return invoke<int>(0x5FAF9754E789FB47, ped, propId); } // 0x5FAF9754E789FB47
	static int GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS(Ped ped, int propId, int drawableId) { return invoke<int>(0xA6E7F1CEB523E171, ped, propId, drawableId); } // 0xA6E7F1CEB523E171
	static int GET_NUMBER_OF_PED_TEXTURE_VARIATIONS(Ped ped, int componentId, int drawableId) { return invoke<int>(0x8F7156A3142A6BAD, ped, componentId, drawableId); } // 0x8F7156A3142A6BAD
	static int _GET_NUM_HAIR_COLORS() { return invoke<int>(0xE5C0CF872C2AD150); } // 0xE5C0CF872C2AD150
	static int _GET_NUM_HEAD_OVERLAY_VALUES(int overlayID) { return invoke<int>(0xCF1CE768BB43480E, overlayID); } // 0xCF1CE768BB43480E
	static int _GET_NUM_MAKEUP_COLORS() { return invoke<int>(0xD1F7CA1535D22818); } // 0xD1F7CA1535D22818
	static int _GET_NUM_PARENT_PEDS_OF_TYPE(int type) { return invoke<int>(0x5EF37013A6539C9D, type); } // 0x5EF37013A6539C9D
	static int GET_PED_ACCURACY(Ped ped) { return invoke<int>(0x37F4AD56ECBC0CD6, ped); } // 0x37F4AD56ECBC0CD6
	static int GET_PED_ALERTNESS(Ped ped) { return invoke<int>(0xF6AA118530443FD2, ped); } // 0xF6AA118530443FD2
	static int GET_PED_ARMOUR(Ped ped) { return invoke<int>(0x9483AF821605B1D8, ped); } // 0x9483AF821605B1D8
	static Ped _GET_PED_AS_GROUP_LEADER(int groupID) { return invoke<Ped>(0x5CCE68DBD5FE93EC, groupID); } // 0x5CCE68DBD5FE93EC
	static Ped GET_PED_AS_GROUP_MEMBER(int groupID, int memberNumber) { return invoke<Ped>(0x51455483CF23ED97, groupID, memberNumber); } // 0x51455483CF23ED97
	static Vector3 GET_PED_BONE_COORDS(Ped ped, int boneId, float offsetX, float offsetY, float offsetZ) { return invoke<Vector3>(0x17C07FC640E86B4E, ped, boneId, offsetX, offsetY, offsetZ); } // 0x17C07FC640E86B4E
	static int GET_PED_BONE_INDEX(Ped ped, int boneId) { return invoke<int>(0x3F428D08BE5AAE31, ped, boneId); } // 0x3F428D08BE5AAE31
	static Hash GET_PED_CAUSE_OF_DEATH(Ped ped) { return invoke<Hash>(0x16FFE42AB2D2DC59, ped); } // 0x16FFE42AB2D2DC59
	static int GET_PED_COMBAT_MOVEMENT(Ped ped) { return invoke<int>(0xDEA92412FCAEB3F5, ped); } // 0xDEA92412FCAEB3F5
	static Any GET_PED_COMBAT_RANGE(Ped ped) { return invoke<Any>(0xF9D9F7F2DB8E2FA0, ped); } // 0xF9D9F7F2DB8E2FA0
	static BOOL GET_PED_CONFIG_FLAG(Ped ped, int flagId, BOOL p2) { return invoke<BOOL>(0x7EE53118C892B513, ped, flagId, p2); } // 0x7EE53118C892B513
	static Any GET_PED_DECORATIONS_STATE(Ped ped) { return invoke<Any>(0x71EAB450D86954A1, ped); } // 0x71EAB450D86954A1
	static Vector3 GET_PED_DEFENSIVE_AREA_POSITION(Ped ped, BOOL p1) { return invoke<Vector3>(0x3C06B8786DD94CD1, ped, p1); } // 0x3C06B8786DD94CD1
	static int GET_PED_DRAWABLE_VARIATION(Ped ped, int componentId) { return invoke<int>(0x67F3780DD425D4FC, ped, componentId); } // 0x67F3780DD425D4FC
	static float GET_PED_ENVEFF_SCALE(Ped ped) { return invoke<float>(0x9C14D30395A51A3C, ped); } // 0x9C14D30395A51A3C
	static Vector3 GET_PED_EXTRACTED_DISPLACEMENT(Ped ped, BOOL worldSpace) { return invoke<Vector3>(0xE0AF41401ADF87E3, ped, worldSpace); } // 0xE0AF41401ADF87E3
	static void GET_PED_FLOOD_INVINCIBILITY(Ped ped, BOOL p1) { invoke<Void>(0x2BC338A7B21F4608, ped, p1); } // 0x2BC338A7B21F4608
	static int GET_PED_GROUP_INDEX(Ped ped) { return invoke<int>(0xF162E133B4E7A675, ped); } // 0xF162E133B4E7A675
	static BOOL _GET_PED_HEAD_BLEND_DATA(Ped ped, Any* headBlendData) { return invoke<BOOL>(0x2746BD9D88C5C5D0, ped, headBlendData); } // 0x2746BD9D88C5C5D0
	static int _GET_PED_HEAD_OVERLAY_VALUE(Ped ped, int overlayID) { return invoke<int>(0xA60EF3B6461A4D43, ped, overlayID); } // 0xA60EF3B6461A4D43
	static char* GET_PEDHEADSHOT_TXD_STRING(int handle) { return invoke<char*>(0xDB4EACD4AD0A5D6B, handle); } // 0xDB4EACD4AD0A5D6B
	static float _GET_PED_ILLUMINATED_CLOTHING_GLOW_INTENSITY(Ped ped) { return invoke<float>(0x1461B28A06717D68, ped); } // 0x1461B28A06717D68
	static BOOL GET_PED_LAST_DAMAGE_BONE(Ped ped, int* outBone) { return invoke<BOOL>(0xD75960F6BD9EA49C, ped, outBone); } // 0xD75960F6BD9EA49C
	static int GET_PED_MAX_HEALTH(Ped ped) { return invoke<int>(0x4700A416E8324EF3, ped); } // 0x4700A416E8324EF3
	static int GET_PED_MONEY(Ped ped) { return invoke<int>(0x3F69145BBA87BAE7, ped); } // 0x3F69145BBA87BAE7
	static int GET_PED_NEARBY_PEDS(Ped ped, int* sizeAndPeds, int ignore) { return invoke<int>(0x23F8F5FC7E8C4A6B, ped, sizeAndPeds, ignore); } // 0x23F8F5FC7E8C4A6B
	static int GET_PED_NEARBY_VEHICLES(Ped ped, int* sizeAndVehs) { return invoke<int>(0xCFF869CBFA210D82, ped, sizeAndVehs); } // 0xCFF869CBFA210D82
	static int GET_PED_PALETTE_VARIATION(Ped ped, int componentId) { return invoke<int>(0xE3DD5F2A84B42281, ped, componentId); } // 0xE3DD5F2A84B42281
	static int GET_PED_PARACHUTE_LANDING_TYPE(Ped ped) { return invoke<int>(0x8B9F1FC6AE8166C0, ped); } // 0x8B9F1FC6AE8166C0
	static int GET_PED_PARACHUTE_STATE(Ped ped) { return invoke<int>(0x79CFD9827CC979B6, ped); } // 0x79CFD9827CC979B6
	static void GET_PED_PARACHUTE_TINT_INDEX(Ped ped, int* outTintIndex) { invoke<Void>(0xEAF5F7E5AE7C6C9D, ped, outTintIndex); } // 0xEAF5F7E5AE7C6C9D
	static int GET_PED_PROP_INDEX(Ped ped, int componentId) { return invoke<int>(0x898CC20EA75BACD8, ped, componentId); } // 0x898CC20EA75BACD8
	static int GET_PED_PROP_TEXTURE_INDEX(Ped ped, int componentId) { return invoke<int>(0xE131A28626F81AB2, ped, componentId); } // 0xE131A28626F81AB2
	static int GET_PED_RAGDOLL_BONE_INDEX(Ped ped, int bone) { return invoke<int>(0x2057EF813397A772, ped, bone); } // 0x2057EF813397A772
	static Hash GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(Ped ped) { return invoke<Hash>(0x42FDD0F017B1E38E, ped); } // 0x42FDD0F017B1E38E
	static Hash GET_PED_RELATIONSHIP_GROUP_HASH(Ped ped) { return invoke<Hash>(0x7DBDD04862D95F04, ped); } // 0x7DBDD04862D95F04
	static BOOL GET_PED_RESET_FLAG(Ped ped, int flagId) { return invoke<BOOL>(0xAF9E59B1B1FBF2A0, ped, flagId); } // 0xAF9E59B1B1FBF2A0
	static Ped GET_PEDS_JACKER(Ped ped) { return invoke<Ped>(0x9B128DC36C1E04CF, ped); } // 0x9B128DC36C1E04CF
	static Entity GET_PED_SOURCE_OF_DEATH(Ped ped) { return invoke<Entity>(0x93C8B64DEB84728C, ped); } // 0x93C8B64DEB84728C
	static BOOL GET_PED_STEALTH_MOVEMENT(Ped ped) { return invoke<BOOL>(0x7C2AC9CA66575FBF, ped); } // 0x7C2AC9CA66575FBF
	static int GET_PED_TEXTURE_VARIATION(Ped ped, int componentId) { return invoke<int>(0x4A355E041E004E6, ped, componentId); } // 0x4A355E041E004E6
	static int GET_PED_TYPE(Ped ped) { return invoke<int>(0xFF059E1E4C01E63C, ped); } // 0xFF059E1E4C01E63C
	static Player GET_PLAYER_PED_IS_FOLLOWING(Ped ped) { return invoke<Player>(0x6A3975DEA89F9A17, ped); } // 0x6A3975DEA89F9A17
	static Ped GET_RANDOM_PED_AT_COORD(float x, float y, float z, float xRadius, float yRadius, float zRadius, int pedType) { return invoke<Ped>(0x876046A8E3A4B71C, x, y, z, xRadius, yRadius, zRadius, pedType); } // 0x876046A8E3A4B71C
	static int GET_RELATIONSHIP_BETWEEN_GROUPS(Hash group1, Hash group2) { return invoke<int>(0x9E6B70061662AE5C, group1, group2); } // 0x9E6B70061662AE5C
	static int GET_RELATIONSHIP_BETWEEN_PEDS(Ped ped1, Ped ped2) { return invoke<int>(0xEBA5AD3A0EAF7121, ped1, ped2); } // 0xEBA5AD3A0EAF7121
	static int GET_SEAT_PED_IS_TRYING_TO_ENTER(Ped ped) { return invoke<int>(0x6F4C85ACD641BCD2, ped); } // 0x6F4C85ACD641BCD2
	static float GET_SYNCHRONIZED_SCENE_PHASE(int sceneID) { return invoke<float>(0xE4A310B1D7FA73CC, sceneID); } // 0xE4A310B1D7FA73CC
	static float GET_SYNCHRONIZED_SCENE_RATE(int sceneID) { return invoke<float>(0xD80932D577274D40, sceneID); } // 0xD80932D577274D40
	static int _GET_TATTOO_ZONE(Hash collection, Hash overlay) { return invoke<int>(0x9FD452BFBE7A7A8B, collection, overlay); } // 0x9FD452BFBE7A7A8B
	static Vehicle GET_VEHICLE_PED_IS_IN(Ped ped, BOOL lastVehicle) { return invoke<Vehicle>(0x9A9112A0FE9A4713, ped, lastVehicle); } // 0x9A9112A0FE9A4713
	static Vehicle GET_VEHICLE_PED_IS_TRYING_TO_ENTER(Ped ped) { return invoke<Vehicle>(0x814FA8BE5449445D, ped); } // 0x814FA8BE5449445D
	static Vehicle GET_VEHICLE_PED_IS_USING(Ped ped) { return invoke<Vehicle>(0x6094AD011A2EA87D, ped); } // 0x6094AD011A2EA87D
	static void GIVE_PED_HELMET(Ped ped, BOOL cannotRemove, int helmetFlag, int textureIndex) { invoke<Void>(0x54C7C4A94367717E, ped, cannotRemove, helmetFlag, textureIndex); } // 0x54C7C4A94367717E
	static void GIVE_PED_NM_MESSAGE(Ped ped) { invoke<Void>(0xB158DFCCC56E5C5B, ped); } // 0xB158DFCCC56E5C5B
	static BOOL HAS_ACTION_MODE_ASSET_LOADED(char* asset) { return invoke<BOOL>(0xE4B5F4BF2CB24E65, asset); } // 0xE4B5F4BF2CB24E65
	static BOOL HAS_PED_HEAD_BLEND_FINISHED(Ped ped) { return invoke<BOOL>(0x654CD0A825161131, ped); } // 0x654CD0A825161131
	static BOOL HAS_PED_RECEIVED_EVENT(Ped ped, Any p1) { return invoke<BOOL>(0x8507BCB710FA6DC0, ped, p1); } // 0x8507BCB710FA6DC0
	static BOOL HAS_STEALTH_MODE_ASSET_LOADED(char* asset) { return invoke<BOOL>(0xE977FC5B08AF3441, asset); } // 0xE977FC5B08AF3441
	static void HIDE_PED_BLOOD_DAMAGE_BY_ZONE(Ped ped, Any p1, BOOL p2) { invoke<Void>(0x62AB793144DE75DC, ped, p1, p2); } // 0x62AB793144DE75DC
	static BOOL IS_ANY_PED_NEAR_POINT(float x, float y, float z, float radius) { return invoke<BOOL>(0x83961498679DC9F, x, y, z, radius); } // 0x83961498679DC9F
	static BOOL IS_ANY_PED_SHOOTING_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL p6, BOOL p7) { return invoke<BOOL>(0xA0D3D71EA1086C55, x1, y1, z1, x2, y2, z2, p6, p7); } // 0xA0D3D71EA1086C55
	static BOOL IS_CONVERSATION_PED_DEAD(Ped ped) { return invoke<BOOL>(0xE0A0AEC214B1FABA, ped); } // 0xE0A0AEC214B1FABA
	static BOOL IS_COP_PED_IN_AREA_3D(float x1, float y1, float z1, float x2, float y2, float z2) { return invoke<BOOL>(0x16EC4839969F9F5E, x1, y1, z1, x2, y2, z2); } // 0x16EC4839969F9F5E
	static BOOL IS_PED_AIMING_FROM_COVER(Ped ped) { return invoke<BOOL>(0x3998B1276A3300E5, ped); } // 0x3998B1276A3300E5
	static BOOL IS_PED_A_PLAYER(Ped ped) { return invoke<BOOL>(0x12534C348C6CB68B, ped); } // 0x12534C348C6CB68B
	static BOOL IS_PED_BEING_JACKED(Ped ped) { return invoke<BOOL>(0x9A497FE2DF198913, ped); } // 0x9A497FE2DF198913
	static BOOL IS_PED_BEING_STEALTH_KILLED(Ped ped) { return invoke<BOOL>(0x863B23EFDE9C5DF2, ped); } // 0x863B23EFDE9C5DF2
	static BOOL IS_PED_BEING_STUNNED(Ped ped, int p1) { return invoke<BOOL>(0x4FBACCE3B4138EE8, ped, p1); } // 0x4FBACCE3B4138EE8
	static BOOL _IS_PED_BLUSH_COLOR_VALID(int colorID) { return invoke<BOOL>(0x604E810189EE3A59, colorID); } // 0x604E810189EE3A59
	static BOOL IS_PED_CLIMBING(Ped ped) { return invoke<BOOL>(0x53E8CB4F48BFE623, ped); } // 0x53E8CB4F48BFE623
	static BOOL IS_PED_COMPONENT_VARIATION_VALID(Ped ped, int componentId, int drawableId, int textureId) { return invoke<BOOL>(0xE825F6B6CEA7671D, ped, componentId, drawableId, textureId); } // 0xE825F6B6CEA7671D
	static BOOL IS_PED_DEAD_OR_DYING(Ped ped, BOOL p1) { return invoke<BOOL>(0x3317DEDB88C95038, ped, p1); } // 0x3317DEDB88C95038
	static BOOL IS_PED_DIVING(Ped ped) { return invoke<BOOL>(0x5527B8246FEF9B11, ped); } // 0x5527B8246FEF9B11
	static BOOL IS_PED_DOING_DRIVEBY(Ped ped) { return invoke<BOOL>(0xB2C086CC1BF8F2BF, ped); } // 0xB2C086CC1BF8F2BF
	static BOOL IS_PED_DUCKING(Ped ped) { return invoke<BOOL>(0xD125AE748725C6BC, ped); } // 0xD125AE748725C6BC
	static BOOL IS_PED_EVASIVE_DIVING(Ped ped, Entity* evadingEntity) { return invoke<BOOL>(0x414641C26E105898, ped, evadingEntity); } // 0x414641C26E105898
	static BOOL IS_PED_FACING_PED(Ped ped, Ped otherPed, float angle) { return invoke<BOOL>(0xD71649DB0A545AA3, ped, otherPed, angle); } // 0xD71649DB0A545AA3
	static BOOL IS_PED_FALLING(Ped ped) { return invoke<BOOL>(0xFB92A102F1C4DFA3, ped); } // 0xFB92A102F1C4DFA3
	static BOOL IS_PED_FATALLY_INJURED(Ped ped) { return invoke<BOOL>(0xD839450756ED5A80, ped); } // 0xD839450756ED5A80
	static BOOL IS_PED_FLEEING(Ped ped) { return invoke<BOOL>(0xBBCCE00B381F8482, ped); } // 0xBBCCE00B381F8482
	static BOOL IS_PED_GETTING_INTO_A_VEHICLE(Ped ped) { return invoke<BOOL>(0xBB062B2B5722478E, ped); } // 0xBB062B2B5722478E
	static BOOL IS_PED_GOING_INTO_COVER(Ped ped) { return invoke<BOOL>(0x9F65DBC537E59AD5, ped); } // 0x9F65DBC537E59AD5
	static BOOL IS_PED_GROUP_MEMBER(Ped ped, int groupId) { return invoke<BOOL>(0x9BB01E3834671191, ped, groupId); } // 0x9BB01E3834671191
	static BOOL _IS_PED_HAIR_COLOR_VALID(int colorID) { return invoke<BOOL>(0xE0D36E5D9E99CC21, colorID); } // 0xE0D36E5D9E99CC21
	static BOOL IS_PED_HANGING_ON_TO_VEHICLE(Ped ped) { return invoke<BOOL>(0x1C86D8AEF8254B78, ped); } // 0x1C86D8AEF8254B78
	static BOOL IS_PEDHEADSHOT_READY(int handle) { return invoke<BOOL>(0x7085228842B13A67, handle); } // 0x7085228842B13A67
	static BOOL IS_PEDHEADSHOT_VALID(int handle) { return invoke<BOOL>(0xA0A9668F158129A2, handle); } // 0xA0A9668F158129A2
	static BOOL IS_PED_HEADTRACKING_ENTITY(Ped ped, Entity entity) { return invoke<BOOL>(0x813A0A7C9D2E831F, ped, entity); } // 0x813A0A7C9D2E831F
	static BOOL IS_PED_HEADTRACKING_PED(Ped ped1, Ped ped2) { return invoke<BOOL>(0x5CD3CB88A7F8850D, ped1, ped2); } // 0x5CD3CB88A7F8850D
	static BOOL IS_PED_HUMAN(Ped ped) { return invoke<BOOL>(0xB980061DA992779D, ped); } // 0xB980061DA992779D
	static BOOL IS_PED_HURT(Ped ped) { return invoke<BOOL>(0x5983BB449D7FDB12, ped); } // 0x5983BB449D7FDB12
	static BOOL IS_PED_IN_ANY_BOAT(Ped ped) { return invoke<BOOL>(0x2E0E1C2B4F6CB339, ped); } // 0x2E0E1C2B4F6CB339
	static BOOL IS_PED_IN_ANY_HELI(Ped ped) { return invoke<BOOL>(0x298B91AE825E5705, ped); } // 0x298B91AE825E5705
	static BOOL IS_PED_IN_ANY_PLANE(Ped ped) { return invoke<BOOL>(0x5FFF4CFC74D8FB80, ped); } // 0x5FFF4CFC74D8FB80
	static BOOL IS_PED_IN_ANY_POLICE_VEHICLE(Ped ped) { return invoke<BOOL>(0xBD04E29640C9C12, ped); } // 0xBD04E29640C9C12
	static BOOL IS_PED_IN_ANY_SUB(Ped ped) { return invoke<BOOL>(0xFBFC01CCFB35D99E, ped); } // 0xFBFC01CCFB35D99E
	static BOOL IS_PED_IN_ANY_TAXI(Ped ped) { return invoke<BOOL>(0x6E575D6A898AB852, ped); } // 0x6E575D6A898AB852
	static BOOL IS_PED_IN_ANY_TRAIN(Ped ped) { return invoke<BOOL>(0x6F972C1AB75A1ED0, ped); } // 0x6F972C1AB75A1ED0
	static BOOL IS_PED_IN_ANY_VEHICLE(Ped ped, BOOL atGetIn) { return invoke<BOOL>(0x997ABD671D25CA0B, ped, atGetIn); } // 0x997ABD671D25CA0B
	static BOOL IS_PED_IN_COMBAT(Ped ped, Ped target) { return invoke<BOOL>(0x4859F1FC66A6278E, ped, target); } // 0x4859F1FC66A6278E
	static BOOL IS_PED_IN_COVER(Ped ped, BOOL exceptUseWeapon) { return invoke<BOOL>(0x60DFD0691A170B88, ped, exceptUseWeapon); } // 0x60DFD0691A170B88
	static BOOL IS_PED_IN_COVER_FACING_LEFT(Ped ped) { return invoke<BOOL>(0x845333B3150583AB, ped); } // 0x845333B3150583AB
	static BOOL IS_PED_IN_FLYING_VEHICLE(Ped ped) { return invoke<BOOL>(0x9134873537FA419C, ped); } // 0x9134873537FA419C
	static BOOL IS_PED_IN_GROUP(Ped ped) { return invoke<BOOL>(0x5891CAC5D4ACFF74, ped); } // 0x5891CAC5D4ACFF74
	static BOOL IS_PED_INJURED(Ped ped) { return invoke<BOOL>(0x84A2DD9AC37C35C1, ped); } // 0x84A2DD9AC37C35C1
	static BOOL IS_PED_IN_MELEE_COMBAT(Ped ped) { return invoke<BOOL>(0x4E209B2C1EAD5159, ped); } // 0x4E209B2C1EAD5159
	static BOOL IS_PED_IN_MODEL(Ped ped, Hash modelHash) { return invoke<BOOL>(0x796D90EFB19AA332, ped, modelHash); } // 0x796D90EFB19AA332
	static BOOL IS_PED_IN_PARACHUTE_FREE_FALL(Ped ped) { return invoke<BOOL>(0x7DCE8BDA0F1C1200, ped); } // 0x7DCE8BDA0F1C1200
	static BOOL IS_PED_IN_VEHICLE(Ped ped, Vehicle vehicle, BOOL atGetIn) { return invoke<BOOL>(0xA3EE4A07279BB9DB, ped, vehicle, atGetIn); } // 0xA3EE4A07279BB9DB
	static BOOL IS_PED_JACKING(Ped ped) { return invoke<BOOL>(0x4AE4FF911DFB61DA, ped); } // 0x4AE4FF911DFB61DA
	static BOOL IS_PED_JUMPING(Ped ped) { return invoke<BOOL>(0xCEDABC5900A0BF97, ped); } // 0xCEDABC5900A0BF97
	static BOOL IS_PED_JUMPING_OUT_OF_VEHICLE(Ped ped) { return invoke<BOOL>(0x433DDFFE2044B636, ped); } // 0x433DDFFE2044B636
	static BOOL _IS_PED_LIPSTICK_COLOR_VALID(int colorID) { return invoke<BOOL>(0x525A2C2562F3CD4, colorID); } // 0x525A2C2562F3CD4
	static BOOL IS_PED_MALE(Ped ped) { return invoke<BOOL>(0x6D9F5FAA7488BA46, ped); } // 0x6D9F5FAA7488BA46
	static BOOL IS_PED_MODEL(Ped ped, Hash modelHash) { return invoke<BOOL>(0xC9D55B1A358A5BF7, ped, modelHash); } // 0xC9D55B1A358A5BF7
	static BOOL IS_PED_ON_ANY_BIKE(Ped ped) { return invoke<BOOL>(0x94495889E22C6479, ped); } // 0x94495889E22C6479
	static BOOL IS_PED_ON_FOOT(Ped ped) { return invoke<BOOL>(0x1FEE67DB37F59B2, ped); } // 0x1FEE67DB37F59B2
	static BOOL IS_PED_ON_MOUNT(Ped ped) { return invoke<BOOL>(0x460BC76A0E10655E, ped); } // 0x460BC76A0E10655E
	static BOOL IS_PED_ON_SPECIFIC_VEHICLE(Ped ped, Vehicle vehicle) { return invoke<BOOL>(0xEC5F66E459AF3BB2, ped, vehicle); } // 0xEC5F66E459AF3BB2
	static BOOL IS_PED_ON_VEHICLE(Ped ped) { return invoke<BOOL>(0x67722AEB798E5FAB, ped); } // 0x67722AEB798E5FAB
	static BOOL IS_PED_PERFORMING_STEALTH_KILL(Ped ped) { return invoke<BOOL>(0xFD4CCDBCC59941B7, ped); } // 0xFD4CCDBCC59941B7
	static BOOL IS_PED_PLANTING_BOMB(Ped ped) { return invoke<BOOL>(0xC70B5FAE151982D8, ped); } // 0xC70B5FAE151982D8
	static BOOL IS_PED_PRONE(Ped ped) { return invoke<BOOL>(0xD6A86331A537A7B9, ped); } // 0xD6A86331A537A7B9
	static BOOL _IS_PED_PROP_VALID(Ped ped, int componentId, int drawableId, int TextureId) { return invoke<BOOL>(0x2B16A3BFF1FBCE49, ped, componentId, drawableId, TextureId); } // 0x2B16A3BFF1FBCE49
	static BOOL IS_PED_RAGDOLL(Ped ped) { return invoke<BOOL>(0x47E4E977581C5B55, ped); } // 0x47E4E977581C5B55
	static BOOL IS_PED_RELOADING(Ped ped) { return invoke<BOOL>(0x24B100C68C645951, ped); } // 0x24B100C68C645951
	static BOOL IS_PED_RESPONDING_TO_EVENT(Ped ped, Any event) { return invoke<BOOL>(0x625B774D75C87068, ped, event); } // 0x625B774D75C87068
	static BOOL IS_PED_RUNNING_MOBILE_PHONE_TASK(Ped ped) { return invoke<BOOL>(0x2AFE52F782F25775, ped); } // 0x2AFE52F782F25775
	static BOOL IS_PED_RUNNING_RAGDOLL_TASK(Ped ped) { return invoke<BOOL>(0xE3B6097CC25AA69E, ped); } // 0xE3B6097CC25AA69E
	static BOOL IS_PED_SHOOTING(Ped ped) { return invoke<BOOL>(0x34616828CD07F1A1, ped); } // 0x34616828CD07F1A1
	static BOOL IS_PED_SHOOTING_IN_AREA(Ped ped, float x1, float y1, float z1, float x2, float y2, float z2, BOOL p7, BOOL p8) { return invoke<BOOL>(0x7E9DFE24AC1E58EF, ped, x1, y1, z1, x2, y2, z2, p7, p8); } // 0x7E9DFE24AC1E58EF
	static BOOL IS_PED_SITTING_IN_ANY_VEHICLE(Ped ped) { return invoke<BOOL>(0x826AA586EDB9FEF8, ped); } // 0x826AA586EDB9FEF8
	static BOOL IS_PED_SITTING_IN_VEHICLE(Ped ped, Vehicle vehicle) { return invoke<BOOL>(0xA808AA1D79230FC2, ped, vehicle); } // 0xA808AA1D79230FC2
	static BOOL _IS_PED_STANDING_IN_COVER(Ped ped) { return invoke<BOOL>(0x6A03BF943D767C93, ped); } // 0x6A03BF943D767C93
	static BOOL IS_PED_STOPPED(Ped ped) { return invoke<BOOL>(0x530944F6F4B8A214, ped); } // 0x530944F6F4B8A214
	static BOOL IS_PED_SWIMMING(Ped ped) { return invoke<BOOL>(0x9DE327631295B4C2, ped); } // 0x9DE327631295B4C2
	static BOOL IS_PED_SWIMMING_UNDER_WATER(Ped ped) { return invoke<BOOL>(0xC024869A53992F34, ped); } // 0xC024869A53992F34
	static BOOL IS_PED_TRACKED(Ped ped) { return invoke<BOOL>(0x4C5E1F087CD10BB7, ped); } // 0x4C5E1F087CD10BB7
	static BOOL IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE(Ped ped) { return invoke<BOOL>(0x44D28D5DDFE5F68C, ped); } // 0x44D28D5DDFE5F68C
	static BOOL IS_PED_USING_ACTION_MODE(Ped ped) { return invoke<BOOL>(0xE73468D085F745, ped); } // 0xE73468D085F745
	static BOOL IS_PED_USING_ANY_SCENARIO(Ped ped) { return invoke<BOOL>(0x57AB4A3080F85143, ped); } // 0x57AB4A3080F85143
	static BOOL IS_PED_USING_SCENARIO(Ped ped, char* scenario) { return invoke<BOOL>(0x1BF094736DD62C2E, ped, scenario); } // 0x1BF094736DD62C2E
	static BOOL IS_PED_VAULTING(Ped ped) { return invoke<BOOL>(0x117C70D1F5730B5E, ped); } // 0x117C70D1F5730B5E
	static BOOL IS_PED_WEARING_HELMET(Ped ped) { return invoke<BOOL>(0xF33BDFE19B309B19, ped); } // 0xF33BDFE19B309B19
	static BOOL IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM(Ped ped, char* animDict, char* anim) { return invoke<BOOL>(0x6EC47A344923E1ED, ped, animDict, anim); } // 0x6EC47A344923E1ED
	static BOOL IS_SYNCHRONIZED_SCENE_LOOPED(int sceneID) { return invoke<BOOL>(0x62522002E0C391BA, sceneID); } // 0x62522002E0C391BA
	static BOOL IS_SYNCHRONIZED_SCENE_RUNNING(int sceneId) { return invoke<BOOL>(0x25D39B935A038A26, sceneId); } // 0x25D39B935A038A26
	static BOOL IS_TRACKED_PED_VISIBLE(Ped ped) { return invoke<BOOL>(0x91C8E617F64188AC, ped); } // 0x91C8E617F64188AC
	static void KNOCK_OFF_PED_PROP(Ped ped, BOOL p1, BOOL p2, BOOL p3, BOOL p4) { invoke<Void>(0x6FD7816A36615F48, ped, p1, p2, p3, p4); } // 0x6FD7816A36615F48
	static void KNOCK_PED_OFF_VEHICLE(Ped ped) { invoke<Void>(0x45BBCBA77C29A841, ped); } // 0x45BBCBA77C29A841
	static BOOL _0x03EA03AF85A85CB7(Ped ped, BOOL p1, BOOL p2, BOOL p3, BOOL p4, BOOL p5, BOOL p6, BOOL p7, Any p8) { return invoke<BOOL>(0x3EA03AF85A85CB7, ped, p1, p2, p3, p4, p5, p6, p7, p8); } // 0x3EA03AF85A85CB7
	static BOOL _0x06087579E7AA85A9(Any p0, Any p1, float p2, float p3, float p4, float p5) { return invoke<BOOL>(0x6087579E7AA85A9, p0, p1, p2, p3, p4, p5); } // 0x6087579E7AA85A9
	static void _0x061CB768363D6424(Any p0, BOOL p1) { invoke<Void>(0x61CB768363D6424, p0, p1); } // 0x61CB768363D6424
	static void _0x0B3E35AC043707D9(Any p0, Any p1) { invoke<Void>(0xB3E35AC043707D9, p0, p1); } // 0xB3E35AC043707D9
	static void _0x0F62619393661D6E(Any p0, Any p1, Any p2) { invoke<Void>(0xF62619393661D6E, p0, p1, p2); } // 0xF62619393661D6E
	static void _0x110F526AB784111F(Ped ped, float p1) { invoke<Void>(0x110F526AB784111F, ped, p1); } // 0x110F526AB784111F
	static void _0x1216E0BFA72CC703(Any p0, Any p1) { invoke<Void>(0x1216E0BFA72CC703, p0, p1); } // 0x1216E0BFA72CC703
	static void _0x1280804F7CFD2D6C(Any p0) { invoke<Void>(0x1280804F7CFD2D6C, p0); } // 0x1280804F7CFD2D6C
	static void _0x129466ED55140F8D(Ped ped, BOOL toggle) { invoke<Void>(0x129466ED55140F8D, ped, toggle); } // 0x129466ED55140F8D
	static BOOL _0x14590DDBEDB1EC85(Ped ped) { return invoke<BOOL>(0x14590DDBEDB1EC85, ped); } // 0x14590DDBEDB1EC85
	static void _0x148B08C2D2ACB884(Any p0, Any p1, Any p2) { invoke<Void>(0x148B08C2D2ACB884, p0, p1, p2); } // 0x148B08C2D2ACB884
	static void _0x1A330D297AAC6BC1(Ped ped, int p1) { invoke<Void>(0x1A330D297AAC6BC1, ped, p1); } // 0x1A330D297AAC6BC1
	static Any _0x1E77FA7A62EE6C4C(Any p0) { return invoke<Any>(0x1E77FA7A62EE6C4C, p0); } // 0x1E77FA7A62EE6C4C
	static int _0x1E98817B311AE98A(Ped ped) { return invoke<int>(0x1E98817B311AE98A, ped); } // 0x1E98817B311AE98A
	static void _0x2016C603D6B8987C(Any p0, BOOL p1) { invoke<Void>(0x2016C603D6B8987C, p0, p1); } // 0x2016C603D6B8987C
	static void _0x2208438012482A1A(Ped ped, BOOL p1, BOOL p2) { invoke<Void>(0x2208438012482A1A, ped, p1, p2); } // 0x2208438012482A1A
	static Any _0x25361A96E0F7E419(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0x25361A96E0F7E419, p0, p1, p2, p3); } // 0x25361A96E0F7E419
	static BOOL _0x26AF0E8E30BD2A2C(Ped ped) { return invoke<BOOL>(0x26AF0E8E30BD2A2C, ped); } // 0x26AF0E8E30BD2A2C
	static void _0x2735233A786B1BEF(Ped ped, float p1) { invoke<Void>(0x2735233A786B1BEF, ped, p1); } // 0x2735233A786B1BEF
	static void _0x280C7E3AC7F56E90(Any p0, Any* p1, Any* p2, Any* p3) { invoke<Void>(0x280C7E3AC7F56E90, p0, p1, p2, p3); } // 0x280C7E3AC7F56E90
	static void _0x288DF530C92DAD6F(Any p0, float p1) { invoke<Void>(0x288DF530C92DAD6F, p0, p1); } // 0x288DF530C92DAD6F
	static void _0x2B5AA717A181FB4C(Any p0, BOOL p1) { invoke<Void>(0x2B5AA717A181FB4C, p0, p1); } // 0x2B5AA717A181FB4C
	static void _0x2B694AFCF64E6994(Ped ped, BOOL p1) { invoke<Void>(0x2B694AFCF64E6994, ped, p1); } // 0x2B694AFCF64E6994
	static void _0x2DF9038C90AD5264(float p0, float p1, float p2, float p3, float p4, int interiorFlags, float scale, int duration) { invoke<Void>(0x2DF9038C90AD5264, p0, p1, p2, p3, p4, interiorFlags, scale, duration); } // 0x2DF9038C90AD5264
	static Any _0x2DFC81C9B9608549(Any p0, Any p1) { return invoke<Any>(0x2DFC81C9B9608549, p0, p1); } // 0x2DFC81C9B9608549
	static void _0x2F074C904D85129E(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0x2F074C904D85129E, p0, p1, p2, p3, p4, p5, p6); } // 0x2F074C904D85129E
	static void _0x2F3C3D9F50681DE4(Any p0, BOOL p1) { invoke<Void>(0x2F3C3D9F50681DE4, p0, p1); } // 0x2F3C3D9F50681DE4
	static Any _0x336B3D200AB007CB(Any p0, float p1, float p2, float p3, float p4) { return invoke<Any>(0x336B3D200AB007CB, p0, p1, p2, p3, p4); } // 0x336B3D200AB007CB
	static Any _0x36B77BB84687C318(Ped ped, Any p1) { return invoke<Any>(0x36B77BB84687C318, ped, p1); } // 0x36B77BB84687C318
	static void _0x36C6984C3ED0C911(Any p0) { invoke<Void>(0x36C6984C3ED0C911, p0); } // 0x36C6984C3ED0C911
	static Any _0x3795688A307E1EB6(Any p0) { return invoke<Any>(0x3795688A307E1EB6, p0); } // 0x3795688A307E1EB6
	static Any _0x39D55A620FCB6A3A(Ped ped, int slot, int drawableId, int textureId) { return invoke<Any>(0x39D55A620FCB6A3A, ped, slot, drawableId, textureId); } // 0x39D55A620FCB6A3A
	static Any _0x3C67506996001F5E() { return invoke<Any>(0x3C67506996001F5E); } // 0x3C67506996001F5E
	static BOOL _0x3E802F11FBE27674(Any p0) { return invoke<BOOL>(0x3E802F11FBE27674, p0); } // 0x3E802F11FBE27674
	static void _0x3E9679C1DFCF422C(Any p0, Any p1) { invoke<Void>(0x3E9679C1DFCF422C, p0, p1); } // 0x3E9679C1DFCF422C
	static void _0x3F7325574E41B44D(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x3F7325574E41B44D, p0, p1, p2, p3); } // 0x3F7325574E41B44D
	static Any _0x412F1364FA066CFB(Any p0) { return invoke<Any>(0x412F1364FA066CFB, p0); } // 0x412F1364FA066CFB
	static void _0x425AECF167663F48(Ped ped, BOOL p1) { invoke<Void>(0x425AECF167663F48, ped, p1); } // 0x425AECF167663F48
	static BOOL _0x451294E859ECC018(int p0) { return invoke<BOOL>(0x451294E859ECC018, p0); } // 0x451294E859ECC018
	static Any _0x451D05012CCEC234(Any p0) { return invoke<Any>(0x451D05012CCEC234, p0); } // 0x451D05012CCEC234
	static void _0x4668D80430D6C299(Ped ped) { invoke<Void>(0x4668D80430D6C299, ped); } // 0x4668D80430D6C299
	static BOOL _0x46B05BCAE43856B0(Ped ped, int flag) { return invoke<BOOL>(0x46B05BCAE43856B0, ped, flag); } // 0x46B05BCAE43856B0
	static void _0x4759CC730F947C81() { invoke<Void>(0x4759CC730F947C81); } // 0x4759CC730F947C81
	static void _0x49E50BDB8BA4DAB2(Ped ped, BOOL p1) { invoke<Void>(0x49E50BDB8BA4DAB2, ped, p1); } // 0x49E50BDB8BA4DAB2
	static Any _0x511F1A683387C7E2(Any p0) { return invoke<Any>(0x511F1A683387C7E2, p0); } // 0x511F1A683387C7E2
	static void _0x52D59AB61DDC05DD(Ped ped, BOOL p1) { invoke<Void>(0x52D59AB61DDC05DD, ped, p1); } // 0x52D59AB61DDC05DD
	static int _0x5407B7288D0478B7(Any p0) { return invoke<int>(0x5407B7288D0478B7, p0); } // 0x5407B7288D0478B7
	static void _0x5615E0C5EB2BC6E2(Any p0, Any p1) { invoke<Void>(0x5615E0C5EB2BC6E2, p0, p1); } // 0x5615E0C5EB2BC6E2
	static void _0x570389D1C3DE3C6B(Any p0) { invoke<Void>(0x570389D1C3DE3C6B, p0); } // 0x570389D1C3DE3C6B
	static void _0x576594E8D64375E2(Any p0, BOOL p1) { invoke<Void>(0x576594E8D64375E2, p0, p1); } // 0x576594E8D64375E2
	static void _0x5A7F62FDA59759BD() { invoke<Void>(0x5A7F62FDA59759BD); } // 0x5A7F62FDA59759BD
	static void _0x5AAB586FFEC0FD96(Any p0) { invoke<Void>(0x5AAB586FFEC0FD96, p0); } // 0x5AAB586FFEC0FD96
	static void _0x5B6010B3CBC29095(Any p0, BOOL p1) { invoke<Void>(0x5B6010B3CBC29095, p0, p1); } // 0x5B6010B3CBC29095
	static void _0x5D517B27CF6ECD04(Any p0) { invoke<Void>(0x5D517B27CF6ECD04, p0); } // 0x5D517B27CF6ECD04
	static void _0x600048C60D5C2C51(Any p0) { invoke<Void>(0x600048C60D5C2C51, p0); } // 0x600048C60D5C2C51
	static BOOL _0x61767F73EACEED21(Ped ped) { return invoke<BOOL>(0x61767F73EACEED21, ped); } // 0x61767F73EACEED21
	static Any _0x6585D955A68452A5(Ped ped) { return invoke<Any>(0x6585D955A68452A5, ped); } // 0x6585D955A68452A5
	static void _0x6647C5F6F5792496(Ped ped, BOOL p1) { invoke<Void>(0x6647C5F6F5792496, ped, p1); } // 0x6647C5F6F5792496
	static BOOL _0x66680A92700F43DF(Ped p0) { return invoke<BOOL>(0x66680A92700F43DF, p0); } // 0x66680A92700F43DF
	static Any _0x668FD40BCBA5DE48(Any p0, Any p1, Any p2, Any p3, Any p4) { return invoke<Any>(0x668FD40BCBA5DE48, p0, p1, p2, p3, p4); } // 0x668FD40BCBA5DE48
	static BOOL _0x68772DB2B2526F9F(Ped ped, float x, float y, float z, float range) { return invoke<BOOL>(0x68772DB2B2526F9F, ped, x, y, z, range); } // 0x68772DB2B2526F9F
	static void _0x687C0B594907D2E8(Ped ped) { invoke<Void>(0x687C0B594907D2E8, ped); } // 0x687C0B594907D2E8
	static void _0x6B0E6172C9A4D902(BOOL p0) { invoke<Void>(0x6B0E6172C9A4D902, p0); } // 0x6B0E6172C9A4D902
	static void _0x711794453CFD692B(Any p0, Any p1) { invoke<Void>(0x711794453CFD692B, p0, p1); } // 0x711794453CFD692B
	static void _0x733C87D4CE22BEA2(Any p0) { invoke<Void>(0x733C87D4CE22BEA2, p0); } // 0x733C87D4CE22BEA2
	static BOOL _0x7350823473013C02(Ped ped) { return invoke<BOOL>(0x7350823473013C02, ped); } // 0x7350823473013C02
	static void _0x75BA1CB3B7D40CAF(Ped ped, BOOL p1) { invoke<Void>(0x75BA1CB3B7D40CAF, ped, p1); } // 0x75BA1CB3B7D40CAF
	static Any _0x76BBA2CEE66D47E9(Any p0) { return invoke<Any>(0x76BBA2CEE66D47E9, p0); } // 0x76BBA2CEE66D47E9
	static void _0x781DE8FA214E87D2(Ped ped, char* p1) { invoke<Void>(0x781DE8FA214E87D2, ped, p1); } // 0x781DE8FA214E87D2
	static BOOL _0x784002A632822099(Ped ped) { return invoke<BOOL>(0x784002A632822099, ped); } // 0x784002A632822099
	static void _0x78C4E9961DB3EB5B(Any p0, Any p1) { invoke<Void>(0x78C4E9961DB3EB5B, p0, p1); } // 0x78C4E9961DB3EB5B
	static void _0x7D7A2E43E74E2EB8(Any p0) { invoke<Void>(0x7D7A2E43E74E2EB8, p0); } // 0x7D7A2E43E74E2EB8
	static BOOL _0x7F2F4F13AC5257EF(Any p0) { return invoke<BOOL>(0x7F2F4F13AC5257EF, p0); } // 0x7F2F4F13AC5257EF
	static void _0x80054D7FCC70EEC6(Any p0) { invoke<Void>(0x80054D7FCC70EEC6, p0); } // 0x80054D7FCC70EEC6
	static Any _0x81AA517FBBA05D39(Any p0) { return invoke<Any>(0x81AA517FBBA05D39, p0); } // 0x81AA517FBBA05D39
	static void _0x820E9892A77E97CD(Any p0, Any p1) { invoke<Void>(0x820E9892A77E97CD, p0, p1); } // 0x820E9892A77E97CD
	static void _0x83A169EABCDB10A2(Any p0, Any p1) { invoke<Void>(0x83A169EABCDB10A2, p0, p1); } // 0x83A169EABCDB10A2
	static Any _0x876928DDDFCCC9CD() { return invoke<Any>(0x876928DDDFCCC9CD); } // 0x876928DDDFCCC9CD
	static void _0x87DDEB611B329A9C(Any p0) { invoke<Void>(0x87DDEB611B329A9C, p0); } // 0x87DDEB611B329A9C
	static Any _0x8A24B067D175A7BD(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return invoke<Any>(0x8A24B067D175A7BD, p0, p1, p2, p3, p4, p5); } // 0x8A24B067D175A7BD
	static Entity _0x8C4F3BF23B6237DB(Ped ped, BOOL p1, BOOL p2) { return invoke<Entity>(0x8C4F3BF23B6237DB, ped, p1, p2); } // 0x8C4F3BF23B6237DB
	static void _0x952F06BEECD775CC(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x952F06BEECD775CC, p0, p1, p2, p3); } // 0x952F06BEECD775CC
	static Any _0x953563CE563143AF(Any p0) { return invoke<Any>(0x953563CE563143AF, p0); } // 0x953563CE563143AF
	static void _0x9911F4A24485F653(BOOL p0) { invoke<Void>(0x9911F4A24485F653, p0); } // 0x9911F4A24485F653
	static void _0x9A77DFD295E29B09(Any p0, BOOL p1) { invoke<Void>(0x9A77DFD295E29B09, p0, p1); } // 0x9A77DFD295E29B09
	static BOOL _0x9C6A6C19B6C0C496(Ped p0, Any* p1) { return invoke<BOOL>(0x9C6A6C19B6C0C496, p0, p1); } // 0x9C6A6C19B6C0C496
	static Any _0x9D728C1E12BF5518(Any p0) { return invoke<Any>(0x9D728C1E12BF5518, p0); } // 0x9D728C1E12BF5518
	static void _0x9DBA107B4937F809(Any p0, char* p1) { invoke<Void>(0x9DBA107B4937F809, p0, p1); } // 0x9DBA107B4937F809
	static BOOL _0x9E30E91FB03A2CAF(Any* p0, Any* p1) { return invoke<BOOL>(0x9E30E91FB03A2CAF, p0, p1); } // 0x9E30E91FB03A2CAF
	static void _0xA21C118553BBDF02(Ped ped) { invoke<Void>(0xA21C118553BBDF02, ped); } // 0xA21C118553BBDF02
	static void _0xA3A9299C4F2ADB98(Any p0) { invoke<Void>(0xA3A9299C4F2ADB98, p0); } // 0xA3A9299C4F2ADB98
	static BOOL _0xA3F3564A5B3646C0(Ped ped) { return invoke<BOOL>(0xA3F3564A5B3646C0, ped); } // 0xA3F3564A5B3646C0
	static void _0xA52D5247A4227E14(Any p0) { invoke<Void>(0xA52D5247A4227E14, p0); } // 0xA52D5247A4227E14
	static Any _0xA586FBEB32A53DBB() { return invoke<Any>(0xA586FBEB32A53DBB); } // 0xA586FBEB32A53DBB
	static Any _0xA635C11B8C44AFC2() { return invoke<Any>(0xA635C11B8C44AFC2); } // 0xA635C11B8C44AFC2
	static void _0xA660FAF550EB37E5(Any p0, BOOL p1) { invoke<Void>(0xA660FAF550EB37E5, p0, p1); } // 0xA660FAF550EB37E5
	static void _0xA9B61A329BFDCBEA(Any p0, BOOL p1) { invoke<Void>(0xA9B61A329BFDCBEA, p0, p1); } // 0xA9B61A329BFDCBEA
	static Any _0xAAA6A3698A69E048(Any p0) { return invoke<Any>(0xAAA6A3698A69E048, p0); } // 0xAAA6A3698A69E048
	static void _0xAFC976FD0580C7B3(Ped ped, BOOL toggle) { invoke<Void>(0xAFC976FD0580C7B3, ped, toggle); } // 0xAFC976FD0580C7B3
	static void _0xAFF4710E2A0A6C12(Ped ped) { invoke<Void>(0xAFF4710E2A0A6C12, ped); } // 0xAFF4710E2A0A6C12
	static void _0xB282749D5E028163(Any p0, Any p1) { invoke<Void>(0xB282749D5E028163, p0, p1); } // 0xB282749D5E028163
	static void _0xB2AFF10216DEFA2F(float x, float y, float z, float p3, float p4, float p5, float p6, int interiorFlags, float scale, int duration) { invoke<Void>(0xB2AFF10216DEFA2F, x, y, z, p3, p4, p5, p6, interiorFlags, scale, duration); } // 0xB2AFF10216DEFA2F
	static void _0xB782F8238512BAD5(Any p0, Any* p1) { invoke<Void>(0xB782F8238512BAD5, p0, p1); } // 0xB782F8238512BAD5
	static BOOL _0xB8B52E498014F5B0(Ped ped) { return invoke<BOOL>(0xB8B52E498014F5B0, ped); } // 0xB8B52E498014F5B0
	static Any _0xB9496CE47546DB2C(Any p0) { return invoke<Any>(0xB9496CE47546DB2C, p0); } // 0xB9496CE47546DB2C
	static BOOL _0xBA63D9FE45412247(Ped ped, BOOL p1) { return invoke<BOOL>(0xBA63D9FE45412247, ped, p1); } // 0xBA63D9FE45412247
	static Any _0xBA8805A1108A2515(Any p0) { return invoke<Any>(0xBA8805A1108A2515, p0); } // 0xBA8805A1108A2515
	static void _0xC1F6EBF9A3D55538(Any p0, Any p1) { invoke<Void>(0xC1F6EBF9A3D55538, p0, p1); } // 0xC1F6EBF9A3D55538
	static void _0xC2EE020F5FB4DB53(Ped ped) { invoke<Void>(0xC2EE020F5FB4DB53, ped); } // 0xC2EE020F5FB4DB53
	static Any _0xC56FBF2F228E1DAC(Hash modelHash, Any p1, Any p2) { return invoke<Any>(0xC56FBF2F228E1DAC, modelHash, p1, p2); } // 0xC56FBF2F228E1DAC
	static void _0xC79196DCB36F6121(Any p0) { invoke<Void>(0xC79196DCB36F6121, p0); } // 0xC79196DCB36F6121
	static void _0xCB968B53FC7F916D(Any p0, BOOL p1, Any p2, Any p3) { invoke<Void>(0xCB968B53FC7F916D, p0, p1, p2, p3); } // 0xCB968B53FC7F916D
	static Any _0xCC6E3B6BB69501F1(Any p0) { return invoke<Any>(0xCC6E3B6BB69501F1, p0); } // 0xCC6E3B6BB69501F1
	static void _0xCC9682B8951C5229(Ped ped, int r, int g, int b, int p4) { invoke<Void>(0xCC9682B8951C5229, ped, r, g, b, p4); } // 0xCC9682B8951C5229
	static void _0xCD018C591F94CB43(Any p0, BOOL p1) { invoke<Void>(0xCD018C591F94CB43, p0, p1); } // 0xCD018C591F94CB43
	static void _0xCEDA60A74219D064(Any p0, BOOL p1) { invoke<Void>(0xCEDA60A74219D064, p0, p1); } // 0xCEDA60A74219D064
	static BOOL _0xD1871251F3B5ACD7(Ped ped) { return invoke<BOOL>(0xD1871251F3B5ACD7, ped); } // 0xD1871251F3B5ACD7
	static void _0xD33DAA36272177C4(Ped ped) { invoke<Void>(0xD33DAA36272177C4, ped); } // 0xD33DAA36272177C4
	static void _0xD69411AA0CEBF9E9(Ped ped, int p1, int p2, int p3) { invoke<Void>(0xD69411AA0CEBF9E9, ped, p1, p2, p3); } // 0xD69411AA0CEBF9E9
	static void _0xD8C3BE3EE94CAF2D(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xD8C3BE3EE94CAF2D, p0, p1, p2, p3, p4); } // 0xD8C3BE3EE94CAF2D
	static BOOL _0xDCCA191DF9980FD7(Ped ped) { return invoke<BOOL>(0xDCCA191DF9980FD7, ped); } // 0xDCCA191DF9980FD7
	static void _0xDED5AF5A0EA4B297(Ped driver, float p1) { invoke<Void>(0xDED5AF5A0EA4B297, driver, p1); } // 0xDED5AF5A0EA4B297
	static void _0xE43A13C9E4CCCBCF(Ped ped, BOOL p1) { invoke<Void>(0xE43A13C9E4CCCBCF, ped, p1); } // 0xE43A13C9E4CCCBCF
	static void _0xE4723DB6E736CCFF(Ped ped, Any p1, float p2, float p3, float p4, float p5, BOOL p6) { invoke<Void>(0xE4723DB6E736CCFF, ped, p1, p2, p3, p4, p5, p6); } // 0xE4723DB6E736CCFF
	static void _0xE6CA85E7259CE16B(Any p0) { invoke<Void>(0xE6CA85E7259CE16B, p0); } // 0xE6CA85E7259CE16B
	static void _0xE861D0B05C7662B8(Pickup p0, Any p1, Blip* p2) { invoke<Void>(0xE861D0B05C7662B8, p0, p1, p2); } // 0xE861D0B05C7662B8
	static Any _0xE8A169E666CBC541() { return invoke<Any>(0xE8A169E666CBC541); } // 0xE8A169E666CBC541
	static void _0xE906EC930F5FE7C8(Any p0, Any p1) { invoke<Void>(0xE906EC930F5FE7C8, p0, p1); } // 0xE906EC930F5FE7C8
	static int _0xEA9960D07DADCF10(Any p0) { return invoke<int>(0xEA9960D07DADCF10, p0); } // 0xEA9960D07DADCF10
	static Any _0xEBB376779A760AA8() { return invoke<Any>(0xEBB376779A760AA8); } // 0xEBB376779A760AA8
	static BOOL _0xEBD0EDBA5BE957CF(Ped ped) { return invoke<BOOL>(0xEBD0EDBA5BE957CF, ped); } // 0xEBD0EDBA5BE957CF
	static void _0xEC4B4B3B9908052A(Ped ped, float unk) { invoke<Void>(0xEC4B4B3B9908052A, ped, unk); } // 0xEC4B4B3B9908052A
	static Any _0xEC6935EBE0847B90(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0xEC6935EBE0847B90, p0, p1, p2, p3); } // 0xEC6935EBE0847B90
	static void _0xED3C76ADFA6D07C4(Ped ped) { invoke<Void>(0xED3C76ADFA6D07C4, ped); } // 0xED3C76ADFA6D07C4
	static BOOL _0xED6D8E27A43B8CDE(Any p0) { return invoke<BOOL>(0xED6D8E27A43B8CDE, p0); } // 0xED6D8E27A43B8CDE
	static Any _0xEEED8FAFEC331A70(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0xEEED8FAFEC331A70, p0, p1, p2, p3); } // 0xEEED8FAFEC331A70
	static Any _0xF033419D1B81FAE8(Any p0) { return invoke<Any>(0xF033419D1B81FAE8, p0); } // 0xF033419D1B81FAE8
	static BOOL _0xF0DAEF2F545BEE25(Any p0) { return invoke<BOOL>(0xF0DAEF2F545BEE25, p0); } // 0xF0DAEF2F545BEE25
	static void _0xF1C03A5352243A30(Any p0) { invoke<Void>(0xF1C03A5352243A30, p0); } // 0xF1C03A5352243A30
	static BOOL _0xF2385935BFFD4D92(Any p0) { return invoke<BOOL>(0xF2385935BFFD4D92, p0); } // 0xF2385935BFFD4D92
	static void _0xF2BEBCDFAFDAA19E(BOOL toggle) { invoke<Void>(0xF2BEBCDFAFDAA19E, toggle); } // 0xF2BEBCDFAFDAA19E
	static BOOL _0xF41B5D290C99A3D6(Any p0) { return invoke<BOOL>(0xF41B5D290C99A3D6, p0); } // 0xF41B5D290C99A3D6
	static Any _0xF445DE8DA80A1792() { return invoke<Any>(0xF445DE8DA80A1792); } // 0xF445DE8DA80A1792
	static void _0xF5846EDB26A98A24(Ped ped, BOOL p1) { invoke<Void>(0xF5846EDB26A98A24, ped, p1); } // 0xF5846EDB26A98A24
	static BOOL _0xF60165E1D2C5370B(Ped ped, Any* p1, Any* p2) { return invoke<BOOL>(0xF60165E1D2C5370B, ped, p1, p2); } // 0xF60165E1D2C5370B
	static void _0xF79F9DEF0AADE61A(Ped ped) { invoke<Void>(0xF79F9DEF0AADE61A, ped); } // 0xF79F9DEF0AADE61A
	static void _0xF9ACF4A08098EA25(Ped ped, BOOL p1) { invoke<Void>(0xF9ACF4A08098EA25, ped, p1); } // 0xF9ACF4A08098EA25
	static BOOL _0xFCF37A457CB96DC0(Any p0, float p1, float p2, float p3, float p4) { return invoke<BOOL>(0xFCF37A457CB96DC0, p0, p1, p2, p3, p4); } // 0xFCF37A457CB96DC0
	static Any _0xFE07FF6495D52E2A(Any p0, Any p1, Any p2, Any p3) { return invoke<Any>(0xFE07FF6495D52E2A, p0, p1, p2, p3); } // 0xFE07FF6495D52E2A
	static BOOL _0xFEC9A3B1820F3331(Any p0) { return invoke<BOOL>(0xFEC9A3B1820F3331, p0); } // 0xFEC9A3B1820F3331
	static void _0xFEE4A5459472A9F8() { invoke<Void>(0xFEE4A5459472A9F8); } // 0xFEE4A5459472A9F8
	static void _0xFF4803BC019852D9(float p0, Any p1) { invoke<Void>(0xFF4803BC019852D9, p0, p1); } // 0xFF4803BC019852D9
	static void PLAY_FACIAL_ANIM(Ped ped, char* animName, char* animDict) { invoke<Void>(0xE1E65CA8AC9C00ED, ped, animName, animDict); } // 0xE1E65CA8AC9C00ED
	static void REGISTER_HATED_TARGETS_AROUND_PED(Ped ped, float radius) { invoke<Void>(0x9222F300BF8354FE, ped, radius); } // 0x9222F300BF8354FE
	static int REGISTER_PEDHEADSHOT(Ped ped) { return invoke<int>(0x4462658788425076, ped); } // 0x4462658788425076
	static void REGISTER_TARGET(Ped ped, Ped target) { invoke<Void>(0x2F25D9AEFA34FBA2, ped, target); } // 0x2F25D9AEFA34FBA2
	static void REMOVE_ACTION_MODE_ASSET(char* asset) { invoke<Void>(0x13E940F88470FA51, asset); } // 0x13E940F88470FA51
	static void REMOVE_GROUP(int groupId) { invoke<Void>(0x8EB2F69076AF7053, groupId); } // 0x8EB2F69076AF7053
	static void REMOVE_PED_DEFENSIVE_AREA(Ped ped, BOOL toggle) { invoke<Void>(0x74D4E028107450A9, ped, toggle); } // 0x74D4E028107450A9
	static void REMOVE_PED_ELEGANTLY(Ped* ped) { invoke<Void>(0xAC6D445B994DF95E, ped); } // 0xAC6D445B994DF95E
	static void REMOVE_PED_FROM_GROUP(Ped ped) { invoke<Void>(0xED74007FFB146BC2, ped); } // 0xED74007FFB146BC2
	static void REMOVE_PED_HELMET(Ped ped, BOOL instantly) { invoke<Void>(0xA7B2458D0AD6DED8, ped, instantly); } // 0xA7B2458D0AD6DED8
	static void REMOVE_PED_PREFERRED_COVER_SET(Ped ped) { invoke<Void>(0xFDDB234CF74073D9, ped); } // 0xFDDB234CF74073D9
	static void REMOVE_RELATIONSHIP_GROUP(Hash groupHash) { invoke<Void>(0xB6BA2444AB393DA2, groupHash); } // 0xB6BA2444AB393DA2
	static void REMOVE_SCENARIO_BLOCKING_AREA(Any p0, BOOL p1) { invoke<Void>(0x31D16B74C6E29D66, p0, p1); } // 0x31D16B74C6E29D66
	static void REMOVE_SCENARIO_BLOCKING_AREAS() { invoke<Void>(0xD37401D78A929A49); } // 0xD37401D78A929A49
	static void REMOVE_STEALTH_MODE_ASSET(char* asset) { invoke<Void>(0x9219857D21F0E842, asset); } // 0x9219857D21F0E842
	static void REQUEST_ACTION_MODE_ASSET(char* asset) { invoke<Void>(0x290E2780BB7AA598, asset); } // 0x290E2780BB7AA598
	static void REQUEST_STEALTH_MODE_ASSET(char* asset) { invoke<Void>(0x2A0A62FCDEE16D4F, asset); } // 0x2A0A62FCDEE16D4F
	static void RESET_AI_MELEE_WEAPON_DAMAGE_MODIFIER() { invoke<Void>(0x46E56A7CD1D63C3F); } // 0x46E56A7CD1D63C3F
	static void RESET_AI_WEAPON_DAMAGE_MODIFIER() { invoke<Void>(0xEA16670E7BA4743C); } // 0xEA16670E7BA4743C
	static void RESET_GROUP_FORMATION_DEFAULT_SPACING(int groupHandle) { invoke<Void>(0x63DAB4CCB3273205, groupHandle); } // 0x63DAB4CCB3273205
	static void RESET_PED_IN_VEHICLE_CONTEXT(Ped ped) { invoke<Void>(0x22EF8FF8778030EB, ped); } // 0x22EF8FF8778030EB
	static void RESET_PED_LAST_VEHICLE(Ped ped) { invoke<Void>(0xBB8DE8CF6A8DD8BB, ped); } // 0xBB8DE8CF6A8DD8BB
	static void RESET_PED_MOVEMENT_CLIPSET(Ped ped, float p1) { invoke<Void>(0xAA74EC0CB0AAEA2C, ped, p1); } // 0xAA74EC0CB0AAEA2C
	static void _RESET_PED_RAGDOLL_BLOCKING_FLAGS(Ped ped, int flags) { invoke<Void>(0xD86D101FCFD00A4B, ped, flags); } // 0xD86D101FCFD00A4B
	static void RESET_PED_RAGDOLL_TIMER(Ped ped) { invoke<Void>(0x9FA4664CF62E47E8, ped); } // 0x9FA4664CF62E47E8
	static void RESET_PED_STRAFE_CLIPSET(Ped ped) { invoke<Void>(0x20510814175EA477, ped); } // 0x20510814175EA477
	static Any RESET_PED_VISIBLE_DAMAGE(Ped ped) { return invoke<Any>(0x3AC1F7B898F30C05, ped); } // 0x3AC1F7B898F30C05
	static void RESET_PED_WEAPON_MOVEMENT_CLIPSET(Ped ped) { invoke<Void>(0x97B0DB5B4AA74E77, ped); } // 0x97B0DB5B4AA74E77
	static void RESURRECT_PED(Ped ped) { invoke<Void>(0x71BC8E838B9C6035, ped); } // 0x71BC8E838B9C6035
	static void REVIVE_INJURED_PED(Ped ped) { invoke<Void>(0x8D8ACD8388CD99CE, ped); } // 0x8D8ACD8388CD99CE
	static void SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER(float modifier) { invoke<Void>(0x66460DEDDD417254, modifier); } // 0x66460DEDDD417254
	static void SET_AI_WEAPON_DAMAGE_MODIFIER(float value) { invoke<Void>(0x1B1E2A40A65B8521, value); } // 0x1B1E2A40A65B8521
	static void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(Ped ped, BOOL toggle) { invoke<Void>(0x9F8AA94D6D97DBF4, ped, toggle); } // 0x9F8AA94D6D97DBF4
	static void SET_CAN_ATTACK_FRIENDLY(Ped ped, BOOL toggle, BOOL p2) { invoke<Void>(0xB3B1CB349FF9C75D, ped, toggle, p2); } // 0xB3B1CB349FF9C75D
	static void SET_COMBAT_FLOAT(Ped ped, int combatType, float p2) { invoke<Void>(0xFF41B4B141ED981C, ped, combatType, p2); } // 0xFF41B4B141ED981C
	static void SET_CREATE_RANDOM_COPS(BOOL toggle) { invoke<Void>(0x102E68B2024D536D, toggle); } // 0x102E68B2024D536D
	static void SET_CREATE_RANDOM_COPS_NOT_ON_SCENARIOS(BOOL toggle) { invoke<Void>(0x8A4986851C4EF6E7, toggle); } // 0x8A4986851C4EF6E7
	static void SET_CREATE_RANDOM_COPS_ON_SCENARIOS(BOOL toggle) { invoke<Void>(0x444CB7D7DBE6973D, toggle); } // 0x444CB7D7DBE6973D
	static void SET_DRIVER_ABILITY(Ped driver, float ability) { invoke<Void>(0xB195FFA8042FC5C3, driver, ability); } // 0xB195FFA8042FC5C3
	static void SET_DRIVER_AGGRESSIVENESS(Ped driver, float aggressiveness) { invoke<Void>(0xA731F608CA104E3C, driver, aggressiveness); } // 0xA731F608CA104E3C
	static void SET_ENABLE_BOUND_ANKLES(Ped ped, BOOL toggle) { invoke<Void>(0xC52E0F855C58FC2E, ped, toggle); } // 0xC52E0F855C58FC2E
	static void SET_ENABLE_HANDCUFFS(Ped ped, BOOL toggle) { invoke<Void>(0xDF1AF8B5D56542FA, ped, toggle); } // 0xDF1AF8B5D56542FA
	static void SET_ENABLE_PED_ENVEFF_SCALE(Ped ped, BOOL toggle) { invoke<Void>(0xD2C5AA0C0E8D0F1E, ped, toggle); } // 0xD2C5AA0C0E8D0F1E
	static void SET_ENABLE_SCUBA(Ped ped, BOOL toggle) { invoke<Void>(0xF99F62004024D506, ped, toggle); } // 0xF99F62004024D506
	static Vehicle SET_EXCLUSIVE_PHONE_RELATIONSHIPS(Ped ped) { return invoke<Vehicle>(0xF92691AED837A5FC, ped); } // 0xF92691AED837A5FC
	static void SET_FACIAL_IDLE_ANIM_OVERRIDE(Ped ped, char* animName, char* animDict) { invoke<Void>(0xFFC24B988B938B38, ped, animName, animDict); } // 0xFFC24B988B938B38
	static void SET_GROUP_FORMATION(int groupId, int formationType) { invoke<Void>(0xCE2F5FC3AF7E8C1E, groupId, formationType); } // 0xCE2F5FC3AF7E8C1E
	static void SET_GROUP_FORMATION_SPACING(int groupId, float p1, float p2, float p3) { invoke<Void>(0x1D9D45004C28C916, groupId, p1, p2, p3); } // 0x1D9D45004C28C916
	static void SET_GROUP_SEPARATION_RANGE(int groupHandle, float separationRange) { invoke<Void>(0x4102C7858CFEE4E4, groupHandle, separationRange); } // 0x4102C7858CFEE4E4
	static void SET_IK_TARGET(Ped ped, int ikIndex, Entity entityLookAt, int boneLookAt, float offsetX, float offsetY, float offsetZ, Any p7, int blendInDuration, int blendOutDuration) { invoke<Void>(0xC32779C16FCEECD9, ped, ikIndex, entityLookAt, boneLookAt, offsetX, offsetY, offsetZ, p7, blendInDuration, blendOutDuration); } // 0xC32779C16FCEECD9
	static Any SET_PED_ACCURACY(Ped ped, int accuracy) { return invoke<Any>(0x7AEFB85C1D49DEB6, ped, accuracy); } // 0x7AEFB85C1D49DEB6
	static void SET_PED_ALERTNESS(Ped ped, int value) { invoke<Void>(0xDBA71115ED9941A6, ped, value); } // 0xDBA71115ED9941A6
	static void SET_PED_ALLOWED_TO_DUCK(Ped ped, BOOL toggle) { invoke<Void>(0xDA1F1B7BE1A8766F, ped, toggle); } // 0xDA1F1B7BE1A8766F
	static void SET_PED_ALLOW_VEHICLES_OVERRIDE(Ped ped, BOOL toggle) { invoke<Void>(0x3C028C636A414ED9, ped, toggle); } // 0x3C028C636A414ED9
	static void SET_PED_ALTERNATE_MOVEMENT_ANIM(Ped ped, int stance, char* animDictionary, char* animationName, float p4, BOOL p5) { invoke<Void>(0x90A43CC281FFAB46, ped, stance, animDictionary, animationName, p4, p5); } // 0x90A43CC281FFAB46
	static void SET_PED_ALTERNATE_WALK_ANIM(Ped ped, char* animDict, char* animName, float p3, BOOL p4) { invoke<Void>(0x6C60394CB4F75E9A, ped, animDict, animName, p3, p4); } // 0x6C60394CB4F75E9A
	static void SET_PED_ANGLED_DEFENSIVE_AREA(Ped ped, float p1, float p2, float p3, float p4, float p5, float p6, float p7, BOOL p8, BOOL p9) { invoke<Void>(0xC7F76DF27A5045A1, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9); } // 0xC7F76DF27A5045A1
	static void SET_PED_ARMOUR(Ped ped, int amount) { invoke<Void>(0xCEA04D83135264CC, ped, amount); } // 0xCEA04D83135264CC
	static void SET_PED_AS_COP(Ped ped, BOOL toggle) { invoke<Void>(0xBB03C38DD3FB7FFD, ped, toggle); } // 0xBB03C38DD3FB7FFD
	static void SET_PED_AS_ENEMY(Ped ped, BOOL toggle) { invoke<Void>(0x2A0C9720B854BFA, ped, toggle); } // 0x2A0C9720B854BFA
	static void SET_PED_AS_GROUP_LEADER(Ped ped, int groupId) { invoke<Void>(0x2A7819605465FBCE, ped, groupId); } // 0x2A7819605465FBCE
	static void SET_PED_AS_GROUP_MEMBER(Ped ped, int groupId) { invoke<Void>(0x9F3480FE65DB31B5, ped, groupId); } // 0x9F3480FE65DB31B5
	static void SET_PED_BLEND_FROM_PARENTS(Ped ped, Ped father, Ped mother, float fathersSide, float mothersSide) { invoke<Void>(0x137BBD05230DB22D, ped, father, mother, fathersSide, mothersSide); } // 0x137BBD05230DB22D
	static void SET_PED_BOUNDS_ORIENTATION(Ped ped, float p1, float p2, float p3, float p4, float p5) { invoke<Void>(0x4F5F651ACCC9C4CF, ped, p1, p2, p3, p4, p5); } // 0x4F5F651ACCC9C4CF
	static void SET_PED_CAN_ARM_IK(Ped ped, BOOL toggle) { invoke<Void>(0x6C3B4D6D13B4C841, ped, toggle); } // 0x6C3B4D6D13B4C841
	static void SET_PED_CAN_BE_DRAGGED_OUT(Ped ped, BOOL toggle) { invoke<Void>(0xC1670E958EEE24E5, ped, toggle); } // 0xC1670E958EEE24E5
	static void SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE(Ped ped, int state) { invoke<Void>(0x7A6535691B477C48, ped, state); } // 0x7A6535691B477C48
	static void SET_PED_CAN_BE_SHOT_IN_VEHICLE(Ped ped, BOOL toggle) { invoke<Void>(0xC7EF1BA83230BA07, ped, toggle); } // 0xC7EF1BA83230BA07
	static void SET_PED_CAN_BE_TARGETED_WHEN_INJURED(Ped ped, BOOL toggle) { invoke<Void>(0x638C03B0F9878F57, ped, toggle); } // 0x638C03B0F9878F57
	static void SET_PED_CAN_BE_TARGETED_WITHOUT_LOS(Ped ped, BOOL toggle) { invoke<Void>(0x4328652AE5769C71, ped, toggle); } // 0x4328652AE5769C71
	static void SET_PED_CAN_BE_TARGETTED(Ped ped, BOOL toggle) { invoke<Void>(0x63F58F7C80513AAD, ped, toggle); } // 0x63F58F7C80513AAD
	static void SET_PED_CAN_BE_TARGETTED_BY_PLAYER(Ped ped, Player player, BOOL toggle) { invoke<Void>(0x66B57B72E0836A76, ped, player, toggle); } // 0x66B57B72E0836A76
	static void SET_PED_CAN_BE_TARGETTED_BY_TEAM(Ped ped, int team, BOOL toggle) { invoke<Void>(0xBF1CA77833E58F2C, ped, team, toggle); } // 0xBF1CA77833E58F2C
	static void SET_PED_CAN_COWER_IN_COVER(Ped ped, BOOL toggle) { invoke<Void>(0xCB7553CDCEF4A735, ped, toggle); } // 0xCB7553CDCEF4A735
	static void SET_PED_CAN_EVASIVE_DIVE(Ped ped, BOOL toggle) { invoke<Void>(0x6B7A646C242A7059, ped, toggle); } // 0x6B7A646C242A7059
	static void SET_PED_CAN_HEAD_IK(Ped ped, BOOL toggle) { invoke<Void>(0xC11C18092C5530DC, ped, toggle); } // 0xC11C18092C5530DC
	static void SET_PED_CAN_LEG_IK(Ped ped, BOOL toggle) { invoke<Void>(0x73518ECE2485412B, ped, toggle); } // 0x73518ECE2485412B
	static void SET_PED_CAN_PEEK_IN_COVER(Ped ped, BOOL toggle) { invoke<Void>(0xC514825C507E3736, ped, toggle); } // 0xC514825C507E3736
	static void SET_PED_CAN_PLAY_AMBIENT_ANIMS(Ped ped, BOOL toggle) { invoke<Void>(0x6373D1349925A70E, ped, toggle); } // 0x6373D1349925A70E
	static void SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS(Ped ped, BOOL toggle) { invoke<Void>(0xEB0585D15254740, ped, toggle); } // 0xEB0585D15254740
	static void SET_PED_CAN_PLAY_GESTURE_ANIMS(Ped ped, BOOL toggle) { invoke<Void>(0xBAF20C5432058024, ped, toggle); } // 0xBAF20C5432058024
	static void _SET_PED_CAN_PLAY_INJURED_ANIMS(Ped ped, BOOL p1) { invoke<Void>(0x33A60D8BDD6E508C, ped, p1); } // 0x33A60D8BDD6E508C
	static void SET_PED_CAN_PLAY_VISEME_ANIMS(Ped ped, BOOL toggle, BOOL p2) { invoke<Void>(0xF833DDBA3B104D43, ped, toggle, p2); } // 0xF833DDBA3B104D43
	static void SET_PED_CAN_RAGDOLL(Ped ped, BOOL toggle) { invoke<Void>(0xB128377056A54E2A, ped, toggle); } // 0xB128377056A54E2A
	static void SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT(Ped ped, BOOL toggle) { invoke<Void>(0xDF993EE5E90ABA25, ped, toggle); } // 0xDF993EE5E90ABA25
	static void SET_PED_CAN_SMASH_GLASS(Ped ped, BOOL p1, BOOL p2) { invoke<Void>(0x1CCE141467FF42A2, ped, p1, p2); } // 0x1CCE141467FF42A2
	static void SET_PED_CAN_SWITCH_WEAPON(Ped ped, BOOL toggle) { invoke<Void>(0xED7F7EFE9FABF340, ped, toggle); } // 0xED7F7EFE9FABF340
	static void SET_PED_CAN_TELEPORT_TO_GROUP_LEADER(Ped pedHandle, int groupHandle, BOOL toggle) { invoke<Void>(0x2E2F4240B3F24647, pedHandle, groupHandle, toggle); } // 0x2E2F4240B3F24647
	static void SET_PED_CAN_TORSO_IK(Ped ped, BOOL toggle) { invoke<Void>(0xF2B7106D37947CE0, ped, toggle); } // 0xF2B7106D37947CE0
	static void SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT(Ped ped, BOOL toggle) { invoke<Void>(0xEC4686EC06434678, ped, toggle); } // 0xEC4686EC06434678
	static void SET_PED_CAPSULE(Ped ped, float value) { invoke<Void>(0x364DF566EC833DE2, ped, value); } // 0x364DF566EC833DE2
	static void SET_PED_CLOTH_PRONE(Any p0, Any p1) { invoke<Void>(0x82A3D6D9CC2CB8E3, p0, p1); } // 0x82A3D6D9CC2CB8E3
	static void SET_PED_COMBAT_ABILITY(Ped ped, int p1) { invoke<Void>(0xC7622C0D36B2FDA8, ped, p1); } // 0xC7622C0D36B2FDA8
	static void SET_PED_COMBAT_ATTRIBUTES(Ped ped, int attributeIndex, BOOL enabled) { invoke<Void>(0x9F7794730795E019, ped, attributeIndex, enabled); } // 0x9F7794730795E019
	static void SET_PED_COMBAT_MOVEMENT(Ped ped, int combatMovement) { invoke<Void>(0x4D9CA1009AFBD057, ped, combatMovement); } // 0x4D9CA1009AFBD057
	static void SET_PED_COMBAT_RANGE(Ped ped, int p1) { invoke<Void>(0x3C606747B23E497B, ped, p1); } // 0x3C606747B23E497B
	static void SET_PED_COMPONENT_VARIATION(Ped ped, int componentId, int drawableId, int textureId, int paletteId) { invoke<Void>(0x262B14F48D29DE80, ped, componentId, drawableId, textureId, paletteId); } // 0x262B14F48D29DE80
	static void SET_PED_CONFIG_FLAG(Ped ped, int flagId, BOOL value) { invoke<Void>(0x1913FE4CBF41C463, ped, flagId, value); } // 0x1913FE4CBF41C463
	static void SET_PED_COORDS_KEEP_VEHICLE(Ped ped, float posX, float posY, float posZ) { invoke<Void>(0x9AFEFF481A85AB2E, ped, posX, posY, posZ); } // 0x9AFEFF481A85AB2E
	static void SET_PED_COORDS_NO_GANG(Ped ped, float posX, float posY, float posZ) { invoke<Void>(0x87052FE446E07247, ped, posX, posY, posZ); } // 0x87052FE446E07247
	static void SET_PED_COWER_HASH(Ped ped, char* p1) { invoke<Void>(0xA549131166868ED3, ped, p1); } // 0xA549131166868ED3
	static void _SET_PED_DECORATION(Ped ped, Hash collection, Hash overlay) { invoke<Void>(0x5F5D1665E352A839, ped, collection, overlay); } // 0x5F5D1665E352A839
	static void SET_PED_DEFAULT_COMPONENT_VARIATION(Ped ped) { invoke<Void>(0x45EEE61580806D63, ped); } // 0x45EEE61580806D63
	static void SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED(Ped ped, Ped attachPed, float p2, float p3, float p4, float p5, float p6, float p7, float p8, BOOL p9, BOOL p10) { invoke<Void>(0x4EF47FE21698A8B6, ped, attachPed, p2, p3, p4, p5, p6, p7, p8, p9, p10); } // 0x4EF47FE21698A8B6
	static void SET_PED_DEFENSIVE_AREA_DIRECTION(Ped ped, float p1, float p2, float p3, BOOL p4) { invoke<Void>(0x413C6C763A4AFFAD, ped, p1, p2, p3, p4); } // 0x413C6C763A4AFFAD
	static void SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_PED(Ped ped, Ped target, float xOffset, float yOffset, float zOffset, float radius, BOOL p6) { invoke<Void>(0xF9B8F91AAD3B953E, ped, target, xOffset, yOffset, zOffset, radius, p6); } // 0xF9B8F91AAD3B953E
	static void SET_PED_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { invoke<Void>(0x95E3D6257B166CF2, multiplier); } // 0x95E3D6257B166CF2
	static void SET_PED_DESIRED_HEADING(Ped ped, float heading) { invoke<Void>(0xAA5A7ECE2AA8FE70, ped, heading); } // 0xAA5A7ECE2AA8FE70
	static void SET_PED_DIES_IN_SINKING_VEHICLE(Ped ped, BOOL toggle) { invoke<Void>(0xD718A22995E2B4BC, ped, toggle); } // 0xD718A22995E2B4BC
	static void SET_PED_DIES_INSTANTLY_IN_WATER(Ped ped, BOOL toggle) { invoke<Void>(0xEEB64139BA29A7CF, ped, toggle); } // 0xEEB64139BA29A7CF
	static void SET_PED_DIES_IN_VEHICLE(Ped ped, BOOL toggle) { invoke<Void>(0x2A30922C90C9B42C, ped, toggle); } // 0x2A30922C90C9B42C
	static void SET_PED_DIES_IN_WATER(Ped ped, BOOL toggle) { invoke<Void>(0x56CEF0AC79073BDE, ped, toggle); } // 0x56CEF0AC79073BDE
	static Any SET_PED_DIES_WHEN_INJURED(Ped ped, BOOL toggle) { return invoke<Any>(0x5BA7919BED300023, ped, toggle); } // 0x5BA7919BED300023
	static void SET_PED_DRIVE_BY_CLIPSET_OVERRIDE(Ped ped, char* clipset) { invoke<Void>(0xED34AB6C5CB36520, ped, clipset); } // 0xED34AB6C5CB36520
	static void SET_PED_DUCKING(Ped ped, BOOL toggle) { invoke<Void>(0x30983CA930B692D, ped, toggle); } // 0x30983CA930B692D
	static Any SET_PED_ENABLE_WEAPON_BLOCKING(Ped ped, BOOL toggle) { return invoke<Any>(0x97A790315D3831FD, ped, toggle); } // 0x97A790315D3831FD
	static void SET_PED_ENVEFF_SCALE(Ped ped, float value) { invoke<Void>(0xBF29516833893561, ped, value); } // 0xBF29516833893561
	static void _SET_PED_EYE_COLOR(Ped ped, int index) { invoke<Void>(0x50B56988B170AFDF, ped, index); } // 0x50B56988B170AFDF
	static void _SET_PED_FACE_FEATURE(Ped ped, int index, float scale) { invoke<Void>(0x71A5C1DBA060049E, ped, index, scale); } // 0x71A5C1DBA060049E
	static void _SET_PED_FACIAL_DECORATION(Ped ped, Hash collection, Hash overlay) { invoke<Void>(0x5619BFA07CFD7833, ped, collection, overlay); } // 0x5619BFA07CFD7833
	static void SET_PED_FIRING_PATTERN(Ped ped, Hash patternHash) { invoke<Void>(0x9AC577F5A12AD8A9, ped, patternHash); } // 0x9AC577F5A12AD8A9
	static void SET_PED_FLEE_ATTRIBUTES(Ped ped, int attributes, BOOL p2) { invoke<Void>(0x70A2D1137C8ED7C9, ped, attributes, p2); } // 0x70A2D1137C8ED7C9
	static void SET_PED_GENERATES_DEAD_BODY_EVENTS(Ped ped, BOOL toggle) { invoke<Void>(0x7FB17BA2E7DECA5B, ped, toggle); } // 0x7FB17BA2E7DECA5B
	static void SET_PED_GESTURE_GROUP(Ped ped, char* animGroupGesture) { invoke<Void>(0xDDF803377F94AAA8, ped, animGroupGesture); } // 0xDDF803377F94AAA8
	static void SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE(Ped ped, BOOL toggle) { invoke<Void>(0xBC0ED94165A48BC2, ped, toggle); } // 0xBC0ED94165A48BC2
	static void SET_PED_GRAVITY(Ped ped, BOOL toggle) { invoke<Void>(0x9FF447B6B6AD960A, ped, toggle); } // 0x9FF447B6B6AD960A
	static void SET_PED_GROUP_MEMBER_PASSENGER_INDEX(Ped ped, int index) { invoke<Void>(0xBDDB8D9EC6BCF3C, ped, index); } // 0xBDDB8D9EC6BCF3C
	static void _SET_PED_HAIR_COLOR(Ped ped, int colorID, int highlightColorID) { invoke<Void>(0x4CFFC65454C93A49, ped, colorID, highlightColorID); } // 0x4CFFC65454C93A49
	static void SET_PED_HEAD_BLEND_DATA(Ped ped, int shapeFirstID, int shapeSecondID, int shapeThirdID, int skinFirstID, int skinSecondID, int skinThirdID, float shapeMix, float skinMix, float thirdMix, BOOL isParent) { invoke<Void>(0x9414E18B9434C2FE, ped, shapeFirstID, shapeSecondID, shapeThirdID, skinFirstID, skinSecondID, skinThirdID, shapeMix, skinMix, thirdMix, isParent); } // 0x9414E18B9434C2FE
	static void SET_PED_HEAD_OVERLAY(Ped ped, int overlayID, int index, float opacity) { invoke<Void>(0x48F44967FA05CC1E, ped, overlayID, index, opacity); } // 0x48F44967FA05CC1E
	static void _SET_PED_HEAD_OVERLAY_COLOR(Ped ped, int overlayID, int colorType, int colorID, int secondColorID) { invoke<Void>(0x497BF74A7B9CB952, ped, overlayID, colorType, colorID, secondColorID); } // 0x497BF74A7B9CB952
	static void SET_PED_HEARING_RANGE(Ped ped, float value) { invoke<Void>(0x33A8F7F7D5F7F33C, ped, value); } // 0x33A8F7F7D5F7F33C
	static void SET_PED_HELMET(Ped ped, BOOL canWearHelmet) { invoke<Void>(0x560A43136EB58105, ped, canWearHelmet); } // 0x560A43136EB58105
	static void SET_PED_HELMET_FLAG(Ped ped, int helmetFlag) { invoke<Void>(0xC0E78D5C2CE3EB25, ped, helmetFlag); } // 0xC0E78D5C2CE3EB25
	static void SET_PED_HELMET_PROP_INDEX(Ped ped, int propIndex) { invoke<Void>(0x26D83693ED99291C, ped, propIndex); } // 0x26D83693ED99291C
	static void SET_PED_HELMET_TEXTURE_INDEX(Ped ped, int textureIndex) { invoke<Void>(0xF1550C4BD22582E2, ped, textureIndex); } // 0xF1550C4BD22582E2
	static void SET_PED_ID_RANGE(Ped ped, float value) { invoke<Void>(0xF107E836A70DCE05, ped, value); } // 0xF107E836A70DCE05
	static void _SET_PED_ILLUMINATED_CLOTHING_GLOW_INTENSITY(Ped ped, float intensity) { invoke<Void>(0x4E90D746056E273D, ped, intensity); } // 0x4E90D746056E273D
	static void SET_PED_INTO_VEHICLE(Ped ped, Vehicle vehicle, int seatIndex) { invoke<Void>(0xF75B0D629E1C063D, ped, vehicle, seatIndex); } // 0xF75B0D629E1C063D
	static void SET_PED_IN_VEHICLE_CONTEXT(Ped ped, Hash context) { invoke<Void>(0x530071295899A8C6, ped, context); } // 0x530071295899A8C6
	static void SET_PED_KEEP_TASK(Ped ped, BOOL toggle) { invoke<Void>(0x971D38760FBC02EF, ped, toggle); } // 0x971D38760FBC02EF
	static void SET_PED_LEG_IK_MODE(Ped ped, int mode) { invoke<Void>(0xC396F5B86FF9FEBD, ped, mode); } // 0xC396F5B86FF9FEBD
	static void SET_PED_LOD_MULTIPLIER(Ped ped, float multiplier) { invoke<Void>(0xDC2C5C242AAC342B, ped, multiplier); } // 0xDC2C5C242AAC342B
	static void SET_PED_MAX_HEALTH(Ped ped, int value) { invoke<Void>(0xF5F6378C4F3419D3, ped, value); } // 0xF5F6378C4F3419D3
	static void SET_PED_MAX_MOVE_BLEND_RATIO(Ped ped, float value) { invoke<Void>(0x433083750C5E064A, ped, value); } // 0x433083750C5E064A
	static void SET_PED_MAX_TIME_IN_WATER(Ped ped, float value) { invoke<Void>(0x43C851690662113D, ped, value); } // 0x43C851690662113D
	static void SET_PED_MAX_TIME_UNDERWATER(Ped ped, float value) { invoke<Void>(0x6BA428C528D9E522, ped, value); } // 0x6BA428C528D9E522
	static void SET_PED_MIN_GROUND_TIME_FOR_STUNGUN(Ped ped, int ms) { invoke<Void>(0xFA0675AB151073FA, ped, ms); } // 0xFA0675AB151073FA
	static void SET_PED_MIN_MOVE_BLEND_RATIO(Ped ped, float value) { invoke<Void>(0x1A898D26E2333DD, ped, value); } // 0x1A898D26E2333DD
	static void SET_PED_MODEL_IS_SUPPRESSED(Ped ped, BOOL toggle) { invoke<Void>(0xE163A4BCE4DE6F11, ped, toggle); } // 0xE163A4BCE4DE6F11
	static void SET_PED_MONEY(Ped ped, int amount) { invoke<Void>(0xA9C8960E8684C1B5, ped, amount); } // 0xA9C8960E8684C1B5
	static void SET_PED_MOTION_BLUR(Ped ped, BOOL toggle) { invoke<Void>(0xA986918B102B448, ped, toggle); } // 0xA986918B102B448
	static void SET_PED_MOVE_ANIMS_BLEND_OUT(Ped ped) { invoke<Void>(0x9E8C908F41584ECD, ped); } // 0x9E8C908F41584ECD
	static void SET_PED_MOVEMENT_CLIPSET(Ped ped, char* clipSet, float p2) { invoke<Void>(0xAF8A94EDE7712BEF, ped, clipSet, p2); } // 0xAF8A94EDE7712BEF
	static void SET_PED_MOVE_RATE_OVERRIDE(Ped ped, float value) { invoke<Void>(0x85BF80FA50A39D1, ped, value); } // 0x85BF80FA50A39D1
	static void SET_PED_NAME_DEBUG(Ped ped, char* name) { invoke<Void>(0x98EFA132A4117BE1, ped, name); } // 0x98EFA132A4117BE1
	static void SET_PED_NEVER_LEAVES_GROUP(Ped ped, BOOL toggle) { invoke<Void>(0x3DBFC55D5C9BB447, ped, toggle); } // 0x3DBFC55D5C9BB447
	static void SET_PED_NON_CREATION_AREA(float x1, float y1, float z1, float x2, float y2, float z2) { invoke<Void>(0xEE01041D559983EA, x1, y1, z1, x2, y2, z2); } // 0xEE01041D559983EA
	static void SET_PED_PARACHUTE_TINT_INDEX(Ped ped, int tintIndex) { invoke<Void>(0x333FC8DB079B7186, ped, tintIndex); } // 0x333FC8DB079B7186
	static Any SET_PED_PINNED_DOWN(Ped ped, BOOL pinned, int p2) { return invoke<Any>(0xAAD6D1ACF08F4612, ped, pinned, p2); } // 0xAAD6D1ACF08F4612
	static void SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE(Ped ped, BOOL toggle) { invoke<Void>(0x94D94BF1A75AED3D, ped, toggle); } // 0x94D94BF1A75AED3D
	static void SET_PED_PREFERRED_COVER_SET(Ped ped, Any itemSet) { invoke<Void>(0x8421EB4DA7E391B9, ped, itemSet); } // 0x8421EB4DA7E391B9
	static void SET_PED_PRIMARY_LOOKAT(Ped ped, Ped lookAt) { invoke<Void>(0xCD17B554996A8D9E, ped, lookAt); } // 0xCD17B554996A8D9E
	static void SET_PED_PROP_INDEX(Ped ped, int componentId, int drawableId, int TextureId, BOOL attach) { invoke<Void>(0x93376B65A266EB5F, ped, componentId, drawableId, TextureId, attach); } // 0x93376B65A266EB5F
	static void _SET_PED_RAGDOLL_BLOCKING_FLAGS(Ped ped, int flags) { invoke<Void>(0x26695EC767728D84, ped, flags); } // 0x26695EC767728D84
	static Any SET_PED_RAGDOLL_FORCE_FALL(Ped ped) { return invoke<Any>(0x1F6594B923B9251, ped); } // 0x1F6594B923B9251
	static void SET_PED_RAGDOLL_ON_COLLISION(Ped ped, BOOL toggle) { invoke<Void>(0xF0A4F1BBF4FA7497, ped, toggle); } // 0xF0A4F1BBF4FA7497
	static void SET_PED_RANDOM_COMPONENT_VARIATION(Ped ped, BOOL p1) { invoke<Void>(0xC8A9481A01E63C28, ped, p1); } // 0xC8A9481A01E63C28
	static void SET_PED_RANDOM_PROPS(Ped ped) { invoke<Void>(0xC44AA05345C992C6, ped); } // 0xC44AA05345C992C6
	static void SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(Ped ped, Hash hash) { invoke<Void>(0xADB3F206518799E8, ped, hash); } // 0xADB3F206518799E8
	static void SET_PED_RELATIONSHIP_GROUP_HASH(Ped ped, Hash hash) { invoke<Void>(0xC80A74AC829DDD92, ped, hash); } // 0xC80A74AC829DDD92
	static void SET_PED_RESERVE_PARACHUTE_TINT_INDEX(Ped ped, Any p1) { invoke<Void>(0xE88DA0751C22A2AD, ped, p1); } // 0xE88DA0751C22A2AD
	static void SET_PED_RESET_FLAG(Ped ped, int flagId, BOOL doReset) { invoke<Void>(0xC1E8A365BF3B29F2, ped, flagId, doReset); } // 0xC1E8A365BF3B29F2
	static void SET_PED_SEEING_RANGE(Ped ped, float value) { invoke<Void>(0xF29CF591C4BF6CEE, ped, value); } // 0xF29CF591C4BF6CEE
	static void SET_PED_SHOOT_RATE(Ped ped, int shootRate) { invoke<Void>(0x614DA022990752DC, ped, shootRate); } // 0x614DA022990752DC
	static void SET_PED_SHOOTS_AT_COORD(Ped ped, float x, float y, float z, BOOL toggle) { invoke<Void>(0x96A05E4FB321B1BA, ped, x, y, z, toggle); } // 0x96A05E4FB321B1BA
	static void SET_PED_SPHERE_DEFENSIVE_AREA(Ped ped, float x, float y, float z, float radius, BOOL p5, BOOL p6) { invoke<Void>(0x9D3151A373974804, ped, x, y, z, radius, p5, p6); } // 0x9D3151A373974804
	static void SET_PED_STAY_IN_VEHICLE_WHEN_JACKED(Ped ped, BOOL toggle) { invoke<Void>(0xEDF4079F9D54C9A1, ped, toggle); } // 0xEDF4079F9D54C9A1
	static void SET_PED_STEALTH_MOVEMENT(Ped ped, BOOL p1, char* action) { invoke<Void>(0x88CBB5CEB96B7BD2, ped, p1, action); } // 0x88CBB5CEB96B7BD2
	static void SET_PED_STEERS_AROUND_OBJECTS(Ped ped, BOOL toggle) { invoke<Void>(0x1509C089ADC208BF, ped, toggle); } // 0x1509C089ADC208BF
	static void SET_PED_STEERS_AROUND_PEDS(Ped ped, BOOL toggle) { invoke<Void>(0x46F2193B3AD1D891, ped, toggle); } // 0x46F2193B3AD1D891
	static void SET_PED_STEERS_AROUND_VEHICLES(Ped ped, BOOL toggle) { invoke<Void>(0xEB6FB9D48DDE23EC, ped, toggle); } // 0xEB6FB9D48DDE23EC
	static void SET_PED_STRAFE_CLIPSET(Ped ped, char* clipSet) { invoke<Void>(0x29A28F3F8CF6D854, ped, clipSet); } // 0x29A28F3F8CF6D854
	static void SET_PED_SUFFERS_CRITICAL_HITS(Ped ped, BOOL toggle) { invoke<Void>(0xEBD76F2359F190AC, ped, toggle); } // 0xEBD76F2359F190AC
	static void SET_PED_SWEAT(Ped ped, float sweat) { invoke<Void>(0x27B0405F59637D1F, ped, sweat); } // 0x27B0405F59637D1F
	static void SET_PED_TARGET_LOSS_RESPONSE(Ped ped, int responseType) { invoke<Void>(0x703B9079823DA4A, ped, responseType); } // 0x703B9079823DA4A
	static void SET_PED_TO_INFORM_RESPECTED_FRIENDS(Ped ped, float radius, int maxFriends) { invoke<Void>(0x112942C6E708F70B, ped, radius, maxFriends); } // 0x112942C6E708F70B
	static void SET_PED_TO_LOAD_COVER(Ped ped, BOOL toggle) { invoke<Void>(0x332B562EEDA62399, ped, toggle); } // 0x332B562EEDA62399
	static BOOL SET_PED_TO_RAGDOLL(Ped ped, int time1, int time2, int ragdollType, BOOL p4, BOOL p5, BOOL p6) { return invoke<BOOL>(0xAE99FB955581844A, ped, time1, time2, ragdollType, p4, p5, p6); } // 0xAE99FB955581844A
	static BOOL SET_PED_TO_RAGDOLL_WITH_FALL(Ped ped, int time, int p2, int ragdollType, float x, float y, float z, float p7, float p8, float p9, float p10, float p11, float p12, float p13) { return invoke<BOOL>(0xD76632D99E4966C8, ped, time, p2, ragdollType, x, y, z, p7, p8, p9, p10, p11, p12, p13); } // 0xD76632D99E4966C8
	static void SET_PED_USING_ACTION_MODE(Ped ped, BOOL p1, Any p2, char* action) { invoke<Void>(0xD75ACCF5E0FB5367, ped, p1, p2, action); } // 0xD75ACCF5E0FB5367
	static void SET_PED_VISUAL_FIELD_CENTER_ANGLE(Ped ped, float angle) { invoke<Void>(0x3B6405E8AB34A907, ped, angle); } // 0x3B6405E8AB34A907
	static void SET_PED_VISUAL_FIELD_MAX_ANGLE(Ped ped, float value) { invoke<Void>(0x70793BDCA1E854D4, ped, value); } // 0x70793BDCA1E854D4
	static void SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE(Ped ped, float angle) { invoke<Void>(0x78D0B67629D75856, ped, angle); } // 0x78D0B67629D75856
	static void SET_PED_VISUAL_FIELD_MIN_ANGLE(Ped ped, float value) { invoke<Void>(0x2DB492222FB21E26, ped, value); } // 0x2DB492222FB21E26
	static void SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE(Ped ped, float angle) { invoke<Void>(0x7A276EB2C224D70F, ped, angle); } // 0x7A276EB2C224D70F
	static void SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE(Ped ped, float range) { invoke<Void>(0x9C74B0BC831B753A, ped, range); } // 0x9C74B0BC831B753A
	static void SET_PED_WEAPON_MOVEMENT_CLIPSET(Ped ped, char* clipSet) { invoke<Void>(0x2622E35B77D3ACA2, ped, clipSet); } // 0x2622E35B77D3ACA2
	static void SET_PED_WETNESS_ENABLED_THIS_FRAME(Ped ped) { invoke<Void>(0xB5485E4907B53019, ped); } // 0xB5485E4907B53019
	static void SET_PED_WETNESS_HEIGHT(Ped ped, float height) { invoke<Void>(0x44CB6447D2571AA0, ped, height); } // 0x44CB6447D2571AA0
	static void SET_RELATIONSHIP_BETWEEN_GROUPS(int relationship, Hash group1, Hash group2) { invoke<Void>(0xBF25EB89375A37AD, relationship, group1, group2); } // 0xBF25EB89375A37AD
	static void SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME(float p0, float p1) { invoke<Void>(0x7A556143A1C03898, p0, p1); } // 0x7A556143A1C03898
	static void SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA(float x, float y, float z, float range, int p4) { invoke<Void>(0x28157D43CF600981, x, y, z, range, p4); } // 0x28157D43CF600981
	static void SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND(BOOL value) { invoke<Void>(0x14F19A8782C8071E, value); } // 0x14F19A8782C8071E
	static void SET_SCRIPTED_ANIM_SEAT_OFFSET(Ped ped, float p1) { invoke<Void>(0x5917BBA32D06C230, ped, p1); } // 0x5917BBA32D06C230
	static void SET_SCRIPTED_CONVERSION_COORD_THIS_FRAME(float x, float y, float z) { invoke<Void>(0x5086C7843552CF85, x, y, z); } // 0x5086C7843552CF85
	static void SET_SYNCHRONIZED_SCENE_LOOPED(int sceneID, BOOL toggle) { invoke<Void>(0xD9A897A4C6C2974F, sceneID, toggle); } // 0xD9A897A4C6C2974F
	static void _SET_SYNCHRONIZED_SCENE_OCCLUSION_PORTAL(Any sceneID, BOOL p1) { invoke<Void>(0x394B9CD12435C981, sceneID, p1); } // 0x394B9CD12435C981
	static void SET_SYNCHRONIZED_SCENE_ORIGIN(int sceneID, float x, float y, float z, float roll, float pitch, float yaw, BOOL p7) { invoke<Void>(0x6ACF6B7225801CD7, sceneID, x, y, z, roll, pitch, yaw, p7); } // 0x6ACF6B7225801CD7
	static void SET_SYNCHRONIZED_SCENE_PHASE(int sceneID, float phase) { invoke<Void>(0x734292F4F0ABF6D0, sceneID, phase); } // 0x734292F4F0ABF6D0
	static void SET_SYNCHRONIZED_SCENE_RATE(int sceneID, float rate) { invoke<Void>(0xB6C49F8A5E295A5D, sceneID, rate); } // 0xB6C49F8A5E295A5D
	static void SET_TIME_EXCLUSIVE_DISPLAY_TEXTURE(Any p0, BOOL p1) { invoke<Void>(0xFD325494792302D7, p0, p1); } // 0xFD325494792302D7
	static void STOP_ANY_PED_MODEL_BEING_SUPPRESSED() { invoke<Void>(0xB47BD05FA66B40CF); } // 0xB47BD05FA66B40CF
	static void STOP_PED_WEAPON_FIRING_WHEN_DROPPED(Ped ped) { invoke<Void>(0xC158D28142A34608, ped); } // 0xC158D28142A34608
	static void UNREGISTER_PEDHEADSHOT(int handle) { invoke<Void>(0x96B1361D9B24C2FF, handle); } // 0x96B1361D9B24C2FF
	static void UPDATE_PED_HEAD_BLEND_DATA(Ped ped, float shapeMix, float skinMix, float thirdMix) { invoke<Void>(0x723538F61C647C5A, ped, shapeMix, skinMix, thirdMix); } // 0x723538F61C647C5A
	static BOOL WAS_PED_KILLED_BY_STEALTH(Ped ped) { return invoke<BOOL>(0xF9800AA1A771B000, ped); } // 0xF9800AA1A771B000
	static BOOL WAS_PED_KILLED_BY_TAKEDOWN(Ped ped) { return invoke<BOOL>(0x7F08E26039C7347C, ped); } // 0x7F08E26039C7347C
	static BOOL WAS_PED_SKELETON_UPDATED(Ped ped) { return invoke<BOOL>(0x11B499C1E0FF8559, ped); } // 0x11B499C1E0FF8559
}

namespace PHYSICS
{
	static void ACTIVATE_PHYSICS(Entity entity) { invoke<Void>(0x710311ADF0E20730, entity); } // 0x710311ADF0E20730
	static Object ADD_ROPE(float x, float y, float z, float rotX, float rotY, float rotZ, float length, int ropeType, float maxLength, float minLength, float p10, BOOL p11, BOOL p12, BOOL rigid, float p14, BOOL breakWhenShot, Any* unkPtr) { return invoke<Object>(0xE832D760399EB220, x, y, z, rotX, rotY, rotZ, length, ropeType, maxLength, minLength, p10, p11, p12, rigid, p14, breakWhenShot, unkPtr); } // 0xE832D760399EB220
	static void APPLY_IMPULSE_TO_CLOTH(float posX, float posY, float posZ, float vecX, float vecY, float vecZ, float impulse) { invoke<Void>(0xE37F721824571784, posX, posY, posZ, vecX, vecY, vecZ, impulse); } // 0xE37F721824571784
	static void ATTACH_ENTITIES_TO_ROPE(Object rope, Entity ent1, Entity ent2, float ent1_x, float ent1_y, float ent1_z, float ent2_x, float ent2_y, float ent2_z, float length, BOOL p10, BOOL p11, char* boneName1, char* boneName2) { invoke<Void>(0x3D95EC8B6D940AC3, rope, ent1, ent2, ent1_x, ent1_y, ent1_z, ent2_x, ent2_y, ent2_z, length, p10, p11, boneName1, boneName2); } // 0x3D95EC8B6D940AC3
	static void ATTACH_ROPE_TO_ENTITY(Object rope, Entity entity, float x, float y, float z, BOOL p5) { invoke<Void>(0x4B490A6832559A65, rope, entity, x, y, z, p5); } // 0x4B490A6832559A65
	static void BREAK_ENTITY_GLASS(Any p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, Any p9, BOOL p10) { invoke<Void>(0x2E648D16F6E308F3, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); } // 0x2E648D16F6E308F3
	static Any DELETE_CHILD_ROPE(Object rope) { return invoke<Any>(0xAA5D6B1888E4DB20, rope); } // 0xAA5D6B1888E4DB20
	static void DELETE_ROPE(Object* rope) { invoke<Void>(0x52B4829281364649, rope); } // 0x52B4829281364649
	static void DETACH_ROPE_FROM_ENTITY(Object rope, Entity entity) { invoke<Void>(0xBCF3026912A8647D, rope, entity); } // 0xBCF3026912A8647D
	static BOOL DOES_ROPE_EXIST(Object* rope) { return invoke<BOOL>(0xFD5448BE3111ED96, rope); } // 0xFD5448BE3111ED96
	static Vector3 GET_CGOFFSET(Object rope) { return invoke<Vector3>(0x8214A4B5A7A33612, rope); } // 0x8214A4B5A7A33612
	static Any GET_ROPE_LAST_VERTEX_COORD(Object rope) { return invoke<Any>(0x21BB0FBD3E217C2D, rope); } // 0x21BB0FBD3E217C2D
	static float _GET_ROPE_LENGTH(Object rope) { return invoke<float>(0x73040398DFF9A4A6, rope); } // 0x73040398DFF9A4A6
	static Vector3 GET_ROPE_VERTEX_COORD(Object rope, int vertex) { return invoke<Vector3>(0xEA61CA8E80F09E4D, rope, vertex); } // 0xEA61CA8E80F09E4D
	static int GET_ROPE_VERTEX_COUNT(Object rope) { return invoke<int>(0x3655F544CD30F0B5, rope); } // 0x3655F544CD30F0B5
	static Any LOAD_ROPE_DATA(Object rope, char* rope_preset) { return invoke<Any>(0xCBB203C04D1ABD27, rope, rope_preset); } // 0xCBB203C04D1ABD27
	static Any _0x0C112765300C7E1E(Any p0) { return invoke<Any>(0xC112765300C7E1E, p0); } // 0xC112765300C7E1E
	static void _0x15F944730C832252(Any p0, Any p1) { invoke<Void>(0x15F944730C832252, p0, p1); } // 0x15F944730C832252
	static BOOL _0x271C9D3ACA5D6409(Object rope) { return invoke<BOOL>(0x271C9D3ACA5D6409, rope); } // 0x271C9D3ACA5D6409
	static void _0x36CCB9BE67B970FD(Any p0, BOOL p1) { invoke<Void>(0x36CCB9BE67B970FD, p0, p1); } // 0x36CCB9BE67B970FD
	static BOOL _0x84DE3B5FB3E666F0(Any* p0) { return invoke<BOOL>(0x84DE3B5FB3E666F0, p0); } // 0x84DE3B5FB3E666F0
	static void _0x9EBD751E5787BAF2(Any p0) { invoke<Void>(0x9EBD751E5787BAF2, p0); } // 0x9EBD751E5787BAF2
	static void _0xB1B6216CA2E7B55E(Any p0, BOOL p1, BOOL p2) { invoke<Void>(0xB1B6216CA2E7B55E, p0, p1, p2); } // 0xB1B6216CA2E7B55E
	static void _0xB743F735C03D7810(Any p0, Any p1) { invoke<Void>(0xB743F735C03D7810, p0, p1); } // 0xB743F735C03D7810
	static void _0xBC0CE682D4D05650(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13) { invoke<Void>(0xBC0CE682D4D05650, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13); } // 0xBC0CE682D4D05650
	static void _0xCC6E963682533882(Any p0) { invoke<Void>(0xCC6E963682533882, p0); } // 0xCC6E963682533882
	static void _0xDC57A637A20006ED(Any p0, Any p1) { invoke<Void>(0xDC57A637A20006ED, p0, p1); } // 0xDC57A637A20006ED
	static void PIN_ROPE_VERTEX(Object rope, int vertex, float x, float y, float z) { invoke<Void>(0x2B320CF14146B69A, rope, vertex, x, y, z); } // 0x2B320CF14146B69A
	static BOOL ROPE_ARE_TEXTURES_LOADED() { return invoke<BOOL>(0xF2D0E6A75CC05597); } // 0xF2D0E6A75CC05597
	static void ROPE_CONVERT_TO_SIMPLE(Object rope) { invoke<Void>(0x5389D48EFA2F079A, rope); } // 0x5389D48EFA2F079A
	static void ROPE_DRAW_SHADOW_ENABLED(Object* rope, BOOL toggle) { invoke<Void>(0xF159A63806BB5BA8, rope, toggle); } // 0xF159A63806BB5BA8
	static Any ROPE_FORCE_LENGTH(Object rope, float length) { return invoke<Any>(0xD009F759A723DB1B, rope, length); } // 0xD009F759A723DB1B
	static Any ROPE_LOAD_TEXTURES() { return invoke<Any>(0x9B9039DBF2D258C1); } // 0x9B9039DBF2D258C1
	static void ROPE_RESET_LENGTH(Object rope, float length) { invoke<Void>(0xC16DE94D9BEA14A0, rope, length); } // 0xC16DE94D9BEA14A0
	static void ROPE_SET_UPDATE_PINVERTS(Object rope) { invoke<Void>(0xC8D667EE52114ABA, rope); } // 0xC8D667EE52114ABA
	static Any ROPE_UNLOAD_TEXTURES() { return invoke<Any>(0x6CE36C35C1AC8163); } // 0x6CE36C35C1AC8163
	static void SET_CG_AT_BOUNDCENTER(Object rope) { invoke<Void>(0xBE520D9761FF811F, rope); } // 0xBE520D9761FF811F
	static void SET_CGOFFSET(Object rope, float x, float y, float z) { invoke<Void>(0xD8FA3908D7B86904, rope, x, y, z); } // 0xD8FA3908D7B86904
	static void SET_DAMPING(Object rope, int vertex, float value) { invoke<Void>(0xEEA3B200A6FEB65B, rope, vertex, value); } // 0xEEA3B200A6FEB65B
	static Any SET_DISABLE_BREAKING(Object rope, BOOL enabled) { return invoke<Any>(0x5CEC1A84620E7D5B, rope, enabled); } // 0x5CEC1A84620E7D5B
	static void SET_DISABLE_FRAG_DAMAGE(Object object, BOOL toggle) { invoke<Void>(0x1BA3AED21C16CFB, object, toggle); } // 0x1BA3AED21C16CFB
	static void START_ROPE_UNWINDING_FRONT(Object rope) { invoke<Void>(0x538D1179EC1AA9A9, rope); } // 0x538D1179EC1AA9A9
	static void START_ROPE_WINDING(Object rope) { invoke<Void>(0x1461C72C889E343E, rope); } // 0x1461C72C889E343E
	static void STOP_ROPE_UNWINDING_FRONT(Object rope) { invoke<Void>(0xFFF3A50779EFBBB3, rope); } // 0xFFF3A50779EFBBB3
	static void STOP_ROPE_WINDING(Object rope) { invoke<Void>(0xCB2D4AB84A19AA7C, rope); } // 0xCB2D4AB84A19AA7C
	static Any UNPIN_ROPE_VERTEX(Object rope, int vertex) { return invoke<Any>(0x4B5AE2EEE4A8F180, rope, vertex); } // 0x4B5AE2EEE4A8F180
}

namespace PLAYER
{
	static BOOL ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP(Player player) { return invoke<BOOL>(0xAFAF86043E5874E9, player); } // 0xAFAF86043E5874E9
	static BOOL ARE_PLAYER_STARS_GREYED_OUT(Player player) { return invoke<BOOL>(0xA6EB355EE14A2DB, player); } // 0xA6EB355EE14A2DB
	static void ASSISTED_MOVEMENT_CLOSE_ROUTE() { invoke<Void>(0xAEBF081FFC0A0E5E); } // 0xAEBF081FFC0A0E5E
	static void ASSISTED_MOVEMENT_FLUSH_ROUTE() { invoke<Void>(0x8621390F0CDCFE1F); } // 0x8621390F0CDCFE1F
	static BOOL CAN_PED_HEAR_PLAYER(Player player, Ped ped) { return invoke<BOOL>(0xF297383AA91DCA29, player, ped); } // 0xF297383AA91DCA29
	static BOOL CAN_PLAYER_START_MISSION(Player player) { return invoke<BOOL>(0xDE7465A27D403C06, player); } // 0xDE7465A27D403C06
	static void CHANGE_PLAYER_PED(Player Player, Ped ped, BOOL b2, BOOL b3) { invoke<Void>(0x48189FAC643DEEE, Player, ped, b2, b3); } // 0x48189FAC643DEEE
	static void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(Player player) { invoke<Void>(0x4AACB96203D11A31, player); } // 0x4AACB96203D11A31
	static void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED(Player player) { invoke<Void>(0xF0B67A4DE6AB5F98, player); } // 0xF0B67A4DE6AB5F98
	static void CLEAR_PLAYER_PARACHUTE_MODEL_OVERRIDE(Player player) { invoke<Void>(0x8753997EB5F6EE3F, player); } // 0x8753997EB5F6EE3F
	static void CLEAR_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(Player player) { invoke<Void>(0x10C54E4389C12B42, player); } // 0x10C54E4389C12B42
	static void CLEAR_PLAYER_PARACHUTE_VARIATION_OVERRIDE(Player player) { invoke<Void>(0xF4CC924CF8C7B21, player); } // 0xF4CC924CF8C7B21
	static void CLEAR_PLAYER_WANTED_LEVEL(Player player) { invoke<Void>(0xB302540597885499, player); } // 0xB302540597885499
	static void DISABLE_PLAYER_FIRING(Player player, BOOL toggle) { invoke<Void>(0x5E6CC07646BBEAB8, player, toggle); } // 0x5E6CC07646BBEAB8
	static void DISABLE_PLAYER_VEHICLE_REWARDS(Player player) { invoke<Void>(0xC142BE3BB9CE125F, player); } // 0xC142BE3BB9CE125F
	static void DISPLAY_SYSTEM_SIGNIN_UI(BOOL unk) { invoke<Void>(0x94DD7888C10A979E, unk); } // 0x94DD7888C10A979E
	static void ENABLE_SPECIAL_ABILITY(Player player, BOOL toggle) { invoke<Void>(0x181EC197DAEFE121, player, toggle); } // 0x181EC197DAEFE121
	static void _EXPAND_WORLD_LIMITS(float x, float y, float z) { invoke<Void>(0x5006D96C995A5827, x, y, z); } // 0x5006D96C995A5827
	static void FORCE_CLEANUP(int cleanupFlags) { invoke<Void>(0xBC8983F38F78ED51, cleanupFlags); } // 0xBC8983F38F78ED51
	static void FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME(char* name, int cleanupFlags) { invoke<Void>(0x4C68DDDDF0097317, name, cleanupFlags); } // 0x4C68DDDDF0097317
	static void FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID(int id, int cleanupFlags) { invoke<Void>(0xF745B37630DF176B, id, cleanupFlags); } // 0xF745B37630DF176B
	static int _GET_ACHIEVEMENT_PROGRESSION(int achId) { return invoke<int>(0x1C186837D0619335, achId); } // 0x1C186837D0619335
	static int GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP() { return invoke<int>(0x9A41CF4674A12272); } // 0x9A41CF4674A12272
	static BOOL GET_ENTITY_PLAYER_IS_FREE_AIMING_AT(Player player, Entity* entity) { return invoke<BOOL>(0x2975C866E6713290, player, entity); } // 0x2975C866E6713290
	static int GET_MAX_WANTED_LEVEL() { return invoke<int>(0x462E0DB9B137DC5F); } // 0x462E0DB9B137DC5F
	static int GET_NUMBER_OF_PLAYERS() { return invoke<int>(0x407C7F91DDB46C16); } // 0x407C7F91DDB46C16
	static float GET_PLAYER_CURRENT_STEALTH_NOISE(Player player) { return invoke<float>(0x2F395D61F3A1F877, player); } // 0x2F395D61F3A1F877
	static int GET_PLAYER_GROUP(Player player) { return invoke<int>(0xD127585F77030AF, player); } // 0xD127585F77030AF
	static BOOL GET_PLAYER_HAS_RESERVE_PARACHUTE(Player player) { return invoke<BOOL>(0x5DDFE2FF727F3CA3, player); } // 0x5DDFE2FF727F3CA3
	static Player GET_PLAYER_INDEX() { return invoke<Player>(0xA5EDC40EF369B48D); } // 0xA5EDC40EF369B48D
	static BOOL GET_PLAYER_INVINCIBLE(Player player) { return invoke<BOOL>(0xB721981B2B939E07, player); } // 0xB721981B2B939E07
	static int GET_PLAYER_MAX_ARMOUR(Player player) { return invoke<int>(0x92659B4CE1863CB3, player); } // 0x92659B4CE1863CB3
	static char* GET_PLAYER_NAME(Player player) { return invoke<char*>(0x6D0DE6A7B5DA71F8, player); } // 0x6D0DE6A7B5DA71F8
	static void GET_PLAYER_PARACHUTE_PACK_TINT_INDEX(Player player, int* tintIndex) { invoke<Void>(0x6E9C742F340CE5A2, player, tintIndex); } // 0x6E9C742F340CE5A2
	static void GET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(Player player, int* r, int* g, int* b) { invoke<Void>(0xEF56DBABD3CD4887, player, r, g, b); } // 0xEF56DBABD3CD4887
	static void GET_PLAYER_PARACHUTE_TINT_INDEX(Player player, int* tintIndex) { invoke<Void>(0x75D3F7A1B0D9B145, player, tintIndex); } // 0x75D3F7A1B0D9B145
	static Ped GET_PLAYER_PED(Player playerId) { return invoke<Ped>(0x43A66C31C68491C0, playerId); } // 0x43A66C31C68491C0
	static Ped GET_PLAYER_PED_SCRIPT_INDEX(Player Player) { return invoke<Ped>(0x50FAC3A3E030A6E1, Player); } // 0x50FAC3A3E030A6E1
	static void GET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(Player player, int* index) { invoke<Void>(0xD5A016BC3C09CF40, player, index); } // 0xD5A016BC3C09CF40
	static void GET_PLAYER_RGB_COLOUR(Player Player, int* r, int* g, int* b) { invoke<Void>(0xE902EF951DCE178F, Player, r, g, b); } // 0xE902EF951DCE178F
	static Vehicle GET_PLAYERS_LAST_VEHICLE() { return invoke<Vehicle>(0xB6997A7EB3F5C8C0); } // 0xB6997A7EB3F5C8C0
	static float GET_PLAYER_SPRINT_STAMINA_REMAINING(Player player) { return invoke<float>(0x3F9F16F8E65A7ED7, player); } // 0x3F9F16F8E65A7ED7
	static float GET_PLAYER_SPRINT_TIME_REMAINING(Player player) { return invoke<float>(0x1885BC9B108B4C99, player); } // 0x1885BC9B108B4C99
	static BOOL GET_PLAYER_TARGET_ENTITY(Player player, Entity* entity) { return invoke<BOOL>(0x13EDE1A5DBF797C9, player, entity); } // 0x13EDE1A5DBF797C9
	static int GET_PLAYER_TEAM(Player player) { return invoke<int>(0x37039302F4E0A008, player); } // 0x37039302F4E0A008
	static float GET_PLAYER_UNDERWATER_TIME_REMAINING(Player player) { return invoke<float>(0xA1FCF8E6AF40B731, player); } // 0xA1FCF8E6AF40B731
	static Vector3 GET_PLAYER_WANTED_CENTRE_POSITION(Player player) { return invoke<Vector3>(0xC92BA89F1AF26F8, player); } // 0xC92BA89F1AF26F8
	static int GET_PLAYER_WANTED_LEVEL(Player player) { return invoke<int>(0xE28E54788CE8F12D, player); } // 0xE28E54788CE8F12D
	static int GET_TIME_SINCE_LAST_ARREST() { return invoke<int>(0x5063F92F07C2A316); } // 0x5063F92F07C2A316
	static int GET_TIME_SINCE_LAST_DEATH() { return invoke<int>(0xC7034807558DDFCA); } // 0xC7034807558DDFCA
	static int GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC(Player player) { return invoke<int>(0xDB89591E290D9182, player); } // 0xDB89591E290D9182
	static int GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT(Player player) { return invoke<int>(0xD559D2BE9E37853B, player); } // 0xD559D2BE9E37853B
	static int GET_TIME_SINCE_PLAYER_HIT_PED(Player player) { return invoke<int>(0xE36A25322DC35F42, player); } // 0xE36A25322DC35F42
	static int GET_TIME_SINCE_PLAYER_HIT_VEHICLE(Player player) { return invoke<int>(0x5D35ECF3A81A0EE0, player); } // 0x5D35ECF3A81A0EE0
	static Any GET_WANTED_LEVEL_RADIUS(Player player) { return invoke<Any>(0x85DEB493BE80812, player); } // 0x85DEB493BE80812
	static int GET_WANTED_LEVEL_THRESHOLD(int wantedLevel) { return invoke<int>(0xFDD179EAF45B556C, wantedLevel); } // 0xFDD179EAF45B556C
	static Any GIVE_ACHIEVEMENT_TO_PLAYER(int achId) { return invoke<Any>(0xBEC7076D64130195, achId); } // 0xBEC7076D64130195
	static void GIVE_PLAYER_RAGDOLL_CONTROL(Player player, BOOL toggle) { invoke<Void>(0x3C49C870E66F0A28, player, toggle); } // 0x3C49C870E66F0A28
	static BOOL HAS_ACHIEVEMENT_BEEN_PASSED(int achievement) { return invoke<BOOL>(0x867365E111A3B6EB, achievement); } // 0x867365E111A3B6EB
	static BOOL HAS_FORCE_CLEANUP_OCCURRED(int cleanupFlags) { return invoke<BOOL>(0xC968670BFACE42D9, cleanupFlags); } // 0xC968670BFACE42D9
	static BOOL HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE(Player player) { return invoke<BOOL>(0xD705740BB0A1CF4C, player); } // 0xD705740BB0A1CF4C
	static BOOL HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(Player player) { return invoke<BOOL>(0xE4B90F367BD81752, player); } // 0xE4B90F367BD81752
	static BOOL HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED(Player player) { return invoke<BOOL>(0x20CE80B0C2BF4ACC, player); } // 0x20CE80B0C2BF4ACC
	static BOOL HAS_PLAYER_LEFT_THE_WORLD(Player player) { return invoke<BOOL>(0xD55DDFB47991A294, player); } // 0xD55DDFB47991A294
	static BOOL _HAS_PLAYER_TELEPORT_FINISHED(Player player) { return invoke<BOOL>(0xE23D5873C2394C61, player); } // 0xE23D5873C2394C61
	static int INT_TO_PARTICIPANTINDEX(int value) { return invoke<int>(0x9EC6603812C24710, value); } // 0x9EC6603812C24710
	static Player INT_TO_PLAYERINDEX(int value) { return invoke<Player>(0x41BD2A6B006AF756, value); } // 0x41BD2A6B006AF756
	static BOOL IS_PLAYER_BEING_ARRESTED(Player player, BOOL atArresting) { return invoke<BOOL>(0x388A47C51ABDAC8E, player, atArresting); } // 0x388A47C51ABDAC8E
	static BOOL _IS_PLAYER_CAM_CONTROL_DISABLED() { return invoke<BOOL>(0x7C814D2FB49F40C0); } // 0x7C814D2FB49F40C0
	static BOOL IS_PLAYER_CLIMBING(Player player) { return invoke<BOOL>(0x95E8F73DC65EFB9C, player); } // 0x95E8F73DC65EFB9C
	static BOOL IS_PLAYER_CONTROL_ON(Player player) { return invoke<BOOL>(0x49C32D60007AFA47, player); } // 0x49C32D60007AFA47
	static BOOL IS_PLAYER_DEAD(Player player) { return invoke<BOOL>(0x424D4687FA1E5652, player); } // 0x424D4687FA1E5652
	static BOOL IS_PLAYER_FREE_AIMING(Player player) { return invoke<BOOL>(0x2E397FD2ECD37C87, player); } // 0x2E397FD2ECD37C87
	static BOOL IS_PLAYER_FREE_AIMING_AT_ENTITY(Player player, Entity entity) { return invoke<BOOL>(0x3C06B5C839B38F7B, player, entity); } // 0x3C06B5C839B38F7B
	static BOOL IS_PLAYER_FREE_FOR_AMBIENT_TASK(Player player) { return invoke<BOOL>(0xDCCFD3F106C36AB4, player); } // 0xDCCFD3F106C36AB4
	static BOOL IS_PLAYER_LOGGING_IN_NP() { return invoke<BOOL>(0x74556E1420867ECA); } // 0x74556E1420867ECA
	static BOOL IS_PLAYER_ONLINE() { return invoke<BOOL>(0xF25D331DC2627BBC); } // 0xF25D331DC2627BBC
	static BOOL IS_PLAYER_PLAYING(Player player) { return invoke<BOOL>(0x5E9564D8246B909A, player); } // 0x5E9564D8246B909A
	static BOOL IS_PLAYER_PRESSING_HORN(Player player) { return invoke<BOOL>(0xFA1E2BF8B10598F9, player); } // 0xFA1E2BF8B10598F9
	static BOOL IS_PLAYER_READY_FOR_CUTSCENE(Player player) { return invoke<BOOL>(0x908CBECC2CAA3690, player); } // 0x908CBECC2CAA3690
	static BOOL IS_PLAYER_RIDING_TRAIN(Player player) { return invoke<BOOL>(0x4EC12697209F2196, player); } // 0x4EC12697209F2196
	static BOOL IS_PLAYER_SCRIPT_CONTROL_ON(Player player) { return invoke<BOOL>(0x8A876A65283DD7D7, player); } // 0x8A876A65283DD7D7
	static BOOL IS_PLAYER_TARGETTING_ANYTHING(Player player) { return invoke<BOOL>(0x78CFE51896B6B8A4, player); } // 0x78CFE51896B6B8A4
	static BOOL IS_PLAYER_TARGETTING_ENTITY(Player player, Entity entity) { return invoke<BOOL>(0x7912F7FC4F6264B6, player, entity); } // 0x7912F7FC4F6264B6
	static BOOL IS_PLAYER_TELEPORT_ACTIVE() { return invoke<BOOL>(0x2B15662D7F8886F); } // 0x2B15662D7F8886F
	static BOOL IS_PLAYER_WANTED_LEVEL_GREATER(Player player, int wantedLevel) { return invoke<BOOL>(0x238DB2A2C23EE9EF, player, wantedLevel); } // 0x238DB2A2C23EE9EF
	static BOOL IS_SPECIAL_ABILITY_ACTIVE(Player player) { return invoke<BOOL>(0x3E5F7FC85D854E15, player); } // 0x3E5F7FC85D854E15
	static BOOL IS_SPECIAL_ABILITY_ENABLED(Player player) { return invoke<BOOL>(0xB1D200FE26AEF3CB, player); } // 0xB1D200FE26AEF3CB
	static BOOL IS_SPECIAL_ABILITY_METER_FULL(Player player) { return invoke<BOOL>(0x5A1FE504B7F2587, player); } // 0x5A1FE504B7F2587
	static BOOL IS_SPECIAL_ABILITY_UNLOCKED(Hash playerModel) { return invoke<BOOL>(0xC6017F6A6CDFA694, playerModel); } // 0xC6017F6A6CDFA694
	static BOOL IS_SYSTEM_UI_BEING_DISPLAYED() { return invoke<BOOL>(0x5D511E3867C87139); } // 0x5D511E3867C87139
	static int NETWORK_PLAYER_ID_TO_INT() { return invoke<int>(0xEE68096F9F37341E); } // 0xEE68096F9F37341E
	static void _0x0032A6DBA562C518() { invoke<Void>(0x32A6DBA562C518); } // 0x32A6DBA562C518
	static void _0x17F7471EACA78290(Any p0) { invoke<Void>(0x17F7471EACA78290, p0); } // 0x17F7471EACA78290
	static void _0x2382AB11450AE7BA(Any p0, Any p1) { invoke<Void>(0x2382AB11450AE7BA, p0, p1); } // 0x2382AB11450AE7BA
	static void _0x2F41A3BAE005E5FA(Any p0, Any p1) { invoke<Void>(0x2F41A3BAE005E5FA, p0, p1); } // 0x2F41A3BAE005E5FA
	static void _0x2F7CEB6520288061(BOOL p0) { invoke<Void>(0x2F7CEB6520288061, p0); } // 0x2F7CEB6520288061
	static void _0x31E90B8873A4CD3B(Any p0, Any p1) { invoke<Void>(0x31E90B8873A4CD3B, p0, p1); } // 0x31E90B8873A4CD3B
	static void _0x36F1B38855F2A8DF(Player player) { invoke<Void>(0x36F1B38855F2A8DF, player); } // 0x36F1B38855F2A8DF
	static BOOL _0x38D28DA81E4E9BF9(Player player) { return invoke<BOOL>(0x38D28DA81E4E9BF9, player); } // 0x38D28DA81E4E9BF9
	static Any _0x4669B3ED80F24B4E(Player player) { return invoke<Any>(0x4669B3ED80F24B4E, player); } // 0x4669B3ED80F24B4E
	static void _0x5501B7A5CDB79D37(Player p0) { invoke<Void>(0x5501B7A5CDB79D37, p0); } // 0x5501B7A5CDB79D37
	static void _0x55FCC0C390620314(Player player1, Player player2, BOOL toggle) { invoke<Void>(0x55FCC0C390620314, player1, player2, toggle); } // 0x55FCC0C390620314
	static Player _0x56105E599CAB0EFA(int* p0) { return invoke<Player>(0x56105E599CAB0EFA, p0); } // 0x56105E599CAB0EFA
	static void _0x5702B917B99DB1CD(int p0) { invoke<Void>(0x5702B917B99DB1CD, p0); } // 0x5702B917B99DB1CD
	static void _0x5DC40A8869C22141(BOOL p0, ScrHandle p1) { invoke<Void>(0x5DC40A8869C22141, p0, p1); } // 0x5DC40A8869C22141
	static BOOL _0x5FC472C501CCADB3(Player player) { return invoke<BOOL>(0x5FC472C501CCADB3, player); } // 0x5FC472C501CCADB3
	static BOOL _0x65FAEE425DE637B0(Player p0) { return invoke<BOOL>(0x65FAEE425DE637B0, p0); } // 0x65FAEE425DE637B0
	static BOOL _0x690A61A6D13583F6(Ped p0) { return invoke<BOOL>(0x690A61A6D13583F6, p0); } // 0x690A61A6D13583F6
	static void _0x6BC97F4F4BB3C04B(Any p0, Any p1) { invoke<Void>(0x6BC97F4F4BB3C04B, p0, p1); } // 0x6BC97F4F4BB3C04B
	static Any _0x6E4361FF3E8CD7CA(Any p0) { return invoke<Any>(0x6E4361FF3E8CD7CA, p0); } // 0x6E4361FF3E8CD7CA
	static Any _0x7E07C78925D5FD96(Any p0) { return invoke<Any>(0x7E07C78925D5FD96, p0); } // 0x7E07C78925D5FD96
	static void _0x821FDC827D6F4090(Any p0) { invoke<Void>(0x821FDC827D6F4090, p0); } // 0x821FDC827D6F4090
	static Any _0x8BC515BAE4AAF8FF(Any p0) { return invoke<Any>(0x8BC515BAE4AAF8FF, p0); } // 0x8BC515BAE4AAF8FF
	static void _0x8D768602ADEF2245(Any p0, Any p1) { invoke<Void>(0x8D768602ADEF2245, p0, p1); } // 0x8D768602ADEF2245
	static void _0x9EDD76E87D5D51BA(Player player) { invoke<Void>(0x9EDD76E87D5D51BA, player); } // 0x9EDD76E87D5D51BA
	static Any _0xA0D3E4F7AAFB7E78(Any p0, Any p1) { return invoke<Any>(0xA0D3E4F7AAFB7E78, p0, p1); } // 0xA0D3E4F7AAFB7E78
	static Any _0xAD73CE5A09E42D12(Player player) { return invoke<Any>(0xAD73CE5A09E42D12, player); } // 0xAD73CE5A09E42D12
	static void _0xB214D570EAD7F81A(Any p0, Any p1) { invoke<Void>(0xB214D570EAD7F81A, p0, p1); } // 0xB214D570EAD7F81A
	static void _0xB45EFF719D8427A6(float p0) { invoke<Void>(0xB45EFF719D8427A6, p0); } // 0xB45EFF719D8427A6
	static void _0xB885852C39CC265D() { invoke<Void>(0xB885852C39CC265D); } // 0xB885852C39CC265D
	static BOOL _0xB9CF1F793A9F1BF1() { return invoke<BOOL>(0xB9CF1F793A9F1BF1); } // 0xB9CF1F793A9F1BF1
	static BOOL _0xBC0753C9CA14B506(Player player, int p1, BOOL p2) { return invoke<BOOL>(0xBC0753C9CA14B506, player, p1, p2); } // 0xBC0753C9CA14B506
	static void _0xBC9490CA15AEA8FB(Player player) { invoke<Void>(0xBC9490CA15AEA8FB, player); } // 0xBC9490CA15AEA8FB
	static void _0xBCFDE9EDE4CF27DC(Any p0, Any p1) { invoke<Void>(0xBCFDE9EDE4CF27DC, p0, p1); } // 0xBCFDE9EDE4CF27DC
	static void _0xC3376F42B1FACCC6(Player player) { invoke<Void>(0xC3376F42B1FACCC6, player); } // 0xC3376F42B1FACCC6
	static void _0xC388A0F065F5BC34(Any p0, Any p1) { invoke<Void>(0xC388A0F065F5BC34, p0, p1); } // 0xC388A0F065F5BC34
	static void _0xC9A763D8FE87436A(Player player) { invoke<Void>(0xC9A763D8FE87436A, player); } // 0xC9A763D8FE87436A
	static void _0xCAC57395B151135F(Player player, BOOL p1) { invoke<Void>(0xCAC57395B151135F, player, p1); } // 0xCAC57395B151135F
	static Any _0xCB645E85E97EA48B() { return invoke<Any>(0xCB645E85E97EA48B); } // 0xCB645E85E97EA48B
	static void _0xD2B315B6689D537D(Player player, BOOL p1) { invoke<Void>(0xD2B315B6689D537D, player, p1); } // 0xD2B315B6689D537D
	static void _0xD821056B9ACF8052(Any p0, Any p1) { invoke<Void>(0xD821056B9ACF8052, p0, p1); } // 0xD821056B9ACF8052
	static void _0xDC64D2C53493ED12(Player player) { invoke<Void>(0xDC64D2C53493ED12, player); } // 0xDC64D2C53493ED12
	static BOOL _0xDD2620B7B9D16FF1(Player player, float p1) { return invoke<BOOL>(0xDD2620B7B9D16FF1, player, p1); } // 0xDD2620B7B9D16FF1
	static void _0xDE45D1A1EF45EE61(Player player, BOOL toggle) { invoke<Void>(0xDE45D1A1EF45EE61, player, toggle); } // 0xDE45D1A1EF45EE61
	static void _0xEFD79FA81DFBA9CB(Any p0, Any p1) { invoke<Void>(0xEFD79FA81DFBA9CB, p0, p1); } // 0xEFD79FA81DFBA9CB
	static BOOL _0xF10B44FD479D69F3(Player player, int p1) { return invoke<BOOL>(0xF10B44FD479D69F3, player, p1); } // 0xF10B44FD479D69F3
	static void _0xFAC75988A7D078D3(Any p0) { invoke<Void>(0xFAC75988A7D078D3, p0); } // 0xFAC75988A7D078D3
	static void _0xFF300C7649724A0B(Player player, BOOL p1) { invoke<Void>(0xFF300C7649724A0B, player, p1); } // 0xFF300C7649724A0B
	static void _0xFFEE8FA29AB9A18E(Player player) { invoke<Void>(0xFFEE8FA29AB9A18E, player); } // 0xFFEE8FA29AB9A18E
	static void PLAYER_ATTACH_VIRTUAL_BOUND(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7) { invoke<Void>(0xED51733DC73AED51, p0, p1, p2, p3, p4, p5, p6, p7); } // 0xED51733DC73AED51
	static void PLAYER_DETACH_VIRTUAL_BOUND() { invoke<Void>(0x1DD5897E2FA6E7C9); } // 0x1DD5897E2FA6E7C9
	static Player PLAYER_ID() { return invoke<Player>(0x4F8644AF03D0E0D6); } // 0x4F8644AF03D0E0D6
	static Ped PLAYER_PED_ID() { return invoke<Ped>(0xD80958FC74E988A6); } // 0xD80958FC74E988A6
	static Any REMOVE_PLAYER_HELMET(Player player, BOOL p2) { return invoke<Any>(0xF3AC26D3CC576528, player, p2); } // 0xF3AC26D3CC576528
	static void REPORT_CRIME(Player player, int crimeType, int wantedLvlThresh) { invoke<Void>(0xE9B09589827545E7, player, crimeType, wantedLvlThresh); } // 0xE9B09589827545E7
	static void RESET_PLAYER_ARREST_STATE(Player player) { invoke<Void>(0x2D03E13C460760D6, player); } // 0x2D03E13C460760D6
	static void RESET_PLAYER_INPUT_GAIT(Player player) { invoke<Void>(0x19531C47A2ABD691, player); } // 0x19531C47A2ABD691
	static void RESET_PLAYER_STAMINA(Player player) { invoke<Void>(0xA6F312FCCE9C1DFE, player); } // 0xA6F312FCCE9C1DFE
	static void RESET_WANTED_LEVEL_DIFFICULTY(Player player) { invoke<Void>(0xB9D0DD990DC141DD, player); } // 0xB9D0DD990DC141DD
	static void RESTORE_PLAYER_STAMINA(Player player, float p1) { invoke<Void>(0xA352C1B864CAFD33, player, p1); } // 0xA352C1B864CAFD33
	static BOOL _SET_ACHIEVEMENT_PROGRESSION(int achId, int progression) { return invoke<BOOL>(0xC2AFFFDABBDC2C5C, achId, progression); } // 0xC2AFFFDABBDC2C5C
	static void SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE(Player player, float multiplier) { invoke<Void>(0xCA7DC8329F0A1E9E, player, multiplier); } // 0xCA7DC8329F0A1E9E
	static void SET_ALL_RANDOM_PEDS_FLEE(Player player, BOOL toggle) { invoke<Void>(0x56E0FE8534C2949, player, toggle); } // 0x56E0FE8534C2949
	static void SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME(Player player) { invoke<Void>(0x471D2FF42A94B4F2, player); } // 0x471D2FF42A94B4F2
	static void SET_AUTO_GIVE_PARACHUTE_WHEN_ENTER_PLANE(Player player, BOOL toggle) { invoke<Void>(0x9F343285A00B4BB6, player, toggle); } // 0x9F343285A00B4BB6
	static void SET_DISABLE_AMBIENT_MELEE_MOVE(Player player, BOOL toggle) { invoke<Void>(0x2E8AABFA40A84F8C, player, toggle); } // 0x2E8AABFA40A84F8C
	static void SET_DISPATCH_COPS_FOR_PLAYER(Player player, BOOL toggle) { invoke<Void>(0xDB172424876553F4, player, toggle); } // 0xDB172424876553F4
	static void SET_EVERYONE_IGNORE_PLAYER(Player player, BOOL toggle) { invoke<Void>(0x8EEDA153AD141BA4, player, toggle); } // 0x8EEDA153AD141BA4
	static void SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS(Player player, BOOL toggle) { invoke<Void>(0x596976B02B6B5700, player, toggle); } // 0x596976B02B6B5700
	static void SET_MAX_WANTED_LEVEL(int maxWantedLevel) { invoke<Void>(0xAA5F02DB48D704B9, maxWantedLevel); } // 0xAA5F02DB48D704B9
	static void SET_PLAYER_CAN_BE_HASSLED_BY_GANGS(Player player, BOOL toggle) { invoke<Void>(0xD5E460AD7020A246, player, toggle); } // 0xD5E460AD7020A246
	static void SET_PLAYER_CAN_DO_DRIVE_BY(Player player, BOOL toggle) { invoke<Void>(0x6E8834B52EC20C77, player, toggle); } // 0x6E8834B52EC20C77
	static void SET_PLAYER_CAN_LEAVE_PARACHUTE_SMOKE_TRAIL(Player player, BOOL enabled) { invoke<Void>(0xF401B182DBA8AF53, player, enabled); } // 0xF401B182DBA8AF53
	static Any SET_PLAYER_CAN_USE_COVER(Player player, BOOL toggle) { return invoke<Any>(0xD465A8599DFF6814, player, toggle); } // 0xD465A8599DFF6814
	static void SET_PLAYER_CLOTH_LOCK_COUNTER(int value) { invoke<Void>(0x14D913B777DFF5DA, value); } // 0x14D913B777DFF5DA
	static void SET_PLAYER_CLOTH_PACKAGE_INDEX(int index) { invoke<Void>(0x9F7BBA2EA6372500, index); } // 0x9F7BBA2EA6372500
	static void SET_PLAYER_CLOTH_PIN_FRAMES(Player player, BOOL toggle) { invoke<Void>(0x749FADDF97DFE930, player, toggle); } // 0x749FADDF97DFE930
	static void SET_PLAYER_CONTROL(Player player, BOOL toggle, int flags) { invoke<Void>(0x8D32347D6D4C40A2, player, toggle, flags); } // 0x8D32347D6D4C40A2
	static void SET_PLAYER_FORCED_AIM(Player player, BOOL toggle) { invoke<Void>(0xFEE4F80AC44A726, player, toggle); } // 0xFEE4F80AC44A726
	static void SET_PLAYER_FORCED_ZOOM(Player player, BOOL toggle) { invoke<Void>(0x75E7D505F2B15902, player, toggle); } // 0x75E7D505F2B15902
	static void SET_PLAYER_FORCE_SKIP_AIM_INTRO(Player player, BOOL toggle) { invoke<Void>(0x7651BC64AE59E128, player, toggle); } // 0x7651BC64AE59E128
	static void SET_PLAYER_HAS_RESERVE_PARACHUTE(Player player) { invoke<Void>(0x7DDAB28D31FAC363, player); } // 0x7DDAB28D31FAC363
	static void SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER(Player player, float regenRate) { invoke<Void>(0x5DB660B38DD98A31, player, regenRate); } // 0x5DB660B38DD98A31
	static void SET_PLAYER_INVINCIBLE(Player player, BOOL toggle) { invoke<Void>(0x239528EACDC3E7DE, player, toggle); } // 0x239528EACDC3E7DE
	static void SET_PLAYER_LOCKON(Player player, BOOL toggle) { invoke<Void>(0x5C8B2F450EE4328E, player, toggle); } // 0x5C8B2F450EE4328E
	static void SET_PLAYER_LOCKON_RANGE_OVERRIDE(Player player, float range) { invoke<Void>(0x29961D490E5814FD, player, range); } // 0x29961D490E5814FD
	static void SET_PLAYER_MAX_ARMOUR(Player player, int value) { invoke<Void>(0x77DFCCF5948B8C71, player, value); } // 0x77DFCCF5948B8C71
	static void SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE(Player player) { invoke<Void>(0x1DE37BBF9E9CC14A, player); } // 0x1DE37BBF9E9CC14A
	static void SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE(Player player, Vehicle vehicle) { invoke<Void>(0x8026FF78F208978A, player, vehicle); } // 0x8026FF78F208978A
	static void SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER(Player player, float modifier) { invoke<Void>(0x4A3DC7ECCC321032, player, modifier); } // 0x4A3DC7ECCC321032
	static void SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER(Player player, float modifier) { invoke<Void>(0xAE540335B4ABC4E2, player, modifier); } // 0xAE540335B4ABC4E2
	static void SET_PLAYER_MODEL(Player player, Hash model) { invoke<Void>(0xA1CADD00108836, player, model); } // 0xA1CADD00108836
	static void SET_PLAYER_NOISE_MULTIPLIER(Player player, float multiplier) { invoke<Void>(0xDB89EF50FF25FCE9, player, multiplier); } // 0xDB89EF50FF25FCE9
	static void SET_PLAYER_PARACHUTE_MODEL_OVERRIDE(Player player, Hash model) { invoke<Void>(0x977DB4641F6FC3DB, player, model); } // 0x977DB4641F6FC3DB
	static void SET_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE(Player player, Hash model) { invoke<Void>(0xDC80A4C2F18A2B64, player, model); } // 0xDC80A4C2F18A2B64
	static void SET_PLAYER_PARACHUTE_PACK_TINT_INDEX(Player player, int tintIndex) { invoke<Void>(0x93B0FB27C9A04060, player, tintIndex); } // 0x93B0FB27C9A04060
	static void SET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR(Player player, int r, int g, int b) { invoke<Void>(0x8217FD371A4625CF, player, r, g, b); } // 0x8217FD371A4625CF
	static void SET_PLAYER_PARACHUTE_TINT_INDEX(Player player, int tintIndex) { invoke<Void>(0xA3D0E54541D9A5E5, player, tintIndex); } // 0xA3D0E54541D9A5E5
	static void SET_PLAYER_PARACHUTE_VARIATION_OVERRIDE(Player player, int p1, Any p2, Any p3, BOOL p4) { invoke<Void>(0xD9284A8C0D48352C, player, p1, p2, p3, p4); } // 0xD9284A8C0D48352C
	static void SET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX(Player player, int index) { invoke<Void>(0xAF04C87F5DC1DF38, player, index); } // 0xAF04C87F5DC1DF38
	static void SET_PLAYER_RESET_FLAG_PREFER_REAR_SEATS(Player player, int flags) { invoke<Void>(0x11D5F725F0E780E0, player, flags); } // 0x11D5F725F0E780E0
	static void SET_PLAYER_SIMULATE_AIMING(Player player, BOOL toggle) { invoke<Void>(0xC54C95DA968EC5B5, player, toggle); } // 0xC54C95DA968EC5B5
	static void SET_PLAYER_SNEAKING_NOISE_MULTIPLIER(Player player, float multiplier) { invoke<Void>(0xB2C1A29588A9F47C, player, multiplier); } // 0xB2C1A29588A9F47C
	static void SET_PLAYER_SPRINT(Player player, BOOL toggle) { invoke<Void>(0xA01B8075D8B92DF4, player, toggle); } // 0xA01B8075D8B92DF4
	static void SET_PLAYER_STEALTH_PERCEPTION_MODIFIER(Player player, float value) { invoke<Void>(0x4E9021C1FCDD507A, player, value); } // 0x4E9021C1FCDD507A
	static void SET_PLAYER_TARGETING_MODE(int targetMode) { invoke<Void>(0xB1906895227793F3, targetMode); } // 0xB1906895227793F3
	static void SET_PLAYER_TEAM(Player player, int team) { invoke<Void>(0x299FA38396A4940, player, team); } // 0x299FA38396A4940
	static void SET_PLAYER_VEHICLE_DAMAGE_MODIFIER(Player player, float damageAmount) { invoke<Void>(0xA50E117CDDF82F0C, player, damageAmount); } // 0xA50E117CDDF82F0C
	static void SET_PLAYER_VEHICLE_DEFENSE_MODIFIER(Player player, float modifier) { invoke<Void>(0x4C60E6EFDAFF2462, player, modifier); } // 0x4C60E6EFDAFF2462
	static void SET_PLAYER_WANTED_CENTRE_POSITION(Player player, float x, float y, float z) { invoke<Void>(0x520E541A97A13354, player, x, y, z); } // 0x520E541A97A13354
	static void SET_PLAYER_WANTED_LEVEL(Player player, int wantedLevel, BOOL disableNoMission) { invoke<Void>(0x39FF19C64EF7DA5B, player, wantedLevel, disableNoMission); } // 0x39FF19C64EF7DA5B
	static void SET_PLAYER_WANTED_LEVEL_NO_DROP(Player player, int wantedLevel, BOOL p2) { invoke<Void>(0x340E61DE7F471565, player, wantedLevel, p2); } // 0x340E61DE7F471565
	static void SET_PLAYER_WANTED_LEVEL_NOW(Player player, BOOL p1) { invoke<Void>(0xE0A7D1E497FFCD6F, player, p1); } // 0xE0A7D1E497FFCD6F
	static void SET_PLAYER_WEAPON_DAMAGE_MODIFIER(Player player, float damageAmount) { invoke<Void>(0xCE07B9F7817AADA3, player, damageAmount); } // 0xCE07B9F7817AADA3
	static void SET_PLAYER_WEAPON_DEFENSE_MODIFIER(Player player, ScrHandle modifier) { invoke<Void>(0x2D83BC011CA14A3C, player, modifier); } // 0x2D83BC011CA14A3C
	static void SET_POLICE_IGNORE_PLAYER(Player player, BOOL toggle) { invoke<Void>(0x32C62AA929C2DA6A, player, toggle); } // 0x32C62AA929C2DA6A
	static void SET_POLICE_RADAR_BLIPS(BOOL toggle) { invoke<Void>(0x43286D561B72B8BF, toggle); } // 0x43286D561B72B8BF
	static void SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER(Player player, float multiplier) { invoke<Void>(0x6DB47AA77FD94E09, player, multiplier); } // 0x6DB47AA77FD94E09
	static void SET_SPECIAL_ABILITY_MULTIPLIER(float multiplier) { invoke<Void>(0xA49C426ED0CA4AB7, multiplier); } // 0xA49C426ED0CA4AB7
	static void SET_SWIM_MULTIPLIER_FOR_PLAYER(Player player, float multiplier) { invoke<Void>(0xA91C6F0FF7D16A13, player, multiplier); } // 0xA91C6F0FF7D16A13
	static void SET_WANTED_LEVEL_DIFFICULTY(Player player, float difficulty) { invoke<Void>(0x9B0BB33B04405E7A, player, difficulty); } // 0x9B0BB33B04405E7A
	static void SET_WANTED_LEVEL_MULTIPLIER(float multiplier) { invoke<Void>(0x20E5F00CDA207BA, multiplier); } // 0x20E5F00CDA207BA
	static void SIMULATE_PLAYER_INPUT_GAIT(Player control, float amount, int gaitType, float speed, BOOL p4, BOOL p5) { invoke<Void>(0x477D5D63E63ECA5D, control, amount, gaitType, speed, p4, p5); } // 0x477D5D63E63ECA5D
	static void SPECIAL_ABILITY_CHARGE_ABSOLUTE(Player player, int p1, BOOL p2) { invoke<Void>(0xB7B0870EB531D08D, player, p1, p2); } // 0xB7B0870EB531D08D
	static void SPECIAL_ABILITY_CHARGE_CONTINUOUS(Player player, Ped p2) { invoke<Void>(0xED481732DFF7E997, player, p2); } // 0xED481732DFF7E997
	static void SPECIAL_ABILITY_CHARGE_LARGE(Player player, BOOL p1, BOOL p2) { invoke<Void>(0xF733F45FA4497D93, player, p1, p2); } // 0xF733F45FA4497D93
	static void SPECIAL_ABILITY_CHARGE_MEDIUM(Player player, BOOL p1, BOOL p2) { invoke<Void>(0xF113E3AA9BC54613, player, p1, p2); } // 0xF113E3AA9BC54613
	static void SPECIAL_ABILITY_CHARGE_NORMALIZED(Player player, float normalizedValue, BOOL p2) { invoke<Void>(0xA0696A65F009EE18, player, normalizedValue, p2); } // 0xA0696A65F009EE18
	static void SPECIAL_ABILITY_CHARGE_SMALL(Player player, BOOL p1, BOOL p2) { invoke<Void>(0x2E7B9B683481687D, player, p1, p2); } // 0x2E7B9B683481687D
	static void SPECIAL_ABILITY_DEACTIVATE(Player player) { invoke<Void>(0xD6A953C6D1492057, player); } // 0xD6A953C6D1492057
	static void SPECIAL_ABILITY_DEACTIVATE_FAST(Player player) { invoke<Void>(0x9CB5CE07A3968D5A, player); } // 0x9CB5CE07A3968D5A
	static void SPECIAL_ABILITY_DEPLETE_METER(Player player, BOOL p1) { invoke<Void>(0x1D506DBBBC51E64B, player, p1); } // 0x1D506DBBBC51E64B
	static void SPECIAL_ABILITY_FILL_METER(Player player, BOOL p1) { invoke<Void>(0x3DACA8DDC6FD4980, player, p1); } // 0x3DACA8DDC6FD4980
	static void SPECIAL_ABILITY_LOCK(Hash playerModel) { invoke<Void>(0x6A09D0D590A47D13, playerModel); } // 0x6A09D0D590A47D13
	static void SPECIAL_ABILITY_RESET(Player player) { invoke<Void>(0x375F0E738F861A94, player); } // 0x375F0E738F861A94
	static void SPECIAL_ABILITY_UNLOCK(Hash playerModel) { invoke<Void>(0xF145F3BE2EFA9A3B, playerModel); } // 0xF145F3BE2EFA9A3B
	static void START_FIRING_AMNESTY(int duration) { invoke<Void>(0xBF9BD71691857E48, duration); } // 0xBF9BD71691857E48
	static void START_PLAYER_TELEPORT(Player player, float x, float y, float z, float heading, BOOL p5, BOOL p6, BOOL p7) { invoke<Void>(0xAD15F075A4DA0FDE, player, x, y, z, heading, p5, p6, p7); } // 0xAD15F075A4DA0FDE
	static void STOP_PLAYER_TELEPORT() { invoke<Void>(0xC449EDED9D73009C); } // 0xC449EDED9D73009C
	static void _SWITCH_CRIME_TYPE(Player player, int p1) { invoke<Void>(0x9A987297ED8BD838, player, p1); } // 0x9A987297ED8BD838
}

namespace RECORDING
{
	static BOOL _IS_RECORDING() { return invoke<BOOL>(0x1897CA71995A90B4); } // 0x1897CA71995A90B4
	static void _0x13B350B8AD0EEE10() { invoke<Void>(0x13B350B8AD0EEE10); } // 0x13B350B8AD0EEE10
	static void _0x208784099002BC30(char* missionNameLabel, Any p1) { invoke<Void>(0x208784099002BC30, missionNameLabel, p1); } // 0x208784099002BC30
	static void _0x293220DA1B46CEBC(float p0, float p1, BOOL p2) { invoke<Void>(0x293220DA1B46CEBC, p0, p1, p2); } // 0x293220DA1B46CEBC
	static BOOL _0x33D47E85B476ABCD(BOOL* p0) { return invoke<BOOL>(0x33D47E85B476ABCD, p0); } // 0x33D47E85B476ABCD
	static Any _0x4282E08174868BE3() { return invoke<Any>(0x4282E08174868BE3); } // 0x4282E08174868BE3
	static void _0x48621C9FCA3EBD28(BOOL p0) { invoke<Void>(0x48621C9FCA3EBD28, p0); } // 0x48621C9FCA3EBD28
	static BOOL _0x644546EC5287471B() { return invoke<BOOL>(0x644546EC5287471B); } // 0x644546EC5287471B
	static void _0x66972397E0757E7A(Any p0, Any p1, Any p2) { invoke<Void>(0x66972397E0757E7A, p0, p1, p2); } // 0x66972397E0757E7A
	static void _0x81CBAE94390F9F89() { invoke<Void>(0x81CBAE94390F9F89); } // 0x81CBAE94390F9F89
	static void _0xAF66DCEE6609B148() { invoke<Void>(0xAF66DCEE6609B148); } // 0xAF66DCEE6609B148
	static Any _0xDF4B952F7D381B95() { return invoke<Any>(0xDF4B952F7D381B95); } // 0xDF4B952F7D381B95
	static void _0xF854439EFBB3B583() { invoke<Void>(0xF854439EFBB3B583); } // 0xF854439EFBB3B583
	static void _START_RECORDING(int mode) { invoke<Void>(0xC3AC2FFF9612AC81, mode); } // 0xC3AC2FFF9612AC81
	static void _STOP_RECORDING_AND_DISCARD_CLIP() { invoke<Void>(0x88BB3507ED41A240); } // 0x88BB3507ED41A240
	static void _STOP_RECORDING_AND_SAVE_CLIP() { invoke<Void>(0x71A5197D6AFC8B3); } // 0x71A5197D6AFC8B3
	static void _STOP_RECORDING_THIS_FRAME() { invoke<Void>(0xEB2D525B57F42B40); } // 0xEB2D525B57F42B40
}

namespace RENDERING
{
	static void _ACTIVATE_ROCKSTAR_EDITOR() { invoke<Void>(0x49DA8145672B2725); } // 0x49DA8145672B2725
	static BOOL _IS_INTERIOR_RENDERING_DISABLED() { return invoke<BOOL>(0x95AB8B5C992C7B58); } // 0x95AB8B5C992C7B58
	static void _0x5AD3932DAEB1E5D3() { invoke<Void>(0x5AD3932DAEB1E5D3); } // 0x5AD3932DAEB1E5D3
	static void _0x7E2BD3EF6C205F09(char* p0, BOOL p1) { invoke<Void>(0x7E2BD3EF6C205F09, p0, p1); } // 0x7E2BD3EF6C205F09
	static void _0xE058175F8EAFE79A(BOOL p0) { invoke<Void>(0xE058175F8EAFE79A, p0); } // 0xE058175F8EAFE79A
	static void _RESET_EDITOR_VALUES() { invoke<Void>(0x3353D13F09307691); } // 0x3353D13F09307691
}

namespace SCRIPT
{
	static void _BEGIN_ENUMERATING_THREADS() { invoke<Void>(0xDADFADA5A20143A8); } // 0xDADFADA5A20143A8
	static BOOL DOES_SCRIPT_EXIST(char* scriptName) { return invoke<BOOL>(0xFC04745FBE67C19A, scriptName); } // 0xFC04745FBE67C19A
	static BOOL _DOES_SCRIPT_WITH_NAME_HASH_EXIST(Hash scriptHash) { return invoke<BOOL>(0xF86AA3C56BA31381, scriptHash); } // 0xF86AA3C56BA31381
	static int GET_EVENT_AT_INDEX(int eventGroup, int eventIndex) { return invoke<int>(0xD8F66A3A60C62153, eventGroup, eventIndex); } // 0xD8F66A3A60C62153
	static BOOL GET_EVENT_DATA(int eventGroup, int eventIndex, int* argStruct, int argStructSize) { return invoke<BOOL>(0x2902843FCD2B2D79, eventGroup, eventIndex, argStruct, argStructSize); } // 0x2902843FCD2B2D79
	static BOOL GET_EVENT_EXISTS(int eventGroup, int eventIndex) { return invoke<BOOL>(0x936E6168A9BCEDB5, eventGroup, eventIndex); } // 0x936E6168A9BCEDB5
	static Hash GET_HASH_OF_THIS_SCRIPT_NAME() { return invoke<Hash>(0x8A1C8B1738FFE87E); } // 0x8A1C8B1738FFE87E
	static int _GET_ID_OF_NEXT_THREAD_IN_ENUMERATION() { return invoke<int>(0x30B4FA1C82DD4B9F); } // 0x30B4FA1C82DD4B9F
	static int GET_ID_OF_THIS_THREAD() { return invoke<int>(0xC30338E8088E2E21); } // 0xC30338E8088E2E21
	static char* _GET_NAME_OF_THREAD(int threadId) { return invoke<char*>(0x5A42BA9FC8DA96B, threadId); } // 0x5A42BA9FC8DA96B
	static BOOL _GET_NO_LOADING_SCREEN() { return invoke<BOOL>(0x18C1270EA7F199BC); } // 0x18C1270EA7F199BC
	static int GET_NUMBER_OF_EVENTS(int eventGroup) { return invoke<int>(0x5F92A689A06620AA, eventGroup); } // 0x5F92A689A06620AA
	static int _GET_NUMBER_OF_INSTANCES_OF_SCRIPT_WITH_NAME_HASH(Hash scriptHash) { return invoke<int>(0x2C83A9DA6BFFC4F9, scriptHash); } // 0x2C83A9DA6BFFC4F9
	static char* GET_THIS_SCRIPT_NAME() { return invoke<char*>(0x442E0A7EDE4A738A); } // 0x442E0A7EDE4A738A
	static BOOL HAS_SCRIPT_LOADED(char* scriptName) { return invoke<BOOL>(0xE6CC9F3BA0FB9EF1, scriptName); } // 0xE6CC9F3BA0FB9EF1
	static BOOL HAS_SCRIPT_WITH_NAME_HASH_LOADED(Hash scriptHash) { return invoke<BOOL>(0x5F0F0C783EB16C04, scriptHash); } // 0x5F0F0C783EB16C04
	static BOOL IS_THREAD_ACTIVE(int threadId) { return invoke<BOOL>(0x46E9AE36D8FA6417, threadId); } // 0x46E9AE36D8FA6417
	static void _0xA40CC53DF8E50837(BOOL p0, Any args, int argCount, int bit) { invoke<Void>(0xA40CC53DF8E50837, p0, args, argCount, bit); } // 0xA40CC53DF8E50837
	static void _0xB1577667C3708F9B() { invoke<Void>(0xB1577667C3708F9B); } // 0xB1577667C3708F9B
	static void REQUEST_SCRIPT(char* scriptName) { invoke<Void>(0x6EB5F71AA68F2E8E, scriptName); } // 0x6EB5F71AA68F2E8E
	static void REQUEST_SCRIPT_WITH_NAME_HASH(Hash scriptHash) { invoke<Void>(0xD62A67D26D9653E6, scriptHash); } // 0xD62A67D26D9653E6
	static void SET_NO_LOADING_SCREEN(BOOL toggle) { invoke<Void>(0x5262CC1995D07E09, toggle); } // 0x5262CC1995D07E09
	static void SET_SCRIPT_AS_NO_LONGER_NEEDED(char* scriptName) { invoke<Void>(0xC90D2DCACD56184C, scriptName); } // 0xC90D2DCACD56184C
	static void SET_SCRIPT_WITH_NAME_HASH_AS_NO_LONGER_NEEDED(Hash scriptHash) { invoke<Void>(0xC5BC038960E9DB27, scriptHash); } // 0xC5BC038960E9DB27
	static void SHUTDOWN_LOADING_SCREEN() { invoke<Void>(0x78EBE9809CCD637); } // 0x78EBE9809CCD637
	static void TERMINATE_THIS_THREAD() { invoke<Void>(0x1090044AD1DA76FA); } // 0x1090044AD1DA76FA
	static void TERMINATE_THREAD(int threadId) { invoke<Void>(0xC8B189ED9138BCD4, threadId); } // 0xC8B189ED9138BCD4
	static void TRIGGER_SCRIPT_EVENT(int eventGroup, int* args, int argCount, int bit) { invoke<Void>(0x5AE99C571D5BBE5D, eventGroup, args, argCount, bit); } // 0x5AE99C571D5BBE5D
}

namespace SHAPETEST
{
	static int GET_SHAPE_TEST_RESULT(int rayHandle, BOOL* hit, Vector3* endCoords, Vector3* surfaceNormal, Entity* entityHit) { return invoke<int>(0x3D87450E15D98694, rayHandle, hit, endCoords, surfaceNormal, entityHit); } // 0x3D87450E15D98694
	static int _GET_SHAPE_TEST_RESULT_EX(int rayHandle, BOOL* hit, Vector3* endCoords, Vector3* surfaceNormal, Hash* materialHash, Entity* entityHit) { return invoke<int>(0x65287525D951F6BE, rayHandle, hit, endCoords, surfaceNormal, materialHash, entityHit); } // 0x65287525D951F6BE
	static void _SHAPE_TEST_RESULT_ENTITY(Entity entityHit) { invoke<Void>(0x2B3334BCA57CD799, entityHit); } // 0x2B3334BCA57CD799
	static int START_SHAPE_TEST_BOUND(Entity entity, int flags1, int flags2) { return invoke<int>(0x37181417CE7C8900, entity, flags1, flags2); } // 0x37181417CE7C8900
	static int START_SHAPE_TEST_BOUNDING_BOX(Entity entity, int flags1, int flags2) { return invoke<int>(0x52837721A854EC7, entity, flags1, flags2); } // 0x52837721A854EC7
	static int START_SHAPE_TEST_BOX(float x, float y, float z, float x1, float y2, float z2, float rotX, float rotY, float rotZ, Any p9, Any p10, Any entity, Any p12) { return invoke<int>(0xFE466162C4401D18, x, y, z, x1, y2, z2, rotX, rotY, rotZ, p9, p10, entity, p12); } // 0xFE466162C4401D18
	static int START_SHAPE_TEST_CAPSULE(float x1, float y1, float z1, float x2, float y2, float z2, float radius, int flags, Entity entity, int p9) { return invoke<int>(0x28579D1B8F8AAC80, x1, y1, z1, x2, y2, z2, radius, flags, entity, p9); } // 0x28579D1B8F8AAC80
	static int _START_SHAPE_TEST_CAPSULE_2(float x1, float y1, float z1, float x2, float y2, float z2, float radius, int flags, Entity entity, Any p9) { return invoke<int>(0xE6AC6C45FBE83004, x1, y1, z1, x2, y2, z2, radius, flags, entity, p9); } // 0xE6AC6C45FBE83004
	static int START_SHAPE_TEST_LOS_PROBE(float x1, float y1, float z1, float x2, float y2, float z2, int flags, Entity ent, int p8) { return invoke<int>(0x7EE9F5D83DD4F90E, x1, y1, z1, x2, y2, z2, flags, ent, p8); } // 0x7EE9F5D83DD4F90E
	static int _START_SHAPE_TEST_RAY(float x1, float y1, float z1, float x2, float y2, float z2, int flags, Entity entity, int p8) { return invoke<int>(0x377906D8A31E5586, x1, y1, z1, x2, y2, z2, flags, entity, p8); } // 0x377906D8A31E5586
	static int _START_SHAPE_TEST_SURROUNDING_COORDS(Vector3* pVec1, Vector3* pVec2, int flag, Entity entity, int flag2) { return invoke<int>(0xFF6BE494C7987F34, pVec1, pVec2, flag, entity, flag2); } // 0xFF6BE494C7987F34
}

namespace SOCIALCLUB
{
	static int _GET_TOTAL_SC_INBOX_IDS() { return invoke<int>(0x3A93FF1A2CA0864); } // 0x3A93FF1A2CA0864
	static BOOL _IS_SC_INBOX_VALID(int p0) { return invoke<BOOL>(0x93028F1DB42BFD08, p0); } // 0x93028F1DB42BFD08
	static Any _0x07C61676E5BB52CD(Any p0) { return invoke<Any>(0x7C61676E5BB52CD, p0); } // 0x7C61676E5BB52CD
	static Any _0x07DBD622D9533857(Any p0) { return invoke<Any>(0x7DBD622D9533857, p0); } // 0x7DBD622D9533857
	static BOOL _0x0F73393BAC7E6730(Any* p0, int* p1) { return invoke<BOOL>(0xF73393BAC7E6730, p0, p1); } // 0xF73393BAC7E6730
	static void _0x116FB94DC4B79F17(char* p0) { invoke<Void>(0x116FB94DC4B79F17, p0); } // 0x116FB94DC4B79F17
	static Any _0x16DA8172459434AA() { return invoke<Any>(0x16DA8172459434AA); } // 0x16DA8172459434AA
	static BOOL _0x19853B5B17D77BCA(Any p0, Any* p1) { return invoke<BOOL>(0x19853B5B17D77BCA, p0, p1); } // 0x19853B5B17D77BCA
	static BOOL _0x1989C6E6F67E76A8(Any* p0, Any* p1, Any* p2) { return invoke<BOOL>(0x1989C6E6F67E76A8, p0, p1, p2); } // 0x1989C6E6F67E76A8
	static Any _0x1D4446A62D35B0D0(Any p0, Any p1) { return invoke<Any>(0x1D4446A62D35B0D0, p0, p1); } // 0x1D4446A62D35B0D0
	static BOOL _0x1F1E9682483697C7(Any p0, Any p1) { return invoke<BOOL>(0x1F1E9682483697C7, p0, p1); } // 0x1F1E9682483697C7
	static BOOL _0x225798743970412B(int* p0) { return invoke<BOOL>(0x225798743970412B, p0); } // 0x225798743970412B
	static BOOL _0x287F1F75D2803595(Any p0, Any* p1) { return invoke<BOOL>(0x287F1F75D2803595, p0, p1); } // 0x287F1F75D2803595
	static Any _0x2E89990DDFF670C3(Any p0, Any p1) { return invoke<Any>(0x2E89990DDFF670C3, p0, p1); } // 0x2E89990DDFF670C3
	static BOOL _0x3001BEF2FECA3680() { return invoke<BOOL>(0x3001BEF2FECA3680); } // 0x3001BEF2FECA3680
	static BOOL _0x418DC16FAE452C1C(int p0) { return invoke<BOOL>(0x418DC16FAE452C1C, p0); } // 0x418DC16FAE452C1C
	static void _0x44ACA259D67651DB(Any* p0, Any p1) { invoke<Void>(0x44ACA259D67651DB, p0, p1); } // 0x44ACA259D67651DB
	static BOOL _0x4737980E8A283806(int p0, Any* p1) { return invoke<BOOL>(0x4737980E8A283806, p0, p1); } // 0x4737980E8A283806
	static BOOL _0x487912FD248EFDDF(Any p0, float p1) { return invoke<BOOL>(0x487912FD248EFDDF, p0, p1); } // 0x487912FD248EFDDF
	static Any _0x4A7D6E727F941747(Any* p0) { return invoke<Any>(0x4A7D6E727F941747, p0); } // 0x4A7D6E727F941747
	static Any _0x5C4EBFFA98BDB41C(Any p0) { return invoke<Any>(0x5C4EBFFA98BDB41C, p0); } // 0x5C4EBFFA98BDB41C
	static void _0x675721C9F644D161() { invoke<Void>(0x675721C9F644D161); } // 0x675721C9F644D161
	static BOOL _0x699E4A5C8C893A18(int p0, char* p1, Any* p2) { return invoke<BOOL>(0x699E4A5C8C893A18, p0, p1, p2); } // 0x699E4A5C8C893A18
	static BOOL _0x6AFD2CD753FEEF83(char* playerName) { return invoke<BOOL>(0x6AFD2CD753FEEF83, playerName); } // 0x6AFD2CD753FEEF83
	static BOOL _0x6BFB12CE158E3DD4(Any p0) { return invoke<BOOL>(0x6BFB12CE158E3DD4, p0); } // 0x6BFB12CE158E3DD4
	static Any _0x700569DBA175A77C(Any p0) { return invoke<Any>(0x700569DBA175A77C, p0); } // 0x700569DBA175A77C
	static Any _0x7DB18CA8CAD5B098() { return invoke<Any>(0x7DB18CA8CAD5B098); } // 0x7DB18CA8CAD5B098
	static Any _0x8147FFF6A718E1AD(Any p0) { return invoke<Any>(0x8147FFF6A718E1AD, p0); } // 0x8147FFF6A718E1AD
	static BOOL _0x8416FE4E4629D7D7(char* p0) { return invoke<BOOL>(0x8416FE4E4629D7D7, p0); } // 0x8416FE4E4629D7D7
	static Any _0x85535ACF97FC0969(Any p0) { return invoke<Any>(0x85535ACF97FC0969, p0); } // 0x85535ACF97FC0969
	static BOOL _0x87E0052F08BD64E6(Any p0, int* p1) { return invoke<BOOL>(0x87E0052F08BD64E6, p0, p1); } // 0x87E0052F08BD64E6
	static BOOL _0x8CC469AB4D349B7C(int p0, char* p1, Any* p2) { return invoke<BOOL>(0x8CC469AB4D349B7C, p0, p1, p2); } // 0x8CC469AB4D349B7C
	static Any _0x9237E334F6E43156(Any p0) { return invoke<Any>(0x9237E334F6E43156, p0); } // 0x9237E334F6E43156
	static BOOL _0x92DA6E70EF249BD1(char* p0, int* p1) { return invoke<BOOL>(0x92DA6E70EF249BD1, p0, p1); } // 0x92DA6E70EF249BD1
	static int _0x930DE22F07B1CCE3(Any p0) { return invoke<int>(0x930DE22F07B1CCE3, p0); } // 0x930DE22F07B1CCE3
	static void _0xA68D3D229F4F3B06(char* p0) { invoke<Void>(0xA68D3D229F4F3B06, p0); } // 0xA68D3D229F4F3B06
	static Any _0xBC1CC91205EC8D6E() { return invoke<Any>(0xBC1CC91205EC8D6E); } // 0xBC1CC91205EC8D6E
	static void _0xBFA0A56A817C6C7D(BOOL p0) { invoke<Void>(0xBFA0A56A817C6C7D, p0); } // 0xBFA0A56A817C6C7D
	static BOOL _0xD0EE05FE193646EA(Any* p0, Any* p1, Any* p2) { return invoke<BOOL>(0xD0EE05FE193646EA, p0, p1, p2); } // 0xD0EE05FE193646EA
	static Any _0xD302E99EDF0449CF(Any p0) { return invoke<Any>(0xD302E99EDF0449CF, p0); } // 0xD302E99EDF0449CF
	static Any _0xD8122C407663B995() { return invoke<Any>(0xD8122C407663B995); } // 0xD8122C407663B995
	static void _0xDA024BDBD600F44A(int* networkHandle) { invoke<Void>(0xDA024BDBD600F44A, networkHandle); } // 0xDA024BDBD600F44A
	static Any _0xDF649C4E9AFDD788() { return invoke<Any>(0xDF649C4E9AFDD788); } // 0xDF649C4E9AFDD788
	static Any _0xEB2BF817463DFA28(Any p0, Any p1) { return invoke<Any>(0xEB2BF817463DFA28, p0, p1); } // 0xEB2BF817463DFA28
	static BOOL _0xF22CA0FD74B80E7A(Any p0) { return invoke<BOOL>(0xF22CA0FD74B80E7A, p0); } // 0xF22CA0FD74B80E7A
	static BOOL _0xF6BAAAF762E1BF40(char* p0, int* p1) { return invoke<BOOL>(0xF6BAAAF762E1BF40, p0, p1); } // 0xF6BAAAF762E1BF40
	static BOOL _0xFE4C1D0D3B9CC17E(Any p0, Any p1) { return invoke<BOOL>(0xFE4C1D0D3B9CC17E, p0, p1); } // 0xFE4C1D0D3B9CC17E
	static Any _0xFF8F3A92B75ED67A() { return invoke<Any>(0xFF8F3A92B75ED67A); } // 0xFF8F3A92B75ED67A
	static void SC_EMAIL_MESSAGE_CLEAR_RECIP_LIST() { invoke<Void>(0x55DF6DB45179236E); } // 0x55DF6DB45179236E
	static void SC_EMAIL_MESSAGE_PUSH_GAMER_TO_RECIP_LIST(Player* player) { invoke<Void>(0x2330C12A7A605D16, player); } // 0x2330C12A7A605D16
	static int _SC_GET_CHECK_STRING_STATUS(int taskHandle) { return invoke<int>(0x82E4A58BABC15AE7, taskHandle); } // 0x82E4A58BABC15AE7
	static Entity _SC_GET_NICKNAME() { return invoke<Entity>(0x198D161F458ECC7F); } // 0x198D161F458ECC7F
	static BOOL _SC_HAS_CHECK_STRING_TASK_COMPLETED(int taskHandle) { return invoke<BOOL>(0x1753344C770358AE, taskHandle); } // 0x1753344C770358AE
	static void _SC_INBOX_GET_EMAILS(int offset, int limit) { invoke<Void>(0x40ADDCBAFA1018A, offset, limit); } // 0x40ADDCBAFA1018A
	static BOOL _SC_INBOX_MESSAGE_GET_DATA_BOOL(int p0, char* p1) { return invoke<BOOL>(0xFFE5C16F402D851D, p0, p1); } // 0xFFE5C16F402D851D
	static BOOL SC_INBOX_MESSAGE_GET_DATA_INT(int p0, char* context, int* out) { return invoke<BOOL>(0xA00EFE4082C4056E, p0, context, out); } // 0xA00EFE4082C4056E
	static BOOL SC_INBOX_MESSAGE_GET_DATA_STRING(int p0, char* context, char* out) { return invoke<BOOL>(0x7572EF42FC6A9B6D, p0, context, out); } // 0x7572EF42FC6A9B6D
	static char* _SC_INBOX_MESSAGE_GET_STRING(int p0) { return invoke<char*>(0xF3E31D16CBDCB304, p0); } // 0xF3E31D16CBDCB304
	static BOOL SC_INBOX_MESSAGE_GET_UGCDATA(Any p0, Any* p1) { return invoke<BOOL>(0x69D82604A1A5A254, p0, p1); } // 0x69D82604A1A5A254
	static Hash _SC_INBOX_MESSAGE_INIT(int p0) { return invoke<Hash>(0xBB8EA16ECBC976C4, p0); } // 0xBB8EA16ECBC976C4
	static BOOL _SC_INBOX_MESSAGE_POP(int p0) { return invoke<BOOL>(0x2C015348CF19CA1D, p0); } // 0x2C015348CF19CA1D
	static BOOL _SC_INBOX_MESSAGE_PUSH(int p0) { return invoke<BOOL>(0x9A2C8064B6C1E41A, p0); } // 0x9A2C8064B6C1E41A
	static BOOL _SC_START_CHECK_STRING_TASK(char* string, int* taskHandle) { return invoke<BOOL>(0x75632C5ECD7ED843, string, taskHandle); } // 0x75632C5ECD7ED843
}

namespace STATS
{
	static Hash _GET_NGSTAT_BOOL_HASH(int index, BOOL spStat, BOOL charStat, int character, char* section) { return invoke<Hash>(0xBA52FF538ED2BC71, index, spStat, charStat, character, section); } // 0xBA52FF538ED2BC71
	static Hash _GET_NGSTAT_INT_HASH(int index, BOOL spStat, BOOL charStat, int character, char* section) { return invoke<Hash>(0x2B4CDCA6F07FF3DA, index, spStat, charStat, character, section); } // 0x2B4CDCA6F07FF3DA
	static Hash _GET_PSTAT_BOOL_HASH(int index, BOOL spStat, BOOL charStat, int character) { return invoke<Hash>(0x80C75307B1C42837, index, spStat, charStat, character); } // 0x80C75307B1C42837
	static Hash _GET_PSTAT_INT_HASH(int index, BOOL spStat, BOOL charStat, int character) { return invoke<Hash>(0x61E111E323419E07, index, spStat, charStat, character); } // 0x61E111E323419E07
	static Hash _GET_TUPSTAT_BOOL_HASH(int index, BOOL spStat, BOOL charStat, int character) { return invoke<Hash>(0xC4BB08EE7907471E, index, spStat, charStat, character); } // 0xC4BB08EE7907471E
	static Hash _GET_TUPSTAT_INT_HASH(int index, BOOL spStat, BOOL charStat, int character) { return invoke<Hash>(0xD16C2AD6B8E32854, index, spStat, charStat, character); } // 0xD16C2AD6B8E32854
	static BOOL LEADERBOARDS2_READ_BY_HANDLE(Any* p0, Any* p1) { return invoke<BOOL>(0xC30713A383BFBF0E, p0, p1); } // 0xC30713A383BFBF0E
	static BOOL LEADERBOARDS2_READ_BY_RADIUS(Any* p0, Any p1, Any* p2) { return invoke<BOOL>(0x5CE587FB5A42C8C4, p0, p1, p2); } // 0x5CE587FB5A42C8C4
	static BOOL LEADERBOARDS2_READ_BY_RANK(Any* p0, Any p1, Any p2) { return invoke<BOOL>(0xBA2C7DB0C129449A, p0, p1, p2); } // 0xBA2C7DB0C129449A
	static BOOL LEADERBOARDS2_READ_BY_ROW(Any* p0, Any* p1, Any p2, Any* p3, Any p4, Any* p5, Any p6) { return invoke<BOOL>(0xA9CDB1E3F0A49883, p0, p1, p2, p3, p4, p5, p6); } // 0xA9CDB1E3F0A49883
	static BOOL LEADERBOARDS2_READ_BY_SCORE_FLOAT(Any* p0, float p1, Any p2) { return invoke<BOOL>(0xE662C8B759D08F3C, p0, p1, p2); } // 0xE662C8B759D08F3C
	static BOOL LEADERBOARDS2_READ_BY_SCORE_INT(Any* p0, Any p1, Any p2) { return invoke<BOOL>(0x7EEC7E4F6984A16A, p0, p1, p2); } // 0x7EEC7E4F6984A16A
	static BOOL LEADERBOARDS2_READ_FRIENDS_BY_ROW(Any* p0, Any* p1, Any p2, BOOL p3, Any p4, Any p5) { return invoke<BOOL>(0x918B101666F9CB83, p0, p1, p2, p3, p4, p5); } // 0x918B101666F9CB83
	static BOOL LEADERBOARDS2_WRITE_DATA(Any* p0) { return invoke<BOOL>(0xAE2206545888AE49, p0); } // 0xAE2206545888AE49
	static BOOL LEADERBOARDS_CACHE_DATA_ROW(Any* p0) { return invoke<BOOL>(0xB9BB18E2C40142ED, p0); } // 0xB9BB18E2C40142ED
	static void LEADERBOARDS_CLEAR_CACHE_DATA() { invoke<Void>(0xD4B02A6B476E1FDC); } // 0xD4B02A6B476E1FDC
	static void _LEADERBOARDS_DEATHS(Hash statName, float value) { invoke<Void>(0x428EAF89E24F6C36, statName, value); } // 0x428EAF89E24F6C36
	static BOOL LEADERBOARDS_GET_CACHE_DATA_ROW(Any p0, Any p1, Any* p2) { return invoke<BOOL>(0x9120E8DBA3D69273, p0, p1, p2); } // 0x9120E8DBA3D69273
	static BOOL LEADERBOARDS_GET_CACHE_EXISTS(Any p0) { return invoke<BOOL>(0x9C51349BE6CDFE2C, p0); } // 0x9C51349BE6CDFE2C
	static Any LEADERBOARDS_GET_CACHE_TIME(Any p0) { return invoke<Any>(0xF04C1C27DA35F6C8, p0); } // 0xF04C1C27DA35F6C8
	static Any LEADERBOARDS_GET_COLUMN_ID(Any p0, Any p1, Any p2) { return invoke<Any>(0xC4B5467A1886EA7E, p0, p1, p2); } // 0xC4B5467A1886EA7E
	static Any LEADERBOARDS_GET_COLUMN_TYPE(Any p0, Any p1, Any p2) { return invoke<Any>(0xBF4FEF46DB7894D3, p0, p1, p2); } // 0xBF4FEF46DB7894D3
	static Any LEADERBOARDS_GET_NUMBER_OF_COLUMNS(Any p0, Any p1) { return invoke<Any>(0x117B45156D7EFF2E, p0, p1); } // 0x117B45156D7EFF2E
	static Any LEADERBOARDS_READ_CLEAR(Any p0, Any p1, Any p2) { return invoke<Any>(0x7CCE5C737A665701, p0, p1, p2); } // 0x7CCE5C737A665701
	static Any LEADERBOARDS_READ_CLEAR_ALL() { return invoke<Any>(0xA34CB6E6F0DF4A0B); } // 0xA34CB6E6F0DF4A0B
	static BOOL LEADERBOARDS_READ_PENDING(Any p0, Any p1, Any p2) { return invoke<BOOL>(0xAC392C8483342AC2, p0, p1, p2); } // 0xAC392C8483342AC2
	static BOOL LEADERBOARDS_READ_SUCCESSFUL(Any p0, Any p1, Any p2) { return invoke<BOOL>(0x2FB19228983E832C, p0, p1, p2); } // 0x2FB19228983E832C
	static void _0x015B03EE1C43E6EC(Any p0) { invoke<Void>(0x15B03EE1C43E6EC, p0); } // 0x15B03EE1C43E6EC
	static void _0x03C2EEBB04B3FB72(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0x3C2EEBB04B3FB72, p0, p1, p2, p3, p4, p5, p6); } // 0x3C2EEBB04B3FB72
	static void _0x047CBED6F6F8B63C() { invoke<Void>(0x47CBED6F6F8B63C); } // 0x47CBED6F6F8B63C
	static void _0x04D90BA8207ADA2D(Any p0) { invoke<Void>(0x4D90BA8207ADA2D, p0); } // 0x4D90BA8207ADA2D
	static void _0x06EAF70AE066441E(Any p0) { invoke<Void>(0x6EAF70AE066441E, p0); } // 0x6EAF70AE066441E
	static void _0x098760C7461724CD() { invoke<Void>(0x98760C7461724CD); } // 0x98760C7461724CD
	static void _0x0A50D2604E05CB94(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xA50D2604E05CB94, p0, p1, p2, p3, p4); } // 0xA50D2604E05CB94
	static void _0x0A9C7F36E5D7B683(Any p0) { invoke<Void>(0xA9C7F36E5D7B683, p0); } // 0xA9C7F36E5D7B683
	static void _0x0B565B0AAE56A0E8(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0xB565B0AAE56A0E8, p0, p1, p2, p3, p4, p5, p6); } // 0xB565B0AAE56A0E8
	static Any _0x0B8B7F74BF061C6D() { return invoke<Any>(0xB8B7F74BF061C6D); } // 0xB8B7F74BF061C6D
	static void _0x0BCA1D2C47B0D269(Any p0, Any p1, float p2) { invoke<Void>(0xBCA1D2C47B0D269, p0, p1, p2); } // 0xBCA1D2C47B0D269
	static void _0x0D01D20616FC73FB(Any p0, Any p1) { invoke<Void>(0xD01D20616FC73FB, p0, p1); } // 0xD01D20616FC73FB
	static void _0x0EACDF8487D5155A(Any p0) { invoke<Void>(0xEACDF8487D5155A, p0); } // 0xEACDF8487D5155A
	static void _0x11FF1C80276097ED(char* p0, Any p1, Any p2) { invoke<Void>(0x11FF1C80276097ED, p0, p1, p2); } // 0x11FF1C80276097ED
	static void _0x121FB4DDDC2D5291(Any p0, Any p1, Any p2, float p3) { invoke<Void>(0x121FB4DDDC2D5291, p0, p1, p2, p3); } // 0x121FB4DDDC2D5291
	static void _0x14E0B2D1AD1044E0(Any* p0, Any* p1, Any* p2, Any* p3) { invoke<Void>(0x14E0B2D1AD1044E0, p0, p1, p2, p3); } // 0x14E0B2D1AD1044E0
	static void _0x14EDA9EE27BD1626(Any p0) { invoke<Void>(0x14EDA9EE27BD1626, p0); } // 0x14EDA9EE27BD1626
	static void _0x164C5FF663790845(Any p0) { invoke<Void>(0x164C5FF663790845, p0); } // 0x164C5FF663790845
	static void _0x1A7CE7CD3E653485(Any p0) { invoke<Void>(0x1A7CE7CD3E653485, p0); } // 0x1A7CE7CD3E653485
	static Any _0x1A8EA222F9C67DBB(Any p0) { return invoke<Any>(0x1A8EA222F9C67DBB, p0); } // 0x1A8EA222F9C67DBB
	static void _0x1CAE5D2E3F9A07F0(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0x1CAE5D2E3F9A07F0, p0, p1, p2, p3, p4, p5); } // 0x1CAE5D2E3F9A07F0
	static void _0x203B381133817079(Any p0) { invoke<Void>(0x203B381133817079, p0); } // 0x203B381133817079
	static void _0x2605663BD4F23B5D(Any p0) { invoke<Void>(0x2605663BD4F23B5D, p0); } // 0x2605663BD4F23B5D
	static void _0x26D7399B9587FE89(int p0) { invoke<Void>(0x26D7399B9587FE89, p0); } // 0x26D7399B9587FE89
	static void _0x27AA1C973CACFE63(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { invoke<Void>(0x27AA1C973CACFE63, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); } // 0x27AA1C973CACFE63
	static void _0x282B6739644F4347(Any p0) { invoke<Void>(0x282B6739644F4347, p0); } // 0x282B6739644F4347
	static void _0x28ECB8AC2F607DB2(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x28ECB8AC2F607DB2, p0, p1, p2, p3, p4); } // 0x28ECB8AC2F607DB2
	static void _0x2B69F5074C894811(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x2B69F5074C894811, p0, p1, p2, p3); } // 0x2B69F5074C894811
	static void _0x2CD90358F67D0AA8(Any p0) { invoke<Void>(0x2CD90358F67D0AA8, p0); } // 0x2CD90358F67D0AA8
	static void _0x2E65248609523599(Any p0, Any p1, Any p2) { invoke<Void>(0x2E65248609523599, p0, p1, p2); } // 0x2E65248609523599
	static void _0x30A6614C1F7799B8(Any p0, float p1, Any p2) { invoke<Void>(0x30A6614C1F7799B8, p0, p1, p2); } // 0x30A6614C1F7799B8
	static BOOL _0x3270F67EED31FBC1(Any p0, Any* p1, Any* p2) { return invoke<BOOL>(0x3270F67EED31FBC1, p0, p1, p2); } // 0x3270F67EED31FBC1
	static Any _0x32CAC93C9DE73D32() { return invoke<Any>(0x32CAC93C9DE73D32); } // 0x32CAC93C9DE73D32
	static Any _0x33D72899E24C3365(Any p0, Any p1) { return invoke<Any>(0x33D72899E24C3365, p0, p1); } // 0x33D72899E24C3365
	static BOOL _0x34770B9CE0E03B91(Any p0, Any* p1) { return invoke<BOOL>(0x34770B9CE0E03B91, p0, p1); } // 0x34770B9CE0E03B91
	static float _0x38491439B6BA7F7D(Any p0, Any p1) { return invoke<float>(0x38491439B6BA7F7D, p0, p1); } // 0x38491439B6BA7F7D
	static void _0x38BAAA5DD4C9D19F(int value) { invoke<Void>(0x38BAAA5DD4C9D19F, value); } // 0x38BAAA5DD4C9D19F
	static void _0x3DE3AA516FB126A4(Any p0) { invoke<Void>(0x3DE3AA516FB126A4, p0); } // 0x3DE3AA516FB126A4
	static void _0x3EBEAC6C3F81F6BD(Any p0) { invoke<Void>(0x3EBEAC6C3F81F6BD, p0); } // 0x3EBEAC6C3F81F6BD
	static void _0x419615486BBF1956(Any p0) { invoke<Void>(0x419615486BBF1956, p0); } // 0x419615486BBF1956
	static void _0x44919CC079BB60BF(Any p0) { invoke<Void>(0x44919CC079BB60BF, p0); } // 0x44919CC079BB60BF
	static void _0x46326E13DA4E0546(Any* p0) { invoke<Void>(0x46326E13DA4E0546, p0); } // 0x46326E13DA4E0546
	static void _0x47B32F5611E6E483(Any p0) { invoke<Void>(0x47B32F5611E6E483, p0); } // 0x47B32F5611E6E483
	static Any _0x4C89FE2BDEB3F169() { return invoke<Any>(0x4C89FE2BDEB3F169); } // 0x4C89FE2BDEB3F169
	static Any _0x4FEF53183C3C6414() { return invoke<Any>(0x4FEF53183C3C6414); } // 0x4FEF53183C3C6414
	static void _0x5009DFD741329729(char* p0, Any p1) { invoke<Void>(0x5009DFD741329729, p0, p1); } // 0x5009DFD741329729
	static void _0x501478855A6074CE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0x501478855A6074CE, p0, p1, p2, p3, p4, p5); } // 0x501478855A6074CE
	static void _0x516FC96EB88EEFE5(Any p0) { invoke<Void>(0x516FC96EB88EEFE5, p0); } // 0x516FC96EB88EEFE5
	static void _0x53CAE13E9B426993(Any p0) { invoke<Void>(0x53CAE13E9B426993, p0); } // 0x53CAE13E9B426993
	static void _0x55384438FC55AD8E(int value) { invoke<Void>(0x55384438FC55AD8E, value); } // 0x55384438FC55AD8E
	static Any _0x55A8BECAF28A4EB7() { return invoke<Any>(0x55A8BECAF28A4EB7); } // 0x55A8BECAF28A4EB7
	static Any _0x567384DFA67029E6() { return invoke<Any>(0x567384DFA67029E6); } // 0x567384DFA67029E6
	static void _0x5688585E6D563CD8(Any p0) { invoke<Void>(0x5688585E6D563CD8, p0); } // 0x5688585E6D563CD8
	static Any _0x58A651CD201D89AD(Any p0) { return invoke<Any>(0x58A651CD201D89AD, p0); } // 0x58A651CD201D89AD
	static BOOL _0x5A556B229A169402() { return invoke<BOOL>(0x5A556B229A169402); } // 0x5A556B229A169402
	static Any _0x5BD5F255321C4AAF(Any p0) { return invoke<Any>(0x5BD5F255321C4AAF, p0); } // 0x5BD5F255321C4AAF
	static void _0x5DA3A8DE8CB6226F(int time) { invoke<Void>(0x5DA3A8DE8CB6226F, time); } // 0x5DA3A8DE8CB6226F
	static BOOL _0x5EAD2BF6484852E4() { return invoke<BOOL>(0x5EAD2BF6484852E4); } // 0x5EAD2BF6484852E4
	static void _0x5FF2C33B13A02A11(Any p0) { invoke<Void>(0x5FF2C33B13A02A11, p0); } // 0x5FF2C33B13A02A11
	static void _0x60EEDC12AF66E846(Any p0) { invoke<Void>(0x60EEDC12AF66E846, p0); } // 0x60EEDC12AF66E846
	static void _0x629526ABA383BCAA() { invoke<Void>(0x629526ABA383BCAA); } // 0x629526ABA383BCAA
	static void _0x6483C25849031C4F(Any p0, Any p1, Any p2, Any* p3) { invoke<Void>(0x6483C25849031C4F, p0, p1, p2, p3); } // 0x6483C25849031C4F
	static void _0x6551B1F7F6CD46EA(Any p0) { invoke<Void>(0x6551B1F7F6CD46EA, p0); } // 0x6551B1F7F6CD46EA
	static void _0x678F86D8FC040BDB(Any p0) { invoke<Void>(0x678F86D8FC040BDB, p0); } // 0x678F86D8FC040BDB
	static void _0x6A60E43998228229(Any p0) { invoke<Void>(0x6A60E43998228229, p0); } // 0x6A60E43998228229
	static void _0x6BC0ACD0673ACEBE(Any p0, Any p1, Any p2) { invoke<Void>(0x6BC0ACD0673ACEBE, p0, p1, p2); } // 0x6BC0ACD0673ACEBE
	static void _0x6BCCF9948492FD85(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x6BCCF9948492FD85, p0, p1, p2, p3, p4); } // 0x6BCCF9948492FD85
	static BOOL _0x6DEE77AFF8C21BD1(Any* p0, Any* p1) { return invoke<BOOL>(0x6DEE77AFF8C21BD1, p0, p1); } // 0x6DEE77AFF8C21BD1
	static Any _0x6E0A5253375C4584() { return invoke<Any>(0x6E0A5253375C4584); } // 0x6E0A5253375C4584
	static void _0x6F361B8889A792A3() { invoke<Void>(0x6F361B8889A792A3); } // 0x6F361B8889A792A3
	static void _0x7033EEFD9B28088E(Any p0) { invoke<Void>(0x7033EEFD9B28088E, p0); } // 0x7033EEFD9B28088E
	static void _0x71862B1D855F32E1(Any* p0, Any p1, Any p2, Any p3) { invoke<Void>(0x71862B1D855F32E1, p0, p1, p2, p3); } // 0x71862B1D855F32E1
	static void _0x71B008056E5692D6() { invoke<Void>(0x71B008056E5692D6); } // 0x71B008056E5692D6
	static void _0x723C1CE13FBFDB67(Any p0, Any p1) { invoke<Void>(0x723C1CE13FBFDB67, p0, p1); } // 0x723C1CE13FBFDB67
	static void _0x73001E34F85137F8(Any p0) { invoke<Void>(0x73001E34F85137F8, p0); } // 0x73001E34F85137F8
	static void _0x792271AB35C356A4(Any p0, Any p1) { invoke<Void>(0x792271AB35C356A4, p0, p1); } // 0x792271AB35C356A4
	static void _0x79AB33F0FBFAC40C(Any p0) { invoke<Void>(0x79AB33F0FBFAC40C, p0); } // 0x79AB33F0FBFAC40C
	static void _0x7B18DA61F6BAE9D5(Any p0) { invoke<Void>(0x7B18DA61F6BAE9D5, p0); } // 0x7B18DA61F6BAE9D5
	static void _0x7D36291161859389(Any p0) { invoke<Void>(0x7D36291161859389, p0); } // 0x7D36291161859389
	static void _0x7D8BA05688AD64C7(Any p0) { invoke<Void>(0x7D8BA05688AD64C7, p0); } // 0x7D8BA05688AD64C7
	static BOOL _0x7E6946F68A38B74F(Any p0) { return invoke<BOOL>(0x7E6946F68A38B74F, p0); } // 0x7E6946F68A38B74F
	static void _0x7EEC2A316C250073(Any p0, Any p1, Any p2) { invoke<Void>(0x7EEC2A316C250073, p0, p1, p2); } // 0x7EEC2A316C250073
	static BOOL _0x7F2C4CDF2E82DF4C(Any p0) { return invoke<BOOL>(0x7F2C4CDF2E82DF4C, p0); } // 0x7F2C4CDF2E82DF4C
	static void _0x848B66100EE33B05(Any p0) { invoke<Void>(0x848B66100EE33B05, p0); } // 0x848B66100EE33B05
	static Any _0x84A810B375E69C0E() { return invoke<Any>(0x84A810B375E69C0E); } // 0x84A810B375E69C0E
	static void _0x84DFC579C2FC214C(Any p0) { invoke<Void>(0x84DFC579C2FC214C, p0); } // 0x84DFC579C2FC214C
	static void _0x88087EE1F28024AE(Any p0) { invoke<Void>(0x88087EE1F28024AE, p0); } // 0x88087EE1F28024AE
	static Any _0x88578F6EC36B4A3A(Any p0, Any p1) { return invoke<Any>(0x88578F6EC36B4A3A, p0, p1); } // 0x88578F6EC36B4A3A
	static Any _0x886913BBEACA68C1(Any* p0) { return invoke<Any>(0x886913BBEACA68C1, p0); } // 0x886913BBEACA68C1
	static void _0x8989CBD7B4E82534(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0x8989CBD7B4E82534, p0, p1, p2, p3, p4, p5, p6); } // 0x8989CBD7B4E82534
	static void _0x8A800DACCC0DA55D() { invoke<Void>(0x8A800DACCC0DA55D); } // 0x8A800DACCC0DA55D
	static Any _0x8B9CDBD6C566C38C() { return invoke<Any>(0x8B9CDBD6C566C38C); } // 0x8B9CDBD6C566C38C
	static void _0x8C9D11605E59D955(Any p0) { invoke<Void>(0x8C9D11605E59D955, p0); } // 0x8C9D11605E59D955
	static void _0x8D8ADB562F09A245(Any p0) { invoke<Void>(0x8D8ADB562F09A245, p0); } // 0x8D8ADB562F09A245
	static void _0x8EC74CEB042E7CFF(Any p0) { invoke<Void>(0x8EC74CEB042E7CFF, p0); } // 0x8EC74CEB042E7CFF
	static void _0x90D0622866E80445(int p0, char* p1) { invoke<Void>(0x90D0622866E80445, p0, p1); } // 0x90D0622866E80445
	static void _0x928DBFB892638EF3() { invoke<Void>(0x928DBFB892638EF3); } // 0x928DBFB892638EF3
	static void _0x930F504203F561C9(Any p0) { invoke<Void>(0x930F504203F561C9, p0); } // 0x930F504203F561C9
	static int _0x94F12ABF9C79E339(int p0) { return invoke<int>(0x94F12ABF9C79E339, p0); } // 0x94F12ABF9C79E339
	static void _0x96E6D5150DBF1C09(Any p0, Any p1, Any p2) { invoke<Void>(0x96E6D5150DBF1C09, p0, p1, p2); } // 0x96E6D5150DBF1C09
	static void _0x98E2BC1CA26287C3() { invoke<Void>(0x98E2BC1CA26287C3); } // 0x98E2BC1CA26287C3
	static Any _0x9A62EC95AE10E011() { return invoke<Any>(0x9A62EC95AE10E011); } // 0x9A62EC95AE10E011
	static void _0x9B4BD21D69B1E609() { invoke<Void>(0x9B4BD21D69B1E609); } // 0x9B4BD21D69B1E609
	static Any _0x9EC8858184CD253A() { return invoke<Any>(0x9EC8858184CD253A); } // 0x9EC8858184CD253A
	static void _0xA071E0ED98F91286(Any p0, Any p1) { invoke<Void>(0xA071E0ED98F91286, p0, p1); } // 0xA071E0ED98F91286
	static BOOL _0xA0F93D5465B3094D(Any* p0) { return invoke<BOOL>(0xA0F93D5465B3094D, p0); } // 0xA0F93D5465B3094D
	static Any _0xA31FD15197B192BD() { return invoke<Any>(0xA31FD15197B192BD); } // 0xA31FD15197B192BD
	static void _0xA3C53804BDB68ED2(Any p0, Any p1) { invoke<Void>(0xA3C53804BDB68ED2, p0, p1); } // 0xA3C53804BDB68ED2
	static BOOL _0xA5C80D8E768A9E66(Any* p0) { return invoke<BOOL>(0xA5C80D8E768A9E66, p0); } // 0xA5C80D8E768A9E66
	static void _0xA6F54BB2FFCA35EA(Any p0) { invoke<Void>(0xA6F54BB2FFCA35EA, p0); } // 0xA6F54BB2FFCA35EA
	static void _0xA736CF7FB7C5BFF4(Any* p0, Any* p1, Any* p2, Any* p3) { invoke<Void>(0xA736CF7FB7C5BFF4, p0, p1, p2, p3); } // 0xA736CF7FB7C5BFF4
	static Any _0xA761D4AC6115623D() { return invoke<Any>(0xA761D4AC6115623D); } // 0xA761D4AC6115623D
	static void _0xA78B8FA58200DA56(int p0) { invoke<Void>(0xA78B8FA58200DA56, p0); } // 0xA78B8FA58200DA56
	static void _0xA8733668D1047B51(Any p0) { invoke<Void>(0xA8733668D1047B51, p0); } // 0xA8733668D1047B51
	static Any _0xA943FD1722E11EFD() { return invoke<Any>(0xA943FD1722E11EFD); } // 0xA943FD1722E11EFD
	static void _0xAA525DFF66BB82F5(Any p0, Any p1, Any p2) { invoke<Void>(0xAA525DFF66BB82F5, p0, p1, p2); } // 0xAA525DFF66BB82F5
	static void _0xADDD1C754E2E2914(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { invoke<Void>(0xADDD1C754E2E2914, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); } // 0xADDD1C754E2E2914
	static Any _0xAFF47709F1D5DCCE() { return invoke<Any>(0xAFF47709F1D5DCCE); } // 0xAFF47709F1D5DCCE
	static BOOL _0xB1D2BB1E1631F5B1() { return invoke<BOOL>(0xB1D2BB1E1631F5B1); } // 0xB1D2BB1E1631F5B1
	static Any _0xB3DA2606774A8E2D() { return invoke<Any>(0xB3DA2606774A8E2D); } // 0xB3DA2606774A8E2D
	static void _0xB475F27C6A994D65() { invoke<Void>(0xB475F27C6A994D65); } // 0xB475F27C6A994D65
	static void _0xB7257BA2550EA10A(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0xB7257BA2550EA10A, p0, p1, p2, p3, p4, p5, p6); } // 0xB7257BA2550EA10A
	static Any _0xBA9749CC94C1FD85() { return invoke<Any>(0xBA9749CC94C1FD85); } // 0xBA9749CC94C1FD85
	static void _0xBAA2F0490E146BE8(Any p0) { invoke<Void>(0xBAA2F0490E146BE8, p0); } // 0xBAA2F0490E146BE8
	static Any _0xBE3DB208333D9844() { return invoke<Any>(0xBE3DB208333D9844); } // 0xBE3DB208333D9844
	static void _0xBE509B0A3693DE8B(Any p0) { invoke<Void>(0xBE509B0A3693DE8B, p0); } // 0xBE509B0A3693DE8B
	static BOOL _0xBED9F5693F34ED17(Hash statName, int p1, float* outValue) { return invoke<BOOL>(0xBED9F5693F34ED17, statName, p1, outValue); } // 0xBED9F5693F34ED17
	static void _0xBF371CD2B64212FD(Any p0) { invoke<Void>(0xBF371CD2B64212FD, p0); } // 0xBF371CD2B64212FD
	static void _0xBFAFDB5FAAA5C5AB(Any p0) { invoke<Void>(0xBFAFDB5FAAA5C5AB, p0); } // 0xBFAFDB5FAAA5C5AB
	static Any _0xC0E0D686DDFC6EAE() { return invoke<Any>(0xC0E0D686DDFC6EAE); } // 0xC0E0D686DDFC6EAE
	static void _0xC141B8917E0017EC() { invoke<Void>(0xC141B8917E0017EC); } // 0xC141B8917E0017EC
	static BOOL _0xC38DC1E90D22547C(Any* p0, Any* p1, Any* p2) { return invoke<BOOL>(0xC38DC1E90D22547C, p0, p1, p2); } // 0xC38DC1E90D22547C
	static void _0xC5BE134EC7BA96A0(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xC5BE134EC7BA96A0, p0, p1, p2, p3, p4); } // 0xC5BE134EC7BA96A0
	static Any _0xC6E0E2616A7576BB() { return invoke<Any>(0xC6E0E2616A7576BB); } // 0xC6E0E2616A7576BB
	static Any _0xC70DDCE56D0D3A99() { return invoke<Any>(0xC70DDCE56D0D3A99); } // 0xC70DDCE56D0D3A99
	static void _0xC729991A9065376E(Any p0) { invoke<Void>(0xC729991A9065376E, p0); } // 0xC729991A9065376E
	static void _0xC847B43F369AC0B5() { invoke<Void>(0xC847B43F369AC0B5); } // 0xC847B43F369AC0B5
	static BOOL _0xC980E62E33DF1D5C(Any* p0, Any* p1) { return invoke<BOOL>(0xC980E62E33DF1D5C, p0, p1); } // 0xC980E62E33DF1D5C
	static void _0xCB00196B31C39EB1(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xCB00196B31C39EB1, p0, p1, p2, p3); } // 0xCB00196B31C39EB1
	static void _0xCC25A4553DFBF9EA(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xCC25A4553DFBF9EA, p0, p1, p2, p3, p4); } // 0xCC25A4553DFBF9EA
	static Any _0xCE5AA445ABA8DEE0(Any* p0) { return invoke<Any>(0xCE5AA445ABA8DEE0, p0); } // 0xCE5AA445ABA8DEE0
	static void _0xCEA553E35C2246E1(Any p0, Any p1, Any p2) { invoke<Void>(0xCEA553E35C2246E1, p0, p1, p2); } // 0xCEA553E35C2246E1
	static void _0xD1032E482629049E(BOOL p0) { invoke<Void>(0xD1032E482629049E, p0); } // 0xD1032E482629049E
	static void _0xD1A1EE3B4FA8E760(Any p0) { invoke<Void>(0xD1A1EE3B4FA8E760, p0); } // 0xD1A1EE3B4FA8E760
	static void _0xD1C9B92BDD3F151D(Any p0, Any p1, Any p2) { invoke<Void>(0xD1C9B92BDD3F151D, p0, p1, p2); } // 0xD1C9B92BDD3F151D
	static void _0xD558BEC0BBA7E8D2(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xD558BEC0BBA7E8D2, p0, p1, p2, p3, p4); } // 0xD558BEC0BBA7E8D2
	static void _0xD6781E42755531F7(Any p0) { invoke<Void>(0xD6781E42755531F7, p0); } // 0xD6781E42755531F7
	static void _0xDAC073C7901F9E15(Any p0) { invoke<Void>(0xDAC073C7901F9E15, p0); } // 0xDAC073C7901F9E15
	static void _0xDAF80797FC534BEC(Any p0) { invoke<Void>(0xDAF80797FC534BEC, p0); } // 0xDAF80797FC534BEC
	static Any _0xDEAAF77EB3687E97(Any p0, Any* p1) { return invoke<Any>(0xDEAAF77EB3687E97, p0, p1); } // 0xDEAAF77EB3687E97
	static void _0xE3261D791EB44ACB(Any p0) { invoke<Void>(0xE3261D791EB44ACB, p0); } // 0xE3261D791EB44ACB
	static Any _0xE496A53BA5F50A56(Any p0) { return invoke<Any>(0xE496A53BA5F50A56, p0); } // 0xE496A53BA5F50A56
	static Any _0xE8853FBCE7D8D0D6() { return invoke<Any>(0xE8853FBCE7D8D0D6); } // 0xE8853FBCE7D8D0D6
	static void _0xE95C8A1875A02CA4(Any p0, Any p1, Any p2) { invoke<Void>(0xE95C8A1875A02CA4, p0, p1, p2); } // 0xE95C8A1875A02CA4
	static BOOL _0xECB41AC6AB754401() { return invoke<BOOL>(0xECB41AC6AB754401); } // 0xECB41AC6AB754401
	static void _0xEDBF6C9B0D2C65C8(Any p0) { invoke<Void>(0xEDBF6C9B0D2C65C8, p0); } // 0xEDBF6C9B0D2C65C8
	static void _0xF06A6F41CB445443(Any p0) { invoke<Void>(0xF06A6F41CB445443, p0); } // 0xF06A6F41CB445443
	static Any _0xF11F01D98113536A(Any p0) { return invoke<Any>(0xF11F01D98113536A, p0); } // 0xF11F01D98113536A
	static void _0xF1A1803D3476F215(int value) { invoke<Void>(0xF1A1803D3476F215, value); } // 0xF1A1803D3476F215
	static BOOL _0xF1AE5DCDBFCA2721(Any* p0, Any* p1, Any* p2) { return invoke<BOOL>(0xF1AE5DCDBFCA2721, p0, p1, p2); } // 0xF1AE5DCDBFCA2721
	static void _0xF434A10BA01C37D0(BOOL p0) { invoke<Void>(0xF434A10BA01C37D0, p0); } // 0xF434A10BA01C37D0
	static int _0xF4D8E7AC2A27758C(int p0) { return invoke<int>(0xF4D8E7AC2A27758C, p0); } // 0xF4D8E7AC2A27758C
	static void _0xF4FF020A08BC8863(Any p0, Any p1) { invoke<Void>(0xF4FF020A08BC8863, p0, p1); } // 0xF4FF020A08BC8863
	static void _0xF534D94DFA2EAD26(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xF534D94DFA2EAD26, p0, p1, p2, p3, p4); } // 0xF534D94DFA2EAD26
	static void _0xF5BB8DAC426A52C0(Any* p0, Any* p1, Any* p2, Any* p3) { invoke<Void>(0xF5BB8DAC426A52C0, p0, p1, p2, p3); } // 0xF5BB8DAC426A52C0
	static void _0xF6792800AC95350D(Any p0) { invoke<Void>(0xF6792800AC95350D, p0); } // 0xF6792800AC95350D
	static void _0xF8C54A461C3E11DC(Any* p0, Any* p1, Any* p2, Any* p3) { invoke<Void>(0xF8C54A461C3E11DC, p0, p1, p2, p3); } // 0xF8C54A461C3E11DC
	static Any _0xF9F2922717B819EC() { return invoke<Any>(0xF9F2922717B819EC); } // 0xF9F2922717B819EC
	static void _0xFCC228E07217FCAC(Any p0) { invoke<Void>(0xFCC228E07217FCAC, p0); } // 0xFCC228E07217FCAC
	static void _PLAYSTATS_AMBIENT_MISSION_CRATE_CREATED(float p0, float p1, float p2) { invoke<Void>(0xAFC7E5E075A96F46, p0, p1, p2); } // 0xAFC7E5E075A96F46
	static void PLAYSTATS_AWARD_XP(Any p0, Any p1, Any p2) { invoke<Void>(0x46F917F6B4128FE4, p0, p1, p2); } // 0x46F917F6B4128FE4
	static void PLAYSTATS_CHEAT_APPLIED(char* cheat) { invoke<Void>(0x6058665D72302D3F, cheat); } // 0x6058665D72302D3F
	static void PLAYSTATS_CLOTH_CHANGE(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x34B973047A2268B9, p0, p1, p2, p3, p4); } // 0x34B973047A2268B9
	static void PLAYSTATS_FRIEND_ACTIVITY(Any p0, Any p1) { invoke<Void>(0xF71DE29AB2258F1, p0, p1); } // 0xF71DE29AB2258F1
	static void PLAYSTATS_MATCH_STARTED(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { invoke<Void>(0xBC80E22DED931E3D, p0, p1, p2, p3, p4, p5, p6); } // 0xBC80E22DED931E3D
	static void PLAYSTATS_MISSION_CHECKPOINT(Any* p0, Any p1, Any p2, Any p3) { invoke<Void>(0xC900596A63978C1D, p0, p1, p2, p3); } // 0xC900596A63978C1D
	static void PLAYSTATS_MISSION_OVER(Any* p0, Any p1, Any p2, BOOL p3, BOOL p4, BOOL p5) { invoke<Void>(0x7C4BB33A8CED7324, p0, p1, p2, p3, p4, p5); } // 0x7C4BB33A8CED7324
	static void PLAYSTATS_MISSION_STARTED(Any* p0, Any p1, Any p2, BOOL p3) { invoke<Void>(0xC19A2925C34D2231, p0, p1, p2, p3); } // 0xC19A2925C34D2231
	static void PLAYSTATS_NPC_INVITE(Any* p0) { invoke<Void>(0x93054C88E6AA7C44, p0); } // 0x93054C88E6AA7C44
	static void PLAYSTATS_ODDJOB_DONE(Any p0, Any p1, Any p2) { invoke<Void>(0x69DEA3E9DB727B4C, p0, p1, p2); } // 0x69DEA3E9DB727B4C
	static void PLAYSTATS_PROP_CHANGE(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xBA739D6D5A05D6E7, p0, p1, p2, p3); } // 0xBA739D6D5A05D6E7
	static void PLAYSTATS_RACE_CHECKPOINT(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x9C375C315099DDE4, p0, p1, p2, p3, p4); } // 0x9C375C315099DDE4
	static void PLAYSTATS_RANK_UP(Any p0) { invoke<Void>(0xC7F2DE41D102BFB4, p0); } // 0xC7F2DE41D102BFB4
	static void PLAYSTATS_SHOP_ITEM(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x176852ACAAC173D1, p0, p1, p2, p3, p4); } // 0x176852ACAAC173D1
	static void PLAYSTATS_WEBSITE_VISITED(Hash scaleformHash, int p1) { invoke<Void>(0xDDF24D535060F811, scaleformHash, p1); } // 0xDDF24D535060F811
	static Any STAT_CLEAR_SLOT_FOR_RELOAD(int statSlot) { return invoke<Any>(0xEB0A72181D4AA4AD, statSlot); } // 0xEB0A72181D4AA4AD
	static Any STAT_DELETE_SLOT(Any p0) { return invoke<Any>(0x49A49BED12794D70, p0); } // 0x49A49BED12794D70
	static BOOL STAT_GET_BOOL(Hash statHash, BOOL* outValue, Any p2) { return invoke<BOOL>(0x11B5E6D2AE73F48E, statHash, outValue, p2); } // 0x11B5E6D2AE73F48E
	static BOOL STAT_GET_BOOL_MASKED(Hash statName, int mask, int p2) { return invoke<BOOL>(0x10FE3F1B79F9B071, statName, mask, p2); } // 0x10FE3F1B79F9B071
	static BOOL STAT_GET_DATE(Hash statHash, Any* p1, Any p2, Any p3) { return invoke<BOOL>(0x8B0FACEFC36C824B, statHash, p1, p2, p3); } // 0x8B0FACEFC36C824B
	static BOOL STAT_GET_FLOAT(Hash statHash, float* outValue, Any p2) { return invoke<BOOL>(0xD7AE6C9C9C6AC54C, statHash, outValue, p2); } // 0xD7AE6C9C9C6AC54C
	static BOOL STAT_GET_INT(Hash statHash, int* outValue, int p2) { return invoke<BOOL>(0x767FBC2AC802EF3D, statHash, outValue, p2); } // 0x767FBC2AC802EF3D
	static char* STAT_GET_LICENSE_PLATE(Hash statName) { return invoke<char*>(0x5473D4195058B2E4, statName); } // 0x5473D4195058B2E4
	static BOOL STAT_GET_MASKED_INT(Any p0, Any* p1, Any p2, Any p3, Any p4) { return invoke<BOOL>(0x655185A06D9EEAAB, p0, p1, p2, p3, p4); } // 0x655185A06D9EEAAB
	static int STAT_GET_NUMBER_OF_DAYS(Hash statName) { return invoke<int>(0xE0E854F5280FB769, statName); } // 0xE0E854F5280FB769
	static int STAT_GET_NUMBER_OF_HOURS(Hash statName) { return invoke<int>(0xF2D4B2FE415AAFC3, statName); } // 0xF2D4B2FE415AAFC3
	static int STAT_GET_NUMBER_OF_MINUTES(Hash statName) { return invoke<int>(0x7583B4BE4C5A41B5, statName); } // 0x7583B4BE4C5A41B5
	static int STAT_GET_NUMBER_OF_SECONDS(Hash statName) { return invoke<int>(0x2CE056FF3723F00B, statName); } // 0x2CE056FF3723F00B
	static BOOL STAT_GET_POS(Any p0, Any* p1, Any* p2, Any* p3, Any p4) { return invoke<BOOL>(0x350F82CCB186AA1B, p0, p1, p2, p3, p4); } // 0x350F82CCB186AA1B
	static char* STAT_GET_STRING(Hash statHash, int p1) { return invoke<char*>(0xE50384ACC2C3DB74, statHash, p1); } // 0xE50384ACC2C3DB74
	static char* STAT_GET_USER_ID(Any p0) { return invoke<char*>(0x2365C388E393BBE2, p0); } // 0x2365C388E393BBE2
	static void STAT_INCREMENT(Hash statName, float value) { invoke<Void>(0x9B5A68C6489E9909, statName, value); } // 0x9B5A68C6489E9909
	static BOOL STAT_LOAD(int p0) { return invoke<BOOL>(0xA651443F437B1CE6, p0); } // 0xA651443F437B1CE6
	static BOOL STAT_LOAD_PENDING(Any p0) { return invoke<BOOL>(0xA1750FFAFA181661, p0); } // 0xA1750FFAFA181661
	static BOOL STAT_SAVE(int p0, BOOL p1, int p2) { return invoke<BOOL>(0xE07BCA305B82D2FD, p0, p1, p2); } // 0xE07BCA305B82D2FD
	static Any STAT_SAVE_PENDING() { return invoke<Any>(0x7D3A583856F2C5AC); } // 0x7D3A583856F2C5AC
	static Any STAT_SAVE_PENDING_OR_REQUESTED() { return invoke<Any>(0xBBB6AD006F1BBEA3); } // 0xBBB6AD006F1BBEA3
	static BOOL STAT_SET_BOOL(Hash statName, BOOL value, BOOL save) { return invoke<BOOL>(0x4B33C4243DE0C432, statName, value, save); } // 0x4B33C4243DE0C432
	static BOOL STAT_SET_BOOL_MASKED(Hash statName, BOOL value, int mask, BOOL save) { return invoke<BOOL>(0x5BC62EC1937B9E5B, statName, value, mask, save); } // 0x5BC62EC1937B9E5B
	static BOOL STAT_SET_CURRENT_POSIX_TIME(Hash statName, BOOL p1) { return invoke<BOOL>(0xC2F84B7F9C4D0C61, statName, p1); } // 0xC2F84B7F9C4D0C61
	static BOOL STAT_SET_DATE(Hash statName, Any* value, int numFields, BOOL save) { return invoke<BOOL>(0x2C29BFB64F4FCBE4, statName, value, numFields, save); } // 0x2C29BFB64F4FCBE4
	static BOOL STAT_SET_FLOAT(Hash statName, float value, BOOL save) { return invoke<BOOL>(0x4851997F37FE9B3C, statName, value, save); } // 0x4851997F37FE9B3C
	static BOOL STAT_SET_GXT_LABEL(Hash statName, char* value, BOOL save) { return invoke<BOOL>(0x17695002FD8B2AE0, statName, value, save); } // 0x17695002FD8B2AE0
	static BOOL STAT_SET_INT(Hash statName, int value, BOOL save) { return invoke<BOOL>(0xB3271D7AB655B441, statName, value, save); } // 0xB3271D7AB655B441
	static BOOL STAT_SET_LICENSE_PLATE(Hash statName, char* str) { return invoke<BOOL>(0x69FF13266D7296DA, statName, str); } // 0x69FF13266D7296DA
	static BOOL STAT_SET_MASKED_INT(Hash statName, Any p1, Any p2, int p3, BOOL save) { return invoke<BOOL>(0x7BBB1B54583ED410, statName, p1, p2, p3, save); } // 0x7BBB1B54583ED410
	static BOOL STAT_SET_POS(Hash statName, float x, float y, float z, BOOL save) { return invoke<BOOL>(0xDB283FDE680FE72E, statName, x, y, z, save); } // 0xDB283FDE680FE72E
	static void _STAT_SET_PROFILE_SETTING(int profileSetting, int value) { invoke<Void>(0x68F01422BE1D838F, profileSetting, value); } // 0x68F01422BE1D838F
	static BOOL STAT_SET_STRING(Hash statName, char* value, BOOL save) { return invoke<BOOL>(0xA87B2335D12531D7, statName, value, save); } // 0xA87B2335D12531D7
	static BOOL STAT_SET_USER_ID(Hash statName, char* value, BOOL save) { return invoke<BOOL>(0x8CDDF1E452BABE11, statName, value, save); } // 0x8CDDF1E452BABE11
	static BOOL STAT_SLOT_IS_LOADED(Any p0) { return invoke<BOOL>(0xD0A9F0E7BD91E3C, p0); } // 0xD0A9F0E7BD91E3C
}

namespace STREAMING
{
	static void BEGIN_SRL() { invoke<Void>(0x9BADDC94EF83B823); } // 0x9BADDC94EF83B823
	static void CLEAR_FOCUS() { invoke<Void>(0x31B73D1EA9F01DA2); } // 0x31B73D1EA9F01DA2
	static void CLEAR_HD_AREA() { invoke<Void>(0xCE58B1CFB9290813); } // 0xCE58B1CFB9290813
	static Any DESTROY_PLAYER_IN_PAUSE_MENU() { return invoke<Any>(0x5B74EA8CFD5E3E7E); } // 0x5B74EA8CFD5E3E7E
	static BOOL DOES_ANIM_DICT_EXIST(char* animDict) { return invoke<BOOL>(0x2DA49C3B79856961, animDict); } // 0x2DA49C3B79856961
	static void END_SRL() { invoke<Void>(0xA41540E63C9EE17); } // 0xA41540E63C9EE17
	static Any FORMAT_FOCUS_HEADING(float x, float y, float z, float rad, Any p4, Any p5) { return invoke<Any>(0x219C7B8D53E429FD, x, y, z, rad, p4, p5); } // 0x219C7B8D53E429FD
	static int GET_IDEAL_PLAYER_SWITCH_TYPE(float x1, float y1, float z1, float x2, float y2, float z2) { return invoke<int>(0xB5D7B26B45720E05, x1, y1, z1, x2, y2, z2); } // 0xB5D7B26B45720E05
	static int GET_NUMBER_OF_STREAMING_REQUESTS() { return invoke<int>(0x4060057271CEBC89); } // 0x4060057271CEBC89
	static int GET_PLAYER_SHORT_SWITCH_STATE() { return invoke<int>(0x20F898A5D9782800); } // 0x20F898A5D9782800
	static int GET_PLAYER_SWITCH_STATE() { return invoke<int>(0x470555300D10B2A5); } // 0x470555300D10B2A5
	static int GET_PLAYER_SWITCH_TYPE() { return invoke<int>(0xB3C94A90D9FC9E62); } // 0xB3C94A90D9FC9E62
	static BOOL HAS_ANIM_DICT_LOADED(char* animDict) { return invoke<BOOL>(0xD031A9162D01088C, animDict); } // 0xD031A9162D01088C
	static BOOL HAS_ANIM_SET_LOADED(char* animSet) { return invoke<BOOL>(0xC4EA073D86FB29B0, animSet); } // 0xC4EA073D86FB29B0
	static BOOL HAS_CLIP_SET_LOADED(char* clipSet) { return invoke<BOOL>(0x318234F4F3738AF3, clipSet); } // 0x318234F4F3738AF3
	static BOOL HAS_COLLISION_FOR_MODEL_LOADED(Hash model) { return invoke<BOOL>(0x22CCA434E368F03A, model); } // 0x22CCA434E368F03A
	static BOOL HAS_MODEL_LOADED(Hash model) { return invoke<BOOL>(0x98A4EB5D89A0C952, model); } // 0x98A4EB5D89A0C952
	static BOOL HAS_NAMED_PTFX_ASSET_LOADED(char* assetName) { return invoke<BOOL>(0x8702416E512EC454, assetName); } // 0x8702416E512EC454
	static BOOL HAS_PTFX_ASSET_LOADED() { return invoke<BOOL>(0xCA7D9B86ECA7481B); } // 0xCA7D9B86ECA7481B
	static BOOL IS_ENTITY_FOCUS(Entity entity) { return invoke<BOOL>(0x2DDFF3FB9075D747, entity); } // 0x2DDFF3FB9075D747
	static BOOL IS_IPL_ACTIVE(char* iplName) { return invoke<BOOL>(0x88A741E44A2B3495, iplName); } // 0x88A741E44A2B3495
	static BOOL _IS_MODEL_A_PED(Hash modelHash) { return invoke<BOOL>(0x75816577FEA6DAD5, modelHash); } // 0x75816577FEA6DAD5
	static BOOL IS_MODEL_A_VEHICLE(Hash model) { return invoke<BOOL>(0x19AAC8F07BFEC53E, model); } // 0x19AAC8F07BFEC53E
	static BOOL IS_MODEL_IN_CDIMAGE(Hash model) { return invoke<BOOL>(0x35B9E0803292B641, model); } // 0x35B9E0803292B641
	static BOOL IS_MODEL_VALID(Hash model) { return invoke<BOOL>(0xC0296A2EDF545E92, model); } // 0xC0296A2EDF545E92
	static BOOL IS_NETWORK_LOADING_SCENE() { return invoke<BOOL>(0x41CA5A33160EA4AB); } // 0x41CA5A33160EA4AB
	static BOOL IS_NEW_LOAD_SCENE_ACTIVE() { return invoke<BOOL>(0xA41A05B6CB741B85); } // 0xA41A05B6CB741B85
	static BOOL IS_NEW_LOAD_SCENE_LOADED() { return invoke<BOOL>(0x1B8247A7A8B9AD1); } // 0x1B8247A7A8B9AD1
	static BOOL IS_PLAYER_SWITCH_IN_PROGRESS() { return invoke<BOOL>(0xD9D2CFFF49FAB35F); } // 0xD9D2CFFF49FAB35F
	static BOOL IS_SRL_LOADED() { return invoke<BOOL>(0xD0263801A4C5B0BB); } // 0xD0263801A4C5B0BB
	static void LOAD_ALL_OBJECTS_NOW() { invoke<Void>(0xBD6E84632DD4CB3F); } // 0xBD6E84632DD4CB3F
	static void _LOAD_MISSION_CREATOR_DATA() { invoke<Void>(0xB5A4DB34FE89B88A); } // 0xB5A4DB34FE89B88A
	static void LOAD_SCENE(float x, float y, float z) { invoke<Void>(0x4448EB75B4904BDB, x, y, z); } // 0x4448EB75B4904BDB
	static void NETWORK_STOP_LOAD_SCENE() { invoke<Void>(0x64E630FAF5F60F44); } // 0x64E630FAF5F60F44
	static void NETWORK_UPDATE_LOAD_SCENE() { invoke<Void>(0xC4582015556D1C46); } // 0xC4582015556D1C46
	static BOOL NEW_LOAD_SCENE_START(float p0, float p1, float p2, float p3, float p4, float p5, float p6, Any p7) { return invoke<BOOL>(0x212A8D0D2BABFAC2, p0, p1, p2, p3, p4, p5, p6, p7); } // 0x212A8D0D2BABFAC2
	static BOOL NEW_LOAD_SCENE_START_SPHERE(float x, float y, float z, float radius, Any p4) { return invoke<BOOL>(0xACCFB4ACF53551B0, x, y, z, radius, p4); } // 0xACCFB4ACF53551B0
	static void NEW_LOAD_SCENE_STOP() { invoke<Void>(0xC197616D221FF4A4); } // 0xC197616D221FF4A4
	static void _0x03F1A106BDA7DD3E() { invoke<Void>(0x3F1A106BDA7DD3E); } // 0x3F1A106BDA7DD3E
	static Any _0x07C313F94746702C(Any p0) { return invoke<Any>(0x7C313F94746702C, p0); } // 0x7C313F94746702C
	static void _0x0811381EF5062FEC(Entity p0) { invoke<Void>(0x811381EF5062FEC, p0); } // 0x811381EF5062FEC
	static Any _0x0AD9710CEE2F590F(float p0, float p1, float p2, float p3, float p4, float p5, Any p6) { return invoke<Any>(0xAD9710CEE2F590F, p0, p1, p2, p3, p4, p5, p6); } // 0xAD9710CEE2F590F
	static BOOL _0x0BC3144DEB678666(Hash modelHash) { return invoke<BOOL>(0xBC3144DEB678666, modelHash); } // 0xBC3144DEB678666
	static Any _0x0C15B0E443B2349D() { return invoke<Any>(0xC15B0E443B2349D); } // 0xC15B0E443B2349D
	static void _0x0FDE9DBFC0A6BC65(Any* p0) { invoke<Void>(0xFDE9DBFC0A6BC65, p0); } // 0xFDE9DBFC0A6BC65
	static void _0x1E9057A74FD73E23() { invoke<Void>(0x1E9057A74FD73E23); } // 0x1E9057A74FD73E23
	static void _0x1EE7D8DF4425F053(Any p0) { invoke<Void>(0x1EE7D8DF4425F053, p0); } // 0x1EE7D8DF4425F053
	static Any _0x1F3F018BC3AFA77C(float p0, float p1, float p2, float p3, float p4, float p5, float p6, Any p7, Any p8) { return invoke<Any>(0x1F3F018BC3AFA77C, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0x1F3F018BC3AFA77C
	static void _0x20C6C7E4EB082A7F(BOOL p0) { invoke<Void>(0x20C6C7E4EB082A7F, p0); } // 0x20C6C7E4EB082A7F
	static Any _0x3D3D8B3BE5A83D35() { return invoke<Any>(0x3D3D8B3BE5A83D35); } // 0x3D3D8B3BE5A83D35
	static void _0x40AEFD1A244741F2(BOOL p0) { invoke<Void>(0x40AEFD1A244741F2, p0); } // 0x40AEFD1A244741F2
	static void _0x43D1680C6D19A8E9() { invoke<Void>(0x43D1680C6D19A8E9); } // 0x43D1680C6D19A8E9
	static void _0x472397322E92A856() { invoke<Void>(0x472397322E92A856); } // 0x472397322E92A856
	static void _0x4E52E752C76E7E7A(Any p0) { invoke<Void>(0x4E52E752C76E7E7A, p0); } // 0x4E52E752C76E7E7A
	static Any _0x5068F488DDB54DD8() { return invoke<Any>(0x5068F488DDB54DD8); } // 0x5068F488DDB54DD8
	static Any _0x5B48A06DD0E792A5() { return invoke<Any>(0x5B48A06DD0E792A5); } // 0x5B48A06DD0E792A5
	static void _0x5F2013F8BC24EE69(int p0) { invoke<Void>(0x5F2013F8BC24EE69, p0); } // 0x5F2013F8BC24EE69
	static void _0x63EB2B972A218CAC() { invoke<Void>(0x63EB2B972A218CAC); } // 0x63EB2B972A218CAC
	static Any _0x71E7B2E657449AAD() { return invoke<Any>(0x71E7B2E657449AAD); } // 0x71E7B2E657449AAD
	static void _0x74DE2E8739086740() { invoke<Void>(0x74DE2E8739086740); } // 0x74DE2E8739086740
	static Any _0x78C0D93253149435() { return invoke<Any>(0x78C0D93253149435); } // 0x78C0D93253149435
	static Any _0x7D41E9D2D17C5B2D(Any p0) { return invoke<Any>(0x7D41E9D2D17C5B2D, p0); } // 0x7D41E9D2D17C5B2D
	static void _0x8E2A065ABDAE6994() { invoke<Void>(0x8E2A065ABDAE6994); } // 0x8E2A065ABDAE6994
	static Any _0x933BBEEB8C61B5F4() { return invoke<Any>(0x933BBEEB8C61B5F4); } // 0x933BBEEB8C61B5F4
	static void _0x95A7DABDDBB78AE7(Any* p0, Any* p1) { invoke<Void>(0x95A7DABDDBB78AE7, p0, p1); } // 0x95A7DABDDBB78AE7
	static void _0xA76359FC80B2438E(float p0) { invoke<Void>(0xA76359FC80B2438E, p0); } // 0xA76359FC80B2438E
	static void _0xAD5FDF34B81BFE79() { invoke<Void>(0xAD5FDF34B81BFE79); } // 0xAD5FDF34B81BFE79
	static void _0xAF12610C644A35C9(char* p0, BOOL p1) { invoke<Void>(0xAF12610C644A35C9, p0, p1); } // 0xAF12610C644A35C9
	static Any _0xBC9823AB80A3DCAC() { return invoke<Any>(0xBC9823AB80A3DCAC); } // 0xBC9823AB80A3DCAC
	static void _0xBD605B8E0E18B3BB() { invoke<Void>(0xBD605B8E0E18B3BB); } // 0xBD605B8E0E18B3BB
	static void _0xBEB2D9A1D9A8F55A(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0xBEB2D9A1D9A8F55A, p0, p1, p2, p3); } // 0xBEB2D9A1D9A8F55A
	static void _0xBED8CA5FF5E04113(float p0, float p1, float p2, float p3) { invoke<Void>(0xBED8CA5FF5E04113, p0, p1, p2, p3); } // 0xBED8CA5FF5E04113
	static void _0xD4793DFF3AF2ABCD() { invoke<Void>(0xD4793DFF3AF2ABCD); } // 0xD4793DFF3AF2ABCD
	static Any _0xDFA80CB25D0A19B3() { return invoke<Any>(0xDFA80CB25D0A19B3); } // 0xDFA80CB25D0A19B3
	static void _0xEF39EE20C537E98C(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0xEF39EE20C537E98C, p0, p1, p2, p3, p4, p5); } // 0xEF39EE20C537E98C
	static void _0xF086AD9354FAC3A3(Any p0) { invoke<Void>(0xF086AD9354FAC3A3, p0); } // 0xF086AD9354FAC3A3
	static void _0xF4A0DADB70F57FA6() { invoke<Void>(0xF4A0DADB70F57FA6); } // 0xF4A0DADB70F57FA6
	static void _0xF8155A7F03DDFC8E(Any p0) { invoke<Void>(0xF8155A7F03DDFC8E, p0); } // 0xF8155A7F03DDFC8E
	static Any _0xFB199266061F820A() { return invoke<Any>(0xFB199266061F820A); } // 0xFB199266061F820A
	static void PREFETCH_SRL(char* srl) { invoke<Void>(0x3D245789CE12982C, srl); } // 0x3D245789CE12982C
	static void REMOVE_ANIM_DICT(char* animDict) { invoke<Void>(0xF66A602F829E2A06, animDict); } // 0xF66A602F829E2A06
	static void REMOVE_ANIM_SET(char* animSet) { invoke<Void>(0x16350528F93024B3, animSet); } // 0x16350528F93024B3
	static void REMOVE_CLIP_SET(char* clipSet) { invoke<Void>(0x1F73A131C18CD94, clipSet); } // 0x1F73A131C18CD94
	static void REMOVE_IPL(char* iplName) { invoke<Void>(0xEE6C5AD3ECE0A82D, iplName); } // 0xEE6C5AD3ECE0A82D
	static void _REMOVE_NAMED_PTFX_ASSET(char* assetName) { invoke<Void>(0x5F61EBBE1A00F96D, assetName); } // 0x5F61EBBE1A00F96D
	static void REMOVE_PTFX_ASSET() { invoke<Void>(0x88C6814073DD4A73); } // 0x88C6814073DD4A73
	static void REQUEST_ADDITIONAL_COLLISION_AT_COORD(float x, float y, float z) { invoke<Void>(0xC9156DC11411A9EA, x, y, z); } // 0xC9156DC11411A9EA
	static void REQUEST_ANIM_DICT(char* animDict) { invoke<Void>(0xD3BD40951412FEF6, animDict); } // 0xD3BD40951412FEF6
	static void REQUEST_ANIM_SET(char* animSet) { invoke<Void>(0x6EA47DAE7FAD0EED, animSet); } // 0x6EA47DAE7FAD0EED
	static void REQUEST_CLIP_SET(char* clipSet) { invoke<Void>(0xD2A71E1A77418A49, clipSet); } // 0xD2A71E1A77418A49
	static Any REQUEST_COLLISION_AT_COORD(float x, float y, float z) { return invoke<Any>(0x7503F7948F491A7, x, y, z); } // 0x7503F7948F491A7
	static void REQUEST_COLLISION_FOR_MODEL(Hash model) { invoke<Void>(0x923CB32A3B874FCB, model); } // 0x923CB32A3B874FCB
	static void _REQUEST_INTERIOR_ROOM_BY_NAME(int interiorID, char* roomName) { invoke<Void>(0x8A7A40100EDFEC58, interiorID, roomName); } // 0x8A7A40100EDFEC58
	static void REQUEST_IPL(char* iplName) { invoke<Void>(0x41B4893843BBDB74, iplName); } // 0x41B4893843BBDB74
	static void REQUEST_MENU_PED_MODEL(Hash model) { invoke<Void>(0xA0261AEF7ACFC51E, model); } // 0xA0261AEF7ACFC51E
	static void REQUEST_MODEL(Hash model) { invoke<Void>(0x963D27A58DF860AC, model); } // 0x963D27A58DF860AC
	static void REQUEST_NAMED_PTFX_ASSET(char* assetName) { invoke<Void>(0xB80D8756B4668AB6, assetName); } // 0xB80D8756B4668AB6
	static Any REQUEST_PTFX_ASSET() { return invoke<Any>(0x944955FB2A3935C8); } // 0x944955FB2A3935C8
	static void SET_DITCH_POLICE_MODELS(BOOL toggle) { invoke<Void>(0x42CBE54462D92634, toggle); } // 0x42CBE54462D92634
	static void _SET_FOCUS_AREA(float x, float y, float z, float offsetX, float offsetY, float offsetZ) { invoke<Void>(0xBB7454BAFF08FE25, x, y, z, offsetX, offsetY, offsetZ); } // 0xBB7454BAFF08FE25
	static void SET_FOCUS_ENTITY(Entity entity) { invoke<Void>(0x198F77705FA0931D, entity); } // 0x198F77705FA0931D
	static void SET_GAME_PAUSES_FOR_STREAMING(BOOL toggle) { invoke<Void>(0x717CD6E6FAEBBEDC, toggle); } // 0x717CD6E6FAEBBEDC
	static void SET_HD_AREA(float x, float y, float z, float radius) { invoke<Void>(0xB85F26619073E775, x, y, z, radius); } // 0xB85F26619073E775
	static void SET_INTERIOR_ACTIVE(int interiorID, BOOL toggle) { invoke<Void>(0xE37B76C387BE28ED, interiorID, toggle); } // 0xE37B76C387BE28ED
	static void SET_MODEL_AS_NO_LONGER_NEEDED(Hash model) { invoke<Void>(0xE532F5D78798DAAB, model); } // 0xE532F5D78798DAAB
	static void SET_PED_POPULATION_BUDGET(int p0) { invoke<Void>(0x8C95333CFC3340F3, p0); } // 0x8C95333CFC3340F3
	static int SET_PLAYER_INVERTED_UP() { return invoke<int>(0x8C2D6C52A3104BB); } // 0x8C2D6C52A3104BB
	static void SET_PLAYER_SWITCH_OUTRO(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, Any p8) { invoke<Void>(0xC208B673CE446B61, p0, p1, p2, p3, p4, p5, p6, p7, p8); } // 0xC208B673CE446B61
	static void SET_REDUCE_PED_MODEL_BUDGET(BOOL toggle) { invoke<Void>(0x77B5F9A36BF96710, toggle); } // 0x77B5F9A36BF96710
	static void SET_REDUCE_VEHICLE_MODEL_BUDGET(BOOL toggle) { invoke<Void>(0x80C527893080CCF3, toggle); } // 0x80C527893080CCF3
	static void SET_SRL_TIME(float p0) { invoke<Void>(0xA74A541C6884E7B8, p0); } // 0xA74A541C6884E7B8
	static void SET_STREAMING(BOOL toggle) { invoke<Void>(0x6E0C692677008888, toggle); } // 0x6E0C692677008888
	static void SET_VEHICLE_POPULATION_BUDGET(int p0) { invoke<Void>(0xCB9E1EB3BE2AF4E9, p0); } // 0xCB9E1EB3BE2AF4E9
	static void SHUTDOWN_CREATOR_BUDGET() { invoke<Void>(0xCCE26000E9A6FAD7); } // 0xCCE26000E9A6FAD7
	static void START_PLAYER_SWITCH(Ped from, Ped to, int flags, int switchType) { invoke<Void>(0xFAA23F2CBA159D67, from, to, flags, switchType); } // 0xFAA23F2CBA159D67
	static void STOP_PLAYER_SWITCH() { invoke<Void>(0x95C0A5BBDC189AA1); } // 0x95C0A5BBDC189AA1
	static void _SWITCH_IN_PLAYER(Ped ped) { invoke<Void>(0xD8295AF639FD9CB8, ped); } // 0xD8295AF639FD9CB8
	static void _SWITCH_OUT_PLAYER(Ped ped, int flags, int switchType) { invoke<Void>(0xAAB3200ED59016BC, ped, flags, switchType); } // 0xAAB3200ED59016BC
}

namespace SYSTEM
{
	static int CEIL(float value) { return invoke<int>(0x11E019C8F43ACC8A, value); } // 0x11E019C8F43ACC8A
	static float COS(float value) { return invoke<float>(0xD0FFB162F40A139C, value); } // 0xD0FFB162F40A139C
	static int FLOOR(float value) { return invoke<int>(0xF34EE736CF047844, value); } // 0xF34EE736CF047844
	static void _0x42B65DEEF2EDF2A1(Any p0) { invoke<Void>(0x42B65DEEF2EDF2A1, p0); } // 0x42B65DEEF2EDF2A1
	static float POW(float base, float exponent) { return invoke<float>(0xE3621CC40F31FE2E, base, exponent); } // 0xE3621CC40F31FE2E
	static int ROUND(float value) { return invoke<int>(0xF2DB717A73826179, value); } // 0xF2DB717A73826179
	static void SETTIMERA(int value) { invoke<Void>(0xC1B1E9A034A63A62, value); } // 0xC1B1E9A034A63A62
	static void SETTIMERB(int value) { invoke<Void>(0x5AE11BC36633DE4E, value); } // 0x5AE11BC36633DE4E
	static int SHIFT_LEFT(int value, int bitShift) { return invoke<int>(0xEDD95A39E5544DE8, value, bitShift); } // 0xEDD95A39E5544DE8
	static int SHIFT_RIGHT(int value, int bitShift) { return invoke<int>(0x97EF1E5BCE9DC075, value, bitShift); } // 0x97EF1E5BCE9DC075
	static float SIN(float value) { return invoke<float>(0xBADBFA3B172435F, value); } // 0xBADBFA3B172435F
	static float SQRT(float value) { return invoke<float>(0x71D93B57D07F9804, value); } // 0x71D93B57D07F9804
	static int START_NEW_SCRIPT(char* scriptName, int stackSize) { return invoke<int>(0xE81651AD79516E48, scriptName, stackSize); } // 0xE81651AD79516E48
	static int START_NEW_SCRIPT_WITH_ARGS(char* scriptName, Any* args, int argCount, int stackSize) { return invoke<int>(0xB8BA7F44DF1575E1, scriptName, args, argCount, stackSize); } // 0xB8BA7F44DF1575E1
	static int START_NEW_SCRIPT_WITH_NAME_HASH(Hash scriptHash, int stackSize) { return invoke<int>(0xEB1C67C3A5333A92, scriptHash, stackSize); } // 0xEB1C67C3A5333A92
	static int START_NEW_SCRIPT_WITH_NAME_HASH_AND_ARGS(Hash scriptHash, Any* args, int argCount, int stackSize) { return invoke<int>(0xC4BB298BD441BE78, scriptHash, args, argCount, stackSize); } // 0xC4BB298BD441BE78
	static int TIMERA() { return invoke<int>(0x83666F9FB8FEBD4B); } // 0x83666F9FB8FEBD4B
	static int TIMERB() { return invoke<int>(0xC9D9444186B5A374); } // 0xC9D9444186B5A374
	static float TIMESTEP() { return invoke<float>(0x50597EE2); } // 0x50597EE2
	static float TO_FLOAT(int value) { return invoke<float>(0xBBDA792448DB5A89, value); } // 0xBBDA792448DB5A89
	static float VDIST(float x1, float y1, float z1, float x2, float y2, float z2) { return invoke<float>(0x2A488C176D52CCA5, x1, y1, z1, x2, y2, z2); } // 0x2A488C176D52CCA5
	static float VDIST2(float x1, float y1, float z1, float x2, float y2, float z2) { return invoke<float>(0xB7A628320EFF8E47, x1, y1, z1, x2, y2, z2); } // 0xB7A628320EFF8E47
	static float VMAG(float x, float y, float z) { return invoke<float>(0x652D2EEEF1D3E62C, x, y, z); } // 0x652D2EEEF1D3E62C
	static float VMAG2(float x, float y, float z) { return invoke<float>(0xA8CEACB4F35AE058, x, y, z); } // 0xA8CEACB4F35AE058
	static void WAIT(int* ms) { invoke<Void>(0x4EDE34FBADD967A6, ms); } // 0x4EDE34FBADD967A6
}

namespace UNK
{
	static int _GET_CURRENT_LANGUAGE_ID() { return invoke<int>(0x2BDD44CC428A7EAE); } // 0x2BDD44CC428A7EAE
	static int _GET_USER_LANGUAGE_ID() { return invoke<int>(0xA8AE43AEC1A61314); } // 0xA8AE43AEC1A61314
	static void _IS_IN_LOADING_SCREEN(BOOL p0) { invoke<Void>(0xFC309E94546FCDB5, p0); } // 0xFC309E94546FCDB5
	static BOOL _IS_UI_LOADING_MULTIPLAYER() { return invoke<BOOL>(0xC6DC823253FBB366); } // 0xC6DC823253FBB366
	static Any _0x8AA464D4E0F6ACCD() { return invoke<Any>(0x8AA464D4E0F6ACCD); } // 0x8AA464D4E0F6ACCD
	static void _0xB0C56BD3D808D863(BOOL p0) { invoke<Void>(0xB0C56BD3D808D863, p0); } // 0xB0C56BD3D808D863
	static void _0xC7E7181C09F33B69(BOOL p0) { invoke<Void>(0xC7E7181C09F33B69, p0); } // 0xC7E7181C09F33B69
	static BOOL _0xEF7D17BC6C85264C() { return invoke<BOOL>(0xEF7D17BC6C85264C); } // 0xEF7D17BC6C85264C
	static int _0xF2CA003F167E21D2() { return invoke<int>(0xF2CA003F167E21D2); } // 0xF2CA003F167E21D2
	static void _0xFA1E0E893D915215(BOOL p0) { invoke<Void>(0xFA1E0E893D915215, p0); } // 0xFA1E0E893D915215
}

namespace VEHICLE
{
	static int _ADD_SPEED_ZONE_FOR_COORD(float x, float y, float z, float radius, float speed, BOOL p5) { return invoke<int>(0x2CE544C68FB812A0, x, y, z, radius, speed, p5); } // 0x2CE544C68FB812A0
	static void ADD_VEHICLE_STUCK_CHECK_WITH_WARP(Any p0, float p1, Any p2, BOOL p3, BOOL p4, BOOL p5, Any p6) { invoke<Void>(0x2FA9923062DD396C, p0, p1, p2, p3, p4, p5, p6); } // 0x2FA9923062DD396C
	static void ADD_VEHICLE_UPSIDEDOWN_CHECK(Vehicle vehicle) { invoke<Void>(0xB72E26D81006005B, vehicle); } // 0xB72E26D81006005B
	static BOOL _ANY_PASSENGERS_RAPPELING(Vehicle vehicle) { return invoke<BOOL>(0x291E373D483E7EE7, vehicle); } // 0x291E373D483E7EE7
	static BOOL ARE_ALL_VEHICLE_WINDOWS_INTACT(Vehicle vehicle) { return invoke<BOOL>(0x11D862A3E977A9EF, vehicle); } // 0x11D862A3E977A9EF
	static BOOL ARE_ANY_VEHICLE_SEATS_FREE(Vehicle vehicle) { return invoke<BOOL>(0x2D34FC3BC4ADB780, vehicle); } // 0x2D34FC3BC4ADB780
	static BOOL _ARE_BOMB_BAY_DOORS_OPEN(Vehicle aircraft) { return invoke<BOOL>(0xD0917A423314BBA8, aircraft); } // 0xD0917A423314BBA8
	static BOOL _ARE_PROPELLERS_UNDAMAGED(Vehicle vehicle) { return invoke<BOOL>(0x755D6D5267CBBD7E, vehicle); } // 0x755D6D5267CBBD7E
	static BOOL _ARE_VEHICLE_WINGS_INTACT(Vehicle vehicle) { return invoke<BOOL>(0x5991A01434CE9677, vehicle); } // 0x5991A01434CE9677
	static void ATTACH_VEHICLE_TO_CARGOBOB(Vehicle vehicle, Vehicle cargobob, int p2, float x, float y, float z) { invoke<Void>(0x4127F1D84E347769, vehicle, cargobob, p2, x, y, z); } // 0x4127F1D84E347769
	static void ATTACH_VEHICLE_TO_TOW_TRUCK(Vehicle towTruck, Vehicle vehicle, BOOL rear, float hookOffsetX, float hookOffsetY, float hookOffsetZ) { invoke<Void>(0x29A16F8D621C4508, towTruck, vehicle, rear, hookOffsetX, hookOffsetY, hookOffsetZ); } // 0x29A16F8D621C4508
	static void ATTACH_VEHICLE_TO_TRAILER(Vehicle vehicle, Vehicle trailer, float radius) { invoke<Void>(0x3C7D42D58F770B54, vehicle, trailer, radius); } // 0x3C7D42D58F770B54
	static BOOL CAN_SHUFFLE_SEAT(Vehicle vehicle, Any p1) { return invoke<BOOL>(0x30785D90C956BF35, vehicle, p1); } // 0x30785D90C956BF35
	static BOOL _CAN_VEHICLE_PARACHUTE_BE_ACTIVATED(Vehicle vehicle) { return invoke<BOOL>(0xA916396DF4154EE3, vehicle); } // 0xA916396DF4154EE3
	static Any CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR(Vehicle vehicle) { return invoke<Any>(0x55E1D2758F34E437, vehicle); } // 0x55E1D2758F34E437
	static Any CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR(Vehicle vehicle) { return invoke<Any>(0x5FFBDEEC3E8E2009, vehicle); } // 0x5FFBDEEC3E8E2009
	static void CLOSE_BOMB_BAY_DOORS(Vehicle vehicle) { invoke<Void>(0x3556041742A0DC74, vehicle); } // 0x3556041742A0DC74
	static void CONTROL_LANDING_GEAR(Vehicle vehicle, int state) { invoke<Void>(0xCFC8BE9A5E1FE575, vehicle, state); } // 0xCFC8BE9A5E1FE575
	static Vehicle CREATE_MISSION_TRAIN(int variation, float x, float y, float z, BOOL direction) { return invoke<Vehicle>(0x63C6CCA8E68AE8C8, variation, x, y, z, direction); } // 0x63C6CCA8E68AE8C8
	static void CREATE_PICK_UP_ROPE_FOR_CARGOBOB(Vehicle cargobob, int state) { invoke<Void>(0x7BEB0C7A235F6F3B, cargobob, state); } // 0x7BEB0C7A235F6F3B
	static int CREATE_SCRIPT_VEHICLE_GENERATOR(float x, float y, float z, float heading, float p4, float p5, Hash modelHash, int p7, int p8, int p9, int p10, BOOL p11, BOOL p12, BOOL p13, BOOL p14, BOOL p15, int p16) { return invoke<int>(0x9DEF883114668116, x, y, z, heading, p4, p5, modelHash, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16); } // 0x9DEF883114668116
	static Vehicle CREATE_VEHICLE(Hash modelHash, float x, float y, float z, float heading, BOOL isNetwork, BOOL thisScriptCheck) { return invoke<Vehicle>(0xAF35D0D2583051B0, modelHash, x, y, z, heading, isNetwork, thisScriptCheck); } // 0xAF35D0D2583051B0
	static void DELETE_ALL_TRAINS() { invoke<Void>(0x736A718577F39C7D); } // 0x736A718577F39C7D
	static void DELETE_MISSION_TRAIN(Vehicle* train) { invoke<Void>(0x5B76B14AE875C795, train); } // 0x5B76B14AE875C795
	static void DELETE_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator) { invoke<Void>(0x22102C9ABFCF125D, vehicleGenerator); } // 0x22102C9ABFCF125D
	static void DELETE_VEHICLE(Vehicle* vehicle) { invoke<Void>(0xEA386986E786A54F, vehicle); } // 0xEA386986E786A54F
	static BOOL DETACH_VEHICLE_FROM_ANY_CARGOBOB(Vehicle vehicle) { return invoke<BOOL>(0xADF7BE450512C12F, vehicle); } // 0xADF7BE450512C12F
	static BOOL DETACH_VEHICLE_FROM_ANY_TOW_TRUCK(Vehicle vehicle) { return invoke<BOOL>(0xD0E9CE05A1E68CD8, vehicle); } // 0xD0E9CE05A1E68CD8
	static void DETACH_VEHICLE_FROM_CARGOBOB(Vehicle vehicle, Vehicle cargobob) { invoke<Void>(0xE21D3DF1051399D, vehicle, cargobob); } // 0xE21D3DF1051399D
	static void DETACH_VEHICLE_FROM_TOW_TRUCK(Vehicle towTruck, Vehicle vehicle) { invoke<Void>(0xC2DB6B6708350ED8, towTruck, vehicle); } // 0xC2DB6B6708350ED8
	static void DETACH_VEHICLE_FROM_TRAILER(Vehicle vehicle) { invoke<Void>(0x90532EDF0D2BDD86, vehicle); } // 0x90532EDF0D2BDD86
	static void _DETACH_VEHICLE_WINDSCREEN(Vehicle vehicle) { invoke<Void>(0x6D645D59FB5F5AD3, vehicle); } // 0x6D645D59FB5F5AD3
	static void DISABLE_PLANE_AILERON(Vehicle vehicle, BOOL p1, BOOL p2) { invoke<Void>(0x23428FC53C60919C, vehicle, p1, p2); } // 0x23428FC53C60919C
	static void DISABLE_VEHICLE_IMPACT_EXPLOSION_ACTIVATION(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xD8050E0EB60CF274, vehicle, toggle); } // 0xD8050E0EB60CF274
	static void _DISABLE_VEHICLE_NEON_LIGHTS(Vehicle vehicle, BOOL disable) { invoke<Void>(0x83F813570FF519DE, vehicle, disable); } // 0x83F813570FF519DE
	static void DISABLE_VEHICLE_WEAPON(BOOL disabled, Hash weaponHash, Vehicle vehicle, Ped owner) { invoke<Void>(0xF4FC6A6F67D8D856, disabled, weaponHash, vehicle, owner); } // 0xF4FC6A6F67D8D856
	static void _DISPLAY_DISTANT_VEHICLES(BOOL toggle) { invoke<Void>(0xF796359A959DF65D, toggle); } // 0xF796359A959DF65D
	static BOOL _DOES_CARGOBOB_HAVE_PICKUP_MAGNET(Vehicle cargobob) { return invoke<BOOL>(0x6E08BF5B3722BAC9, cargobob); } // 0x6E08BF5B3722BAC9
	static BOOL DOES_CARGOBOB_HAVE_PICK_UP_ROPE(Vehicle cargobob) { return invoke<BOOL>(0x1821D91AD4B56108, cargobob); } // 0x1821D91AD4B56108
	static BOOL DOES_EXTRA_EXIST(Vehicle vehicle, int extraId) { return invoke<BOOL>(0x1262D55792428154, vehicle, extraId); } // 0x1262D55792428154
	static BOOL DOES_SCRIPT_VEHICLE_GENERATOR_EXIST(int v) { return invoke<BOOL>(0xF6086BC836400876, v); } // 0xF6086BC836400876
	static BOOL DOES_VEHICLE_EXIST_WITH_DECORATOR(char* decorator) { return invoke<BOOL>(0x956B409B984D9BF7, decorator); } // 0x956B409B984D9BF7
	static BOOL _DOES_VEHICLE_HAVE_DOOR(Vehicle vehicle, int doorIndex) { return invoke<BOOL>(0x645F4B6E8499F632, vehicle, doorIndex); } // 0x645F4B6E8499F632
	static BOOL DOES_VEHICLE_HAVE_ROOF(Vehicle vehicle) { return invoke<BOOL>(0x8AC862B0B32C5B80, vehicle); } // 0x8AC862B0B32C5B80
	static BOOL DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK(Vehicle vehicle) { return invoke<BOOL>(0x57E4C39DE5EE8470, vehicle); } // 0x57E4C39DE5EE8470
	static BOOL DOES_VEHICLE_HAVE_WEAPONS(Vehicle vehicle) { return invoke<BOOL>(0x25ECB9F8017D98E0, vehicle); } // 0x25ECB9F8017D98E0
	static void _EJECT_JB700_ROOF(Vehicle vehicle, float x, float y, float z) { invoke<Void>(0xE38CB9D7D39FDBCC, vehicle, x, y, z); } // 0xE38CB9D7D39FDBCC
	static void EXPLODE_VEHICLE(Vehicle vehicle, BOOL isAudible, BOOL isInvisible) { invoke<Void>(0xBA71116ADF5B514C, vehicle, isAudible, isInvisible); } // 0xBA71116ADF5B514C
	static void EXPLODE_VEHICLE_IN_CUTSCENE(Vehicle vehicle, BOOL p1) { invoke<Void>(0x786A4EB67B01BF0B, vehicle, p1); } // 0x786A4EB67B01BF0B
	static Any FIX_VEHICLE_WINDOW(Vehicle vehicle, int index) { return invoke<Any>(0x772282EBEB95E682, vehicle, index); } // 0x772282EBEB95E682
	static int _GET_AIRCRAFT_BOMB_COUNT(Vehicle aircraft) { return invoke<int>(0xEA12BD130D7569A1, aircraft); } // 0xEA12BD130D7569A1
	static int _GET_AIRCRAFT_COUNTERMEASURE_COUNT(Vehicle aircraft) { return invoke<int>(0xF846AA63DF56B804, aircraft); } // 0xF846AA63DF56B804
	static int _GET_ALL_VEHICLES(Any* vehArray) { return invoke<int>(0x9B8E1BF04B51F2E8, vehArray); } // 0x9B8E1BF04B51F2E8
	static BOOL _GET_BOAT_ANCHOR(Vehicle vehicle) { return invoke<BOOL>(0x26C10ECBDA5D043B, vehicle); } // 0x26C10ECBDA5D043B
	static Vector3 _GET_CARGOBOB_HOOK_POSITION(Vehicle cargobob) { return invoke<Vector3>(0xCBDB9B923CACC92D, cargobob); } // 0xCBDB9B923CACC92D
	static Vehicle GET_CLOSEST_VEHICLE(float x, float y, float z, float radius, Hash modelHash, int flags) { return invoke<Vehicle>(0xF73EB622C4F1689B, x, y, z, radius, modelHash, flags); } // 0xF73EB622C4F1689B
	static int GET_CONVERTIBLE_ROOF_STATE(Vehicle vehicle) { return invoke<int>(0xF8C397922FC03F41, vehicle); } // 0xF8C397922FC03F41
	static Any GET_CURRENT_PLAYBACK_FOR_VEHICLE(Any p0) { return invoke<Any>(0x42BC05C27A946054, p0); } // 0x42BC05C27A946054
	static char* GET_DISPLAY_NAME_FROM_VEHICLE_MODEL(Hash modelHash) { return invoke<char*>(0xB215AAC32D25D019, modelHash); } // 0xB215AAC32D25D019
	static Entity GET_ENTITY_ATTACHED_TO_TOW_TRUCK(Vehicle towTruck) { return invoke<Entity>(0xEFEA18DCF10F8F75, towTruck); } // 0xEFEA18DCF10F8F75
	static Vector3 _GET_ENTRY_POSITION_OF_DOOR(Vehicle vehicle, int doorIndex) { return invoke<Vector3>(0xC0572928C0ABFDA3, vehicle, doorIndex); } // 0xC0572928C0ABFDA3
	static BOOL _GET_HAS_LOWERABLE_WHEELS(Vehicle vehicle) { return invoke<BOOL>(0xDCA174A42133F08C, vehicle); } // 0xDCA174A42133F08C
	static float _GET_HELI_ENGINE_HEALTH(Vehicle vehicle) { return invoke<float>(0xAC51915D27E4A5F7, vehicle); } // 0xAC51915D27E4A5F7
	static float _GET_HELI_MAIN_ROTOR_HEALTH(Vehicle vehicle) { return invoke<float>(0xE4CB7541F413D2C5, vehicle); } // 0xE4CB7541F413D2C5
	static float _GET_HELI_TAIL_ROTOR_HEALTH(Vehicle vehicle) { return invoke<float>(0xAE8CE82A4219AC8C, vehicle); } // 0xAE8CE82A4219AC8C
	static BOOL GET_IS_LEFT_VEHICLE_HEADLIGHT_DAMAGED(Vehicle vehicle) { return invoke<BOOL>(0x5EF77C9ADD3B11A3, vehicle); } // 0x5EF77C9ADD3B11A3
	static BOOL GET_IS_RIGHT_VEHICLE_HEADLIGHT_DAMAGED(Vehicle vehicle) { return invoke<BOOL>(0xA7ECB73355EB2F20, vehicle); } // 0xA7ECB73355EB2F20
	static BOOL GET_IS_VEHICLE_ENGINE_RUNNING(Vehicle vehicle) { return invoke<BOOL>(0xAE31E7DF9B5B132E, vehicle); } // 0xAE31E7DF9B5B132E
	static BOOL GET_IS_VEHICLE_PRIMARY_COLOUR_CUSTOM(Vehicle vehicle) { return invoke<BOOL>(0xF095C0405307B21B, vehicle); } // 0xF095C0405307B21B
	static BOOL GET_IS_VEHICLE_SECONDARY_COLOUR_CUSTOM(Vehicle vehicle) { return invoke<BOOL>(0x910A32E7AAD2656C, vehicle); } // 0x910A32E7AAD2656C
	static int GET_LANDING_GEAR_STATE(Vehicle vehicle) { return invoke<int>(0x9B0F3DCA3DB0F4CD, vehicle); } // 0x9B0F3DCA3DB0F4CD
	static Vehicle GET_LAST_DRIVEN_VEHICLE() { return invoke<Vehicle>(0xB2D06FAEDE65B577); } // 0xB2D06FAEDE65B577
	static Ped GET_LAST_PED_IN_VEHICLE_SEAT(Vehicle vehicle, int seatIndex) { return invoke<Ped>(0x83F969AA1EE2A664, vehicle, seatIndex); } // 0x83F969AA1EE2A664
	static char* GET_LIVERY_NAME(Vehicle vehicle, int liveryIndex) { return invoke<char*>(0xB4C7A93837C91A1F, vehicle, liveryIndex); } // 0xB4C7A93837C91A1F
	static char* GET_MOD_SLOT_NAME(Vehicle vehicle, int modType) { return invoke<char*>(0x51F0FEB9F6AE98C0, vehicle, modType); } // 0x51F0FEB9F6AE98C0
	static char* GET_MOD_TEXT_LABEL(Vehicle vehicle, int modType, int modValue) { return invoke<char*>(0x8935624F8C5592CC, vehicle, modType, modValue); } // 0x8935624F8C5592CC
	static int GET_NUMBER_OF_VEHICLE_COLOURS(Vehicle vehicle) { return invoke<int>(0x3B963160CD65D41E, vehicle); } // 0x3B963160CD65D41E
	static Any _GET_NUMBER_OF_VEHICLE_DOORS(Vehicle vehicle) { return invoke<Any>(0x92922A607497B14D, vehicle); } // 0x92922A607497B14D
	static int GET_NUMBER_OF_VEHICLE_NUMBER_PLATES() { return invoke<int>(0x4C4D6B2644F458CB); } // 0x4C4D6B2644F458CB
	static int GET_NUM_MOD_COLORS(int p0, BOOL p1) { return invoke<int>(0xA551BE18C11A476D, p0, p1); } // 0xA551BE18C11A476D
	static int GET_NUM_MOD_KITS(Vehicle vehicle) { return invoke<int>(0x33F2E3FE70EAAE1D, vehicle); } // 0x33F2E3FE70EAAE1D
	static int GET_NUM_VEHICLE_MODS(Vehicle vehicle, int modType) { return invoke<int>(0xE38E9162A2500646, vehicle, modType); } // 0xE38E9162A2500646
	static int GET_NUM_VEHICLE_WINDOW_TINTS() { return invoke<int>(0x9D1224004B3A6707); } // 0x9D1224004B3A6707
	static Ped GET_PED_IN_VEHICLE_SEAT(Vehicle vehicle, int index) { return invoke<Ped>(0xBB40DD2270B65366, vehicle, index); } // 0xBB40DD2270B65366
	static Ped _GET_PED_USING_VEHICLE_DOOR(Vehicle vehicle, int doorIndex) { return invoke<Ped>(0x218297BF0CFD853B, vehicle, doorIndex); } // 0x218297BF0CFD853B
	static float GET_POSITION_IN_RECORDING(Any p0) { return invoke<float>(0x2DACD605FC681475, p0); } // 0x2DACD605FC681475
	static Vector3 GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME(int p0, float p1, char* p2) { return invoke<Vector3>(0xD242728AA6F0FBA2, p0, p1, p2); } // 0xD242728AA6F0FBA2
	static Vehicle GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6) { return invoke<Vehicle>(0xB50807EABE20A8DC, p0, p1, p2, p3, p4, p5, p6); } // 0xB50807EABE20A8DC
	static Vehicle GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE(float p0, float p1, float p2, float p3, int p4, int p5, int p6) { return invoke<Vehicle>(0xC5574E0AEB86BA68, p0, p1, p2, p3, p4, p5, p6); } // 0xC5574E0AEB86BA68
	static Vehicle GET_RANDOM_VEHICLE_IN_SPHERE(float x, float y, float z, float radius, Hash modelHash, int flags) { return invoke<Vehicle>(0x386F6CE5BAF6091C, x, y, z, radius, modelHash, flags); } // 0x386F6CE5BAF6091C
	static void GET_RANDOM_VEHICLE_MODEL_IN_MEMORY(BOOL p0, Hash* modelHash, int* p2) { invoke<Void>(0x55BF0AC0C34F4FD, p0, modelHash, p2); } // 0x55BF0AC0C34F4FD
	static int GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME(Any p0, float p1, Any* p2) { return invoke<int>(0x2058206FBE79A8AD, p0, p1, p2); } // 0x2058206FBE79A8AD
	static float GET_TIME_POSITION_IN_RECORDING(Any p0) { return invoke<float>(0x5746F3A7AB7FE544, p0); } // 0x5746F3A7AB7FE544
	static Any GET_TOTAL_DURATION_OF_VEHICLE_RECORDING(Any p0, Any p1) { return invoke<Any>(0xE48D1C262390950, p0, p1); } // 0xE48D1C262390950
	static float GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID(Any p0) { return invoke<float>(0x102D125411A7B6E6, p0); } // 0x102D125411A7B6E6
	static Entity GET_TRAIN_CARRIAGE(Vehicle train, int trailerNumber) { return invoke<Entity>(0x8AAFD0814722BC3, train, trailerNumber); } // 0x8AAFD0814722BC3
	static float GET_VEHICLE_ACCELERATION(Vehicle vehicle) { return invoke<float>(0x5DD35C8D074E57AE, vehicle); } // 0x5DD35C8D074E57AE
	static Vehicle GET_VEHICLE_ATTACHED_TO_CARGOBOB(Vehicle cargobob) { return invoke<Vehicle>(0x873B82D42AC2B9E5, cargobob); } // 0x873B82D42AC2B9E5
	static Vehicle _GET_VEHICLE_ATTACHED_TO_ENTITY(Vehicle object) { return invoke<Vehicle>(0x375E7FC44F21C8AB, object); } // 0x375E7FC44F21C8AB
	static float GET_VEHICLE_BODY_HEALTH(Vehicle vehicle) { return invoke<float>(0xF271147EB7B40F12, vehicle); } // 0xF271147EB7B40F12
	static float _GET_VEHICLE_BODY_HEALTH_2(Vehicle vehicle) { return invoke<float>(0xB8EF61207C2393A9, vehicle); } // 0xB8EF61207C2393A9
	static Hash GET_VEHICLE_CAUSE_OF_DESTRUCTION(Vehicle vehicle) { return invoke<Hash>(0xE495D1EF4C91FD20, vehicle); } // 0xE495D1EF4C91FD20
	static int GET_VEHICLE_CLASS(Vehicle vehicle) { return invoke<int>(0x29439776AAA00A62, vehicle); } // 0x29439776AAA00A62
	static int GET_VEHICLE_CLASS_FROM_NAME(Hash modelHash) { return invoke<int>(0xDEDF1C8BD47C2200, modelHash); } // 0xDEDF1C8BD47C2200
	static float GET_VEHICLE_CLASS_MAX_ACCELERATION(int vehicleClass) { return invoke<float>(0x2F83E7E45D9EA7AE, vehicleClass); } // 0x2F83E7E45D9EA7AE
	static float GET_VEHICLE_CLASS_MAX_AGILITY(int vehicleClass) { return invoke<float>(0x4F930AD022D6DE3B, vehicleClass); } // 0x4F930AD022D6DE3B
	static float GET_VEHICLE_CLASS_MAX_BRAKING(int vehicleClass) { return invoke<float>(0x4BF54C16EC8FEC03, vehicleClass); } // 0x4BF54C16EC8FEC03
	static float _GET_VEHICLE_CLASS_MAX_SPEED(int vehicleClass) { return invoke<float>(0xC09F246ABEDD82, vehicleClass); } // 0xC09F246ABEDD82
	static float GET_VEHICLE_CLASS_MAX_TRACTION(int vehicleClass) { return invoke<float>(0xDBC86D85C5059461, vehicleClass); } // 0xDBC86D85C5059461
	static void GET_VEHICLE_COLOR(Vehicle vehicle, int* r, int* g, int* b) { invoke<Void>(0xF3CC740D36221548, vehicle, r, g, b); } // 0xF3CC740D36221548
	static int GET_VEHICLE_COLOUR_COMBINATION(Vehicle vehicle) { return invoke<int>(0x6A842D197F845D56, vehicle); } // 0x6A842D197F845D56
	static void GET_VEHICLE_COLOURS(Vehicle vehicle, int* colorPrimary, int* colorSecondary) { invoke<Void>(0xA19435F193E081AC, vehicle, colorPrimary, colorSecondary); } // 0xA19435F193E081AC
	static void GET_VEHICLE_CUSTOM_PRIMARY_COLOUR(Vehicle vehicle, int* r, int* g, int* b) { invoke<Void>(0xB64CF2CCA9D95F52, vehicle, r, g, b); } // 0xB64CF2CCA9D95F52
	static void GET_VEHICLE_CUSTOM_SECONDARY_COLOUR(Vehicle vehicle, int* r, int* g, int* b) { invoke<Void>(0x8389CD56CA8072DC, vehicle, r, g, b); } // 0x8389CD56CA8072DC
	static void _GET_VEHICLE_DASHBOARD_COLOUR(Vehicle vehicle, int* color) { invoke<Void>(0xB7635E80A5C31BFF, vehicle, color); } // 0xB7635E80A5C31BFF
	static Vector3 GET_VEHICLE_DEFORMATION_AT_POS(Vehicle vehicle, float offsetX, float offsetY, float offsetZ) { return invoke<Vector3>(0x4EC6CFBC7B2E9536, vehicle, offsetX, offsetY, offsetZ); } // 0x4EC6CFBC7B2E9536
	static float GET_VEHICLE_DIRT_LEVEL(Vehicle vehicle) { return invoke<float>(0x8F17BC8BA08DA62B, vehicle); } // 0x8F17BC8BA08DA62B
	static float GET_VEHICLE_DOOR_ANGLE_RATIO(Vehicle vehicle, int door) { return invoke<float>(0xFE3F9C29F7B32BD5, vehicle, door); } // 0xFE3F9C29F7B32BD5
	static int GET_VEHICLE_DOOR_LOCK_STATUS(Vehicle vehicle) { return invoke<int>(0x25BC98A59C2EA962, vehicle); } // 0x25BC98A59C2EA962
	static BOOL GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(Vehicle vehicle, Player player) { return invoke<BOOL>(0xF6AF6CB341349015, vehicle, player); } // 0xF6AF6CB341349015
	static float GET_VEHICLE_ENGINE_HEALTH(Vehicle vehicle) { return invoke<float>(0xC45D23BAF168AAB8, vehicle); } // 0xC45D23BAF168AAB8
	static float GET_VEHICLE_ENVEFF_SCALE(Vehicle vehicle) { return invoke<float>(0xA82819CAC9C4C403, vehicle); } // 0xA82819CAC9C4C403
	static void GET_VEHICLE_EXTRA_COLOURS(Vehicle vehicle, int* pearlescentColor, int* wheelColor) { invoke<Void>(0x3BC4245933A166F7, vehicle, pearlescentColor, wheelColor); } // 0x3BC4245933A166F7
	static int _GET_VEHICLE_HEADLIGHTS_COLOUR(Vehicle vehicle) { return invoke<int>(0x3DFF319A831E0CDB, vehicle); } // 0x3DFF319A831E0CDB
	static float _GET_VEHICLE_HOVER_MODE_PERCENTAGE(Vehicle aircraft) { return invoke<float>(0xDA62027C8BDB326E, aircraft); } // 0xDA62027C8BDB326E
	static void _GET_VEHICLE_INTERIOR_COLOUR(Vehicle vehicle, int* color) { invoke<Void>(0x7D1464D472D32136, vehicle, color); } // 0x7D1464D472D32136
	static Hash GET_VEHICLE_LAYOUT_HASH(Vehicle vehicle) { return invoke<Hash>(0x28D37D4F71AC5C58, vehicle); } // 0x28D37D4F71AC5C58
	static BOOL GET_VEHICLE_LIGHTS_STATE(Vehicle vehicle, BOOL* lightsOn, BOOL* highbeamsOn) { return invoke<BOOL>(0xB91B4C20085BD12F, vehicle, lightsOn, highbeamsOn); } // 0xB91B4C20085BD12F
	static int GET_VEHICLE_LIVERY(Vehicle trailers2) { return invoke<int>(0x2BB9230590DA5E8A, trailers2); } // 0x2BB9230590DA5E8A
	static int GET_VEHICLE_LIVERY_COUNT(Vehicle vehicle) { return invoke<int>(0x87B63E25A529D526, vehicle); } // 0x87B63E25A529D526
	static float GET_VEHICLE_MAX_BRAKING(Vehicle vehicle) { return invoke<float>(0xAD7E85FC227197C4, vehicle); } // 0xAD7E85FC227197C4
	static int GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(Vehicle vehicle) { return invoke<int>(0xA7C4F2C6E744A550, vehicle); } // 0xA7C4F2C6E744A550
	static float _GET_VEHICLE_MAX_SPEED(Vehicle vehicle) { return invoke<float>(0x53AF99BAA671CA47, vehicle); } // 0x53AF99BAA671CA47
	static float GET_VEHICLE_MAX_TRACTION(Vehicle vehicle) { return invoke<float>(0xA132FB5370554DB0, vehicle); } // 0xA132FB5370554DB0
	static int GET_VEHICLE_MOD(Vehicle vehicle, int modType) { return invoke<int>(0x772960298DA26FDB, vehicle, modType); } // 0x772960298DA26FDB
	static void GET_VEHICLE_MOD_COLOR_1(Vehicle vehicle, int* paintType, int* color, int* pearlescentColor) { invoke<Void>(0xE8D65CA700C9A693, vehicle, paintType, color, pearlescentColor); } // 0xE8D65CA700C9A693
	static char* GET_VEHICLE_MOD_COLOR_1_NAME(Vehicle vehicle, BOOL p1) { return invoke<char*>(0xB45085B721EFD38C, vehicle, p1); } // 0xB45085B721EFD38C
	static void GET_VEHICLE_MOD_COLOR_2(Vehicle vehicle, int* paintType, int* color) { invoke<Void>(0x81592BE4E3878728, vehicle, paintType, color); } // 0x81592BE4E3878728
	static char* GET_VEHICLE_MOD_COLOR_2_NAME(Vehicle vehicle) { return invoke<char*>(0x4967A516ED23A5A1, vehicle); } // 0x4967A516ED23A5A1
	static Any _GET_VEHICLE_MOD_DATA(Vehicle vehicle, int modType, int modIndex) { return invoke<Any>(0x4593CF82AA179706, vehicle, modType, modIndex); } // 0x4593CF82AA179706
	static float GET_VEHICLE_MODEL_ACCELERATION(Hash modelHash) { return invoke<float>(0x8C044C5C84505B6A, modelHash); } // 0x8C044C5C84505B6A
	static float _GET_VEHICLE_MODEL_DOWN_FORCE(Hash modelHash) { return invoke<float>(0x53409B5163D5B846, modelHash); } // 0x53409B5163D5B846
	static float _GET_VEHICLE_MODEL_HAND_BRAKE(Hash modelHash) { return invoke<float>(0xBFBA3BA79CFF7EBF, modelHash); } // 0xBFBA3BA79CFF7EBF
	static float GET_VEHICLE_MODEL_MAX_BRAKING(Hash modelHash) { return invoke<float>(0xDC53FD41B4ED944C, modelHash); } // 0xDC53FD41B4ED944C
	static float _GET_VEHICLE_MODEL_MAX_KNOTS(Hash modelHash) { return invoke<float>(0xC6AD107DDC9054CC, modelHash); } // 0xC6AD107DDC9054CC
	static float _GET_VEHICLE_MODEL_MAX_SPEED(Hash modelHash) { return invoke<float>(0xF417C2502FFFED43, modelHash); } // 0xF417C2502FFFED43
	static float GET_VEHICLE_MODEL_MAX_TRACTION(Hash modelHash) { return invoke<float>(0x539DE94D44FDFD0D, modelHash); } // 0x539DE94D44FDFD0D
	static float _GET_VEHICLE_MODEL_MOVE_RESISTANCE(Hash modelHash) { return invoke<float>(0x5AA3F878A178C4FC, modelHash); } // 0x5AA3F878A178C4FC
	static int GET_VEHICLE_MODEL_NUMBER_OF_SEATS(Hash modelHash) { return invoke<int>(0x2AD93716F184EDA4, modelHash); } // 0x2AD93716F184EDA4
	static int GET_VEHICLE_MOD_KIT(Vehicle vehicle) { return invoke<int>(0x6325D1A044AE510D, vehicle); } // 0x6325D1A044AE510D
	static int GET_VEHICLE_MOD_KIT_TYPE(Vehicle vehicle) { return invoke<int>(0xFC058F5121E54C32, vehicle); } // 0xFC058F5121E54C32
	static float GET_VEHICLE_MOD_MODIFIER_VALUE(Vehicle vehicle, int modType, int modIndex) { return invoke<float>(0x90A38E9838E0A8C1, vehicle, modType, modIndex); } // 0x90A38E9838E0A8C1
	static BOOL GET_VEHICLE_MOD_VARIATION(Vehicle vehicle, int modType) { return invoke<BOOL>(0xB3924ECD70E095DC, vehicle, modType); } // 0xB3924ECD70E095DC
	static void _GET_VEHICLE_NEON_LIGHTS_COLOUR(Vehicle vehicle, int* r, int* g, int* b) { invoke<Void>(0x7619EEE8C886757F, vehicle, r, g, b); } // 0x7619EEE8C886757F
	static int GET_VEHICLE_NUMBER_OF_PASSENGERS(Vehicle vehicle) { return invoke<int>(0x24CB2137731FFE89, vehicle); } // 0x24CB2137731FFE89
	static char* GET_VEHICLE_NUMBER_PLATE_TEXT(Vehicle vehicle) { return invoke<char*>(0x7CE1CCB9B293020E, vehicle); } // 0x7CE1CCB9B293020E
	static int GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(Vehicle elegy) { return invoke<int>(0xF11BC2DD9A3E7195, elegy); } // 0xF11BC2DD9A3E7195
	static BOOL _GET_VEHICLE_OWNER(Vehicle vehicle, Entity* entity) { return invoke<BOOL>(0x8F5EBAB1F260CFCE, vehicle, entity); } // 0x8F5EBAB1F260CFCE
	static float GET_VEHICLE_PETROL_TANK_HEALTH(Vehicle vehicle) { return invoke<float>(0x7D5DABE888D2D074, vehicle); } // 0x7D5DABE888D2D074
	static int GET_VEHICLE_PLATE_TYPE(Vehicle vehicle) { return invoke<int>(0x9CCC9525BF2408E0, vehicle); } // 0x9CCC9525BF2408E0
	static int GET_VEHICLE_RECORDING_ID(int p0, char* p1) { return invoke<int>(0x21543C612379DB3C, p0, p1); } // 0x21543C612379DB3C
	static float _GET_VEHICLE_SUSPENSION_HEIGHT(Vehicle vehicle) { return invoke<float>(0x53952FD2BAA19F17, vehicle); } // 0x53952FD2BAA19F17
	static BOOL GET_VEHICLE_TRAILER_VEHICLE(Vehicle vehicle, Vehicle* trailer) { return invoke<BOOL>(0x1CDD6BADC297830D, vehicle, trailer); } // 0x1CDD6BADC297830D
	static BOOL GET_VEHICLE_TYRES_CAN_BURST(Vehicle vehicle) { return invoke<BOOL>(0x678B9BB8C3F58FEB, vehicle); } // 0x678B9BB8C3F58FEB
	static void GET_VEHICLE_TYRE_SMOKE_COLOR(Vehicle vehicle, int* r, int* g, int* b) { invoke<Void>(0xB635392A4938B3C3, vehicle, r, g, b); } // 0xB635392A4938B3C3
	static int GET_VEHICLE_WHEEL_TYPE(Vehicle vehicle) { return invoke<int>(0xB3ED1BFB4BE636DC, vehicle); } // 0xB3ED1BFB4BE636DC
	static int GET_VEHICLE_WINDOW_TINT(Vehicle vehicle) { return invoke<int>(0xEE21293DAD47C95, vehicle); } // 0xEE21293DAD47C95
	static BOOL HAS_PRELOAD_MODS_FINISHED(Any p0) { return invoke<BOOL>(0x6F43E5175EB6D96, p0); } // 0x6F43E5175EB6D96
	static BOOL HAS_VEHICLE_ASSET_LOADED(int vehicleAsset) { return invoke<BOOL>(0x1BBE0523B8DB9A21, vehicleAsset); } // 0x1BBE0523B8DB9A21
	static BOOL _HAS_VEHICLE_JUMPING_ABILITY(Vehicle vehicle) { return invoke<BOOL>(0x9078C0C5EF8C19E9, vehicle); } // 0x9078C0C5EF8C19E9
	static BOOL _HAS_VEHICLE_PARACHUTE(Vehicle vehicle) { return invoke<BOOL>(0xBC9CFF381338CB4F, vehicle); } // 0xBC9CFF381338CB4F
	static BOOL HAS_VEHICLE_RECORDING_BEEN_LOADED(Any p0, Any* p1) { return invoke<BOOL>(0x300D614A4C785FC4, p0, p1); } // 0x300D614A4C785FC4
	static BOOL _HAS_VEHICLE_ROCKET_BOOST(Vehicle vehicle) { return invoke<BOOL>(0x36D782F68B309BDA, vehicle); } // 0x36D782F68B309BDA
	static BOOL IS_ANY_VEHICLE_NEAR_POINT(float x, float y, float z, float radius) { return invoke<BOOL>(0x61E1DD6125A3EEE6, x, y, z, radius); } // 0x61E1DD6125A3EEE6
	static BOOL IS_BIG_VEHICLE(Vehicle vehicle) { return invoke<BOOL>(0x9F243D3919F442FE, vehicle); } // 0x9F243D3919F442FE
	static BOOL IS_COP_VEHICLE_IN_AREA_3D(float x1, float x2, float y1, float y2, float z1, float z2) { return invoke<BOOL>(0x7EEF65D5F153E26A, x1, x2, y1, y2, z1, z2); } // 0x7EEF65D5F153E26A
	static BOOL IS_HELI_PART_BROKEN(Vehicle vehicle, BOOL p1, BOOL p2, BOOL p3) { return invoke<BOOL>(0xBC74B4BE25EB6C8A, vehicle, p1, p2, p3); } // 0xBC74B4BE25EB6C8A
	static BOOL IS_PLAYBACK_GOING_ON_FOR_VEHICLE(Any p0) { return invoke<BOOL>(0x1C8A4C2C19E68EEC, p0); } // 0x1C8A4C2C19E68EEC
	static BOOL IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE(Any p0) { return invoke<BOOL>(0xAEA8FD591FAD4106, p0); } // 0xAEA8FD591FAD4106
	static BOOL IS_TAXI_LIGHT_ON(Vehicle vehicle) { return invoke<BOOL>(0x7504C0F113AB50FC, vehicle); } // 0x7504C0F113AB50FC
	static BOOL IS_THIS_MODEL_A_BICYCLE(Hash model) { return invoke<BOOL>(0xBF94DD42F63BDED2, model); } // 0xBF94DD42F63BDED2
	static BOOL IS_THIS_MODEL_A_BIKE(Hash model) { return invoke<BOOL>(0xB50C0B0CEDC6CE84, model); } // 0xB50C0B0CEDC6CE84
	static BOOL IS_THIS_MODEL_A_BOAT(Hash model) { return invoke<BOOL>(0x45A9187928F4B9E3, model); } // 0x45A9187928F4B9E3
	static BOOL IS_THIS_MODEL_A_CAR(Hash model) { return invoke<BOOL>(0x7F6DB52EEFC96DF8, model); } // 0x7F6DB52EEFC96DF8
	static BOOL IS_THIS_MODEL_A_HELI(Hash model) { return invoke<BOOL>(0xDCE4334788AF94EA, model); } // 0xDCE4334788AF94EA
	static BOOL _IS_THIS_MODEL_A_JETSKI(Hash model) { return invoke<BOOL>(0x9537097412CF75FE, model); } // 0x9537097412CF75FE
	static BOOL _IS_THIS_MODEL_AN_AMPHIBIOUS_CAR(Hash model) { return invoke<BOOL>(0x633F6F44A537EBB6, model); } // 0x633F6F44A537EBB6
	static BOOL IS_THIS_MODEL_A_PLANE(Hash model) { return invoke<BOOL>(0xA0948AB42D7BA0DE, model); } // 0xA0948AB42D7BA0DE
	static BOOL IS_THIS_MODEL_A_QUADBIKE(Hash model) { return invoke<BOOL>(0x39DAC362EE65FA28, model); } // 0x39DAC362EE65FA28
	static BOOL IS_THIS_MODEL_A_TRAIN(Hash model) { return invoke<BOOL>(0xAB935175B22E822B, model); } // 0xAB935175B22E822B
	static BOOL IS_TOGGLE_MOD_ON(Vehicle vehicle, int modType) { return invoke<BOOL>(0x84B233A8C8FC8AE7, vehicle, modType); } // 0x84B233A8C8FC8AE7
	static BOOL IS_VEHICLE_A_CONVERTIBLE(Vehicle vehicle, BOOL p1) { return invoke<BOOL>(0x52F357A30698BCCE, vehicle, p1); } // 0x52F357A30698BCCE
	static BOOL IS_VEHICLE_ALARM_ACTIVATED(Vehicle vehicle) { return invoke<BOOL>(0x4319E335B71FFF34, vehicle); } // 0x4319E335B71FFF34
	static BOOL IS_VEHICLE_ATTACHED_TO_CARGOBOB(Vehicle cargobob, Vehicle vehicleAttached) { return invoke<BOOL>(0xD40148F22E81A1D9, cargobob, vehicleAttached); } // 0xD40148F22E81A1D9
	static BOOL IS_VEHICLE_ATTACHED_TO_TOW_TRUCK(Vehicle towTruck, Vehicle vehicle) { return invoke<BOOL>(0x146DF9EC4C4B9FD4, towTruck, vehicle); } // 0x146DF9EC4C4B9FD4
	static BOOL IS_VEHICLE_ATTACHED_TO_TRAILER(Vehicle vehicle) { return invoke<BOOL>(0xE7CF3C4F9F489F0C, vehicle); } // 0xE7CF3C4F9F489F0C
	static BOOL IS_VEHICLE_BUMPER_BROKEN_OFF(Vehicle vehicle, BOOL front) { return invoke<BOOL>(0x468056A6BB6F3846, vehicle, front); } // 0x468056A6BB6F3846
	static BOOL _IS_VEHICLE_DAMAGED(Vehicle vehicle) { return invoke<BOOL>(0xBCDC5017D3CE1E9E, vehicle); } // 0xBCDC5017D3CE1E9E
	static BOOL IS_VEHICLE_DOOR_DAMAGED(Vehicle veh, int doorID) { return invoke<BOOL>(0xB8E181E559464527, veh, doorID); } // 0xB8E181E559464527
	static BOOL IS_VEHICLE_DOOR_FULLY_OPEN(Vehicle vehicle, int doorIndex) { return invoke<BOOL>(0x3E933CFF7B111C22, vehicle, doorIndex); } // 0x3E933CFF7B111C22
	static BOOL IS_VEHICLE_DRIVEABLE(Vehicle vehicle, BOOL isOnFireCheck) { return invoke<BOOL>(0x4C241E39B23DF959, vehicle, isOnFireCheck); } // 0x4C241E39B23DF959
	static BOOL _IS_VEHICLE_ENGINE_ON_FIRE(Vehicle vehicle) { return invoke<BOOL>(0xEC69ADF931AAE0C3, vehicle); } // 0xEC69ADF931AAE0C3
	static BOOL IS_VEHICLE_EXTRA_TURNED_ON(Vehicle vehicle, int extraId) { return invoke<BOOL>(0xD2E6822DBFD6C8BD, vehicle, extraId); } // 0xD2E6822DBFD6C8BD
	static BOOL IS_VEHICLE_HIGH_DETAIL(Vehicle vehicle) { return invoke<BOOL>(0x1F25887F3C104278, vehicle); } // 0x1F25887F3C104278
	static BOOL IS_VEHICLE_IN_BURNOUT(Vehicle vehicle) { return invoke<BOOL>(0x1297A88E081430EB, vehicle); } // 0x1297A88E081430EB
	static BOOL IS_VEHICLE_IN_GARAGE_AREA(char* garageName, Vehicle vehicle) { return invoke<BOOL>(0xCEE4490CD57BB3C2, garageName, vehicle); } // 0xCEE4490CD57BB3C2
	static BOOL IS_VEHICLE_MODEL(Vehicle vehicle, Hash model) { return invoke<BOOL>(0x423E8DE37D934D89, vehicle, model); } // 0x423E8DE37D934D89
	static BOOL _IS_VEHICLE_MOD_LOAD_DONE(Vehicle vehicle) { return invoke<BOOL>(0x9A83F5F9963775EF, vehicle); } // 0x9A83F5F9963775EF
	static BOOL _IS_VEHICLE_NEON_LIGHT_ENABLED(Vehicle vehicle, int index) { return invoke<BOOL>(0x8C4B92553E4766A5, vehicle, index); } // 0x8C4B92553E4766A5
	static BOOL IS_VEHICLE_ON_ALL_WHEELS(Vehicle vehicle) { return invoke<BOOL>(0xB104CD1BABF302E2, vehicle); } // 0xB104CD1BABF302E2
	static BOOL _IS_VEHICLE_ROCKET_BOOST_ACTIVE(Vehicle vehicle) { return invoke<BOOL>(0x3D34E80EED4AE3BE, vehicle); } // 0x3D34E80EED4AE3BE
	static BOOL IS_VEHICLE_SEARCHLIGHT_ON(Vehicle vehicle) { return invoke<BOOL>(0xC0F97FCE55094987, vehicle); } // 0xC0F97FCE55094987
	static BOOL IS_VEHICLE_SEAT_FREE(Vehicle vehicle, int seatIndex) { return invoke<BOOL>(0x22AC59A870E6A669, vehicle, seatIndex); } // 0x22AC59A870E6A669
	static BOOL _IS_VEHICLE_SHOP_RESPRAY_ALLOWED(Vehicle vehicle) { return invoke<BOOL>(0x8D474C8FAEFF6CDE, vehicle); } // 0x8D474C8FAEFF6CDE
	static BOOL IS_VEHICLE_SIREN_ON(Vehicle vehicle) { return invoke<BOOL>(0x4C9BF537BE2634B2, vehicle); } // 0x4C9BF537BE2634B2
	static BOOL _IS_VEHICLE_SIREN_SOUND_ON(Vehicle vehicle) { return invoke<BOOL>(0xB5CC40FBCB586380, vehicle); } // 0xB5CC40FBCB586380
	static BOOL IS_VEHICLE_STOLEN(Vehicle vehicle) { return invoke<BOOL>(0x4AF9BD80EEBEB453, vehicle); } // 0x4AF9BD80EEBEB453
	static BOOL IS_VEHICLE_STOPPED(Vehicle vehicle) { return invoke<BOOL>(0x5721B434AD84D57A, vehicle); } // 0x5721B434AD84D57A
	static BOOL IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS(Vehicle vehicle) { return invoke<BOOL>(0x2959F696AE390A99, vehicle); } // 0x2959F696AE390A99
	static BOOL IS_VEHICLE_STUCK_ON_ROOF(Vehicle vehicle) { return invoke<BOOL>(0xB497F06B288DCFDF, vehicle); } // 0xB497F06B288DCFDF
	static BOOL IS_VEHICLE_STUCK_TIMER_UP(Vehicle vehicle, int p1, int p2) { return invoke<BOOL>(0x679BE1DAF71DA874, vehicle, p1, p2); } // 0x679BE1DAF71DA874
	static BOOL IS_VEHICLE_TYRE_BURST(Vehicle vehicle, int wheelID, BOOL completely) { return invoke<BOOL>(0xBA291848A0815CA9, vehicle, wheelID, completely); } // 0xBA291848A0815CA9
	static BOOL IS_VEHICLE_VISIBLE(Vehicle vehicle) { return invoke<BOOL>(0xAA0A52D24FB98293, vehicle); } // 0xAA0A52D24FB98293
	static BOOL IS_VEHICLE_WINDOW_INTACT(Vehicle vehicle, int windowIndex) { return invoke<BOOL>(0x46E571A0E20D01F1, vehicle, windowIndex); } // 0x46E571A0E20D01F1
	static void _JITTER_VEHICLE(Vehicle vehicle, BOOL p1, float yaw, float pitch, float roll) { invoke<Void>(0xC59872A5134879C7, vehicle, p1, yaw, pitch, roll); } // 0xC59872A5134879C7
	static void LOWER_CONVERTIBLE_ROOF(Vehicle vehicle, BOOL instantlyLower) { invoke<Void>(0xDED51F703D0FA83D, vehicle, instantlyLower); } // 0xDED51F703D0FA83D
	static void _0x02398B627547189C(Vehicle p0, BOOL p1) { invoke<Void>(0x2398B627547189C, p0, p1); } // 0x2398B627547189C
	static Any _0x0419B167EE128F33(Any p0, Any p1) { return invoke<Any>(0x419B167EE128F33, p0, p1); } // 0x419B167EE128F33
	static void _0x0581730AB9380412(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0x581730AB9380412, p0, p1, p2, p3, p4, p5); } // 0x581730AB9380412
	static void _0x063AE2B2CC273588(Any p0, BOOL p1) { invoke<Void>(0x63AE2B2CC273588, p0, p1); } // 0x63AE2B2CC273588
	static void _0x06582AFF74894C75(Vehicle vehicle, BOOL p1) { invoke<Void>(0x6582AFF74894C75, vehicle, p1); } // 0x6582AFF74894C75
	static void _0x065D03A9D6B2C6B5(Any p0, Any p1) { invoke<Void>(0x65D03A9D6B2C6B5, p0, p1); } // 0x65D03A9D6B2C6B5
	static void _0x0A436B8643716D14() { invoke<Void>(0xA436B8643716D14); } // 0xA436B8643716D14
	static void _0x0A6A279F3AA4FD70(Vehicle vehicle, BOOL p1) { invoke<Void>(0xA6A279F3AA4FD70, vehicle, p1); } // 0xA6A279F3AA4FD70
	static void _0x0AD9E8F87FF7C16F(Any p0, BOOL p1) { invoke<Void>(0xAD9E8F87FF7C16F, p0, p1); } // 0xAD9E8F87FF7C16F
	static void _0x0CDDA42F9E360CA6(Vehicle vehicle, BOOL p1) { invoke<Void>(0xCDDA42F9E360CA6, vehicle, p1); } // 0xCDDA42F9E360CA6
	static void _0x0D5F65A8F4EBDAB5(Any p0, Any p1) { invoke<Void>(0xD5F65A8F4EBDAB5, p0, p1); } // 0xD5F65A8F4EBDAB5
	static void _0x0F3B4D4E43177236(Any p0, BOOL p1) { invoke<Void>(0xF3B4D4E43177236, p0, p1); } // 0xF3B4D4E43177236
	static void _0x10655FAB9915623D(Any p0, Any p1) { invoke<Void>(0x10655FAB9915623D, p0, p1); } // 0x10655FAB9915623D
	static void _0x1087BC8EC540DAEB(Any p0, Any p1) { invoke<Void>(0x1087BC8EC540DAEB, p0, p1); } // 0x1087BC8EC540DAEB
	static void _0x1093408B4B9D1146(Any p0, float p1) { invoke<Void>(0x1093408B4B9D1146, p0, p1); } // 0x1093408B4B9D1146
	static void _0x1201E8A3290A3B98(Any p0, Any p1) { invoke<Void>(0x1201E8A3290A3B98, p0, p1); } // 0x1201E8A3290A3B98
	static void _0x1312DDD8385AEE4E(Any p0, Any p1) { invoke<Void>(0x1312DDD8385AEE4E, p0, p1); } // 0x1312DDD8385AEE4E
	static void _0x16B5E274BDE402F8(Vehicle vehicle, Vehicle trailer, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11) { invoke<Void>(0x16B5E274BDE402F8, vehicle, trailer, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); } // 0x16B5E274BDE402F8
	static void _0x182F266C2D9E2BEB(Vehicle vehicle, float p1) { invoke<Void>(0x182F266C2D9E2BEB, vehicle, p1); } // 0x182F266C2D9E2BEB
	static void _0x192547247864DFDD(Vehicle vehicle, BOOL p1) { invoke<Void>(0x192547247864DFDD, vehicle, p1); } // 0x192547247864DFDD
	static void _0x1A78AD3D8240536F(Vehicle vehicle, BOOL p1) { invoke<Void>(0x1A78AD3D8240536F, vehicle, p1); } // 0x1A78AD3D8240536F
	static void _0x1AA8A837D2169D94(Vehicle vehicle, BOOL p1) { invoke<Void>(0x1AA8A837D2169D94, vehicle, p1); } // 0x1AA8A837D2169D94
	static void _0x1B212B26DD3C04DF(Any p0, Any p1) { invoke<Void>(0x1B212B26DD3C04DF, p0, p1); } // 0x1B212B26DD3C04DF
	static void _0x1BBAC99C0BC53656(Any p0, Any p1) { invoke<Void>(0x1BBAC99C0BC53656, p0, p1); } // 0x1BBAC99C0BC53656
	static void _0x1D97D1E3A70A649F(Vehicle vehicle, BOOL p1) { invoke<Void>(0x1D97D1E3A70A649F, vehicle, p1); } // 0x1D97D1E3A70A649F
	static Any _0x1DA0DA9CB3F0C8BF(Any p0) { return invoke<Any>(0x1DA0DA9CB3F0C8BF, p0); } // 0x1DA0DA9CB3F0C8BF
	static void _0x1DDA078D12879EEE(Any p0, Any p1, Any p2) { invoke<Void>(0x1DDA078D12879EEE, p0, p1, p2); } // 0x1DDA078D12879EEE
	static void _0x1F2E4E06DEA8992B(Any p0, BOOL p1) { invoke<Void>(0x1F2E4E06DEA8992B, p0, p1); } // 0x1F2E4E06DEA8992B
	static void _0x1F34B0626C594380(Any p0, Any p1) { invoke<Void>(0x1F34B0626C594380, p0, p1); } // 0x1F34B0626C594380
	static void _0x1F9FB66F3A3842D2(Vehicle vehicle, BOOL p1) { invoke<Void>(0x1F9FB66F3A3842D2, vehicle, p1); } // 0x1F9FB66F3A3842D2
	static void _0x206BC5DC9D1AC70A(Vehicle vehicle, BOOL p1) { invoke<Void>(0x206BC5DC9D1AC70A, vehicle, p1); } // 0x206BC5DC9D1AC70A
	static void _0x21115BCD6E44656A(Any p0, BOOL p1) { invoke<Void>(0x21115BCD6E44656A, p0, p1); } // 0x21115BCD6E44656A
	static void _0x21973BBF8D17EDFA(Any p0, Any p1) { invoke<Void>(0x21973BBF8D17EDFA, p0, p1); } // 0x21973BBF8D17EDFA
	static void _0x2311DD7159F00582(Vehicle vehicle, BOOL p1) { invoke<Void>(0x2311DD7159F00582, vehicle, p1); } // 0x2311DD7159F00582
	static Any _0x2467A2D807D37CA3(Any p0) { return invoke<Any>(0x2467A2D807D37CA3, p0); } // 0x2467A2D807D37CA3
	static void _0x25367DE49D64CF16(Vehicle vehicle, BOOL p1) { invoke<Void>(0x25367DE49D64CF16, vehicle, p1); } // 0x25367DE49D64CF16
	static void _0x26D99D5A82FD18E8(Any p0) { invoke<Void>(0x26D99D5A82FD18E8, p0); } // 0x26D99D5A82FD18E8
	static void _0x279D50DE5652D935(Any p0, BOOL p1) { invoke<Void>(0x279D50DE5652D935, p0, p1); } // 0x279D50DE5652D935
	static BOOL _0x27B926779DEB502D(Vehicle vehicle, BOOL frontBumper) { return invoke<BOOL>(0x27B926779DEB502D, vehicle, frontBumper); } // 0x27B926779DEB502D
	static void _0x28B18377EB6E25F6(Any p0, Any p1) { invoke<Void>(0x28B18377EB6E25F6, p0, p1); } // 0x28B18377EB6E25F6
	static void _0x2A86A0475B6A1434(Any p0, Any p1) { invoke<Void>(0x2A86A0475B6A1434, p0, p1); } // 0x2A86A0475B6A1434
	static void _0x2A8F319B392E7B3F(Vehicle vehicle, float p1) { invoke<Void>(0x2A8F319B392E7B3F, vehicle, p1); } // 0x2A8F319B392E7B3F
	static Any _0x2B6747FAA9DB9D6B(Vehicle vehicle, BOOL p1) { return invoke<Any>(0x2B6747FAA9DB9D6B, vehicle, p1); } // 0x2B6747FAA9DB9D6B
	static Any _0x2C1D8B3B19E517CC(Any p0, Any p1) { return invoke<Any>(0x2C1D8B3B19E517CC, p0, p1); } // 0x2C1D8B3B19E517CC
	static void _0x2C4A1590ABF43E8B(Vehicle vehicle, BOOL p1) { invoke<Void>(0x2C4A1590ABF43E8B, vehicle, p1); } // 0x2C4A1590ABF43E8B
	static Any _0x2C8CBFE1EA5FC631(Any p0) { return invoke<Any>(0x2C8CBFE1EA5FC631, p0); } // 0x2C8CBFE1EA5FC631
	static void _0x2FA2494B47FDD009(Any p0, Any p1) { invoke<Void>(0x2FA2494B47FDD009, p0, p1); } // 0x2FA2494B47FDD009
	static void _0x32CAEDF24A583345(Any p0) { invoke<Void>(0x32CAEDF24A583345, p0); } // 0x32CAEDF24A583345
	static void _0x33506883545AC0DF(Vehicle vehicle, BOOL p1) { invoke<Void>(0x33506883545AC0DF, vehicle, p1); } // 0x33506883545AC0DF
	static void _0x3441CAD2F2231923(Vehicle vehicle, BOOL p1) { invoke<Void>(0x3441CAD2F2231923, vehicle, p1); } // 0x3441CAD2F2231923
	static void _0x35BB21DE06784373(Any p0, Any p1) { invoke<Void>(0x35BB21DE06784373, p0, p1); } // 0x35BB21DE06784373
	static void _0x35E0654F4BAD7971(BOOL p0) { invoke<Void>(0x35E0654F4BAD7971, p0); } // 0x35E0654F4BAD7971
	static Any _0x36492C2F0D134C56(Any p0) { return invoke<Any>(0x36492C2F0D134C56, p0); } // 0x36492C2F0D134C56
	static void _0x374706271354CB18(Vehicle vehicle, Entity p1, float p2) { invoke<Void>(0x374706271354CB18, vehicle, p1, p2); } // 0x374706271354CB18
	static void _0x3B458DDB57038F08(Any p0, Any p1, Any p2) { invoke<Void>(0x3B458DDB57038F08, p0, p1, p2); } // 0x3B458DDB57038F08
	static Any _0x3DE51E9C80B116CF(Any p0) { return invoke<Any>(0x3DE51E9C80B116CF, p0); } // 0x3DE51E9C80B116CF
	static void _0x4056EA1105F5ABD7(Any p0, Any p1) { invoke<Void>(0x4056EA1105F5ABD7, p0, p1); } // 0x4056EA1105F5ABD7
	static void _0x41290B40FA63E6DA(Any p0) { invoke<Void>(0x41290B40FA63E6DA, p0); } // 0x41290B40FA63E6DA
	static void _0x428AD3E26C8D9EB0(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0x428AD3E26C8D9EB0, p0, p1, p2, p3, p4); } // 0x428AD3E26C8D9EB0
	static void _0x428BACCDF5E26EAD(Vehicle vehicle, BOOL p1) { invoke<Void>(0x428BACCDF5E26EAD, vehicle, p1); } // 0x428BACCDF5E26EAD
	static Any _0x42A4BEB35D372407(Any p0) { return invoke<Any>(0x42A4BEB35D372407, p0); } // 0x42A4BEB35D372407
	static void _0x4419966C9936071A(Any p0) { invoke<Void>(0x4419966C9936071A, p0); } // 0x4419966C9936071A
	static void _0x44CD1F493DB2A0A6(Any p0, Any p1, Any p2) { invoke<Void>(0x44CD1F493DB2A0A6, p0, p1, p2); } // 0x44CD1F493DB2A0A6
	static Any _0x45A561A9421AB6AD(Any p0, Any p1) { return invoke<Any>(0x45A561A9421AB6AD, p0, p1); } // 0x45A561A9421AB6AD
	static void _0x48ADC8A773564670() { invoke<Void>(0x48ADC8A773564670); } // 0x48ADC8A773564670
	static Any _0x48C633E94A8142A7(Any p0) { return invoke<Any>(0x48C633E94A8142A7, p0); } // 0x48C633E94A8142A7
	static Any _0x4C815EB175086F84(Any p0, Any p1) { return invoke<Any>(0x4C815EB175086F84, p0, p1); } // 0x4C815EB175086F84
	static void _0x4D9D109F63FEE1D4(Any p0, BOOL p1) { invoke<Void>(0x4D9D109F63FEE1D4, p0, p1); } // 0x4D9D109F63FEE1D4
	static Any _0x4E20D2A627011E8E(Any p0, Any p1) { return invoke<Any>(0x4E20D2A627011E8E, p0, p1); } // 0x4E20D2A627011E8E
	static Any _0x4E417C547182C84D(Any p0) { return invoke<Any>(0x4E417C547182C84D, p0); } // 0x4E417C547182C84D
	static void _0x4E74E62E0A97E901(Vehicle vehicle, BOOL p1) { invoke<Void>(0x4E74E62E0A97E901, vehicle, p1); } // 0x4E74E62E0A97E901
	static void _0x500873A45724C863(Vehicle vehicle, Any p1) { invoke<Void>(0x500873A45724C863, vehicle, p1); } // 0x500873A45724C863
	static Any _0x50634E348C8D44EF(Any p0) { return invoke<Any>(0x50634E348C8D44EF, p0); } // 0x50634E348C8D44EF
	static void _0x51BB2D88D31A914B(Vehicle vehicle, BOOL p1) { invoke<Void>(0x51BB2D88D31A914B, vehicle, p1); } // 0x51BB2D88D31A914B
	static void _0x51DB102F4A3BA5E0(BOOL p0) { invoke<Void>(0x51DB102F4A3BA5E0, p0); } // 0x51DB102F4A3BA5E0
	static void _0x5335BE58C083E74E(Any p0) { invoke<Void>(0x5335BE58C083E74E, p0); } // 0x5335BE58C083E74E
	static void _0x544996C0081ABDEB(Any p0, Any p1) { invoke<Void>(0x544996C0081ABDEB, p0, p1); } // 0x544996C0081ABDEB
	static Any _0x54B0F614960F4A5F(float p0, float p1, float p2, float p3, float p4, float p5, float p6) { return invoke<Any>(0x54B0F614960F4A5F, p0, p1, p2, p3, p4, p5, p6); } // 0x54B0F614960F4A5F
	static Any _0x563B65A643ED072E(Any p0, Any p1, Any p2) { return invoke<Any>(0x563B65A643ED072E, p0, p1, p2); } // 0x563B65A643ED072E
	static void _0x56B94C6D7127DFBA(Any p0, float p1, BOOL p2) { invoke<Void>(0x56B94C6D7127DFBA, p0, p1, p2); } // 0x56B94C6D7127DFBA
	static void _0x56EB5E94318D3FB6(Vehicle vehicle, BOOL p1) { invoke<Void>(0x56EB5E94318D3FB6, vehicle, p1); } // 0x56EB5E94318D3FB6
	static void _0x571FEB383F629926(Vehicle cargobob, BOOL p1) { invoke<Void>(0x571FEB383F629926, cargobob, p1); } // 0x571FEB383F629926
	static void _0x5845066D8A1EA7F7(Vehicle vehicle, float x, float y, float z, Any p4) { invoke<Void>(0x5845066D8A1EA7F7, vehicle, x, y, z, p4); } // 0x5845066D8A1EA7F7
	static Any _0x5873C14A52D74236(Any p0) { return invoke<Any>(0x5873C14A52D74236, p0); } // 0x5873C14A52D74236
	static void _0x5B91B229243351A8(Any p0, Any p1) { invoke<Void>(0x5B91B229243351A8, p0, p1); } // 0x5B91B229243351A8
	static Any _0x5BA68A0840D546AC(Any p0, Any p1) { return invoke<Any>(0x5BA68A0840D546AC, p0, p1); } // 0x5BA68A0840D546AC
	static void _0x5E569EC46EC21CAE(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x5E569EC46EC21CAE, vehicle, toggle); } // 0x5E569EC46EC21CAE
	static Any _0x5ECB40269053C0D4(Any p0) { return invoke<Any>(0x5ECB40269053C0D4, p0); } // 0x5ECB40269053C0D4
	static void _0x5EE5632F47AE9695(Any p0, Any p1) { invoke<Void>(0x5EE5632F47AE9695, p0, p1); } // 0x5EE5632F47AE9695
	static Any _0x60190048C0764A26(Any p0) { return invoke<Any>(0x60190048C0764A26, p0); } // 0x60190048C0764A26
	static BOOL _0x62CA17B74C435651(Vehicle vehicle) { return invoke<BOOL>(0x62CA17B74C435651, vehicle); } // 0x62CA17B74C435651
	static BOOL _0x634148744F385576(Vehicle vehicle) { return invoke<BOOL>(0x634148744F385576, vehicle); } // 0x634148744F385576
	static BOOL _0x639431E895B9AA57(Ped ped, Vehicle vehicle, BOOL p2, BOOL p3, BOOL p4) { return invoke<BOOL>(0x639431E895B9AA57, ped, vehicle, p2, p3, p4); } // 0x639431E895B9AA57
	static void _0x6501129C9E0FFA05(Any p0, Any p1) { invoke<Void>(0x6501129C9E0FFA05, p0, p1); } // 0x6501129C9E0FFA05
	static void _0x65B080555EA48149(Any p0) { invoke<Void>(0x65B080555EA48149, p0); } // 0x65B080555EA48149
	static float _0x6636C535F6CC2725(Vehicle vehicle) { return invoke<float>(0x6636C535F6CC2725, vehicle); } // 0x6636C535F6CC2725
	static void _0x66979ACF5102FD2F(Vehicle cargobob, float p1) { invoke<Void>(0x66979ACF5102FD2F, cargobob, p1); } // 0x66979ACF5102FD2F
	static void _0x66E3AAFACE2D1EB8(Any p0, Any p1, Any p2) { invoke<Void>(0x66E3AAFACE2D1EB8, p0, p1, p2); } // 0x66E3AAFACE2D1EB8
	static void _0x685D5561680D088B(Vehicle vehicle, float p1) { invoke<Void>(0x685D5561680D088B, vehicle, p1); } // 0x685D5561680D088B
	static void _0x6A98C2ECF57FA5D4(Vehicle vehicle, Entity entity) { invoke<Void>(0x6A98C2ECF57FA5D4, vehicle, entity); } // 0x6A98C2ECF57FA5D4
	static Any _0x6ADAABD3068C5235() { return invoke<Any>(0x6ADAABD3068C5235); } // 0x6ADAABD3068C5235
	static void _0x6D6AF961B72728AE(Vehicle vehicle) { invoke<Void>(0x6D6AF961B72728AE, vehicle); } // 0x6D6AF961B72728AE
	static void _0x6D8EAC07506291FB(Vehicle cargobob, float p1) { invoke<Void>(0x6D8EAC07506291FB, cargobob, p1); } // 0x6D8EAC07506291FB
	static Any _0x6EAAEFC76ACC311F(Any p0) { return invoke<Any>(0x6EAAEFC76ACC311F, p0); } // 0x6EAAEFC76ACC311F
	static void _0x6EBFB22D646FFC18(Vehicle vehicle, BOOL p1) { invoke<Void>(0x6EBFB22D646FFC18, vehicle, p1); } // 0x6EBFB22D646FFC18
	static Any _0x725012A415DBA050(Any p0, Any* p1, Any p2) { return invoke<Any>(0x725012A415DBA050, p0, p1, p2); } // 0x725012A415DBA050
	static void _0x72BECCF4B829522E(Any p0, Any p1) { invoke<Void>(0x72BECCF4B829522E, p0, p1); } // 0x72BECCF4B829522E
	static void _0x73561D4425A021A2(Any p0, Any p1) { invoke<Void>(0x73561D4425A021A2, p0, p1); } // 0x73561D4425A021A2
	static void _0x737E398138550FFF(Any p0, Any p1) { invoke<Void>(0x737E398138550FFF, p0, p1); } // 0x737E398138550FFF
	static void _0x756AE6E962168A04(Any p0, Any p1) { invoke<Void>(0x756AE6E962168A04, p0, p1); } // 0x756AE6E962168A04
	static void _0x76D26A22750E849E(Any p0) { invoke<Void>(0x76D26A22750E849E, p0); } // 0x76D26A22750E849E
	static void _0x78CEEE41F49F421F(Any p0, Any p1) { invoke<Void>(0x78CEEE41F49F421F, p0, p1); } // 0x78CEEE41F49F421F
	static void _0x796A877E459B99EA(Any p0, float p1, float p2, float p3) { invoke<Void>(0x796A877E459B99EA, p0, p1, p2, p3); } // 0x796A877E459B99EA
	static void _0x79DF7E806202CE01(Any p0, Any p1) { invoke<Void>(0x79DF7E806202CE01, p0, p1); } // 0x79DF7E806202CE01
	static void _0x7BBE7FF626A591FE(Any p0) { invoke<Void>(0x7BBE7FF626A591FE, p0); } // 0x7BBE7FF626A591FE
	static void _0x7C0043FDFF6436BC(Vehicle x) { invoke<Void>(0x7C0043FDFF6436BC, x); } // 0x7C0043FDFF6436BC
	static void _0x7C06330BFDDA182E(Any p0) { invoke<Void>(0x7C06330BFDDA182E, p0); } // 0x7C06330BFDDA182E
	static void _0x7D6F9A3EF26136A0(Vehicle vehicle, BOOL p1, BOOL p2) { invoke<Void>(0x7D6F9A3EF26136A0, vehicle, p1, p2); } // 0x7D6F9A3EF26136A0
	static void _0x80E3357FDEF45C21(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x80E3357FDEF45C21, vehicle, toggle); } // 0x80E3357FDEF45C21
	static Any _0x8181CE2F25CB9BB7(Any p0, Any p1) { return invoke<Any>(0x8181CE2F25CB9BB7, p0, p1); } // 0x8181CE2F25CB9BB7
	static void _0x84EA99C62CB3EF0C(Any p0, Any p1, Any p2) { invoke<Void>(0x84EA99C62CB3EF0C, p0, p1, p2); } // 0x84EA99C62CB3EF0C
	static Any _0x8533CAFDE1F0F336(Any p0) { return invoke<Any>(0x8533CAFDE1F0F336, p0); } // 0x8533CAFDE1F0F336
	static void _0x86B4B6212CB8B627(Any p0, Any p1) { invoke<Void>(0x86B4B6212CB8B627, p0, p1); } // 0x86B4B6212CB8B627
	static void _0x870B8B7A766615C8(Any p0, Any p1, Any p2) { invoke<Void>(0x870B8B7A766615C8, p0, p1, p2); } // 0x870B8B7A766615C8
	static void _0x878C75C09FBDB942(Any p0) { invoke<Void>(0x878C75C09FBDB942, p0); } // 0x878C75C09FBDB942
	static void _0x88BC673CA9E0AE99(Vehicle vehicle, BOOL p1) { invoke<Void>(0x88BC673CA9E0AE99, vehicle, p1); } // 0x88BC673CA9E0AE99
	static BOOL _0x89D630CF5EA96D23(Vehicle vehicle, Entity entity) { return invoke<BOOL>(0x89D630CF5EA96D23, vehicle, entity); } // 0x89D630CF5EA96D23
	static void _0x8AA9180DE2FEDD45(Vehicle vehicle, BOOL p1) { invoke<Void>(0x8AA9180DE2FEDD45, vehicle, p1); } // 0x8AA9180DE2FEDD45
	static void _0x8EA86DF356801C7D(Any p0, Any p1) { invoke<Void>(0x8EA86DF356801C7D, p0, p1); } // 0x8EA86DF356801C7D
	static void _0x8F719973E1445BA2(Vehicle vehicle, Vehicle p1) { invoke<Void>(0x8F719973E1445BA2, vehicle, p1); } // 0x8F719973E1445BA2
	static void _0x9007A2F21DC108D4(Any p0, float p1) { invoke<Void>(0x9007A2F21DC108D4, p0, p1); } // 0x9007A2F21DC108D4
	static void _0x91A0BD635321F145(Vehicle vehicle, BOOL p1) { invoke<Void>(0x91A0BD635321F145, vehicle, p1); } // 0x91A0BD635321F145
	static BOOL _0x91D6DD290888CBAB() { return invoke<BOOL>(0x91D6DD290888CBAB); } // 0x91D6DD290888CBAB
	static int _0x92523B76657A517D(Any p0, float p1) { return invoke<int>(0x92523B76657A517D, p0, p1); } // 0x92523B76657A517D
	static void _0x95CF53B3D687F9FA(Vehicle vehicle) { invoke<Void>(0x95CF53B3D687F9FA, vehicle); } // 0x95CF53B3D687F9FA
	static void _0x9737A37136F07E75(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x9737A37136F07E75, vehicle, toggle); } // 0x9737A37136F07E75
	static Any _0x99093F60746708CA(Any p0) { return invoke<Any>(0x99093F60746708CA, p0); } // 0x99093F60746708CA
	static void _0x99AD4CCCB128CBC9(Vehicle vehicle) { invoke<Void>(0x99AD4CCCB128CBC9, vehicle); } // 0x99AD4CCCB128CBC9
	static void _0x99CAD8E7AFDB60FA(Vehicle vehicle, float p1, float p2) { invoke<Void>(0x99CAD8E7AFDB60FA, vehicle, p1, p2); } // 0x99CAD8E7AFDB60FA
	static void _0x9A75585FB2E54FAD(float p0, float p1, float p2, float p3) { invoke<Void>(0x9A75585FB2E54FAD, p0, p1, p2, p3); } // 0x9A75585FB2E54FAD
	static void _0x9BDDC73CC6A115D4(Vehicle vehicle, BOOL p1, BOOL p2) { invoke<Void>(0x9BDDC73CC6A115D4, vehicle, p1, p2); } // 0x9BDDC73CC6A115D4
	static void _0x9BECD4B9FEF3F8A6(Vehicle vehicle, BOOL p1) { invoke<Void>(0x9BECD4B9FEF3F8A6, vehicle, p1); } // 0x9BECD4B9FEF3F8A6
	static void _0x9D30687C57BAA0BB(Any p0) { invoke<Void>(0x9D30687C57BAA0BB, p0); } // 0x9D30687C57BAA0BB
	static void _0x9F3F689B814F2599(Vehicle vehicle, BOOL p1) { invoke<Void>(0x9F3F689B814F2599, vehicle, p1); } // 0x9F3F689B814F2599
	static Any _0xA01BC64DD4BFBBAC(Vehicle vehicle, int p1) { return invoke<Any>(0xA01BC64DD4BFBBAC, vehicle, p1); } // 0xA01BC64DD4BFBBAC
	static void _0xA17BAD153B51547E(Vehicle cargobob, float p1) { invoke<Void>(0xA17BAD153B51547E, cargobob, p1); } // 0xA17BAD153B51547E
	static Any _0xA1A9FC1C76A6730D(Any p0) { return invoke<Any>(0xA1A9FC1C76A6730D, p0); } // 0xA1A9FC1C76A6730D
	static void _0xA1DD82F3CCF9A01E(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { invoke<Void>(0xA1DD82F3CCF9A01E, p0, p1, p2, p3, p4, p5); } // 0xA1DD82F3CCF9A01E
	static void _0xA247F9EF01D8082E(Any p0) { invoke<Void>(0xA247F9EF01D8082E, p0); } // 0xA247F9EF01D8082E
	static BOOL _0xA4822F1CF23F4810(Vector3* outVec, Any p1, Vector3* outVec1, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { return invoke<BOOL>(0xA4822F1CF23F4810, outVec, p1, outVec1, p3, p4, p5, p6, p7, p8); } // 0xA4822F1CF23F4810
	static void _0xA7DCDF4DED40A8F4(Vehicle vehicle, BOOL p1) { invoke<Void>(0xA7DCDF4DED40A8F4, vehicle, p1); } // 0xA7DCDF4DED40A8F4
	static void _0xAA3F739ABDDCF21F() { invoke<Void>(0xAA3F739ABDDCF21F); } // 0xAA3F739ABDDCF21F
	static void _0xAB04325045427AAE(Vehicle vehicle, BOOL p1) { invoke<Void>(0xAB04325045427AAE, vehicle, p1); } // 0xAB04325045427AAE
	static void _0xAB31EF4DE6800CE9(Any p0, Any p1) { invoke<Void>(0xAB31EF4DE6800CE9, p0, p1); } // 0xAB31EF4DE6800CE9
	static BOOL _0xAE3FEE8709B39DCB(Vehicle vehicle) { return invoke<BOOL>(0xAE3FEE8709B39DCB, vehicle); } // 0xAE3FEE8709B39DCB
	static Any _0xAF03011701811146(Any p0, Any p1) { return invoke<Any>(0xAF03011701811146, p0, p1); } // 0xAF03011701811146
	static void _0xAF60E6A2936F982A(Any p0, Any p1) { invoke<Void>(0xAF60E6A2936F982A, p0, p1); } // 0xAF60E6A2936F982A
	static void _0xB055A34527CB8FD7(Vehicle vehicle, BOOL p1) { invoke<Void>(0xB055A34527CB8FD7, vehicle, p1); } // 0xB055A34527CB8FD7
	static void _0xB088E9A47AE6EDD5(Vehicle vehicle, BOOL p1) { invoke<Void>(0xB088E9A47AE6EDD5, vehicle, p1); } // 0xB088E9A47AE6EDD5
	static Any _0xB09D25E77C33EB3F(Any p0, Any p1, Any p2) { return invoke<Any>(0xB09D25E77C33EB3F, p0, p1, p2); } // 0xB09D25E77C33EB3F
	static Any _0xB0AD1238A709B1A2(Any p0) { return invoke<Any>(0xB0AD1238A709B1A2, p0); } // 0xB0AD1238A709B1A2
	static void _0xB264C4D2F2B0A78B(Vehicle vehicle) { invoke<Void>(0xB264C4D2F2B0A78B, vehicle); } // 0xB264C4D2F2B0A78B
	static void _0xB28B1FE5BFADD7F5(Vehicle vehicle, BOOL p1) { invoke<Void>(0xB28B1FE5BFADD7F5, vehicle, p1); } // 0xB28B1FE5BFADD7F5
	static void _0xB2E0C0D6922D31F2(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xB2E0C0D6922D31F2, vehicle, toggle); } // 0xB2E0C0D6922D31F2
	static void _0xB9562064627FF9DB(Any p0, Any p1) { invoke<Void>(0xB9562064627FF9DB, p0, p1); } // 0xB9562064627FF9DB
	static Any _0xBA91D045575699AD(Any p0) { return invoke<Any>(0xBA91D045575699AD, p0); } // 0xBA91D045575699AD
	static void _0xBAA045B4E42F3C06(Any p0, Any p1) { invoke<Void>(0xBAA045B4E42F3C06, p0, p1); } // 0xBAA045B4E42F3C06
	static void _0xBB2333BB87DDD87F(Any p0, Any p1) { invoke<Void>(0xBB2333BB87DDD87F, p0, p1); } // 0xBB2333BB87DDD87F
	static void _0xBC3CCA5844452B06(float p0) { invoke<Void>(0xBC3CCA5844452B06, p0); } // 0xBC3CCA5844452B06
	static void _0xBD32E46AA95C1DD2(Any p0) { invoke<Void>(0xBD32E46AA95C1DD2, p0); } // 0xBD32E46AA95C1DD2
	static void _0xBE5C1255A1830FF5(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xBE5C1255A1830FF5, vehicle, toggle); } // 0xBE5C1255A1830FF5
	static void _0xC0ED6438E6D39BA8(Any p0, Any p1, Any p2) { invoke<Void>(0xC0ED6438E6D39BA8, p0, p1, p2); } // 0xC0ED6438E6D39BA8
	static void _0xC1F981A6F74F0C23(Any p0, BOOL p1) { invoke<Void>(0xC1F981A6F74F0C23, p0, p1); } // 0xC1F981A6F74F0C23
	static void _0xC24075310A8B9CD1(Any p0, Any p1, Any p2, Any p3, Any p4) { invoke<Void>(0xC24075310A8B9CD1, p0, p1, p2, p3, p4); } // 0xC24075310A8B9CD1
	static void _0xC361AA040D6637A8(Vehicle vehicle, BOOL p1) { invoke<Void>(0xC361AA040D6637A8, vehicle, p1); } // 0xC361AA040D6637A8
	static void _0xC45C27EF50F36ADC(Vehicle vehicle, BOOL p1) { invoke<Void>(0xC45C27EF50F36ADC, vehicle, p1); } // 0xC45C27EF50F36ADC
	static void _0xC4B3347BD68BD609(Any p0) { invoke<Void>(0xC4B3347BD68BD609, p0); } // 0xC4B3347BD68BD609
	static void _0xC50CE861B55EAB8B(Vehicle vehicle, BOOL p1) { invoke<Void>(0xC50CE861B55EAB8B, vehicle, p1); } // 0xC50CE861B55EAB8B
	static Any _0xCA4AC3EAAE46EC7B(Any p0, Any p1) { return invoke<Any>(0xCA4AC3EAAE46EC7B, p0, p1); } // 0xCA4AC3EAAE46EC7B
	static void _0xCAC66558B944DA67(char* vehicle, BOOL p1) { invoke<Void>(0xCAC66558B944DA67, vehicle, p1); } // 0xCAC66558B944DA67
	static void _0xCF1182F682F65307(Any p0, Player p1) { invoke<Void>(0xCF1182F682F65307, p0, p1); } // 0xCF1182F682F65307
	static void _0xCF9159024555488C(Any p0) { invoke<Void>(0xCF9159024555488C, p0); } // 0xCF9159024555488C
	static void _0xCFD778E7904C255E(Vehicle vehicle) { invoke<Void>(0xCFD778E7904C255E, vehicle); } // 0xCFD778E7904C255E
	static void _0xD3301660A57C9272(Any p0) { invoke<Void>(0xD3301660A57C9272, p0); } // 0xD3301660A57C9272
	static Any _0xD3E51C0AB8C26EEE(Any p0, Any p1) { return invoke<Any>(0xD3E51C0AB8C26EEE, p0, p1); } // 0xD3E51C0AB8C26EEE
	static Any _0xD4196117AF7BB974(Any p0, Any p1) { return invoke<Any>(0xD4196117AF7BB974, p0, p1); } // 0xD4196117AF7BB974
	static BOOL _0xD4C4642CB7F50B5D(Vehicle vehicle) { return invoke<BOOL>(0xD4C4642CB7F50B5D, vehicle); } // 0xD4C4642CB7F50B5D
	static void _0xD565F438137F0E10(Any p0, Any p1) { invoke<Void>(0xD565F438137F0E10, p0, p1); } // 0xD565F438137F0E10
	static void _0xDBA3C090E3D74690(Vehicle vehicle) { invoke<Void>(0xDBA3C090E3D74690, vehicle); } // 0xDBA3C090E3D74690
	static void _0xDBC631F109350B8C(Vehicle vehicle, BOOL p1) { invoke<Void>(0xDBC631F109350B8C, vehicle, p1); } // 0xDBC631F109350B8C
	static Any _0xDCE97BDF8A0EABC8() { return invoke<Any>(0xDCE97BDF8A0EABC8); } // 0xDCE97BDF8A0EABC8
	static void _0xDF7E3EEB29642C38(Vehicle vehicle, Vector3* out1, Vector3* out2) { invoke<Void>(0xDF7E3EEB29642C38, vehicle, out1, out2); } // 0xDF7E3EEB29642C38
	static void _0xDFFCEF48E511DB48(Any p0, BOOL p1) { invoke<Void>(0xDFFCEF48E511DB48, p0, p1); } // 0xDFFCEF48E511DB48
	static void _0xE01903C47C7AC89E() { invoke<Void>(0xE01903C47C7AC89E); } // 0xE01903C47C7AC89E
	static void _0xE05DD0E9707003A3(Any p0, BOOL p1) { invoke<Void>(0xE05DD0E9707003A3, p0, p1); } // 0xE05DD0E9707003A3
	static void _0xE16142B94664DEFD(Vehicle vehicle, BOOL p1) { invoke<Void>(0xE16142B94664DEFD, vehicle, p1); } // 0xE16142B94664DEFD
	static void _0xE2F53F172B45EDE1() { invoke<Void>(0xE2F53F172B45EDE1); } // 0xE2F53F172B45EDE1
	static void _0xE301BD63E9E13CF0(Vehicle vehicle, Vehicle cargobob) { invoke<Void>(0xE301BD63E9E13CF0, vehicle, cargobob); } // 0xE301BD63E9E13CF0
	static void _0xE30524E1871F481D(Any p0) { invoke<Void>(0xE30524E1871F481D, p0); } // 0xE30524E1871F481D
	static BOOL _0xE33FFA906CE74880(Vehicle vehicle, Any p1) { return invoke<BOOL>(0xE33FFA906CE74880, vehicle, p1); } // 0xE33FFA906CE74880
	static void _0xE3EBAAE484798530(Vehicle vehicle, BOOL p1) { invoke<Void>(0xE3EBAAE484798530, vehicle, p1); } // 0xE3EBAAE484798530
	static void _0xE44A982368A4AF23(Vehicle vehicle, Vehicle vehicle2) { invoke<Void>(0xE44A982368A4AF23, vehicle, vehicle2); } // 0xE44A982368A4AF23
	static void _0xE4E2FD323574965C(Any p0, Any p1) { invoke<Void>(0xE4E2FD323574965C, p0, p1); } // 0xE4E2FD323574965C
	static void _0xE5810AC70602F2F5(Vehicle vehicle, float p1) { invoke<Void>(0xE5810AC70602F2F5, vehicle, p1); } // 0xE5810AC70602F2F5
	static int _0xE6B0E8CFC3633BF0(Vehicle vehicle) { return invoke<int>(0xE6B0E8CFC3633BF0, vehicle); } // 0xE6B0E8CFC3633BF0
	static void _0xE6C0C80B8C867537(BOOL p0) { invoke<Void>(0xE6C0C80B8C867537, p0); } // 0xE6C0C80B8C867537
	static void _0xE6F13851780394DA(Vehicle vehicle, float p1) { invoke<Void>(0xE6F13851780394DA, vehicle, p1); } // 0xE6F13851780394DA
	static void _0xE842A9398079BD82(Vehicle vehicle, float p1) { invoke<Void>(0xE842A9398079BD82, vehicle, p1); } // 0xE842A9398079BD82
	static void _0xE851E480B814D4BA(Vehicle vehicle, BOOL p1) { invoke<Void>(0xE851E480B814D4BA, vehicle, p1); } // 0xE851E480B814D4BA
	static void _0xED5EDE9E676643C9(Any p0, Any p1) { invoke<Void>(0xED5EDE9E676643C9, p0, p1); } // 0xED5EDE9E676643C9
	static void _0xED8286F71A819BAA(Vehicle cargobob, float p1) { invoke<Void>(0xED8286F71A819BAA, cargobob, p1); } // 0xED8286F71A819BAA
	static void _0xEDBC8405B3895CC9(Any p0, Any p1) { invoke<Void>(0xEDBC8405B3895CC9, p0, p1); } // 0xEDBC8405B3895CC9
	static int _0xEEBFC7A7EFDC35B4(Vehicle vehicle) { return invoke<int>(0xEEBFC7A7EFDC35B4, vehicle); } // 0xEEBFC7A7EFDC35B4
	static void _0xEFC13B1CE30D755D(Any p0, Any p1) { invoke<Void>(0xEFC13B1CE30D755D, p0, p1); } // 0xEFC13B1CE30D755D
	static void _0xF051D9BFB6BA39C0(Any p0) { invoke<Void>(0xF051D9BFB6BA39C0, p0); } // 0xF051D9BFB6BA39C0
	static void _0xF06A16CA55D138D8(Any p0, Any p1) { invoke<Void>(0xF06A16CA55D138D8, p0, p1); } // 0xF06A16CA55D138D8
	static void _0xF0E4BA16D1DB546C(Vehicle vehicle, int p1, int p2) { invoke<Void>(0xF0E4BA16D1DB546C, vehicle, p1, p2); } // 0xF0E4BA16D1DB546C
	static Vector3 _0xF0F2103EFAF8CBA7(Any p0, float p1) { return invoke<Vector3>(0xF0F2103EFAF8CBA7, p0, p1); } // 0xF0F2103EFAF8CBA7
	static void _0xF25E02CB9C5818F8() { invoke<Void>(0xF25E02CB9C5818F8); } // 0xF25E02CB9C5818F8
	static Any _0xF3B0E0AED097A3F5(Any p0, Any p1) { return invoke<Any>(0xF3B0E0AED097A3F5, p0, p1); } // 0xF3B0E0AED097A3F5
	static void _0xF488C566413B4232(Any p0, float p1) { invoke<Void>(0xF488C566413B4232, p0, p1); } // 0xF488C566413B4232
	static BOOL _0xF78F94D60248C737(Any p0, BOOL p1) { return invoke<BOOL>(0xF78F94D60248C737, p0, p1); } // 0xF78F94D60248C737
	static BOOL _0xF7F203E31F96F6A1(Vehicle vehicle, BOOL flag) { return invoke<BOOL>(0xF7F203E31F96F6A1, vehicle, flag); } // 0xF7F203E31F96F6A1
	static void _0xF87D9F2301F7D206(Any p0) { invoke<Void>(0xF87D9F2301F7D206, p0); } // 0xF87D9F2301F7D206
	static void _0xF8EBCCC96ADB9FB7(Any p0, float p1, BOOL p2) { invoke<Void>(0xF8EBCCC96ADB9FB7, p0, p1, p2); } // 0xF8EBCCC96ADB9FB7
	static void _0xFAF2A78061FD9EF4(Any p0, float p1, float p2, float p3) { invoke<Void>(0xFAF2A78061FD9EF4, p0, p1, p2, p3); } // 0xFAF2A78061FD9EF4
	static void _0xFC40CBF7B90CA77C(Vehicle vehicle) { invoke<Void>(0xFC40CBF7B90CA77C, vehicle); } // 0xFC40CBF7B90CA77C
	static void _0xFE205F38AAA58E5B(Any p0, Any p1) { invoke<Void>(0xFE205F38AAA58E5B, p0, p1); } // 0xFE205F38AAA58E5B
	static void OPEN_BOMB_BAY_DOORS(Vehicle vehicle) { invoke<Void>(0x87E7F24270732CB1, vehicle); } // 0x87E7F24270732CB1
	static void PAUSE_PLAYBACK_RECORDED_VEHICLE(Any p0) { invoke<Void>(0x632A689BF42301B1, p0); } // 0x632A689BF42301B1
	static void PRELOAD_VEHICLE_MOD(Any p0, int modType, Any p2) { invoke<Void>(0x758F49C24925568A, p0, modType, p2); } // 0x758F49C24925568A
	static void RAISE_CONVERTIBLE_ROOF(Vehicle vehicle, BOOL instantlyRaise) { invoke<Void>(0x8F5FB35D7E88FC70, vehicle, instantlyRaise); } // 0x8F5FB35D7E88FC70
	static void _RAISE_LOWERABLE_WHEELS(Vehicle vehicle) { invoke<Void>(0xF660602546D27BA8, vehicle); } // 0xF660602546D27BA8
	static void RELEASE_PRELOAD_MODS(Vehicle vehicle) { invoke<Void>(0x445D79F995508307, vehicle); } // 0x445D79F995508307
	static void REMOVE_PICK_UP_ROPE_FOR_CARGOBOB(Vehicle cargobob) { invoke<Void>(0x9768CF648F54C804, cargobob); } // 0x9768CF648F54C804
	static BOOL _REMOVE_SPEED_ZONE(int speedzone) { return invoke<BOOL>(0x1033371FC8E842A7, speedzone); } // 0x1033371FC8E842A7
	static void REMOVE_VEHICLE_ASSET(int vehicleAsset) { invoke<Void>(0xACE699C71AB9DEB5, vehicleAsset); } // 0xACE699C71AB9DEB5
	static void REMOVE_VEHICLE_HIGH_DETAIL_MODEL(Vehicle vehicle) { invoke<Void>(0x689CDE5F7C6787, vehicle); } // 0x689CDE5F7C6787
	static void REMOVE_VEHICLE_MOD(Vehicle vehicle, int modType) { invoke<Void>(0x92D619E420858204, vehicle, modType); } // 0x92D619E420858204
	static void REMOVE_VEHICLE_RECORDING(Any p0, Any* p1) { invoke<Void>(0xF1160ACCF98A3FC8, p0, p1); } // 0xF1160ACCF98A3FC8
	static void REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, Any unk) { invoke<Void>(0x46A1E1A299EC4BBA, x1, y1, z1, x2, y2, z2, unk); } // 0x46A1E1A299EC4BBA
	static void REMOVE_VEHICLE_STUCK_CHECK(Vehicle vehicle) { invoke<Void>(0x8386BFB614D06749, vehicle); } // 0x8386BFB614D06749
	static void REMOVE_VEHICLE_UPSIDEDOWN_CHECK(Vehicle vehicle) { invoke<Void>(0xC53EB42A499A7E90, vehicle); } // 0xC53EB42A499A7E90
	static void REMOVE_VEHICLE_WINDOW(Vehicle vehicle, int windowIndex) { invoke<Void>(0xA711568EEDB43069, vehicle, windowIndex); } // 0xA711568EEDB43069
	static void REQUEST_VEHICLE_ASSET(Hash vehicleHash, int vehicleAsset) { invoke<Void>(0x81A15811460FAB3A, vehicleHash, vehicleAsset); } // 0x81A15811460FAB3A
	static void REQUEST_VEHICLE_HIGH_DETAIL_MODEL(Vehicle vehicle) { invoke<Void>(0xA6E9FDCB2C76785E, vehicle); } // 0xA6E9FDCB2C76785E
	static void _REQUEST_VEHICLE_PHONE_EXPLOSION() { invoke<Void>(0xEF49CF0270307CBE); } // 0xEF49CF0270307CBE
	static void REQUEST_VEHICLE_RECORDING(int i, char* name) { invoke<Void>(0xAF514CABE74CBF15, i, name); } // 0xAF514CABE74CBF15
	static void RESET_VEHICLE_STUCK_TIMER(Vehicle vehicle, int nullAttributes) { invoke<Void>(0xD7591B0065AFAA7A, vehicle, nullAttributes); } // 0xD7591B0065AFAA7A
	static void RESET_VEHICLE_WHEELS(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x21D2E5662C1F6FED, vehicle, toggle); } // 0x21D2E5662C1F6FED
	static Any ROLL_DOWN_WINDOW(Vehicle vehicle, int windowIndex) { return invoke<Any>(0x7AD9E6CE657D69E3, vehicle, windowIndex); } // 0x7AD9E6CE657D69E3
	static void ROLL_DOWN_WINDOWS(Vehicle vehicle) { invoke<Void>(0x85796B0549DDE156, vehicle); } // 0x85796B0549DDE156
	static Any ROLL_UP_WINDOW(Vehicle vehicle, int windowIndex) { return invoke<Any>(0x602E548F46E24D59, vehicle, windowIndex); } // 0x602E548F46E24D59
	static void _SET_AIRCRAFT_BOMB_COUNT(Vehicle aircraft, int bombCount) { invoke<Void>(0xF4B2ED59DEB5D774, aircraft, bombCount); } // 0xF4B2ED59DEB5D774
	static void _SET_AIRCRAFT_COUNTERMEASURE_COUNT(Vehicle aircraft, int count) { invoke<Void>(0x9BDA23BF666F0855, aircraft, count); } // 0x9BDA23BF666F0855
	static void SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE(BOOL active) { invoke<Void>(0x608207E7A8FB787C, active); } // 0x608207E7A8FB787C
	static void SET_ALL_VEHICLE_GENERATORS_ACTIVE() { invoke<Void>(0x34AD89078831A4BC); } // 0x34AD89078831A4BC
	static void SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL p6, BOOL p7) { invoke<Void>(0xC12321827687FE4D, x1, y1, z1, x2, y2, z2, p6, p7); } // 0xC12321827687FE4D
	static Any SET_ALL_VEHICLES_SPAWN(Vehicle p0, BOOL p1, BOOL p2, BOOL p3) { return invoke<Any>(0xE023E8AC4EF7C117, p0, p1, p2, p3); } // 0xE023E8AC4EF7C117
	static void _SET_BIKE_LEAN_ANGLE(Vehicle vehicle, float x, float y) { invoke<Void>(0x9CFA4896C3A53CBB, vehicle, x, y); } // 0x9CFA4896C3A53CBB
	static void SET_BOAT_ANCHOR(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x75DBEC174AEEAD10, vehicle, toggle); } // 0x75DBEC174AEEAD10
	static void SET_CAN_RESPRAY_VEHICLE(Vehicle vehicle, BOOL state) { invoke<Void>(0x52BBA29D5EC69356, vehicle, state); } // 0x52BBA29D5EC69356
	static void _SET_CARGOBOB_HOOK_POSITION(Vehicle cargobob, float xOffset, float yOffset, int state) { invoke<Void>(0x877C1EAEAC531023, cargobob, xOffset, yOffset, state); } // 0x877C1EAEAC531023
	static void _SET_CARGOBOB_PICKUP_MAGNET_ACTIVE(Vehicle cargobob, BOOL isActive) { invoke<Void>(0x9A665550F8DA349B, cargobob, isActive); } // 0x9A665550F8DA349B
	static void _SET_CARGOBOB_PICKUP_MAGNET_STRENGTH(Vehicle cargobob, float strength) { invoke<Void>(0xBCBFCD9D1DAC19E2, cargobob, strength); } // 0xBCBFCD9D1DAC19E2
	static void _SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER(float multiplier) { invoke<Void>(0x84FD40F56075E816, multiplier); } // 0x84FD40F56075E816
	static void SET_CONVERTIBLE_ROOF(Vehicle vehicle, BOOL p1) { invoke<Void>(0xF39C4F538B5124C2, vehicle, p1); } // 0xF39C4F538B5124C2
	static void _SET_DESIRED_VERTICAL_FLIGHT_PHASE(Vehicle vehicle, float angleRatio) { invoke<Void>(0x30D779DE7C4F6DD3, vehicle, angleRatio); } // 0x30D779DE7C4F6DD3
	static void SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x37C8252A7C92D017, vehicle, toggle); } // 0x37C8252A7C92D017
	static void SET_DISABLE_VEHICLE_PETROL_TANK_FIRES(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x465BF26AB9684352, vehicle, toggle); } // 0x465BF26AB9684352
	static void SET_FAR_DRAW_VEHICLES(BOOL toggle) { invoke<Void>(0x26324F33423F3CC3, toggle); } // 0x26324F33423F3CC3
	static void SET_FORCE_HD_VEHICLE(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x97CE68CB032583F0, vehicle, toggle); } // 0x97CE68CB032583F0
	static void SET_FORKLIFT_FORK_HEIGHT(Vehicle vehicle, float height) { invoke<Void>(0x37EBBF3117BD6A25, vehicle, height); } // 0x37EBBF3117BD6A25
	static Any SET_GARBAGE_TRUCKS(BOOL toggle) { return invoke<Any>(0x2AFD795EEAC8D30D, toggle); } // 0x2AFD795EEAC8D30D
	static void SET_HELI_BLADES_FULL_SPEED(Vehicle vehicle) { invoke<Void>(0xA178472EBB8AE60D, vehicle); } // 0xA178472EBB8AE60D
	static void SET_HELI_BLADES_SPEED(Vehicle vehicle, float speed) { invoke<Void>(0xFD280B4D7F3ABC4D, vehicle, speed); } // 0xFD280B4D7F3ABC4D
	static void _SET_HELICOPTER_ROLL_PITCH_YAW_MULT(Vehicle helicopter, float multiplier) { invoke<Void>(0x6E0859B530A365CC, helicopter, multiplier); } // 0x6E0859B530A365CC
	static void SET_LAST_DRIVEN_VEHICLE(Vehicle vehicle) { invoke<Void>(0xACFB2463CC22BED2, vehicle); } // 0xACFB2463CC22BED2
	static void SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED(Vehicle* train, BOOL p1) { invoke<Void>(0xBBE7648349B49BE8, train, p1); } // 0xBBE7648349B49BE8
	static void SET_MISSION_TRAIN_COORDS(Vehicle train, float x, float y, float z) { invoke<Void>(0x591CA673AA6AB736, train, x, y, z); } // 0x591CA673AA6AB736
	static Any SET_NUMBER_OF_PARKED_VEHICLES(int value) { return invoke<Any>(0xCAA15F13EBD417FF, value); } // 0xCAA15F13EBD417FF
	static void SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { invoke<Void>(0xEAE6DCC7EEE3DB1D, multiplier); } // 0xEAE6DCC7EEE3DB1D
	static BOOL SET_PED_ENABLED_BIKE_RINGTONE(Vehicle vehicle, Entity entity) { return invoke<BOOL>(0x57715966069157AD, vehicle, entity); } // 0x57715966069157AD
	static void SET_PED_TARGETTABLE_VEHICLE_DESTROY(Vehicle vehicle, int doorIndex, int destroyType) { invoke<Void>(0xBE70724027F85BCD, vehicle, doorIndex, destroyType); } // 0xBE70724027F85BCD
	static void _SET_PLANE_MIN_HEIGHT_ABOVE_TERRAIN(Vehicle plane, int height) { invoke<Void>(0xB893215D8D4C015B, plane, height); } // 0xB893215D8D4C015B
	static void SET_PLANE_TURBULENCE_MULTIPLIER(Vehicle vehicle, float multiplier) { invoke<Void>(0xAD2D28A1AFDFF131, vehicle, multiplier); } // 0xAD2D28A1AFDFF131
	static void SET_PLAYBACK_SPEED(Vehicle vehicle, float speed) { invoke<Void>(0x6683AB880E427778, vehicle, speed); } // 0x6683AB880E427778
	static void SET_PLAYBACK_TO_USE_AI(Vehicle vehicle, int flag) { invoke<Void>(0xA549C3B37EA28131, vehicle, flag); } // 0xA549C3B37EA28131
	static void SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER(Any p0, Any p1, Any p2, BOOL p3) { invoke<Void>(0x6E63860BBB190730, p0, p1, p2, p3); } // 0x6E63860BBB190730
	static Any SET_PLAYERS_LAST_VEHICLE(Vehicle vehicle) { return invoke<Any>(0xBCDF8BAF56C87B6A, vehicle); } // 0xBCDF8BAF56C87B6A
	static void _SET_RAMP_VEHICLE_RECEIVES_RAMP_DAMAGE(Vehicle vehicle, BOOL receivesDamage) { invoke<Void>(0x28D034A93FE31BF5, vehicle, receivesDamage); } // 0x28D034A93FE31BF5
	static Any SET_RANDOM_BOATS(BOOL toggle) { return invoke<Any>(0x84436EC293B1415F, toggle); } // 0x84436EC293B1415F
	static void SET_RANDOM_TRAINS(BOOL toggle) { invoke<Void>(0x80D9F74197EA47D9, toggle); } // 0x80D9F74197EA47D9
	static void SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { invoke<Void>(0xB3B3359379FE77D3, multiplier); } // 0xB3B3359379FE77D3
	static void SET_RENDER_TRAIN_AS_DERAILED(Vehicle train, BOOL toggle) { invoke<Void>(0x317B11A312DF5534, train, toggle); } // 0x317B11A312DF5534
	static void SET_SCRIPT_VEHICLE_GENERATOR(int vehicleGenerator, BOOL enabled) { invoke<Void>(0xD9D620E0AC6DC4B0, vehicleGenerator, enabled); } // 0xD9D620E0AC6DC4B0
	static void _SET_SOMETHING_MULTIPLIER_THIS_FRAME(BOOL toggle) { invoke<Void>(0xD4B8E3D1917BC86B, toggle); } // 0xD4B8E3D1917BC86B
	static void _SET_SOME_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float value) { invoke<Void>(0x90B6DA738A9A25DA, value); } // 0x90B6DA738A9A25DA
	static void SET_TAXI_LIGHTS(Vehicle vehicle, BOOL state) { invoke<Void>(0x598803E85E8448D9, vehicle, state); } // 0x598803E85E8448D9
	static void _SET_TOW_TRUCK_CRANE_HEIGHT(Vehicle towTruck, float height) { invoke<Void>(0xFE54B92A344583CA, towTruck, height); } // 0xFE54B92A344583CA
	static Any SET_TRAIN_CRUISE_SPEED(Vehicle train, float speed) { return invoke<Any>(0x16469284DB8C62B5, train, speed); } // 0x16469284DB8C62B5
	static Any SET_TRAIN_SPEED(Vehicle train, float speed) { return invoke<Any>(0xAA0BC91BE0B796E3, train, speed); } // 0xAA0BC91BE0B796E3
	static void SET_VEHICLE_ALARM(Vehicle vehicle, BOOL state) { invoke<Void>(0xCDE5E70C1DDB954C, vehicle, state); } // 0xCDE5E70C1DDB954C
	static void SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON(Vehicle veh, BOOL toggle) { invoke<Void>(0x5D14D4154BFE7B2C, veh, toggle); } // 0x5D14D4154BFE7B2C
	static Any SET_VEHICLE_AUTOMATICALLY_ATTACHES(Vehicle vehicle, BOOL p1, Any p2) { return invoke<Any>(0x8BA6F76BC53A1493, vehicle, p1, p2); } // 0x8BA6F76BC53A1493
	static void SET_VEHICLE_BODY_HEALTH(Vehicle vehicle, float value) { invoke<Void>(0xB77D05AC8C78AADB, vehicle, value); } // 0xB77D05AC8C78AADB
	static void SET_VEHICLE_BRAKE_LIGHTS(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x92B35082E0B42F66, vehicle, toggle); } // 0x92B35082E0B42F66
	static void SET_VEHICLE_BURNOUT(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xFB8794444A7D60FB, vehicle, toggle); } // 0xFB8794444A7D60FB
	static void SET_VEHICLE_CAN_BE_TARGETTED(Vehicle vehicle, BOOL state) { invoke<Void>(0x3750146A28097A82, vehicle, state); } // 0x3750146A28097A82
	static void SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x300504B23BD3B711, vehicle, toggle); } // 0x300504B23BD3B711
	static void SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED(Vehicle vehicle, BOOL state) { invoke<Void>(0x4C7028F78FFD3681, vehicle, state); } // 0x4C7028F78FFD3681
	static void SET_VEHICLE_CAN_BREAK(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x59BF8C3D52C92F66, vehicle, toggle); } // 0x59BF8C3D52C92F66
	static void SET_VEHICLE_CEILING_HEIGHT(Vehicle vehicle, float p1) { invoke<Void>(0xA46413066687A328, vehicle, p1); } // 0xA46413066687A328
	static void SET_VEHICLE_COLOUR_COMBINATION(Vehicle vehicle, int colorCombination) { invoke<Void>(0x33E8CD3322E2FE31, vehicle, colorCombination); } // 0x33E8CD3322E2FE31
	static void SET_VEHICLE_COLOURS(Vehicle vehicle, int colorPrimary, int colorSecondary) { invoke<Void>(0x4F1D4BE3A7F24601, vehicle, colorPrimary, colorSecondary); } // 0x4F1D4BE3A7F24601
	static void SET_VEHICLE_CUSTOM_PRIMARY_COLOUR(Vehicle vehicle, int r, int g, int b) { invoke<Void>(0x7141766F91D15BEA, vehicle, r, g, b); } // 0x7141766F91D15BEA
	static void SET_VEHICLE_CUSTOM_SECONDARY_COLOUR(Vehicle vehicle, int r, int g, int b) { invoke<Void>(0x36CED73BFED89754, vehicle, r, g, b); } // 0x36CED73BFED89754
	static void SET_VEHICLE_DAMAGE(Vehicle vehicle, float xOffset, float yOffset, float zOffset, float damage, float radius, BOOL p6) { invoke<Void>(0xA1DD317EA8FD4F29, vehicle, xOffset, yOffset, zOffset, damage, radius, p6); } // 0xA1DD317EA8FD4F29
	static void _SET_VEHICLE_DASHBOARD_COLOUR(Vehicle vehicle, int color) { invoke<Void>(0x6089CDF6A57F326C, vehicle, color); } // 0x6089CDF6A57F326C
	static void SET_VEHICLE_DEFORMATION_FIXED(Vehicle vehicle) { invoke<Void>(0x953DA1E1B12C0491, vehicle); } // 0x953DA1E1B12C0491
	static void SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { invoke<Void>(0x245A6883D966D537, multiplier); } // 0x245A6883D966D537
	static void SET_VEHICLE_DIRT_LEVEL(Vehicle vehicle, float dirtLevel) { invoke<Void>(0x79D3B596FE44EE8B, vehicle, dirtLevel); } // 0x79D3B596FE44EE8B
	static void SET_VEHICLE_DOOR_BROKEN(Vehicle vehicle, int doorIndex, BOOL deleteDoor) { invoke<Void>(0xD4D4F6A4AB575A33, vehicle, doorIndex, deleteDoor); } // 0xD4D4F6A4AB575A33
	static void _SET_VEHICLE_DOOR_CAN_BREAK(Vehicle vehicle, int doorIndex, BOOL isBreakable) { invoke<Void>(0x2FA133A4A9D37ED8, vehicle, doorIndex, isBreakable); } // 0x2FA133A4A9D37ED8
	static void SET_VEHICLE_DOOR_CONTROL(Vehicle vehicle, int doorIndex, int speed, float angle) { invoke<Void>(0xF2BFA0430F0A0FCB, vehicle, doorIndex, speed, angle); } // 0xF2BFA0430F0A0FCB
	static void SET_VEHICLE_DOOR_LATCHED(Vehicle vehicle, int doorIndex, BOOL forceClose, BOOL lock, BOOL p4) { invoke<Void>(0xA5A9653A8D2CAF48, vehicle, doorIndex, forceClose, lock, p4); } // 0xA5A9653A8D2CAF48
	static void SET_VEHICLE_DOOR_OPEN(Vehicle vehicle, int doorIndex, BOOL loose, BOOL openInstantly) { invoke<Void>(0x7C65DAC73C35C862, vehicle, doorIndex, loose, openInstantly); } // 0x7C65DAC73C35C862
	static void SET_VEHICLE_DOOR_SHUT(Vehicle vehicle, int doorIndex, BOOL closeInstantly) { invoke<Void>(0x93D9BD300D7789E5, vehicle, doorIndex, closeInstantly); } // 0x93D9BD300D7789E5
	static void SET_VEHICLE_DOORS_LOCKED(Vehicle vehicle, int doorLockStatus) { invoke<Void>(0xB664292EAECF7FA6, vehicle, doorLockStatus); } // 0xB664292EAECF7FA6
	static void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xA2F80B8D040727CC, vehicle, toggle); } // 0xA2F80B8D040727CC
	static void SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(Vehicle vehicle, Player player, BOOL toggle) { invoke<Void>(0x517AAF684BB50CD1, vehicle, player, toggle); } // 0x517AAF684BB50CD1
	static void SET_VEHICLE_DOORS_LOCKED_FOR_TEAM(Vehicle vehicle, int team, BOOL toggle) { invoke<Void>(0xB81F6D4A8F5EEBA8, vehicle, team, toggle); } // 0xB81F6D4A8F5EEBA8
	static void SET_VEHICLE_DOORS_SHUT(Vehicle vehicle, BOOL closeInstantly) { invoke<Void>(0x781B3D62BB013EF5, vehicle, closeInstantly); } // 0x781B3D62BB013EF5
	static void SET_VEHICLE_DROPS_MONEY_WHEN_BLOWN_UP(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x68F64F2470F9656, vehicle, toggle); } // 0x68F64F2470F9656
	static void SET_VEHICLE_ENGINE_CAN_DEGRADE(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x983765856F2564F9, vehicle, toggle); } // 0x983765856F2564F9
	static void SET_VEHICLE_ENGINE_HEALTH(Vehicle vehicle, float health) { invoke<Void>(0x45F6D8EEF34ABEF1, vehicle, health); } // 0x45F6D8EEF34ABEF1
	static void SET_VEHICLE_ENGINE_ON(Vehicle vehicle, BOOL value, BOOL instantly, BOOL otherwise) { invoke<Void>(0x2497C4717C8B881E, vehicle, value, instantly, otherwise); } // 0x2497C4717C8B881E
	static void _SET_VEHICLE_ENGINE_POWER_MULTIPLIER(Vehicle vehicle, float value) { invoke<Void>(0x93A3996368C94158, vehicle, value); } // 0x93A3996368C94158
	static void _SET_VEHICLE_ENGINE_TORQUE_MULTIPLIER(Vehicle vehicle, float value) { invoke<Void>(0xB59E4BD37AE292DB, vehicle, value); } // 0xB59E4BD37AE292DB
	static void SET_VEHICLE_ENVEFF_SCALE(Vehicle vehicle, float fade) { invoke<Void>(0x3AFDC536C3D01674, vehicle, fade); } // 0x3AFDC536C3D01674
	static void SET_VEHICLE_EXCLUSIVE_DRIVER(Vehicle vehicle, Ped ped) { invoke<Void>(0x41062318F23ED854, vehicle, ped); } // 0x41062318F23ED854
	static void _SET_VEHICLE_EXCLUSIVE_DRIVER_2(Vehicle vehicle, Ped ped, int p2) { invoke<Void>(0xB5C51B5502E85E83, vehicle, ped, p2); } // 0xB5C51B5502E85E83
	static void SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x71B0892EC081D60A, vehicle, toggle); } // 0x71B0892EC081D60A
	static void SET_VEHICLE_EXTRA(Vehicle vehicle, int extraId, BOOL disable) { invoke<Void>(0x7EE3A3C5E4A40CC9, vehicle, extraId, disable); } // 0x7EE3A3C5E4A40CC9
	static void SET_VEHICLE_EXTRA_COLOURS(Vehicle vehicle, int pearlescentColor, int wheelColor) { invoke<Void>(0x2036F561ADD12E33, vehicle, pearlescentColor, wheelColor); } // 0x2036F561ADD12E33
	static void SET_VEHICLE_FIXED(Vehicle vehicle) { invoke<Void>(0x115722B1B9C14C1C, vehicle); } // 0x115722B1B9C14C1C
	static void SET_VEHICLE_FORWARD_SPEED(Vehicle vehicle, float speed) { invoke<Void>(0xAB54A438726D25D5, vehicle, speed); } // 0xAB54A438726D25D5
	static void SET_VEHICLE_FRICTION_OVERRIDE(Vehicle vehicle, float friction) { invoke<Void>(0x1837AF7C627009BA, vehicle, friction); } // 0x1837AF7C627009BA
	static void SET_VEHICLE_FULLBEAM(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x8B7FD87F0DDB421E, vehicle, toggle); } // 0x8B7FD87F0DDB421E
	static void SET_VEHICLE_GRAVITY(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x89F149B6131E57DA, vehicle, toggle); } // 0x89F149B6131E57DA
	static void _SET_VEHICLE_HALT(Vehicle vehicle, float distance, int killEngine, BOOL unknown) { invoke<Void>(0x260BE8F09E326A20, vehicle, distance, killEngine, unknown); } // 0x260BE8F09E326A20
	static void SET_VEHICLE_HANDBRAKE(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x684785568EF26A22, vehicle, toggle); } // 0x684785568EF26A22
	static void SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER(Vehicle vehicle, BOOL owned) { invoke<Void>(0x2B5F9D2AF1F1722D, vehicle, owned); } // 0x2B5F9D2AF1F1722D
	static void SET_VEHICLE_HAS_STRONG_AXLES(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x92F0CF722BC4202F, vehicle, toggle); } // 0x92F0CF722BC4202F
	static void _SET_VEHICLE_HEADLIGHTS_COLOUR(Vehicle vehicle, int color) { invoke<Void>(0xE41033B25D003A07, vehicle, color); } // 0xE41033B25D003A07
	static void _SET_VEHICLE_HUD_SPECIAL_ABILITY_BAR_ACTIVE(Vehicle vehicle, BOOL active) { invoke<Void>(0x99C82F8A139F3E4E, vehicle, active); } // 0x99C82F8A139F3E4E
	static void SET_VEHICLE_INDICATOR_LIGHTS(Vehicle vehicle, int turnSignal, BOOL toggle) { invoke<Void>(0xB5D45264751B7DF0, vehicle, turnSignal, toggle); } // 0xB5D45264751B7DF0
	static void _SET_VEHICLE_INTERIOR_COLOUR(Vehicle vehicle, int color) { invoke<Void>(0xF40DD601A65F7F19, vehicle, color); } // 0xF40DD601A65F7F19
	static void SET_VEHICLE_INTERIORLIGHT(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xBC2042F090AF6AD3, vehicle, toggle); } // 0xBC2042F090AF6AD3
	static void SET_VEHICLE_IS_CONSIDERED_BY_PLAYER(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x31B927BBC44156CD, vehicle, toggle); } // 0x31B927BBC44156CD
	static Any SET_VEHICLE_IS_STOLEN(Vehicle vehicle, BOOL isStolen) { return invoke<Any>(0x67B2C79AA7FF5738, vehicle, isStolen); } // 0x67B2C79AA7FF5738
	static void SET_VEHICLE_IS_WANTED(Vehicle vehicle, BOOL state) { invoke<Void>(0xF7EC25A3EBEEC726, vehicle, state); } // 0xF7EC25A3EBEEC726
	static void _SET_VEHICLE_JET_ENGINE_ON(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xB8FBC8B1330CA9B4, vehicle, toggle); } // 0xB8FBC8B1330CA9B4
	static void SET_VEHICLE_LIGHT_MULTIPLIER(Vehicle vehicle, float multiplier) { invoke<Void>(0xB385454F8791F57C, vehicle, multiplier); } // 0xB385454F8791F57C
	static void SET_VEHICLE_LIGHTS(Vehicle vehicle, int state) { invoke<Void>(0x34E710FF01247C5A, vehicle, state); } // 0x34E710FF01247C5A
	static void _SET_VEHICLE_LIGHTS_MODE(Vehicle vehicle, int p1) { invoke<Void>(0x1FD09E7390A74D54, vehicle, p1); } // 0x1FD09E7390A74D54
	static void SET_VEHICLE_LIVERY(Vehicle vehicle, int liveryIndex) { invoke<Void>(0x60BF608F1B8CD1B6, vehicle, liveryIndex); } // 0x60BF608F1B8CD1B6
	static void SET_VEHICLE_LOD_MULTIPLIER(Vehicle vehicle, float multiplier) { invoke<Void>(0x93AE6A61BE015BF1, vehicle, multiplier); } // 0x93AE6A61BE015BF1
	static void SET_VEHICLE_MOD(Vehicle vehicle, int modType, int modIndex, BOOL customTires) { invoke<Void>(0x6AF0636DDEDCB6DD, vehicle, modType, modIndex, customTires); } // 0x6AF0636DDEDCB6DD
	static void SET_VEHICLE_MOD_COLOR_1(Vehicle vehicle, int paintType, int color, int p3) { invoke<Void>(0x43FEB945EE7F85B8, vehicle, paintType, color, p3); } // 0x43FEB945EE7F85B8
	static void SET_VEHICLE_MOD_COLOR_2(Vehicle vehicle, int paintType, int color) { invoke<Void>(0x816562BADFDEC83E, vehicle, paintType, color); } // 0x816562BADFDEC83E
	static void SET_VEHICLE_MODEL_IS_SUPPRESSED(Hash model, BOOL suppressed) { invoke<Void>(0xFC2D89AC25A5814, model, suppressed); } // 0xFC2D89AC25A5814
	static void SET_VEHICLE_MOD_KIT(Vehicle vehicle, int modKit) { invoke<Void>(0x1F2AA07F00B3217A, vehicle, modKit); } // 0x1F2AA07F00B3217A
	static void SET_VEHICLE_NAME_DEBUG(Vehicle vehicle, char* name) { invoke<Void>(0xBFDF984E2C22B94F, vehicle, name); } // 0xBFDF984E2C22B94F
	static void SET_VEHICLE_NEEDS_TO_BE_HOTWIRED(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xFBA550EA44404EE6, vehicle, toggle); } // 0xFBA550EA44404EE6
	static void _SET_VEHICLE_NEON_LIGHT_ENABLED(Vehicle vehicle, int index, BOOL toggle) { invoke<Void>(0x2AA720E4287BF269, vehicle, index, toggle); } // 0x2AA720E4287BF269
	static void _SET_VEHICLE_NEON_LIGHTS_COLOUR(Vehicle vehicle, int r, int g, int b) { invoke<Void>(0x8E0A582209A62695, vehicle, r, g, b); } // 0x8E0A582209A62695
	static void SET_VEHICLE_NUMBER_PLATE_TEXT(Vehicle vehicle, char* plateText) { invoke<Void>(0x95A88F0B409CDA47, vehicle, plateText); } // 0x95A88F0B409CDA47
	static void SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(Vehicle vehicle, int plateIndex) { invoke<Void>(0x9088EB5A43FFB0A1, vehicle, plateIndex); } // 0x9088EB5A43FFB0A1
	static BOOL SET_VEHICLE_ON_GROUND_PROPERLY(Vehicle vehicle) { return invoke<BOOL>(0x49733E92263139D1, vehicle); } // 0x49733E92263139D1
	static void SET_VEHICLE_OUT_OF_CONTROL(Vehicle vehicle, BOOL killDriver, BOOL explodeOnImpact) { invoke<Void>(0xF19D095E42D430CC, vehicle, killDriver, explodeOnImpact); } // 0xF19D095E42D430CC
	static void _SET_VEHICLE_PARACHUTE_ACTIVE(Vehicle vehicle, BOOL active) { invoke<Void>(0xBFFB028B3DD0A97, vehicle, active); } // 0xBFFB028B3DD0A97
	static void SET_VEHICLE_PETROL_TANK_HEALTH(Vehicle vehicle, float health) { invoke<Void>(0x70DB57649FA8D0D8, vehicle, health); } // 0x70DB57649FA8D0D8
	static void SET_VEHICLE_PROVIDES_COVER(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x5AFEEDD9BB2899D7, vehicle, toggle); } // 0x5AFEEDD9BB2899D7
	static void SET_VEHICLE_REDUCE_GRIP(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x222FF6A823D122E2, vehicle, toggle); } // 0x222FF6A823D122E2
	static void _SET_VEHICLE_ROCKET_BOOST_ACTIVE(Vehicle vehicle, BOOL active) { invoke<Void>(0x81E1552E35DC3839, vehicle, active); } // 0x81E1552E35DC3839
	static void _SET_VEHICLE_ROCKET_BOOST_PERCENTAGE(Vehicle vehicle, float percentage) { invoke<Void>(0xFEB2DDED3509562E, vehicle, percentage); } // 0xFEB2DDED3509562E
	static void _SET_VEHICLE_ROCKET_BOOST_REFILL_TIME(Vehicle vehicle, float time) { invoke<Void>(0xE00F2AB100B76E89, vehicle, time); } // 0xE00F2AB100B76E89
	static void _SET_VEHICLE_ROOF_LIVERY(Vehicle vehicle, int livery) { invoke<Void>(0xA6D3A8750DC73270, vehicle, livery); } // 0xA6D3A8750DC73270
	static void SET_VEHICLE_RUDDER_BROKEN(Vehicle vehicle, BOOL p1) { invoke<Void>(0x9606148B6C71DEF, vehicle, p1); } // 0x9606148B6C71DEF
	static void SET_VEHICLE_SEARCHLIGHT(Vehicle heli, BOOL toggle, BOOL canBeUsedByAI) { invoke<Void>(0x14E85C5EE7A4D542, heli, toggle, canBeUsedByAI); } // 0x14E85C5EE7A4D542
	static void SET_VEHICLE_SHOOT_AT_TARGET(Ped driver, Entity entity, float xTarget, float yTarget, float zTarget) { invoke<Void>(0x74CD9A9327A282EA, driver, entity, xTarget, yTarget, zTarget); } // 0x74CD9A9327A282EA
	static void _SET_VEHICLE_SILENT(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x9D44FCCE98450843, vehicle, toggle); } // 0x9D44FCCE98450843
	static void SET_VEHICLE_SIREN(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xF4924635A19EB37D, vehicle, toggle); } // 0xF4924635A19EB37D
	static void _SET_VEHICLE_ST(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x1CF38D529D7441D9, vehicle, toggle); } // 0x1CF38D529D7441D9
	static void SET_VEHICLE_STEER_BIAS(Vehicle vehicle, float value) { invoke<Void>(0x42A8EC77D5150CBE, vehicle, value); } // 0x42A8EC77D5150CBE
	static void SET_VEHICLE_STRONG(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x3E8C8727991A8A0B, vehicle, toggle); } // 0x3E8C8727991A8A0B
	static void SET_VEHICLE_TIMED_EXPLOSION(Vehicle vehicle, Ped ped, BOOL toggle) { invoke<Void>(0x2E0A74E1002380B1, vehicle, ped, toggle); } // 0x2E0A74E1002380B1
	static void _SET_VEHICLE_TRANSFORM_STATE(Vehicle vehicle, float state) { invoke<Void>(0x438B3D7CA026FE91, vehicle, state); } // 0x438B3D7CA026FE91
	static void SET_VEHICLE_TYRE_BURST(Vehicle vehicle, int index, BOOL onRim, float p3) { invoke<Void>(0xEC6A202EE4960385, vehicle, index, onRim, p3); } // 0xEC6A202EE4960385
	static void SET_VEHICLE_TYRE_FIXED(Vehicle vehicle, int tyreIndex) { invoke<Void>(0x6E13FC662B882D1D, vehicle, tyreIndex); } // 0x6E13FC662B882D1D
	static void SET_VEHICLE_TYRES_CAN_BURST(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xEB9DC3C7D8596C46, vehicle, toggle); } // 0xEB9DC3C7D8596C46
	static void SET_VEHICLE_TYRE_SMOKE_COLOR(Vehicle vehicle, int r, int g, int b) { invoke<Void>(0xB5BA80F839791C0F, vehicle, r, g, b); } // 0xB5BA80F839791C0F
	static void SET_VEHICLE_UNDRIVEABLE(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x8ABA6AF54B942B95, vehicle, toggle); } // 0x8ABA6AF54B942B95
	static Any SET_VEHICLE_WHEELS_CAN_BREAK(Vehicle vehicle, BOOL enabled) { return invoke<Any>(0x29B18B4FD460CA8F, vehicle, enabled); } // 0x29B18B4FD460CA8F
	static void SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP(Vehicle vehicle, BOOL toggle) { invoke<Void>(0xA37B9A517B133349, vehicle, toggle); } // 0xA37B9A517B133349
	static void SET_VEHICLE_WHEEL_TYPE(Vehicle vehicle, int WheelType) { invoke<Void>(0x487EB21CC7295BA1, vehicle, WheelType); } // 0x487EB21CC7295BA1
	static void SET_VEHICLE_WINDOW_TINT(Vehicle vehicle, int tint) { invoke<Void>(0x57C51E6BAD752696, vehicle, tint); } // 0x57C51E6BAD752696
	static void _SET_VERTICAL_FLIGHT_PHASE(Vehicle vehicle, float angle) { invoke<Void>(0x9AA47FFF660CB932, vehicle, angle); } // 0x9AA47FFF660CB932
	static void SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE(Any p0, float p1) { invoke<Void>(0x9438F7AD68771A20, p0, p1); } // 0x9438F7AD68771A20
	static void SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE(Any p0) { invoke<Void>(0xAB8E2EDA0C0A5883, p0); } // 0xAB8E2EDA0C0A5883
	static Any SMASH_VEHICLE_WINDOW(Vehicle vehicle, int index) { return invoke<Any>(0x9E5B5E4D2CCD2259, vehicle, index); } // 0x9E5B5E4D2CCD2259
	static void START_PLAYBACK_RECORDED_VEHICLE(Vehicle vehicle, int p1, char* playback, BOOL p3) { invoke<Void>(0x3F878F92B3A7A071, vehicle, p1, playback, p3); } // 0x3F878F92B3A7A071
	static void START_PLAYBACK_RECORDED_VEHICLE_USING_AI(Any p0, Any p1, Any* p2, float p3, Any p4) { invoke<Void>(0x29DE5FA52D00428C, p0, p1, p2, p3, p4); } // 0x29DE5FA52D00428C
	static void START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS(Vehicle vehicle, Any p1, char* playback, Any p3, Any p4, Any p5) { invoke<Void>(0x7D80FD645D4DA346, vehicle, p1, playback, p3, p4, p5); } // 0x7D80FD645D4DA346
	static Any START_VEHICLE_ALARM(Vehicle vehicle) { return invoke<Any>(0xB8FF7AB45305C345, vehicle); } // 0xB8FF7AB45305C345
	static void START_VEHICLE_HORN(Vehicle vehicle, int duration, Hash mode, BOOL forever) { invoke<Void>(0x9C8C6504B5B63D2C, vehicle, duration, mode, forever); } // 0x9C8C6504B5B63D2C
	static void STEER_UNLOCK_BIAS(Vehicle vehicle, BOOL toggle) { invoke<Void>(0x7116E24E9D1929D, vehicle, toggle); } // 0x7116E24E9D1929D
	static void STOP_ALL_GARAGE_ACTIVITY() { invoke<Void>(0xF87E938BDF29D66); } // 0xF87E938BDF29D66
	static void STOP_PLAYBACK_RECORDED_VEHICLE(Any p0) { invoke<Void>(0x54833611C17ABDEA, p0); } // 0x54833611C17ABDEA
	static Any SWITCH_TRAIN_TRACK(int intersectionId, BOOL state) { return invoke<Any>(0xFD813BB7DB977F20, intersectionId, state); } // 0xFD813BB7DB977F20
	static void TOGGLE_VEHICLE_MOD(Vehicle vehicle, int modType, BOOL toggle) { invoke<Void>(0x2A1F4F37F95BAD08, vehicle, modType, toggle); } // 0x2A1F4F37F95BAD08
	static void TRACK_VEHICLE_VISIBILITY(Vehicle vehicle) { invoke<Void>(0x64473AEFDCF47DCA, vehicle); } // 0x64473AEFDCF47DCA
	static void _TRANSFORM_STORMBERG_TO_ROAD_VEHICLE(Vehicle vehicle, BOOL instantly) { invoke<Void>(0x2A69FFD1B42BFF9E, vehicle, instantly); } // 0x2A69FFD1B42BFF9E
	static void _TRANSFORM_STORMBERG_TO_WATER_VEHICLE(Vehicle vehicle, BOOL instantly) { invoke<Void>(0xBE4C854FFDB6EEBE, vehicle, instantly); } // 0xBE4C854FFDB6EEBE
	static void UNPAUSE_PLAYBACK_RECORDED_VEHICLE(Any p0) { invoke<Void>(0x8879EE09268305D5, p0); } // 0x8879EE09268305D5
	static BOOL _VEHICLE_HAS_LANDING_GEAR(Vehicle vehicle) { return invoke<BOOL>(0x4198AB0022B15F87, vehicle); } // 0x4198AB0022B15F87
	static void _VEHICLE_SET_CUSTOM_PARACHUTE_MODEL(Vehicle vehicle, Hash parachuteModel) { invoke<Void>(0x4D610C6B56031351, vehicle, parachuteModel); } // 0x4D610C6B56031351
	static void _VEHICLE_SET_CUSTOM_PARACHUTE_TEXTURE(Vehicle vehicle, int colorIndex) { invoke<Void>(0xA74AD2439468C883, vehicle, colorIndex); } // 0xA74AD2439468C883
	static BOOL WAS_COUNTER_ACTIVATED(Vehicle vehicle, Any p1) { return invoke<BOOL>(0x3EC8BF18AA453FE9, vehicle, p1); } // 0x3EC8BF18AA453FE9
}

namespace WATER
{
	static int _ADD_CURRENT_RISE(float xLow, float yLow, float xHigh, float yHigh, float height) { return invoke<int>(0xFDBF4CDBC07E1706, xLow, yLow, xHigh, yHigh, height); } // 0xFDBF4CDBC07E1706
	static float _GET_CURRENT_INTENSITY() { return invoke<float>(0x2B2A2CC86778B619); } // 0x2B2A2CC86778B619
	static BOOL GET_WATER_HEIGHT(float x, float y, float z, float* height) { return invoke<BOOL>(0xF6829842C06AE524, x, y, z, height); } // 0xF6829842C06AE524
	static BOOL GET_WATER_HEIGHT_NO_WAVES(float x, float y, float z, float* height) { return invoke<BOOL>(0x8EE6B53CE13A9794, x, y, z, height); } // 0x8EE6B53CE13A9794
	static void MODIFY_WATER(float x, float y, float radius, float height) { invoke<Void>(0xC443FD757C3BA637, x, y, radius, height); } // 0xC443FD757C3BA637
	static void _0x547237AA71AB44DE(Any p0) { invoke<Void>(0x547237AA71AB44DE, p0); } // 0x547237AA71AB44DE
	static void _REMOVE_CURRENT_RISE(int p0) { invoke<Void>(0xB1252E3E59A82AAF, p0); } // 0xB1252E3E59A82AAF
	static void _RESET_CURRENT_INTENSITY() { invoke<Void>(0x5E5E99285AE812DB); } // 0x5E5E99285AE812DB
	static void _SET_CURRENT_INTENSITY(float intensity) { invoke<Void>(0xB96B00E976BE977F, intensity); } // 0xB96B00E976BE977F
	static BOOL TEST_PROBE_AGAINST_ALL_WATER(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { return invoke<BOOL>(0x8974647ED222EA5F, p0, p1, p2, p3, p4, p5, p6, p7); } // 0x8974647ED222EA5F
	static BOOL TEST_PROBE_AGAINST_WATER(float x1, float y1, float z1, float x2, float y2, float z2, Vector3* result) { return invoke<BOOL>(0xFFA5D878809819DB, x1, y1, z1, x2, y2, z2, result); } // 0xFFA5D878809819DB
	static BOOL TEST_VERTICAL_PROBE_AGAINST_ALL_WATER(float x, float y, float z, Any p3, float* height) { return invoke<BOOL>(0x2B3451FA1E3142E2, x, y, z, p3, height); } // 0x2B3451FA1E3142E2
}

namespace WEAPON
{
	static void ADD_AMMO_TO_PED(Ped ped, Hash weaponHash, int ammo) { invoke<Void>(0x78F0424C34306220, ped, weaponHash, ammo); } // 0x78F0424C34306220
	static BOOL CAN_USE_WEAPON_ON_PARACHUTE(Hash weaponHash) { return invoke<BOOL>(0xBC7BE5ABC0879F74, weaponHash); } // 0xBC7BE5ABC0879F74
	static void CLEAR_ENTITY_LAST_WEAPON_DAMAGE(Entity entity) { invoke<Void>(0xAC678E40BE7C74D2, entity); } // 0xAC678E40BE7C74D2
	static void CLEAR_PED_LAST_WEAPON_DAMAGE(Ped ped) { invoke<Void>(0xE98F88A24C5F4B8, ped); } // 0xE98F88A24C5F4B8
	static Object CREATE_WEAPON_OBJECT(Hash weaponHash, int ammoCount, float x, float y, float z, BOOL showWorldModel, float heading, Any p7) { return invoke<Object>(0x9541D3CF0D398F36, weaponHash, ammoCount, x, y, z, showWorldModel, heading, p7); } // 0x9541D3CF0D398F36
	static BOOL DOES_WEAPON_TAKE_WEAPON_COMPONENT(Hash weaponHash, Hash componentHash) { return invoke<BOOL>(0x5CEE3DF569CECAB0, weaponHash, componentHash); } // 0x5CEE3DF569CECAB0
	static void ENABLE_LASER_SIGHT_RENDERING(BOOL toggle) { invoke<Void>(0xC8B46D7727D864AA, toggle); } // 0xC8B46D7727D864AA
	static void EXPLODE_PROJECTILES(Ped ped, Hash weaponHash, BOOL p2) { invoke<Void>(0xFC4BD125DE7611E4, ped, weaponHash, p2); } // 0xFC4BD125DE7611E4
	static BOOL GET_AMMO_IN_CLIP(Ped ped, Hash weaponHash, int* ammo) { return invoke<BOOL>(0x2E1202248937775C, ped, weaponHash, ammo); } // 0x2E1202248937775C
	static int GET_AMMO_IN_PED_WEAPON(Ped ped, Hash weaponhash) { return invoke<int>(0x15A522136D7F951, ped, weaponhash); } // 0x15A522136D7F951
	static Hash GET_BEST_PED_WEAPON(Ped ped, BOOL p1) { return invoke<Hash>(0x8483E98E8B888AE2, ped, p1); } // 0x8483E98E8B888AE2
	static BOOL GET_CURRENT_PED_VEHICLE_WEAPON(Ped ped, Hash* weaponHash) { return invoke<BOOL>(0x1017582BCD3832DC, ped, weaponHash); } // 0x1017582BCD3832DC
	static BOOL GET_CURRENT_PED_WEAPON(Ped ped, Hash* weaponHash, BOOL p2) { return invoke<BOOL>(0x3A87E44BB9A01D54, ped, weaponHash, p2); } // 0x3A87E44BB9A01D54
	static Entity GET_CURRENT_PED_WEAPON_ENTITY_INDEX(Ped ped) { return invoke<Entity>(0x3B390A939AF0B5FC, ped); } // 0x3B390A939AF0B5FC
	static BOOL GET_IS_PED_GADGET_EQUIPPED(Ped ped, Hash gadgetHash) { return invoke<BOOL>(0xF731332072F5156C, ped, gadgetHash); } // 0xF731332072F5156C
	static float _GET_LOCKON_RANGE_OF_CURRENT_PED_WEAPON(Ped ped) { return invoke<float>(0x840F03E9041E2C9C, ped); } // 0x840F03E9041E2C9C
	static BOOL GET_MAX_AMMO(Ped ped, Hash weaponHash, int* ammo) { return invoke<BOOL>(0xDC16122C7A20C933, ped, weaponHash, ammo); } // 0xDC16122C7A20C933
	static int GET_MAX_AMMO_IN_CLIP(Ped ped, Hash weaponHash, BOOL p2) { return invoke<int>(0xA38DCFFCEA8962FA, ped, weaponHash, p2); } // 0xA38DCFFCEA8962FA
	static float GET_MAX_RANGE_OF_CURRENT_PED_WEAPON(Ped ped) { return invoke<float>(0x814C9D19DFD69679, ped); } // 0x814C9D19DFD69679
	static int GET_PED_AMMO_BY_TYPE(Ped ped, Any ammoType) { return invoke<int>(0x39D22031557946C1, ped, ammoType); } // 0x39D22031557946C1
	static Hash GET_PED_AMMO_TYPE_FROM_WEAPON(Ped ped, Hash weaponHash) { return invoke<Hash>(0x7FEAD38B326B9F74, ped, weaponHash); } // 0x7FEAD38B326B9F74
	static Hash _GET_PED_AMMO_TYPE_FROM_WEAPON_2(Ped ped, Hash weaponHash) { return invoke<Hash>(0xF489B44DD5AF4BD9, ped, weaponHash); } // 0xF489B44DD5AF4BD9
	static BOOL GET_PED_LAST_WEAPON_IMPACT_COORD(Ped ped, Vector3* coords) { return invoke<BOOL>(0x6C4D0409BA1A2BC2, ped, coords); } // 0x6C4D0409BA1A2BC2
	static int GET_PED_WEAPON_TINT_INDEX(Ped ped, Hash weaponHash) { return invoke<int>(0x2B9EEDC07BD06B9F, ped, weaponHash); } // 0x2B9EEDC07BD06B9F
	static Hash GET_PED_WEAPONTYPE_IN_SLOT(Ped ped, Hash weaponSlot) { return invoke<Hash>(0xEFFED78E9011134D, ped, weaponSlot); } // 0xEFFED78E9011134D
	static Hash GET_SELECTED_PED_WEAPON(Ped ped) { return invoke<Hash>(0xA6DB4965674D243, ped); } // 0xA6DB4965674D243
	static int GET_WEAPON_CLIP_SIZE(Hash weaponHash) { return invoke<int>(0x583BE370B1EC6EB4, weaponHash); } // 0x583BE370B1EC6EB4
	static BOOL GET_WEAPON_COMPONENT_HUD_STATS(Hash componentHash, int* outData) { return invoke<BOOL>(0xB3CAF387AE12E9F8, componentHash, outData); } // 0xB3CAF387AE12E9F8
	static Hash GET_WEAPON_COMPONENT_TYPE_MODEL(Hash componentHash) { return invoke<Hash>(0xDB57B41EC1DB083, componentHash); } // 0xDB57B41EC1DB083
	static float _GET_WEAPON_DAMAGE(Hash weaponHash, Any p1) { return invoke<float>(0x3133B907D8B32053, weaponHash, p1); } // 0x3133B907D8B32053
	static int GET_WEAPON_DAMAGE_TYPE(Hash weaponHash) { return invoke<int>(0x3BE0BB12D25FB305, weaponHash); } // 0x3BE0BB12D25FB305
	static BOOL GET_WEAPON_HUD_STATS(Hash weaponHash, Any* outData) { return invoke<BOOL>(0xD92C739EE34C9EBA, weaponHash, outData); } // 0xD92C739EE34C9EBA
	static Object GET_WEAPON_OBJECT_FROM_PED(Ped ped, BOOL p1) { return invoke<Object>(0xCAE1DC9A0E22A16D, ped, p1); } // 0xCAE1DC9A0E22A16D
	static int GET_WEAPON_OBJECT_TINT_INDEX(Object weapon) { return invoke<int>(0xCD183314F7CD2E57, weapon); } // 0xCD183314F7CD2E57
	static int GET_WEAPON_TINT_COUNT(Hash weaponHash) { return invoke<int>(0x5DCF6C5CAB2E9BF7, weaponHash); } // 0x5DCF6C5CAB2E9BF7
	static Hash GET_WEAPONTYPE_GROUP(Hash weaponHash) { return invoke<Hash>(0xC3287EE3050FB74C, weaponHash); } // 0xC3287EE3050FB74C
	static Hash GET_WEAPONTYPE_MODEL(Hash weaponHash) { return invoke<Hash>(0xF46CDC33180FDA94, weaponHash); } // 0xF46CDC33180FDA94
	static Hash GET_WEAPONTYPE_SLOT(Hash weaponHash) { return invoke<Hash>(0x4215460B9B8B7FA0, weaponHash); } // 0x4215460B9B8B7FA0
	static void GIVE_DELAYED_WEAPON_TO_PED(Ped ped, Hash weaponHash, int ammoCount, BOOL equipNow) { invoke<Void>(0xB282DC6EBD803C75, ped, weaponHash, ammoCount, equipNow); } // 0xB282DC6EBD803C75
	static void GIVE_WEAPON_COMPONENT_TO_PED(Ped ped, Hash weaponHash, Hash componentHash) { invoke<Void>(0xD966D51AA5B28BB9, ped, weaponHash, componentHash); } // 0xD966D51AA5B28BB9
	static void GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT(Object weaponObject, Hash addonHash) { invoke<Void>(0x33E179436C0B31DB, weaponObject, addonHash); } // 0x33E179436C0B31DB
	static void GIVE_WEAPON_OBJECT_TO_PED(Object weaponObject, Ped ped) { invoke<Void>(0xB1FA61371AF7C4B7, weaponObject, ped); } // 0xB1FA61371AF7C4B7
	static void GIVE_WEAPON_TO_PED(Ped ped, Hash weaponHash, int ammoCount, BOOL isHidden, BOOL equipNow) { invoke<Void>(0xBF0FD6E56C964FCB, ped, weaponHash, ammoCount, isHidden, equipNow); } // 0xBF0FD6E56C964FCB
	static BOOL HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON(Entity entity, Hash weaponHash, int weaponType) { return invoke<BOOL>(0x131D401334815E94, entity, weaponHash, weaponType); } // 0x131D401334815E94
	static BOOL HAS_PED_BEEN_DAMAGED_BY_WEAPON(Ped ped, Hash weaponHash, int weaponType) { return invoke<BOOL>(0x2D343D2219CD027A, ped, weaponHash, weaponType); } // 0x2D343D2219CD027A
	static BOOL HAS_PED_GOT_WEAPON(Ped ped, Hash weaponHash, BOOL p2) { return invoke<BOOL>(0x8DECB02F88F428BC, ped, weaponHash, p2); } // 0x8DECB02F88F428BC
	static BOOL HAS_PED_GOT_WEAPON_COMPONENT(Ped ped, Hash weaponHash, Hash componentHash) { return invoke<BOOL>(0xC593212475FAE340, ped, weaponHash, componentHash); } // 0xC593212475FAE340
	static BOOL HAS_VEHICLE_GOT_PROJECTILE_ATTACHED(Ped driver, Vehicle vehicle, Hash weaponHash, Any p3) { return invoke<BOOL>(0x717C8481234E3B88, driver, vehicle, weaponHash, p3); } // 0x717C8481234E3B88
	static BOOL HAS_WEAPON_ASSET_LOADED(Hash weaponHash) { return invoke<BOOL>(0x36E353271F0E90EE, weaponHash); } // 0x36E353271F0E90EE
	static BOOL HAS_WEAPON_GOT_WEAPON_COMPONENT(Object weapon, Hash addonHash) { return invoke<BOOL>(0x76A18844E743BF91, weapon, addonHash); } // 0x76A18844E743BF91
	static void HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE(Ped ped, BOOL toggle) { invoke<Void>(0x6F6981D2253C208F, ped, toggle); } // 0x6F6981D2253C208F
	static BOOL IS_PED_ARMED(Ped ped, int p1) { return invoke<BOOL>(0x475768A975D5AD17, ped, p1); } // 0x475768A975D5AD17
	static BOOL IS_PED_CURRENT_WEAPON_SILENCED(Ped ped) { return invoke<BOOL>(0x65F0C5AE05943EC7, ped); } // 0x65F0C5AE05943EC7
	static BOOL IS_PED_WEAPON_COMPONENT_ACTIVE(Ped ped, Hash weaponHash, Hash componentHash) { return invoke<BOOL>(0xD78DE0572D3969E, ped, weaponHash, componentHash); } // 0xD78DE0572D3969E
	static BOOL IS_PED_WEAPON_READY_TO_SHOOT(Ped ped) { return invoke<BOOL>(0xB80CA294F2F26749, ped); } // 0xB80CA294F2F26749
	static BOOL IS_WEAPON_VALID(Hash weaponHash) { return invoke<BOOL>(0x937C71165CF334B3, weaponHash); } // 0x937C71165CF334B3
	static BOOL MAKE_PED_RELOAD(Ped ped) { return invoke<BOOL>(0x20AE33F3AC9C0033, ped); } // 0x20AE33F3AC9C0033
	static Any _0x0ABF535877897560(Any p0) { return invoke<Any>(0xABF535877897560, p0); } // 0xABF535877897560
	static void _0x1E45B34ADEBEE48E() { invoke<Void>(0x1E45B34ADEBEE48E); } // 0x1E45B34ADEBEE48E
	static void _0x2472622CE1F2D45F(Any p0, Any p1, Any p2) { invoke<Void>(0x2472622CE1F2D45F, p0, p1, p2); } // 0x2472622CE1F2D45F
	static void _0x44F1012B69313374(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x44F1012B69313374, p0, p1, p2, p3); } // 0x44F1012B69313374
	static void _0x4757F00BC6323CFE(Any p0, Any p1) { invoke<Void>(0x4757F00BC6323CFE, p0, p1); } // 0x4757F00BC6323CFE
	static Any _0x4D1CB8DC40208A17(Any p0, Any p1) { return invoke<Any>(0x4D1CB8DC40208A17, p0, p1); } // 0x4D1CB8DC40208A17
	static Any _0x585847C5E4E11709(Any p0, Any p1, Any p2) { return invoke<Any>(0x585847C5E4E11709, p0, p1, p2); } // 0x585847C5E4E11709
	static void _0x5DA825A85D0EA6E6(Any p0, Any p1, Any p2) { invoke<Void>(0x5DA825A85D0EA6E6, p0, p1, p2); } // 0x5DA825A85D0EA6E6
	static Any _0x6558AC7C17BFEF58(Any p0) { return invoke<Any>(0x6558AC7C17BFEF58, p0); } // 0x6558AC7C17BFEF58
	static void _0x68F8BE6AF5CDF8A6(Any p0, Any p1) { invoke<Void>(0x68F8BE6AF5CDF8A6, p0, p1); } // 0x68F8BE6AF5CDF8A6
	static int _0x91EF34584710BE99(float p0, float p1, float p2, int p3, float p4, float p5, float p6, Hash weaponHash) { return invoke<int>(0x91EF34584710BE99, p0, p1, p2, p3, p4, p5, p6, weaponHash); } // 0x91EF34584710BE99
	static void _0x977CA98939E82E4B(Any p0, Any p1) { invoke<Void>(0x977CA98939E82E4B, p0, p1); } // 0x977CA98939E82E4B
	static Any _0x9DA58CDBF6BDBC08(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { return invoke<Any>(0x9DA58CDBF6BDBC08, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); } // 0x9DA58CDBF6BDBC08
	static void _0x9FE5633880ECD8ED(Any p0, Any p1, Any p2, Any p3) { invoke<Void>(0x9FE5633880ECD8ED, p0, p1, p2, p3); } // 0x9FE5633880ECD8ED
	static Any _0xA2C9AC24B4061285(Any p0, Any p1) { return invoke<Any>(0xA2C9AC24B4061285, p0, p1); } // 0xA2C9AC24B4061285
	static Any _0xB3EA4FEABF41464B(Any p0, Any p1) { return invoke<Any>(0xB3EA4FEABF41464B, p0, p1); } // 0xB3EA4FEABF41464B
	static void _0xB4771B9AAF4E68E4(Ped ped, Hash weaponHash, BOOL p2) { invoke<Void>(0xB4771B9AAF4E68E4, ped, weaponHash, p2); } // 0xB4771B9AAF4E68E4
	static Entity _0xB4C8D77C80C0421E(Ped ped, float p1) { return invoke<Entity>(0xB4C8D77C80C0421E, ped, p1); } // 0xB4C8D77C80C0421E
	static Any _0xCD79A550999D7D4F(Any p0) { return invoke<Any>(0xCD79A550999D7D4F, p0); } // 0xCD79A550999D7D4F
	static Any _0xDAB963831DBFD3F4(Any p0, Any p1, Any p2, Any p3, Any p4) { return invoke<Any>(0xDAB963831DBFD3F4, p0, p1, p2, p3, p4); } // 0xDAB963831DBFD3F4
	static void _0xE4DCEC7FD5B739A5(Ped ped) { invoke<Void>(0xE4DCEC7FD5B739A5, ped); } // 0xE4DCEC7FD5B739A5
	static void _0xE620FD3512A04F18(float p0) { invoke<Void>(0xE620FD3512A04F18, p0); } // 0xE620FD3512A04F18
	static void _0xECDC202B25E5CF48(Player player, Any p1, BOOL p2) { invoke<Void>(0xECDC202B25E5CF48, player, p1, p2); } // 0xECDC202B25E5CF48
	static void _0xEFF296097FF1E509(Any p0, Any p1) { invoke<Void>(0xEFF296097FF1E509, p0, p1); } // 0xEFF296097FF1E509
	static Any _0xF0A60040BE558F2D(Any p0, Any p1, Any p2) { return invoke<Any>(0xF0A60040BE558F2D, p0, p1, p2); } // 0xF0A60040BE558F2D
	static BOOL _PED_SKIP_NEXT_RELOADING(Ped ped) { return invoke<BOOL>(0x8C0D57EA686FAD87, ped); } // 0x8C0D57EA686FAD87
	static void REMOVE_ALL_PED_WEAPONS(Ped ped, BOOL p1) { invoke<Void>(0xF25DF915FA38C5F3, ped, p1); } // 0xF25DF915FA38C5F3
	static void REMOVE_ALL_PROJECTILES_OF_TYPE(Hash weaponHash, BOOL p1) { invoke<Void>(0xFC52E0F37E446528, weaponHash, p1); } // 0xFC52E0F37E446528
	static void REMOVE_WEAPON_ASSET(Hash weaponHash) { invoke<Void>(0xAA08EF13F341C8FC, weaponHash); } // 0xAA08EF13F341C8FC
	static void REMOVE_WEAPON_COMPONENT_FROM_PED(Ped ped, Hash weaponHash, Hash componentHash) { invoke<Void>(0x1E8BE90C74FB4C09, ped, weaponHash, componentHash); } // 0x1E8BE90C74FB4C09
	static void REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT(Any p0, Any p1) { invoke<Void>(0xF7D82B0D66777611, p0, p1); } // 0xF7D82B0D66777611
	static void REMOVE_WEAPON_FROM_PED(Ped ped, Hash weaponHash) { invoke<Void>(0x4899CB088EDF59B8, ped, weaponHash); } // 0x4899CB088EDF59B8
	static void REQUEST_WEAPON_ASSET(Hash weaponHash, int p1, int p2) { invoke<Void>(0x5443438F033E29C3, weaponHash, p1, p2); } // 0x5443438F033E29C3
	static void REQUEST_WEAPON_HIGH_DETAIL_MODEL(Entity weaponObject) { invoke<Void>(0x48164DBB970AC3F0, weaponObject); } // 0x48164DBB970AC3F0
	static BOOL SET_AMMO_IN_CLIP(Ped ped, Hash weaponHash, int ammo) { return invoke<BOOL>(0xDCD2A934D65CB497, ped, weaponHash, ammo); } // 0xDCD2A934D65CB497
	static BOOL SET_CURRENT_PED_VEHICLE_WEAPON(Ped ped, Hash weaponHash) { return invoke<BOOL>(0x75C55983C2C39DAA, ped, weaponHash); } // 0x75C55983C2C39DAA
	static void SET_CURRENT_PED_WEAPON(Ped ped, Hash weaponHash, BOOL equipNow) { invoke<Void>(0xADF692B254977C0C, ped, weaponHash, equipNow); } // 0xADF692B254977C0C
	static Any SET_FLASH_LIGHT_FADE_DISTANCE(float distance) { return invoke<Any>(0xCEA66DAD478CD39B, distance); } // 0xCEA66DAD478CD39B
	static void SET_PED_AMMO(Ped ped, Hash weaponHash, int ammo) { invoke<Void>(0x14E56BC5B5DB6A19, ped, weaponHash, ammo); } // 0x14E56BC5B5DB6A19
	static void SET_PED_AMMO_BY_TYPE(Ped ped, Any ammoType, int ammo) { invoke<Void>(0x5FD1E1F011E76D7E, ped, ammoType, ammo); } // 0x5FD1E1F011E76D7E
	static void SET_PED_AMMO_TO_DROP(Any ammoType, int ammo) { invoke<Void>(0xA4EFEF9440A5B0EF, ammoType, ammo); } // 0xA4EFEF9440A5B0EF
	static void SET_PED_CHANCE_OF_FIRING_BLANKS(Ped ped, float xBias, float yBias) { invoke<Void>(0x8378627201D5497D, ped, xBias, yBias); } // 0x8378627201D5497D
	static void SET_PED_CURRENT_WEAPON_VISIBLE(Ped ped, BOOL visible, BOOL deselectWeapon, BOOL p3, BOOL p4) { invoke<Void>(0x725A4CCFDED9A70, ped, visible, deselectWeapon, p3, p4); } // 0x725A4CCFDED9A70
	static void SET_PED_DROPS_INVENTORY_WEAPON(Ped ped, Hash weaponHash, float xOffset, float yOffset, float zOffset, int ammoCount) { invoke<Void>(0x208A1888007FC0E6, ped, weaponHash, xOffset, yOffset, zOffset, ammoCount); } // 0x208A1888007FC0E6
	static void SET_PED_DROPS_WEAPON(Ped ped) { invoke<Void>(0x6B7513D9966FBEC0, ped); } // 0x6B7513D9966FBEC0
	static void SET_PED_DROPS_WEAPONS_WHEN_DEAD(Ped ped, BOOL toggle) { invoke<Void>(0x476AE72C1D19D1A8, ped, toggle); } // 0x476AE72C1D19D1A8
	static void SET_PED_GADGET(Ped ped, Hash gadgetHash, BOOL p2) { invoke<Void>(0xD0D7B1E680ED4A1A, ped, gadgetHash, p2); } // 0xD0D7B1E680ED4A1A
	static void SET_PED_INFINITE_AMMO(Ped ped, BOOL toggle, Hash weaponHash) { invoke<Void>(0x3EDCB0505123623B, ped, toggle, weaponHash); } // 0x3EDCB0505123623B
	static void SET_PED_INFINITE_AMMO_CLIP(Ped ped, BOOL toggle) { invoke<Void>(0x183DADC6AA953186, ped, toggle); } // 0x183DADC6AA953186
	static void SET_PED_WEAPON_TINT_INDEX(Ped ped, Hash weaponHash, int tintIndex) { invoke<Void>(0x50969B9B89ED5738, ped, weaponHash, tintIndex); } // 0x50969B9B89ED5738
	static void SET_WEAPON_ANIMATION_OVERRIDE(Ped ped, Hash animStyle) { invoke<Void>(0x1055AC3A667F09D9, ped, animStyle); } // 0x1055AC3A667F09D9
	static void SET_WEAPON_OBJECT_TINT_INDEX(Object weapon, int tintIndex) { invoke<Void>(0xF827589017D4E4A9, weapon, tintIndex); } // 0xF827589017D4E4A9
	static BOOL SET_WEAPON_SMOKEGRENADE_ASSIGNED(Ped ped) { return invoke<BOOL>(0x4B7620C47217126C, ped); } // 0x4B7620C47217126C
}

namespace ZONE
{
	static void CLEAR_POPSCHEDULE_OVERRIDE_VEHICLE_MODEL(int scheduleId) { invoke<Void>(0x5C0DE367AA0D911C, scheduleId); } // 0x5C0DE367AA0D911C
	static Hash GET_HASH_OF_MAP_AREA_AT_COORDS(float x, float y, float z) { return invoke<Hash>(0x7EE64D51E8498728, x, y, z); } // 0x7EE64D51E8498728
	static char* GET_NAME_OF_ZONE(float x, float y, float z) { return invoke<char*>(0xCD90657D4C30E1CA, x, y, z); } // 0xCD90657D4C30E1CA
	static int GET_ZONE_AT_COORDS(float x, float y, float z) { return invoke<int>(0x27040C25DE6CB2F4, x, y, z); } // 0x27040C25DE6CB2F4
	static int GET_ZONE_FROM_NAME_ID(char* zoneName) { return invoke<int>(0x98CD1D2934B76CC1, zoneName); } // 0x98CD1D2934B76CC1
	static int GET_ZONE_POPSCHEDULE(int zoneId) { return invoke<int>(0x4334BC40AA0CB4BB, zoneId); } // 0x4334BC40AA0CB4BB
	static int GET_ZONE_SCUMMINESS(int zoneId) { return invoke<int>(0x5F7B268D15BA0739, zoneId); } // 0x5F7B268D15BA0739
	static void OVERRIDE_POPSCHEDULE_VEHICLE_MODEL(int scheduleId, Hash vehicleHash) { invoke<Void>(0x5F7D596BAC2E7777, scheduleId, vehicleHash); } // 0x5F7D596BAC2E7777
	static void SET_ZONE_ENABLED(int zoneId, BOOL toggle) { invoke<Void>(0xBA5ECEEA120E5611, zoneId, toggle); } // 0xBA5ECEEA120E5611
}

