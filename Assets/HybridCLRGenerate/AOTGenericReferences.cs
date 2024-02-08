using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"GameCore.dll",
		"System.Core.dll",
		"UniTask.dll",
		"UnityEngine.CoreModule.dll",
		"YooAsset.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// Core.Singleton<object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<BattleTest.<CreateUnit>d__1,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Core.UI.UIManager.<LoadFUIEntitysAsync>d__3,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Core.UI.UIManager.<ShowPanelAsync>d__2>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<HotUpdate.GameLogic.MKSceneManager.<SceneChange>d__2>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>g__ClickActionAsync|0>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<MK.Client.FUIHelper.<>c__DisplayClass10_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<MK.Client.FUIHelper.<>c__DisplayClass11_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<MK.Client.FUIHelper.<>c__DisplayClass8_0.<<AddListnerAsync>g__ClickActionAsync|0>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<MK.Client.FUIHelper.<>c__DisplayClass9_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<BattleTest.<CreateUnit>d__1,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Core.UI.UIManager.<LoadFUIEntitysAsync>d__3,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Core.UI.UIManager.<ShowPanelAsync>d__2>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<HotUpdate.GameLogic.MKSceneManager.<SceneChange>d__2>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>g__ClickActionAsync|0>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<MK.Client.FUIHelper.<>c__DisplayClass10_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<MK.Client.FUIHelper.<>c__DisplayClass11_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<MK.Client.FUIHelper.<>c__DisplayClass8_0.<<AddListnerAsync>g__ClickActionAsync|0>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<MK.Client.FUIHelper.<>c__DisplayClass9_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<BattleTest.<<CreateCube>b__2_0>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>b__2>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<MK.Client.FUIHelper.<>c__DisplayClass10_1.<<AddListnerAsync>b__2>d<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<MK.Client.FUIHelper.<>c__DisplayClass11_1.<<AddListnerAsync>b__2>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>b__2>d<object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>b__2>d<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>b__2>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<MK.Client.FUIHelper.<>c__DisplayClass8_1.<<AddListnerAsync>b__2>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<MK.Client.FUIHelper.<>c__DisplayClass9_1.<<AddListnerAsync>b__2>d<object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<MK.Client.LobbyPanelHandler.<>c.<<CreateScene>b__4_0>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<UITest.<>c.<<Init>b__0_0>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<BattleTest.<<CreateCube>b__2_0>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>b__2>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<MK.Client.FUIHelper.<>c__DisplayClass10_1.<<AddListnerAsync>b__2>d<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<MK.Client.FUIHelper.<>c__DisplayClass11_1.<<AddListnerAsync>b__2>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>b__2>d<object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>b__2>d<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>b__2>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<MK.Client.FUIHelper.<>c__DisplayClass8_1.<<AddListnerAsync>b__2>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<MK.Client.FUIHelper.<>c__DisplayClass9_1.<<AddListnerAsync>b__2>d<object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<MK.Client.LobbyPanelHandler.<>c.<<CreateScene>b__4_0>d>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<UITest.<>c.<<Init>b__0_0>d>
	// Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<object>
	// Cysharp.Threading.Tasks.ITaskPoolNode<object>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.IUniTaskSource<object>
	// Cysharp.Threading.Tasks.TaskPool<object>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<object>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<object>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<object>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask<object>
	// Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit>
	// Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object>
	// System.Action<object,object,object,object>
	// System.Action<object,object,object>
	// System.Action<object,object>
	// System.Action<object>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.Comparer<byte>
	// System.Collections.Generic.Comparer<object>
	// System.Collections.Generic.Dictionary.Enumerator<int,MK.PanelInfo>
	// System.Collections.Generic.Dictionary.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,MK.PanelInfo>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection<int,MK.PanelInfo>
	// System.Collections.Generic.Dictionary.KeyCollection<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,MK.PanelInfo>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection<int,MK.PanelInfo>
	// System.Collections.Generic.Dictionary.ValueCollection<int,object>
	// System.Collections.Generic.Dictionary<int,MK.PanelInfo>
	// System.Collections.Generic.Dictionary<int,object>
	// System.Collections.Generic.EqualityComparer<MK.PanelInfo>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.EqualityComparer<byte>
	// System.Collections.Generic.EqualityComparer<int>
	// System.Collections.Generic.EqualityComparer<object>
	// System.Collections.Generic.HashSet.Enumerator<object>
	// System.Collections.Generic.HashSet<object>
	// System.Collections.Generic.HashSetEqualityComparer<object>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,MK.PanelInfo>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.ICollection<object>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,MK.PanelInfo>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<object>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,MK.PanelInfo>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerator<object>
	// System.Collections.Generic.IEqualityComparer<int>
	// System.Collections.Generic.IEqualityComparer<object>
	// System.Collections.Generic.KeyValuePair<int,MK.PanelInfo>
	// System.Collections.Generic.KeyValuePair<int,object>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.ObjectComparer<byte>
	// System.Collections.Generic.ObjectComparer<object>
	// System.Collections.Generic.ObjectEqualityComparer<MK.PanelInfo>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.ObjectEqualityComparer<byte>
	// System.Collections.Generic.ObjectEqualityComparer<int>
	// System.Collections.Generic.ObjectEqualityComparer<object>
	// System.Func<Cysharp.Threading.Tasks.UniTask>
	// System.Func<Cysharp.Threading.Tasks.UniTaskVoid>
	// System.Func<int>
	// System.Func<object,Cysharp.Threading.Tasks.UniTask>
	// System.Func<object,object,Cysharp.Threading.Tasks.UniTask>
	// System.Func<object,object,object,Cysharp.Threading.Tasks.UniTask>
	// System.Func<object,object,object,object,Cysharp.Threading.Tasks.UniTask>
	// System.Predicate<object>
	// System.Runtime.CompilerServices.ConditionalWeakTable.CreateValueCallback<object,object>
	// System.Runtime.CompilerServices.ConditionalWeakTable.Enumerator<object,object>
	// System.Runtime.CompilerServices.ConditionalWeakTable<object,object>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,object>>
	// System.ValueTuple<byte,object>
	// }}

	public void RefMethods()
	{
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,HotUpdate.GameLogic.MKSceneManager.<SceneChange>d__2>(Cysharp.Threading.Tasks.UniTask.Awaiter&,HotUpdate.GameLogic.MKSceneManager.<SceneChange>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>g__ClickActionAsync|0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>g__ClickActionAsync|0>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass10_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass10_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass11_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass11_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass8_0.<<AddListnerAsync>g__ClickActionAsync|0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass8_0.<<AddListnerAsync>g__ClickActionAsync|0>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass9_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass9_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,Core.UI.UIManager.<ShowPanelAsync>d__2>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,Core.UI.UIManager.<ShowPanelAsync>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,BattleTest.<CreateUnit>d__1>(Cysharp.Threading.Tasks.UniTask.Awaiter&,BattleTest.<CreateUnit>d__1&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,Core.UI.UIManager.<LoadFUIEntitysAsync>d__3>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,Core.UI.UIManager.<LoadFUIEntitysAsync>d__3&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Core.UI.UIManager.<ShowPanelAsync>d__2>(Core.UI.UIManager.<ShowPanelAsync>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<HotUpdate.GameLogic.MKSceneManager.<SceneChange>d__2>(HotUpdate.GameLogic.MKSceneManager.<SceneChange>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>g__ClickActionAsync|0>d>(MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>g__ClickActionAsync|0>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass10_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>>(MK.Client.FUIHelper.<>c__DisplayClass10_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass11_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>>(MK.Client.FUIHelper.<>c__DisplayClass11_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>>(MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>>(MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>>(MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass8_0.<<AddListnerAsync>g__ClickActionAsync|0>d>(MK.Client.FUIHelper.<>c__DisplayClass8_0.<<AddListnerAsync>g__ClickActionAsync|0>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass9_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>>(MK.Client.FUIHelper.<>c__DisplayClass9_0.<<AddListnerAsync>g__ClickActionAsync|0>d<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<MK.Client.LobbyPanelHandler.<CreateScene>d__4>(MK.Client.LobbyPanelHandler.<CreateScene>d__4&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.Start<BattleTest.<CreateUnit>d__1>(BattleTest.<CreateUnit>d__1&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.Start<Core.UI.UIManager.<LoadFUIEntitysAsync>d__3>(Core.UI.UIManager.<LoadFUIEntitysAsync>d__3&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>b__2>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>b__2>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass10_1.<<AddListnerAsync>b__2>d<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass10_1.<<AddListnerAsync>b__2>d<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass11_1.<<AddListnerAsync>b__2>d<object,object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass11_1.<<AddListnerAsync>b__2>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>b__2>d<object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>b__2>d<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>b__2>d<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>b__2>d<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>b__2>d<object,object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>b__2>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass8_1.<<AddListnerAsync>b__2>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass8_1.<<AddListnerAsync>b__2>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.FUIHelper.<>c__DisplayClass9_1.<<AddListnerAsync>b__2>d<object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.FUIHelper.<>c__DisplayClass9_1.<<AddListnerAsync>b__2>d<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,MK.Client.LobbyPanelHandler.<>c.<<CreateScene>b__4_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,MK.Client.LobbyPanelHandler.<>c.<<CreateScene>b__4_0>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,UITest.<>c.<<Init>b__0_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,UITest.<>c.<<Init>b__0_0>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,BattleTest.<<CreateCube>b__2_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,BattleTest.<<CreateCube>b__2_0>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<BattleTest.<<CreateCube>b__2_0>d>(BattleTest.<<CreateCube>b__2_0>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>b__2>d>(MK.Client.FUIHelper.<>c__DisplayClass0_0.<<AddListnerAsync>b__2>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass10_1.<<AddListnerAsync>b__2>d<object,object>>(MK.Client.FUIHelper.<>c__DisplayClass10_1.<<AddListnerAsync>b__2>d<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass11_1.<<AddListnerAsync>b__2>d<object,object,object>>(MK.Client.FUIHelper.<>c__DisplayClass11_1.<<AddListnerAsync>b__2>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>b__2>d<object>>(MK.Client.FUIHelper.<>c__DisplayClass1_0.<<AddListnerAsync>b__2>d<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>b__2>d<object,object>>(MK.Client.FUIHelper.<>c__DisplayClass2_0.<<AddListnerAsync>b__2>d<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>b__2>d<object,object,object>>(MK.Client.FUIHelper.<>c__DisplayClass3_0.<<AddListnerAsync>b__2>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass8_1.<<AddListnerAsync>b__2>d>(MK.Client.FUIHelper.<>c__DisplayClass8_1.<<AddListnerAsync>b__2>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<MK.Client.FUIHelper.<>c__DisplayClass9_1.<<AddListnerAsync>b__2>d<object>>(MK.Client.FUIHelper.<>c__DisplayClass9_1.<<AddListnerAsync>b__2>d<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<MK.Client.LobbyPanelHandler.<>c.<<CreateScene>b__4_0>d>(MK.Client.LobbyPanelHandler.<>c.<<CreateScene>b__4_0>d&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder.Start<UITest.<>c.<<Init>b__0_0>d>(UITest.<>c.<<Init>b__0_0>d&)
		// Cysharp.Threading.Tasks.UniTask.Awaiter Cysharp.Threading.Tasks.EnumeratorAsyncExtensions.GetAwaiter<object>(object)
		// System.Void Cysharp.Threading.Tasks.Internal.Error.ThrowArgumentNullException<object>(object,string)
		// object UnityEngine.Object.Instantiate<object>(object,UnityEngine.Transform,bool)
		// object YooAsset.AssetHandle.GetAssetObject<object>()
		// YooAsset.AssetHandle YooAsset.ResourcePackage.LoadAssetAsync<object>(string,uint)
		// YooAsset.AssetHandle YooAsset.YooAssets.LoadAssetAsync<object>(string,uint)
	}
}