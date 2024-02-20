var should = require('should');
var calculator = require('../calculator');

describe('calculator', function () {
    it('should have add function', function () {
        calculator.add.should.be.an.instanceOf(Function);
    });
    describe('#add()', function () {
        it('should return 0 given no arguments', function () {
            calculator.add().should.be.exactly(0);
        });
        it('should return 0 given an empty string', function () {
            calculator.add('').should.be.exactly(0);
        });
        it('should return any single integer', function () {
            calculator.add('5').should.be.exactly(5);
        });
        if('should add two integers');
        // .. and so on
    });
});