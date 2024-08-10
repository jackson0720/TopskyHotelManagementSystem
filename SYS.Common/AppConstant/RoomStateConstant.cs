using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    public static class RoomStateConstant
    {
        // 定义一个枚举来表示房间状态
        public enum State
        {
            Empty,   // 空房
            Occupied, // 已住
            UnderRepair, // 维修
            Dirty,    // 脏房
            Reserved, // 预约
        }

        // 使用一个静态类来存储状态的详细信息
        public static class StateInfo
        {
            // 定义一个结构体来存储每个状态的详细信息
            public struct StateDetail
            {
                public string Code { get; }
                public string Description { get; }

                public StateDetail(string code, string description)
                {
                    Code = code;
                    Description = description;
                }
            }

            // 使用一个字典来存储状态信息
            private static readonly Dictionary<State, StateDetail> _stateDetails = new Dictionary<State, StateDetail>
            {
                { State.Empty, new StateDetail("0", "空房") },
                { State.Occupied, new StateDetail("1", "已住") },
                { State.UnderRepair, new StateDetail("2", "维修") },
                { State.Dirty, new StateDetail("3", "脏房") },
                { State.Reserved, new StateDetail("4", "预约") }
            };

            // 获取状态的详细信息
            public static StateDetail GetStateDetail(State state)
            {
                return _stateDetails.TryGetValue(state, out var detail) ? detail : default;
            }

            // 获取所有状态的详细信息列表
            public static List<StateDetail> GetAllStateDetails()
            {
                return _stateDetails.Values.ToList();
            }
        }
    }
}
