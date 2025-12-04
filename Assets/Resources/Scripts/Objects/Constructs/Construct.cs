using Resources.Objects.Items.Tools;
using Resources.Utils.MUtils;

namespace Resources.Objects.Constructs {
	public abstract class Construct : MObject {
		protected string title;
		protected string description;
		protected float durability;
		protected ItemTool[] reqTools;
	}
}
