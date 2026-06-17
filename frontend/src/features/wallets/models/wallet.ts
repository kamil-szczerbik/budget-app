export type Wallet = {
  readonly id: number;
  readonly isActive: boolean;
  readonly createdAt: Date;
  readonly deactivatedAt?: Date;
};
