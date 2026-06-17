export const TransactionCategoryType = {
  Expense: "expense",
  Income: "income",
};

export type TransactionCategoryType =
  (typeof TransactionCategoryType)[keyof typeof TransactionCategoryType];
