using System.Globalization;

namespace Examen_RentaCar_JohanAlexander;

public class frmAlquiler : Form
{
    private readonly TextBox txtCliente = new();
    private readonly DateTimePicker dtpSalida = new();
    private readonly CheckBox chkCorporativo = new();
    private readonly TextBox txtVehiculo = new();
    private readonly TextBox txtTarifa = new();
    private readonly NumericUpDown nudDias = new();
    private readonly RadioButton rbtBasico = new();
    private readonly RadioButton rbtCompleto = new();
    private readonly RadioButton rbtSucursal = new();
    private readonly RadioButton rbtDomicilio = new();
    private readonly CheckBox chkGps = new();
    private readonly Label lblEncabezado = new();
    private readonly ListBox lstAlquileres = new();
    private readonly Label lblSubtotal = new();
    private readonly Label lblDescuento = new();
    private readonly Label lblDomicilio = new();
    private readonly Label lblItbis = new();
    private readonly Label lblTotal = new();
    private readonly Button btnAgregar = new();
    private readonly Button btnCalcular = new();
    private readonly Button btnLimpiar = new();
    private readonly Button btnSalir = new();

    private decimal subtotalAcumulado;
    private TableLayoutPanel root;
    private TableLayoutPanel left;
    private Label heading;
    private GroupBox dataGroup;
    private TableLayoutPanel data;
    private FlowLayoutPanel tariffDays;
    private Label daysLabel;
    private TableLayoutPanel options;
    private GroupBox insurance;
    private FlowLayoutPanel insuranceFlow;
    private GroupBox delivery;
    private FlowLayoutPanel deliveryFlow;
    private Label note;
    private TableLayoutPanel right;
    private TableLayoutPanel summary;
    private FlowLayoutPanel actions;
    private readonly CultureInfo culturaRD = CultureInfo.GetCultureInfo("es-DO");

    public frmAlquiler()
    {
        InitializeComponent();
        Load += FrmAlquiler_Load;
        btnAgregar.Click += BtnAgregar_Click;
        btnCalcular.Click += BtnCalcular_Click;
        btnLimpiar.Click += BtnLimpiar_Click;
        btnSalir.Click += BtnSalir_Click;
    }

    private void InitializeComponent()
    {
        root = new TableLayoutPanel();
        left = new TableLayoutPanel();
        heading = new Label();
        dataGroup = new GroupBox();
        data = new TableLayoutPanel();
        tariffDays = new FlowLayoutPanel();
        daysLabel = new Label();
        options = new TableLayoutPanel();
        insurance = new GroupBox();
        insuranceFlow = new FlowLayoutPanel();
        delivery = new GroupBox();
        deliveryFlow = new FlowLayoutPanel();
        note = new Label();
        right = new TableLayoutPanel();
        summary = new TableLayoutPanel();
        actions = new FlowLayoutPanel();
        root.SuspendLayout();
        left.SuspendLayout();
        dataGroup.SuspendLayout();
        data.SuspendLayout();
        tariffDays.SuspendLayout();
        options.SuspendLayout();
        insurance.SuspendLayout();
        delivery.SuspendLayout();
        right.SuspendLayout();
        SuspendLayout();
        // 
        // root
        // 
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49F));
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51F));
        root.Controls.Add(left, 0, 0);
        root.Controls.Add(right, 1, 0);
        root.Controls.Add(actions, 0, 1);
        root.Location = new Point(0, 0);
        root.Name = "root";
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
        root.Size = new Size(200, 100);
        root.TabIndex = 0;
        // 
        // left
        // 
        left.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        left.Controls.Add(heading, 0, 0);
        left.Controls.Add(dataGroup, 0, 1);
        left.Controls.Add(options, 0, 2);
        left.Controls.Add(note, 0, 3);
        left.Location = new Point(3, 3);
        left.Name = "left";
        left.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        left.RowStyles.Add(new RowStyle(SizeType.Absolute, 205F));
        left.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
        left.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        left.Size = new Size(92, 22);
        left.TabIndex = 0;
        // 
        // heading
        // 
        heading.Location = new Point(3, 0);
        heading.Name = "heading";
        heading.Size = new Size(86, 23);
        heading.TabIndex = 0;
        // 
        // dataGroup
        // 
        dataGroup.Controls.Add(data);
        dataGroup.Location = new Point(3, 41);
        dataGroup.Name = "dataGroup";
        dataGroup.Size = new Size(86, 100);
        dataGroup.TabIndex = 1;
        dataGroup.TabStop = false;
        // 
        // data
        // 
        data.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
        data.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        data.Controls.Add(tariffDays, 1, 4);
        data.Location = new Point(0, 0);
        data.Name = "data";
        data.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        data.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        data.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        data.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        data.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        data.Size = new Size(200, 100);
        data.TabIndex = 0;
        // 
        // tariffDays
        // 
        tariffDays.Controls.Add(daysLabel);
        tariffDays.Location = new Point(103, 83);
        tariffDays.Name = "tariffDays";
        tariffDays.Size = new Size(94, 14);
        tariffDays.TabIndex = 0;
        // 
        // daysLabel
        // 
        daysLabel.Location = new Point(3, 0);
        daysLabel.Name = "daysLabel";
        daysLabel.Size = new Size(100, 23);
        daysLabel.TabIndex = 0;
        // 
        // options
        // 
        options.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        options.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        options.Controls.Add(insurance, 0, 0);
        options.Controls.Add(delivery, 1, 0);
        options.Location = new Point(3, 246);
        options.Name = "options";
        options.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        options.Size = new Size(86, 100);
        options.TabIndex = 2;
        // 
        // insurance
        // 
        insurance.Controls.Add(insuranceFlow);
        insurance.Location = new Point(3, 3);
        insurance.Name = "insurance";
        insurance.Size = new Size(37, 94);
        insurance.TabIndex = 0;
        insurance.TabStop = false;
        // 
        // insuranceFlow
        // 
        insuranceFlow.Location = new Point(0, 0);
        insuranceFlow.Name = "insuranceFlow";
        insuranceFlow.Size = new Size(200, 100);
        insuranceFlow.TabIndex = 0;
        // 
        // delivery
        // 
        delivery.Controls.Add(deliveryFlow);
        delivery.Location = new Point(46, 3);
        delivery.Name = "delivery";
        delivery.Size = new Size(37, 94);
        delivery.TabIndex = 1;
        delivery.TabStop = false;
        // 
        // deliveryFlow
        // 
        deliveryFlow.Location = new Point(0, 0);
        deliveryFlow.Name = "deliveryFlow";
        deliveryFlow.Size = new Size(200, 100);
        deliveryFlow.TabIndex = 0;
        // 
        // note
        // 
        note.Location = new Point(3, 408);
        note.Name = "note";
        note.Size = new Size(86, 1);
        note.TabIndex = 3;
        // 
        // right
        // 
        right.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        right.Controls.Add(summary, 0, 3);
        right.Location = new Point(101, 3);
        right.Name = "right";
        right.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        right.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        right.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        right.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
        right.Size = new Size(96, 22);
        right.TabIndex = 1;
        // 
        // summary
        // 
        summary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
        summary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
        summary.Location = new Point(3, -145);
        summary.Name = "summary";
        summary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        summary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        summary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        summary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        summary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        summary.Size = new Size(90, 100);
        summary.TabIndex = 0;
        // 
        // actions
        // 
        root.SetColumnSpan(actions, 2);
        actions.Location = new Point(3, 31);
        actions.Name = "actions";
        actions.Size = new Size(194, 66);
        actions.TabIndex = 2;
        // 
        // frmAlquiler
        // 
        BackColor = Color.FromArgb(246, 247, 249);
        ClientSize = new Size(1230, 709);
        Controls.Add(root);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(1020, 660);
        Name = "frmAlquiler";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "RentaCar Express - Alquiler de vehículos";
        root.ResumeLayout(false);
        left.ResumeLayout(false);
        dataGroup.ResumeLayout(false);
        data.ResumeLayout(false);
        tariffDays.ResumeLayout(false);
        options.ResumeLayout(false);
        insurance.ResumeLayout(false);
        delivery.ResumeLayout(false);
        right.ResumeLayout(false);
        ResumeLayout(false);
    }

    private static void AddFieldLabel(TableLayoutPanel panel, string caption, int row)
    {
        panel.Controls.Add(new Label { Text = caption, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, row);
    }

    private static void AddSummaryRow(TableLayoutPanel panel, string caption, Label value, int row, bool bold = false)
    {
        panel.Controls.Add(new Label
        {
            Text = caption, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft,
            Font = new Font("Segoe UI", 9F, bold ? FontStyle.Bold : FontStyle.Regular)
        }, 0, row);
        value.Text = "RD$ 0.00";
        value.Dock = DockStyle.Fill;
        value.TextAlign = ContentAlignment.MiddleRight;
        value.BorderStyle = BorderStyle.FixedSingle;
        value.BackColor = Color.White;
        value.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        value.ForeColor = bold ? Color.DarkGreen : Color.FromArgb(35, 45, 60);
        panel.Controls.Add(value, 1, row);
    }

    private static void StyleButton(Button button, string caption, Color color)
    {
        button.Text = caption; button.Height = 38;
        button.FlatStyle = FlatStyle.Flat; button.FlatAppearance.BorderSize = 0;
        button.BackColor = color; button.ForeColor = Color.White;
        button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button.Margin = new Padding(4); button.Cursor = Cursors.Hand;
    }

    private void FrmAlquiler_Load(object? sender, EventArgs e)
    {
        dtpSalida.Value = DateTime.Today;
        rbtBasico.Checked = true;
        rbtSucursal.Checked = true;
        nudDias.Value = 1;
        subtotalAcumulado = 0m;
        ActualizarSubtotal();
        ActualizarResultados(0m, 0m, 0m, 0m);
        txtCliente.Focus();
    }

    private void BtnAgregar_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCliente.Text))
        {
            MessageBox.Show("Por favor, escriba el nombre del cliente.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCliente.Focus(); return;
        }
        if (string.IsNullOrWhiteSpace(txtVehiculo.Text))
        {
            MessageBox.Show("Por favor, escriba el nombre del vehículo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtVehiculo.Focus(); return;
        }
        if (!TryParseMoney(txtTarifa.Text, out decimal tarifa) || tarifa <= 0m)
        {
            MessageBox.Show("Por favor, escriba una tarifa diaria válida, mayor que cero.", "Tarifa no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTarifa.Focus(); return;
        }

        int dias = (int)nudDias.Value;
        decimal tarifaDiaria = tarifa + (rbtCompleto.Checked ? 300m : 0m) + (chkGps.Checked ? 100m : 0m);
        decimal totalLinea = tarifaDiaria * dias;
        string seguro = rbtCompleto.Checked ? "Completo" : "Básico";
        string nombreVehiculo = chkGps.Checked ? $"{txtVehiculo.Text.Trim()} (GPS)" : $"{txtVehiculo.Text.Trim()} ({seguro})";

        lstAlquileres.Items.Add(FormatearColumnas(
            dias.ToString(CultureInfo.InvariantCulture), nombreVehiculo,
            tarifaDiaria.ToString("N2", culturaRD), totalLinea.ToString("N2", culturaRD)));

        subtotalAcumulado += totalLinea;
        ActualizarSubtotal();

        txtVehiculo.Clear(); txtTarifa.Clear(); nudDias.Value = 1;
        rbtBasico.Checked = true; chkGps.Checked = false;
        txtVehiculo.Focus();
    }

    private void BtnCalcular_Click(object? sender, EventArgs e)
    {
        if (lstAlquileres.Items.Count == 0 || subtotalAcumulado <= 0m)
        {
            MessageBox.Show("Debe agregar por lo menos un vehículo antes de calcular el total.",
                "Sin vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        decimal descuento = chkCorporativo.Checked ? subtotalAcumulado * 0.15m : 0m;
        decimal domicilio = rbtDomicilio.Checked ? 500m : 0m;
        decimal baseImponible = subtotalAcumulado - descuento + domicilio;
        decimal itbis = baseImponible * 0.18m;
        decimal total = baseImponible + itbis;
        ActualizarResultados(descuento, domicilio, itbis, total);
    }

    private void BtnLimpiar_Click(object? sender, EventArgs e)
    {
        txtCliente.Clear(); txtVehiculo.Clear(); txtTarifa.Clear();
        dtpSalida.Value = DateTime.Today;
        chkCorporativo.Checked = false; chkGps.Checked = false;
        rbtBasico.Checked = true; rbtSucursal.Checked = true;
        nudDias.Value = 1; lstAlquileres.Items.Clear();
        subtotalAcumulado = 0m;
        ActualizarSubtotal(); ActualizarResultados(0m, 0m, 0m, 0m);
        txtCliente.Focus();
    }

    private void BtnSalir_Click(object? sender, EventArgs e)
    {
        DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?",
            "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (respuesta == DialogResult.Yes) Close();
    }

    private bool TryParseMoney(string value, out decimal result)
    {
        value = value.Trim().Replace("RD$", "", StringComparison.OrdinalIgnoreCase).Trim();
        return decimal.TryParse(value, NumberStyles.Number, culturaRD, out result)
            || decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out result);
    }

    private static string FormatearColumnas(string dias, string vehiculo, string tarifa, string total)
    {
        string nombre = vehiculo.Length > 24 ? vehiculo[..24] : vehiculo;
        return dias.PadRight(6) + nombre.PadRight(24) + tarifa.PadLeft(10) + total.PadLeft(12);
    }

    private void ActualizarSubtotal() => lblSubtotal.Text = subtotalAcumulado.ToString("C2", culturaRD);

    private void ActualizarResultados(decimal descuento, decimal domicilio, decimal itbis, decimal total)
    {
        lblDescuento.Text = descuento.ToString("C2", culturaRD);
        lblDomicilio.Text = domicilio.ToString("C2", culturaRD);
        lblItbis.Text = itbis.ToString("C2", culturaRD);
        lblTotal.Text = total.ToString("C2", culturaRD);
    }
}
