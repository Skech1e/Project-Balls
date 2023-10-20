#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


struct InvokerActionInvoker0
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj)
	{
		method->invoker_method(methodPtr, method, obj, NULL, NULL);
	}
};
template <typename T1>
struct InvokerActionInvoker1;
template <typename T1>
struct InvokerActionInvoker1<T1*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1)
	{
		void* params[1] = { p1 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename R>
struct InvokerFuncInvoker0
{
	static inline R Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj)
	{
		R ret;
		method->invoker_method(methodPtr, method, obj, NULL, &ret);
		return ret;
	}
};
template <typename R, typename T1>
struct InvokerFuncInvoker1;
template <typename R, typename T1>
struct InvokerFuncInvoker1<R, T1*>
{
	static inline R Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1)
	{
		R ret;
		void* params[1] = { p1 };
		method->invoker_method(methodPtr, method, obj, params, &ret);
		return ret;
	}
};

// System.Action`1<UnityEngine.Color>
struct Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22;
// System.Action`1<System.Object>
struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87;
// System.Action`1<System.Single>
struct Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A;
// System.Action`1<UnityEngine.Vector2>
struct Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81;
// System.Action`1<UnityEngine.Vector3>
struct Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2;
// System.Action`2<UnityEngine.Color,System.Object>
struct Action_2_tA6305A40DF06ED5230D130F9BFFB7DFF81760FF3;
// System.Action`2<System.Single,System.Object>
struct Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10;
// System.Action`2<System.Single,System.Single>
struct Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132;
// System.Action`2<UnityEngine.Vector3,System.Object>
struct Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// LTBezier[]
struct LTBezierU5BU5D_tE338191DD1D06AE454F8D59FF13813B7114729FE;
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;
// UnityEngine.Sprite[]
struct SpriteU5BU5D_tCEE379E10CAD9DBFA770B331480592548ED0EA1B;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07;
// UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// UnityEngine.GUIStyle
struct GUIStyle_t20BA2F9F3FE9D13AAA607EEEBE5547835A6F6580;
// UnityEngine.UI.Image
struct Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E;
// LTBezierPath
struct LTBezierPath_t7D7955285591E2EC13CB9D6AD709DECD0662D9E8;
// LTDescr
struct LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119;
// LTDescrOptional
struct LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99;
// LTRect
struct LTRect_t66D96FDF103E1EBFDF64D310099E6792B10F48C4;
// LTSeq
struct LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE;
// LTSpline
struct LTSpline_tBB800424387D68FA0CA376A5C5B465878D83AE51;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.UI.RawImage
struct RawImage_tFF12F7DB574FBDC1863CF607C7A12A5D9F8D6179;
// UnityEngine.RectTransform
struct RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5;
// UnityEngine.SpriteRenderer
struct SpriteRenderer_t1DD7FE258F072E1FA87D6577BA27225892B8047B;
// System.String
struct String_t;
// UnityEngine.UI.Text
struct Text_tD60B2346DAA6666BF0D822FF607F0B220C2B9E62;
// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// LTDescr/<>c
struct U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE;
// LTDescr/ActionMethodDelegate
struct ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7;
// LTDescr/EaseTypeDelegate
struct EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B;

IL2CPP_EXTERN_C RuntimeClass* LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;

struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
struct Il2CppArrayBounds;

// LTBezierPath
struct LTBezierPath_t7D7955285591E2EC13CB9D6AD709DECD0662D9E8  : public RuntimeObject
{
	// UnityEngine.Vector3[] LTBezierPath::pts
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___pts_0;
	// System.Single LTBezierPath::length
	float ___length_1;
	// System.Boolean LTBezierPath::orientToPath
	bool ___orientToPath_2;
	// System.Boolean LTBezierPath::orientToPath2d
	bool ___orientToPath2d_3;
	// LTBezier[] LTBezierPath::beziers
	LTBezierU5BU5D_tE338191DD1D06AE454F8D59FF13813B7114729FE* ___beziers_4;
	// System.Single[] LTBezierPath::lengthRatio
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___lengthRatio_5;
	// System.Int32 LTBezierPath::currentBezier
	int32_t ___currentBezier_6;
	// System.Int32 LTBezierPath::previousBezier
	int32_t ___previousBezier_7;
};

// LTSeq
struct LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE  : public RuntimeObject
{
	// LTSeq LTSeq::previous
	LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE* ___previous_0;
	// LTSeq LTSeq::current
	LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE* ___current_1;
	// LTDescr LTSeq::tween
	LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119* ___tween_2;
	// System.Single LTSeq::totalDelay
	float ___totalDelay_3;
	// System.Single LTSeq::timeScale
	float ___timeScale_4;
	// System.Int32 LTSeq::debugIter
	int32_t ___debugIter_5;
	// System.UInt32 LTSeq::counter
	uint32_t ___counter_6;
	// System.Boolean LTSeq::toggle
	bool ___toggle_7;
	// System.UInt32 LTSeq::_id
	uint32_t ____id_8;
};

// LTSpline
struct LTSpline_tBB800424387D68FA0CA376A5C5B465878D83AE51  : public RuntimeObject
{
	// System.Single LTSpline::distance
	float ___distance_2;
	// System.Boolean LTSpline::constantSpeed
	bool ___constantSpeed_3;
	// UnityEngine.Vector3[] LTSpline::pts
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___pts_4;
	// UnityEngine.Vector3[] LTSpline::ptsAdj
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___ptsAdj_5;
	// System.Int32 LTSpline::ptsAdjLength
	int32_t ___ptsAdjLength_6;
	// System.Boolean LTSpline::orientToPath
	bool ___orientToPath_7;
	// System.Boolean LTSpline::orientToPath2d
	bool ___orientToPath2d_8;
	// System.Int32 LTSpline::numSections
	int32_t ___numSections_9;
	// System.Int32 LTSpline::currPt
	int32_t ___currPt_10;
};

struct LTSpline_tBB800424387D68FA0CA376A5C5B465878D83AE51_StaticFields
{
	// System.Int32 LTSpline::DISTANCE_COUNT
	int32_t ___DISTANCE_COUNT_0;
	// System.Int32 LTSpline::SUBLINE_COUNT
	int32_t ___SUBLINE_COUNT_1;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// LTDescr/<>c
struct U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE  : public RuntimeObject
{
};

struct U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE_StaticFields
{
	// LTDescr/<>c LTDescr/<>c::<>9
	U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE* ___U3CU3E9_0;
	// LTDescr/ActionMethodDelegate LTDescr/<>c::<>9__113_0
	ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* ___U3CU3E9__113_0_1;
	// LTDescr/ActionMethodDelegate LTDescr/<>c::<>9__114_0
	ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* ___U3CU3E9__114_0_2;
};

// UnityEngine.Color
struct Color_tD001788D726C3A7F1379BEED0260B9591F440C1F 
{
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// UnityEngine.Quaternion
struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 
{
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;
};

struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_StaticFields
{
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___identityQuaternion_4;
};

// UnityEngine.Rect
struct Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D 
{
	// System.Single UnityEngine.Rect::m_XMin
	float ___m_XMin_0;
	// System.Single UnityEngine.Rect::m_YMin
	float ___m_YMin_1;
	// System.Single UnityEngine.Rect::m_Width
	float ___m_Width_2;
	// System.Single UnityEngine.Rect::m_Height
	float ___m_Height_3;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// System.UInt32
struct UInt32_t1833D51FFA667B18A5AA4B8D34DE284F8495D29B 
{
	// System.UInt32 System.UInt32::m_value
	uint32_t ___m_value_0;
};

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 
{
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;
};

struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields
{
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___negativeInfinityVector_9;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354  : public RuntimeObject
{
	// System.IntPtr UnityEngine.AnimationCurve::m_Ptr
	intptr_t ___m_Ptr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// LTDescr
struct LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119  : public RuntimeObject
{
	// System.Boolean LTDescr::toggle
	bool ___toggle_0;
	// System.Boolean LTDescr::useEstimatedTime
	bool ___useEstimatedTime_1;
	// System.Boolean LTDescr::useFrames
	bool ___useFrames_2;
	// System.Boolean LTDescr::useManualTime
	bool ___useManualTime_3;
	// System.Boolean LTDescr::usesNormalDt
	bool ___usesNormalDt_4;
	// System.Boolean LTDescr::hasInitiliazed
	bool ___hasInitiliazed_5;
	// System.Boolean LTDescr::hasExtraOnCompletes
	bool ___hasExtraOnCompletes_6;
	// System.Boolean LTDescr::hasPhysics
	bool ___hasPhysics_7;
	// System.Boolean LTDescr::onCompleteOnRepeat
	bool ___onCompleteOnRepeat_8;
	// System.Boolean LTDescr::onCompleteOnStart
	bool ___onCompleteOnStart_9;
	// System.Boolean LTDescr::useRecursion
	bool ___useRecursion_10;
	// System.Single LTDescr::ratioPassed
	float ___ratioPassed_11;
	// System.Single LTDescr::passed
	float ___passed_12;
	// System.Single LTDescr::delay
	float ___delay_13;
	// System.Single LTDescr::time
	float ___time_14;
	// System.Single LTDescr::speed
	float ___speed_15;
	// System.Single LTDescr::lastVal
	float ___lastVal_16;
	// System.UInt32 LTDescr::_id
	uint32_t ____id_17;
	// System.Int32 LTDescr::loopCount
	int32_t ___loopCount_18;
	// System.UInt32 LTDescr::counter
	uint32_t ___counter_19;
	// System.Single LTDescr::direction
	float ___direction_20;
	// System.Single LTDescr::directionLast
	float ___directionLast_21;
	// System.Single LTDescr::overshoot
	float ___overshoot_22;
	// System.Single LTDescr::period
	float ___period_23;
	// System.Single LTDescr::scale
	float ___scale_24;
	// System.Boolean LTDescr::destroyOnComplete
	bool ___destroyOnComplete_25;
	// UnityEngine.Transform LTDescr::trans
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans_26;
	// UnityEngine.Vector3 LTDescr::fromInternal
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___fromInternal_27;
	// UnityEngine.Vector3 LTDescr::toInternal
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___toInternal_28;
	// UnityEngine.Vector3 LTDescr::diff
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___diff_29;
	// UnityEngine.Vector3 LTDescr::diffDiv2
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___diffDiv2_30;
	// TweenAction LTDescr::type
	int32_t ___type_31;
	// LeanTweenType LTDescr::easeType
	int32_t ___easeType_32;
	// LeanTweenType LTDescr::loopType
	int32_t ___loopType_33;
	// System.Boolean LTDescr::hasUpdateCallback
	bool ___hasUpdateCallback_34;
	// LTDescr/EaseTypeDelegate LTDescr::easeMethod
	EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* ___easeMethod_35;
	// LTDescr/ActionMethodDelegate LTDescr::<easeInternal>k__BackingField
	ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* ___U3CeaseInternalU3Ek__BackingField_36;
	// LTDescr/ActionMethodDelegate LTDescr::<initInternal>k__BackingField
	ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* ___U3CinitInternalU3Ek__BackingField_37;
	// UnityEngine.SpriteRenderer LTDescr::spriteRen
	SpriteRenderer_t1DD7FE258F072E1FA87D6577BA27225892B8047B* ___spriteRen_38;
	// UnityEngine.RectTransform LTDescr::rectTransform
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___rectTransform_39;
	// UnityEngine.UI.Text LTDescr::uiText
	Text_tD60B2346DAA6666BF0D822FF607F0B220C2B9E62* ___uiText_40;
	// UnityEngine.UI.Image LTDescr::uiImage
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___uiImage_41;
	// UnityEngine.UI.RawImage LTDescr::rawImage
	RawImage_tFF12F7DB574FBDC1863CF607C7A12A5D9F8D6179* ___rawImage_42;
	// UnityEngine.Sprite[] LTDescr::sprites
	SpriteU5BU5D_tCEE379E10CAD9DBFA770B331480592548ED0EA1B* ___sprites_43;
	// LTDescrOptional LTDescr::_optional
	LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* ____optional_44;
};

struct LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_StaticFields
{
	// System.Single LTDescr::val
	float ___val_45;
	// System.Single LTDescr::dt
	float ___dt_46;
	// UnityEngine.Vector3 LTDescr::newVect
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___newVect_47;
};

// LTDescrOptional
struct LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99  : public RuntimeObject
{
	// UnityEngine.Transform LTDescrOptional::<toTrans>k__BackingField
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___U3CtoTransU3Ek__BackingField_0;
	// UnityEngine.Vector3 LTDescrOptional::<point>k__BackingField
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___U3CpointU3Ek__BackingField_1;
	// UnityEngine.Vector3 LTDescrOptional::<axis>k__BackingField
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___U3CaxisU3Ek__BackingField_2;
	// System.Single LTDescrOptional::<lastVal>k__BackingField
	float ___U3ClastValU3Ek__BackingField_3;
	// UnityEngine.Quaternion LTDescrOptional::<origRotation>k__BackingField
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___U3CorigRotationU3Ek__BackingField_4;
	// LTBezierPath LTDescrOptional::<path>k__BackingField
	LTBezierPath_t7D7955285591E2EC13CB9D6AD709DECD0662D9E8* ___U3CpathU3Ek__BackingField_5;
	// LTSpline LTDescrOptional::<spline>k__BackingField
	LTSpline_tBB800424387D68FA0CA376A5C5B465878D83AE51* ___U3CsplineU3Ek__BackingField_6;
	// UnityEngine.AnimationCurve LTDescrOptional::animationCurve
	AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* ___animationCurve_7;
	// System.Int32 LTDescrOptional::initFrameCount
	int32_t ___initFrameCount_8;
	// UnityEngine.Color LTDescrOptional::color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color_9;
	// LTRect LTDescrOptional::<ltRect>k__BackingField
	LTRect_t66D96FDF103E1EBFDF64D310099E6792B10F48C4* ___U3CltRectU3Ek__BackingField_10;
	// System.Action`1<System.Single> LTDescrOptional::<onUpdateFloat>k__BackingField
	Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* ___U3ConUpdateFloatU3Ek__BackingField_11;
	// System.Action`2<System.Single,System.Single> LTDescrOptional::<onUpdateFloatRatio>k__BackingField
	Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* ___U3ConUpdateFloatRatioU3Ek__BackingField_12;
	// System.Action`2<System.Single,System.Object> LTDescrOptional::<onUpdateFloatObject>k__BackingField
	Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* ___U3ConUpdateFloatObjectU3Ek__BackingField_13;
	// System.Action`1<UnityEngine.Vector2> LTDescrOptional::<onUpdateVector2>k__BackingField
	Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* ___U3ConUpdateVector2U3Ek__BackingField_14;
	// System.Action`1<UnityEngine.Vector3> LTDescrOptional::<onUpdateVector3>k__BackingField
	Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* ___U3ConUpdateVector3U3Ek__BackingField_15;
	// System.Action`2<UnityEngine.Vector3,System.Object> LTDescrOptional::<onUpdateVector3Object>k__BackingField
	Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* ___U3ConUpdateVector3ObjectU3Ek__BackingField_16;
	// System.Action`1<UnityEngine.Color> LTDescrOptional::<onUpdateColor>k__BackingField
	Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22* ___U3ConUpdateColorU3Ek__BackingField_17;
	// System.Action`2<UnityEngine.Color,System.Object> LTDescrOptional::<onUpdateColorObject>k__BackingField
	Action_2_tA6305A40DF06ED5230D130F9BFFB7DFF81760FF3* ___U3ConUpdateColorObjectU3Ek__BackingField_18;
	// System.Action LTDescrOptional::<onComplete>k__BackingField
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___U3ConCompleteU3Ek__BackingField_19;
	// System.Action`1<System.Object> LTDescrOptional::<onCompleteObject>k__BackingField
	Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___U3ConCompleteObjectU3Ek__BackingField_20;
	// System.Object LTDescrOptional::<onCompleteParam>k__BackingField
	RuntimeObject* ___U3ConCompleteParamU3Ek__BackingField_21;
	// System.Object LTDescrOptional::<onUpdateParam>k__BackingField
	RuntimeObject* ___U3ConUpdateParamU3Ek__BackingField_22;
	// System.Action LTDescrOptional::<onStart>k__BackingField
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___U3ConStartU3Ek__BackingField_23;
};

// LTRect
struct LTRect_t66D96FDF103E1EBFDF64D310099E6792B10F48C4  : public RuntimeObject
{
	// UnityEngine.Rect LTRect::_rect
	Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D ____rect_0;
	// System.Single LTRect::alpha
	float ___alpha_1;
	// System.Single LTRect::rotation
	float ___rotation_2;
	// UnityEngine.Vector2 LTRect::pivot
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___pivot_3;
	// UnityEngine.Vector2 LTRect::margin
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___margin_4;
	// UnityEngine.Rect LTRect::relativeRect
	Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D ___relativeRect_5;
	// System.Boolean LTRect::rotateEnabled
	bool ___rotateEnabled_6;
	// System.Boolean LTRect::rotateFinished
	bool ___rotateFinished_7;
	// System.Boolean LTRect::alphaEnabled
	bool ___alphaEnabled_8;
	// System.String LTRect::labelStr
	String_t* ___labelStr_9;
	// LTGUI/Element_Type LTRect::type
	int32_t ___type_10;
	// UnityEngine.GUIStyle LTRect::style
	GUIStyle_t20BA2F9F3FE9D13AAA607EEEBE5547835A6F6580* ___style_11;
	// System.Boolean LTRect::useColor
	bool ___useColor_12;
	// UnityEngine.Color LTRect::color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color_13;
	// System.Boolean LTRect::fontScaleToFit
	bool ___fontScaleToFit_14;
	// System.Boolean LTRect::useSimpleScale
	bool ___useSimpleScale_15;
	// System.Boolean LTRect::sizeByHeight
	bool ___sizeByHeight_16;
	// UnityEngine.Texture LTRect::texture
	Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___texture_17;
	// System.Int32 LTRect::_id
	int32_t ____id_18;
	// System.Int32 LTRect::counter
	int32_t ___counter_19;
};

struct LTRect_t66D96FDF103E1EBFDF64D310099E6792B10F48C4_StaticFields
{
	// System.Boolean LTRect::colorTouched
	bool ___colorTouched_20;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};

struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// System.Action`1<UnityEngine.Color>
struct Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22  : public MulticastDelegate_t
{
};

// System.Action`1<System.Object>
struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87  : public MulticastDelegate_t
{
};

// System.Action`1<System.Single>
struct Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A  : public MulticastDelegate_t
{
};

// System.Action`1<UnityEngine.Vector2>
struct Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81  : public MulticastDelegate_t
{
};

// System.Action`1<UnityEngine.Vector3>
struct Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2  : public MulticastDelegate_t
{
};

// System.Action`2<UnityEngine.Color,System.Object>
struct Action_2_tA6305A40DF06ED5230D130F9BFFB7DFF81760FF3  : public MulticastDelegate_t
{
};

// System.Action`2<System.Single,System.Object>
struct Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10  : public MulticastDelegate_t
{
};

// System.Action`2<System.Single,System.Single>
struct Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132  : public MulticastDelegate_t
{
};

// System.Action`2<UnityEngine.Vector3,System.Object>
struct Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C  : public MulticastDelegate_t
{
};

// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07  : public MulticastDelegate_t
{
};

// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// LTDescr/ActionMethodDelegate
struct ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7  : public MulticastDelegate_t
{
};

// LTDescr/EaseTypeDelegate
struct EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B  : public MulticastDelegate_t
{
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// System.Void System.Action`1<System.Single>::Invoke(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_mA8F89FB04FEA0F48A4F22EC84B5F9ADB2914341F_gshared_inline (Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* __this, float ___obj0, const RuntimeMethod* method) ;
// System.Void System.Action`2<System.Single,System.Single>::Invoke(T1,T2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_2_Invoke_m50A62593A87E11ED31B47FE46E633AB3B9A7666C_gshared_inline (Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* __this, float ___arg10, float ___arg21, const RuntimeMethod* method) ;
// System.Void System.Action`2<System.Single,System.Object>::Invoke(T1,T2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_2_Invoke_m9E7863E85E4D6B6D0C7F731513A8ECC8139FE626_gshared_inline (Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* __this, float ___arg10, RuntimeObject* ___arg21, const RuntimeMethod* method) ;
// System.Void System.Action`2<UnityEngine.Vector3,System.Object>::Invoke(T1,T2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_2_Invoke_m719475FEF89235EA7C17D75BF384DE2B9545839B_gshared_inline (Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___arg10, RuntimeObject* ___arg21, const RuntimeMethod* method) ;
// System.Void System.Action`1<UnityEngine.Vector3>::Invoke(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_m211AB6C2AA7326F6BFC8338EC888360A219AFF41_gshared_inline (Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___obj0, const RuntimeMethod* method) ;
// System.Void System.Action`1<UnityEngine.Vector2>::Invoke(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_m3C60C84018CAD36C0EC956A14935394A7DD116C6_gshared_inline (Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___obj0, const RuntimeMethod* method) ;

// System.Void LTDescr/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m53B9D2F26C5D0C2EBC3EEFC0CC427621A992AC8F (U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE* __this, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onUpdateFloat(System.Action`1<System.Single>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateFloat_m4BCEBD8B8D19487198954284ADB77EF98BA832DF_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onUpdateFloatRatio(System.Action`2<System.Single,System.Single>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateFloatRatio_m13C68440F2DD889D21A63A88607F0A53B087EAF1_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onUpdateVector2(System.Action`1<UnityEngine.Vector2>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateVector2_m65877391CC63F7918C116B939098F74C8153867C_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onUpdateVector3(System.Action`1<UnityEngine.Vector3>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateVector3_mF5528C641054AF6D5570F4C521B97399377BB714_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onUpdateFloatObject(System.Action`2<System.Single,System.Object>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateFloatObject_m9173548CA04A36CE51944DC2F6B3D9AFB615583B_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onUpdateVector3Object(System.Action`2<UnityEngine.Vector3,System.Object>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateVector3Object_mA6A20E33951345E524C678126849ABC7BDBAACCB_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onUpdateColor(System.Action`1<UnityEngine.Color>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateColor_mBE1BC44C9B9A46AE55C7EF4CD31B8AFE98B96AFA_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onComplete(System.Action)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onComplete_m96FFEFD7789ADFA64EE6FD2AF845D9B6BD451798_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onCompleteObject(System.Action`1<System.Object>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onCompleteObject_m3F13DA5092A613749482AFEA8616C50985FAB6BA_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onCompleteParam(System.Object)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onCompleteParam_m62AFA92B070D830600EC7C2FAC58BF58B24C9402_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, RuntimeObject* ___value0, const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_onStart(System.Action)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onStart_mA3D18F65D8268F7EA4AE03CFF2F113F052AFB71D_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___value0, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline (const RuntimeMethod* method) ;
// System.Void LTDescrOptional::set_point(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_point_m58D1986651D5F3479B0C39B2BEFDB9986CF5F621_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___value0, const RuntimeMethod* method) ;
// System.Action`1<System.Single> LTDescrOptional::get_onUpdateFloat()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* LTDescrOptional_get_onUpdateFloat_m072498872BEA06E4F4C3F6F841F98F450A993912_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) ;
// System.Void System.Action`1<System.Single>::Invoke(T)
inline void Action_1_Invoke_mA8F89FB04FEA0F48A4F22EC84B5F9ADB2914341F_inline (Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* __this, float ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A*, float, const RuntimeMethod*))Action_1_Invoke_mA8F89FB04FEA0F48A4F22EC84B5F9ADB2914341F_gshared_inline)(__this, ___obj0, method);
}
// System.Action`2<System.Single,System.Single> LTDescrOptional::get_onUpdateFloatRatio()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* LTDescrOptional_get_onUpdateFloatRatio_m67A16BB3C211324DE40E1F748B2C3A2B9F424043_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) ;
// System.Void System.Action`2<System.Single,System.Single>::Invoke(T1,T2)
inline void Action_2_Invoke_m50A62593A87E11ED31B47FE46E633AB3B9A7666C_inline (Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* __this, float ___arg10, float ___arg21, const RuntimeMethod* method)
{
	((  void (*) (Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132*, float, float, const RuntimeMethod*))Action_2_Invoke_m50A62593A87E11ED31B47FE46E633AB3B9A7666C_gshared_inline)(__this, ___arg10, ___arg21, method);
}
// System.Action`2<System.Single,System.Object> LTDescrOptional::get_onUpdateFloatObject()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* LTDescrOptional_get_onUpdateFloatObject_m4491FDBDA0B266B51D9598D44D86E8C21A57C696_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) ;
// System.Object LTDescrOptional::get_onUpdateParam()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* LTDescrOptional_get_onUpdateParam_mC0BAFEB0A9FA8DCD7C1BF69729A933ACB035E5D1_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) ;
// System.Void System.Action`2<System.Single,System.Object>::Invoke(T1,T2)
inline void Action_2_Invoke_m9E7863E85E4D6B6D0C7F731513A8ECC8139FE626_inline (Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* __this, float ___arg10, RuntimeObject* ___arg21, const RuntimeMethod* method)
{
	((  void (*) (Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10*, float, RuntimeObject*, const RuntimeMethod*))Action_2_Invoke_m9E7863E85E4D6B6D0C7F731513A8ECC8139FE626_gshared_inline)(__this, ___arg10, ___arg21, method);
}
// System.Action`2<UnityEngine.Vector3,System.Object> LTDescrOptional::get_onUpdateVector3Object()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* LTDescrOptional_get_onUpdateVector3Object_mED8D03633DF1E94683600AF1835E146F1D83DB91_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) ;
// System.Void System.Action`2<UnityEngine.Vector3,System.Object>::Invoke(T1,T2)
inline void Action_2_Invoke_m719475FEF89235EA7C17D75BF384DE2B9545839B_inline (Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___arg10, RuntimeObject* ___arg21, const RuntimeMethod* method)
{
	((  void (*) (Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, RuntimeObject*, const RuntimeMethod*))Action_2_Invoke_m719475FEF89235EA7C17D75BF384DE2B9545839B_gshared_inline)(__this, ___arg10, ___arg21, method);
}
// System.Action`1<UnityEngine.Vector3> LTDescrOptional::get_onUpdateVector3()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* LTDescrOptional_get_onUpdateVector3_m44FF421248177E984AE7B15DA68CC8060A895574_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) ;
// System.Void System.Action`1<UnityEngine.Vector3>::Invoke(T)
inline void Action_1_Invoke_m211AB6C2AA7326F6BFC8338EC888360A219AFF41_inline (Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, const RuntimeMethod*))Action_1_Invoke_m211AB6C2AA7326F6BFC8338EC888360A219AFF41_gshared_inline)(__this, ___obj0, method);
}
// System.Action`1<UnityEngine.Vector2> LTDescrOptional::get_onUpdateVector2()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* LTDescrOptional_get_onUpdateVector2_mCE0D193D519DC1F030232347E200E30F38650796_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___x0, float ___y1, const RuntimeMethod* method) ;
// System.Void System.Action`1<UnityEngine.Vector2>::Invoke(T)
inline void Action_1_Invoke_m3C60C84018CAD36C0EC956A14935394A7DD116C6_inline (Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81*, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7, const RuntimeMethod*))Action_1_Invoke_m3C60C84018CAD36C0EC956A14935394A7DD116C6_gshared_inline)(__this, ___obj0, method);
}
// System.Void LTSeq::reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTSeq_reset_mEAFCB13DCA94562FA8CE36476D8985C3204A5AF8 (LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE* __this, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1_Multicast(EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* __this, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 retVal;
	memset((&retVal), 0, sizeof(retVal));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* currentDelegate = reinterpret_cast<EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B*>(delegatesToInvoke[i]);
		typedef Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
		retVal = ((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
	return retVal;
}
Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1_OpenInst(EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* __this, const RuntimeMethod* method)
{
	typedef Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 (*FunctionPointerType) (const RuntimeMethod*);
	return ((FunctionPointerType)__this->___method_ptr_0)(method);
}
Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1_OpenStatic(EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* __this, const RuntimeMethod* method)
{
	typedef Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 (*FunctionPointerType) (const RuntimeMethod*);
	return ((FunctionPointerType)__this->___method_ptr_0)(method);
}
Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1_OpenStaticInvoker(EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* __this, const RuntimeMethod* method)
{
	return InvokerFuncInvoker0< Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 >::Invoke(__this->___method_ptr_0, method, NULL);
}
Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1_ClosedStaticInvoker(EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* __this, const RuntimeMethod* method)
{
	return InvokerFuncInvoker1< Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, RuntimeObject* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2);
}
IL2CPP_EXTERN_C  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 DelegatePInvokeWrapper_EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B (EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* __this, const RuntimeMethod* method)
{
	typedef Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 returnValue = il2cppPInvokeFunc();

	return returnValue;
}
// System.Void LTDescr/EaseTypeDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EaseTypeDelegate__ctor_m14E7AA6C59AE0914CCDC841460F3715723A5A2F3 (EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 0;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		if (___object0 == NULL)
			il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1_Multicast;
}
// UnityEngine.Vector3 LTDescr/EaseTypeDelegate::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 EaseTypeDelegate_Invoke_m5C409F991CB38F8CF8B39E83A82391D17473F2E1 (EaseTypeDelegate_tD483AAE963FA644C101F6EC8461CF2778A64C43B* __this, const RuntimeMethod* method) 
{
	typedef Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	return ((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331_Multicast(ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* __this, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* currentDelegate = reinterpret_cast<ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331_OpenInst(ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331_OpenStatic(ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331_OpenStaticInvoker(ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker0::Invoke(__this->___method_ptr_0, method, NULL);
}
void ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331_ClosedStaticInvoker(ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker1< RuntimeObject* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7 (ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void LTDescr/ActionMethodDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ActionMethodDelegate__ctor_m4F638865F24CDA31594ACAF18453C2DA0D2BFA64 (ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 0;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		if (___object0 == NULL)
			il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331_Multicast;
}
// System.Void LTDescr/ActionMethodDelegate::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ActionMethodDelegate_Invoke_m65ED7B3D2B697978C2AF74E2401C178F57EC1331 (ActionMethodDelegate_t191EA56C293C88D72225C23FBC80C4DA82B5AFA7* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void LTDescr/<>c::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_m645BD05F9864A4128475985F87FB5E5810EA2604 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE* L_0 = (U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE*)il2cpp_codegen_object_new(U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__ctor_m53B9D2F26C5D0C2EBC3EEFC0CC427621A992AC8F(L_0, NULL);
		((U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE_il2cpp_TypeInfo_var))->___U3CU3E9_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE_il2cpp_TypeInfo_var))->___U3CU3E9_0), (void*)L_0);
		return;
	}
}
// System.Void LTDescr/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m53B9D2F26C5D0C2EBC3EEFC0CC427621A992AC8F (U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Void LTDescr/<>c::<setCallback>b__113_0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec_U3CsetCallbackU3Eb__113_0_m1D6948041C2A4B4EDD53C429A72C5671FB4E73DE (U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE* __this, const RuntimeMethod* method) 
{
	{
		// this.initInternal = ()=>{};
		return;
	}
}
// System.Void LTDescr/<>c::<setValue3>b__114_0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec_U3CsetValue3U3Eb__114_0_m4DA91B2A9C06B395A1A58527C9C9C80BBC9F3F13 (U3CU3Ec_tDAD88E3A7623BD840DCD00E8C5C8655C748A59FE* __this, const RuntimeMethod* method) 
{
	{
		// this.initInternal = ()=>{};
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Transform LTDescrOptional::get_toTrans()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* LTDescrOptional_get_toTrans_mDB0821725712626B68F44246D37C8779F0F37984 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Transform toTrans { get; set; }
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0 = __this->___U3CtoTransU3Ek__BackingField_0;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_toTrans(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_toTrans_m0B281A3201DE3F0299C3AB456DAAB81933D0A281 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___value0, const RuntimeMethod* method) 
{
	{
		// public Transform toTrans { get; set; }
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0 = ___value0;
		__this->___U3CtoTransU3Ek__BackingField_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CtoTransU3Ek__BackingField_0), (void*)L_0);
		return;
	}
}
// UnityEngine.Vector3 LTDescrOptional::get_point()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 LTDescrOptional_get_point_mA27602B88C44EA4247343715E51E972F14985EA8 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Vector3 point { get; set; }
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___U3CpointU3Ek__BackingField_1;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_point(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_point_m58D1986651D5F3479B0C39B2BEFDB9986CF5F621 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___value0, const RuntimeMethod* method) 
{
	{
		// public Vector3 point { get; set; }
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___value0;
		__this->___U3CpointU3Ek__BackingField_1 = L_0;
		return;
	}
}
// UnityEngine.Vector3 LTDescrOptional::get_axis()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 LTDescrOptional_get_axis_m69DD980F94B0648F6D6C0DBDF26BA573562F12A6 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Vector3 axis { get; set; }
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = __this->___U3CaxisU3Ek__BackingField_2;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_axis(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_axis_mF83E5806A5187EB5812F8A20DEA8981801C2DE55 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___value0, const RuntimeMethod* method) 
{
	{
		// public Vector3 axis { get; set; }
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___value0;
		__this->___U3CaxisU3Ek__BackingField_2 = L_0;
		return;
	}
}
// System.Single LTDescrOptional::get_lastVal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float LTDescrOptional_get_lastVal_m332C8D966589F66770D1E80F4261E4FB00C404F9 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public float lastVal{ get; set; }
		float L_0 = __this->___U3ClastValU3Ek__BackingField_3;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_lastVal(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_lastVal_m47486F8725175EB4D4D472428ECC56576B3FEBA3 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, float ___value0, const RuntimeMethod* method) 
{
	{
		// public float lastVal{ get; set; }
		float L_0 = ___value0;
		__this->___U3ClastValU3Ek__BackingField_3 = L_0;
		return;
	}
}
// UnityEngine.Quaternion LTDescrOptional::get_origRotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 LTDescrOptional_get_origRotation_m85883C3F853DEE65A0B07A5DFBBEDAF8352E034A (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Quaternion origRotation { get; set; }
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0 = __this->___U3CorigRotationU3Ek__BackingField_4;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_origRotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_origRotation_mC9998525EDA4ACCE7436979F184E8B75BE64B28F (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___value0, const RuntimeMethod* method) 
{
	{
		// public Quaternion origRotation { get; set; }
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0 = ___value0;
		__this->___U3CorigRotationU3Ek__BackingField_4 = L_0;
		return;
	}
}
// LTBezierPath LTDescrOptional::get_path()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR LTBezierPath_t7D7955285591E2EC13CB9D6AD709DECD0662D9E8* LTDescrOptional_get_path_m8EA87D0861C741D1A7A0DDD5A65560804B878422 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public LTBezierPath path { get; set; }
		LTBezierPath_t7D7955285591E2EC13CB9D6AD709DECD0662D9E8* L_0 = __this->___U3CpathU3Ek__BackingField_5;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_path(LTBezierPath)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_path_mC5E79652632D1E448B9095D1B4B1B6CEFBBC6DBF (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, LTBezierPath_t7D7955285591E2EC13CB9D6AD709DECD0662D9E8* ___value0, const RuntimeMethod* method) 
{
	{
		// public LTBezierPath path { get; set; }
		LTBezierPath_t7D7955285591E2EC13CB9D6AD709DECD0662D9E8* L_0 = ___value0;
		__this->___U3CpathU3Ek__BackingField_5 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CpathU3Ek__BackingField_5), (void*)L_0);
		return;
	}
}
// LTSpline LTDescrOptional::get_spline()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR LTSpline_tBB800424387D68FA0CA376A5C5B465878D83AE51* LTDescrOptional_get_spline_m19D4B996A670272553026D604EDFD1827D95F426 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public LTSpline spline { get; set; }
		LTSpline_tBB800424387D68FA0CA376A5C5B465878D83AE51* L_0 = __this->___U3CsplineU3Ek__BackingField_6;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_spline(LTSpline)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_spline_m8A28FA0547EB4030198F1A0E8B2A5E9184B886CA (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, LTSpline_tBB800424387D68FA0CA376A5C5B465878D83AE51* ___value0, const RuntimeMethod* method) 
{
	{
		// public LTSpline spline { get; set; }
		LTSpline_tBB800424387D68FA0CA376A5C5B465878D83AE51* L_0 = ___value0;
		__this->___U3CsplineU3Ek__BackingField_6 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CsplineU3Ek__BackingField_6), (void*)L_0);
		return;
	}
}
// LTRect LTDescrOptional::get_ltRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR LTRect_t66D96FDF103E1EBFDF64D310099E6792B10F48C4* LTDescrOptional_get_ltRect_m26C3356E3DBE6012CAC40D36AFE533A4757951AB (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public LTRect ltRect { get; set; } // maybe get rid of this eventually
		LTRect_t66D96FDF103E1EBFDF64D310099E6792B10F48C4* L_0 = __this->___U3CltRectU3Ek__BackingField_10;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_ltRect(LTRect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_ltRect_m458080D2B516361FB8BA59FF162DDC67316A89FA (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, LTRect_t66D96FDF103E1EBFDF64D310099E6792B10F48C4* ___value0, const RuntimeMethod* method) 
{
	{
		// public LTRect ltRect { get; set; } // maybe get rid of this eventually
		LTRect_t66D96FDF103E1EBFDF64D310099E6792B10F48C4* L_0 = ___value0;
		__this->___U3CltRectU3Ek__BackingField_10 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CltRectU3Ek__BackingField_10), (void*)L_0);
		return;
	}
}
// System.Action`1<System.Single> LTDescrOptional::get_onUpdateFloat()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* LTDescrOptional_get_onUpdateFloat_m072498872BEA06E4F4C3F6F841F98F450A993912 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<float> onUpdateFloat { get; set; }
		Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* L_0 = __this->___U3ConUpdateFloatU3Ek__BackingField_11;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onUpdateFloat(System.Action`1<System.Single>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateFloat_m4BCEBD8B8D19487198954284ADB77EF98BA832DF (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<float> onUpdateFloat { get; set; }
		Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* L_0 = ___value0;
		__this->___U3ConUpdateFloatU3Ek__BackingField_11 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateFloatU3Ek__BackingField_11), (void*)L_0);
		return;
	}
}
// System.Action`2<System.Single,System.Single> LTDescrOptional::get_onUpdateFloatRatio()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* LTDescrOptional_get_onUpdateFloatRatio_m67A16BB3C211324DE40E1F748B2C3A2B9F424043 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<float,float> onUpdateFloatRatio { get; set; }
		Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* L_0 = __this->___U3ConUpdateFloatRatioU3Ek__BackingField_12;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onUpdateFloatRatio(System.Action`2<System.Single,System.Single>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateFloatRatio_m13C68440F2DD889D21A63A88607F0A53B087EAF1 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<float,float> onUpdateFloatRatio { get; set; }
		Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* L_0 = ___value0;
		__this->___U3ConUpdateFloatRatioU3Ek__BackingField_12 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateFloatRatioU3Ek__BackingField_12), (void*)L_0);
		return;
	}
}
// System.Action`2<System.Single,System.Object> LTDescrOptional::get_onUpdateFloatObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* LTDescrOptional_get_onUpdateFloatObject_m4491FDBDA0B266B51D9598D44D86E8C21A57C696 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<float,object> onUpdateFloatObject { get; set; }
		Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* L_0 = __this->___U3ConUpdateFloatObjectU3Ek__BackingField_13;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onUpdateFloatObject(System.Action`2<System.Single,System.Object>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateFloatObject_m9173548CA04A36CE51944DC2F6B3D9AFB615583B (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<float,object> onUpdateFloatObject { get; set; }
		Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* L_0 = ___value0;
		__this->___U3ConUpdateFloatObjectU3Ek__BackingField_13 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateFloatObjectU3Ek__BackingField_13), (void*)L_0);
		return;
	}
}
// System.Action`1<UnityEngine.Vector2> LTDescrOptional::get_onUpdateVector2()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* LTDescrOptional_get_onUpdateVector2_mCE0D193D519DC1F030232347E200E30F38650796 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Vector2> onUpdateVector2 { get; set; }
		Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* L_0 = __this->___U3ConUpdateVector2U3Ek__BackingField_14;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onUpdateVector2(System.Action`1<UnityEngine.Vector2>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateVector2_m65877391CC63F7918C116B939098F74C8153867C (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<Vector2> onUpdateVector2 { get; set; }
		Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* L_0 = ___value0;
		__this->___U3ConUpdateVector2U3Ek__BackingField_14 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateVector2U3Ek__BackingField_14), (void*)L_0);
		return;
	}
}
// System.Action`1<UnityEngine.Vector3> LTDescrOptional::get_onUpdateVector3()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* LTDescrOptional_get_onUpdateVector3_m44FF421248177E984AE7B15DA68CC8060A895574 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Vector3> onUpdateVector3 { get; set; }
		Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* L_0 = __this->___U3ConUpdateVector3U3Ek__BackingField_15;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onUpdateVector3(System.Action`1<UnityEngine.Vector3>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateVector3_mF5528C641054AF6D5570F4C521B97399377BB714 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<Vector3> onUpdateVector3 { get; set; }
		Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* L_0 = ___value0;
		__this->___U3ConUpdateVector3U3Ek__BackingField_15 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateVector3U3Ek__BackingField_15), (void*)L_0);
		return;
	}
}
// System.Action`2<UnityEngine.Vector3,System.Object> LTDescrOptional::get_onUpdateVector3Object()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* LTDescrOptional_get_onUpdateVector3Object_mED8D03633DF1E94683600AF1835E146F1D83DB91 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Vector3,object> onUpdateVector3Object { get; set; }
		Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* L_0 = __this->___U3ConUpdateVector3ObjectU3Ek__BackingField_16;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onUpdateVector3Object(System.Action`2<UnityEngine.Vector3,System.Object>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateVector3Object_mA6A20E33951345E524C678126849ABC7BDBAACCB (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<Vector3,object> onUpdateVector3Object { get; set; }
		Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* L_0 = ___value0;
		__this->___U3ConUpdateVector3ObjectU3Ek__BackingField_16 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateVector3ObjectU3Ek__BackingField_16), (void*)L_0);
		return;
	}
}
// System.Action`1<UnityEngine.Color> LTDescrOptional::get_onUpdateColor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22* LTDescrOptional_get_onUpdateColor_m5085BB52E6446C596C9666A6EB994B538E6520BA (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Color> onUpdateColor { get; set; }
		Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22* L_0 = __this->___U3ConUpdateColorU3Ek__BackingField_17;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onUpdateColor(System.Action`1<UnityEngine.Color>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateColor_mBE1BC44C9B9A46AE55C7EF4CD31B8AFE98B96AFA (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<Color> onUpdateColor { get; set; }
		Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22* L_0 = ___value0;
		__this->___U3ConUpdateColorU3Ek__BackingField_17 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateColorU3Ek__BackingField_17), (void*)L_0);
		return;
	}
}
// System.Action`2<UnityEngine.Color,System.Object> LTDescrOptional::get_onUpdateColorObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_2_tA6305A40DF06ED5230D130F9BFFB7DFF81760FF3* LTDescrOptional_get_onUpdateColorObject_m1C79BAFB2919CBF399509EA62977B832474A53C7 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Color,object> onUpdateColorObject { get; set; }
		Action_2_tA6305A40DF06ED5230D130F9BFFB7DFF81760FF3* L_0 = __this->___U3ConUpdateColorObjectU3Ek__BackingField_18;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onUpdateColorObject(System.Action`2<UnityEngine.Color,System.Object>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateColorObject_mDF1D2E3DF555252FFA3F178C2076BB3FD58F98D3 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_tA6305A40DF06ED5230D130F9BFFB7DFF81760FF3* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<Color,object> onUpdateColorObject { get; set; }
		Action_2_tA6305A40DF06ED5230D130F9BFFB7DFF81760FF3* L_0 = ___value0;
		__this->___U3ConUpdateColorObjectU3Ek__BackingField_18 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateColorObjectU3Ek__BackingField_18), (void*)L_0);
		return;
	}
}
// System.Action LTDescrOptional::get_onComplete()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* LTDescrOptional_get_onComplete_mDA222EA6377D85D378C92FF748EB3176386B1BE8 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action onComplete { get; set; }
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_0 = __this->___U3ConCompleteU3Ek__BackingField_19;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onComplete(System.Action)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onComplete_m96FFEFD7789ADFA64EE6FD2AF845D9B6BD451798 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action onComplete { get; set; }
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_0 = ___value0;
		__this->___U3ConCompleteU3Ek__BackingField_19 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConCompleteU3Ek__BackingField_19), (void*)L_0);
		return;
	}
}
// System.Action`1<System.Object> LTDescrOptional::get_onCompleteObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* LTDescrOptional_get_onCompleteObject_mE5B6DDBD587B9B3D3413FE734855BBF7AD6E7B6C (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<object> onCompleteObject { get; set; }
		Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* L_0 = __this->___U3ConCompleteObjectU3Ek__BackingField_20;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onCompleteObject(System.Action`1<System.Object>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onCompleteObject_m3F13DA5092A613749482AFEA8616C50985FAB6BA (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<object> onCompleteObject { get; set; }
		Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* L_0 = ___value0;
		__this->___U3ConCompleteObjectU3Ek__BackingField_20 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConCompleteObjectU3Ek__BackingField_20), (void*)L_0);
		return;
	}
}
// System.Object LTDescrOptional::get_onCompleteParam()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* LTDescrOptional_get_onCompleteParam_m7A290ECEC6D5782B9637A5E027465EED69DCA793 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public object onCompleteParam { get; set; }
		RuntimeObject* L_0 = __this->___U3ConCompleteParamU3Ek__BackingField_21;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onCompleteParam(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onCompleteParam_m62AFA92B070D830600EC7C2FAC58BF58B24C9402 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, RuntimeObject* ___value0, const RuntimeMethod* method) 
{
	{
		// public object onCompleteParam { get; set; }
		RuntimeObject* L_0 = ___value0;
		__this->___U3ConCompleteParamU3Ek__BackingField_21 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConCompleteParamU3Ek__BackingField_21), (void*)L_0);
		return;
	}
}
// System.Object LTDescrOptional::get_onUpdateParam()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* LTDescrOptional_get_onUpdateParam_mC0BAFEB0A9FA8DCD7C1BF69729A933ACB035E5D1 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public object onUpdateParam { get; set; }
		RuntimeObject* L_0 = __this->___U3ConUpdateParamU3Ek__BackingField_22;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onUpdateParam(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateParam_m6F1D577E1B5D4610D95F7C984D29605806C4C29A (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, RuntimeObject* ___value0, const RuntimeMethod* method) 
{
	{
		// public object onUpdateParam { get; set; }
		RuntimeObject* L_0 = ___value0;
		__this->___U3ConUpdateParamU3Ek__BackingField_22 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateParamU3Ek__BackingField_22), (void*)L_0);
		return;
	}
}
// System.Action LTDescrOptional::get_onStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* LTDescrOptional_get_onStart_m55CC57DF606C8D8DCFC7750F3E40DC175F050756 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action onStart { get; set; }
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_0 = __this->___U3ConStartU3Ek__BackingField_23;
		return L_0;
	}
}
// System.Void LTDescrOptional::set_onStart(System.Action)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_set_onStart_mA3D18F65D8268F7EA4AE03CFF2F113F052AFB71D (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action onStart { get; set; }
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_0 = ___value0;
		__this->___U3ConStartU3Ek__BackingField_23 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConStartU3Ek__BackingField_23), (void*)L_0);
		return;
	}
}
// System.Void LTDescrOptional::reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_reset_mB2AA60DDAE4B207B83625AEEE0D2660959E35D95 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// animationCurve = null;
		__this->___animationCurve_7 = (AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___animationCurve_7), (void*)(AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354*)NULL);
		// this.onUpdateFloat = null;
		LTDescrOptional_set_onUpdateFloat_m4BCEBD8B8D19487198954284ADB77EF98BA832DF_inline(__this, (Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A*)NULL, NULL);
		// this.onUpdateFloatRatio = null;
		LTDescrOptional_set_onUpdateFloatRatio_m13C68440F2DD889D21A63A88607F0A53B087EAF1_inline(__this, (Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132*)NULL, NULL);
		// this.onUpdateVector2 = null;
		LTDescrOptional_set_onUpdateVector2_m65877391CC63F7918C116B939098F74C8153867C_inline(__this, (Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81*)NULL, NULL);
		// this.onUpdateVector3 = null;
		LTDescrOptional_set_onUpdateVector3_mF5528C641054AF6D5570F4C521B97399377BB714_inline(__this, (Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2*)NULL, NULL);
		// this.onUpdateFloatObject = null;
		LTDescrOptional_set_onUpdateFloatObject_m9173548CA04A36CE51944DC2F6B3D9AFB615583B_inline(__this, (Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10*)NULL, NULL);
		// this.onUpdateVector3Object = null;
		LTDescrOptional_set_onUpdateVector3Object_mA6A20E33951345E524C678126849ABC7BDBAACCB_inline(__this, (Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C*)NULL, NULL);
		// this.onUpdateColor = null;
		LTDescrOptional_set_onUpdateColor_mBE1BC44C9B9A46AE55C7EF4CD31B8AFE98B96AFA_inline(__this, (Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22*)NULL, NULL);
		// this.onComplete = null;
		LTDescrOptional_set_onComplete_m96FFEFD7789ADFA64EE6FD2AF845D9B6BD451798_inline(__this, (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)NULL, NULL);
		// this.onCompleteObject = null;
		LTDescrOptional_set_onCompleteObject_m3F13DA5092A613749482AFEA8616C50985FAB6BA_inline(__this, (Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87*)NULL, NULL);
		// this.onCompleteParam = null;
		LTDescrOptional_set_onCompleteParam_m62AFA92B070D830600EC7C2FAC58BF58B24C9402_inline(__this, NULL, NULL);
		// this.onStart = null;
		LTDescrOptional_set_onStart_mA3D18F65D8268F7EA4AE03CFF2F113F052AFB71D_inline(__this, (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)NULL, NULL);
		// this.point = Vector3.zero;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0;
		L_0 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		LTDescrOptional_set_point_m58D1986651D5F3479B0C39B2BEFDB9986CF5F621_inline(__this, L_0, NULL);
		// this.initFrameCount = 0;
		__this->___initFrameCount_8 = 0;
		// }
		return;
	}
}
// System.Void LTDescrOptional::callOnUpdate(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional_callOnUpdate_m72EC55DBDBCC4C043A4C8D61506D1E25E7698E82 (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, float ___val0, float ___ratioPassed1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(this.onUpdateFloat!=null)
		Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* L_0;
		L_0 = LTDescrOptional_get_onUpdateFloat_m072498872BEA06E4F4C3F6F841F98F450A993912_inline(__this, NULL);
		if (!L_0)
		{
			goto IL_0014;
		}
	}
	{
		// this.onUpdateFloat(val);
		Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* L_1;
		L_1 = LTDescrOptional_get_onUpdateFloat_m072498872BEA06E4F4C3F6F841F98F450A993912_inline(__this, NULL);
		float L_2 = ___val0;
		NullCheck(L_1);
		Action_1_Invoke_mA8F89FB04FEA0F48A4F22EC84B5F9ADB2914341F_inline(L_1, L_2, NULL);
	}

IL_0014:
	{
		// if (this.onUpdateFloatRatio != null){
		Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* L_3;
		L_3 = LTDescrOptional_get_onUpdateFloatRatio_m67A16BB3C211324DE40E1F748B2C3A2B9F424043_inline(__this, NULL);
		if (!L_3)
		{
			goto IL_002a;
		}
	}
	{
		// this.onUpdateFloatRatio(val,ratioPassed);
		Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* L_4;
		L_4 = LTDescrOptional_get_onUpdateFloatRatio_m67A16BB3C211324DE40E1F748B2C3A2B9F424043_inline(__this, NULL);
		float L_5 = ___val0;
		float L_6 = ___ratioPassed1;
		NullCheck(L_4);
		Action_2_Invoke_m50A62593A87E11ED31B47FE46E633AB3B9A7666C_inline(L_4, L_5, L_6, NULL);
		return;
	}

IL_002a:
	{
		// }else if(this.onUpdateFloatObject!=null){
		Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* L_7;
		L_7 = LTDescrOptional_get_onUpdateFloatObject_m4491FDBDA0B266B51D9598D44D86E8C21A57C696_inline(__this, NULL);
		if (!L_7)
		{
			goto IL_0045;
		}
	}
	{
		// this.onUpdateFloatObject(val, this.onUpdateParam);
		Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* L_8;
		L_8 = LTDescrOptional_get_onUpdateFloatObject_m4491FDBDA0B266B51D9598D44D86E8C21A57C696_inline(__this, NULL);
		float L_9 = ___val0;
		RuntimeObject* L_10;
		L_10 = LTDescrOptional_get_onUpdateParam_mC0BAFEB0A9FA8DCD7C1BF69729A933ACB035E5D1_inline(__this, NULL);
		NullCheck(L_8);
		Action_2_Invoke_m9E7863E85E4D6B6D0C7F731513A8ECC8139FE626_inline(L_8, L_9, L_10, NULL);
		return;
	}

IL_0045:
	{
		// }else if(this.onUpdateVector3Object!=null){
		Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* L_11;
		L_11 = LTDescrOptional_get_onUpdateVector3Object_mED8D03633DF1E94683600AF1835E146F1D83DB91_inline(__this, NULL);
		if (!L_11)
		{
			goto IL_0064;
		}
	}
	{
		// this.onUpdateVector3Object(LTDescr.newVect, this.onUpdateParam);
		Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* L_12;
		L_12 = LTDescrOptional_get_onUpdateVector3Object_mED8D03633DF1E94683600AF1835E146F1D83DB91_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = ((LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_StaticFields*)il2cpp_codegen_static_fields_for(LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_il2cpp_TypeInfo_var))->___newVect_47;
		RuntimeObject* L_14;
		L_14 = LTDescrOptional_get_onUpdateParam_mC0BAFEB0A9FA8DCD7C1BF69729A933ACB035E5D1_inline(__this, NULL);
		NullCheck(L_12);
		Action_2_Invoke_m719475FEF89235EA7C17D75BF384DE2B9545839B_inline(L_12, L_13, L_14, NULL);
		return;
	}

IL_0064:
	{
		// }else if(this.onUpdateVector3!=null){
		Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* L_15;
		L_15 = LTDescrOptional_get_onUpdateVector3_m44FF421248177E984AE7B15DA68CC8060A895574_inline(__this, NULL);
		if (!L_15)
		{
			goto IL_007d;
		}
	}
	{
		// this.onUpdateVector3(LTDescr.newVect);
		Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* L_16;
		L_16 = LTDescrOptional_get_onUpdateVector3_m44FF421248177E984AE7B15DA68CC8060A895574_inline(__this, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_17 = ((LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_StaticFields*)il2cpp_codegen_static_fields_for(LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_il2cpp_TypeInfo_var))->___newVect_47;
		NullCheck(L_16);
		Action_1_Invoke_m211AB6C2AA7326F6BFC8338EC888360A219AFF41_inline(L_16, L_17, NULL);
		return;
	}

IL_007d:
	{
		// }else if(this.onUpdateVector2!=null){
		Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* L_18;
		L_18 = LTDescrOptional_get_onUpdateVector2_mCE0D193D519DC1F030232347E200E30F38650796_inline(__this, NULL);
		if (!L_18)
		{
			goto IL_00a9;
		}
	}
	{
		// this.onUpdateVector2(new Vector2(LTDescr.newVect.x,LTDescr.newVect.y));
		Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* L_19;
		L_19 = LTDescrOptional_get_onUpdateVector2_mCE0D193D519DC1F030232347E200E30F38650796_inline(__this, NULL);
		float L_20 = (&((LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_StaticFields*)il2cpp_codegen_static_fields_for(LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_il2cpp_TypeInfo_var))->___newVect_47)->___x_2;
		float L_21 = (&((LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_StaticFields*)il2cpp_codegen_static_fields_for(LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119_il2cpp_TypeInfo_var))->___newVect_47)->___y_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_22;
		memset((&L_22), 0, sizeof(L_22));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_22), L_20, L_21, /*hidden argument*/NULL);
		NullCheck(L_19);
		Action_1_Invoke_m3C60C84018CAD36C0EC956A14935394A7DD116C6_inline(L_19, L_22, NULL);
	}

IL_00a9:
	{
		// }
		return;
	}
}
// System.Void LTDescrOptional::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTDescrOptional__ctor_m63A9539F1B59BC6C460E0AFD89DADECE5E2B454D (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void LTSeq::reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTSeq_reset_mEAFCB13DCA94562FA8CE36476D8985C3204A5AF8 (LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE* __this, const RuntimeMethod* method) 
{
	{
		// previous = null;
		__this->___previous_0 = (LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___previous_0), (void*)(LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE*)NULL);
		// tween = null;
		__this->___tween_2 = (LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___tween_2), (void*)(LTDescr_t55287742733FE2AC301A5A3753AEBF04F5CDF119*)NULL);
		// totalDelay = 0f;
		__this->___totalDelay_3 = (0.0f);
		// }
		return;
	}
}
// System.Void LTSeq::init(System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTSeq_init_mC1C95898990A9F815C025A91385B472D9E547F9D (LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE* __this, uint32_t ___id0, uint32_t ___global_counter1, const RuntimeMethod* method) 
{
	{
		// reset();
		LTSeq_reset_mEAFCB13DCA94562FA8CE36476D8985C3204A5AF8(__this, NULL);
		// _id = id;
		uint32_t L_0 = ___id0;
		__this->____id_8 = L_0;
		// counter = global_counter;
		uint32_t L_1 = ___global_counter1;
		__this->___counter_6 = L_1;
		// this.current = this;
		__this->___current_1 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___current_1), (void*)__this);
		// }
		return;
	}
}
// System.Void LTSeq::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LTSeq__ctor_mBFF2569014C099CCF436E18268153847BFE276EB (LTSeq_t446E6ACA302170902C6743BFAD295CC107AD52BE* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateFloat_m4BCEBD8B8D19487198954284ADB77EF98BA832DF_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<float> onUpdateFloat { get; set; }
		Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* L_0 = ___value0;
		__this->___U3ConUpdateFloatU3Ek__BackingField_11 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateFloatU3Ek__BackingField_11), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateFloatRatio_m13C68440F2DD889D21A63A88607F0A53B087EAF1_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<float,float> onUpdateFloatRatio { get; set; }
		Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* L_0 = ___value0;
		__this->___U3ConUpdateFloatRatioU3Ek__BackingField_12 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateFloatRatioU3Ek__BackingField_12), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateVector2_m65877391CC63F7918C116B939098F74C8153867C_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<Vector2> onUpdateVector2 { get; set; }
		Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* L_0 = ___value0;
		__this->___U3ConUpdateVector2U3Ek__BackingField_14 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateVector2U3Ek__BackingField_14), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateVector3_mF5528C641054AF6D5570F4C521B97399377BB714_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<Vector3> onUpdateVector3 { get; set; }
		Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* L_0 = ___value0;
		__this->___U3ConUpdateVector3U3Ek__BackingField_15 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateVector3U3Ek__BackingField_15), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateFloatObject_m9173548CA04A36CE51944DC2F6B3D9AFB615583B_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<float,object> onUpdateFloatObject { get; set; }
		Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* L_0 = ___value0;
		__this->___U3ConUpdateFloatObjectU3Ek__BackingField_13 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateFloatObjectU3Ek__BackingField_13), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateVector3Object_mA6A20E33951345E524C678126849ABC7BDBAACCB_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<Vector3,object> onUpdateVector3Object { get; set; }
		Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* L_0 = ___value0;
		__this->___U3ConUpdateVector3ObjectU3Ek__BackingField_16 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateVector3ObjectU3Ek__BackingField_16), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onUpdateColor_mBE1BC44C9B9A46AE55C7EF4CD31B8AFE98B96AFA_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<Color> onUpdateColor { get; set; }
		Action_1_t6F23E949C5B7B23A98CD4EE8560AA8A2266BDC22* L_0 = ___value0;
		__this->___U3ConUpdateColorU3Ek__BackingField_17 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConUpdateColorU3Ek__BackingField_17), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onComplete_m96FFEFD7789ADFA64EE6FD2AF845D9B6BD451798_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action onComplete { get; set; }
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_0 = ___value0;
		__this->___U3ConCompleteU3Ek__BackingField_19 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConCompleteU3Ek__BackingField_19), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onCompleteObject_m3F13DA5092A613749482AFEA8616C50985FAB6BA_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action<object> onCompleteObject { get; set; }
		Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* L_0 = ___value0;
		__this->___U3ConCompleteObjectU3Ek__BackingField_20 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConCompleteObjectU3Ek__BackingField_20), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onCompleteParam_m62AFA92B070D830600EC7C2FAC58BF58B24C9402_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, RuntimeObject* ___value0, const RuntimeMethod* method) 
{
	{
		// public object onCompleteParam { get; set; }
		RuntimeObject* L_0 = ___value0;
		__this->___U3ConCompleteParamU3Ek__BackingField_21 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConCompleteParamU3Ek__BackingField_21), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_onStart_mA3D18F65D8268F7EA4AE03CFF2F113F052AFB71D_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___value0, const RuntimeMethod* method) 
{
	{
		// public Action onStart { get; set; }
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_0 = ___value0;
		__this->___U3ConStartU3Ek__BackingField_23 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3ConStartU3Ek__BackingField_23), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___zeroVector_5;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LTDescrOptional_set_point_m58D1986651D5F3479B0C39B2BEFDB9986CF5F621_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___value0, const RuntimeMethod* method) 
{
	{
		// public Vector3 point { get; set; }
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___value0;
		__this->___U3CpointU3Ek__BackingField_1 = L_0;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* LTDescrOptional_get_onUpdateFloat_m072498872BEA06E4F4C3F6F841F98F450A993912_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<float> onUpdateFloat { get; set; }
		Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* L_0 = __this->___U3ConUpdateFloatU3Ek__BackingField_11;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* LTDescrOptional_get_onUpdateFloatRatio_m67A16BB3C211324DE40E1F748B2C3A2B9F424043_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<float,float> onUpdateFloatRatio { get; set; }
		Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* L_0 = __this->___U3ConUpdateFloatRatioU3Ek__BackingField_12;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* LTDescrOptional_get_onUpdateFloatObject_m4491FDBDA0B266B51D9598D44D86E8C21A57C696_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<float,object> onUpdateFloatObject { get; set; }
		Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* L_0 = __this->___U3ConUpdateFloatObjectU3Ek__BackingField_13;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* LTDescrOptional_get_onUpdateParam_mC0BAFEB0A9FA8DCD7C1BF69729A933ACB035E5D1_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public object onUpdateParam { get; set; }
		RuntimeObject* L_0 = __this->___U3ConUpdateParamU3Ek__BackingField_22;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* LTDescrOptional_get_onUpdateVector3Object_mED8D03633DF1E94683600AF1835E146F1D83DB91_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Vector3,object> onUpdateVector3Object { get; set; }
		Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* L_0 = __this->___U3ConUpdateVector3ObjectU3Ek__BackingField_16;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* LTDescrOptional_get_onUpdateVector3_m44FF421248177E984AE7B15DA68CC8060A895574_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Vector3> onUpdateVector3 { get; set; }
		Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* L_0 = __this->___U3ConUpdateVector3U3Ek__BackingField_15;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* LTDescrOptional_get_onUpdateVector2_mCE0D193D519DC1F030232347E200E30F38650796_inline (LTDescrOptional_t60C461FE22386619DF260F600954CDD3ED9D3C99* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Vector2> onUpdateVector2 { get; set; }
		Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* L_0 = __this->___U3ConUpdateVector2U3Ek__BackingField_14;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___x0, float ___y1, const RuntimeMethod* method) 
{
	{
		float L_0 = ___x0;
		__this->___x_0 = L_0;
		float L_1 = ___y1;
		__this->___y_1 = L_1;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_mA8F89FB04FEA0F48A4F22EC84B5F9ADB2914341F_gshared_inline (Action_1_t310F18CB4338A2740CA701F160C62E2C3198E66A* __this, float ___obj0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___obj0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_2_Invoke_m50A62593A87E11ED31B47FE46E633AB3B9A7666C_gshared_inline (Action_2_t4195ED8D681728C29103F36BCD591C0F089C9132* __this, float ___arg10, float ___arg21, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, float, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___arg10, ___arg21, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_2_Invoke_m9E7863E85E4D6B6D0C7F731513A8ECC8139FE626_gshared_inline (Action_2_t25A8547AFC85E4914143093EDA11AE27C97D9E10* __this, float ___arg10, RuntimeObject* ___arg21, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, float, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___arg10, ___arg21, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_2_Invoke_m719475FEF89235EA7C17D75BF384DE2B9545839B_gshared_inline (Action_2_t7493708BA3F87F84FAB65917DE69C3FD00878E6C* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___arg10, RuntimeObject* ___arg21, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___arg10, ___arg21, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_m211AB6C2AA7326F6BFC8338EC888360A219AFF41_gshared_inline (Action_1_t2EDB30EAB747FDF563DD6410FC76AF861A09A0C2* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___obj0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___obj0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_m3C60C84018CAD36C0EC956A14935394A7DD116C6_gshared_inline (Action_1_t17E52B12DC24FA6C9DD52F87043C85BEA889BB81* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___obj0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___obj0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
