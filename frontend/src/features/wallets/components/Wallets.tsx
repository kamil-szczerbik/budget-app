import { useWallets } from "../hooks/useWallets";

export default function Wallets() {
  const wallets = useWallets();

  return (
    <>
      <h1>Wallets</h1>

      {wallets.map((wallet) => (
        <div key={wallet.id}>{wallet.id}</div>
      ))}
    </>
  );
}
