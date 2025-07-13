namespace EOM.TSHotelManagement.FormUI
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

            if (!_frmProgress.Visible)
            {
                _frmProgress.Visible = false;
                Task.Run(() => _frmProgress.ShowDialog());
            }
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
