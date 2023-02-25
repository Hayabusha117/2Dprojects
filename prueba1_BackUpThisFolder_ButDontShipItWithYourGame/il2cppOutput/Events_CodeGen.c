#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Void GameEvent::Raise()
extern void GameEvent_Raise_m3DBD220C352DF019976B011F0A2B59871077E01D (void);
// 0x00000002 System.Void GameEvent::RegisterListener(GameEventListener)
extern void GameEvent_RegisterListener_m77836E09D65F957F48BE2C3D10960CE5962549F9 (void);
// 0x00000003 System.Void GameEvent::UnregisterListener(GameEventListener)
extern void GameEvent_UnregisterListener_m9D7977148A380F83CC421B51A2E3A0A9ACD70D47 (void);
// 0x00000004 System.Void GameEvent::.ctor()
extern void GameEvent__ctor_m317005E0CF966C75CF825D6CA3A65F95C6F53427 (void);
// 0x00000005 System.Void GameEventListener::OnEventRise()
extern void GameEventListener_OnEventRise_m9F09BC58A8489653346DE2E2803AC720ECA61E2D (void);
// 0x00000006 System.Void GameEventListener::OnEnable()
extern void GameEventListener_OnEnable_m209BF772E0406B2A6C0529C6D6EA3EE59848BB5E (void);
// 0x00000007 System.Void GameEventListener::OnDisable()
extern void GameEventListener_OnDisable_m4CAAEB809D13B09294D97BF4AAE3B5513ECC5840 (void);
// 0x00000008 System.Void GameEventListener::.ctor()
extern void GameEventListener__ctor_mED5D3D479403D020281DE1305E4DFD5EACD25901 (void);
static Il2CppMethodPointer s_methodPointers[8] = 
{
	GameEvent_Raise_m3DBD220C352DF019976B011F0A2B59871077E01D,
	GameEvent_RegisterListener_m77836E09D65F957F48BE2C3D10960CE5962549F9,
	GameEvent_UnregisterListener_m9D7977148A380F83CC421B51A2E3A0A9ACD70D47,
	GameEvent__ctor_m317005E0CF966C75CF825D6CA3A65F95C6F53427,
	GameEventListener_OnEventRise_m9F09BC58A8489653346DE2E2803AC720ECA61E2D,
	GameEventListener_OnEnable_m209BF772E0406B2A6C0529C6D6EA3EE59848BB5E,
	GameEventListener_OnDisable_m4CAAEB809D13B09294D97BF4AAE3B5513ECC5840,
	GameEventListener__ctor_mED5D3D479403D020281DE1305E4DFD5EACD25901,
};
static const int32_t s_InvokerIndices[8] = 
{
	5295,
	4231,
	4231,
	5295,
	5295,
	5295,
	5295,
	5295,
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_Events_CodeGenModule;
const Il2CppCodeGenModule g_Events_CodeGenModule = 
{
	"Events.dll",
	8,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
