using WCell.Constants;
using WCell.Constants.Items;
using WCell.Constants.World;
using WCell.RealmServer.Content;
using WCell.RealmServer.Global;
using WCell.Util;
using WCell.Util.Data;
using WCell.Util.Graphics;

namespace WCell.RealmServer.AreaTriggers
{
    [DataHolder]
    public class ATTemplateTavern : ATTemplate, IDataHolder
    {
        public new void FinalizeDataHolder()
        {
            var trigger = AreaTriggerMgr.AreaTriggers.Get(Id);
            if (trigger == null)
            {
                ContentMgr.OnInvalidDBData("AreaTriggerEntry {0} (#{1}, Type: {2}) had invalid AreaTrigger-id.", Name, Id, Type);
                return;
            }
            else
            {
                trigger.Template = this;
            }

            Handler = AreaTriggerMgr.GetHandler(Type);
        }
    }
}
