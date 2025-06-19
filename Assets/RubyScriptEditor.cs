using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditorInternal;
using System.Collections;

//[CustomEditor(typeof(RubyScript), true)]
public class RubyScriptEditor {/*: Editor {

    public ReorderableList InventoryList;

    private RubyScript _evCtrl = null;
    void OnEnable()
    {
        _evCtrl = (RubyScript)target;
        InventoryList = new ReorderableList(_evCtrl.inventoryContent, typeof(RubyScript), true, true, true, true);

        InventoryList.drawHeaderCallback += DrawHeader;
        InventoryList.drawElementCallback += DrawElement;


        InventoryList.onAddCallback += AddItem;
        InventoryList.onRemoveCallback += RemoveItem;
    }

    void OnDisable()
    {
        InventoryList.drawHeaderCallback -= DrawHeader;
        InventoryList.drawElementCallback -= DrawElement;

        InventoryList.onAddCallback -= AddItem;
        InventoryList.onRemoveCallback -= RemoveItem;
    }

    private void DrawHeader(Rect rect)
    {
        GUI.Label(rect, "Inventory");
    }

    private void DrawElement(Rect rect, int index, bool active, bool focused)
    {
        EditorGUI.BeginChangeCheck();
        _evCtrl.inventoryContent[index] = (Button)EditorGUI.ObjectField(new Rect(rect.x, rect.y, 250, rect.height), _evCtrl.inventoryContent[index], typeof(Button), true);
         if (EditorGUI.EndChangeCheck())
        {
            EditorUtility.SetDirty(target);
        }
    }

    private void AddItem(ReorderableList list)
    {
        _evCtrl.inventoryContent.Add(null);
        EditorUtility.SetDirty(target);
    }

    private void RemoveItem(ReorderableList list)
    {
        _evCtrl.inventoryContent.RemoveAt(list.index);
        EditorUtility.SetDirty(target);
    }
    
        public override void OnInspectorGUI()
        {
            GUILayout.BeginHorizontal();
            _evCtrl.CombatMenu = EditorGUILayout.Toggle("Combat Menu", _evCtrl.CombatMenu);
            GUILayout.EndHorizontal();
            if (_evCtrl.CombatMenu == true)
            {
                _evCtrl.InventoryMenu = false;
                GUILayout.Space(5);
                GUILayout.BeginHorizontal();
                _evCtrl.Self = (CanvasGroup)EditorGUILayout.ObjectField(_evCtrl.Self, typeof(CanvasGroup), true);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                _evCtrl.XButton = (Button)EditorGUILayout.ObjectField(_evCtrl.XButton, typeof(Button), true);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                _evCtrl.ImageA = (Image)EditorGUILayout.ObjectField(_evCtrl.ImageA, typeof(Image), true);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                _evCtrl.ImageB = (Image)EditorGUILayout.ObjectField(_evCtrl.ImageB, typeof(Image), true);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                _evCtrl.ImageC = (Image)EditorGUILayout.ObjectField(_evCtrl.ImageC, typeof(Image), true);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                _evCtrl.ImageD = (Image)EditorGUILayout.ObjectField(_evCtrl.ImageD, typeof(Image), true);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                _evCtrl.DefaultImage = (Sprite)EditorGUILayout.ObjectField(_evCtrl.DefaultImage, typeof(Sprite), true);
                GUILayout.EndHorizontal();
            }

                //public Button AnchorButton;
    //public Vector3 AnchorPos; 
    //public List<Button> inventoryContent;

            GUILayout.BeginHorizontal();
            _evCtrl.InventoryMenu = EditorGUILayout.Toggle("Inventory Menu", _evCtrl.InventoryMenu);
            GUILayout.EndHorizontal();

            if (_evCtrl.InventoryMenu  == true)
            {
                _evCtrl.CombatMenu = false;
                GUILayout.Space(5);
                GUILayout.BeginHorizontal();
                _evCtrl.Self = (CanvasGroup)EditorGUILayout.ObjectField("Inventory Menu", _evCtrl.Self, typeof(CanvasGroup), true);
                GUILayout.EndHorizontal();

                GUILayout.Space(5);
                GUILayout.BeginHorizontal();
                _evCtrl.User = (ROverlay)EditorGUILayout.ObjectField("Inventory Menu", _evCtrl.User, typeof(ROverlay), true);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                //_evCtrl.AnchorButton = (Button)EditorGUILayout.ObjectField("Anchor Button", _evCtrl.AnchorButton, typeof(Button), true);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                //_evCtrl.AnchorPos.x = EditorGUILayout.FloatField("Position X",_evCtrl.AnchorPos.x);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                //_evCtrl.AnchorPos.y = EditorGUILayout.FloatField("Position Y", _evCtrl.AnchorPos.y);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                //_evCtrl.AnchorPos.z = EditorGUILayout.FloatField("Position Z", _evCtrl.AnchorPos.z);
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                _evCtrl.XButton = (Button)EditorGUILayout.ObjectField(_evCtrl.XButton, typeof(Button), true);
                GUILayout.EndHorizontal();

                GUILayout.Space(5);
                GUILayout.BeginHorizontal();
                _evCtrl.scroller = (ScrollRect)EditorGUILayout.ObjectField("Inventory Scroller", _evCtrl.scroller, typeof(ScrollRect), true);
                GUILayout.EndHorizontal();
                InventoryList.DoLayoutList();
            }
        }

	    // Use this for initialization
	    void Start () {
	
	    }
	
	    // Update is called once per frame
	    void Update () {
	
	    }
}*/
}
