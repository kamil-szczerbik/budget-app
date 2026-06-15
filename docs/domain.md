# Domain Model

## Overview

The application is a personal finance management system. Users can track income, expenses, transfers between wallets, and analyze their financial situation over time.

---

## User

Represents an account in the system.

A user owns:
- wallets
- categories
- transactions

---

## Wallet

Represents a place where money is stored.

Examples:
- bank account
- cash
- savings account

---

## Wallet type

Represents a logical grouping of wallets. Used to help users organize and filter wallets by their purpose or nature.

Examples:
- bank Account
- cash
- savings
- investment

## Transaction

The core entity of the system.

Represents a movement of money.

Types:
- expense
- income
- transfer (between wallets)
- opening balance

---

## Transaction category

Used to group transactions.

Examples:
- food
- transport
- entertainment
- shopping
- home

---

## Currency

Represents the currency of wallets and transactions.

---