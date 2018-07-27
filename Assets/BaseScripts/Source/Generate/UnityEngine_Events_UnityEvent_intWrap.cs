﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

internal class UnityEngine_Events_UnityEvent_intWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Events.UnityEvent<int>), typeof(UnityEngine.Events.UnityEventBase), "UnityEvent_int");
		L.RegFunction("AddListener", AddListener);
		L.RegFunction("RemoveListener", RemoveListener);
		L.RegFunction("Invoke", Invoke);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.Events.UnityEvent<int>)ToLua.CheckObject<UnityEngine.Events.UnityEvent<int>>(L, 1);
			UnityEngine.Events.UnityAction<int> arg0 = (UnityEngine.Events.UnityAction<int>)ToLua.CheckDelegate<UnityEngine.Events.UnityAction<int>>(L, 2);
			obj.AddListener(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.Events.UnityEvent<int>)ToLua.CheckObject<UnityEngine.Events.UnityEvent<int>>(L, 1);
			UnityEngine.Events.UnityAction<int> arg0 = (UnityEngine.Events.UnityAction<int>)ToLua.CheckDelegate<UnityEngine.Events.UnityAction<int>>(L, 2);
			obj.RemoveListener(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Invoke(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.Events.UnityEvent<int>)ToLua.CheckObject<UnityEngine.Events.UnityEvent<int>>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Invoke(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
