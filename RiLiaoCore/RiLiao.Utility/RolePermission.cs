namespace RiLiao.Utility
{
    // 用户角色权限枚举
    public enum RolePermission
    {
        // 读取信息
        Read = 0,
        // 添加进货记录
        AddPO = 1,
        // 更新进货记录
        UpdatePO = 2,
        // 删除进货记录
        DeletePO = 3,
        // 添加供应商
        AddVendor = 4,
        // 更新供应商信息
        UpdateVendor = 5,
        // 删除供应商信息
        DeleteVendor = 6,
        // 添加用户
        AddUser = 7,
        // 更新用户信息
        UpdateUser = 8,
        // 删除用户信息
        DeleteUser = 9,
        // 添加权限规则
        AddRules = 10,
        // 更新权限规则
        UpdateRules = 11,
        // 删除权限规则
        DeleteRules = 12
    }
}
