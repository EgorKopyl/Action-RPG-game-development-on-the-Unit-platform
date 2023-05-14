using UnityEngine;
using static EquipmantManager;

public class PlayerStats : CharacterStats
{
    void Start()
    {
        EquipmantManager.instance.onEquipmentChanget += OnEquipmentChanget;
    }

    void OnEquipmentChanget(Equipments newItem, Equipments oldItem)
    {
        if (newItem != null)
        {
            statArmor.AddModifier(newItem.armorModifier);
            statDamage.AddModifier(newItem.damageModifier);
        }
        if (oldItem != null)
        {
            statArmor.RemoveModifier(oldItem.armorModifier);
            statDamage.RemoveModifier(oldItem.damageModifier);
        }
    }

}
