import type { PaymentTransaction } from "../types/PaymentTransaction";
import "../styles/layout.css"
import "../styles/global.css"

interface Props {
  data: PaymentTransaction[];
}

export default function PaymentTransactionTable({ data }: Props) {
  return (
    <div className="transaction-table hide-scrollbar">
      <table className="min-w-full text-sm text-left">
        <thead className="bg-[#004f5c] text-white uppercase text-xs">
          <tr>
            <th className="px-4 py-3">Transaction ID</th>
            <th className="px-4 py-3 text-right">Amount</th>
            <th className="px-4 py-3">Currency</th>
            <th className="px-4 py-3">Created At</th>
          </tr>
        </thead>
        <tbody className="divide-y text-black">
          {data.map((item) => (
            <tr key={item.transactionId} className="hover:bg-gray-50">
              <td className="px-4 py-2 font-mono text-xs truncate max-w-[240px]">
                {item.transactionId}
              </td>
              <td className="px-4 py-2 text-right font-medium">
                {item.paymentAmount.toLocaleString()}
              </td>
              <td className="px-4 py-2">{item.currency}</td>
              <td className="px-4 py-2">
                {new Date(item.createdAt).toLocaleString()}
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
