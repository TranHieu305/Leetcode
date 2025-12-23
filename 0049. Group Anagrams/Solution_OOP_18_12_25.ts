interface IAnagramStragegy {
    makeKey(str: string): string;
}

class SortAnagramStragegy implements IAnagramStragegy {
    makeKey(str: string): string {
        return str.split("").sort().join("");
    }
}

class AnagramGroups {
    private groups = new Map<string, string[]>();

    add(key : string, str : string): void {
        let arr = this.groups.get(key) || this.groups.set(key, []).get(key);
        arr!.push(str);
    }

    toArray(): string[][] {
        return Array.from(this.groups.values());
    }
}

class AnagramGrouper {
    private readonly stragegy: IAnagramStragegy;

    constructor(stragegy: IAnagramStragegy){
        this.stragegy = stragegy;
    }

    group(words: string[]): string[][] {
        const groups = new AnagramGroups();

        words.forEach(word => {
            const key = this.stragegy.makeKey(word);
            groups.add(key, word);
        });
        
        return groups.toArray();
    }
}


function groupAnagrams(strs: string[]): string[][] {
    const sortStragegy = new SortAnagramStragegy();
    const grouper = new AnagramGrouper(sortStragegy)
    return grouper.group(strs);
};