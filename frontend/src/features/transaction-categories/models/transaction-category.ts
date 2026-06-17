import type { TransactionCategoryType } from "./transaction-category-type";

export type TransactionCategory = {
  readonly id: number;
  readonly name: string;
  readonly type: TransactionCategoryType;
  readonly parentId?: number;
};
