#include "Natives.h"

void CryV::Natives::SetPos()
{
    ENTITY::SET_ENTITY_COORDS_NO_OFFSET(PLAYER::PLAYER_PED_ID(), 412.4f, -976.71f, 29.43f, false, false, false);
}
