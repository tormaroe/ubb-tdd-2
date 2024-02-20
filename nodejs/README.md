Simple test project for JavaScript/Node.js using Mocha test framework. I followed instructions at https://mochajs.org/#getting-started. https://github.com/shouldjs/should.js was used for assertions.

## Running the tests

```
TMARO@lt-146418 MINGW64 /c/dev/ubb-tdd-2/nodejs
$ npm test

> test
> mocha

  calculator
    √ should have add function
    #add()
      √ should return 0 given no arguments
      √ should return 0 given an empty string
      √ should return 5 given an argument "5"

  4 passing (3ms)

```