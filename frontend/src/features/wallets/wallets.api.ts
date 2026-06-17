import { API_BASE_URL } from "@/api/api.config";
import type { Wallet } from "./models/wallet";

const WALLET_BASE_URL = API_BASE_URL + "wallets";

export async function getWallets(): Promise<Wallet[]> {
  const res = await fetch(WALLET_BASE_URL);
  return res.json();
}
