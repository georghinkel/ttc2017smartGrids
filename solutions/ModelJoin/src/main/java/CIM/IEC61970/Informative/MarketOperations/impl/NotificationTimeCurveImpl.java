/**
 */
package CIM.IEC61970.Informative.MarketOperations.impl;

import CIM.IEC61970.Core.impl.CurveImpl;

import CIM.IEC61970.Informative.MarketOperations.GeneratingBid;
import CIM.IEC61970.Informative.MarketOperations.MarketOperationsPackage;
import CIM.IEC61970.Informative.MarketOperations.NotificationTimeCurve;

import java.util.Collection;

import org.eclipse.emf.common.notify.NotificationChain;

import org.eclipse.emf.common.util.EList;

import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.InternalEObject;

import org.eclipse.emf.ecore.util.EObjectWithInverseResolvingEList;
import org.eclipse.emf.ecore.util.InternalEList;

/**
 * <!-- begin-user-doc -->
 * An implementation of the model object '<em><b>Notification Time Curve</b></em>'.
 * <!-- end-user-doc -->
 * <p>
 * The following features are implemented:
 * </p>
 * <ul>
 *   <li>{@link CIM.IEC61970.Informative.MarketOperations.impl.NotificationTimeCurveImpl#getGeneratingBids <em>Generating Bids</em>}</li>
 * </ul>
 *
 * @generated
 */
public class NotificationTimeCurveImpl extends CurveImpl implements NotificationTimeCurve {
	/**
	 * The cached value of the '{@link #getGeneratingBids() <em>Generating Bids</em>}' reference list.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #getGeneratingBids()
	 * @generated
	 * @ordered
	 */
	protected EList<GeneratingBid> generatingBids;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	protected NotificationTimeCurveImpl() {
		super();
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	protected EClass eStaticClass() {
		return MarketOperationsPackage.Literals.NOTIFICATION_TIME_CURVE;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EList<GeneratingBid> getGeneratingBids() {
		if (generatingBids == null) {
			generatingBids = new EObjectWithInverseResolvingEList<GeneratingBid>(GeneratingBid.class, this, MarketOperationsPackage.NOTIFICATION_TIME_CURVE__GENERATING_BIDS, MarketOperationsPackage.GENERATING_BID__NOTIFICATION_TIME_CURVE);
		}
		return generatingBids;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@SuppressWarnings("unchecked")
	@Override
	public NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
		switch (featureID) {
			case MarketOperationsPackage.NOTIFICATION_TIME_CURVE__GENERATING_BIDS:
				return ((InternalEList<InternalEObject>)(InternalEList<?>)getGeneratingBids()).basicAdd(otherEnd, msgs);
		}
		return super.eInverseAdd(otherEnd, featureID, msgs);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
		switch (featureID) {
			case MarketOperationsPackage.NOTIFICATION_TIME_CURVE__GENERATING_BIDS:
				return ((InternalEList<?>)getGeneratingBids()).basicRemove(otherEnd, msgs);
		}
		return super.eInverseRemove(otherEnd, featureID, msgs);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public Object eGet(int featureID, boolean resolve, boolean coreType) {
		switch (featureID) {
			case MarketOperationsPackage.NOTIFICATION_TIME_CURVE__GENERATING_BIDS:
				return getGeneratingBids();
		}
		return super.eGet(featureID, resolve, coreType);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@SuppressWarnings("unchecked")
	@Override
	public void eSet(int featureID, Object newValue) {
		switch (featureID) {
			case MarketOperationsPackage.NOTIFICATION_TIME_CURVE__GENERATING_BIDS:
				getGeneratingBids().clear();
				getGeneratingBids().addAll((Collection<? extends GeneratingBid>)newValue);
				return;
		}
		super.eSet(featureID, newValue);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public void eUnset(int featureID) {
		switch (featureID) {
			case MarketOperationsPackage.NOTIFICATION_TIME_CURVE__GENERATING_BIDS:
				getGeneratingBids().clear();
				return;
		}
		super.eUnset(featureID);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public boolean eIsSet(int featureID) {
		switch (featureID) {
			case MarketOperationsPackage.NOTIFICATION_TIME_CURVE__GENERATING_BIDS:
				return generatingBids != null && !generatingBids.isEmpty();
		}
		return super.eIsSet(featureID);
	}

} //NotificationTimeCurveImpl
