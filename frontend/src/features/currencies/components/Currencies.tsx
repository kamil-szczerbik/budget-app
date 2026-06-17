import { useCurrencies } from "../hooks/useCurrencies";

export default function Currencies() {
  const currencies = useCurrencies();

  return (
    <>
      <h1>Currencies</h1>

      {currencies.map((currency) => (
        <div key={currency.id}>{currency.code}</div>
      ))}
    </>
  );
}
