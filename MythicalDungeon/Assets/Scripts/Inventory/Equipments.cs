using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName ="Inventory/Equipment")]
public class Equipments : Item
{
    public EquipmentSlots equipSlot;
    public SkinnedMeshRenderer mesh;
    public int armorModifier;
    public int damageModifier;
    public override void Use()
    {
        base.Use();
        EquipmantManager.instance.Equip(this);
        RemoveFromInventory();
    }
    
}
public enum EquipmentSlots { Head, Chest, Legs, Weapon, Shield, Feet}