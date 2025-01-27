namespace EOM.TSHotelManager.FormUI
{
    public class LoadingProgress
    {
        private FrmProgress _frmProgress;

        public void Show()
        {
            if (_frmProgress == null || _frmProgress.IsDisposed)
            {
                _frmProgress = new FrmProgress();
            }

            Task.Run(() => _frmProgress.ShowDialog());
        }

        public void Close()
        {
            if (_frmProgress != null && !_frmProgress.IsDisposed)
            {
                _frmProgress.BeginInvoke(new Action(() =>
                {
                    _frmProgress.Close();
                }));
            }
        }
    }
}
