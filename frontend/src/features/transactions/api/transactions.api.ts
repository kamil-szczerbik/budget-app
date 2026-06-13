import { API_BASE_URL } from "../../../api/api.config";
import type { Transaction } from "../models/transaction";

const TRANSACTION_BASE_URL = API_BASE_URL + 'transactions';

export async function getTransactions(): Promise<Transaction[]> {
  const res = await fetch(TRANSACTION_BASE_URL);
  return res.json();
}