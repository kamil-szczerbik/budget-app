export type Transaction = {
  readonly id: number;
  readonly date: Date;
  readonly amount: number;
  readonly description?: string;
};
