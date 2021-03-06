namespace Memstate
{
    public abstract class StorageProvider
    {
        public virtual void Initialize()
        {
        }

        public abstract IJournalReader CreateJournalReader();

        public abstract IJournalWriter CreateJournalWriter(long nextRecordNumber);

        public abstract IJournalSubscriptionSource CreateJournalSubscriptionSource();
    }
}