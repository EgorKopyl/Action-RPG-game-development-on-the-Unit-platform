using UnityEngine;
using UnityEngine.UI;

public class EquipmantManager : MonoBehaviour
{
    #region Singleton
    public static EquipmantManager instance;
    private void Awake()
    {
        instance =this;
    }
    #endregion Singleton
    public SkinnedMeshRenderer targetMesh;
    Equipments[] currentEquipmants;
    SkinnedMeshRenderer[] currentMeshes;
    public delegate void OnEquipmentChanget(Equipments newItem, Equipments oldItem);
    public OnEquipmentChanget onEquipmentChanget;
    Inventory inventory;
    public Button butUnequip;
    public Equipments[] defaultItems;
    void Start()
    {
        inventory = Inventory.instance;
        int numSlots = System.Enum.GetNames(typeof(EquipmentSlots)).Length;
        currentEquipmants = new Equipments[numSlots];
        currentMeshes = new SkinnedMeshRenderer[numSlots];
        EquipDefaultItems();
    }
    public void Equip(Equipments newItem)
    {
        int slotIndex = (int)newItem.equipSlot;
        Equipments oldItem = null;
        if(onEquipmentChanget != null)
        {
            onEquipmentChanget.Invoke(newItem, oldItem);
        }
        currentEquipmants[slotIndex] = newItem;
        SkinnedMeshRenderer newMesh = Instantiate<SkinnedMeshRenderer>(newItem.mesh);
        newMesh.transform.parent = targetMesh.transform;

        newMesh.bones = targetMesh.bones;
        newMesh.rootBone = targetMesh.rootBone;
        currentMeshes[slotIndex] = newMesh;

    }
    public Equipments Unequip(int slotIndex)
    {
        if (currentEquipmants[slotIndex]!= null)
        {
            if(currentMeshes[slotIndex]!= null)
            {
                Destroy(currentMeshes[slotIndex].gameObject);
            }
            Equipments oldItem = currentEquipmants[slotIndex];
            inventory.Add(oldItem);
            currentEquipmants[slotIndex] = null;

            if(onEquipmentChanget!= null)
            {
                onEquipmentChanget.Invoke(null, oldItem);
            }
            return oldItem;
        }
        return null;
    }
    public void UnequipAll()
    {
        for ( int i = 0; i <currentEquipmants.Length; i++ )
        {
            Unequip(i);
        }
        EquipDefaultItems();
    }

    void EquipDefaultItems()
    {
        foreach (Equipments item in defaultItems)
        {
            Equip(item);
        }
    }

}
