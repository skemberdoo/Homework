using System;
using System.Collections.Generic;

public class Branch
{
    public string Name { get; set; }
    public List<Branch> Branches { get; set; }

    public Branch(string name)
    {
        Name = name;
        Branches = new List<Branch>();
    }
}

public class Program
{
    public static int CalculateDepth(Branch branch)
    {
        if (branch.Branches.Count == 0)
        {
            return 1;
        }
        else
        {
            int maxDepth = 0;
            foreach (var child in branch.Branches)
            {
                int childDepth = CalculateDepth(child);
                if (childDepth > maxDepth)
                {
                    maxDepth = childDepth;
                }
            }
            return maxDepth + 1;
        }
    }

    public static void Main(string[] args)
    {
        
        Branch branch5 = new Branch("Branch 5");
        Branch branch4 = new Branch("Branch 4");
        branch4.Branches.Add(branch5);
        Branch branch3 = new Branch("Branch 3");
        branch3.Branches.Add(branch4);
        Branch branch2 = new Branch("Branch 2");
        branch2.Branches.Add(branch3);
        Branch branch1 = new Branch("Branch 1");
        branch1.Branches.Add(branch2);

        int depth = CalculateDepth(branch1);
        Console.WriteLine("Depth: " + depth);
    }
}
