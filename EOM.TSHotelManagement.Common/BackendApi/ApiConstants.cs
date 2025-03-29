using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOM.TSHotelManagement.Common
{
    public class ApiConstants
    {
        public const string GetAllAdmin = "Administrator/GetAllAdmin";
        public const string GetAllAdminTypes = "Administrator/GetAllAdminTypes";
        public const string AddAdmin = "Administrator/AddAdmin";
        public const string SelectRoomTypeByType = "RoomType/SelectRoomTypeByType";
        public const string InsertRoom = "Room/InsertRoom";
        public const string SelectRoomTypesAll = "RoomType/SelectRoomTypesAll";
        public const string SelectRoomAll = "Room/SelectRoomAll";
        public const string SelectRoomByRoomNo = "Room/SelectRoomByRoomNo";
        public const string UpdAccount = "Administrator/UpdAccount";
        public const string GetAdminInfoByAdminAccount = "Administrator/GetAdminInfoByAdminAccount";
        public const string GetAllModuleByAdmin = "Module/GetAllModuleByAdmin";
        public const string GetAllModule = "Module/GetAllModule";
        public const string DelModuleZeroList = "Module/DelModuleZeroList";
        public const string AddModuleZeroList = "Module/AddModuleZeroList";
        public const string SelectDeptAllCanUse = "Base/SelectDeptAllCanUse";
        public const string SelectWorkerAll = "Employee/SelectWorkerAll";
        public const string SelectCashInfoAll = "Cash/SelectCashInfoAll";
        public const string AddCashInfo = "Cash/AddCashInfo";
        public const string UpdateNewPwdByOldPwd = "Administrator/UpdateNewPwdByOldPwd";
        public const string SelectMangerByPass = "Administrator/SelectMangerByPass";
        public const string SelectPositionAll = "Base/SelectPositionAll";
        public const string UpdateWorkerPositionAndClub = "Employee/UpdateWorkerPositionAndClub";
        public const string SelectCanUseRoomAll = "Room/SelectCanUseRoomAll";
        public const string DayByRoomNo = "Room/DayByRoomNo";
        public const string UpdateRoomInfo = "Room/UpdateRoomInfo";
        public const string UpdateRoomByRoomNo = "Room/UpdateRoomByRoomNo";
        public const string SelectSpendByCustoNo = "Spend/SelectSpendByCustoNo";
        public const string UpdateSpendInfoByRoomNo = "Spend/UpdateSpendInfoByRoomNo";
        public const string InsertSpendInfo = "Spend/InsertSpendInfo";
        public const string SelectRoomTypeByRoomNo = "RoomType/SelectRoomTypeByRoomNo";
        public const string SelectCustoAll = "Custo/SelectCustoAll";
        public const string SelectVipRuleList = "VipLevelRule/SelectVipRuleList";
        public const string SeletHistorySpendInfoAll = "Spend/SeletHistorySpendInfoAll";
        public const string UpdCustomerTypeByCustoNo = "Custo/UpdCustomerTypeByCustoNo";
        public const string SelectCardInfoByCustoNo = "Custo/SelectCardInfoByCustoNo";
        public const string SelectCheckInfoAll = "SupervisionStatistics/SelectCheckInfoAll";
        public const string SelectCustoTypeAllCanUse = "Base/SelectCustoTypeAllCanUse";
        public const string SelectPassPortTypeAllCanUse = "Base/SelectPassPortTypeAllCanUse";
        public const string SelectSexTypeAll = "Base/SelectSexTypeAll";
        public const string SelectSpendInfoRoomNo = "Spend/SelectSpendInfoRoomNo";
        public const string SelectMoneyByRoomNoAndTime = "Spend/SelectMoneyByRoomNoAndTime";
        public const string SelectWtiInfo = "EnergyManagement/SelectWtiInfo";
        public const string InsertWtiInfo = "HydroelectricPower​/InsertWtiInfo";
        public const string UpdateMoneyState = "Spend​/UpdateMoneyState";
        public const string SelectCustoByInfo = "Custo​/SelectCustoByInfo";
        public const string SelectSpendInfoAll = "Spend​/SelectSpendInfoAll";
        public const string AddDept = "Base​/AddDept";
        public const string UpdDept = "Base​/UpdDept";
        public const string CheckWorkerBydepartment = "Employee​/CheckWorkerBydepartment";
        public const string DelDept = "Base​/DelDept";
        public const string UpdCustomerInfo = "Custo​/UpdCustomerInfo";
        public const string InsertCustomerInfo = "Custo​/InsertCustomerInfo";
        public const string AddLog = "App/AddLog";
    }
}
