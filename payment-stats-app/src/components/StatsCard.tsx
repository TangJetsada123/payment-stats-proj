interface Props {
    label: string;
    value: number | string;
  }
  
  export function StatsCard({ label, value }: Props) {
    return (
      <div className="statscard-container">
        <div className="statscard-label">
          {label}
        </div>
        <div className="statscard-value">
          {value}
        </div>
      </div>
    );
  }
  