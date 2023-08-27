#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
217,
225,
226,
227,
228,
229,
230,
231,
232,
233,
236,
237,
404,
405,
407,
435,
436,
437,
457,
458,
459,
460,
558,
559,
560,
563,
605,
606,
607,
610,
612,
614,
616,
621,
629,
630,
631,
632,
633,
634,
635,
636,
637,
638,
639,
640,
641,
642,
643,
644,
645,
647,
648,
649,
650,
651,
652,
653,
747,
748,
749,
750,
751,
752,
753,
754,
755,
756,
757,
758,
759,
760,
761,
762,
763,
765,
766,
767,
768,
769,
770,
771,
898,
907,
910,
912,
918,
919,
921,
922,
926,
928,
931,
932,
934,
935,
938,
939,
940,
943,
945,
948,
950,
952,
1029,
1031,
1033,
1042,
1043,
1044,
1045,
1047,
1054,
1055,
1056,
1057,
1058,
1066,
1067,
1068,
1072,
1073,
1076,
1080,
1081,
1082,
1353,
1574,
1575,
8891,
8892,
8894,
8895,
8896,
8897,
8898,
8899,
8901,
8903,
8905,
8906,
8907,
8916,
8918,
8922,
8923,
8925,
8927,
8929,
8941,
8948,
8954,
8955,
8957,
8958,
8959,
8960,
8961,
8963,
8965,
10059,
10063,
10065,
10066,
10067,
10068,
10241,
10242,
10243,
10244,
10266,
10267,
10268,
10270,
10272,
10324,
10396,
10398,
10410,
10411,
10412,
10413,
10858,
10859,
10864,
10865,
10905,
10927,
10933,
10940,
10950,
10954,
11042,
11044,
11057,
11059,
11060,
11061,
11068,
11083,
11103,
11104,
11112,
11114,
11121,
11122,
11125,
11127,
11132,
11138,
11139,
11146,
11148,
11160,
11163,
11164,
11165,
11176,
11185,
11191,
11192,
11193,
11195,
11196,
11214,
11216,
11230,
11255,
11256,
11257,
11278,
11308,
11309,
11878,
11879,
11880,
11958,
12038,
12291,
12292,
12299,
12300,
12301,
12307,
12379,
12784,
12785,
13174,
14553,
14574,
14581,
14583,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementType_raw (int,int);
int ves_icall_System_Array_IsValueOfElementType_raw (int,int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy_raw (int,int,int,int,int,int);
int ves_icall_System_Array_GetLength_raw (int,int,int);
int ves_icall_System_Array_GetLowerBound_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
int ves_icall_System_Array_GetValueImpl_raw (int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
int ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
void ves_icall_System_Enum_InternalBoxEnum_raw (int,int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
int ves_icall_System_GC_GetCollectionCount (int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
void ves_icall_RuntimeType_GetInterfaceMapData_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetPacking_raw (int,int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Decrement_Long (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
int ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw (int);
void ves_icall_System_Threading_Thread_StartInternal_raw (int,int,int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
void ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureInternal_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int mono_object_hash_icall_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
void ves_icall_AssemblyExtensions_ApplyUpdate (int,int,int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
int ves_icall_CustomAttributeBuilder_GetBlob_raw (int,int,int,int,int,int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 217,
ves_icall_System_Array_InternalCreate,
// token 225,
ves_icall_System_Array_GetCorElementTypeOfElementType_raw,
// token 226,
ves_icall_System_Array_IsValueOfElementType_raw,
// token 227,
ves_icall_System_Array_CanChangePrimitive,
// token 228,
ves_icall_System_Array_FastCopy_raw,
// token 229,
ves_icall_System_Array_GetLength_raw,
// token 230,
ves_icall_System_Array_GetLowerBound_raw,
// token 231,
ves_icall_System_Array_GetGenericValue_icall,
// token 232,
ves_icall_System_Array_GetValueImpl_raw,
// token 233,
ves_icall_System_Array_SetGenericValue_icall,
// token 236,
ves_icall_System_Array_SetValueImpl_raw,
// token 237,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 404,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 405,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 407,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 435,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 436,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 437,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 457,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 458,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 459,
ves_icall_System_Enum_InternalGetCorElementType,
// token 460,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 558,
ves_icall_System_Environment_get_ProcessorCount,
// token 559,
ves_icall_System_Environment_get_TickCount,
// token 560,
ves_icall_System_Environment_get_TickCount64,
// token 563,
ves_icall_System_Environment_FailFast_raw,
// token 605,
ves_icall_System_GC_GetCollectionCount,
// token 606,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 607,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 610,
ves_icall_System_GC_SuppressFinalize_raw,
// token 612,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 614,
ves_icall_System_GC_GetGCMemoryInfo,
// token 616,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 621,
ves_icall_System_Object_MemberwiseClone_raw,
// token 629,
ves_icall_System_Math_Acos,
// token 630,
ves_icall_System_Math_Acosh,
// token 631,
ves_icall_System_Math_Asin,
// token 632,
ves_icall_System_Math_Asinh,
// token 633,
ves_icall_System_Math_Atan,
// token 634,
ves_icall_System_Math_Atan2,
// token 635,
ves_icall_System_Math_Atanh,
// token 636,
ves_icall_System_Math_Cbrt,
// token 637,
ves_icall_System_Math_Ceiling,
// token 638,
ves_icall_System_Math_Cos,
// token 639,
ves_icall_System_Math_Cosh,
// token 640,
ves_icall_System_Math_Exp,
// token 641,
ves_icall_System_Math_Floor,
// token 642,
ves_icall_System_Math_Log,
// token 643,
ves_icall_System_Math_Log10,
// token 644,
ves_icall_System_Math_Pow,
// token 645,
ves_icall_System_Math_Sin,
// token 647,
ves_icall_System_Math_Sinh,
// token 648,
ves_icall_System_Math_Sqrt,
// token 649,
ves_icall_System_Math_Tan,
// token 650,
ves_icall_System_Math_Tanh,
// token 651,
ves_icall_System_Math_FusedMultiplyAdd,
// token 652,
ves_icall_System_Math_Log2,
// token 653,
ves_icall_System_Math_ModF,
// token 747,
ves_icall_System_MathF_Acos,
// token 748,
ves_icall_System_MathF_Acosh,
// token 749,
ves_icall_System_MathF_Asin,
// token 750,
ves_icall_System_MathF_Asinh,
// token 751,
ves_icall_System_MathF_Atan,
// token 752,
ves_icall_System_MathF_Atan2,
// token 753,
ves_icall_System_MathF_Atanh,
// token 754,
ves_icall_System_MathF_Cbrt,
// token 755,
ves_icall_System_MathF_Ceiling,
// token 756,
ves_icall_System_MathF_Cos,
// token 757,
ves_icall_System_MathF_Cosh,
// token 758,
ves_icall_System_MathF_Exp,
// token 759,
ves_icall_System_MathF_Floor,
// token 760,
ves_icall_System_MathF_Log,
// token 761,
ves_icall_System_MathF_Log10,
// token 762,
ves_icall_System_MathF_Pow,
// token 763,
ves_icall_System_MathF_Sin,
// token 765,
ves_icall_System_MathF_Sinh,
// token 766,
ves_icall_System_MathF_Sqrt,
// token 767,
ves_icall_System_MathF_Tan,
// token 768,
ves_icall_System_MathF_Tanh,
// token 769,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 770,
ves_icall_System_MathF_Log2,
// token 771,
ves_icall_System_MathF_ModF,
// token 898,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 907,
ves_icall_RuntimeType_make_array_type_raw,
// token 910,
ves_icall_RuntimeType_make_byref_type_raw,
// token 912,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 918,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 919,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 921,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 922,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 926,
ves_icall_RuntimeType_GetInterfaceMapData_raw,
// token 928,
ves_icall_RuntimeType_GetPacking_raw,
// token 931,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 932,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 934,
ves_icall_System_RuntimeType_getFullName_raw,
// token 935,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 938,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 939,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 940,
ves_icall_RuntimeType_GetFields_native_raw,
// token 943,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 945,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 948,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 950,
ves_icall_RuntimeType_GetName_raw,
// token 952,
ves_icall_RuntimeType_GetNamespace_raw,
// token 1029,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 1031,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 1033,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1042,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 1043,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 1044,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 1045,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1047,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1054,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1055,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1056,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1057,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1058,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1066,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1067,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 1068,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1072,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 1073,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1076,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1080,
ves_icall_System_String_FastAllocateString_raw,
// token 1081,
ves_icall_System_String_InternalIsInterned_raw,
// token 1082,
ves_icall_System_String_InternalIntern_raw,
// token 1353,
ves_icall_System_Type_internal_from_handle_raw,
// token 1574,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1575,
ves_icall_System_ValueType_Equals_raw,
// token 8891,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 8892,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 8894,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 8895,
ves_icall_System_Threading_Interlocked_Decrement_Long,
// token 8896,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 8897,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 8898,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 8899,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 8901,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 8903,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 8905,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 8906,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 8907,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 8916,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 8918,
mono_monitor_exit_icall_raw,
// token 8922,
ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw,
// token 8923,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 8925,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 8927,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 8929,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 8941,
ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw,
// token 8948,
ves_icall_System_Threading_Thread_StartInternal_raw,
// token 8954,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 8955,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 8957,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 8958,
ves_icall_System_Threading_Thread_GetState_raw,
// token 8959,
ves_icall_System_Threading_Thread_SetState_raw,
// token 8960,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 8961,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 8963,
ves_icall_System_Threading_Thread_YieldInternal,
// token 8965,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 10059,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 10063,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 10065,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 10066,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 10067,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 10068,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 10241,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 10242,
ves_icall_System_GCHandle_InternalFree_raw,
// token 10243,
ves_icall_System_GCHandle_InternalGet_raw,
// token 10244,
ves_icall_System_GCHandle_InternalSet_raw,
// token 10266,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 10267,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 10268,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 10270,
ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureInternal_raw,
// token 10272,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 10324,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 10396,
mono_object_hash_icall_raw,
// token 10398,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 10410,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 10411,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 10412,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw,
// token 10413,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 10858,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 10859,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 10864,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 10865,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 10905,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 10927,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 10933,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 10940,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 10950,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 10954,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 11042,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 11044,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 11057,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 11059,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 11060,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 11061,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 11068,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 11083,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 11103,
ves_icall_reflection_get_token_raw,
// token 11104,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 11112,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 11114,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 11121,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 11122,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 11125,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 11127,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 11132,
ves_icall_reflection_get_token_raw,
// token 11138,
ves_icall_get_method_info_raw,
// token 11139,
ves_icall_get_method_attributes,
// token 11146,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 11148,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 11160,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 11163,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 11164,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 11165,
ves_icall_reflection_get_token_raw,
// token 11176,
ves_icall_InternalInvoke_raw,
// token 11185,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 11191,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 11192,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 11193,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 11195,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 11196,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 11214,
ves_icall_InvokeClassConstructor_raw,
// token 11216,
ves_icall_InternalInvoke_raw,
// token 11230,
ves_icall_reflection_get_token_raw,
// token 11255,
ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw,
// token 11256,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 11257,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 11278,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 11308,
ves_icall_reflection_get_token_raw,
// token 11309,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 11878,
ves_icall_AssemblyExtensions_ApplyUpdate,
// token 11879,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 11880,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 11958,
ves_icall_CustomAttributeBuilder_GetBlob_raw,
// token 12038,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 12291,
ves_icall_ModuleBuilder_basic_init_raw,
// token 12292,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 12299,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 12300,
ves_icall_ModuleBuilder_getToken_raw,
// token 12301,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 12307,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 12379,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 12784,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 12785,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 13174,
ves_icall_System_Diagnostics_Debugger_Log,
// token 14553,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 14574,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 14581,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 14583,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_handles [] = {
0,
1,
1,
0,
1,
1,
1,
0,
1,
0,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
0,
1,
0,
0,
0,
1,
0,
1,
1,
1,
1,
0,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
};
