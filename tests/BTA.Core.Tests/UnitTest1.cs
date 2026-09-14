
using Xunit;
using BTA.Core;

namespace BTA.Core.Tests;

public class LayoutConverterTests
{
    [Fact]
    public void Converts_sghl_to_سلام()
    {
        Assert.Equal("سلام", LayoutConverter.ConvertLayout("sghl"));
    }

    [Fact]
    public void Converts_سلام_back_to_sghl()
    {
        Assert.Equal("sghl", LayoutConverter.ConvertLayout("سلام"));
    }
}