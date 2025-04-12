/*
 Navicat Premium Dump SQL

 Source Server         : local-MariaDB
 Source Server Type    : MariaDB
 Source Server Version : 101110 (10.11.10-MariaDB)
 Source Host           : localhost:3306
 Source Schema         : tshoteldb

 Target Server Type    : MariaDB
 Target Server Version : 101110 (10.11.10-MariaDB)
 File Encoding         : 65001

 Date: 11/04/2025 22:45:27
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for administrator
-- ----------------------------
DROP TABLE IF EXISTS `administrator`;
CREATE TABLE `administrator`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '自增长ID',
  `admin_number` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '管理员编号',
  `admin_account` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '管理员账号',
  `admin_password` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '管理员密码',
  `admin_type` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '管理员类型',
  `admin_name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '管理员名称',
  `is_admin` int(11) NULL DEFAULT NULL COMMENT '是否为超级管理员',
  `delete_mk` int(11) NULL DEFAULT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料新增人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料新增时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `admin_number`, `admin_account`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '管理员信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for administrator_type
-- ----------------------------
DROP TABLE IF EXISTS `administrator_type`;
CREATE TABLE `administrator_type`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '编号',
  `type_id` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '管理员类型',
  `type_name` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '管理员类型名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `type_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 8 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '管理员类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for app_banner
-- ----------------------------
DROP TABLE IF EXISTS `app_banner`;
CREATE TABLE `app_banner`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `banner_number` int(11) NOT NULL COMMENT '编号',
  `banner_content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '文字信息',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `banner_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '主页跑马灯信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for app_config_base
-- ----------------------------
DROP TABLE IF EXISTS `app_config_base`;
CREATE TABLE `app_config_base`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `url_no` int(11) NOT NULL COMMENT 'No',
  `url_addr` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '地址',
  PRIMARY KEY (`id`, `url_no`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '程序信息配置表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for app_version
-- ----------------------------
DROP TABLE IF EXISTS `app_version`;
CREATE TABLE `app_version`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `base_versionId` int(11) NOT NULL COMMENT '流水号',
  `base_version` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '版本号',
  PRIMARY KEY (`id`, `base_versionId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '应用程序版本控制表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for appointment_notice
-- ----------------------------
DROP TABLE IF EXISTS `appointment_notice`;
CREATE TABLE `appointment_notice`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `notice_no` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '公告编号',
  `notice_theme` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '公告主题',
  `notice_type` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '公告类型',
  `notice_time` datetime NOT NULL COMMENT '发布日期',
  `notice_content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '公告正文',
  `notice_department` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '发文部门',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `notice_no`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '公告表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for asset
-- ----------------------------
DROP TABLE IF EXISTS `asset`;
CREATE TABLE `asset`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `asset_number` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '资产编号',
  `asset_name` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '资产名称',
  `asset_value` decimal(16, 2) NOT NULL COMMENT '资产总值',
  `department_code` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '所属部门',
  `acquisition_date` datetime NOT NULL COMMENT '入库时间',
  `asset_source` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '资产来源',
  `acquired_by_employee` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '资产经办人',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `asset_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '酒店资产表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for card_code
-- ----------------------------
DROP TABLE IF EXISTS `card_code`;
CREATE TABLE `card_code`  (
  `id` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '编号',
  `province` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '省份',
  `city` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '城市',
  `district` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '地区',
  `district_code` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '地区识别码',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4489 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '身份证地区识别码表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for counter_rule
-- ----------------------------
DROP TABLE IF EXISTS `counter_rule`;
CREATE TABLE `counter_rule`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `rule_id` int(11) NOT NULL COMMENT '规则编号',
  `rule_name` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规格名称',
  `rule_desc` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规则描述',
  `now_id` int(11) NULL DEFAULT NULL COMMENT '当前ID',
  `prefix_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规则简写',
  `custo_format` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规则格式',
  `number_format` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '编号前缀',
  `separating_char` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规则分割符',
  `datains_usrid` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料新增人',
  `datains_time` datetime NULL DEFAULT NULL COMMENT '资料新增时间',
  `datachg_usrid` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_time` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `rule_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '业务流水号规则表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for custo_type
-- ----------------------------
DROP TABLE IF EXISTS `custo_type`;
CREATE TABLE `custo_type`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `custo_type` int(11) NOT NULL COMMENT '客户类型ID',
  `type_name` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '客户类型名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `custo_type`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '用户类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for customer
-- ----------------------------
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '索引ID',
  `custo_no` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '客户编号',
  `custo_name` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '客户姓名',
  `custo_tel` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '客户电话',
  `passport_type` int(11) NOT NULL COMMENT '证件类型',
  `passport_id` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '证件号码',
  `custo_address` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '客户地址',
  `custo_birth` datetime NULL DEFAULT NULL COMMENT '客户生日',
  `custo_type` int(11) NOT NULL COMMENT '客户类型',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  `custo_gender` int(11) NULL DEFAULT NULL COMMENT '客户性别',
  PRIMARY KEY (`id`, `custo_no`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '用户表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for customer_spend
-- ----------------------------
DROP TABLE IF EXISTS `customer_spend`;
CREATE TABLE `customer_spend`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `spend_number` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '记录编号',
  `room_no` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间编号',
  `custo_no` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '客户编号',
  `spend_name` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '商品名称',
  `apend_quantity` int(11) NOT NULL COMMENT '商品数量',
  `spend_price` decimal(65, 2) NOT NULL COMMENT '商品价格',
  `spend_amount` decimal(65, 2) NOT NULL COMMENT '消费总额',
  `spend_time` datetime NOT NULL COMMENT '消费时间',
  `settlement_status` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '结算状态',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `spend_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '商品消费表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for department
-- ----------------------------
DROP TABLE IF EXISTS `department`;
CREATE TABLE `department`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '索引ID',
  `dept_no` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '部门编号',
  `dept_name` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '部门名称',
  `dept_desc` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '部门描述',
  `dept_date` datetime NULL DEFAULT NULL COMMENT '创建时间(部门)',
  `dept_leader` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '部门主管',
  `dept_parent` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '上级部门',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `dept_no`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '部门表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '索引ID',
  `employee_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '工号',
  `employee_name` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '名字',
  `employee_date_of_birth` datetime NOT NULL COMMENT '出生日期',
  `employee_gender` int(11) NOT NULL COMMENT '性别',
  `employee_tel` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '电话',
  `employee_department` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '部门',
  `employee_nation` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '民族',
  `employee_address` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '居住地址',
  `employee_postion` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '职位',
  `card_type` int(11) NOT NULL COMMENT '证件类型',
  `card_number` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '证件号码',
  `employee_password` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '系统密码',
  `hire_time` datetime NOT NULL COMMENT '入职时间',
  `employee_political` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '面貌',
  `employee_quality` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学历',
  `email_address` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '邮箱地址',
  `delete_mk` int(11) NULL DEFAULT NULL COMMENT '删除标记',
  `enable_mk` int(11) NOT NULL COMMENT '禁用标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `employee_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '员工表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for employee_check
-- ----------------------------
DROP TABLE IF EXISTS `employee_check`;
CREATE TABLE `employee_check`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '自增长ID',
  `check_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '打卡ID',
  `employee_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '工号',
  `check_time` datetime NULL DEFAULT NULL COMMENT '打卡时间',
  `check_way` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '打卡方式',
  `check_state` int(11) NULL DEFAULT NULL COMMENT '打卡状态',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `check_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '员工打卡表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for employee_history
-- ----------------------------
DROP TABLE IF EXISTS `employee_history`;
CREATE TABLE `employee_history`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '自增长ID',
  `history_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '履历ID',
  `employee_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '工号',
  `start_date` datetime NOT NULL COMMENT '开始时间',
  `end_date` datetime NOT NULL COMMENT '结束时间',
  `position` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '职务',
  `company` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '公司',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `history_number` DESC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '员工履历表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for employee_pic
-- ----------------------------
DROP TABLE IF EXISTS `employee_pic`;
CREATE TABLE `employee_pic`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '自增长流水号',
  `employee_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '工号',
  `pic_url` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '照片路径',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '员工照片表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for energy_management
-- ----------------------------
DROP TABLE IF EXISTS `energy_management`;
CREATE TABLE `energy_management`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `information_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '编号',
  `room_no` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间编号',
  `use_date` datetime NOT NULL COMMENT '开始时间',
  `end_date` datetime NULL DEFAULT NULL COMMENT '结束时间',
  `water_use` decimal(65, 2) NOT NULL COMMENT '用水情况',
  `power_use` decimal(65, 2) NOT NULL COMMENT '用电情况',
  `recorder` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '记录人',
  `custo_no` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '客户编号',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `information_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '水电费信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for gender_type
-- ----------------------------
DROP TABLE IF EXISTS `gender_type`;
CREATE TABLE `gender_type`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `gender_number` int(11) NOT NULL COMMENT '性别ID',
  `gender_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '性别名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `gender_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '性别类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for menu
-- ----------------------------
DROP TABLE IF EXISTS `menu`;
CREATE TABLE `menu`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '自增长ID',
  `key` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '菜单键',
  `title` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '菜单标题',
  `path` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '菜单路径',
  `parent` int(11) NULL DEFAULT NULL COMMENT '父级ID',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 35 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '菜单表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for nation
-- ----------------------------
DROP TABLE IF EXISTS `nation`;
CREATE TABLE `nation`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '索引ID',
  `nation_no` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '民族编号',
  `nation_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '民族名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `nation_no`, `nation_name`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '民族信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for nav_bar
-- ----------------------------
DROP TABLE IF EXISTS `nav_bar`;
CREATE TABLE `nav_bar`  (
  `nav_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '导航控件流水号',
  `nav_name` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '导航控件名称',
  `nav_or` int(11) NULL DEFAULT NULL COMMENT '导航控件排序',
  `nav_pic` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '导航控件图片',
  `nav_event` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '导航控件事件',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  `margin_left` int(11) NULL DEFAULT NULL COMMENT '左边距',
  PRIMARY KEY (`nav_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '功能导航' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for operation_log
-- ----------------------------
DROP TABLE IF EXISTS `operation_log`;
CREATE TABLE `operation_log`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `operation_number` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '记录编号',
  `operation_time` datetime NOT NULL COMMENT '记录时间',
  `log_content` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `operation_account` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `operation_level` int(11) NULL DEFAULT NULL COMMENT '日志等级',
  `software_version` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `login_ip` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `request_path` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '请求路径',
  `query_string` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '查询参数',
  `elapsed_time` bigint(20) NULL DEFAULT NULL COMMENT '响应时间',
  `http_method` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '请求方式',
  `status_code` int(11) NULL DEFAULT NULL COMMENT '状态代码',
  `exception_message` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `exception_stacktrace` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `operation_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2220 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '系统操作日志表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for passport_type
-- ----------------------------
DROP TABLE IF EXISTS `passport_type`;
CREATE TABLE `passport_type`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `passport_number` int(11) NOT NULL COMMENT '证件类型ID',
  `passport_name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '证件类型名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `passport_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '证件类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for position
-- ----------------------------
DROP TABLE IF EXISTS `position`;
CREATE TABLE `position`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '索引ID',
  `position_no` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '职位编号',
  `position_name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '职位名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `position_no`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '职位表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for qualification
-- ----------------------------
DROP TABLE IF EXISTS `qualification`;
CREATE TABLE `qualification`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '索引ID',
  `education_no` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学历编号',
  `education_name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '学历名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `education_no`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '学历表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for reser
-- ----------------------------
DROP TABLE IF EXISTS `reser`;
CREATE TABLE `reser`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `reser_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '预约ID ',
  `custo_name` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '客户名字',
  `custo_tel` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '联系方式',
  `reser_way` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '预约方式',
  `reser_room` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '预约房号',
  `reser_date` datetime NULL DEFAULT NULL COMMENT '预约开始日期',
  `reser_end_date` datetime NULL DEFAULT NULL COMMENT '预约结束日期',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `reser_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '预约表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for reward_punishment
-- ----------------------------
DROP TABLE IF EXISTS `reward_punishment`;
CREATE TABLE `reward_punishment`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '自增长ID',
  `employee_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '工号',
  `reward_punishment_information` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '奖惩信息',
  `reward_punishment_type` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '奖惩类型',
  `reward_punishment_operator` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '录入人',
  `reward_punishment_time` datetime NULL DEFAULT NULL COMMENT '录入时间',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '员工奖惩记录表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for reward_punishment_type
-- ----------------------------
DROP TABLE IF EXISTS `reward_punishment_type`;
CREATE TABLE `reward_punishment_type`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `reward_punishment_type_number` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '奖惩类型ID',
  `reward_punishment_type_name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '奖惩类型名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `reward_punishment_type_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '奖惩类型' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for role
-- ----------------------------
DROP TABLE IF EXISTS `role`;
CREATE TABLE `role`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `role_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '角色编码',
  `role_name` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '角色名字',
  `role_description` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '角色描述',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '创建日期',
  `datachg_usr` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '更新日期',
  PRIMARY KEY (`id`, `role_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '角色' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for role_permission
-- ----------------------------
DROP TABLE IF EXISTS `role_permission`;
CREATE TABLE `role_permission`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `role_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '角色编码',
  `permission_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '权限编码',
  `datains_usr` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '创建日期',
  `datachg_usr` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '更新日期',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '角色权限关联表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for room
-- ----------------------------
DROP TABLE IF EXISTS `room`;
CREATE TABLE `room`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `room_no` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间编号',
  `room_type` int(11) NOT NULL COMMENT '房间类型',
  `custo_no` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '客户编号',
  `check_in_time` datetime NULL DEFAULT NULL COMMENT '入住时间',
  `check_out_time` datetime NULL DEFAULT NULL COMMENT '退房时间',
  `room_state_id` int(11) NOT NULL COMMENT '房间状态',
  `room_rent` decimal(65, 2) NOT NULL COMMENT '房屋租金',
  `room_deposit` decimal(65, 2) NULL DEFAULT NULL COMMENT '房屋押金',
  `room_position` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房屋位置',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `room_no`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '房屋表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for room_state
-- ----------------------------
DROP TABLE IF EXISTS `room_state`;
CREATE TABLE `room_state`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `room_state_number` int(11) NOT NULL COMMENT '房间状态ID',
  `room_state` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间状态名称',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `room_state_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '房间状态表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for room_type
-- ----------------------------
DROP TABLE IF EXISTS `room_type`;
CREATE TABLE `room_type`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `room_type` int(11) NOT NULL COMMENT '房间类型ID',
  `room_name` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '房间类型名称',
  `room_rent` decimal(65, 2) NOT NULL COMMENT '房间租金',
  `room_deposit` decimal(65, 2) NOT NULL COMMENT '房间押金',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `room_type`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '房间类型表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sellthing
-- ----------------------------
DROP TABLE IF EXISTS `sellthing`;
CREATE TABLE `sellthing`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `sell_no` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '商品编号',
  `sell_name` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '商品名称',
  `sell_price` decimal(65, 2) NOT NULL COMMENT '商品价格',
  `specification` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '规格型号',
  `stock` int(11) NOT NULL COMMENT '库存数量',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `sell_no`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '商品表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for supervision_statistics
-- ----------------------------
DROP TABLE IF EXISTS `supervision_statistics`;
CREATE TABLE `supervision_statistics`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `statistics_number` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '监管统计编号',
  `supervising_department` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '受监管部门',
  `supervision_progress` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '受监管部门总体概述',
  `supervision_loss` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '受监管部门交易情况',
  `supervision_score` int(11) NOT NULL COMMENT '受监管部门得分情况',
  `supervision_statistician` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '本次监管负责人',
  `supervision_advice` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '监管建议',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `statistics_number`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '监管统计表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for user_role
-- ----------------------------
DROP TABLE IF EXISTS `user_role`;
CREATE TABLE `user_role`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
  `role_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '角色编码',
  `user_number` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '用户编码',
  `datains_usr` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '创建日期',
  `datachg_usr` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '更新日期',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '用户角色关联表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for vip_rule
-- ----------------------------
DROP TABLE IF EXISTS `vip_rule`;
CREATE TABLE `vip_rule`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '索引ID',
  `rule_id` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '会员规则流水号',
  `rule_name` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '会员规则名称',
  `rule_value` decimal(65, 2) NOT NULL COMMENT '预设数值',
  `type_id` int(11) NOT NULL COMMENT '会员等级',
  `delete_mk` int(11) NOT NULL COMMENT '删除标记',
  `datains_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料创建人',
  `datains_date` datetime NULL DEFAULT NULL COMMENT '资料创建时间',
  `datachg_usr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '资料更新人',
  `datachg_date` datetime NULL DEFAULT NULL COMMENT '资料更新时间',
  PRIMARY KEY (`id`, `rule_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '会员等级规则表' ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
