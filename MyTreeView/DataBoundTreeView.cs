using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MyTreeView
{
    public class DataBoundTreeView : UserControl
    {
        private Container components = null;

        public DataBoundTreeView()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Design Generated Code

        private void InitializeComponent()
        {
            this._treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // _treeView
            // 
            this._treeView.Cursor = System.Windows.Forms.Cursors.Cross;
            this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeView.FullRowSelect = true;
            this._treeView.HideSelection = false;
            this._treeView.HotTracking = true;
            this._treeView.LineColor = System.Drawing.Color.Blue;
            this._treeView.Location = new System.Drawing.Point(0, 0);
            this._treeView.Name = "_treeView";
            this._treeView.ShowNodeToolTips = true;
            this._treeView.Size = new System.Drawing.Size(193, 370);
            this._treeView.TabIndex = 0;
            // 
            // DataBoundTreeView
            // 
            this.Controls.Add(this._treeView);
            this.Name = "DataBoundTreeView";
            this.Size = new System.Drawing.Size(193, 370);
            this.ResumeLayout(false);

        }

        #endregion

        #region Public Properties and Methods

        public void LoadTree(DataSet dataSet, TableBinding[] tableBindings)
        {
            _tableBindings = tableBindings;

            _treeView.Nodes.Clear();

            handlerPositionChanged = new EventHandler(cm_PositionChanged);

            handleAfterSelect = new TreeViewEventHandler(tv_AfterSelect);

            handlerListChanged = new ListChangedEventHandler(cm_ListChanged);

            SetEvents(dataSet, false);

            foreach (DataTable dt in dataSet.Tables)
            {
                if (dt.ParentRelations.Count == 0)
                    AddParentNodes(dt, _treeView.Nodes);
            }

            //Wire back up PositionChangedEvents
            SetEvents(dataSet, true);

            //Wire up AfterSelect for our newly loaded TreeView
            _treeView.AfterSelect += handleAfterSelect;

            //Start the UI with the first node selected.
            if (_treeView.Nodes.Count > 0)
            {
                _treeView.SelectedNode = _treeView.Nodes[0];

                TreeNode node = _treeView.SelectedNode;

                //Since Child lists (IBindingList) are always changing, handle the ListChanged for each. 
                while (node.Nodes.Count > 0)
                {
                    ((IBindingList)((BoundTreeNode)node.Nodes[0]).CurrencyManager.List).ListChanged -= handlerListChanged;
                    ((IBindingList)((BoundTreeNode)node.Nodes[0]).CurrencyManager.List).ListChanged += handlerListChanged;
                    node = node.Nodes[0];
                }
            }
        }//Complete

        public void SetEvents(DataSet dataSet, bool on)
        {
            //For every "Parent Only" table
            foreach (DataTable dt in dataSet.Tables)
            {
                //no ancestors
                if (dt.ParentRelations.Count == 0)
                {
                    if (on)
                    {
                        WirePositionChanged(dt, dt.TableName);
                    }
                    else
                    {
                        UnwirePositionChanged(dt, dt.TableName);
                    }
                }
            }
        }//Complete

        /// <summary>
        /// Allow access to the underlying TreeView
        /// </summary>
        /// <value>The TreeView.</value>
        public TreeView TreeView { get { return _treeView; } }//Complete

        #endregion

        #region Private Properties and Methods

        private TreeView _treeView;
        private TableBinding[] _tableBindings;
        private bool DisablePositionChanged = true;
        private TreeViewEventHandler handleAfterSelect = null;
        private EventHandler handlerPositionChanged = null;
        private ListChangedEventHandler handlerListChanged = null;

        private void UnwirePositionChanged(DataTable dt, string navigationPath)
        {
            //Get the CurrencyManager and remove the handler
            CurrencyManager cm = (CurrencyManager)BindingContext[dt.DataSet, navigationPath];
            cm.PositionChanged -= handlerPositionChanged;

            foreach (DataRelation relation in dt.ChildRelations)
                UnwirePositionChanged(relation.ChildTable, navigationPath + "." + relation.RelationName);
        }//Complete

        private void WirePositionChanged(DataTable dt, string navigationPath)
        {
            //Get CurrencyManager and apply handler
            CurrencyManager cm = (CurrencyManager)BindingContext[dt.DataSet, navigationPath];
            cm.PositionChanged += handlerPositionChanged;

            //Do the same for child relations
            foreach (DataRelation relation in dt.ChildRelations)
                WirePositionChanged(relation.ChildTable, dt.TableName);
        }//Complete

        private void AddParentNodes(DataTable dt, TreeNodeCollection nodes)
        {
            CurrencyManager cmParent = (CurrencyManager)BindingContext[dt.DataSet, dt.TableName];

            int i = 0;
            foreach (object rowParent in cmParent.List)
            {
                DataRowView drvParent = (DataRowView)rowParent;
                BoundTreeNode nodeParent = CreateNode(drvParent, cmParent, i);
                nodes.Add(nodeParent);
                cmParent.Position = i;

                AddChildNodes(dt, nodeParent, dt.TableName);

                i++;
            }
        }//Complete

        private void AddChildNodes(DataTable dt, BoundTreeNode nodeParent, string relationName)
        {
            foreach (DataRelation relation in dt.ChildRelations)
            {
                CurrencyManager cmChild = (CurrencyManager)BindingContext[dt.DataSet, relationName + "." + relation.RelationName];

                //Again, "i" will provide a position counter
                int i = 0;
                foreach (object rowChild in cmChild.List)
                {
                    //Unbox the DataRowView, create the custom node (BoundTreeNode) and add it to the TreeView.
                    DataRowView drvChild = (DataRowView)rowChild;
                    BoundTreeNode nodeChild = CreateNode(drvChild, cmChild, i);

                    //Add it to the parent nodes node collection. 
                    nodeParent.Nodes.Add(nodeChild);
                    cmChild.Position = i;

                    //Now we add the children for the current Child row (GrandChildren)...
                    AddChildNodes(relation.ChildTable, nodeChild, relationName + "." + relation.RelationName);

                    i++;
                }
            }
        }

        /// <summary>
        /// Mechanism to build a custom BoundTreeNode, supplies the data, currency and position...
        /// </summary>
        /// <param name="drv">The DRV.</param>
        /// <param name="cm">The cm.</param>
        /// <param name="position">The position.</param>
        /// <returns>BoundTreeNode.</returns>
        private BoundTreeNode CreateNode(DataRowView drv, CurrencyManager cm, int position)
        {
            TableBinding tableBinding = GetBinding(drv.Row.Table.TableName);

            BoundTreeNode node = null;

            if (tableBinding != null)
                node = new BoundTreeNode(drv[tableBinding.DisplayMember].ToString(), drv[tableBinding.ValueMember], cm, position, tableBinding.ImageIndex, tableBinding.SelectedImageIndex);
            else
                node = new BoundTreeNode(drv[0].ToString(), drv[0], cm, position, -1, -1);

            return node;

        }//Complete

        private TableBinding GetBinding(string tableName)
        {
            // Each table can have one and only one binding
            foreach (TableBinding binding in _tableBindings)
            {
                if (binding.TableName == tableName)
                    return binding;
            }

            return null;
        }

        #endregion

        /// <summary>
        /// Some data in the lists has changed, we may need to update the TreeView Display
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ListChangedEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void cm_ListChanged(object sender, ListChangedEventArgs e)
        {
            Console.WriteLine("cm_ListChanged!");

            // Cast the sender to a DataView 
            DataView dv = (DataView)sender;

            // Get the DataRowView of the newly selected row in the List. 
            DataRowView drv = (DataRowView)dv[e.NewIndex];
            DataRow dr = drv.Row;

            // Start searching the tree with the base nodes collection
            TreeNodeCollection nodes = _treeView.Nodes;
            BoundTreeNode node = null;
            TableBinding tableBinding;

            // TableBinding tells us what the field in the datarow is that will be
            // compared to the tag value in the node and what the display value is
            tableBinding = GetBinding(dr.Table.TableName);

            //Find the node
            if (tableBinding != null)
            {
                node = SelectNode(dr[tableBinding.ValueMember], nodes);
                node.Text = dr[tableBinding.DisplayMember].ToString();
                //this._treeView.SelectedNode = node;// This selects nodes from position only in current key...
            }
            else
            {
                node = SelectNode(dr[0], nodes);
                node.Text = dr[0].ToString();
            }
        }

        /// <summary>
        /// When the BoundTreeView's nodes are selected, we must synchronize the CurrencyManagers...
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TreeViewEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // We have to move the currency manager positions for every node in the
            // selected heirarchy because the parent node selection determines the
            // currency manager "list" contents for the children
            ArrayList nodeList = new ArrayList();

            //Start with the node that has been selected
            BoundTreeNode node = (BoundTreeNode)((TreeView)sender).SelectedNode;
            nodeList.Add(node);

            //Recursively add all the parent nodes
            node = (BoundTreeNode)node.Parent;
            while (node != null)
            {
                nodeList.Add(node);
                node = (BoundTreeNode)node.Parent;
            }

            // Don't fire the our own position change event other controls bound to the 
            // currency managers will move accordingly because we are setting the position
            // explicitly. 
            DisablePositionChanged = true;

            // Start at the root node
            for (int i = nodeList.Count; i > 0; i--)
            {
                node = (BoundTreeNode)nodeList[i - 1];
                ((IBindingList)node.CurrencyManager.List).ListChanged -= handlerListChanged;
                node.CurrencyManager.Position = node.Position;
                ((IBindingList)node.CurrencyManager.List).ListChanged += handlerListChanged;
            }
            DisablePositionChanged = false;
        }//Complete

        /// <summary>
        /// When the CurrencyManagers change position we must reposition the TreeView...
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void cm_PositionChanged(object sender, EventArgs e)
        {
            // Manually disable this if we are changing position from tv_AfterSelect
            if (!DisablePositionChanged)
            {
                CurrencyManager cm = (CurrencyManager)sender;

                // The position may be -1 if the list is empty
                if (cm.Position >= 0)
                {
                    DataRowView drv = (DataRowView)((DataView)cm.List)[cm.Position];
                    DataRow dr = drv.Row;

                    // Other controls may allow adding rows that are inaccessable.
                    if (dr.RowState != DataRowState.Detached)
                    {
                        //Start with selected row
                        ArrayList dataRows = new ArrayList();
                        dataRows.Add(dr);

                        //We have to select the parents first so that we only search the
                        //specific lineage when we call SelectNode
                        while (dr.Table.ParentRelations.Count > 0)
                        {
                            dr = dr.GetParentRow(dr.Table.ParentRelations[0]);
                            dataRows.Add(dr);
                        }

                        //Start searching the tree with the base nodes collection. 
                        TreeNodeCollection nodes = _treeView.Nodes;
                        BoundTreeNode node = null;
                        TableBinding tableBinding;

                        //Select the highest parent and then the subsequent children from 
                        //the returned node's collection of children.

                        //Start with the highest datarow in the heirarchy
                        for (int i = dataRows.Count; i > 0; i--)
                        {
                            dr = (DataRow)dataRows[i - 1];

                            //TableBinding tells us what the field in the datarow is that will be 
                            //compared to the tag value in the node
                            tableBinding = GetBinding(dr.Table.TableName);

                            //Find the node and then search for its children for the next datarow
                            if (tableBinding != null)
                                node = SelectNode(dr[tableBinding.ValueMember], nodes);
                            else
                                node = SelectNode(dr[0], nodes);

                            //The next nodes collection to search
                            nodes = node.Nodes;
                        }

                        // We're going to move the tree node selection here, but we don't want
                        // the AfterSelect event to be handled because it would fire the
                        // currency manager PositionChanged event reciprocally
                        _treeView.AfterSelect -= handleAfterSelect;
                        _treeView.SelectedNode = node;
                        _treeView.AfterSelect += handleAfterSelect;

                        //The (IBindingList) has changed, so wire up the child lists to the handler. 
                        while (node.Nodes.Count > 0)
                        {
                            ((IBindingList)((BoundTreeNode)node.Nodes[0]).CurrencyManager.List).ListChanged -= handlerListChanged;
                            ((IBindingList)((BoundTreeNode)node.Nodes[0]).CurrencyManager.List).ListChanged += handlerListChanged;
                            node = (BoundTreeNode)node.Nodes[0];
                        }
                    }
                }
            }
        }//Complete

        /// <summary>
        /// Called recursively. The search is performed left to right and then down the tree.
        /// </summary>
        /// <param name="item">The node selected.</param>
        /// <param name="nodes">The nodes.</param>
        /// <returns>TreeNode.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        private BoundTreeNode SelectNode(object item, TreeNodeCollection nodes)
        {
            foreach (BoundTreeNode node in nodes)
            {
                //if this is the node, return it..
                if (((BoundTreeNode)node).Tag.Equals(item))
                {
                    return node;
                }

                //Current node isnt the one so search its children (possible no match)
                BoundTreeNode foundNode = SelectNode(item, node.Nodes);

                if (foundNode != null)
                    return foundNode;
            }

            //There may be no nodes found. For example, a leaf node or it just wasnt there..
            return null;
        }//Complete

    }

    /// <summary>
    /// Custom class that allows us to store more details on the TreeNode object. 
    /// </summary>
    /// <seealso cref="TreeNode" />
    public class BoundTreeNode : TreeNode
    {
        /// <summary>
        /// The table name that corresponds to the node's data. 
        /// </summary>
        private string _tableName;
        /// <summary>
        /// The CurrencyManager of the Table or Naviagation Path. 
        /// </summary>
        private CurrencyManager _cm;
        /// <summary>
        /// The position of the row in the CurrencyManager.List. 
        /// </summary>
        private int _position;

        /// <summary>
        /// Construct the node. 
        /// </summary>
        /// <param name="nodeLabel">The node label.</param>
        /// <param name="nodeValue">The node value.</param>
        /// <param name="cm">The CurrencyManager object.</param>
        /// <param name="position">The position in the CurrencyManager.List.</param>
        /// <param name="imageIndex">Index of the image.</param>
        /// <param name="selectedImageIndex">Index of the selected image.</param>
        public BoundTreeNode(string nodeLabel, object nodeValue, CurrencyManager cm, int position, int imageIndex, int selectedImageIndex)
        {
            _tableName = ((DataView)cm.List).Table.TableName;
            _position = position;
            _cm = cm;
            this.Text = nodeLabel;

            // Value for the node could be any type so store it as an object in the tag field. 
            this.Tag = nodeValue;

            this.ImageIndex = imageIndex;
            this.SelectedImageIndex = selectedImageIndex;
        }

        public object Value { get { return this.Tag; } }
        public string TableName { get { return _tableName; } }
        public int Position { get; internal set; }
        public CurrencyManager CurrencyManager { get { return _cm; } }
    }

    public class TableBinding
    {
        public string TableName;
        public string ValueMember;
        public string DisplayMember;
        public int ImageIndex;
        public int SelectedImageIndex;

        public TableBinding(string tableName, string valueMember, string displayMember)
        {
            TableName = tableName;
            ValueMember = valueMember;
            DisplayMember = displayMember;
            ImageIndex = -1;
            SelectedImageIndex = -1;
        }

        public TableBinding(string tableName, string valueMember, string displayMember, int imageIndex, int selectedImageIndex)
        {
            TableName = tableName;
            ValueMember = valueMember;
            DisplayMember = displayMember;
            ImageIndex = imageIndex;
            SelectedImageIndex = selectedImageIndex;
        }

    }
}
