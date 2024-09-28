using BinaryTreeMaximumPathSum;

namespace UnitTests;

public class BinaryTreeUnitTest
{
    [Fact]
    public void GetMaxPathSum_Should_Return_42()
    {
        var root = new TreeNode(-10, new(9), new(20, new(15), new(7)));

        var max = new BinaryTree(root).GetMaxPathSum();

        Assert.Equal(42, max);
    }

    [Fact]
    public void GetMaxPathSum_Should_Return_2()
    {
        var root = new TreeNode(2, new(-1));

        var max = new BinaryTree(root).GetMaxPathSum();

        Assert.Equal(2, max);
    }
  
    [Fact]
    public void GetMaxPathSum_Should_Return_minus_3()
    {
        var root = new TreeNode(-3);

        var max = new BinaryTree(root).GetMaxPathSum();

        Assert.Equal(-3, max);
    }
}