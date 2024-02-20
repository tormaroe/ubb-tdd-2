import unittest
from calculator import add

class TestSum(unittest.TestCase):

    def test_sum_empty_string(self):
        self.assertEqual(add(''), 0)

    def test_sum_single_integer(self):
        self.assertEqual(add('5'), 5)

if __name__ == '__main__':
    unittest.main()