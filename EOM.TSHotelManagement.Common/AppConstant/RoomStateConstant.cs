namespace EOM.TSHotelManagement.Common
{
    public class RoomStateConstant : Constant<RoomStateConstant>
    {
        // 空房
        public static readonly RoomStateConstant Vacant = new RoomStateConstant("1", "空房");
        // 已住
        public static readonly RoomStateConstant Occupied = new RoomStateConstant("2", "已住");
        // 维修
        public static readonly RoomStateConstant Maintenance = new RoomStateConstant("3", "维修");
        // 脏房
        public static readonly RoomStateConstant Dirty = new RoomStateConstant("4", "脏房");
        // 预约
        public static readonly RoomStateConstant Reserved = new RoomStateConstant("5", "预约");

        private RoomStateConstant(string code, string description) : base(code, description)
        {
        }
    }
}
