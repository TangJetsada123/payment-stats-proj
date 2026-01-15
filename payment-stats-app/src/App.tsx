import { useState } from 'react'
import './styles/global.css'
import './styles/layout.css'
import { StatsCard } from './components/StatsCard'
import { useEffect } from 'react'
import type { PaymentStats } from './types/PaymentStats'
import type { PaymentTransaction } from './types/PaymentTransaction'
import PaymentTransactionTable from './components/TransactionTable'

function App() {
  const [currency, setCurrency] = useState("");
  const [stats, setStats] = useState<PaymentStats | null>(null);
  const [list, setList] = useState<PaymentTransaction[]>([]);
  const [loading, setLoading] = useState(false);

  const load = async () => {
    setLoading(true);
    const qs = currency ? `?currency=${currency}` : "";

    try {
      const [statsRes, listRes] = await Promise.all([
        fetch(`http://localhost:5171/api/payments/stats${qs}`),
        fetch(`http://localhost:5171/api/payments/list${qs}`)
      ]);
      //API Path need to get configs from env to protect hard code in setting path.

      setStats(await statsRes.json());
      setList(await listRes.json());
    } catch (error) {
      console.error("Error loading data:", error);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    load();
  }, []);

  return (
    <div className="dashboard-layout">
      <div className="dashboard-container">
        <div className="flex items-center justify-between">
          <h1 className="text-topic">
            2C2P Payment Stats Dashboard
          </h1>
          <div className="flex gap-2">
            <input
              value={currency}
              onChange={e => setCurrency(e.target.value)}
              placeholder="Currency"
              className="currency-input"
            />
            <button
              onClick={load}
              className="apply-btn"
            >
              Apply
            </button>
          </div>
        </div>

        {stats && (
          <div className="statscard">
            <StatsCard label="Minimum" value={stats.min.toLocaleString()} />
            <StatsCard label="Maximum" value={stats.max.toLocaleString()} />
            <StatsCard label="Average" value={stats.average.toLocaleString()} />
            <StatsCard label="Count" value={stats.count.toString()} />
          </div>
        )}

        <div>
          <h2 className="text-lg font-semibold mb-3 text-black">
            Transactions
          </h2>
          {loading ? (
            <div className="flex justify-center py-10">
               <p className="text-gray-500 animate-pulse">Loading...</p>
            </div>
          ) : (
            <PaymentTransactionTable data={list} />
          )}
        </div>

      </div>
    </div>
  )
}

export default App