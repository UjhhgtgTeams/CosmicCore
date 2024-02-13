using CosmicCore.Protos;
using CosmicCore.Server.Utilities.Resource.Resources;
using Item = CosmicCore.Server.Gate.Services.Inventory.Item;

namespace CosmicCore.Server.Gate.Services.Utils;

public static class PacketExtensionMethods
{
    public static PlayerSyncScNotify AddItem(this PlayerSyncScNotify packet, Item item)
    {
        switch (item.Excel.ItemMainType.TabType())
        {
            case InventoryTabType.MATERIAL:
                packet.MaterialList.Add(item.ToMaterialProto());
                break;
            case InventoryTabType.RELIC:
                if (item.Count > 0)
                {
                    packet.RelicList.Add(item.ToRelicProto());
                }
                else
                {
                    packet.DelRelicList.Add((uint)item.InternalId);
                }

                break;
            case InventoryTabType.EQUIPMENT:
                if (item.Count > 0)
                {
                    packet.EquipmentList.Add(item.ToEquipmentProto());
                }
                else
                {
                    packet.DelEquipmentList.Add((uint)item.InternalId);
                }

                break;
        }

        // although this method does not have to return the packet, i did this just for convenience
        return packet;
    }
}
