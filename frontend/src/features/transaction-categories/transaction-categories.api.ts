import { API_BASE_URL } from "@/api/api.config";
import type { TransactionCategory } from "./models/transaction-category";

const TRANSACTION_CATEGORY_BASE_URL = API_BASE_URL + "transaction-categories";

export async function getTransactionCategories(): Promise<TransactionCategory[]> {
  const res = await fetch(TRANSACTION_CATEGORY_BASE_URL);
  return res.json();
}
