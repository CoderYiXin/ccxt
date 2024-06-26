import os
import sys

root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))))
sys.path.append(root)

# ----------------------------------------------------------------------------

# PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
# https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

# ----------------------------------------------------------------------------
# -*- coding: utf-8 -*-

from ccxt.test.exchange.base import test_shared_methods  # noqa E402

def test_borrow_interest(exchange, skipped_properties, method, entry, requested_code, requested_symbol):
    format = {
        'info': {},
        'account': 'BTC/USDT',
        'currency': 'USDT',
        'interest': exchange.parse_number('0.1444'),
        'interestRate': exchange.parse_number('0.0006'),
        'amountBorrowed': exchange.parse_number('30.0'),
        'timestamp': 1638230400000,
        'datetime': '2021-11-30T00:00:00.000Z',
    }
    empty_allowed_for = ['account']
    test_shared_methods.assert_structure(exchange, skipped_properties, method, entry, format, empty_allowed_for)
    test_shared_methods.assert_timestamp_and_datetime(exchange, skipped_properties, method, entry)
    test_shared_methods.assert_currency_code(exchange, skipped_properties, method, entry, entry['currency'], requested_code)
    test_shared_methods.assert_symbol(exchange, skipped_properties, method, entry, entry['account'], requested_symbol)
    test_shared_methods.assert_greater(exchange, skipped_properties, method, entry, 'interest', '0')
    test_shared_methods.assert_greater(exchange, skipped_properties, method, entry, 'interestRate', '0')
    test_shared_methods.assert_greater(exchange, skipped_properties, method, entry, 'amountBorrowed', '0')
