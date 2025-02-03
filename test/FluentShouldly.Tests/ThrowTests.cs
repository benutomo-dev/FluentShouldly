using Shouldly;
using static FluentShouldly.Tests.ExtraAssertions;

namespace FluentShouldly.Tests;

public class ThrowTests
{
    [Fact]
    public void ShouldThrow1()
    {
        var ex = Should.Throw<InvalidOperationException>(new Action(() => throw new InvalidOperationException("exception message.")));
        ex.Message.Should().Be("exception message.");

        ShouldBeSameAssertion(
            () => Should.Throw<InvalidOperationException>(new Action(() => { })),
            () => Shouldly.Should.Throw<InvalidOperationException>(new Action(() => { }))
            );
    }

    [Fact]
    public void ShouldThrow2()
    {
        var ex = Should.Throw<InvalidOperationException>(new Func<object?>(() => throw new InvalidOperationException("exception message.")));
        ex.Message.Should().Be("exception message.");

        ShouldBeSameAssertion(
            () => Should.Throw<InvalidOperationException>(new Func<object?>(() => "")),
            () => Shouldly.Should.Throw<InvalidOperationException>(new Func<object?>(() => ""))
            );
    }

    [Fact]
    public void ShouldThrow3()
    {
        var ex = Should.Throw(new Action(() => throw new InvalidOperationException("exception message.")), typeof(InvalidOperationException));
        ex.Message.Should().Be("exception message.");

        ShouldBeSameAssertion(
            () => Should.Throw(new Action(() => { }), typeof(InvalidOperationException)),
            () => Shouldly.Should.Throw(new Action(() => { }), typeof(InvalidOperationException))
            );
    }

    [Fact]
    public void ShouldThrow4()
    {
        var ex = Should.Throw(new Func<object?>(() => throw new InvalidOperationException("exception message.")), typeof(InvalidOperationException));
        ex.Message.Should().Be("exception message.");

        ShouldBeSameAssertion(
            () => Should.Throw(new Func<object?>(() => ""), typeof(InvalidOperationException)),
            () => Shouldly.Should.Throw(new Func<object?>(() => ""), typeof(InvalidOperationException))
            );
    }

    [Fact]
    public void ShouldNotThrow1()
    {
        Should.NotThrow(new Action(() => { }));

        ShouldBeSameAssertion(
            () => Should.NotThrow(new Action(() => throw new InvalidOperationException("exception message."))),
            () => Shouldly.Should.NotThrow(new Action(() => throw new InvalidOperationException("exception message.")))
            );
    }

    [Fact]
    public void ShouldNotThrow2()
    {
        Should.NotThrow(new Func<object?>(() => ""));

        ShouldBeSameAssertion(
            () => Should.NotThrow(new Func<object?>(() => throw new InvalidOperationException("exception message."))),
            () => Shouldly.Should.NotThrow(new Func<object?>(() => throw new InvalidOperationException("exception message.")))
            );
    }


    [Fact]
    public async Task ShouldThrowAsync1_1()
    {
        {
            var ex = await Should.ThrowAsync<IOException>(new Func<Task>(() => throw new FileNotFoundException("exception message.")));
            ex.Message.Should().Be("exception message.");
        }

        {
            var ex = await Should.ThrowAsync<IOException>(new Func<Task>(() => throw new IOException("exception message.")));
            ex.Message.Should().Be("exception message.");
        }

        try { await Should.ThrowAsync<InvalidOperationException>(new Func<Task>(async () => await Task.CompletedTask)); }
        catch (ShouldAssertException ex)
        {
            ex.Message.Should().Be("""
                `new Func<Task>(async () => await Task.CompletedTask)`
                    should throw
                System.InvalidOperationException
                    but did not
                """);
        }

        try { await Should.ThrowAsync<IOException>(new Func<Task>(() => throw new ArgumentException("exception message."))); }
        catch (ShouldAssertException ex)
        {
            ex.Message.Should().Be("""
                `new Func<Task>(() => throw new ArgumentException("exception message."))`
                    should throw
                System.IO.IOException
                    but threw
                System.ArgumentException
                    with message
                "exception message."
                """);
        }
    }

    [Fact]
    public async Task ShouldThrowAsync1_2()
    {
        {
            var ex = await Should.ThrowAsync<IOException>(new Func<Task<object?>>(() => throw new FileNotFoundException("exception message.")));
            ex.Message.Should().Be("exception message.");
        }

        {
            var ex = await Should.ThrowAsync<IOException>(new Func<Task<object?>>(() => throw new IOException("exception message.")));
            ex.Message.Should().Be("exception message.");
        }

        try { await Should.ThrowAsync<InvalidOperationException>(new Func<Task<object?>>(async () => await Task.FromResult(0))); }
        catch (ShouldAssertException ex)
        {
            ex.Message.Should().Be("""
                `new Func<Task<object?>>(async () => await Task.FromResult(0))`
                    should throw
                System.InvalidOperationException
                    but did not
                """);
        }

        try { await Should.ThrowAsync<IOException>(new Func<Task<object?>>(() => throw new ArgumentException("exception message."))); }
        catch (ShouldAssertException ex)
        {
            ex.Message.Should().Be("""
                `new Func<Task<object?>>(() => throw new ArgumentException("exception message."))`
                    should throw
                System.IO.IOException
                    but threw
                System.ArgumentException
                    with message
                "exception message."
                """);
        }
    }


    [Fact]
    public async Task ShouldThrowAsync2_1()
    {
        {
            var ex = await Should.ThrowAsync(new Func<Task>(() => throw new FileNotFoundException("exception message.")), typeof(IOException));
            ex.Message.Should().Be("exception message.");
        }

        {
            var ex = await Should.ThrowAsync(new Func<Task>(() => throw new IOException("exception message.")), typeof(IOException));
            ex.Message.Should().Be("exception message.");
        }

        try { await Should.ThrowAsync(new Func<Task>(async () => await Task.CompletedTask), typeof(InvalidOperationException)); }
        catch (ShouldAssertException ex)
        {
            ex.Message.Should().Be("""
                `new Func<Task>(async () => await Task.CompletedTask)`
                    should throw
                System.InvalidOperationException
                    but did not
                """);
        }

        try { await Should.ThrowAsync(new Func<Task>(() => throw new ArgumentException("exception message.")), typeof(IOException)); }
        catch (ShouldAssertException ex)
        {
            ex.Message.Should().Be("""
                `new Func<Task>(() => throw new ArgumentException("exception message."))`
                    should throw
                System.IO.IOException
                    but threw
                System.ArgumentException
                    with message
                "exception message."
                """);
        }
    }

    [Fact]
    public async Task ShouldThrowAsync2_2()
    {
        {
            var ex = await Should.ThrowAsync(new Func<Task<object?>>(() => throw new FileNotFoundException("exception message.")), typeof(IOException));
            ex.Message.Should().Be("exception message.");
        }

        {
            var ex = await Should.ThrowAsync(new Func<Task<object?>>(() => throw new IOException("exception message.")), typeof(IOException));
            ex.Message.Should().Be("exception message.");
        }

        try { await Should.ThrowAsync(new Func<Task<object?>>(async () => await Task.FromResult(0)), typeof(InvalidOperationException)); }
        catch (ShouldAssertException ex)
        {
            ex.Message.Should().Be("""
                `new Func<Task<object?>>(async () => await Task.FromResult(0))`
                    should throw
                System.InvalidOperationException
                    but did not
                """);
        }

        try { await Should.ThrowAsync(new Func<Task<object?>>(() => throw new ArgumentException("exception message.")), typeof(IOException)); }
        catch (ShouldAssertException ex)
        {
            ex.Message.Should().Be("""
                `new Func<Task<object?>>(() => throw new ArgumentException("exception message."))`
                    should throw
                System.IO.IOException
                    but threw
                System.ArgumentException
                    with message
                "exception message."
                """);
        }
    }

    [Fact]
    public async Task ShouldNotThrowAsync1_1()
    {
        await Should.NotThrowAsync(new Func<Task>(async () => await Task.CompletedTask));
    }

    [Fact]
    public async Task ShouldNotThrowAsync1_2()
    {
        await Should.NotThrowAsync(new Func<Task<object?>>(async () => { await Task.CompletedTask; return ""; }));
    }
}
