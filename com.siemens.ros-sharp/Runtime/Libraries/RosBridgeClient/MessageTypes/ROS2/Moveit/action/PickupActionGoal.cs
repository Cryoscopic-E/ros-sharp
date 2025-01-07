/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2
using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Action;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class PickupActionGoal : ActionGoal<PickupGoal>
    {
        public const string RosMessageName = "moveit_msgs/action/PickupActionGoal";

        public PickupActionGoal() : base()
        {
            this.args = new PickupGoal();
        }

        public PickupActionGoal(Header header, GoalInfo goalInfo, PickupGoal args) : base(header, goalInfo)
        {
            this.args = args;
        }
    }
}
#endif
