using BenchmarkDotNet.Attributes;
using BinaryTreeMaximumPathSum;

namespace PerformanceBenchmark;

public class BinaryTreeMaximumPathSumBenchmark
{
    [Benchmark]
    public void GetMaxPathSumBenchmark()
    {
        var root = new TreeNode(-10, new(9), new(20, new(15), new(7)));
        
        new BinaryTree(root).GetMaxPathSum();
    }

}
