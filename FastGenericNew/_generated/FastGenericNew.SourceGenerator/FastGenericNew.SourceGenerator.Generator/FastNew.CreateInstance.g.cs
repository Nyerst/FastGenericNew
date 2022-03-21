﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by FastGenericNew.SourceGenerator
//     Please do not modify this file directly
// <auto-generated/>
//------------------------------------------------------------------------------
#define AllowUnsafeImplementation
#nullable enable
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Reflection.Emit;
using System.ComponentModel;

namespace @FastGenericNew
{
	public static partial class FastNew	{

        /// <summary>
        /// <para>Create an instance of <typeparamref name="T" /></para>
        /// <para>Returns <c><see langword="new" /> <typeparamref name="T" />()</c> if <typeparamref name="T"/> is a <see cref="ValueType"/>(struct)</para>
        /// <para>This <b>CAN</b> call the Parameterless Constructor of the <see cref="ValueType"/>(struct)</para>
        /// </summary>
        /// <typeparam name="T">The type to create.</typeparam>
        /// <returns>A new instance of <typeparamref name="T" /></returns>
        /// <remarks>
        /// Equivalent to <c><see langword="new" /> <typeparamref name="T" />()</c> for both Reference Types and Value Types
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T>()
	    {
#if NETFRAMEWORK
            return global::@FastGenericNew.FastNew<T>.CompiledDelegate();
#else
		    return typeof(T).IsValueType
                ? System.Activator.CreateInstance<T>() // This will be optimized by JIT

    #if NET6_0_OR_GREATER
                : (global::@FastGenericNew.ClrAllocator<T>.IsSupported
                    ? global::@FastGenericNew.ClrAllocator<T>.CreateInstance()
                    : global::@FastGenericNew.FastNew<T>.CompiledDelegate());
    #else
                : global::@FastGenericNew.FastNew<T>.CompiledDelegate();
    #endif

#endif
	    }
        /// <summary>
        /// Create an instance of <typeparamref name="T" /> <br/>
        /// Returns <c><see langword="default" />(<typeparamref name="T" />)</c> if <typeparamref name="T"/> is a <see cref="ValueType"/>(struct) <br/>
        /// This <b>WILL NOT</b> call the Parameterless Constructor of the <see cref="ValueType"/>(struct)
        /// </summary>
        /// <typeparam name="T">The type to create.</typeparam>
        /// <returns>A new instance of <typeparamref name="T" /></returns>
        /// <remarks>
        /// For reference types, equivalent to <c><see langword="new" /> <typeparamref name="T" />()</c> <br/>
        /// For value types, equivalent to <c><see langword="default" />(<typeparamref name="T" />)</c>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
	    public static T NewOrDefault<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T>()
	    {
#if NETFRAMEWORK
		    return global::@FastGenericNew.FastNew<T>._isValueTypeT
#else
		    return typeof(T).IsValueType
#endif
                ? default(T)! // This will never be null since T is a ValueType
                : FastNew<T>.CompiledDelegate();
	    }
		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0>(TArg0 p0) =>
			global::@FastGenericNew.FastNew<T, TArg0>.CompiledDelegate(p0);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1>(TArg0 p0, TArg1 p1) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1>.CompiledDelegate(p0, p1);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2>(TArg0 p0, TArg1 p1, TArg2 p2) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2>.CompiledDelegate(p0, p1, p2);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3>.CompiledDelegate(p0, p1, p2, p3);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4>.CompiledDelegate(p0, p1, p2, p3, p4);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>.CompiledDelegate(p0, p1, p2, p3, p4, p5);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6, TArg7 p7) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6, p7);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6, TArg7 p7, TArg8 p8) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6, p7, p8);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6, TArg7 p7, TArg8 p8, TArg9 p9) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6, TArg7 p7, TArg8 p8, TArg9 p9, TArg10 p10) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6, TArg7 p7, TArg8 p8, TArg9 p9, TArg10 p10, TArg11 p11) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6, TArg7 p7, TArg8 p8, TArg9 p9, TArg10 p10, TArg11 p11, TArg12 p12) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6, TArg7 p7, TArg8 p8, TArg9 p9, TArg10 p10, TArg11 p11, TArg12 p12, TArg13 p13) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6, TArg7 p7, TArg8 p8, TArg9 p9, TArg10 p10, TArg11 p11, TArg12 p12, TArg13 p13, TArg14 p14) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);

		public static T CreateInstance<
#if NET5_0_OR_GREATER
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]
#endif
T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(TArg0 p0, TArg1 p1, TArg2 p2, TArg3 p3, TArg4 p4, TArg5 p5, TArg6 p6, TArg7 p7, TArg8 p8, TArg9 p9, TArg10 p10, TArg11 p11, TArg12 p12, TArg13 p13, TArg14 p14, TArg15 p15) =>
			global::@FastGenericNew.FastNew<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>.CompiledDelegate(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);

	}
}
