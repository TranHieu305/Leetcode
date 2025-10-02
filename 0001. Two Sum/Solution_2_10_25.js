/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
    var dict = {};
    let result = [];
    nums.forEach((value, index) => {
        var other = target - value;
        if (dict.hasOwnProperty(other)) {
            result = [index, dict[other]]
        }
        else {
            dict[value] = index;
        }

    });

    return result;
};