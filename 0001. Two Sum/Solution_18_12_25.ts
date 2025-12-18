function twoSum(nums: number[], target: number): number[] {
    var map = new Map<number, number>();

    for (let i  = 0; i < nums.length; i++) {
        if (map.has(nums[i])) {
            return [map.get(nums[i])!, i];
        }
        let diff = target - nums[i];
        map.set(diff, i);
    }
    return [];
};