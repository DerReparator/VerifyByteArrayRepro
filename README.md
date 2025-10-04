This issue was fixed in [Verify 30.20.0](https://github.com/VerifyTests/Verify/milestone/430) ([EmptyFiles 8.14.0](https://github.com/VerifyTests/EmptyFiles/milestone/41)). Thank you!

# Verify.Xunit byte[] Repro

This repo was created to show a bug in [Verify.Xunit](https://github.com/VerifyTests/Verify). If you want to verify a `byte[]` no `*.verified.*` file is created automatically.

## How to use

Execute the _ArrayCalculatorTests.TestThat3ElementsAreCorrectlyCreated_ test which works fine (a `*.verified.*` file was created).

Execute the _ArrayCalculatorTests.TestThat5ElementsAreCorrectlyCreated_ test which reproduces the problem: no `*.verified.*` file is created and so the test stays red.
