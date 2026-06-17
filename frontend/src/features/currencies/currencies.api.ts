import { API_BASE_URL } from "@/api/api.config";
import type { Currency } from "./models/currency";

const CURRENCIES_BASE_URL = API_BASE_URL + "currencies";

export async function getCurrencies(): Promise<Currency[]> {
  const res = await fetch(CURRENCIES_BASE_URL);
  return res.json();
}
